using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;


namespace Lyrics_Translation_Appender
{
 
    public partial class MainForm : Form
    {
        DevCircuit.TranslateFromLRC Translator;
        DevCircuit.Settings UserSettings;
        
        public MainForm()
        {
            InitializeComponent();
            Translator = new DevCircuit.TranslateFromLRC();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lyrics.Text = "";
            Translate.Text = "";
            Result.Text = "";
        }

        private void appendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Result.Text = "";
            try
            {
                
                Translator = new DevCircuit.TranslateFromLRC(Lyrics.Text, Translate.Text);
                Translator.MySettings.IgnoreEmprtyLyrics = true;
                Translator.MySettings.IgnoreEmptryTranslation = true;
                AddCredits();
            }
            catch (DevCircuit.TranslateFromLRC.TranslateFailException er)
            {
                MessageBox.Show(er.Message);
            }
            Result.Lines = Translator.Append();
        }

        private void forwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Result.Text = "";
           
            try
            {
                Translator = new DevCircuit.TranslateFromLRC(Lyrics.Text, Translate.Text);
                Translator.MySettings.IgnoreEmprtyLyrics = true;
                Translator.MySettings.IgnoreEmptryTranslation = true;
                AddCredits();
            }
            catch (DevCircuit.TranslateFromLRC.TranslateFailException er)
            {
                MessageBox.Show(er.Message);
            }

            try
            {
                Result.Lines = Translator.Forward();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Result.Text = "";
            try
            {
                Translator = new DevCircuit.TranslateFromLRC(Lyrics.Text, Translate.Text);
                Translator.MySettings.IgnoreEmprtyLyrics = true;
                Translator.MySettings.IgnoreEmptryTranslation = true;
                AddCredits();
            }
            catch (DevCircuit.TranslateFromLRC.TranslateFailException er)
            {
                MessageBox.Show(er.Message);
            }
            Result.Lines = Translator.Replace();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("It is the file with the format [mm:ss.ss]lyrics\n*or click file and open an .lrc file");
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LRCAboutBox openAbout = new LRCAboutBox();
            openAbout.StartPosition = FormStartPosition.CenterParent;
            openAbout.ShowDialog();

           
        }

        private void AddCredits()
        {
            Translator.EditorName = textBox_editor.Text;
            
            Translator.SourceName = textBox_source.Text.Trim((":/.").ToCharArray());
        }


        [DllImport("user32.dll")]
        static extern int GetScrollPos(IntPtr hWnd, int nBar);

        [DllImport("user32.dll")]
        static extern int SetScrollPos(IntPtr hWnd, int nBar, int nPos, bool bRedraw);

        const int SB_HORZ = 0;
        const int SB_VERT = 1;
        const int SB_CTL = 2;
 
        private void ScrollbarSyncTimer_Tick(object sender, EventArgs e)
        {
            int scrollPos = GetScrollPos(Lyrics.Handle, SB_VERT);
            SetScrollPos(Translate.Handle, SB_VERT, scrollPos, true);

            System.Windows.Forms.Application.DoEvents();

        }

        private void Lyrics_TextChanged(object sender, EventArgs e)
        {
            LyricLines.Text = string.Format("{0} Lines", DevCircuit.TranslateFromLRC.CalulateLineNumbers(Lyrics.Text));
            ScrollbarSyncTimer.Start();
        }

        private void Translate_TextChanged(object sender, EventArgs e)
        {
            TranslationLines.Text = string.Format("{0} Lines", DevCircuit.TranslateFromLRC.CalulateLineNumbers(Translate.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserSettings = new DevCircuit.Settings();


            Assembly thisAssem = typeof(Lyrics_Translation_Appender.MainForm).Assembly;
            AssemblyName thisAssemName = thisAssem.GetName();

            Version ver = thisAssemName.Version;
            this.Text = string.Format("{0} {1}",thisAssemName.Name, ver);
        }

        private void button_Addspace_Click(object sender, EventArgs e)
        {
            string GetText = Translate.Text;
            string[] Arr = ConvertToStringArray(GetText);
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] += "\n";
                if (Arr[i] == "\r\n")
                    Arr[i] = " \r\n";
            }
            Translate.Text = "";
            for (int i = 0; i < Arr.Length; i++)
            {
                Translate.Text += Arr[i];
            }
        }

        public string[] ConvertToStringArray(string x)
        {
            List<string> tmp = new List<string>();
            string stor = "";
            for (int j = 0; j < x.Length; j++)
            {
                if (x[j] != '\n' /*|| x[j] != '\r'*/)
                {
                    stor += x[j];
                }
                else
                {
                    tmp.Add(stor);
                    stor = "";
                }
            }
            return tmp.ToArray();
        }

     

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Warning", "Are you sure you want to clear you current work?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Lyrics.Text = "";
                Translate.Text = "";
                Result.Text = "";
            }
        }

        private void Lyrics_MouseUp(object sender, MouseEventArgs e)
        {
            Translate.PerformLayout();
        }

        private void Translate_MouseUp(object sender, MouseEventArgs e)
        {
            Translate.PerformLayout();
        }

        private void button_copy_Click(object sender, EventArgs e)
        {
            button_copy.BackColor = System.Drawing.Color.Red;
            try {
                Clipboard.SetText(Result.Text, TextDataFormat.Text);
                button_copy.BackColor = System.Drawing.Color.Green;
            }
            catch { }
        }
    }
}
