using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hote_registrations
{
    public partial class Page6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Username = (string)Session["User"];
            SqlConnection con = new SqlConnection("Data source =.;Database=Project;integrated security=yes");
            SqlCommand cmd = new SqlCommand("select * from Hotel where UserName=" + "'" + Username + "'", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();


        }
    }
}
    
