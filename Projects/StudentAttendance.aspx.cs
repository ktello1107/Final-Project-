﻿using System;
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
        string db = @"Data Source=(LocalDB)\v11.0;AttachDbFileName=C:\Users\k.tello\Documents\Visual Studio 2012\Projects\Final Projects\Version 1.3\Projects\App_Data\Database1.mdf;Integrated Security=True;MultipleActiveResultSets=True";
        //string db = @"Data Source=(LocalDB)\v11.0;AttachDbFileName=C:\USERS\KING KONG\DOCUMENTS\VISUAL STUDIO 2012\PROJECTS\FINAL PROJECT\FINAL-PROJECT-\PROJECTS\APP_DATA\DATABASE1.MDF;Integrated Security=True;MultipleActiveResultSets=True";

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

        protected void Submit_Click(object sender, EventArgs e)
        {
            //grab page data
            //insert student info into database

            SqlConnection attendance = new SqlConnection ();
            attendance.ConnectionString = db;


            attendance.Open();
                     

            SqlCommand command = new SqlCommand("INSERT INTO Attendance (Date, Hour,Scode,RollNo,Attendance) VALUES ('" + Calendar1.SelectedDate + "', '" + HourList.SelectedValue + "', '" + SubjectCode.SelectedValue +"','" + StudentRollNo.SelectedValue + "', '" + Attendence.SelectedValue + "' )", attendance);
            command.ExecuteNonQuery();

            Label1.Text = "You have successfully updated the Attendance information for Student: " + StudentRollNo.SelectedItem;

            attendance.Close();



        }

        protected void Delete_Click(object sender, EventArgs e)
        {

            SqlConnection delete = new SqlConnection();
            delete.ConnectionString = db;

            delete.Open();

            string deleteStatement = @"DELETE FROM Attendance WHERE RollNo = '" + StudentRollNo.SelectedItem + "'";

            SqlCommand command1 = new SqlCommand(deleteStatement, delete);
            command1.ExecuteNonQuery();

            Label1.Text = "Deleted User";

            delete.Close();

        }

        protected void Update_Click(object sender, EventArgs e)
        {
            SqlConnection update = new SqlConnection();
            update.ConnectionString = db;

            update.Open();
            
        }
    }
}