using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutorizationBotHH
{
    public class User
    {
        public string ?login = Environment.GetEnvironmentVariable("credentinals.Login");
        public string ?password = Environment.GetEnvironmentVariable("credentinals.Password");

    }
}
