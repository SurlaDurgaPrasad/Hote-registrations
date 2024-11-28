using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hote_registrations
{
    public partial class Page5 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("data source=.;database=Project;integrated security=yes");
            SqlCommand cmd;
            protected void Page_Load(object sender, EventArgs e)
            {
                if (!IsPostBack)
                {
                    UNtxt.Focus();
                }

            }

            protected void Button1_Click(object sender, EventArgs e)
            {

                try
                {
                    string Username, Room = String.Empty, Amenities = String.Empty;
                    Username = UNtxt.Text;



                    con.Open();
                    String query = "select Username from registration1 where username =" + "'" + Username + "'";
                    cmd = new SqlCommand(query, con);


                    Username = cmd.ExecuteScalar().ToString();



                    if (RadioButton1.Checked == true)
                    {
                        Room = RadioButton1.Text;
                    }
                    else if (RadioButton2.Checked == true)
                    {
                        Room = RadioButton2.Text;
                    }
                    if (CheckBox1.Checked == true)
                    {
                        Amenities = Amenities + CheckBox1.Text + ",";
                    }
                    if (CheckBox2.Checked == true)
                    {
                        Amenities = Amenities + CheckBox2.Text + ",";
                    }

                    string query1 = "insert into Hotel values('" + Username + "','" + Room + "','" + Amenities + "')";
                    cmd = new SqlCommand(query1, con);

                    cmd.ExecuteNonQuery();

                    Response.Redirect("Page6.aspx");
                    con.Close();


                }
                catch (Exception)
                {
                    Lblmsg.Text = "Invalid username";
                }

            }
        }
}