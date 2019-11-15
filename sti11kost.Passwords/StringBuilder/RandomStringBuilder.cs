using System;
using System.Text;

namespace sti11kost.Passwords.StringBuilder
{
    public class RandomStringBuilder : IStringBuilder
    {
        public string GetRandomString(int size, bool difirentRegister, bool useNumerics)
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                // ch = (char)new Random().Next('a', 'z');
                if (difirentRegister)
                {
                    ch = random.Next(0, 11) % 2 == 0 ? ch.ToString().ToUpperInvariant().ToCharArray()[0]
                        : ch.ToString().ToLowerInvariant().ToCharArray()[0];
                }

                if (useNumerics && random.Next(0, 11) % 2 == 0)
                {
                    ch = random.Next(0, 11).ToString().ToCharArray()[0];
                }

                builder.Append(ch);
            }

            return builder.ToString();
        }
    }
}
