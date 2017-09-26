using MyPasswordManager.Controller.DataBase;
using MyPasswordManager.Model;
using System;

namespace MyPasswordManager.Controller.CommonController
{
    /// <summary>
    /// 登陆业务层
    /// </summary>
    public class loginController : baseDataBaseController
    {
        public string Tips = string.Empty;
        public string ErrorCode = string.Empty;

        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool Login(User user)
        {
            string sql = @"select count(1) from User where Name = '{0}' and password = '{1}'";
            try
            {
                sql = string.Format(sql, user.UserName, user.Password);
            }
            catch (Exception ex)
            {
                Logging.Error("格式化字符串出错：" + ex.Message);
            }
            string result = this.ExcuteReturnOne(sql);
            if (Converter.StringToInt(result) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Register(User user)
        {
            if (IsUserExist(user))
            {
                this.Tips = "已经存在相同用户名！";
                return false;
            }
            string sql = @"insert into User (Name, password, key) values ('{0}', '{1}', '{2}')";
            sql = string.Format(sql, user.UserName, user.Password, user.Key);
            if (this.ExcuteNoQuery(sql) == 1)
            {
                return true;
            }
            else
            {
                this.Tips = "注册失败！";
                return false;
            }
        }

        private bool IsUserExist(User user)
        {
            string sql = @"select count(1) from User where Name = '{0}'";
            sql = string.Format(sql, user.UserName);
            string result = this.ExcuteReturnOne(sql);
            if (Converter.StringToInt(result) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
