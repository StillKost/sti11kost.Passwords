using System;
using System.Text;

namespace sti11kost.Passwords.StringBuilder
{
    public class RandomStringBuilder : IStringBuilder
    {
        public string GetRandomString(int size, bool difirentRegister, bool useNumerics, bool useSpecDigits)
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string specDigits = "!@#$%^&*()_-+={}[]\\|?/";
            Random random = new Random((int)DateTime.Now.Ticks);
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
           
            for (int i = 0; i < size; i++)
            {
                char ch;
                ch = characters[random.Next(characters.Length)];
                if (difirentRegister)
                {
                    ch = random.Next(0, 11) % 2 == 0 ? ch.ToString().ToUpperInvariant().ToCharArray()[0]
                        : ch.ToString().ToLowerInvariant().ToCharArray()[0];
                }

                if (useNumerics && random.Next(-9999, 9999) < 0)
                {
                    ch = random.Next(0, 11).ToString().ToCharArray()[0];
                }

                if (useSpecDigits && (random.Next(-9999, 9999) % 2 == 0 && FindSpecDigits(builder.ToString(), specDigits.ToCharArray())))
                {
                    char digit = specDigits.ToCharArray()[random.Next(0, specDigits.Length - 1)];
                    ch = digit;
                }

                builder.Append(ch);
            }

            return builder.ToString();
        }

        private bool FindSpecDigits(string str, char[] digits)
        {
            char[] arr = str.ToCharArray();
            int counter = 0;
            foreach (char digit in digits)
            {
                if (str.Contains(digit.ToString()))
                    counter++;

                if (counter == 3)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
