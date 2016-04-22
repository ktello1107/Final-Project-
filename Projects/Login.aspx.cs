using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Projects
{
    public partial class Login : System.Web.UI.Page
    {
        // delete the // from your db and put the // in front of my db
        //string db = @"Data Source=(LocalDB)\v11.0;AttachDbFileName=C:\Users\k.tello\Documents\Visual Studio 2012\Projects\Final Projects\Version 1.3\Projects\App_Data\Database1.mdf;Integrated Security=True;MultipleActiveResultSets=True";
        string db = @"Data Source=(LocalDB)\v11.0;AttachDbFileName=C:\USERS\KING KONG\DOCUMENTS\VISUAL STUDIO 2012\PROJECTS\FINAL PROJECT\FINAL-PROJECT-\PROJECTS\APP_DATA\DATABASE1.MDF;Integrated Security=True;MultipleActiveResultSets=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection login = new SqlConnection();
            login.ConnectionString = db;

            login.Open();

            
            login.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection login = new SqlConnection();
            login.ConnectionString = db;

            login.Open();

            SqlCommand command = new SqlCommand("Select Password FROM Login WHERE ID = " + TextBox1.Text, login);
            SqlDataReader reader = command.ExecuteReader();
            string dbPass = null;

            while (reader.Read())
            {
                dbPass = reader["Password"].ToString();
            }

            if (dbPass == null)
            {
                Label1.Text = " User doesn't exist ";
            }

            else if (dbPass != TextBox2.Text)
            {
                Label1.Text = " Incorrect Password ";
            }

            else
            {
                Response.Redirect("Main Page.aspx?");
            }

            login.Close();
        }
        
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx?");
        }


    }
}