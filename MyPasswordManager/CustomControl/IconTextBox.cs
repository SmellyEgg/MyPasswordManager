﻿using System.Windows.Forms;

namespace MyPasswordManager.CustomControl
{
    public class IconTextBox : TextBox
    {
        public IconTextBox() : base() { SetStyle(System.Windows.Forms.ControlStyles.UserPaint, true); this.Multiline = true; this.BitmapImage = Properties.Resources.newsearch; }
        public System.Drawing.Bitmap BitmapImage
        {
            set;
            get;
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
            System.Drawing.Image img = BitmapImage as System.Drawing.Image;
            e.Graphics.DrawImage(img, new System.Drawing.Point(this.Width - (img.Width), 0));

        }
    }
}
