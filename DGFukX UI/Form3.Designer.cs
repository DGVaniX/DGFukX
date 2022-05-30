
namespace DGFukX_UI
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mutationsLbl = new System.Windows.Forms.TextBox();
            this.supOperLbl = new System.Windows.Forms.TextBox();
            this.dtlLbl = new System.Windows.Forms.TextBox();
            this.contFlowCheck = new System.Windows.Forms.CheckBox();
            this.strEncCheck = new System.Windows.Forms.CheckBox();
            this.impStrEncCheck = new System.Windows.Forms.CheckBox();
            this.bcCompCheck = new System.Windows.Forms.CheckBox();
            this.prsvILineInfoCheck = new System.Windows.Forms.CheckBox();
            this.AppOptBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 290);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "String Encryption:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 330);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Important String Encryption:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Control Flow:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 368);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bytecode Compression:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Decrypt Table Length:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 408);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Preserve Line Info:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 171);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mutations:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 211);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Super Operators:";
            // 
            // mutationsLbl
            // 
            this.mutationsLbl.Location = new System.Drawing.Point(250, 168);
            this.mutationsLbl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mutationsLbl.Name = "mutationsLbl";
            this.mutationsLbl.Size = new System.Drawing.Size(63, 23);
            this.mutationsLbl.TabIndex = 9;
            this.mutationsLbl.TextChanged += new System.EventHandler(this.mutationsLbl_TextChanged);
            // 
            // supOperLbl
            // 
            this.supOperLbl.Location = new System.Drawing.Point(250, 207);
            this.supOperLbl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.supOperLbl.Name = "supOperLbl";
            this.supOperLbl.Size = new System.Drawing.Size(63, 23);
            this.supOperLbl.TabIndex = 10;
            this.supOperLbl.TextChanged += new System.EventHandler(this.supOperLbl_TextChanged);
            // 
            // dtlLbl
            // 
            this.dtlLbl.Location = new System.Drawing.Point(250, 129);
            this.dtlLbl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtlLbl.Name = "dtlLbl";
            this.dtlLbl.Size = new System.Drawing.Size(63, 23);
            this.dtlLbl.TabIndex = 11;
            this.dtlLbl.TextChanged += new System.EventHandler(this.dtlLbl_TextChanged);
            // 
            // contFlowCheck
            // 
            this.contFlowCheck.AutoSize = true;
            this.contFlowCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contFlowCheck.Location = new System.Drawing.Point(270, 249);
            this.contFlowCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.contFlowCheck.Name = "contFlowCheck";
            this.contFlowCheck.Size = new System.Drawing.Size(15, 14);
            this.contFlowCheck.TabIndex = 12;
            this.contFlowCheck.UseVisualStyleBackColor = true;
            this.contFlowCheck.CheckedChanged += new System.EventHandler(this.contFlowCheck_CheckedChanged);
            // 
            // strEncCheck
            // 
            this.strEncCheck.AutoSize = true;
            this.strEncCheck.Location = new System.Drawing.Point(270, 290);
            this.strEncCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.strEncCheck.Name = "strEncCheck";
            this.strEncCheck.Size = new System.Drawing.Size(15, 14);
            this.strEncCheck.TabIndex = 13;
            this.strEncCheck.UseVisualStyleBackColor = true;
            this.strEncCheck.CheckedChanged += new System.EventHandler(this.strEncCheck_CheckedChanged);
            // 
            // impStrEncCheck
            // 
            this.impStrEncCheck.AutoSize = true;
            this.impStrEncCheck.Location = new System.Drawing.Point(270, 330);
            this.impStrEncCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.impStrEncCheck.Name = "impStrEncCheck";
            this.impStrEncCheck.Size = new System.Drawing.Size(15, 14);
            this.impStrEncCheck.TabIndex = 14;
            this.impStrEncCheck.UseVisualStyleBackColor = true;
            this.impStrEncCheck.CheckedChanged += new System.EventHandler(this.impStrEncCheck_CheckedChanged);
            // 
            // bcCompCheck
            // 
            this.bcCompCheck.AutoSize = true;
            this.bcCompCheck.Location = new System.Drawing.Point(270, 368);
            this.bcCompCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bcCompCheck.Name = "bcCompCheck";
            this.bcCompCheck.Size = new System.Drawing.Size(15, 14);
            this.bcCompCheck.TabIndex = 15;
            this.bcCompCheck.UseVisualStyleBackColor = true;
            this.bcCompCheck.CheckedChanged += new System.EventHandler(this.bcCompCheck_CheckedChanged);
            // 
            // prsvILineInfoCheck
            // 
            this.prsvILineInfoCheck.AutoSize = true;
            this.prsvILineInfoCheck.Location = new System.Drawing.Point(270, 408);
            this.prsvILineInfoCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.prsvILineInfoCheck.Name = "prsvILineInfoCheck";
            this.prsvILineInfoCheck.Size = new System.Drawing.Size(15, 14);
            this.prsvILineInfoCheck.TabIndex = 16;
            this.prsvILineInfoCheck.UseVisualStyleBackColor = true;
            this.prsvILineInfoCheck.CheckedChanged += new System.EventHandler(this.prsvILineInfoCheck_CheckedChanged);
            // 
            // AppOptBtn
            // 
            this.AppOptBtn.Location = new System.Drawing.Point(99, 450);
            this.AppOptBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AppOptBtn.Name = "AppOptBtn";
            this.AppOptBtn.Size = new System.Drawing.Size(88, 44);
            this.AppOptBtn.TabIndex = 17;
            this.AppOptBtn.Text = "Apply Options";
            this.AppOptBtn.UseVisualStyleBackColor = true;
            this.AppOptBtn.Click += new System.EventHandler(this.AppOptBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 450);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 44);
            this.button1.TabIndex = 18;
            this.button1.Text = "Reset Default";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(99, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 508);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AppOptBtn);
            this.Controls.Add(this.prsvILineInfoCheck);
            this.Controls.Add(this.bcCompCheck);
            this.Controls.Add(this.impStrEncCheck);
            this.Controls.Add(this.strEncCheck);
            this.Controls.Add(this.contFlowCheck);
            this.Controls.Add(this.dtlLbl);
            this.Controls.Add(this.supOperLbl);
            this.Controls.Add(this.mutationsLbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[LUA] DGFukscator | Options";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox mutationsLbl;
        private System.Windows.Forms.TextBox supOperLbl;
        private System.Windows.Forms.TextBox dtlLbl;
        private System.Windows.Forms.CheckBox contFlowCheck;
        private System.Windows.Forms.CheckBox strEncCheck;
        private System.Windows.Forms.CheckBox impStrEncCheck;
        private System.Windows.Forms.CheckBox bcCompCheck;
        private System.Windows.Forms.CheckBox prsvILineInfoCheck;
        private System.Windows.Forms.Button AppOptBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}