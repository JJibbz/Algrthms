using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algrthms
{
    public class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }

        public User(string _login, string _name, bool _isPremium)
        {
            Login = _login;
            Name = _name;
            IsPremium = _isPremium;
        }
    }
}
