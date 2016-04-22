using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Projects
{
    public partial class Student_Info : System.Web.UI.Page
    {
        // delete the // from your db and put the // in front of my db
        //string db = @"Data Source=(LocalDB)\v11.0;AttachDbFileName=C:\Users\k.tello\Documents\Visual Studio 2012\Projects\Final Projects\Version 1.3\Projects\App_Data\Database1.mdf;Integrated Security=True;MultipleActiveResultSets=True";
        string db = @"Data Source=(LocalDB)\v11.0;AttachDbFileName=C:\USERS\KING KONG\DOCUMENTS\VISUAL STUDIO 2012\PROJECTS\FINAL PROJECT\FINAL-PROJECT-\PROJECTS\APP_DATA\DATABASE1.MDF;Integrated Security=True;MultipleActiveResultSets=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection student = new SqlConnection();
            student.ConnectionString = db;

            student.Open();

            Label1.Text = student.State.ToString();


            student.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection student = new SqlConnection();
            student.ConnectionString = db;

            student.Open();

             SqlCommand command1 = new SqlCommand ("INSERT INTO Student_Information (RollNo, Name, Department, DOB, Address, MNo, EID, Notes) VALUES ('"+ TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + TextBox4.Text + "', '" + TextBox5.Text + "', '" + TextBox6.Text + "', '" + TextBox7.Text + "', '" + TextBox8.Text + "')", student);
            command1.ExecuteNonQuery();

            Label1.Text = student.State.ToString();

            student.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main Page.aspx?");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx?");
        }
    }
}