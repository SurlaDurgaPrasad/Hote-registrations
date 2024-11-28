using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hote_registrations
{
    public partial class Regration_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FNametxt.Focus();
            }

        }

        protected void Rigbtn_Click(object sender, EventArgs e)
        {
            string FirstName, LastName, UserName, Gender = String.Empty, password, conformpassword, email, Phone, address, age, languagesknown = String.Empty, country;
            FirstName = FNametxt.Text;
            LastName = LNametxt.Text;
            UserName = UNametxt.Text;
            if (RadioButton1.Checked == true)
            {
                Gender = RadioButton1.Text;
            }
            if (RadioButton2.Checked == true)
            {
                Gender = RadioButton2.Text;
            }
            else if (RadioButton3.Checked == true)
            {
                Gender = RadioButton3.Text;
            }

            password = Passwordtxt.Text;
            conformpassword = CPtxt.Text;
            email = Emailtxt.Text;
            Phone = Phonetxt.Text;
            address = Addresstxt.Text;
            age = Agetxt.Text;
            if (CheckBox1.Checked == true)
            {
                languagesknown = languagesknown + CheckBox1.Text + ",";
            }
            if (CheckBox2.Checked == true)
            {
                languagesknown = languagesknown + CheckBox2.Text + ",";
            }
            if (CheckBox3.Checked == true)
            {
                languagesknown = languagesknown + CheckBox3.Text + ",";
            }
            country = DropDownList1.SelectedValue.ToString();
            SqlConnection con = new SqlConnection("data source=.;database=Project;integrated security=yes");
            con.Open();
            string query = "insert into registration1 values('" + FirstName + "','" + LastName + "','" + UserName + "','" + Gender + "','" + password + "','" + conformpassword + "','" + email + "','" + Phone + "','" + address + "','" + age + "','" + languagesknown + "','" + country + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Page2.aspx");
        }





    }
}
    

        
    
