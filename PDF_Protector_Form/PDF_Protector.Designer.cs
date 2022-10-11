namespace PDF_Protector_Form
{
    partial class PDF_Protector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDF_Protector));
            this.folderPathLabel = new System.Windows.Forms.Label();
            this.folderPathTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.clientPasswordTextBox = new System.Windows.Forms.TextBox();
            this.applyPasswordButton = new System.Windows.Forms.Button();
            this.miniTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // folderPathLabel
            // 
            this.folderPathLabel.AutoSize = true;
            this.folderPathLabel.Location = new System.Drawing.Point(24, 20);
            this.folderPathLabel.Name = "folderPathLabel";
            this.folderPathLabel.Size = new System.Drawing.Size(209, 38);
            this.folderPathLabel.TabIndex = 0;
            this.folderPathLabel.Text = "Full Folder Path";
            // 
            // folderPathTextBox
            // 
            this.folderPathTextBox.AllowDrop = true;
            this.folderPathTextBox.BackColor = System.Drawing.Color.White;
            this.folderPathTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.folderPathTextBox.Location = new System.Drawing.Point(24, 70);
            this.folderPathTextBox.MaxLength = 180;
            this.folderPathTextBox.Name = "folderPathTextBox";
            this.folderPathTextBox.Size = new System.Drawing.Size(818, 34);
            this.folderPathTextBox.TabIndex = 1;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(24, 137);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(212, 38);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Client password";
            // 
            // clientPasswordTextBox
            // 
            this.clientPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientPasswordTextBox.Location = new System.Drawing.Point(24, 178);
            this.clientPasswordTextBox.MaxLength = 30;
            this.clientPasswordTextBox.Name = "clientPasswordTextBox";
            this.clientPasswordTextBox.Size = new System.Drawing.Size(298, 34);
            this.clientPasswordTextBox.TabIndex = 3;
            // 
            // applyPasswordButton
            // 
            this.applyPasswordButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuText;
            this.applyPasswordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.applyPasswordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.applyPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyPasswordButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.applyPasswordButton.Location = new System.Drawing.Point(409, 144);
            this.applyPasswordButton.Name = "applyPasswordButton";
            this.applyPasswordButton.Size = new System.Drawing.Size(390, 77);
            this.applyPasswordButton.TabIndex = 4;
            this.applyPasswordButton.Text = "Apply Password To PDFs";
            this.applyPasswordButton.UseVisualStyleBackColor = true;
            this.applyPasswordButton.Click += new System.EventHandler(this.applyPasswordButton_Click);
            // 
            // miniTextLabel
            // 
            this.miniTextLabel.AutoSize = true;
            this.miniTextLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.miniTextLabel.Location = new System.Drawing.Point(364, 44);
            this.miniTextLabel.Name = "miniTextLabel";
            this.miniTextLabel.Size = new System.Drawing.Size(478, 23);
            this.miniTextLabel.TabIndex = 5;
            this.miniTextLabel.Text = "(Drag && Drop PDF file below to get folder path automatcially)";
            // 
            // PDF_Protector
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 255);
            this.Controls.Add(this.miniTextLabel);
            this.Controls.Add(this.applyPasswordButton);
            this.Controls.Add(this.clientPasswordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.folderPathTextBox);
            this.Controls.Add(this.folderPathLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "PDF_Protector";
            this.Text = "PDF Protector";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Label folderPathLabel;
        private TextBox folderPathTextBox;
        private Label passwordLabel;
        private TextBox clientPasswordTextBox;
        private Button applyPasswordButton;
        private Label miniTextLabel;
    }
}