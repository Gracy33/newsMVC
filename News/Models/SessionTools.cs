using News.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace News.Models
{
    public class SessionTools
    {
        public static Utilisateur User
        {
            get { return (Utilisateur)HttpContext.Current.Session["User"]; }
            set { HttpContext.Current.Session["User"] = value; }

        }

        public static string Login
        {
            get
            {
                try
                {
                    return HttpContext.Current.Session["login"].ToString();
                }
                catch
                {
                    return null;
                }
            }

            set
            {
                HttpContext.Current.Session["login"] = value;
            }
        }
    }
}