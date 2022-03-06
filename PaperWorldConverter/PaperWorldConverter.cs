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
            //Check for existence of input folders
            if (!Directory.Exists(txtInputWorldMain.Text))
            {
                txtStatus.AppendText("Main world folder invalid");
                enableControls();
                return;
            }
            if (!Directory.Exists(lblInputWorldNether.Text))
            {
                txtStatus.AppendText("Nether folder invalid");
                enableControls();
                return;
            }
            if (!Directory.Exists(lblInputWorldEnd.Text))
            {
                txtStatus.AppendText("End folder invalid");
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
                        txtStatus.AppendText("Error creating output directory: " + exception.Message);
                        enableControls();
                        return;
                    }
                } else
                {
                    enableControls();
                    return;
                }
            }

        }
    }
}
