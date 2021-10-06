using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Adding sql library references
using System.Data;
using System.Data.SqlClient;

namespace DBStarterApp
{
    public partial class DBDisplay : System.Web.UI.Page
    {
        //Declaring sql objects
        //con is used for database connections
        SqlConnection con;
        //ada is used for retrieving data from sql
        SqlDataAdapter ada;
        //dt is used for storing the retrieved data
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            /*There is a slight difference in code taken from class.
            I have also displayed the entire table in a table format.
            In project load only the sql connection string definition is required.
            Rest you can add in the function.*/
            //Defining connection string
            string constring = @"Data Source=DESKTOP-R2VIKLU\SQLEXPRESS;Initial Catalog=sample ;persist security info=False;integrated security=SSPI;";
            con = new SqlConnection();
            con.ConnectionString = constring;
            //Defining data adapter to selecting all rows in table
            ada = new SqlDataAdapter("select * from Userdata", con);
            //Defining dt as an empty data table.
            dt = new DataTable();
            //Opening connection
            con.Open();
            //Fill() function is used to store retrieved data to data table.
            ada.Fill(dt);
            //Gridview element is used to display data as table
            //Gridview is found in toolboxes->data
            //Below two lines are used to store data from data table to gridview
            GridView1.DataSource = dt;
            GridView1.DataBind();
            //Closing connection
            con.Close();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //This function is used to select a particular record based on Id on clicking a button
            //Saving select query to data adapter ada
            ada = new SqlDataAdapter("select * from Userdata where Id="+TextBox1.Text,con);
            //Defining data table
            dt = new DataTable();
            //Opening connection
            con.Open();
            //Fill() function is used to store retrieved data to data table.
            ada.Fill(dt);
            //Closing connection
            con.Close();
            //We have to check if data table has any records in it
            //Records are stored in dt.Rows
            //If the number is greater than 0 our query had a successful output
            if (dt.Rows.Count > 0)
            {
                //We assign our values to 3 labels to display them in output
                //dt.Rows is a two dimensional array
                //here we are selecting the first row ie 0 index and 3 elements in that row ie 1,2 and 3.
                Label1.Text = dt.Rows[0][1].ToString();
                Label2.Text = dt.Rows[0][2].ToString();
                Label3.Text = dt.Rows[0][3].ToString();
            }
        }
    }
}