using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05.Q._2
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private string? StoredUserName => "admin";
        private string? StoredPassword => "12345";
        private Role StoredRole => 0;
        public string? UserName { get; set; } 
        public string? Password { get; set; }
        public Role Role { set; get; }

        public bool AuthenticateUser(string UserName, string Password)
        {
            return UserName == StoredUserName && Password == StoredPassword ;
        }

        public bool AuthorizeUser(string UserName, Role Role)
        {
            return UserName == StoredUserName && Role == StoredRole;
        }
    }
}
