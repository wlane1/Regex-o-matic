using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace REGEX_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string SearchString()
        {
            string query = RegexStrTextBox.Text;
            return query;
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            string errorMessage = "No match found";
            string matchString = TextStrTextBox.Text;

            Regex regex = new Regex(SearchString());

            Match match = regex.Match(matchString);

            if (match.Success)
            {
                // ヽ༼ຈل͜ຈ༽ﾉ      Drive Hard      ヽ༼ຈل͜ຈ༽ﾉ
                ReturnLabel.Text = match.Value;
                // ヽ༼ຈل͜ຈ༽ﾉ      Drive Hard      ヽ༼ຈل͜ຈ༽ﾉ
            }
            else
            {
                // ᕙ༼ຈل͜ຈ༽ᕗ DRIVE MUSTANG ᕙ༼ຈل͜ຈ༽ᕗ
                ReturnLabel.Text = errorMessage;
                // ᕙ༼ຈل͜ຈ༽ᕗ DRIVE MUSTANG ᕙ༼ຈل͜ຈ༽ᕗ
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var optionForm = new Options();
            optionForm.Show();
        }

    }
}
