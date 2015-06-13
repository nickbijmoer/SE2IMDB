using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using SEWebapplicatieIMDB.Classes;
using SEWebapplicatieIMDB.Models;

namespace SEWebapplicatieIMDB.Account
{
    public partial class Login : Page
    {
        BusinessAdministration BAM = new BusinessAdministration();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Session[UserID])
            {
                                

            }
        }

        protected void LogIn(object sender, EventArgs e)
        {
           Classes.Account loginGebruiker = BAM.login(TbUserName.Text, TbPassword.Text);

           Session["UserID"] = loginGebruiker.UserID;
           Session["UserName"] = loginGebruiker.UserName;
           Session["Rol"] = loginGebruiker.Rol;

        }
    }
}