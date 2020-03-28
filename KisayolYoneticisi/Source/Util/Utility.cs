using KisayolYoneticisi.Source.BO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KisayolYoneticisi.Source.Util
{
    class Utility
    {

        public static string ExecutablePath
        {
            get
            {
                try
                {
                    return Application.StartupPath;
                }
                catch (Exception)
                {
                    return string.Empty;
                }
            }
        }

        public static void List2ListView(ListView lstVw, List<Kisayol> kisayollar)
        {
            try
            {
                lstVw.Items.Clear();

                foreach (Kisayol ks in kisayollar)
                {
                    lstVw.Items.Add(
                           new ListViewItem(new string[]{
                        ks.KisayolAdi,
                        ks.Yol,
                        ObjectUtility.Date2String(ks.Tarih)
                    }));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
