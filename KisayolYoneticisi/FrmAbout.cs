using KisayolYoneticisi.Source.Log;
using KisayolYoneticisi.Source.Util;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace KisayolYoneticisi
{
    partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            try
            {
                InitializeComponent();
                this.Text = String.Format("About {0}", AssemblyTitle);
                this.labelProductName.Text = AssemblyTitle;
                this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
                this.labelCopyright.Text = AssemblyCopyright;
                this.labelCompanyName.Text = AssemblyCompany;
                this.textBoxDescription.Text = AssemblyDescription;
            }
            catch (Exception ex)
            {
                MessageUtil.Error("An Error occured at opening About Form!..");
                Logger.WriteException(ex, "An Error occured at opening About Form!..", "ERR_ABOUT_INIT"); ;
            }
        }

        private void FrmShortList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            { this.Close(); }
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                try
                {
                    object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                    if (attributes.Length > 0)
                    {
                        AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                        if (titleAttribute.Title != "")
                        {
                            return titleAttribute.Title;
                        }
                    }
                    return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public string AssemblyVersion
        {
            get
            {
                try
                {
                    return Assembly.GetExecutingAssembly().GetName().Version.ToString();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public string AssemblyDescription
        {
            get
            {
                try
                {
                    object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                    if (attributes.Length == 0)
                    {
                        return "This software has been made for decreasing shortcuts on the desktop. Use for good days.";
                    }
                    return ((AssemblyDescriptionAttribute)attributes[0]).Description;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public string AssemblyProduct
        {
            get
            {
                try
                {
                    object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                    if (attributes.Length == 0)
                    {
                        return "";
                    }
                    return ((AssemblyProductAttribute)attributes[0]).Product;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                try
                {
                    object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                    if (attributes.Length == 0)
                    {
                        return "";
                    }
                    return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public string AssemblyCompany
        {
            get
            {
                try
                {
                    object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                    if (attributes.Length == 0)
                    {
                        return "FreeSW Company";
                    }
                    return ((AssemblyCompanyAttribute)attributes[0]).Company;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        #endregion
    }
}
