using MyPasswordManager.CustomControl;
using System.Windows.Forms;

namespace MyPasswordManager.View
{
    partial class frmPassword
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMainBoard = new System.Windows.Forms.Panel();
            this.myTabControl1 = new MyPasswordManager.CustomControl.MyTabControl();
            this.tbpageManager = new System.Windows.Forms.TabPage();
            this.chxIsModify = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.accountListControl = new MyPasswordManager.CustomControl.MyCustomAccountControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAccountType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMainBoard.SuspendLayout();
            this.myTabControl1.SuspendLayout();
            this.tbpageManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1420, 61);
            this.panel1.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUser.Location = new System.Drawing.Point(1068, 20);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(58, 21);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "用户：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 30F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Passwd…";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtFilter);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(262, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 48);
            this.panel2.TabIndex = 0;
            // 
            // txtFilter
            // 
            this.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilter.Font = new System.Drawing.Font("宋体", 28F);
            this.txtFilter.Location = new System.Drawing.Point(55, 3);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(713, 43);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyPasswordManager.Properties.Resources.newsearch;
            this.pictureBox1.Location = new System.Drawing.Point(4, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlMainBoard
            // 
            this.pnlMainBoard.BackColor = System.Drawing.Color.Teal;
            this.pnlMainBoard.Controls.Add(this.myTabControl1);
            this.pnlMainBoard.Location = new System.Drawing.Point(-1, 61);
            this.pnlMainBoard.Name = "pnlMainBoard";
            this.pnlMainBoard.Size = new System.Drawing.Size(1420, 682);
            this.pnlMainBoard.TabIndex = 1;
            // 
            // myTabControl1
            // 
            this.myTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.myTabControl1.Controls.Add(this.tbpageManager);
            this.myTabControl1.Controls.Add(this.tabPage2);
            this.myTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.myTabControl1.ItemSize = new System.Drawing.Size(50, 200);
            this.myTabControl1.Location = new System.Drawing.Point(0, 0);
            this.myTabControl1.Multiline = true;
            this.myTabControl1.Name = "myTabControl1";
            this.myTabControl1.SelectedIndex = 0;
            this.myTabControl1.Size = new System.Drawing.Size(1420, 679);
            this.myTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.myTabControl1.TabIndex = 0;
            // 
            // tbpageManager
            // 
            this.tbpageManager.Controls.Add(this.label5);
            this.tbpageManager.Controls.Add(this.cmbAccountType);
            this.tbpageManager.Controls.Add(this.label4);
            this.tbpageManager.Controls.Add(this.chxIsModify);
            this.tbpageManager.Controls.Add(this.btnOk);
            this.tbpageManager.Controls.Add(this.label3);
            this.tbpageManager.Controls.Add(this.label2);
            this.tbpageManager.Controls.Add(this.txtPassword);
            this.tbpageManager.Controls.Add(this.txtUserName);
            this.tbpageManager.Controls.Add(this.accountListControl);
            this.tbpageManager.Location = new System.Drawing.Point(204, 4);
            this.tbpageManager.Name = "tbpageManager";
            this.tbpageManager.Padding = new System.Windows.Forms.Padding(3);
            this.tbpageManager.Size = new System.Drawing.Size(1212, 671);
            this.tbpageManager.TabIndex = 0;
            this.tbpageManager.Text = "网站";
            this.tbpageManager.UseVisualStyleBackColor = true;
            // 
            // chxIsModify
            // 
            this.chxIsModify.AutoSize = true;
            this.chxIsModify.Checked = true;
            this.chxIsModify.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chxIsModify.Location = new System.Drawing.Point(286, 131);
            this.chxIsModify.Name = "chxIsModify";
            this.chxIsModify.Size = new System.Drawing.Size(48, 16);
            this.chxIsModify.TabIndex = 8;
            this.chxIsModify.Text = "新增";
            this.chxIsModify.UseVisualStyleBackColor = true;
            this.chxIsModify.CheckedChanged += new System.EventHandler(this.chxIsModify_CheckedChanged);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.DarkRed;
            this.btnOk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOk.Location = new System.Drawing.Point(48, 118);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(221, 40);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "新增";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "账户：";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("宋体", 12F);
            this.txtPassword.Location = new System.Drawing.Point(93, 75);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(323, 26);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("宋体", 12F);
            this.txtUserName.Location = new System.Drawing.Point(93, 20);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(323, 26);
            this.txtUserName.TabIndex = 1;
            // 
            // accountListControl
            // 
            this.accountListControl.AutoScroll = true;
            this.accountListControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.accountListControl.Location = new System.Drawing.Point(3, 164);
            this.accountListControl.Name = "accountListControl";
            this.accountListControl.Size = new System.Drawing.Size(1213, 507);
            this.accountListControl.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(204, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1212, 671);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "其他";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "账户类型";
            // 
            // cmbAccountType
            // 
            this.cmbAccountType.FormattingEnabled = true;
            this.cmbAccountType.Location = new System.Drawing.Point(533, 20);
            this.cmbAccountType.Name = "cmbAccountType";
            this.cmbAccountType.Size = new System.Drawing.Size(230, 20);
            this.cmbAccountType.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "可以选择已有类型也可以手动输入";
            // 
            // frmPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 741);
            this.Controls.Add(this.pnlMainBoard);
            this.Controls.Add(this.panel1);
            this.Icon = global::MyPasswordManager.Properties.Resources.padlock;
            this.Name = "frmPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "密码管理";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMainBoard.ResumeLayout(false);
            this.myTabControl1.ResumeLayout(false);
            this.tbpageManager.ResumeLayout(false);
            this.tbpageManager.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMainBoard;
        private MyTabControl myTabControl1;
        private System.Windows.Forms.TabPage tbpageManager;
        private System.Windows.Forms.TabPage tabPage2;
        private MyCustomAccountControl accountListControl;
        private Label label3;
        private Label label2;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Button btnOk;
        private CheckBox chxIsModify;
        private ComboBox cmbAccountType;
        private Label label4;
        private Label label5;
    }
}

