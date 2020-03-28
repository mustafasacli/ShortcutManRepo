using System.Windows.Forms;

namespace KisayolYoneticisi
{
    public partial class FrmShortList : Form
    {
        public FrmShortList()
        {
            InitializeComponent();
        }

        private void FrmShortList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            { this.Close(); }
        }
    }
}
