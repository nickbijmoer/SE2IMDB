using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using SEWebapplicatieIMDB.Models;
using System.Web.UI.WebControls;

namespace SEWebapplicatieIMDB.Account
{
    using System.Threading;
    public partial class Register : System.Web.UI.Page
    {
        SEWebapplicatieIMDB.Classes.BusinessLayer BAM = new Classes.BusinessLayer();
        protected void CreateUser_Click(object sender, EventArgs e)
        {
          
         SEWebapplicatieIMDB.Classes.Account newaccount = new Classes.Account(TbFirstName.Text, TbLastName.Text,RbGender.SelectedValue,Convert.ToInt32(TbYearOfBirth.Text),TbCountry.Text,Convert.ToString(TbPostalCode.Text),TbEmail.Text,TbUserName.Text,TbPassword.Text);
         
           if(BAM.Registreren(newaccount) == true)
           {
               Response.Write("<script type=\"text/javascript\">alert('Registreren is gelukt!');</script>");
               Response.Redirect("/Default.aspx");
           }
           else
           {
               Response.Write("<script type=\"text/javascript\">alert('Registreren is mislukt!');</script>");
           }
        }
    }
}