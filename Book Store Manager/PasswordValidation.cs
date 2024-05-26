using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup.Localizer;

namespace Book_Store_Manager
{
    public class PasswordValidation
    {
        public bool Validate(string password)
        {
            string Symbols = "~!@#$%^&*()_+}{;:/.,";
            bool Upper, lower, Symbol, Numbers;
            Upper = lower = Symbol = Numbers = false;
            foreach(char c in password)
            {
                if (c >= 'a' && c <= 'z')
                    lower = true;
                else if (c >= 'A' && c <= 'Z')
                    Upper = true;
                else if (c >= '0' && c <= '9')
                    Numbers = true;
                else if (Symbols.Contains(c))
                    Symbol = true;
            }
            return Upper && lower && Symbol && Numbers;
        }
    }
}
