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
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection instructor = new SqlConnection();
            instructor.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\k.tello\Documents\Visual Studio 2012\Projects\Final Projects\Version 1.3\Projects\App_Data\Database1.mdf;Integrated Security=True;MultipleActiveResultSets=True";

            instructor.Open();

            Label1.Text = instructor.State.ToString();

            instructor.Close();


        }
               

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection ins = new SqlConnection();
            ins.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\k.tello\Documents\Visual Studio 2012\Projects\Final Projects\Version 1.3\Projects\App_Data\Database1.mdf;Integrated Security=True;MultipleActiveResultSets=True" ;

            ins.Open();


            SqlCommand command1 = new SqlCommand("INSERT INTO Login (ID, Scode, Name, Password) VALUES ('" + TextBox6.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text +"' , '" + TextBox4.Text + "')", ins);
            SqlCommand command2 = new SqlCommand("INSERT INTO Subject (Scode, Ssname) VALUES ('" + TextBox2.Text + "', '" + TextBox7.Text + "')", ins);
            command2.ExecuteNonQuery();
            command1.ExecuteNonQuery();

          ins.Close();


          Label1.Text = "You have successfully created " + TextBox6.Text;

            //if ()
           // {
               // Response.Redirect("Login.aspx?");
           // }
            
            //else
            //{           
             //   Label1.Text = "Please try agian " ; 
            //}
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx?");
        }

    }
}