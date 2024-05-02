using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Typograph5000
{
    public partial class MainForm : Form
    {
        public bool[] Settings { get; private set; }
        public MainForm()
        {
            InitializeComponent();
            Settings = new[]
            {
                false,
                true,
                true,
                true,
                true,
                true,
                true,
                true,
                true
            };
            UpdateSelectedTools();
        }

        public string FixPunctuationsMarks(string input)
        {
            var regex = new Regex(@"\s+(?=[,.!?:;...])");
            return regex.Replace(input, string.Empty);
        }
        
        public string FixWhitespaces(string input)
        {
            var regex = new Regex(@" +");
            return regex.Replace(input, " ");
        }

        public string FixQuotes(string input)
        {
            var regex = new Regex("\"(?=[^\\n]*\")");
            input = regex.Replace(input, "«");

            regex = new Regex("(?<=«[^\\n]*)\"");
            input = regex.Replace(input, "»");
            
            regex = new Regex("\"(?=[^\\n]*»)");
            input = regex.Replace(input, "«");

            return input;
        }

        public string FixHyphen(string input)
        {
            var regex = new Regex(@"\s*-\s*");
            return regex.Replace(input, "-");
        }
        
        public string FixDash(string input)
        {
            var regex = new Regex(@"\s?—\s?");
            return regex.Replace(input, "\u00a0— ");
        }
        
        public string FixK(string input)
        {
            var regex = new Regex(@"(okay)|(хорошо)|(окей)|((?<= )к(?= ))", RegexOptions.IgnoreCase);
            return regex.Replace(input, "k");
        }

        public string FixSatanSocialNetwork(string input)
        {
            var regex = new Regex(@"(instagram)|(инстаграмм?\w?)|(инст\w)", RegexOptions.IgnoreCase);
            return regex.Replace(input, "сатанисткая соц-сеть");
        }
        
        public string FixSymbols(string input)
        {
            var regex = new Regex(@"!{2,}");
            input = regex.Replace(input, "!!!");

            regex = new Regex(@"\?{2,}");
            input = regex.Replace(input, "???");
            
            regex = new Regex(@"\.{2,}");
            return regex.Replace(input, "...");
        }

        public void Check()
        {
            if (Settings[1])
            {
                textBox.Text = FixPunctuationsMarks(textBox.Text);
            }
            
            if (Settings[2])
            {
                textBox.Text = FixWhitespaces(textBox.Text);
            }
            
            if (Settings[3])
            {
                textBox.Text = FixQuotes(textBox.Text);
            }
            
            if (Settings[4])
            {
                textBox.Text = FixHyphen(textBox.Text);
            }
            
            if (Settings[5])
            {
                textBox.Text = FixDash(textBox.Text);
            }
            
            if (Settings[6])
            {
                textBox.Text = FixK(textBox.Text);
            }
            
            if (Settings[7])
            {
                textBox.Text = FixSatanSocialNetwork(textBox.Text);
            }
            
            if (Settings[8])
            {
                textBox.Text = FixSymbols(textBox.Text);
            }
        }
        
        private void checkButton_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox.Text);
        }

        private void MakeUnderline(ToolStripMenuItem e, bool make)
        {
            e.Font = make ? new Font(e.Font, FontStyle.Underline) :
                new Font(e.Font, FontStyle.Regular & FontStyle.Underline);
        }

        private void UpdateSelectedTools()
        {
            MakeUnderline(autoCheckToolStripMenuItem, Settings[0]);
            MakeUnderline(fixPunctuationsMarksToolStripMenuItem, Settings[1]);
            MakeUnderline(fixWhitespacesToolStripMenuItem, Settings[2]);
            MakeUnderline(fixQuotesToolStripMenuItem, Settings[3]);
            MakeUnderline(fixHyphentoolStripMenuItem, Settings[4]);
            MakeUnderline(fixDashtoolStripMenuItem, Settings[5]);
            MakeUnderline(fixKtoolStripMenuItem, Settings[6]);
            MakeUnderline(fixSatanSocialNetworkToolStripMenuItem, Settings[7]);
            MakeUnderline(fixSymbolsToolStripMenuItem, Settings[8]);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (Settings[0])
            {
                Check();
            }
        }

        private void SetSettings(int num)
        {
            Settings[num] = !Settings[num];
            UpdateSelectedTools();
        }
        
        private void autoCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSettings(0);
        }

        private void fixPunctuationsMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSettings(1);
        }

        private void fixWhitespacesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSettings(2);
        }

        private void fixQuotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSettings(3);
        }

        private void fixHyphentoolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSettings(4);
        }

        private void fixDashtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSettings(5);
        }

        private void fixKtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSettings(6);
        }

        private void fixSatanSocialNetworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSettings(7);
        }

        private void fixSymbolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSettings(8);
        }
    }
}