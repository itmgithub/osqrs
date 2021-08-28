
namespace OSQRS
{
    partial class aboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutForm));
            this.authorTagLabel = new System.Windows.Forms.Label();
            this.itmonQRpicturebox = new System.Windows.Forms.PictureBox();
            this.verionTagLabel = new System.Windows.Forms.Label();
            this.authorNameLabel = new System.Windows.Forms.Label();
            this.versionNumLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.licenseNameLabel = new System.Windows.Forms.Label();
            this.licenseTagLabel = new System.Windows.Forms.Label();
            this.zxingLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.itmonQRpicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // authorTagLabel
            // 
            this.authorTagLabel.AutoSize = true;
            this.authorTagLabel.Location = new System.Drawing.Point(12, 59);
            this.authorTagLabel.Name = "authorTagLabel";
            this.authorTagLabel.Size = new System.Drawing.Size(54, 20);
            this.authorTagLabel.TabIndex = 0;
            this.authorTagLabel.Text = "Author";
            // 
            // itmonQRpicturebox
            // 
            this.itmonQRpicturebox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itmonQRpicturebox.Image = ((System.Drawing.Image)(resources.GetObject("itmonQRpicturebox.Image")));
            this.itmonQRpicturebox.Location = new System.Drawing.Point(13, 122);
            this.itmonQRpicturebox.Name = "itmonQRpicturebox";
            this.itmonQRpicturebox.Size = new System.Drawing.Size(198, 187);
            this.itmonQRpicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.itmonQRpicturebox.TabIndex = 1;
            this.itmonQRpicturebox.TabStop = false;
            // 
            // verionTagLabel
            // 
            this.verionTagLabel.AutoSize = true;
            this.verionTagLabel.Location = new System.Drawing.Point(12, 79);
            this.verionTagLabel.Name = "verionTagLabel";
            this.verionTagLabel.Size = new System.Drawing.Size(57, 20);
            this.verionTagLabel.TabIndex = 2;
            this.verionTagLabel.Text = "Version";
            // 
            // authorNameLabel
            // 
            this.authorNameLabel.AutoSize = true;
            this.authorNameLabel.Location = new System.Drawing.Point(102, 59);
            this.authorNameLabel.Name = "authorNameLabel";
            this.authorNameLabel.Size = new System.Drawing.Size(84, 20);
            this.authorNameLabel.TabIndex = 3;
            this.authorNameLabel.Text = "M. Feenstra";
            // 
            // versionNumLabel
            // 
            this.versionNumLabel.AutoSize = true;
            this.versionNumLabel.Location = new System.Drawing.Point(102, 79);
            this.versionNumLabel.Name = "versionNumLabel";
            this.versionNumLabel.Size = new System.Drawing.Size(35, 20);
            this.versionNumLabel.TabIndex = 4;
            this.versionNumLabel.Text = "v0.0";
            // 
            // productNameLabel
            // 
            this.productNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productNameLabel.Location = new System.Drawing.Point(46, 9);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(140, 50);
            this.productNameLabel.TabIndex = 5;
            this.productNameLabel.Text = "OSQRS";
            this.productNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // licenseNameLabel
            // 
            this.licenseNameLabel.AutoSize = true;
            this.licenseNameLabel.Location = new System.Drawing.Point(102, 99);
            this.licenseNameLabel.Name = "licenseNameLabel";
            this.licenseNameLabel.Size = new System.Drawing.Size(96, 20);
            this.licenseNameLabel.TabIndex = 7;
            this.licenseNameLabel.Text = "BSD 3-clause";
            // 
            // licenseTagLabel
            // 
            this.licenseTagLabel.AutoSize = true;
            this.licenseTagLabel.Location = new System.Drawing.Point(12, 99);
            this.licenseTagLabel.Name = "licenseTagLabel";
            this.licenseTagLabel.Size = new System.Drawing.Size(57, 20);
            this.licenseTagLabel.TabIndex = 6;
            this.licenseTagLabel.Text = "License";
            // 
            // zxingLinkLabel
            // 
            this.zxingLinkLabel.AutoSize = true;
            this.zxingLinkLabel.Location = new System.Drawing.Point(13, 319);
            this.zxingLinkLabel.Name = "zxingLinkLabel";
            this.zxingLinkLabel.Size = new System.Drawing.Size(198, 20);
            this.zxingLinkLabel.TabIndex = 8;
            this.zxingLinkLabel.TabStop = true;
            this.zxingLinkLabel.Text = "OSQRS gratefully uses ZXing";
            this.zxingLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.zxingLinkLabel_LinkClicked);
            // 
            // aboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 356);
            this.Controls.Add(this.zxingLinkLabel);
            this.Controls.Add(this.licenseNameLabel);
            this.Controls.Add(this.licenseTagLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.versionNumLabel);
            this.Controls.Add(this.authorNameLabel);
            this.Controls.Add(this.verionTagLabel);
            this.Controls.Add(this.itmonQRpicturebox);
            this.Controls.Add(this.authorTagLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "aboutForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.itmonQRpicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label authorTagLabel;
        private System.Windows.Forms.PictureBox itmonQRpicturebox;
        private System.Windows.Forms.Label verionTagLabel;
        private System.Windows.Forms.Label authorNameLabel;
        private System.Windows.Forms.Label versionNumLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label licenseNameLabel;
        private System.Windows.Forms.Label licenseTagLabel;
        private System.Windows.Forms.LinkLabel zxingLinkLabel;
    }
}