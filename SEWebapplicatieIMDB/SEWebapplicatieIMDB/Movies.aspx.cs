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
          SqlDataAdapter sda = new SqlDataAdapter();
        }
    }
}