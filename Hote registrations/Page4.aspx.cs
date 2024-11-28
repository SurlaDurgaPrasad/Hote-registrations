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
    public partial class Page4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
                if (!IsPostBack)
                {
                    string username = Session["User"].ToString();
                    SqlConnection con = new SqlConnection("data source=.;database=Project;integrated security=yes");
                    SqlCommand cmd = new SqlCommand($"select firstname,lastname,username,gender,password,email,phone,address,age,languagesknown,country from Registration1 where UserName='{username}'", con);
                    //con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    GridView1.DataSource = ds;
                    GridView1.DataBind();

                }
            }

            protected void Button1_Click(object sender, EventArgs e)
            {
                Response.Redirect("Page5.aspx");
            }
        }
    }

    
