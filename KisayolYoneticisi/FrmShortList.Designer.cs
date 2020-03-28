namespace KisayolYoneticisi
{
    partial class FrmShortList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShortList));
            this.txtProgramShortcutList = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtProgramShortcutList
            // 
            this.txtProgramShortcutList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProgramShortcutList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProgramShortcutList.Location = new System.Drawing.Point(0, 0);
            this.txtProgramShortcutList.Name = "txtProgramShortcutList";
            this.txtProgramShortcutList.ReadOnly = true;
            this.txtProgramShortcutList.Size = new System.Drawing.Size(284, 261);
            this.txtProgramShortcutList.TabIndex = 0;
            this.txtProgramShortcutList.Text = resources.GetString("txtProgramShortcutList.Text");
            this.txtProgramShortcutList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmShortList_KeyDown);
            // 
            // FrmShortList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtProgramShortcutList);
            this.Name = "FrmShortList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program Shortcut List";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmShortList_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtProgramShortcutList;
    }
}