namespace Lyrics_Translation_Appender
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lRCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.translationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.Lyrics = new System.Windows.Forms.TextBox();
            this.Translate = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.ScrollbarSyncTimer = new System.Windows.Forms.Timer(this.components);
            this.LyricLines = new System.Windows.Forms.Label();
            this.TranslationLines = new System.Windows.Forms.Label();
            this.button_Addspace = new System.Windows.Forms.Button();
            this.MainStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainStrip
            // 
            this.MainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.MainStrip.Location = new System.Drawing.Point(0, 0);
            this.MainStrip.Name = "MainStrip";
            this.MainStrip.Size = new System.Drawing.Size(935, 24);
            this.MainStrip.TabIndex = 0;
            this.MainStrip.Text = "MainStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lRCToolStripMenuItem,
            this.translationToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // lRCToolStripMenuItem
            // 
            this.lRCToolStripMenuItem.Name = "lRCToolStripMenuItem";
            this.lRCToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.lRCToolStripMenuItem.Text = "LRC";
            // 
            // translationToolStripMenuItem
            // 
            this.translationToolStripMenuItem.Name = "translationToolStripMenuItem";
            this.translationToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.translationToolStripMenuItem.Text = "Translation";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.editToolStripMenuItem.Text = "Settings";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appendToolStripMenuItem,
            this.forwardToolStripMenuItem,
            this.replaceToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.aboutToolStripMenuItem.Text = "Translate";
            // 
            // appendToolStripMenuItem
            // 
            this.appendToolStripMenuItem.Name = "appendToolStripMenuItem";
            this.appendToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.appendToolStripMenuItem.Text = "Append";
            this.appendToolStripMenuItem.Click += new System.EventHandler(this.appendToolStripMenuItem_Click);
            // 
            // forwardToolStripMenuItem
            // 
            this.forwardToolStripMenuItem.Name = "forwardToolStripMenuItem";
            this.forwardToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.forwardToolStripMenuItem.Text = "Forward";
            this.forwardToolStripMenuItem.Click += new System.EventHandler(this.forwardToolStripMenuItem_Click);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.replaceToolStripMenuItem.Text = "Replace";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(744, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Lyrics
            // 
            this.Lyrics.Location = new System.Drawing.Point(12, 37);
            this.Lyrics.Multiline = true;
            this.Lyrics.Name = "Lyrics";
            this.Lyrics.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Lyrics.Size = new System.Drawing.Size(300, 520);
            this.Lyrics.TabIndex = 4;
            this.Lyrics.WordWrap = false;
            this.Lyrics.TextChanged += new System.EventHandler(this.Lyrics_TextChanged);
            // 
            // Translate
            // 
            this.Translate.Location = new System.Drawing.Point(318, 37);
            this.Translate.Multiline = true;
            this.Translate.Name = "Translate";
            this.Translate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Translate.Size = new System.Drawing.Size(300, 520);
            this.Translate.TabIndex = 5;
            this.Translate.WordWrap = false;
            this.Translate.TextChanged += new System.EventHandler(this.Translate_TextChanged);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(624, 37);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Result.Size = new System.Drawing.Size(300, 520);
            this.Result.TabIndex = 6;
            this.Result.WordWrap = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(100, 560);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(95, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Put the lrc file here";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(413, 560);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(116, 13);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Put the translation here";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(741, 560);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(37, 13);
            this.linkLabel3.TabIndex = 9;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "output";
            // 
            // ScrollbarSyncTimer
            // 
            this.ScrollbarSyncTimer.Interval = 10;
            this.ScrollbarSyncTimer.Tick += new System.EventHandler(this.ScrollbarSyncTimer_Tick);
            // 
            // LyricLines
            // 
            this.LyricLines.AutoSize = true;
            this.LyricLines.Location = new System.Drawing.Point(12, 559);
            this.LyricLines.Name = "LyricLines";
            this.LyricLines.Size = new System.Drawing.Size(32, 13);
            this.LyricLines.TabIndex = 10;
            this.LyricLines.Text = "Lines";
            // 
            // TranslationLines
            // 
            this.TranslationLines.AutoSize = true;
            this.TranslationLines.Location = new System.Drawing.Point(315, 560);
            this.TranslationLines.Name = "TranslationLines";
            this.TranslationLines.Size = new System.Drawing.Size(32, 13);
            this.TranslationLines.TabIndex = 11;
            this.TranslationLines.Text = "Lines";
            // 
            // button_Addspace
            // 
            this.button_Addspace.Location = new System.Drawing.Point(536, 563);
            this.button_Addspace.Name = "button_Addspace";
            this.button_Addspace.Size = new System.Drawing.Size(73, 24);
            this.button_Addspace.TabIndex = 12;
            this.button_Addspace.Text = "Add Spaces";
            this.button_Addspace.UseVisualStyleBackColor = true;
            this.button_Addspace.Click += new System.EventHandler(this.button_Addspace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 596);
            this.Controls.Add(this.button_Addspace);
            this.Controls.Add(this.TranslationLines);
            this.Controls.Add(this.LyricLines);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Translate);
            this.Controls.Add(this.Lyrics);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MainStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainStrip;
            this.Name = "Form1";
            this.Text = "lrc file translator v1.4.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainStrip.ResumeLayout(false);
            this.MainStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Lyrics;
        private System.Windows.Forms.TextBox Translate;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.ToolStripMenuItem lRCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem translationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Timer ScrollbarSyncTimer;
        private System.Windows.Forms.Label LyricLines;
        private System.Windows.Forms.Label TranslationLines;
        private System.Windows.Forms.Button button_Addspace;
    }
}

