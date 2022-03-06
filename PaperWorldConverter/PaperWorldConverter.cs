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
    }
}
