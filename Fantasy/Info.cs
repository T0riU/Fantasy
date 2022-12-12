using Fantasy.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Fantasy
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
            ChangeTheme(Theme.Colors[Settings.Default.UserTheme][Theme.ThemeCol.Primary], Theme.Colors[Settings.Default.UserTheme][Theme.ThemeCol.Secondary], Theme.Colors[Settings.Default.UserTheme][Theme.ThemeCol.Tertiary], Theme.Colors[Settings.Default.UserTheme][Theme.ThemeCol.Text]);
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ChangeTheme(Color primaryColor, Color secondaryColor, Color tertiaryColor, Color textColor)
        {
            OK.BackColor = secondaryColor;
            this.BackColor = tertiaryColor;
            this.ForeColor = textColor;
        }

        private void linkGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/T0riU");
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Info_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string ReadmeFileName = "Readme.pdf";
            if (File.Exists(ReadmeFileName))
            {
                System.Diagnostics.Process.Start(ReadmeFileName);
            }
            else
            {
                MessageBox.Show("Problem finding Readme file", "Error finding Readme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
