using KisayolYoneticisi.Source.Variables;
using System;

namespace KisayolYoneticisi.Source.BO
{
    /// <summary>
    ///
    /// </summary>
    public class Kisayol
    {
        #region [ Ctors ]

        public Kisayol(int Id)
        {
            this.Id = Id;
        }

        public Kisayol()
        {
        }

        #endregion [ Ctors ]

        #region [ Properties ]

        public int Id { get; set; } = -1;

        public string KisayolAdi { get; set; } = string.Empty;

        public string Yol { get; set; } = string.Empty;

        public DateTime Tarih { get; set; } = AppVariables.DefaultTime;

        #endregion [ Properties ]

        public override bool Equals(object obj)
        {
            bool res = false;

            Kisayol k = obj as Kisayol;

            if (k != null && k != default(Kisayol))
            {
                res = k.Id == this.Id;
            }

            return res;
        }
    }
}
