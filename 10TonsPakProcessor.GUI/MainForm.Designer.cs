﻿namespace TenTonsPakProcessor.GUI
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.toolStrip = new System.Windows.Forms.ToolStrip();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.statusStrip = new System.Windows.Forms.StatusStrip();
      this.slblFile = new System.Windows.Forms.ToolStripStatusLabel();
      this.slblFiles = new System.Windows.Forms.ToolStripStatusLabel();
      this.pbProgress = new System.Windows.Forms.ToolStripProgressBar();
      this.treeView = new System.Windows.Forms.TreeView();
      this.imageList = new System.Windows.Forms.ImageList(this.components);
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.tbtnOpenPak = new System.Windows.Forms.ToolStripButton();
      this.btnExtractAll = new System.Windows.Forms.ToolStripButton();
      this.btnExtract = new System.Windows.Forms.ToolStripButton();
      this.btnPreview = new System.Windows.Forms.ToolStripButton();
      this.btnCreateArchive = new System.Windows.Forms.ToolStripButton();
      this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
      this.toolStrip.SuspendLayout();
      this.statusStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // toolStrip
      // 
      this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnOpenPak,
            this.toolStripSeparator1,
            this.btnExtractAll,
            this.btnExtract,
            this.btnPreview,
            this.toolStripSeparator2,
            this.btnCreateArchive});
      this.toolStrip.Location = new System.Drawing.Point(0, 0);
      this.toolStrip.Name = "toolStrip";
      this.toolStrip.Size = new System.Drawing.Size(586, 25);
      this.toolStrip.TabIndex = 0;
      this.toolStrip.Text = "toolStrip1";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // statusStrip
      // 
      this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slblFile,
            this.slblFiles,
            this.pbProgress});
      this.statusStrip.Location = new System.Drawing.Point(0, 433);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.Size = new System.Drawing.Size(586, 22);
      this.statusStrip.TabIndex = 1;
      this.statusStrip.Text = "statusStrip1";
      // 
      // slblFile
      // 
      this.slblFile.AutoSize = false;
      this.slblFile.Name = "slblFile";
      this.slblFile.Size = new System.Drawing.Size(200, 17);
      this.slblFile.Text = "n/a";
      this.slblFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // slblFiles
      // 
      this.slblFiles.AutoSize = false;
      this.slblFiles.Name = "slblFiles";
      this.slblFiles.Size = new System.Drawing.Size(100, 17);
      this.slblFiles.Text = "n/a";
      this.slblFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // pbProgress
      // 
      this.pbProgress.Name = "pbProgress";
      this.pbProgress.Size = new System.Drawing.Size(100, 16);
      this.pbProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
      this.pbProgress.Visible = false;
      // 
      // treeView
      // 
      this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.treeView.Enabled = false;
      this.treeView.ImageIndex = 0;
      this.treeView.ImageList = this.imageList;
      this.treeView.Location = new System.Drawing.Point(0, 25);
      this.treeView.Name = "treeView";
      this.treeView.SelectedImageIndex = 0;
      this.treeView.Size = new System.Drawing.Size(586, 408);
      this.treeView.TabIndex = 2;
      this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
      this.treeView.DoubleClick += new System.EventHandler(this.btnPreview_Click);
      // 
      // imageList
      // 
      this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
      this.imageList.ImageSize = new System.Drawing.Size(16, 16);
      this.imageList.TransparentColor = System.Drawing.Color.Transparent;
      // 
      // openFileDialog
      // 
      this.openFileDialog.DefaultExt = "pak";
      this.openFileDialog.Filter = "10Tons PAK Files|*.pak";
      // 
      // folderBrowserDialog
      // 
      this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // tbtnOpenPak
      // 
      this.tbtnOpenPak.Image = global::TenTonsPakProcessor.GUI.Properties.Resources.Button_Open;
      this.tbtnOpenPak.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tbtnOpenPak.Name = "tbtnOpenPak";
      this.tbtnOpenPak.Size = new System.Drawing.Size(56, 22);
      this.tbtnOpenPak.Text = "Open";
      this.tbtnOpenPak.Click += new System.EventHandler(this.tbtnOpenPak_Click);
      // 
      // btnExtractAll
      // 
      this.btnExtractAll.Enabled = false;
      this.btnExtractAll.Image = global::TenTonsPakProcessor.GUI.Properties.Resources.Button_ExtractAll;
      this.btnExtractAll.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnExtractAll.Name = "btnExtractAll";
      this.btnExtractAll.Size = new System.Drawing.Size(79, 22);
      this.btnExtractAll.Text = "Extract All";
      this.btnExtractAll.Click += new System.EventHandler(this.btnExtractAll_Click);
      // 
      // btnExtract
      // 
      this.btnExtract.Enabled = false;
      this.btnExtract.Image = global::TenTonsPakProcessor.GUI.Properties.Resources.Button_Extract;
      this.btnExtract.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnExtract.Name = "btnExtract";
      this.btnExtract.Size = new System.Drawing.Size(62, 22);
      this.btnExtract.Text = "Extract";
      this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
      // 
      // btnPreview
      // 
      this.btnPreview.Enabled = false;
      this.btnPreview.Image = global::TenTonsPakProcessor.GUI.Properties.Resources.Button_Preview;
      this.btnPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnPreview.Name = "btnPreview";
      this.btnPreview.Size = new System.Drawing.Size(68, 22);
      this.btnPreview.Text = "Preview";
      this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
      // 
      // btnCreateArchive
      // 
      this.btnCreateArchive.Image = global::TenTonsPakProcessor.GUI.Properties.Resources.Button_CreateArchive;
      this.btnCreateArchive.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnCreateArchive.Name = "btnCreateArchive";
      this.btnCreateArchive.Size = new System.Drawing.Size(113, 22);
      this.btnCreateArchive.Text = "Create Archive...";
      this.btnCreateArchive.Click += new System.EventHandler(this.btnCreateArchive_Click);
      // 
      // saveFileDialog
      // 
      this.saveFileDialog.DefaultExt = "pak";
      this.saveFileDialog.Filter = "PAK files|*.pak";
      // 
      // MainForm
      // 
      this.AllowDrop = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(586, 455);
      this.Controls.Add(this.treeView);
      this.Controls.Add(this.statusStrip);
      this.Controls.Add(this.toolStrip);
      this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
      this.Text = "10TonsPakProcessor UI";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
      this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
      this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
      this.toolStrip.ResumeLayout(false);
      this.toolStrip.PerformLayout();
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip toolStrip;
    private System.Windows.Forms.ToolStripButton tbtnOpenPak;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.TreeView treeView;
    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.ToolStripStatusLabel slblFile;
    private System.Windows.Forms.ToolStripStatusLabel slblFiles;
    private System.Windows.Forms.ImageList imageList;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton btnExtractAll;
    private System.Windows.Forms.ToolStripButton btnExtract;
    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    private System.Windows.Forms.ToolStripProgressBar pbProgress;
    private System.Windows.Forms.ToolStripButton btnPreview;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton btnCreateArchive;
    private System.Windows.Forms.SaveFileDialog saveFileDialog;
  }
}

