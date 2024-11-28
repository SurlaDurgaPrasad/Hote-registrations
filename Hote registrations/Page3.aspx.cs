using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hote_registrations
{
    public partial class Page3 : System.Web.UI.Page
    {
       
            SqlConnection con = new SqlConnection("data source=.;database=Project;integrated security=yes");
            SqlCommand cmd;
            protected void Page_Load(object sender, EventArgs e)
            {

            }

            protected void Button1_Click(object sender, EventArgs e)
            {
                try
                {
                    string username = txtUser.Text;
                    string Password = string.Empty;
                    Session["User"] = username;



                    //   SqlConnection con = new SqlConnection("data source=.;database=Project;integrated security=yes");
                    con.Open();

                    string select = "Select username from Registration1 where username = " + " '" + username + "' ";
                    cmd = new SqlCommand(select, con);
                    username = cmd.ExecuteScalar().ToString();

                    cmd = new SqlCommand($"select password from Registration1 where UserName='{txtUser.Text}'", con);

                    Password = cmd.ExecuteScalar().ToString();

                    if (Password == txtPass.Text)
                    {
                        Response.Redirect("Page4.aspx");
                    }
                    else
                    {
                        lblmsg.Text = "Invalid password";
                    }
                    con.Close();
                }
                catch (Exception)
                {
                    Response.Write("Invalid Username or password");
                }

            }
        }
    }
