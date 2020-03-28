using KisayolYoneticisi.Source.BO;
using KisayolYoneticisi.Source.QO;
using KisayolYoneticisi.Source.Util;
using KisayolYoneticisi.Source.Variables;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace KisayolYoneticisi.Source.OpManager
{
    class SQLiteManager
    {

        #region [ GetResultSet method ]

        internal static DataSet GetResultSet(string sorgu, params DbParam[] parameters)
        {
            try
            {
                DataSet ds = new DataSet();
                using (SQLiteConnection conn = new SQLiteConnection(AppVariables.ConnectionString))
                {
                    using (SQLiteCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = sorgu;
                        conn.Open();
                        if (parameters != null)
                        {
                            foreach (var prm in parameters)
                            {
                                cmd.Parameters.AddWithValue(prm.Name, prm.Value);
                            }
                        }
                        using (SQLiteDataAdapter dbAdapter = new SQLiteDataAdapter(cmd))
                        {
                            dbAdapter.Fill(ds);
                        }
                        cmd.Parameters.Clear();
                    }// end command               
                }// end connection
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion


        #region [ Execute method ]

        internal static int Execute(string query, params DbParam[] parameters)
        {
            try
            {
                int retInt = -1;
                using (SQLiteConnection conn = new SQLiteConnection(AppVariables.ConnectionString))
                {
                    conn.Open();
                    using (SQLiteTransaction trans = conn.BeginTransaction())
                    {
                        using (SQLiteCommand cmd = conn.CreateCommand())
                        {
                            try
                            {
                                cmd.CommandText = query;
                                cmd.Transaction = trans;
                                if (parameters != null)
                                {
                                    foreach (var prm in parameters)
                                    {
                                        cmd.Parameters.AddWithValue(prm.Name, prm.Value);
                                    }
                                }
                                retInt = cmd.ExecuteNonQuery();
                                trans.Commit();
                            }
                            catch (Exception)
                            {
                                trans.Rollback();
                                throw;
                            }
                            finally
                            {
                                cmd.Parameters.Clear();
                                conn.Close();
                            }
                        }// end command
                    }// end transaction
                }// end connection
                return retInt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion


        #region [ ExecuteScalar method ]

        internal static object ExecuteScalar(string query, params DbParam[] parameters)
        {
            try
            {
                object retObj = null;
                using (SQLiteConnection conn = new SQLiteConnection(AppVariables.ConnectionString))
                {
                    conn.Open();
                    using (SQLiteTransaction trans = conn.BeginTransaction())
                    {
                        using (SQLiteCommand cmd = conn.CreateCommand())
                        {
                            try
                            {
                                cmd.CommandText = query;
                                cmd.Transaction = trans;
                                if (parameters != null)
                                {
                                    foreach (var prm in parameters)
                                    {
                                        cmd.Parameters.AddWithValue(prm.Name, prm.Value);
                                    }
                                }
                                retObj = cmd.ExecuteScalar();
                                trans.Commit();
                            }
                            catch (Exception)
                            {
                                trans.Rollback();
                                throw;
                            }
                            finally
                            {
                                cmd.Parameters.Clear();
                                conn.Close();
                            }
                        }// end command
                    }// end transaction
                }// end connection
                return retObj;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion


        #region [ Add method]

        public static int Add(Kisayol kisayol)
        {
            int retInt = -1;

            try
            {
                retInt = Execute(Crud.InsertQuery(),//en son isactive eklenecek.
                 new DbParam { Name = "@KisayolAdi", Value = kisayol.KisayolAdi },
                 new DbParam { Name = "@Yol", Value = kisayol.Yol },
                 new DbParam { Name = "@Tarih", Value = kisayol.Tarih });
                // return string.Format("{0}", obj).Str2Int();
            }
            catch (Exception)
            {
                throw;
            }

            return retInt;
        }

        #endregion


        #region [ Delete method ]

        public static int Delete(Kisayol kisayol)
        {
            int retInt = -1;

            try
            {
                retInt = Execute(Crud.DeleteQuery(), new DbParam { Name = "@Id", Value = kisayol.Id });
            }
            catch (Exception)
            {
                throw;
            }

            return retInt;
        }

        #endregion


        #region [ Update method ]

        public static int Update(Kisayol kisayol)
        {
            int retInt = -1;

            try
            {
                retInt = Execute(Crud.UpdateQuery(),
                 new DbParam { Name = "@KisayolAdi", Value = kisayol.KisayolAdi },
                 new DbParam { Name = "@Yol", Value = kisayol.Yol },
                 new DbParam { Name = "@Tarih", Value = kisayol.Tarih },
                 new DbParam { Name = "@Id", Value = kisayol.Id });
            }
            catch (Exception)
            {
                throw;
            }

            return retInt;
        }

        #endregion


        #region [ GetTable method ]

        public static DataTable GetTable()
        {
            try
            {
                DataTable dt = GetResultSet(Crud.GetTable(), null).Tables[0];
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion


        #region [ AllList method ]

        public static List<Kisayol> AllList()
        {
            try
            {
                return DataUtility.ToList(GetTable());
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        public static int GetIdentity()
        {
            int retInt = -1;

            try
            {
                DataTable dt = GetResultSet(Crud.GetIdentity()).Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    retInt = ObjectUtility.ToInt(row[0]);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return retInt;
        }

    }
}
