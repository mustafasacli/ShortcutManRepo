using KisayolYoneticisi.Source.Util;
using KisayolYoneticisi.Source.Variables;
using System;
using System.IO;
using System.Text;

namespace KisayolYoneticisi.Source.Log
{
    class Logger
    {
        internal static void WriteException(Exception ex, string title, string responseCode)
        {
            try
            {
                StringBuilder strBuilder = new StringBuilder();
                strBuilder.AppendLine(String.Format("Date : {0:d.MM.yyyy HH:mm:ss}", DateTime.Now));
                strBuilder.AppendLine(String.Format("Title : {0}", title));
                strBuilder.AppendLine(String.Format("Response Code : {0}", responseCode));
                strBuilder.AppendLine(String.Format("Message : {0}", ex.Message));
                strBuilder.AppendLine(String.Format("Stack Trace : {0}", ex.StackTrace));
                strBuilder.AppendLine("/***************************************/");
                FileMode fMode = File.Exists(string.Format("{0}\\{1}", Utility.ExecutablePath, AppVariables.LogFilePath)) == true ? FileMode.Append : FileMode.OpenOrCreate;
                using (StreamWriter sw = new StreamWriter(new FileStream(string.Format("{0}\\{1}", Utility.ExecutablePath, AppVariables.LogFilePath), fMode)))
                {
                    sw.Write(strBuilder.ToString());
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
