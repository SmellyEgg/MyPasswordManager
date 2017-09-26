using System.Drawing;
using System.Windows.Forms;

namespace MyPasswordManager.CustomControl
{
    public class MyTabControl : TabControl
    {
        public MyTabControl()
        {
            this.Alignment = TabAlignment.Left;
            this.SizeMode = TabSizeMode.Fixed;
            this.ItemSize = new Size(25, 100);
            this.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.DrawItem += MyTabControl_DrawItem; ;
        }

        private void MyTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            //throw new System.NotImplementedException();
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = this.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = this.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.White);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                //_textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                _textBrush = new SolidBrush(Color.Teal);
                //e.DrawBackground();
                g.FillRectangle(Brushes.Silver, e.Bounds);
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", (float)10.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }
    }
}
