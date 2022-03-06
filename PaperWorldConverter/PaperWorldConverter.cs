﻿using fNbt;
using Ookii.Dialogs.WinForms;
using System;
using System.IO;
using System.Windows.Forms;

namespace PaperWorldConverter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnInputWorldMain_Click(object sender, EventArgs e)
        {
            //Browse to dir based on what's in the box, if it's valid
            string browseDir = Directory.GetCurrentDirectory();
            string extgText = txtInputWorldMain.Text;
            if (File.Exists(extgText) || Directory.Exists(extgText))
            {
                browseDir = extgText;
            }
            VistaFolderBrowserDialog vofd = new VistaFolderBrowserDialog
            {
                Description = "Select World to Convert",
                UseDescriptionForTitle = true,
                SelectedPath = browseDir,
                ShowNewFolderButton = false
            };
            if (vofd.ShowDialog() == DialogResult.OK)
            {
                txtInputWorldMain.Text = vofd.SelectedPath;
            }

        }

        private void txtInputWorldMain_TextChanged(object sender, EventArgs e)
        {
            //Set values for nether and end folders based on the main world file
            lblInputWorldNether.Text = txtInputWorldMain.Text + "_nether";
            lblInputWorldEnd.Text = txtInputWorldMain.Text + "_the_end";

        }

        private void btnOutputWorld_Click(object sender, EventArgs e)
        {
            //Browse to dir based on what's in the box, if valid
            string browseDir = Directory.GetCurrentDirectory();
            string extgText = txtOutputWorld.Text;
            if (File.Exists(extgText) || Directory.Exists(extgText))
            {
                browseDir = extgText;
            }
            VistaFolderBrowserDialog vofd = new VistaFolderBrowserDialog
            {
                Description = "Select Output World",
                UseDescriptionForTitle = true,
                SelectedPath = browseDir,
                ShowNewFolderButton = true
            };
            if (vofd.ShowDialog() == DialogResult.OK)
            {
                txtOutputWorld.Text = vofd.SelectedPath;
            }
        }

        private void disableControls()
        {
            txtInputWorldMain.Enabled = false;
            btnInputWorldMain.Enabled = false;

            cbxDeleteInputWorld.Enabled = false;

            txtOutputWorld.Enabled = false;
            btnOutputWorld.Enabled = false;

            btnConvert.Enabled = false;
        }

        private void enableControls()
        {
            txtInputWorldMain.Enabled = true;
            btnInputWorldMain.Enabled = true;

            cbxDeleteInputWorld.Enabled = true;

            txtOutputWorld.Enabled = true;
            btnOutputWorld.Enabled = true;

            btnConvert.Enabled = true;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            disableControls();
            txtStatus.AppendText("Checking folders...");

            //Check for existence of input folders
            if (!Directory.Exists(txtInputWorldMain.Text))
            {
                txtStatus.AppendText("\r\nMain world folder invalid!");
                enableControls();
                return;
            }
            if (!Directory.Exists(lblInputWorldNether.Text))
            {
                txtStatus.AppendText("\r\nNether folder invalid!");
                enableControls();
                return;
            }
            if (!Directory.Exists(lblInputWorldEnd.Text))
            {
                txtStatus.AppendText("\r\nEnd folder invalid!");
                enableControls();
                return;
            }

            //Check for existence of output folder, ask user if we should create it
            if (!Directory.Exists(txtOutputWorld.Text))
            {
                string message = "Output folder doesn't exist, create it?";
                if (MessageBox.Show(message, "Invalid Output Folder", MessageBoxButtons.YesNo) == DialogResult.OK)
                {
                    //Create output folder
                    try
                    {
                        Directory.CreateDirectory(txtOutputWorld.Text);
                    } catch (Exception exception)
                    {
                        txtStatus.AppendText("\r\nError creating output directory: " + exception.Message);
                        enableControls();
                        return;
                    }
                } else
                {
                    enableControls();
                    return;
                }
            }

            //Set up variables
            string inputWorldMain = txtInputWorldMain.Text;
            string inputWorldNether = lblInputWorldNether.Text;
            string inputWorldEnd = lblInputWorldEnd.Text;
            string outputWorldMain = txtOutputWorld.Text;
            bool deleteAfterConvert = cbxDeleteInputWorld.Checked;

            //Copy main world files to new world folder
            try
            {
                CloneDirectory(inputWorldMain, outputWorldMain);
            } catch (Exception exception)
            {
                txtStatus.AppendText("\r\nError copying world files: " + exception.Message);
                enableControls();
                return;
            }

            //Copy nether folder to DIM-1 in output
            if (!Directory.Exists(Path.Combine(inputWorldNether, "DIM-1")))
            {
                txtStatus.AppendText("\r\nNo DIM-1 folder in nether folder, can't convert world");
                enableControls();
                return;
            }
            try
            {
                CloneDirectory(Path.Combine(inputWorldNether, "DIM-1"), Path.Combine(outputWorldMain, "DIM-1"));
            } catch (Exception exception)
            {
                txtStatus.AppendText("\r\nError copying nether files: " + exception.Message);
                enableControls();
                return;
            }

            //Copy end folder to DIM-1 in output
            if (!Directory.Exists(Path.Combine(inputWorldEnd, "DIM1")))
            {
                txtStatus.AppendText("\r\nNo DIM1 folder in end dimension folder, can't convert world");
                enableControls();
                return;
            }
            try
            {
                CloneDirectory(Path.Combine(inputWorldEnd, "DIM1"), Path.Combine(outputWorldMain, "DIM1"));
            }
            catch (Exception exception)
            {
                txtStatus.AppendText("\r\nError copying end dimension files: " + exception.Message);
                enableControls();
                return;
            }

            try
            {
                //Load level.dat into NbtFile
                var levelDat = new NbtFile();
                levelDat.LoadFromFile(Path.Combine(outputWorldMain, "level.dat"));
                NbtCompound mainData = (NbtCompound)levelDat.RootTag.Get("Data");

                //Fix playerdata if necessary
                if (mainData.Contains("Player"))
                {
                    //Delete player tag
                    mainData.Remove("Player");
                }
                //Fix level name in level.dat
                string newLevelName = Path.GetFileName(outputWorldMain);
                if (mainData.Contains("LevelName"))
                {
                    mainData.Remove("LevelName");
                    mainData.Add(new NbtString("LevelName", newLevelName));
                }
                //Set and save modified data
                levelDat.RootTag = mainData;
                levelDat.SaveToFile("level.dat", NbtCompression.GZip);
            } 
            catch (Exception exception)
            {
                txtStatus.AppendText("\r\nError modifying level.dat: " + exception.Message);
                enableControls();
                return;
            }
            
            //Delete old folders if needed
            if (deleteAfterConvert)
            {
                try
                {
                    Directory.Delete(inputWorldMain);
                    Directory.Delete(inputWorldNether);
                    Directory.Delete(inputWorldEnd);
                }
                catch (Exception exception)
                {
                    txtStatus.AppendText("\r\nError deleting original folders: " + exception.Message);
                }
                
            }

            //Done!
            txtStatus.AppendText("\r\nWorld conversion complete!");
            enableControls();

        }

        private static void CloneDirectory(string originalFolder, string destFolder)
        {
            foreach (var directory in Directory.GetDirectories(originalFolder))
            {
                string dirName = Path.GetFileName(directory);
                if (!Directory.Exists(Path.Combine(destFolder, dirName)))
                {
                    Directory.CreateDirectory(Path.Combine(destFolder, dirName));
                }
                CloneDirectory(directory, Path.Combine(destFolder, dirName));
            }

            foreach (var file in Directory.GetFiles(originalFolder))
            {
                File.Copy(file, Path.Combine(destFolder, Path.GetFileName(file)));
            }
        }
    }
}
