namespace TerminplanungWIP_prototyp2
{
    partial class MainFrame
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.MMItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MMItemViews = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackgroundImage = global::TerminplanungWIP_prototyp2.Properties.Resources.Bg1;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MMItemFile,
            this.MMItemViews});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(693, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "mainMenu";
            // 
            // MMItemFile
            // 
            this.MMItemFile.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MMItemFile.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.MMItemFile.Name = "MMItemFile";
            this.MMItemFile.Size = new System.Drawing.Size(46, 20);
            this.MMItemFile.Text = "&Datei";
            this.MMItemFile.MouseLeave += new System.EventHandler(this.MMItemFile_MouseLeave);
            this.MMItemFile.MouseEnter += new System.EventHandler(this.MMItemFile_MouseEnter);
            // 
            // MMItemViews
            // 
            this.MMItemViews.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MMItemViews.Name = "MMItemViews";
            this.MMItemViews.Size = new System.Drawing.Size(59, 20);
            this.MMItemViews.Text = "&Ansicht";
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 444);
            this.Controls.Add(this.mainMenu);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainFrame";
            this.Text = "Terminplanung für Wiederholungsprüfungen";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem MMItemFile;
        private System.Windows.Forms.ToolStripMenuItem MMItemViews;
    }
}

