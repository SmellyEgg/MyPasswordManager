namespace MyPasswordManager.Model
{
    /// <summary>
    /// 账户实体
    /// </summary>
    public class Account
    {
        private string accountName = string.Empty;

        private string accountPassword = string.Empty;

        private string userName = string.Empty;

        private string accountType = string.Empty;

        public Account()
        {

        }

        public Account(string name, string password, string username, string type)
        {
            this.accountName = name;
            this.accountPassword = password;
            this.userName = username;
            this.accountType = type;
        }

        /// <summary>
        /// 账户名称
        /// </summary>
        public string AccountName
        {
            get
            {
                return accountName;
            }

            set
            {
                accountName = value;
            }
        }

        /// <summary>
        /// 账户密码
        /// </summary>
        public string AccountPassword
        {
            get
            {
                return accountPassword;
            }

            set
            {
                accountPassword = value;
            }
        }

        /// <summary>
        /// 用户名，用于与账户进行关联
        /// </summary>
        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        /// <summary>
        /// 账户类型，用于过滤什么的
        /// </summary>
        public string AccountType
        {
            get
            {
                return accountType;
            }

            set
            {
                accountType = value;
            }
        }
    }
}
