namespace MyPasswordManager.CustomControl
{
    public class myButton : BaseControl
    {
        private System.Windows.Forms.Button button1;

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "按钮";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // myButton
            // 
            this.Controls.Add(this.button1);
            this.Name = "myButton";
            this.Size = new System.Drawing.Size(114, 30);
            this.ResumeLayout(false);

        }
    }
}
