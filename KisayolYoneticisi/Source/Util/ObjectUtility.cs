using KisayolYoneticisi.Source.Variables;
using System;

namespace KisayolYoneticisi.Source.Util
{
    class ObjectUtility
    {

        public static string ToStr(object obj)
        {
            try
            {
                return obj.ToString();
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        public static DateTime Str2Date(string str)
        {
            try
            {
                return DateTime.Parse(str);
            }
            catch (Exception)
            {
                return AppVariables.DefaultTime;
            }
        }


        public static string Date2String(DateTime date)
        {
            try
            {
                return string.Format("{0:yyyy.MM.dd HH:mm:ss}", date);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int Str2Int(string str)
        {
            int i;
            int.TryParse(str, out i);
            return i;
        }

        public static int ToInt(object obj)
        {
            try
            {
                return Str2Int(ToStr(obj));
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
