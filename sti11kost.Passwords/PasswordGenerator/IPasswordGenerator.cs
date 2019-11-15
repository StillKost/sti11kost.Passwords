using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sti11kost.Passwords.PasswordGenerator
{
    public interface IPasswordGenerator
    {
        string GeneratePassword();
    }
}
