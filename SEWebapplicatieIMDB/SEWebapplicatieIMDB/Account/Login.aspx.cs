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
            RegisterHyperLink.NavigateUrl = "Register";
            OpenAuthLogin.ReturnUrl = Request.QueryString["ReturnUrl"];
            var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (!String.IsNullOrEmpty(returnUrl))
            {
                RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }
        }

        protected void LogIn(object sender, EventArgs e)
        {
           Account loginGebruiker = BAM.login(TbGebruikersnaam.Text, TbPassword.Text);

            if (User is Admin)
            {
                Session[myKeys.key_accountID] = User.AccountID;
                Session[myKeys.key_rights] = "admin";
            }
            else if (User is Account)
            {
                Session[myKeys.key_accountID] = User.AccountID;
                Session[myKeys.key_rights] = "user";
                Console.WriteLine("user");
            }

            Response.Redirect("/pages/dashboard.aspx");  
        }
    }
}