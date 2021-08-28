using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace OSQRS
{
    public partial class aboutForm : Form
    {
        public aboutForm()
        {
            InitializeComponent();
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            authorNameLabel.Text = "M. Feenstra";
            versionNumLabel.Text= fileVersionInfo.ProductVersion;
            
        }

        private void zxingLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Navigate to a URL.
            osqrsTools.OpenUrl("https://github.com/micjahn/ZXing.Net/");
        }
    }
}
