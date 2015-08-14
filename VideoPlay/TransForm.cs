using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoPlay
{
    public class TransForm
    {
        /// <summary>
        /// 强制转换为INT32类型
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Int32 ToInt32(object obj)
        {
            if (obj == null)
            {
                return 0;
            }
            else
            {
                try
                {
                    return Convert.ToInt32(obj);
                }
                catch
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// 强制转换为DateTime类型
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static DateTime ToDateTime(object obj)
        {
            if (obj != null)
            {
                try
                {
                    return Convert.ToDateTime(obj);
                }
                catch
                {
                    return DateTime.Now;
                }
            }
            else
            {
                return DateTime.Now;
            }
        }

        /// <summary>
        /// 强制转换为String类型
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToString(object obj)
        {
            if (obj != null)
            {
                try
                {
                    return Convert.ToString(obj);
                }
                catch
                {
                    return "";
                }
            }
            else
            {
                return "";
            }
        }
        public static string ToString(object obj, int len)
        {
            if (obj != null)
            {
                try
                {
                    string str = Convert.ToString(obj);
                    if (str.Length > len)
                    {
                        str = str.Substring(0, len) + "...";
                    }
                    return str;
                }
                catch
                {
                    return "";
                }
            }
            else
            {
                return "";
            }
        }
        public static Decimal ToDecimal(object obj)
        {
            if (obj != null)
            {
                try
                {
                    return Convert.ToDecimal(obj);
                }
                catch
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// 强制转换为Double类型
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Double ToDouble(object obj)
        {
            if (obj != null)
            {
                try
                {
                    return Convert.ToDouble(obj);
                }
                catch
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 强制转变为Byte[]类型
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Byte[] ToByte(object obj)
        {
            if (obj != null)
            {
                try
                {
                    return System.Text.Encoding.UTF8.GetBytes(obj.ToString());
                }
                catch
                {
                    return new byte[0];
                }
            }
            else
            {
                return new byte[0];
            }
        }

        /// <summary>
        /// 强制转换为Boolean型
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Boolean ToBoolean(object obj)
        {
            if (obj != null)
            {
                try
                {
                    return Convert.ToBoolean(obj);
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}