namespace DGFukX_UI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ObfBtn = new System.Windows.Forms.Button();
            this.LuaFileLbl = new System.Windows.Forms.Label();
            this.FilePathLabel = new System.Windows.Forms.TextBox();
            this.BrowseFileBtn = new System.Windows.Forms.Button();
            this.fileBrowserDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenLogsBtn = new System.Windows.Forms.Button();
            this.ObfOptionsBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ObfBtn
            // 
            this.ObfBtn.Location = new System.Drawing.Point(93, 258);
            this.ObfBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ObfBtn.Name = "ObfBtn";
            this.ObfBtn.Size = new System.Drawing.Size(168, 52);
            this.ObfBtn.TabIndex = 1;
            this.ObfBtn.Text = "Obfuscate";
            this.ObfBtn.UseVisualStyleBackColor = true;
            this.ObfBtn.Click += new System.EventHandler(this.ObfBtn_Click);
            // 
            // LuaFileLbl
            // 
            this.LuaFileLbl.AutoSize = true;
            this.LuaFileLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LuaFileLbl.Location = new System.Drawing.Point(15, 154);
            this.LuaFileLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LuaFileLbl.Name = "LuaFileLbl";
            this.LuaFileLbl.Size = new System.Drawing.Size(54, 15);
            this.LuaFileLbl.TabIndex = 2;
            this.LuaFileLbl.Text = "Lua File:";
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.AllowDrop = true;
            this.FilePathLabel.Location = new System.Drawing.Point(80, 150);
            this.FilePathLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(195, 23);
            this.FilePathLabel.TabIndex = 3;
            this.FilePathLabel.DragDrop += new System.Windows.Forms.DragEventHandler(this.FilePathLabel_DragDrop);
            this.FilePathLabel.DragEnter += new System.Windows.Forms.DragEventHandler(this.FilePathLabel_DragEnter);
            // 
            // BrowseFileBtn
            // 
            this.BrowseFileBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BrowseFileBtn.Location = new System.Drawing.Point(281, 149);
            this.BrowseFileBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BrowseFileBtn.Name = "BrowseFileBtn";
            this.BrowseFileBtn.Size = new System.Drawing.Size(44, 28);
            this.BrowseFileBtn.TabIndex = 4;
            this.BrowseFileBtn.Text = "...";
            this.BrowseFileBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BrowseFileBtn.UseVisualStyleBackColor = true;
            this.BrowseFileBtn.Click += new System.EventHandler(this.BrowseFileBtn_Click);
            // 
            // fileBrowserDialog
            // 
            this.fileBrowserDialog.FileName = "fileBrowserDialog";
            // 
            // OpenLogsBtn
            // 
            this.OpenLogsBtn.Location = new System.Drawing.Point(189, 213);
            this.OpenLogsBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OpenLogsBtn.Name = "OpenLogsBtn";
            this.OpenLogsBtn.Size = new System.Drawing.Size(88, 27);
            this.OpenLogsBtn.TabIndex = 5;
            this.OpenLogsBtn.Text = "Logs";
            this.OpenLogsBtn.UseVisualStyleBackColor = true;
            this.OpenLogsBtn.Click += new System.EventHandler(this.OpenLogsBtn_Click);
            // 
            // ObfOptionsBtn
            // 
            this.ObfOptionsBtn.Location = new System.Drawing.Point(80, 213);
            this.ObfOptionsBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ObfOptionsBtn.Name = "ObfOptionsBtn";
            this.ObfOptionsBtn.Size = new System.Drawing.Size(88, 27);
            this.ObfOptionsBtn.TabIndex = 6;
            this.ObfOptionsBtn.Text = "Options";
            this.ObfOptionsBtn.UseVisualStyleBackColor = true;
            this.ObfOptionsBtn.Click += new System.EventHandler(this.ObfOptionsBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(93, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 329);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ObfOptionsBtn);
            this.Controls.Add(this.OpenLogsBtn);
            this.Controls.Add(this.BrowseFileBtn);
            this.Controls.Add(this.FilePathLabel);
            this.Controls.Add(this.LuaFileLbl);
            this.Controls.Add(this.ObfBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[LUA] DGFukscator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ObfBtn;
        private System.Windows.Forms.TextBox FilePathLabel;
        private System.Windows.Forms.Label LuaFileLbl;
        private System.Windows.Forms.Button BrowseFileBtn;
        private System.Windows.Forms.OpenFileDialog fileBrowserDialog;
        private System.Windows.Forms.Button OpenLogsBtn;
        private System.Windows.Forms.Button ObfOptionsBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

