namespace MyPasswordManager.Model
{
    /// <summary>
    /// 用户实体
    /// </summary>
    public class User
    {
        private string userName = string.Empty;

        private string password = string.Empty;

        private string key = string.Empty;

        public User(string name, string newpassword)
        {
            this.userName = name;
            this.password = newpassword;
        }

        public User(string name, string newpassword, string newkey)
        {
            this.userName = name;
            this.password = newpassword;
            this.key = newkey;
        }

        /// <summary>
        /// 用户名
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
        /// 用户密码
        /// </summary>
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        /// <summary>
        /// 用户密钥
        /// </summary>
        public string Key
        {
            get
            {
                return key;
            }

            set
            {
                key = value;
            }
        }
    }
}
