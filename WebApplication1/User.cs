using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class User
    {
        private Roles role;
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public User(int id, string login, string password)
        {
            Id = id;
            Login = login == "" ? "null" : login;
            Password = password == "" ? "null" : password;
        }

        public void Set_role(string name)
        {
            role = new Roles(name);
        }

        public Roles Get_role()
        {
            return role;
        }       
    }
}