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

        protected void BtnDelete2_click(object sender, CommandEventArgs e)
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