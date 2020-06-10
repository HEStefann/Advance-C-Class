using System;
using System.Collections.Generic;
using System.Text;

namespace AdvanceCSharp___02.modals
{
    public class user
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Enum Role { get; set; }
        public string Grade { get; set; }
        public bool loggedIn { get; set; }
        public user(string username, string password, Enum role)
        {
            Username = username;
            Password = password;
            Role = role;
        }
    }
}
