using MyPasswordManager.Controller.DataBase;
using MyPasswordManager.Model;
using System.Collections.Generic;
using System.Data.SQLite;

namespace MyPasswordManager.Controller.CommonController
{
    public class accountController : baseDataBaseController
    {
        /// <summary>
        /// 获取账户列表
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public List<Account> GetAccountList(string userName)
        {
            string sql = @"select userName, accountName, password, accountType from Account t where userName = '{0}'";
            sql = string.Format(sql, userName);
            SQLiteDataReader reader = this.ExcuteReader(sql);
            List<Account> listAccount = new List<Account>();
            while (reader.Read())
            {
                Account obj = new Account();
                obj.UserName = reader[0].ToString();
                obj.AccountName = reader[1].ToString();
                obj.AccountPassword = reader[2].ToString();
                obj.AccountType = reader[3].ToString();
                listAccount.Add(obj);
            }
            reader.Close();
            this._connection.Close();
            return listAccount;
        }

        /// <summary>
        /// 新增账户
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public int InsertAccount(Account account)
        {
            string sql = @"insert into Account (userName, accountName, password, accountType) values ('{0}', '{1}', '{2}', '{3}')";
            sql = string.Format(sql, account.UserName, account.AccountName, account.AccountPassword, account.AccountType);
            return this.ExcuteNoQuery(sql);
        }

        /// <summary>
        /// 更新账户
        /// </summary>
        /// <param name="oldAccount"></param>
        /// <param name="newAccount"></param>
        /// <returns></returns>
        public int UpdateAccount(Account oldAccount, Account newAccount)
        {
            string sql = @"update Account set accountName = '{0}', password = '{1}', accountType = '{2}' where accountName = '{3}'";
            sql = string.Format(sql, newAccount.AccountName, newAccount.AccountPassword, newAccount.AccountType, oldAccount.AccountName);
            return this.ExcuteNoQuery(sql);
        }
    }
}
