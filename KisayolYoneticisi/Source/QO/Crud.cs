namespace KisayolYoneticisi.Source.QO
{
    class Crud
    {

        public static string DropQuery()
        {
            return "DROP TABLE IF EXISTS Kisayol";
        }

        internal static string CreateTableQuery()
        {
            return @"CREATE TABLE IF NOT EXISTS Kisayol(Id INTEGER PRIMARY KEY, 
                                                KisayolAdi TEXT,
                                                Yol TEXT, 
                                                Tarih TEXT);";
        }

        public static string GetIdentity()
        {
            return "SELECT ROWID FROM Kisayol Order By Id Desc LIMIT 1"; //"Select sqlite3_last_insert_rowid();";//"SELECT last_insert_rowid() AS rowid FROM Kisayol LIMIT 1";
        }

        public static string InsertQuery()
        {
            return @"Insert Into Kisayol(KisayolAdi, Yol, Tarih) Values(@KisayolAdi, @Yol, @Tarih);";//
        }

        public static string UpdateQuery()
        {
            return "Update Kisayol Set KisayolAdi=@KisayolAdi, Yol=@Yol, Tarih=@Tarih Where Id=@Id;";
        }

        public static string DeleteQuery()
        {
            return "Delete From Kisayol Where Id=@Id;";
        }

        public static string GetTable()
        {
            return "Select * From Kisayol;";
        }

    }
}
