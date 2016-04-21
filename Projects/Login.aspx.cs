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
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection login = new SqlConnection();
            login.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename= C:\USERS\KING KONG\DOCUMENTS\VISUAL STUDIO 2012\PROJECTS\PROJECTS_VS.1.4\PROJECTS\APP_DATA\DATABASE1.MDF;Integrated Security=True";
            
            login.Open();

            
            login.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection login = new SqlConnection();
            login.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename= C:\USERS\KING KONG\DOCUMENTS\VISUAL STUDIO 2012\PROJECTS\PROJECTS_VS.1.4\PROJECTS\APP_DATA\DATABASE1.MDF;Integrated Security=True";

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