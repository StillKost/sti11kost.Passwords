using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sti11kost.Passwords.StringBuilder
{
    public interface IStringBuilder
    {
        string GetRandomString(int size, bool difirentRegister, bool useNumerics);
    }
}
