using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace DBStarterApp
{
    public partial class DBUpdate : System.Web.UI.Page
    {
        SqlConnection con;
        SqlDataAdapter ada;
        SqlCommand cmd;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            string constring = @"Data Source=DESKTOP-R2VIKLU\SQLEXPRESS;Initial Catalog=sample ;persist security info=False;integrated security=SSPI;";
            con = new SqlConnection();
            con.ConnectionString = constring;
            ada = new SqlDataAdapter("select * from Userdata", con);
            dt = new DataTable();
            con.Open();
            ada.Fill(dt);
            con.Close();
            GridView1.DataSource = dt;
            GridView1.DataBind();


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "Update Userdata set Name='" + TextBox2.Text + "',Email='" + TextBox3.Text + "' where Id=" + TextBox1.Text;
            cmd = new SqlCommand(s, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("DBUpdate.aspx");
        }
    }
}