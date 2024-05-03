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

        public static string FixPunctuationsMarks(string input)
        {
            var regex = new Regex(@"\s+(?=[,.!?:;...])");
            return regex.Replace(input, string.Empty);
        }
        
        public static string FixWhitespaces(string input)
        {
            var regex = new Regex(@" +");
            return regex.Replace(input, " ");
        }

        public static string FixQuotes(string input)
        {
            var regex = new Regex("\"(?=[^\\n]*\")");
            input = regex.Replace(input, "«");

            regex = new Regex("(?<=«[^\\n]*)\"");
            input = regex.Replace(input, "»");
            
            regex = new Regex("\"(?=[^\\n]*»)");
            input = regex.Replace(input, "«");

            return input;
        }

        public static string FixHyphen(string input)
        {
            var regex = new Regex(@"\s*-\s*");
            return regex.Replace(input, "-");
        }
        
        public static string FixDash(string input)
        {
            var regex = new Regex(@"\s?—\s?");
            return regex.Replace(input, "\u00a0— ");
        }
        
        public static string FixK(string input)
        {
            var regex = new Regex(@"(okay)|(хорошо)|(окей)|((?<= )к(?= ))", RegexOptions.IgnoreCase);
            return regex.Replace(input, "k");
        }

        public static string FixSatanSocialNetwork(string input)
        {
            var regex = new Regex(@"(instagram)|(инстаграмм?\w?)|(инст\w)", RegexOptions.IgnoreCase);
            return regex.Replace(input, "сатанисткая соц-сеть");
        }
        
        public static string FixSymbols(string input)
        {
            var regex = new Regex(@"!{2,}");
            input = regex.Replace(input, "!!!");

            regex = new Regex(@"\?{2,}");
            input = regex.Replace(input, "???");
            
            regex = new Regex(@"\.{2,}");
            return regex.Replace(input, "...");
        }

        public string Check(string input)
        {
            if (Settings[1])
            {
                input = FixPunctuationsMarks(input);
            }
            
            if (Settings[2])
            {
                input = FixWhitespaces(input);
            }
            
            if (Settings[3])
            {
                input = FixQuotes(input);
            }
            
            if (Settings[4])
            {
                input = FixHyphen(input);
            }
            
            if (Settings[5])
            {
                input = FixDash(input);
            }
            
            if (Settings[6])
            {
                input = FixK(input);
            }
            
            if (Settings[7])
            {
                input = FixSatanSocialNetwork(input);
            }
            
            if (Settings[8])
            {
                input = FixSymbols(input);
            }

            return input;
        }
        
        private void checkButton_Click(object sender, EventArgs e)
        {
            textBox.Text = Check(textBox.Text);
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
                textBox.Text = Check(textBox.Text);
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