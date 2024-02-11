namespace Encrypter.Decrypter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputLabel = new System.Windows.Forms.Label();
            this.EncryptBtn = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.DecryptBtn = new System.Windows.Forms.Button();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.ErrorMessageForKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(12, 9);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(35, 15);
            this.InputLabel.TabIndex = 0;
            this.InputLabel.Text = "Input";
            // 
            // EncryptBtn
            // 
            this.EncryptBtn.Location = new System.Drawing.Point(47, 236);
            this.EncryptBtn.Name = "EncryptBtn";
            this.EncryptBtn.Size = new System.Drawing.Size(75, 23);
            this.EncryptBtn.TabIndex = 1;
            this.EncryptBtn.Text = "Encrypt";
            this.EncryptBtn.UseVisualStyleBackColor = true;
            this.EncryptBtn.Click += new System.EventHandler(this.EncryptBtn_Click);
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(12, 27);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(262, 126);
            this.InputBox.TabIndex = 2;
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // KeyBox
            // 
            this.KeyBox.Location = new System.Drawing.Point(47, 207);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.PasswordChar = '*';
            this.KeyBox.Size = new System.Drawing.Size(196, 23);
            this.KeyBox.TabIndex = 3;
            this.KeyBox.UseSystemPasswordChar = true;
            this.KeyBox.TextChanged += new System.EventHandler(this.KeyBox_TextChanged);
            // 
            // DecryptBtn
            // 
            this.DecryptBtn.Location = new System.Drawing.Point(168, 236);
            this.DecryptBtn.Name = "DecryptBtn";
            this.DecryptBtn.Size = new System.Drawing.Size(75, 23);
            this.DecryptBtn.TabIndex = 4;
            this.DecryptBtn.Text = "Decrypt";
            this.DecryptBtn.UseVisualStyleBackColor = true;
            this.DecryptBtn.Click += new System.EventHandler(this.DecryptBtn_Click);
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(12, 210);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(26, 15);
            this.KeyLabel.TabIndex = 5;
            this.KeyLabel.Text = "Key";
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(12, 295);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(262, 126);
            this.OutputBox.TabIndex = 6;
            this.OutputBox.TextChanged += new System.EventHandler(this.OutputBox_TextChanged);
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(12, 277);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(45, 15);
            this.OutputLabel.TabIndex = 7;
            this.OutputLabel.Text = "Output";
            // 
            // ErrorMessageForKey
            // 
            this.ErrorMessageForKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorMessageForKey.AutoEllipsis = true;
            this.ErrorMessageForKey.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessageForKey.Location = new System.Drawing.Point(12, 157);
            this.ErrorMessageForKey.MaximumSize = new System.Drawing.Size(260, 45);
            this.ErrorMessageForKey.MinimumSize = new System.Drawing.Size(260, 45);
            this.ErrorMessageForKey.Name = "ErrorMessageForKey";
            this.ErrorMessageForKey.Size = new System.Drawing.Size(260, 45);
            this.ErrorMessageForKey.TabIndex = 8;
            this.ErrorMessageForKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 433);
            this.Controls.Add(this.ErrorMessageForKey);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.DecryptBtn);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.EncryptBtn);
            this.Controls.Add(this.InputLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Encrypter/Decrypter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label InputLabel;
        private Button EncryptBtn;
        private TextBox InputBox;
        private TextBox KeyBox;
        private Button DecryptBtn;
        private Label KeyLabel;
        private TextBox OutputBox;
        private Label OutputLabel;
        private Label ErrorMessageForKey;
    }
}