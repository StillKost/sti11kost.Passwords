using System;
using System.Collections.Generic;
using System.Windows.Forms;
using sti11kost.Passwords.PasswordGenerator;
using System.Threading;

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
            ResetErrorMessages(new List<Label>() {
                sizeError, includeStrWarning, countErrorMsg
            });

            var passwordGenerator = new CustomPasswordGenerator();

            passwordGenerator.size = int.TryParse(size.Text, out int _size) ? _size : -1;

            if (passwordGenerator.size == -1)
            {
                AddErrorMessage(sizeError, "Введите число!");
                return;
            }

            passwordGenerator.includeString = !string.IsNullOrEmpty(includeStr.Text) ? includeStr.Text : "";
            passwordGenerator.difirentRegister = difirentRegister.Checked ? true : false;
            passwordGenerator.useNumerics = useNums.Checked ? true : false;
            passwordGenerator.useSpecDigits = useSpecDigits.Checked ? true : false;


            if (includeStr.Text.Length > _size)
            {
                AddErrorMessage(includeStrWarning, "Входная строка больше указанного размера.");
            }

            if (int.TryParse(passwordsCount.Text, out int passwordsCont))
            {
                if (passwordsCont > 10)
                {
                    countErrorMsg.ForeColor = System.Drawing.Color.Orange;
                    AddErrorMessage(countErrorMsg, "Максимум 10.");
                }
                else
                {
                    for (int i = 0; i < passwordsCont; i++)
                    {
                        PrintPassword(totalPasswords, passwordGenerator.GeneratePassword());
                        // In order to would be no identical passwords.
                        Thread.Sleep(10);
                    }
                }
            }
            else
            {
                countErrorMsg.ForeColor = System.Drawing.Color.Red;
                AddErrorMessage(countErrorMsg, "Введите число!");                
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

        private void PrintPassword(TextBox textBox, List<string> list)
        {
            foreach (string str in list)
            {
                textBox.Text += str + "\r\n";
            }
        }

        private void PrintPassword(TextBox textBox, string str)
        {
            textBox.Text += str + "\r\n";
        }
        #endregion
    }
}
