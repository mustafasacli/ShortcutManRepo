using KisayolYoneticisi.Source.BO;
using KisayolYoneticisi.Source.Log;
using KisayolYoneticisi.Source.OpManager;
using KisayolYoneticisi.Source.Util;
using KisayolYoneticisi.Source.Variables;
using System;
using System.Windows.Forms;

namespace KisayolYoneticisi
{
    public partial class FrmShortCut : Form
    {

        #region [ Private Fields ]

        int shortcutId = -1;

        #endregion


        #region [ Ctors ]

        public FrmShortCut()
            : this(-1)
        {
        }

        public FrmShortCut(int shortcut_id)
        {
            try
            {
                InitializeComponent();
                shortcutId = shortcut_id;
                if (shortcutId != -1)
                {
                    Kisayol ks = AppVariables.GetById(shortcut_id);
                    if (null != ks)
                    {
                        txtName.Text = ks.KisayolAdi;
                        txtPath.Text = ks.Yol;
                        this.Text = "Shortcut Update";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageUtil.Error("ShortCut Operation failed.");
                Logger.WriteException(ex, "ShortCutFormInitiliaze", "ShortCut Operation failed.");
            }
        }

        #endregion


        #region [ Save method ]

        void Save(Object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageUtil.Warn("Invalid ShortCut Name!..");
                    return;
                }

                if (String.IsNullOrWhiteSpace(txtPath.Text))
                {
                    MessageUtil.Warn("Invalid ShortCut Path!..");
                    return;
                }

                if (shortcutId > 0)
                {
                    Kisayol ks = AppVariables.GetById(shortcutId);
                    ks.Yol = txtPath.Text;
                    ks.KisayolAdi = txtName.Text;
                    int i = SQLiteManager.Update(ks);
                    //ks.Update();
                    AppVariables.Update(ks);
                    if (i == 1)
                    {
                        this.DialogResult = DialogResult.OK;
                        return;
                    }

                    MessageUtil.Error("Update is failed.");
                    this.DialogResult = DialogResult.Abort;
                    return;
                }
                else
                {
                    Kisayol ks = AppVariables.GetByName(txtName.Text);
                    if (ks != null)
                    {
                        MessageUtil.Warn("There is already a Shortcut with given name, please write another name!..");
                        return;
                    }
                    ks = new Kisayol();
                    ks.Yol = txtPath.Text;
                    ks.KisayolAdi = txtName.Text;
                    ks.Tarih = DateTime.Now;
                    int _retInt = SQLiteManager.Add(ks);
                    //ks.Add();
                    if (_retInt == 1)
                    {
                        ks.Id = SQLiteManager.GetIdentity();
                        AppVariables.Add(ks);
                        this.DialogResult = DialogResult.OK;
                        return;
                    }

                    this.DialogResult = DialogResult.Abort;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageUtil.Error("ShortCut could not be saved.");
                Logger.WriteException(ex, "ShortCutSave", "ShortCut could not be saved.");
            }
        }

        #endregion


        #region [ Cancel nethod ]

        void Cancel(Object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #endregion


        #region [ Browse method ]

        void Browse(Object sender, EventArgs e)
        {
            try
            {
                ofd.FileName = string.Empty;
                ofd.Title = "Please Select Application Path";
                ofd.Filter = "(*.exe)|*.exe|(*.msc)|*.msc|(*.msi)|*.msi|(*.jar)|*.jar|(*.lnk)|*.lnk";
                ofd.FilterIndex = 1; // varsayılan olarak jpg uzantıları göster
                ofd.InitialDirectory = Environment.GetFolderPath(
                    Environment.SpecialFolder.DesktopDirectory);//,Environment.SpecialFolderOption.None);
                ofd.ShowDialog();
                if (string.IsNullOrWhiteSpace(ofd.FileName) == false)
                {
                    txtPath.Text = ofd.FileName;
                }
                return;
            }
            catch (Exception ex)
            {
                MessageUtil.Error("ShortCut Browse operation failed.");
                Logger.WriteException(ex, "ShortCutBrowse", "ShortCut Browse operation failed.");
            }
        }

        #endregion

    }
}
