using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Roles
    {
        private Roles() { }
        public string Role_type { get; private set; }

        public Roles(string role)
        {
            this.Role_type = role;
        }
    }
}