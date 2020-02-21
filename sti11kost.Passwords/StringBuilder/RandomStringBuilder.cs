using System;
using System.Linq;

namespace sti11kost.Passwords.StringBuilder
{
    public class RandomStringBuilder : IStringBuilder
    {
        private int Counter = 0;
        public string GetRandomString(int size, bool difirentRegister, bool useNumerics, bool useSpecDigits, string[] unusebleDigits)
        {
            // String of chars.
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            // String of spec digits.
            string specDigits = "!@#$%^&*()_-+={}[]\\|?/";

            Random random = new Random((int)DateTime.Now.Ticks);
            System.Text.StringBuilder builder = new System.Text.StringBuilder();

            for (int i = 0; i < size; i++)
            {
                // Get random char from string of chars.
                char ch = characters[random.Next(characters.Length)];

                bool randomOrder = random.Next(-9999, 9999) % 2 == 0;

                if (difirentRegister)
                {
                    ch = random.Next(0, 11) % 2 == 0 ? ch.ToString().ToUpperInvariant().ToCharArray()[0]
                        : ch.ToString().ToLowerInvariant().ToCharArray()[0];
                }

                if (useNumerics && randomOrder)
                {
                    ch = random.Next(0, 11).ToString().ToCharArray()[0];
                }

                if (useSpecDigits && (randomOrder && FindSpecDigits(builder.ToString(), specDigits.ToCharArray())))
                {
                    char digit = specDigits.ToCharArray()[random.Next(0, specDigits.Length - 1)];
                    ch = digit;
                }

                while (unusebleDigits.ToList().Any(x => x == ch.ToString()))
                {
                    if (Counter >= size)
                    {
                        return "< Не удалось сгенерировать пароль удовлетворяющий всем условиям >";
                    }
                    ch = characters[random.Next(characters.Length)];
                    if (useNumerics && random.Next(-9999, 9999) % 2 == 0)
                    {
                        ch = random.Next(0, 11).ToString().ToCharArray()[0];
                    }
                    Counter++;
                }

                builder.Append(ch);
            }

            return builder.ToString();
        }

        /// <summary>
        /// Count of spec. digits in current string.
        /// </summary>
        /// <param name="str"> Current string. </param>
        /// <param name="digits"> All special digits. </param>
        /// <returns>Boolean: if spec. digits count = 3 => false, else => true. </returns>
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
