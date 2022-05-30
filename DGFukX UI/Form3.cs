using System;
using System.Windows.Forms;
using DGFukX_CLI;

namespace DGFukX_UI
{
    public partial class Form3 : Form
    {
        public static int decryptTableLength;
        public static bool bytecodeCompression;
        public static bool lineInfoPreservation;
        public static bool controlFlow;

        //String Encryption
        public static bool stringEncryption;
        public static bool impStringEncryption;

        //Super Operators
        public static bool superOperators;
        public static int maxSuperOperators;

        //Mutations
        public static bool mutations;
        public static int maxMutations;

        public Form3()
        {
            InitializeComponent();
            LoadDefaultSettings();
        }

        private void LoadDefaultSettings()
        {
            controlFlow = true;

            lineInfoPreservation = false;

            bytecodeCompression = true;

            decryptTableLength = 495;

            stringEncryption = false;
            impStringEncryption = true;

            superOperators = true;
            maxSuperOperators = 155;

            mutations = true;
            maxMutations = 260;

            dtlLbl.Text = decryptTableLength.ToString();
            mutationsLbl.Text = maxMutations.ToString();
            supOperLbl.Text = maxSuperOperators.ToString();

            contFlowCheck.Checked = controlFlow;
            strEncCheck.Checked = stringEncryption;
            impStrEncCheck.Checked = impStringEncryption;
            bcCompCheck.Checked = bytecodeCompression;
            prsvILineInfoCheck.Checked = lineInfoPreservation;

            DGFukX_CLI.Program.SetCustomObfuscationSettings(stringEncryption, impStringEncryption, controlFlow, bytecodeCompression, decryptTableLength, lineInfoPreservation, mutations, superOperators, maxSuperOperators, maxSuperOperators, maxMutations);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //LoadDefaultSettings();
        }

        private void AppOptBtn_Click(object sender, EventArgs e)
        {
            DGFukX_CLI.Program.SetCustomObfuscationSettings(stringEncryption, impStringEncryption, controlFlow, bytecodeCompression, decryptTableLength, lineInfoPreservation, mutations, superOperators, maxSuperOperators, maxSuperOperators, maxMutations);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDefaultSettings();
        }

        private void dtlLbl_TextChanged(object sender, EventArgs e)
        {
            decryptTableLength = Int32.Parse(dtlLbl.Text);
        }

        private void mutationsLbl_TextChanged(object sender, EventArgs e)
        {
            if(dtlLbl.Text == "")
            {
                dtlLbl.Text = "0";
            }
            var nrOfMutations = Int32.Parse(dtlLbl.Text);
            maxMutations = nrOfMutations;
            if (nrOfMutations == 0)
            {
                mutations = true;
            }
            else
            {
                mutations = false;
            }
        }

        private void supOperLbl_TextChanged(object sender, EventArgs e)
        {
            if (supOperLbl.Text == "")
            {
                supOperLbl.Text = "0";
            }
            var nrOfOperators = Int32.Parse(supOperLbl.Text);
            maxSuperOperators = nrOfOperators;
            if (nrOfOperators == 0)
            {
                superOperators = true;
            }
            else
            {
                superOperators = false;
            }
        }

        private void contFlowCheck_CheckedChanged(object sender, EventArgs e)
        {
            controlFlow = contFlowCheck.Checked;
        }

        private void strEncCheck_CheckedChanged(object sender, EventArgs e)
        {
            stringEncryption = strEncCheck.Checked;
        }

        private void impStrEncCheck_CheckedChanged(object sender, EventArgs e)
        {
            impStringEncryption = impStrEncCheck.Checked;
        }

        private void bcCompCheck_CheckedChanged(object sender, EventArgs e)
        {
            bytecodeCompression = bcCompCheck.Checked;
        }

        private void prsvILineInfoCheck_CheckedChanged(object sender, EventArgs e)
        {
            lineInfoPreservation = prsvILineInfoCheck.Checked;
        }
    }
}
