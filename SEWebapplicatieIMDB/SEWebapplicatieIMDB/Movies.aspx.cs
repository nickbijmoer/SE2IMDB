using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SEWebapplicatieIMDB.Classes;

namespace SEWebapplicatieIMDB
{
    
    public partial class Movies : System.Web.UI.Page
    {
        BusinessLayer BL = new BusinessLayer();
        protected void Page_Load(object sender, EventArgs e)
        {
            

           
        
        }

        //Delete the movie
        protected void BtnDelete_click(object sender, CommandEventArgs e)
        {
            //if user is not logged in, he cant delete a movie
            if (Session["UserID"] == null)
            {
                Response.Write("<script type=\"text/javascript\">alert('You're not logged in, please log in!');</script>");

            }
            //if you're logged in you can delete a movie
            else
            {


                int MovieID = Convert.ToInt32(e.CommandArgument);
                if (BL.DeleteMovie(MovieID))
                {

                    Response.Write("<script type=\"text/javascript\">alert('Movie verwijderd!');</script>");
                    ObjectDataSource1.DataBind();
                    Response.Redirect("/Movies.aspx");

                }
            }
        }

        
    }
}