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
            this.radioBtnPanel = new System.Windows.Forms.Panel();
            this.removeRadioBtn = new System.Windows.Forms.RadioButton();
            this.addRadioBtn = new System.Windows.Forms.RadioButton();
            this.creatorLabel = new System.Windows.Forms.Label();
            this.radioBtnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderPathLabel
            // 
            this.folderPathLabel.AutoSize = true;
            this.folderPathLabel.Location = new System.Drawing.Point(19, 17);
            this.folderPathLabel.Name = "folderPathLabel";
            this.folderPathLabel.Size = new System.Drawing.Size(142, 25);
            this.folderPathLabel.TabIndex = 0;
            this.folderPathLabel.Text = "Full Folder Path";
            // 
            // folderPathTextBox
            // 
            this.folderPathTextBox.AllowDrop = true;
            this.folderPathTextBox.BackColor = System.Drawing.Color.White;
            this.folderPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.folderPathTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.folderPathTextBox.Location = new System.Drawing.Point(19, 51);
            this.folderPathTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.folderPathTextBox.MaxLength = 180;
            this.folderPathTextBox.Name = "folderPathTextBox";
            this.folderPathTextBox.Size = new System.Drawing.Size(750, 29);
            this.folderPathTextBox.TabIndex = 1;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(19, 107);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(91, 25);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // clientPasswordTextBox
            // 
            this.clientPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientPasswordTextBox.Location = new System.Drawing.Point(19, 141);
            this.clientPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientPasswordTextBox.MaxLength = 30;
            this.clientPasswordTextBox.Name = "clientPasswordTextBox";
            this.clientPasswordTextBox.Size = new System.Drawing.Size(273, 29);
            this.clientPasswordTextBox.TabIndex = 3;
            // 
            // applyPasswordButton
            // 
            this.applyPasswordButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuText;
            this.applyPasswordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.applyPasswordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.applyPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyPasswordButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.applyPasswordButton.Location = new System.Drawing.Point(450, 105);
            this.applyPasswordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.applyPasswordButton.Name = "applyPasswordButton";
            this.applyPasswordButton.Size = new System.Drawing.Size(319, 64);
            this.applyPasswordButton.TabIndex = 4;
            this.applyPasswordButton.Text = "Process All PDFs in Folder";
            this.applyPasswordButton.UseVisualStyleBackColor = true;
            this.applyPasswordButton.Click += new System.EventHandler(this.applyPasswordButton_Click);
            // 
            // miniTextLabel
            // 
            this.miniTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.miniTextLabel.AutoSize = true;
            this.miniTextLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.miniTextLabel.Location = new System.Drawing.Point(206, 23);
            this.miniTextLabel.Name = "miniTextLabel";
            this.miniTextLabel.Size = new System.Drawing.Size(396, 19);
            this.miniTextLabel.TabIndex = 5;
            this.miniTextLabel.Text = "(Drag && Drop PDF file below to get folder path automatcially)";
            // 
            // radioBtnPanel
            // 
            this.radioBtnPanel.Controls.Add(this.removeRadioBtn);
            this.radioBtnPanel.Controls.Add(this.addRadioBtn);
            this.radioBtnPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtnPanel.Location = new System.Drawing.Point(322, 115);
            this.radioBtnPanel.Margin = new System.Windows.Forms.Padding(0);
            this.radioBtnPanel.Name = "radioBtnPanel";
            this.radioBtnPanel.Size = new System.Drawing.Size(104, 54);
            this.radioBtnPanel.TabIndex = 6;
            // 
            // removeRadioBtn
            // 
            this.removeRadioBtn.AutoSize = true;
            this.removeRadioBtn.Location = new System.Drawing.Point(7, 28);
            this.removeRadioBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeRadioBtn.Name = "removeRadioBtn";
            this.removeRadioBtn.Size = new System.Drawing.Size(81, 24);
            this.removeRadioBtn.TabIndex = 1;
            this.removeRadioBtn.Text = "Remove";
            this.removeRadioBtn.UseVisualStyleBackColor = true;
            // 
            // addRadioBtn
            // 
            this.addRadioBtn.AutoSize = true;
            this.addRadioBtn.Checked = true;
            this.addRadioBtn.Location = new System.Drawing.Point(7, 2);
            this.addRadioBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addRadioBtn.Name = "addRadioBtn";
            this.addRadioBtn.Size = new System.Drawing.Size(55, 24);
            this.addRadioBtn.TabIndex = 0;
            this.addRadioBtn.TabStop = true;
            this.addRadioBtn.Text = "Add";
            this.addRadioBtn.UseVisualStyleBackColor = true;
            // 
            // creatorLabel
            // 
            this.creatorLabel.AutoSize = true;
            this.creatorLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.creatorLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.creatorLabel.Location = new System.Drawing.Point(-1, 182);
            this.creatorLabel.Name = "creatorLabel";
            this.creatorLabel.Size = new System.Drawing.Size(96, 13);
            this.creatorLabel.TabIndex = 7;
            this.creatorLabel.Text = "S3257B / SIO SCO";
            // 
            // PDF_Protector
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 196);
            this.Controls.Add(this.creatorLabel);
            this.Controls.Add(this.radioBtnPanel);
            this.Controls.Add(this.miniTextLabel);
            this.Controls.Add(this.applyPasswordButton);
            this.Controls.Add(this.clientPasswordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.folderPathTextBox);
            this.Controls.Add(this.folderPathLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "PDF_Protector";
            this.Text = "PDF Protector";
            this.TopMost = true;
            this.radioBtnPanel.ResumeLayout(false);
            this.radioBtnPanel.PerformLayout();
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
        private Panel radioBtnPanel;
        private RadioButton removeRadioBtn;
        private RadioButton addRadioBtn;
        private Label creatorLabel;
    }
}