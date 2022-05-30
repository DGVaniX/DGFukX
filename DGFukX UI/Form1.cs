using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGFukX_CLI;

namespace DGFukX_UI
{
    public partial class Form1 : Form
    {
        string fileName;
        
        public Form1()
        {
            InitializeComponent();
            ObfBtn.Enabled = false;
        }

        private void OpenFileBrowser()
        {
            fileBrowserDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            fileBrowserDialog.Filter = "Lua Scripts (*.lua)|*.lua";
            fileBrowserDialog.ShowHelp = false;
            fileBrowserDialog.FileName = "";
            fileBrowserDialog.FilterIndex = 2;
            fileBrowserDialog.RestoreDirectory = true;

            if (fileBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = fileBrowserDialog.FileName;
                FilePathLabel.Text = fileName;
                ObfBtn.Enabled = true;
            }
        }
        
        private void FilePathLabel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void FilePathLabel_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop);
                FilePathLabel.Lines = fileNames;
                ObfBtn.Enabled = true;
            }
        }

        private void ObfBtn_Click(object sender, EventArgs e)
        {
            Form2 consoleLogForm = new Form2();
            consoleLogForm.Show();

            List<string> obfuscationResult = DGFukX_CLI.Program.TryObfuscation(FilePathLabel.Text);
            /*if(obfuscationResult[1] == "true")
            {

            }
            else
            {
                Form2 consoleLogForm = new Form2();
                consoleLogForm.ShowDialog();
            }*/
        }

        private void BrowseFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileBrowser();
        }

        private void OpenLogsBtn_Click(object sender, EventArgs e)
        {
            Form2 consoleLogForm = new Form2();
            consoleLogForm.ShowDialog();
        }

        private void ObfOptionsBtn_Click(object sender, EventArgs e)
        {
            Form3 optionsForm = new Form3();
            optionsForm.ShowDialog();
        }
    }
}