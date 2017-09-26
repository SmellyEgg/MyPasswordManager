using MyPasswordManager.Controller.CommonController;
using System;
using System.Data;
using System.Data.SQLite;

namespace MyPasswordManager.Controller.DataBase
{
    public class baseDataBaseController
    {
        /// <summary>
        /// 连接串
        /// </summary>
        private string _connectionStr = string.Empty;
        /// <summary>
        /// 连接实体
        /// </summary>
        public SQLiteConnection _connection;
        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="sql"></param>
        public int ExcuteNoQuery(string sql)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(this.GetConnection()))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(conn);
                    cmd.CommandText = sql;
                    int result =  cmd.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                Logging.Error("执行sql出错：" + ex.Message);
                return -1;
            }
        }

        /// <summary>
        /// 执行查询语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataSet ExcuteQuery(string sql)
        {
            using (SQLiteConnection conn = new SQLiteConnection(this.GetConnection()))
            {
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                DataSet ds = new DataSet();
                conn.Open();
                SQLiteDataAdapter da = new SQLiteDataAdapter(command);
                da.Fill(ds);
                da.Dispose();
                command.Dispose();
                conn.Close();
                return ds;
            }
        }

        /// <summary>
        /// 获取唯一返回值
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public string ExcuteReturnOne(string sql)
        {
            DataSet dtset = this.ExcuteQuery(sql);
            if (!object.Equals(dtset, null) && dtset.Tables.Count > 0 && dtset.Tables[0].Rows.Count > 0)
            {
                string value = dtset.Tables[0].Rows[0][0].ToString();
                return value;
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 执行查询返回reader
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public SQLiteDataReader ExcuteReader(string sql)
        {
            _connection = new SQLiteConnection(this.GetConnection());
            SQLiteCommand command = new SQLiteCommand(sql, _connection);
            _connection.Open();
            SQLiteDataReader reader = command.ExecuteReader();
            return reader;
        }

        /// <summary>
        /// 获取数据库路径
        /// </summary>
        /// <returns></returns>
        private string GetConnection()
        {
            if (string.IsNullOrEmpty(_connectionStr))
            {
                _connectionStr = "Data Source =" + System.Windows.Forms.Application.StartupPath + "\\choujidan.db";
            }
            return _connectionStr;
        }

    }
}
