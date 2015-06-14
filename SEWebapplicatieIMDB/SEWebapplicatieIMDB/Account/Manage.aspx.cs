using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using SEWebapplicatieIMDB.Classes;
using SEWebapplicatieIMDB.Models;

namespace SEWebapplicatieIMDB.Account
{
    public partial class Manage : System.Web.UI.Page
    {
        BusinessAdministration BAM = new BusinessAdministration();
        protected void Page_Load()
        {
            
        }

        protected void SetPassword_Click(object sender, EventArgs e)
        {
            if (TbPassword.Text == TbConfirmPassword.Text)
            {
                int UserID = Convert.ToInt32(Session["UserID"]);
                BAM.ChangePassword(UserID);
                
            }
            else
            {
                Response.Write("<script type=\"text/javascript\">alert('De textboxen komen niet overeen!');</script>");
            }
        }   

       

       
   
    }
}