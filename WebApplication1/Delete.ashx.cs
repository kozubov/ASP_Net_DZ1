using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for Delete
    /// </summary>
    public class Delete : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            int id;
            if (context.Request.QueryString["id"] != null)
            {
                id = Convert.ToInt32(context.Request.QueryString["id"]);
                var Fin_id = Singleton.Get_singleton().Get_users().Find(User => User.Id == id);
                if (Fin_id != null)
                {
                    Singleton.Get_singleton().Get_users().Remove(Fin_id);
                }
            }
            context.Server.Transfer("Users.aspx", true);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}