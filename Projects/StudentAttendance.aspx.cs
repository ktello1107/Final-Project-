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
    public partial class InstructorPage : System.Web.UI.Page
    {
        // delete the // from your db and put the // in front of my db
        //string db = @"Data Source=(LocalDB)\v11.0;AttachDbFileName=C:\Users\k.tello\Documents\Visual Studio 2012\Projects\Final Projects\Version 1.3\Projects\App_Data\Database1.mdf;Integrated Security=True;MultipleActiveResultSets=True";
        string db = @"Data Source=(LocalDB)\v11.0;AttachDbFileName=C:\USERS\KING KONG\DOCUMENTS\VISUAL STUDIO 2012\PROJECTS\FINAL PROJECT\FINAL-PROJECT-\PROJECTS\APP_DATA\DATABASE1.MDF;Integrated Security=True;MultipleActiveResultSets=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection attendance = new SqlConnection();
            attendance.ConnectionString = db;
            
            attendance.Open();

            Label1.Text = attendance.State.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx?");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main Page.aspx?");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //grab page data
            //insert student info into database

            SqlConnection attendance = new SqlConnection ();
            attendance.ConnectionString = db;


            attendance.Open();

            

            SqlCommand command = new SqlCommand("INSERT INTO Attendance ( Id, Date, Hour,Scode,RollNo,Attendance) VALUES ('" + TextBox5.Text + "','" + Calendar1.SelectedDate + "' , '" + TextBox4.Text + "', '" + TextBox2.Text + "', '" + TextBox1.Text + "', '" + TextBox3.Text + "')", attendance);
            command.ExecuteNonQuery();

            Label1.Text = "You have successfully updated the Attendance information for Student: " + TextBox1.Text;

            attendance.Close();



        }
    }
}