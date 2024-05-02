namespace Typograph5000
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.checkButton = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fixPunctuationsMarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixWhitespacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixQuotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixHyphentoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixDashtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixKtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixSatanSocialNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixSymbolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox.Location = new System.Drawing.Point(0, 27);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(800, 423);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "Hello World";
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // menu
            // 
            this.menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu.BackgroundImage")));
            this.menu.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.checkButton, this.copyToolStripMenuItem, this.settingsToolStripMenuItem });
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menu";
            // 
            // checkButton
            // 
            this.checkButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(80, 20);
            this.checkButton.Text = "Проверить";
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.copyToolStripMenuItem.Text = "Копировать";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.autoCheckToolStripMenuItem, this.toolStripSeparator1, this.fixPunctuationsMarksToolStripMenuItem, this.fixWhitespacesToolStripMenuItem, this.fixQuotesToolStripMenuItem, this.fixHyphentoolStripMenuItem, this.fixDashtoolStripMenuItem, this.fixKtoolStripMenuItem, this.fixSatanSocialNetworkToolStripMenuItem, this.fixSymbolsToolStripMenuItem });
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.settingsToolStripMenuItem.Text = "Настройки";
            // 
            // autoCheckToolStripMenuItem
            // 
            this.autoCheckToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F);
            this.autoCheckToolStripMenuItem.Name = "autoCheckToolStripMenuItem";
            this.autoCheckToolStripMenuItem.Size = new System.Drawing.Size(617, 22);
            this.autoCheckToolStripMenuItem.Text = "Автоматическая правка";
            this.autoCheckToolStripMenuItem.Click += new System.EventHandler(this.autoCheckToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(614, 6);
            // 
            // fixPunctuationsMarksToolStripMenuItem
            // 
            this.fixPunctuationsMarksToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F);
            this.fixPunctuationsMarksToolStripMenuItem.Name = "fixPunctuationsMarksToolStripMenuItem";
            this.fixPunctuationsMarksToolStripMenuItem.Size = new System.Drawing.Size(617, 22);
            this.fixPunctuationsMarksToolStripMenuItem.Text = "Слитные слева со словом знаки препинания";
            this.fixPunctuationsMarksToolStripMenuItem.Click += new System.EventHandler(this.fixPunctuationsMarksToolStripMenuItem_Click);
            // 
            // fixWhitespacesToolStripMenuItem
            // 
            this.fixWhitespacesToolStripMenuItem.Name = "fixWhitespacesToolStripMenuItem";
            this.fixWhitespacesToolStripMenuItem.Size = new System.Drawing.Size(617, 22);
            this.fixWhitespacesToolStripMenuItem.Text = "Не более одного пробела подряд";
            this.fixWhitespacesToolStripMenuItem.Click += new System.EventHandler(this.fixWhitespacesToolStripMenuItem_Click);
            // 
            // fixQuotesToolStripMenuItem
            // 
            this.fixQuotesToolStripMenuItem.Name = "fixQuotesToolStripMenuItem";
            this.fixQuotesToolStripMenuItem.Size = new System.Drawing.Size(617, 22);
            this.fixQuotesToolStripMenuItem.Text = "Елочки вместо «\"»";
            this.fixQuotesToolStripMenuItem.Click += new System.EventHandler(this.fixQuotesToolStripMenuItem_Click);
            // 
            // fixHyphentoolStripMenuItem
            // 
            this.fixHyphentoolStripMenuItem.Name = "fixHyphentoolStripMenuItem";
            this.fixHyphentoolStripMenuItem.Size = new System.Drawing.Size(617, 22);
            this.fixHyphentoolStripMenuItem.Text = "Дефиз без окраймляющих пробелов";
            this.fixHyphentoolStripMenuItem.Click += new System.EventHandler(this.fixHyphentoolStripMenuItem_Click);
            // 
            // fixDashtoolStripMenuItem
            // 
            this.fixDashtoolStripMenuItem.Name = "fixDashtoolStripMenuItem";
            this.fixDashtoolStripMenuItem.Size = new System.Drawing.Size(617, 22);
            this.fixDashtoolStripMenuItem.Text = "Между тире и предыдущим словом непереносимый пробел";
            this.fixDashtoolStripMenuItem.Click += new System.EventHandler(this.fixDashtoolStripMenuItem_Click);
            // 
            // fixKtoolStripMenuItem
            // 
            this.fixKtoolStripMenuItem.Name = "fixKtoolStripMenuItem";
            this.fixKtoolStripMenuItem.Size = new System.Drawing.Size(617, 22);
            this.fixKtoolStripMenuItem.Text = "Не хорошо и не окей, а k";
            this.fixKtoolStripMenuItem.Click += new System.EventHandler(this.fixKtoolStripMenuItem_Click);
            // 
            // fixSatanSocialNetworkToolStripMenuItem
            // 
            this.fixSatanSocialNetworkToolStripMenuItem.Name = "fixSatanSocialNetworkToolStripMenuItem";
            this.fixSatanSocialNetworkToolStripMenuItem.Size = new System.Drawing.Size(617, 22);
            this.fixSatanSocialNetworkToolStripMenuItem.Text = "Не *Instagram (Издатель Meta признан экстремистом на территории РФ), а сатанистск" + "ая соц-сеть";
            this.fixSatanSocialNetworkToolStripMenuItem.Click += new System.EventHandler(this.fixSatanSocialNetworkToolStripMenuItem_Click);
            // 
            // fixSymbolsToolStripMenuItem
            // 
            this.fixSymbolsToolStripMenuItem.Name = "fixSymbolsToolStripMenuItem";
            this.fixSymbolsToolStripMenuItem.Size = new System.Drawing.Size(617, 22);
            this.fixSymbolsToolStripMenuItem.Text = "Использовать адекватное количество восклицательных и вопросительных знаков, троет" + "очий";
            this.fixSymbolsToolStripMenuItem.Click += new System.EventHandler(this.fixSymbolsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Text = "Typograph5000";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem fixSymbolsToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem fixSatanSocialNetworkToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem fixDashtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fixHyphentoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fixKtoolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem checkButton;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem fixWhitespacesToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem fixQuotesToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem fixPunctuationsMarksToolStripMenuItem;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        private System.Windows.Forms.ToolStripMenuItem autoCheckToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menu;

        private System.Windows.Forms.RichTextBox textBox;

        #endregion
    }
}