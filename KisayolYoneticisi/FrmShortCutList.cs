using IWshRuntimeLibrary;
using KisayolYoneticisi.Source.BO;
using KisayolYoneticisi.Source.Log;
using KisayolYoneticisi.Source.OpManager;
using KisayolYoneticisi.Source.QO;
using KisayolYoneticisi.Source.Util;
using KisayolYoneticisi.Source.Variables;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace KisayolYoneticisi
{
    public partial class FrmShortCutList : Form
    {

        #region [ Private Fields ]

        private List<Kisayol> shortCutList = new List<Kisayol>();
        private Thread thrdRun = null;
        private SaveFileDialog svFlDialog = null;

        #endregion


        #region [ FrmShortCutList Ctor ]

        public FrmShortCutList()
        {
            try
            {
                InitializeComponent();
                CheckForIllegalCrossThreadCalls = false;
            }
            catch (Exception ex)
            {
                MessageUtil.Error("Program could not be started.");
                Logger.WriteException(ex, "ListFormInitiliaze", "Program could not be started.");
            }
        }

        #endregion [ FrmShortCutList Ctor ]


        #region [ FrmShortCutList_Load method ]

        private void FrmShortCutList_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        #endregion


        #region [ FormLoad method ]

        void FormLoad()
        {
            try
            {
                double w = (double)this.Width / 12;
                this.lstShortCuts.Columns[0].Width = (int)(2 * w - 9);
                this.lstShortCuts.Columns[1].Width = (int)(7 * w - 9);
                this.lstShortCuts.Columns[2].Width = (int)(3 * w - 9);
                SQLiteManager.Execute(Crud.CreateTableQuery(), null);
                AppVariables.AllList = SQLiteManager.AllList();
                shortCutList = AppVariables.AllList;
                Utility.List2ListView(lstShortCuts, shortCutList);
                cmbxTur.SelectedIndex = 0;
                this.lstShortCuts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.None);
            }
            catch (Exception ex)
            {
                MessageUtil.Error("Program could not be started.");
                Logger.WriteException(ex, "ListFormLoad", "Program could not be loadaed.");
            }
        }

        #endregion


        #region [ lstShortCuts_DoubleClick method ]

        private void lstShortCuts_DoubleClick(object sender, EventArgs e)
        {
            RunProgram();
        }

        #endregion [ lstShortCuts_DoubleClick method ]


        #region [ RunProgram method ]

        private void RunProgram()
        {
            try
            {
                thrdRun = new Thread(new ThreadStart(this.RunThread));
                thrdRun.Start();
            }
            catch (Exception ex)
            {
                MessageUtil.Error("Program could not be started.");
                Logger.WriteException(ex, "RunProgram", "Program could not be started.");
            }
        }

        #endregion [ RunProgram method ]


        #region [ RunThread method ]

        void RunThread()
        {
            try
            {
                if (lstShortCuts.SelectedItems.Count > 0)
                {
                    string exeString = lstShortCuts.SelectedItems[0].SubItems[1].Text;
                    Process.Start(exeString);
                }
            }
            catch (Exception ex)
            {
                MessageUtil.Error("Program could not be started.");
                Logger.WriteException(ex, "RunThread", "Program could not be started.");
            }
        }

        #endregion


        #region [ Add method ]

        private void Add(Object sender, EventArgs e)
        {
            try
            {
                FrmShortCut kseg = new FrmShortCut();
                kseg.ShowDialog();
                if (kseg.DialogResult == DialogResult.OK)
                {
                    shortCutList = AppVariables.AllList;
                    Utility.List2ListView(lstShortCuts, shortCutList);
                }
                return;
            }
            catch (Exception ex)
            {
                MessageUtil.Error("Shortcuts could not be loaded.");
                Logger.WriteException(ex, "ShortCut DoubleClick", "Program could not be started.");
            }
        }

        #endregion [ Add method ]


        #region [ Update method ]

        private void Update(Object sender, EventArgs e)
        {
            try
            {
                if (lstShortCuts.Items.Count > 0 && lstShortCuts.SelectedItems.Count > 0)
                {
                    FrmShortCut kseg = new FrmShortCut(shortCutList[lstShortCuts.SelectedIndices[0]].Id);
                    kseg.ShowDialog();
                    if (kseg.DialogResult == DialogResult.OK)
                    {
                        shortCutList = AppVariables.AllList;
                        Utility.List2ListView(lstShortCuts, shortCutList);
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                MessageUtil.Error("An Error occured at Updating shortcut!..");
                Logger.WriteException(ex, "An error occured at updating shortcut.", "ERR_UPDATE");
            }
        }

        #endregion [ Update method ]


        #region [ Delete method ]

        private void Delete(Object sender, EventArgs e)
        {
            Delete();
        }

        private void Delete()
        {
            try
            {
                if (lstShortCuts.Items.Count > 0 && lstShortCuts.SelectedItems.Count > 0)
                {
                    System.Windows.Forms.DialogResult dr = MessageBox.Show(string.Format("This shortcut will be deleted,  Are you sure?\nName : {0}\nPath : {1}",
                        lstShortCuts.SelectedItems[0].SubItems[0].Text,
                        lstShortCuts.SelectedItems[0].SubItems[1].Text),
                        "Warning", MessageBoxButtons.YesNo);
                    if (dr != System.Windows.Forms.DialogResult.Yes)
                        return;

                    Kisayol ks = new Kisayol(shortCutList[lstShortCuts.SelectedIndices[0]].Id);
                    int ix = SQLiteManager.Delete(ks);
                    //ks.Delete();
                    AppVariables.Delete(ks);
                    string s = string.Empty;
                    switch (ix)
                    {
                        case 1:
                            s = "Delete Process is succesfull.";
                            break;

                        default:
                            s = "Delete Process is not succesfull.";
                            break;
                    }
                    MessageBox.Show(s, "Result");
                }
                shortCutList = AppVariables.AllList;
                Utility.List2ListView(lstShortCuts, shortCutList);
                return;
            }
            catch (Exception ex)
            {
                MessageUtil.Error("An Error occured at Deleting shortcut!..");
                Logger.WriteException(ex, "An error occured at deleting shortcut.", "ERR_DELETE");
            }
        }

        #endregion [ Delete method ]


        #region [ Search method ]

        private void Search(object sender, EventArgs ke)
        {
            try
            {
                int i = cmbxTur.SelectedIndex;
                switch (i)
                {
                    case 0:
                        shortCutList = AppVariables.AllList.Where(k => k.KisayolAdi.ToLowerInvariant().Contains(txtArama.Text.ToLowerInvariant())).ToList<Kisayol>();
                        break;

                    case 1:
                        shortCutList = AppVariables.AllList.Where(k => k.Yol.ToLowerInvariant().Contains(txtArama.Text.ToLowerInvariant())).ToList<Kisayol>();
                        break;

                    default:
                        shortCutList = AppVariables.AllList;
                        break;
                }
                if (shortCutList == null)
                    shortCutList = new List<Kisayol>();

                Utility.List2ListView(lstShortCuts, shortCutList);
            }
            catch (Exception ex)
            {
                Logger.WriteException(ex, "Search Operation Failed.", "SHRTCUT_ERR");
            }
        }

        #endregion [ Search method ]


        #region [ exitToolStripMenuItem_Click method ]

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion [ exitToolStripMenuItem_Click method ]


        #region [ toolItemAbout method ]

        private void toolItemAbout(object sender, EventArgs e)
        {
            FrmAbout frmAb = new FrmAbout();
            frmAb.ShowDialog();
        }

        #endregion [ toolItemAbout method ]


        #region [ exportToExcel method ]

        private void exportToExcel(object sender, EventArgs e)
        {
            exportToExcel();
        }

        private static void exportToExcel()
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageUtil.Error("Export Operation Failed.");
                Logger.WriteException(ex, "ShortCut Export", "Export Operation Failed.");
            }
        }

        #endregion [ exportToExcel method ]


        #region [ openInFileExplorer method ]

        private void openInFileExplorer(object sender, EventArgs e)
        {
            try
            {
                if (lstShortCuts.SelectedItems.Count == 0)
                {
                    MessageUtil.Warn("Please Select A Shortcut!..");
                    return;
                }
                string path = string.Format("{0}", lstShortCuts.SelectedItems[0].SubItems[1].Text);
                if (path.Replace(" ", "").Length == 0)
                {
                    MessageUtil.Warn("Invalid Shortcut Path!..");
                    return;
                }

                string arg = string.Format("/Select, \"{0}\"", path);
                ProcessStartInfo pfi = new ProcessStartInfo("Explorer.exe", arg);
                System.Diagnostics.Process.Start(pfi);
                pfi = null;
            }
            catch (Exception ex)
            {
                MessageUtil.Error("Open In File Explorer Operation Failed.");
                Logger.WriteException(ex, "OpenInFileExplorer", "Open In File Explorer Operation Failed.");
            }
        }

        #endregion [ openInFileExplorer method ]


        #region [ KeyDownMethod method ]

        private void KeyDownMethod(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    RunProgram();
                    return;
                }

                if (e.KeyCode == Keys.Delete)
                {
                    Delete();
                    return;
                }

                if (e.KeyCode == Keys.F1)
                {
                    FrmAbout frmAb = new FrmAbout();
                    frmAb.ShowDialog();
                    return;
                }

                if (e.KeyCode == Keys.F2)
                {
                    ProgramShortcuts();
                    return;
                }
                if (e.Control && e.KeyCode == Keys.D)
                {
                    CreateShortCut();
                    return;
                }

                if (e.Control && e.KeyCode == Keys.S)
                {
                    txtArama.Focus();
                    return;
                }
                if (e.Control && e.KeyCode == Keys.L)
                {
                    lstShortCuts.Focus();
                    return;
                }
                if (e.Control && e.KeyCode == Keys.E)
                {
                    //Export To excel
                    exportToExcel();
                    return;
                }
                if (e.Control && e.KeyCode == Keys.I)
                {
                    if (e.Shift == true)
                        return;
                    // Ctrl + Shift + I : Import From Xml
                    //Import from Excel.
                    return;
                }
                if (e.Control && e.KeyCode == Keys.X)
                {
                    // Export to Xml file.
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageUtil.Error("An Error occured at Key Pressed!..");
                Logger.WriteException(ex, "An Error occured at Key pressed!..", "ERR_KEY_PRESS"); ;
            }
        }

        #endregion [ KeyDownMethod method ]


        #region [ shortcutListToolStripMenuItem_Click method ]

        private void shortcutListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgramShortcuts();
        }

        #endregion [ shortcutListToolStripMenuItem_Click method ]


        #region [ ProgramShortcuts method ]

        private static void ProgramShortcuts()
        {
            FrmShortList frmshrt = new FrmShortList();
            frmshrt.ShowDialog();
        }

        #endregion [ ProgramShortcuts method ]


        #region [ createToolStripMenuItem_Click method ]

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateShortCut();
        }

        #endregion [ createToolStripMenuItem_Click method ]


        #region [ CreateShortCut method ]

        private void CreateShortCut()
        {
            CreateShortCut(Environment.SpecialFolder.Desktop, @"\ShortcutManager.lnk");
            return;
        }

        private void CreateShortCut(Environment.SpecialFolder flder, string DosyaYolu)
        {
            try
            {
                IWshRuntimeLibrary.IWshShortcut kisayol;
                WshShell ws = new WshShell();
                kisayol = (IWshShortcut)ws.CreateShortcut(Environment.GetFolderPath(flder) + DosyaYolu);
                kisayol.TargetPath = Application.ExecutablePath;
                kisayol.Description = "This software has been made for decreasing shortcuts on the desktop. Use for good days.\nMade By : Nusty\nPath : " + Application.ExecutablePath;
                kisayol.IconLocation = Application.StartupPath + @"\monitor.ico";
                kisayol.Save();
            }
            catch (Exception ex)
            {
                MessageUtil.Error("Shortcut could not be created.");
                Logger.WriteException(ex, "Shortcut could not be created.", "ERR_SHORT_CREATE"); ;
            }
        }

        #endregion [ CreateShortCut method ]


        #region [ txtArama_KeyDown method ]

        private void txtArama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.L)
            {
                lstShortCuts.Focus();
            }
        }

        #endregion [ txtArama_KeyDown method ]


        #region [ elementsAtListToolStripMenuItem_Click method ]

        private void elementsAtListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstShortCuts.Items.Count == 0)
                {
                    MessageUtil.Warn("Shortcut List must contain one item at leats.");
                    return;
                }

                List<Kisayol> list = new List<Kisayol>();
                Kisayol ks = null;

                for (int counter = 0; counter < lstShortCuts.Items.Count; counter++)
                {
                    ks = null;
                    ks = new Kisayol()
                    {
                        KisayolAdi = lstShortCuts.Items[counter].SubItems[0].Text,
                        Yol = lstShortCuts.Items[counter].SubItems[1].Text
                    };
                    list.Add(ks);
                }

                bool result = ExportToFile(list);
                if (result)
                {
                    MessageUtil.Info("Export Operation successed.");
                }
                else
                {
                    MessageUtil.Error("Export Operation failed.");
                }
            }
            catch (Exception ex)
            {
                MessageUtil.Error("Export Operation Failed.");
                Logger.WriteException(ex, "Selected ShortCut Export", "Export Operation Failed.");
            }
        }

        #endregion


        #region [ allListToolStripMenuItem_Click method ]

        private void allListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = ExportToFile(shortCutList);
                if (result)
                {
                    MessageUtil.Info("Export Operation successed.");
                }
                else
                {
                    MessageUtil.Error("Export Operation failed.");
                }
            }
            catch (Exception ex)
            {
                MessageUtil.Error("Export Operation Failed.");
                Logger.WriteException(ex, "All ShortCut Export", "Export Operation Failed.");
            }
        }

        #endregion


        #region [ ExportToFile method ]

        bool ExportToFile(List<Kisayol> list)
        {
            bool res = false;
            try
            {
                svFlDialog = new SaveFileDialog();
                DialogResult dr = svFlDialog.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK || dr == System.Windows.Forms.DialogResult.Yes)
                {
                    string fileName = svFlDialog.FileName;
                    if (ObjectUtility.ToStr(fileName).Replace(" ", "").Length == 0)
                    {
                        MessageUtil.Warn("Save File Name can not be empty.");
                        return res;
                    }

                    if (fileName.EndsWith(".xls") == false)
                    {
                        fileName += ".xls";
                    }

                    res = ExportManager.ExportToExcel(list, fileName);
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                svFlDialog = null;
            }

            return res;
        }

        #endregion

    }
}