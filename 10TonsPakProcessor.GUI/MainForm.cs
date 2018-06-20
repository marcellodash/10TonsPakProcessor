using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

using BrokenEvent.Shared.WinApi;

namespace TenTonsPakProcessor.GUI
{
  public partial class MainForm : Form
  {
    private PakFileReader reader;
    private ExplorerIcons icons;
    private string filename;
    private const string TITLE = "10TonsPakProcessor UI";

    public MainForm()
    {
      InitializeComponent();
      icons = new ExplorerIcons(imageList, ExplorerIcons.IconSize.Small);
    }

    private void tbtnOpenPak_Click(object sender, EventArgs e)
    {
      if (openFileDialog.ShowDialog(this) != DialogResult.OK)
        return;

      OpenPak(openFileDialog.FileName);
    }

    private async void OpenPak(string filename)
    {
      Enabled = false;
      pbProgress.Visible = true;
      reader?.Dispose();

      await Task.Run(() =>reader = new PakFileReader(new FileStream(filename, FileMode.Open, FileAccess.Read)));
      BuildFilesTree();
      treeView.Enabled = btnExtractAll.Enabled = true;
      slblFile.Text = Path.GetFileName(filename);
      slblFiles.Text = $"Files: {reader.Files.Count}";

      pbProgress.Visible = false;
      Enabled = true;
      this.filename = filename;
      Text = $"{Path.GetFileName(filename)} - {TITLE}";
    }

    private TreeNodeCollection GetRootNode(string path, IDictionary<string, TreeNode> cache, TreeNodeCollection rootNodes)
    {
      string dirName = Path.GetDirectoryName(path);

      if (string.IsNullOrEmpty(dirName))
        return rootNodes;

      TreeNode result;
      if (cache.TryGetValue(dirName, out result))
        return result.Nodes;

      rootNodes = GetRootNode(dirName, cache, rootNodes);
      TreeNode node = new TreeNode(Path.GetFileName(dirName));
      rootNodes.Add(node);
      cache.Add(dirName, node);
      node.ImageIndex = node.SelectedImageIndex = icons.GetOpenedFolderIconIndex();
      return node.Nodes;
    }

    private void BuildFilesTree()
    {
      treeView.Nodes.Clear();

      Dictionary<string, TreeNode> cache = new Dictionary<string, TreeNode>();

      treeView.BeginUpdate();

      foreach (PakFileItem file in reader.Files)
      {
        TreeNode node = new TreeNode(Path.GetFileName(file.Name));
        GetRootNode(file.Name, cache, treeView.Nodes).Add(node);
        node.Tag = file;
        node.ImageIndex = node.SelectedImageIndex = icons.GetIconIndex(Path.GetExtension(file.Name));
      }

      treeView.TreeViewNodeSorter = Comparer<TreeNode>.Create(NodeComparison);
      treeView.Sort();
      treeView.EndUpdate();
    }

    private static int NodeComparison(TreeNode a, TreeNode b)
    {
      if (a.Nodes.Count > 0 && b.Nodes.Count == 0)
        return -1;
      if (a.Nodes.Count == 0 && b.Nodes.Count > 0)
        return 1;

      return string.Compare(a.Text, b.Text, StringComparison.Ordinal);
    }

    private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      reader?.Dispose();
    }

    private void MainForm_DragEnter(object sender, DragEventArgs e)
    {
      e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Move : DragDropEffects.None;
    }

    private void MainForm_DragDrop(object sender, DragEventArgs e)
    {
      if (!e.Data.GetDataPresent(DataFormats.FileDrop))
        return;

      string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
      foreach (string file in files)
        if (Path.GetExtension(file).ToLower() == ".pak")
        {
          OpenPak(file);
          return;
        }
    }

    private void Extract(string targetPath, IEnumerable<PakFileItem> items)
    {
      foreach (PakFileItem item in items)
      {
        string outputPath = Path.Combine(targetPath, item.Name);
        Directory.CreateDirectory(Path.GetDirectoryName(outputPath));
        using (FileStream stream = new FileStream(outputPath, FileMode.Create))
        {
          byte[] content = reader.GetData(item);
          stream.Write(content, 0, content.Length);
        }
      }
    }

    private async void btnExtractAll_Click(object sender, EventArgs e)
    {
      if (folderBrowserDialog.ShowDialog(this) != DialogResult.OK)
        return;

      Enabled = false;
      pbProgress.Visible = true;
      await Task.Run(() => Extract(folderBrowserDialog.SelectedPath, reader.Files));
      pbProgress.Visible = false;
      Enabled = true;
    }

    private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
    {
      btnPreview.Enabled = btnExtract.Enabled = e.Node != null;
    }

    private IEnumerable<PakFileItem> EnumerateItems(TreeNode node)
    {
      PakFileItem item = node.Tag as PakFileItem;
      if (item != null)
        yield return item;

      foreach (TreeNode n in node.Nodes)
        foreach (PakFileItem i in EnumerateItems(n))
          yield return i;
    }

    private async void btnExtract_Click(object sender, EventArgs e)
    {
      if (folderBrowserDialog.ShowDialog(this) != DialogResult.OK)
        return;

      List<PakFileItem> items = new List<PakFileItem>(EnumerateItems(treeView.SelectedNode));

      Enabled = false;
      pbProgress.Visible = true;
      await Task.Run(() => Extract(folderBrowserDialog.SelectedPath, items));
      pbProgress.Visible = false;
      Enabled = true;      
    }

    private void btnPreview_Click(object sender, EventArgs e)
    {
      if (treeView.SelectedNode == null)
        return;
      PakFileItem item = treeView.SelectedNode.Tag as PakFileItem;
      if (item == null)
        return;

      string targetPath = Path.Combine(Path.GetTempPath(), Path.GetFileName(item.Name));

      using (FileStream stream = new FileStream(targetPath, FileMode.Create))
      {
        byte[] content = reader.GetData(item);
        stream.Write(content, 0, content.Length);
      }

      Text = "Waiting for preview to close";
      ProcessStartInfo info = new ProcessStartInfo(targetPath);
      info.UseShellExecute = true;
      try
      {
        Process process = Process.Start(info);
        process.WaitForExit();
      }
      catch (Exception ex)
      {
        MessageBox.Show(this, $"Unable to preview file:\n{targetPath}\n\n{ex.Message}", "Preview Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      File.Delete(targetPath);
      Text = $"{Path.GetFileName(filename)} - {TITLE}";
    }
  }
}
