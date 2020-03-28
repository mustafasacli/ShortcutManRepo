using KisayolYoneticisi.Source.BO;
using System;
using System.Collections.Generic;
using System.Data;

namespace KisayolYoneticisi.Source.Util
{
    class DataUtility
    {
        public static List<Kisayol> ToList(DataTable dt)
        {
            try
            {
                List<Kisayol> list = new List<Kisayol>();
                Kisayol ks = null;
                foreach (DataRow row in dt.Rows)
                {
                    ks = new Kisayol()
                    {
                        Id = ObjectUtility.Str2Int(row["Id"].ToString()),
                        KisayolAdi = row["KisayolAdi"].ToString(),
                        Yol = row["Yol"].ToString(),
                        Tarih = ObjectUtility.Str2Date(row["Tarih"].ToString())
                    };
                    list.Add(ks);
                }
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
