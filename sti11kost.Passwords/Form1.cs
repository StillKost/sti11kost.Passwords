using System;
using System.Collections.Generic;
using System.Windows.Forms;
using sti11kost.Passwords.PasswordGenerator;

namespace sti11kost.Passwords
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            int _count = 1;

            ResetErrorMessages(new List<Label>() {
                sizeError
            });

            CustomPasswordGenerator passwordGenerator = new CustomPasswordGenerator();
            if(int.TryParse(size.Text, out int _size))
            {
                passwordGenerator.size = _size;
            }
            else
            {
                AddErrorMessage(sizeError, "Введите число!");
                return;
            }

            if (!string.IsNullOrEmpty(includeStr.Text))
            {
                passwordGenerator.includeString = includeStr.Text;
            }
            else
            { }

            if (difirentRegister.Checked)
            {
                passwordGenerator.difirentRegister = true;
            }
            else
            {
                passwordGenerator.difirentRegister = false;
            }

            if (useNums.Checked)
            {
                passwordGenerator.useNumerics = true;
            }
            else
            {
                passwordGenerator.useNumerics = false;
            }

            for(int i = 0; i < _count; i++)
            {
                totalPasswords.Text += passwordGenerator.GeneratePassword() + "\r\n";
            }
        }


        #region Private Actions
        private void AddErrorMessage(Label label, string text)
        {
            label.Text = text;
        }

        private void ResetErrorMessages(List<Label> labels)
        {
            totalPasswords.Text = "";
            foreach (Label l in labels)
            {
                l.Text = " ";
            }
        }
        #endregion
    }
}
