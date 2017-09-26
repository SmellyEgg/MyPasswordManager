using System;

namespace MyPasswordManager.Controller.CommonController
{
    public class Converter
    {
        /// <summary>
        /// 字符串转整型
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int StringToInt(string str)
        {
            try
            {
                int result = Convert.ToInt32(str);
                return result;
            }
            catch
            {
                return -1;
            }
        }
    }
}
