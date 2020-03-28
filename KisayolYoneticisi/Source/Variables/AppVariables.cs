using KisayolYoneticisi.Source.BO;
using KisayolYoneticisi.Source.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KisayolYoneticisi.Source.Variables
{
    internal static class AppVariables
    {
        public static readonly DateTime DefaultTime = new DateTime(1753, 1, 1, 0, 0, 0);

        public static void Update(Kisayol _kisayol)
        {
            if (_kisayol == null || _kisayol == default(Kisayol))
                return;

            int indx = -1;
            indx = _AllList.IndexOf(_kisayol);

            if (indx == -1)
                return;

            _AllList[indx] = _kisayol;
        }

        public static void Add(Kisayol _kisayol)
        {
            if (_kisayol == null || _kisayol == default(Kisayol))
                return;

            _AllList.Add(_kisayol);
            return;
        }

        public static void Delete(Kisayol _kisayol)
        {
            if (_kisayol == null || _kisayol == default(Kisayol))
                return;

            int indx = -1;
            indx = _AllList.IndexOf(_kisayol);

            if (indx == -1)
                return;

            _AllList.RemoveAt(indx);
        }

        private static List<Kisayol> _AllList = new List<Kisayol>();

        internal static List<Kisayol> AllList
        {
            get { return _AllList; }
            set { _AllList = value; }
        }

        public static Kisayol GetById(int id)
        {
            try
            {
                return _AllList.AsQueryable().Where(k => k.Id == id).ToList()[0];
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Kisayol GetByName(string name)
        {
            try
            {
                return _AllList.AsQueryable().Where(k => k.KisayolAdi.Equals(name)).ToList()[0];
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Kisayol GetByPath(string yol)
        {
            try
            {
                return _AllList.AsQueryable().Where(k => k.Yol.Equals(yol)).ToList()[0];
            }
            catch (Exception)
            {
                return null;
            }
        }

        internal static string ConnectionString
        {
            get
            {
                return string.Format(
                    "Data Source={0}\\{1}; Version=3;New=True; Compress=True; Password=DilkiDepesi;",
                    Utility.ExecutablePath, AppVariables.DbFilePath);
            }
        }

        internal static string LogFilePath
        {
            get
            {
                try
                {
                    return System.Configuration.ConfigurationManager.AppSettings["logFileName"];
                }
                catch (Exception)
                {
                    return "log.txt";
                }
            }
        }

        public static string DbFilePath
        {
            get
            {
                try
                {
                    return System.Configuration.ConfigurationManager.AppSettings["dbFileName"];
                }
                catch (Exception)
                {
                    return "Veri.mp3";
                }
            }
        }
    }
}
