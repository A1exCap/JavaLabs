namespace Lab13
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private MenuStrip mainMenu;
        private ToolStripMenuItem menuFormat;
        private ToolStripMenuItem menuService;
        private ToolStripMenuItem menuTable;
        private ToolStripMenuItem menuSpellCheck;
        private ToolStripSeparator separator;
        private ToolStripMenuItem menuStatistics;
        private ToolStripMenuItem menuLanguage;
        private ToolStripMenuItem menuSelectLanguage;
        private ToolStripMenuItem menuTranslation;
        private ToolStripMenuItem menuHyphenation;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.menuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuService = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSpellCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.separator = new System.Windows.Forms.ToolStripSeparator();
            this.menuStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSelectLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTranslation = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHyphenation = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTable = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();

            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormat,
            this.menuService,
            this.menuTable});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(484, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "mainMenu";

            this.menuFormat.Name = "menuFormat";
            this.menuFormat.Size = new System.Drawing.Size(57, 20);
            this.menuFormat.Text = "Format";
            this.menuFormat.Click += new System.EventHandler(this.FormatMenu_Click);

            this.menuService.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSpellCheck,
            this.separator,
            this.menuStatistics,
            this.menuLanguage});
            this.menuService.Name = "menuService";
            this.menuService.Size = new System.Drawing.Size(56, 20);
            this.menuService.Text = "Service";

            this.menuSpellCheck.Name = "menuSpellCheck";
            this.menuSpellCheck.Size = new System.Drawing.Size(180, 22);
            this.menuSpellCheck.Text = "Spell Check";
            this.menuSpellCheck.Click += new System.EventHandler(this.SpellCheck_Click);

            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(177, 6);

            this.menuStatistics.CheckOnClick = true;
            this.menuStatistics.Name = "menuStatistics";
            this.menuStatistics.Size = new System.Drawing.Size(180, 22);
            this.menuStatistics.Text = "Statistics";
            this.menuStatistics.Click += new System.EventHandler(this.Statistics_Click);

            this.menuLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSelectLanguage,
            this.menuTranslation,
            this.menuHyphenation});
            this.menuLanguage.Name = "menuLanguage";
            this.menuLanguage.Size = new System.Drawing.Size(180, 22);
            this.menuLanguage.Text = "Language";

            this.menuSelectLanguage.Name = "menuSelectLanguage";
            this.menuSelectLanguage.Size = new System.Drawing.Size(166, 22);
            this.menuSelectLanguage.Text = "Select Language";
            this.menuSelectLanguage.Click += new System.EventHandler(this.SelectLanguage_Click);

            this.menuTranslation.Name = "menuTranslation";
            this.menuTranslation.Size = new System.Drawing.Size(166, 22);
            this.menuTranslation.Text = "Translation";
            this.menuTranslation.Click += new System.EventHandler(this.Translation_Click);

            this.menuHyphenation.Name = "menuHyphenation";
            this.menuHyphenation.Size = new System.Drawing.Size(166, 22);
            this.menuHyphenation.Text = "Hyphenation";
            this.menuHyphenation.Click += new System.EventHandler(this.Hyphenation_Click);


            this.menuTable.Name = "menuTable";
            this.menuTable.Size = new System.Drawing.Size(47, 20);
            this.menuTable.Text = "Table";
            this.menuTable.Click += new System.EventHandler(this.TableMenu_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Form1";
            this.Text = "Menu Bar - Lab13";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}