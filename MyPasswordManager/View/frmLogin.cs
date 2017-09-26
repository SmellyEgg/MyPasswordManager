using MyPasswordManager.Controller.CommonController;
using MyPasswordManager.Model;
using System;
using System.Windows.Forms;

namespace MyPasswordManager.View
{
    /// <summary>
    /// 漂亮的登陆界面
    /// </summary>
    public partial class frmLogin : Form
    {
        private loginController _loginController;

        private string _dealType = CommonDictionary.LoginType;
        public frmLogin()
        {
            InitializeComponent();
            _loginController = new loginController();
        }

        /// <summary>
        /// 登陆操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_dealType.Equals(CommonDictionary.LoginType))
            {
                User currentUser = this.GetUser();
                if (!object.Equals(currentUser, null))
                {
                    if (_loginController.Login(currentUser))
                    {
                        Showtips("登陆成功!");
                        this.Hide();
                        frmPassword frm = new frmPassword(currentUser);
                        frm.FormClosed += Frm_FormClosed;
                        frm.Show();
                    }
                    else
                    {
                        Showtips("用户名或密码错误！");
                        this.txtPassword.Text = string.Empty;
                    }
                }
            }
            else
            {
                //注册操作
                User currentUser = this.GetUser();
                if (!object.Equals(currentUser, null))
                {
                    if (_loginController.Register(currentUser))
                    {
                        Showtips("注册成功！");
                        this.btnBack.PerformClick();
                    }
                    else
                    {
                        Showtips("注册失败：" + _loginController.Tips);
                    }
                }
            }
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void Showtips(string tips)
        {
            this.lblTips.Text = tips;
        }

        /// <summary>
        /// 获取当前用户
        /// </summary>
        /// <returns></returns>
        private User GetUser()
        {
            if (this.Valid())
            {
                if (_dealType.Equals(CommonDictionary.LoginType))
                {
                    User currentuser = new User(this.txtName.Text.Trim(), this.txtPassword.Text.Trim());
                    return currentuser;
                }
                else
                {
                    User currentuser = new User(this.txtName.Text.Trim(), this.txtPassword.Text.Trim(), this.txtkey.Text.Trim());
                    return currentuser;
                }
            }
            return null;
        }

        /// <summary>
        /// 验证
        /// </summary>
        /// <returns></returns>
        private bool Valid()
        {
            if (string.IsNullOrEmpty(this.txtName.Text.Trim()) || string.IsNullOrEmpty(this.txtPassword.Text.Trim()))
            {
                return false;
            }
            if (_dealType.Equals(CommonDictionary.RegisterType))
            {
                if (string.IsNullOrEmpty(this.txtkey.Text.Trim()))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 注册操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblRegister_Click(object sender, EventArgs e)
        {
            this.SetIsLogin(false);
        }

        /// <summary>
        /// 设置注册相关控件
        /// </summary>
        /// <param name="visible"></param>
        private void SetRegisterControl(bool visible)
        {
            this.txtkey.Visible = visible;
            this.lblKey.Visible = visible;
            this.btnBack.Visible = visible;
        }

        /// <summary>
        /// 返回操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            SetIsLogin(true);
        }

        private void SetIsLogin(bool bol)
        {
            if (bol)
            {
                _dealType = CommonDictionary.LoginType;
                this.SetRegisterControl(false);
                this.btnLogin.Text = "登陆";
            }
            else
            {
                _dealType = CommonDictionary.RegisterType;
                this.Clear();
                this.SetRegisterControl(true);
                this.btnLogin.Text = "完成";
            }
            this.txtName.Focus();
        }

        private void Clear()
        {
            this.txtName.Text = string.Empty;
            this.txtPassword.Text = string.Empty;
            this.txtkey.Text = string.Empty;
            this.lblTips.Text = string.Empty;
        }

        private void txtEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnLogin.PerformClick();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
