using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sti11kost.Passwords
{
    public partial class Settings : Form
    {
        public Settings()
        {
            TopMost = true;
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            count.Value = Properties.Settings.Default.PasswordsCount;
            size.Value = Properties.Settings.Default.PasswordLength;
            exclude.Text = Properties.Settings.Default.ExcludeCharacters;
        }

        private void save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PasswordLength = (int) size.Value;
            Properties.Settings.Default.PasswordsCount = (int) count.Value;
            Properties.Settings.Default.ExcludeCharacters = exclude.Text;
            Properties.Settings.Default.Save();
            this.Close();
            this.Dispose();
        }
    }
}
