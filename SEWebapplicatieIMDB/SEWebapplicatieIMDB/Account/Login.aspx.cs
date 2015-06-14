using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.UI;
using SEWebapplicatieIMDB.Classes;
using SEWebapplicatieIMDB.Models;

namespace SEWebapplicatieIMDB.Account
{
    public partial class Login : Page
    {
        BusinessLayer BAM = new BusinessLayer();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void LogIn(object sender, EventArgs e)
        {
           Classes.Account loginGebruiker = BAM.login(TbUserName.Text, TbPassword.Text);

            if (loginGebruiker == null)
            {
            Response.Write("<script type=\"text/javascript\">alert('Verkeerde inlog gegevens!');</script>");
            }
            else
            {
                Session["UserID"] = loginGebruiker.UserID;
                Session["UserName"] = loginGebruiker.UserName;
                Session["Rol"] = loginGebruiker.Rol; 
                Response.Redirect("/Default.aspx");
            }
         

        }
    }
}