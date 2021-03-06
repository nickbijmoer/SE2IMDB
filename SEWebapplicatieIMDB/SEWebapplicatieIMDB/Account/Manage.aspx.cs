﻿using Microsoft.AspNet.Identity;
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
        BusinessLayer BAM = new BusinessLayer();
        protected void Page_Load()
        {
            
        }

        //on click method used to change password
        protected void SetPassword_Click(object sender, EventArgs e)
        {
            //Check again if textboxes matches
            if (TbPassword.Text == TbConfirmPassword.Text)
            {
                //Get userID
                int UserID = Convert.ToInt32(Session["UserID"]);
                //change password in database
                bool ishetgelukt = BAM.ChangePassword(UserID, TbPassword.Text);
                //if password is changed in databse, get an possitive response
                if (ishetgelukt == true)
                {
                Response.Write("<script type=\"text/javascript\">alert('Password changed!!');</script>");
                Response.Redirect("/Default.aspx");
                }
                //if password is not changed get an negative response
                else
                {
                Response.Write("<script type=\"text/javascript\">alert('Er is iets fout gegaan.');</script>");
                }
                
            }
            //if they dont match, get an response
            else
            {
                Response.Write("<script type=\"text/javascript\">alert('De textboxen komen niet overeen!');</script>");
            }
        }   

       

       
   
    }
}