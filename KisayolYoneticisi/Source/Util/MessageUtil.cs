using System.Windows.Forms;

namespace KisayolYoneticisi.Source.Util
{
    class MessageUtil
    {

        public static void Info(string infoText)
        {
            MessageBox.Show(infoText, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        public static void Error(string errText)
        {
            MessageBox.Show(errText, "Error!..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        public static void Warn(string warningText)
        {
            MessageBox.Show(warningText, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

    }
}
