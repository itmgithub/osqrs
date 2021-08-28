using System;
using System.Windows.Forms;

namespace OSQRS
{
    public partial class qrResultForm : Form
    {
        public qrResultForm()
        {
            InitializeComponent();
        }

        public string TextBoxValue
        {
            get { return qrResultTextBox.Text; }
            set { qrResultTextBox.Text = value; }
        }


        private void qrResultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void copyToClipBoardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(qrResultTextBox.Text);
        }

        private void openInBrowserButton_Click(object sender, EventArgs e)
        {
            osqrsTools.OpenUrl(qrResultTextBox.Text);
        }

        private void qrResultForm_Shown(object sender, EventArgs e)
        {
            Uri uriResult;
            bool result = Uri.TryCreate(qrResultTextBox.Text, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            if (result == true) openInBrowserButton.Visible = true;
        }

        private void aboutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var aboutForm = new aboutForm();
            aboutForm.Show();
        }
    }
}
