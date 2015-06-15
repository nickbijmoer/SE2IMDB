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

        protected void BtnDelete_click(object sender, CommandEventArgs e)
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