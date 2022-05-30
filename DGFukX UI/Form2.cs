using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGFukX;
using DGFukX_CLI;

namespace DGFukX_UI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void Form2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LogBox.Text = DGX.obfuscationLogs;
        }

        private void OpenScriptBtn_Click(object sender, EventArgs e)
        {
            DGFukX_CLI.Program.OpenCompiledScriptFile();
        }
    }
}