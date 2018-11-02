using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Singleton
    {
        private static Singleton single;
        private List<User> users;
        private int count;

        private Singleton()
        {
            users = new List<User>();
            count = 1;
        }

        public static Singleton Get_singleton()
        {
            if (single == null)
            {
                single = new Singleton();
            }

            return single;
        }

        public void Set_user(string login, string password, string name)
        {
            User user = new User(count, login, password);
            user.Set_role(name);
            users.Add(user);
            count++;
        }

        public List<User> Get_users()
        {
            return users;
        }

        public void Remove_user(int i)
        {
            users.RemoveAt(i);
        }       
    }
}