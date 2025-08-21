using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05.Q._2
{
    internal interface IAuthenticationService
    {
        public bool AuthenticateUser(string UserName ,string Password);
        public bool AuthorizeUser(string UserName , Role Role);
    }
}
