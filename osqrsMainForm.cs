using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;

namespace OSQRS
{
    public partial class osqrsMainForm : Form
    {
        const int PenWidth = 3;

        public osqrsMainForm()
        {
            InitializeComponent();
        }

        private void osqrsMainForm_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(new Point(0, 0), new Size(this.ClientRectangle.Width, scanPanel.Location.Y));
            Pen pen = new Pen(Color.Red, PenWidth);
            e.Graphics.DrawRectangle(pen, r);
        }

        private void osqrsMainForm_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            BarcodeReader reader = new BarcodeReader();
            var f = new qrResultForm();

            var X = this.Location.X; // Save current X,Y,W and H before hide
            var Y = this.Location.Y;
            var W = this.Width;
            var H = this.Height;

            this.Visible = false;
            System.Threading.Thread.Sleep(500); // So that OSQRS can hide;
            var bmpImage = new Bitmap(W, H);
            var gfxImage = Graphics.FromImage(bmpImage);
            gfxImage.CopyFromScreen(X, Y, 0, 0, new Size(W, H), CopyPixelOperation.SourceCopy);
            var result = reader.Decode(bmpImage);
            f.Show();
            if (result != null)
            {
                f.TextBoxValue = result.Text;
            } else
            {
                f.TextBoxValue = "Reading QR code failed.";
            }
            gfxImage.Dispose();
            bmpImage.Dispose();

        }
    }
}
