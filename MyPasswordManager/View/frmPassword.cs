using MyPasswordManager.Controller.CommonController;
using MyPasswordManager.Model;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyPasswordManager.View
{
    public partial class frmPassword : Form
    {
        private User _currentUser;

        private Account _currentAccount;

        private List<Account> _accountList;

        private accountController _accountController;

        private string _currentType = CommonDictionary.AddType;
        public frmPassword(User user)
        {
            InitializeComponent();
            this.accountListControl.accountSelected += AccountListControl_accountSelected;
            InitAccount(user);
        }

        private void AccountListControl_accountSelected(Account account)
        {
            this.chxIsModify.Checked = false;
            _currentAccount = account;
            SetCurrentAccount(_currentAccount);
        }

        private void SetCurrentAccount(Account account)
        {
            this.txtUserName.Text = account.AccountName;
            this.txtPassword.Text = account.AccountPassword;
            this.cmbAccountType.Text = account.AccountType;
        }

        private void InitAccount(User user)
        {
            _currentUser = user;
            _accountController = new accountController();
            _accountList = new List<Account>();
            this.lblUser.Text = "用户：" + user.UserName;
            SetAccountInfo(user);
        }
        /// <summary>
        /// 进行解密
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private List<Account> DecodeAccountList(List<Account> list)
        {
            List<Account> newAccountList = new List<Account>();
            foreach (Account account in list)
            {
                account.AccountPassword = SmellyEggCrypt.CryPtService.DESDecrypt(account.AccountPassword, _currentUser.Key);
                newAccountList.Add(account);
            }
            return newAccountList;
        }

        private void SetAccountInfo(User user)
        {
            if (!object.Equals(_accountList, null))
            {
                _accountList.Clear();
            }
            _accountList = _accountController.GetAccountList(user.UserName);
            _accountList = this.DecodeAccountList(_accountList);
            //this.accountListControl.SetAccountContent(_accountList);
            this.Refresh();
        }

        

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            Account account = this.GetAccount();
            if (object.Equals(account, null))
            {
                MessageBox.Show("信息输入不完整！");
                return;
            }
            if (_currentType.Equals(CommonDictionary.AddType))
            {
                if (IsAccountExist(account))
                {
                    MessageBox.Show("已经存在相同名称的账户！");
                    return;
                }
                if (_accountController.InsertAccount(account) == 1)
                {
                    MessageBox.Show("新增账户成功！");
                    account.AccountPassword = SmellyEggCrypt.CryPtService.DESDecrypt(account.AccountPassword, _currentUser.Key);
                    _accountList.Add(account);
                    this.Refresh();
                }
                else
                {
                    MessageBox.Show("插入账户失败！");
                }
            }
            else
            {
                if (_accountController.UpdateAccount(_currentAccount, account) == 1)
                {
                    MessageBox.Show("更新账户成功！");
                    int oldAccountIndex = _accountList.FindIndex(p => p.AccountName.Equals(_currentAccount.AccountName));
                    if (oldAccountIndex != -1)
                    {
                        account.AccountPassword = SmellyEggCrypt.CryPtService.DESDecrypt(account.AccountPassword, _currentUser.Key);
                        _accountList[oldAccountIndex] = account;
                        this.Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("更新账户失败！");
                }
            }
        }
   
        private new void Refresh()
        {
            this.txtPassword.Text = string.Empty;
            this.txtUserName.Text = string.Empty;
            this.accountListControl.SetAccountContent(_accountList);
            this.txtUserName.Focus();
            this.SetAccountType(_accountList);
        }

        private void SetAccountType(List<Account> accountlist)
        {
            List<string> listType = new List<string>();
            foreach(Account account in accountlist)
            {
                if (!listType.Contains(account.AccountType))
                {
                    listType.Add(account.AccountType);
                }
            }
            this.cmbAccountType.DataSource = listType;
            this.cmbAccountType.SelectedIndex = -1;
        }


        private bool IsAccountExist(Account account)
        {
            if (object.Equals(_accountList, null) || _accountList.Count < 1)
            {
                return false;
            }
            else if (_accountList.FindIndex(p => p.AccountName.Equals(account.AccountName)) != -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private Account GetAccount()
        {
            if (Valid())
            {
                Account account = new Account(this.txtUserName.Text.Trim(), this.txtPassword.Text.Trim(), this._currentUser.UserName, this.cmbAccountType.Text);
                account.AccountPassword = SmellyEggCrypt.CryPtService.DESEncrypt(account.AccountPassword, this._currentUser.Key);
                return account;
            }
            else
            {
                return null;
            }
        }

        private bool Valid()
        {
            if (string.IsNullOrEmpty(this.txtPassword.Text.Trim()) || string.IsNullOrEmpty(this.txtUserName.Text.Trim())
                || string.IsNullOrEmpty(this.cmbAccountType.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void chxIsModify_CheckedChanged(object sender, System.EventArgs e)
        {
            if((sender as CheckBox).Checked)
            {
                this._currentType = CommonDictionary.AddType;
                this.btnOk.Text = "新增";
                this.txtPassword.Text = string.Empty;
                this.txtUserName.Text = string.Empty;
                this.cmbAccountType.Text = string.Empty;
                this.txtUserName.Focus();
            }
            else
            {
                this._currentType = CommonDictionary.ModefyType;
                this.btnOk.Text = "修改";
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnOk.PerformClick();
            }
        }

        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Filter();
            }
        }

        private void Filter()
        {
            if (string.IsNullOrEmpty(this.txtFilter.Text.Trim()))
            {
                this.accountListControl.SetAccountContent(_accountList);
            }
            else
            {
                string filterStr = this.txtFilter.Text.Trim();
                if (!object.Equals(_accountList, null) && _accountList.Count > 0)
                {
                    List<Account> filterList = _accountList.Where(p => p.AccountName.ToLower().IndexOf(filterStr.ToLower()) != -1).ToList();
                    this.accountListControl.SetAccountContent(filterList);
                }
            }
        }
    }
}
