using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sti11kost.Passwords.StringBuilder;

namespace sti11kost.Passwords.PasswordGenerator
{
    public class CustomPasswordGenerator : IPasswordGenerator
    {
        public int size { get; set; }
        public string includeString { get; set; }
        public bool difirentRegister { get; set; }
        public bool useNumerics { get; set; }
        RandomStringBuilder RandomStringBuilder { get; set; }

        public CustomPasswordGenerator() => RandomStringBuilder = new RandomStringBuilder();
        

        public string GeneratePassword()
        {
            int includeStrSize = 0;
            if (!string.IsNullOrEmpty(includeString))
            {
                includeString = includeString;
                includeStrSize = includeString.Length;
            }
            int newSize = size - includeStrSize;
            int random = new Random().Next(0, 11);
            return random % 2 == 0 ? (includeString) + RandomStringBuilder.GetRandomString(newSize, difirentRegister, useNumerics) 
                : RandomStringBuilder.GetRandomString(newSize, difirentRegister, useNumerics) + (includeString);
        }
    }
}
