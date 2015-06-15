using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SEWebapplicatieIMDB.Classes;

namespace SEWebapplicatieIMDB
{
    public partial class Top10Movies : System.Web.UI.Page
    {
        BusinessLayer BL = new BusinessLayer();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Delete Movie
        protected void BtnDelete2_click(object sender, CommandEventArgs e)
        {
            //If you're not logged in you cant delete a movie
            if (Session["UserID"] == null)
            {
                Response.Write("<script type=\"text/javascript\">alert('You're not logged in, please log in!');</script>");

            }
            //If you're logged in you can delete a movie
            else
            {


                int MovieID = Convert.ToInt32(e.CommandArgument);
                if (BL.DeleteMovie(MovieID))
                {
                    Response.Write("<script type=\"text/javascript\">alert('Movie verwijderd!');</script>");
                    ObjectDataSource2.DataBind();
                    Response.Redirect("/Top10Movies.aspx");

                }
            }
        }
    }
}