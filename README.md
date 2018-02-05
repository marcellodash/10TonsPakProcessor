# 10TonsPakProcessor
Packer/unpacker for .pak file format as used in games by 10tons Ltd. Tested on:

* Crimsonland 2014
* Neon Chrome
* Time Recoil
* JYDGE
* Tesla vs Lovecraft.

# This Fork
Added basic UI to view package content and extract files/directories by choice.

# CLI Usage
To unpack a .pak file:

`10TonsPakProcessor -unpack someFileToUnpack.pak`

To pack the contents of a directory into a .pak file:

`10TonsPakProcessor -pack <inputDirectory> newPakFile.pak`

