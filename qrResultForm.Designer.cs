
namespace OSQRS
{
    partial class qrResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(qrResultForm));
            this.qrResultTextBox = new System.Windows.Forms.TextBox();
            this.copyToClipBoardButton = new System.Windows.Forms.Button();
            this.openInBrowserButton = new System.Windows.Forms.Button();
            this.aboutNameLinkLabel = new System.Windows.Forms.LinkLabel();
            this.aboutNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // qrResultTextBox
            // 
            this.qrResultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qrResultTextBox.Location = new System.Drawing.Point(12, 32);
            this.qrResultTextBox.Multiline = true;
            this.qrResultTextBox.Name = "qrResultTextBox";
            this.qrResultTextBox.ReadOnly = true;
            this.qrResultTextBox.Size = new System.Drawing.Size(361, 351);
            this.qrResultTextBox.TabIndex = 0;
            // 
            // copyToClipBoardButton
            // 
            this.copyToClipBoardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.copyToClipBoardButton.Location = new System.Drawing.Point(12, 389);
            this.copyToClipBoardButton.Name = "copyToClipBoardButton";
            this.copyToClipBoardButton.Size = new System.Drawing.Size(175, 36);
            this.copyToClipBoardButton.TabIndex = 1;
            this.copyToClipBoardButton.Text = "Copy to Clipboard";
            this.copyToClipBoardButton.UseVisualStyleBackColor = true;
            this.copyToClipBoardButton.Click += new System.EventHandler(this.copyToClipBoardButton_Click);
            // 
            // openInBrowserButton
            // 
            this.openInBrowserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openInBrowserButton.Location = new System.Drawing.Point(198, 390);
            this.openInBrowserButton.Name = "openInBrowserButton";
            this.openInBrowserButton.Size = new System.Drawing.Size(175, 36);
            this.openInBrowserButton.TabIndex = 2;
            this.openInBrowserButton.Text = "Open in Browser";
            this.openInBrowserButton.UseVisualStyleBackColor = true;
            this.openInBrowserButton.Visible = false;
            this.openInBrowserButton.Click += new System.EventHandler(this.openInBrowserButton_Click);
            // 
            // aboutNameLinkLabel
            // 
            this.aboutNameLinkLabel.AutoSize = true;
            this.aboutNameLinkLabel.Location = new System.Drawing.Point(72, 9);
            this.aboutNameLinkLabel.Name = "aboutNameLinkLabel";
            this.aboutNameLinkLabel.Size = new System.Drawing.Size(56, 20);
            this.aboutNameLinkLabel.TabIndex = 3;
            this.aboutNameLinkLabel.TabStop = true;
            this.aboutNameLinkLabel.Text = "OSQRS";
            this.aboutNameLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutLinkLabel_LinkClicked);
            // 
            // aboutNameLabel
            // 
            this.aboutNameLabel.AutoSize = true;
            this.aboutNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aboutNameLabel.Location = new System.Drawing.Point(13, 9);
            this.aboutNameLabel.Name = "aboutNameLabel";
            this.aboutNameLabel.Size = new System.Drawing.Size(57, 20);
            this.aboutNameLabel.TabIndex = 4;
            this.aboutNameLabel.Text = "About:";
            // 
            // qrResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 438);
            this.Controls.Add(this.aboutNameLabel);
            this.Controls.Add(this.aboutNameLinkLabel);
            this.Controls.Add(this.openInBrowserButton);
            this.Controls.Add(this.copyToClipBoardButton);
            this.Controls.Add(this.qrResultTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "qrResultForm";
            this.Text = "QR Code Result";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.qrResultForm_FormClosing);
            this.Shown += new System.EventHandler(this.qrResultForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox qrResultTextBox;
        private System.Windows.Forms.Button copyToClipBoardButton;
        private System.Windows.Forms.Button openInBrowserButton;
        private System.Windows.Forms.LinkLabel aboutNameLinkLabel;
        private System.Windows.Forms.Label aboutNameLabel;
    }
}