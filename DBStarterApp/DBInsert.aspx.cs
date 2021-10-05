using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//Including SQL libraries
using System.Data;
using System.Data.SqlClient;

namespace DBStarterApp
{
    public partial class DBInsert : System.Web.UI.Page
    {
        //Declaring sql objects
        //con is used for database connection
        SqlConnection con;
        //cmd is used for SQL commands
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Connecting to database on page load
            //constring contains the connection string used to connect to your database
            //Source is your server name and Initial Catalog is your database name. Please change values accordingly.
            string constring = @"Data Source=DESKTOP-R2VIKLU\SQLEXPRESS;Initial Catalog=sample ;persist security info=False;integrated security=SSPI;";
            //Saving connection string to SQL object
            con = new SqlConnection();
            con.ConnectionString = constring;
            //Opening Connection to DB
            con.Open();
            Response.Write("Connected");
            //If Connected is being displayed at the top of your page then the database connection is working fine
            //Closing Connection 
            con.Close();
        }

        //This function is executed on clicking submit.
        protected void Button1_Click(object sender, EventArgs e)
        {
            //First we define a string variable with our required insert query
            /*Try out the query in SSMS first then build your own query from there. 
            For eg my query is insert into Userdata values('Ajith','ajith@gmail.com','999999999',3)
            Put everything within double qoutes first.
            Then replace each value like Ajith with IDofTextbox.Text*/
            string s = "insert into Userdata values('" + TextBox1.Text + "' ,' " + TextBox2.Text + "','" + TextBox3.Text + "'," + TextBox4.Text + ")";
            //Opening Connection
            con.Open();
            //Saving the command to SQL object
            cmd = new SqlCommand(s, con);
            //Executing query that we wrote above
            cmd.ExecuteNonQuery();
            //Closing connection
            con.Close();

        }
    }
}