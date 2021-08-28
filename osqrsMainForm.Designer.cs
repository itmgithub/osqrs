
namespace OSQRS
{
    partial class osqrsMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(osqrsMainForm));
            this.scanPanel = new System.Windows.Forms.Panel();
            this.scanButton = new System.Windows.Forms.Button();
            this.scanPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // scanPanel
            // 
            this.scanPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scanPanel.BackColor = System.Drawing.Color.Gray;
            this.scanPanel.Controls.Add(this.scanButton);
            this.scanPanel.Location = new System.Drawing.Point(0, 253);
            this.scanPanel.Name = "scanPanel";
            this.scanPanel.Size = new System.Drawing.Size(332, 50);
            this.scanPanel.TabIndex = 1;
            // 
            // scanButton
            // 
            this.scanButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scanButton.Location = new System.Drawing.Point(121, 9);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(94, 29);
            this.scanButton.TabIndex = 0;
            this.scanButton.Text = "scan";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // osqrsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(332, 303);
            this.Controls.Add(this.scanPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(150, 200);
            this.Name = "osqrsMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OnScreen QR Scanner";
            this.TransparencyKey = System.Drawing.Color.Coral;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.osqrsMainForm_Paint);
            this.Resize += new System.EventHandler(this.osqrsMainForm_Resize);
            this.scanPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel scanPanel;
        private System.Windows.Forms.Button scanButton;
    }
}

