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

        //logout button
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx?");
        }

        //main page button
        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main Page.aspx?");
        }

        //submit button
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

        //Delete button
        protected void Delete_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            SqlConnection delete = new SqlConnection();
            delete.ConnectionString = db;

            delete.Open();

            // Check if record actually deleted, get the ID first
            string selectStatement = @"select id from  Attendance where Date = '" + Calendar1.SelectedDate +
                 "' and hour = '" + HourList.SelectedValue +
                 "' and scode = '" + SubjectCode.SelectedValue +
                 "' and attendance like '" + Attendence.SelectedItem +
                 "' and rollno = (select rollno from studentinformation where name like '" + StudentRollNo.SelectedItem + "')";

            SqlCommand command0 = new SqlCommand(selectStatement, delete);
            SqlDataReader rows = command0.ExecuteReader();
            string id = "";

            // If the rows.Read returns true, the the record exists. If it returns false, then the record does not exists and fail
            if (rows.Read())
            {
                id = rows.GetValue(0).ToString();

                //Deletes the Attendance record if all the fields match
                string deleteStatement = @"Delete from  Attendance where Date = '" + Calendar1.SelectedDate +
                    "' and hour = '" + HourList.SelectedValue +
                    "' and scode = '" + SubjectCode.SelectedValue +
                    "' and attendance like '" + Attendence.SelectedItem +
                    "' and rollno = (select rollno from studentinformation where name like '" + StudentRollNo.SelectedItem + "')";

                SqlCommand command1 = new SqlCommand(deleteStatement, delete);
                command1.ExecuteNonQuery();

                // Get count to verify
                string selectCountStatement = @"select count(*) from  Attendance where id = '" + id + "'";

                SqlCommand command2 = new SqlCommand(selectCountStatement, delete);
                rows = command2.ExecuteReader();

                int count = 0;
                while (rows.Read())
                {
                    count = int.Parse(rows.GetValue(0).ToString());

                }

                // Check the count. If there exists any records and count is 1 or more, then the delete failed. 
                if (count >= 0)
                {
                    Label1.Text = StudentRollNo.SelectedItem + " was Deleted";
                }
                else
                {
                    Label1.Text = StudentRollNo.SelectedItem + " was NOT Deleted";
                }
            }
            else
            {
                Label1.Text = StudentRollNo.SelectedItem + " was NOT Deleted";
            }


            
            delete.Close();
          

        }

        protected void Update_Click(object sender, EventArgs e)
        {
            SqlConnection update = new SqlConnection();
            update.ConnectionString = db;

            update.Open();

            string updateStatement = @"UPDATE Attendance set (Date='" + Calendar1.SelectedDate + "', Hour='" + HourList.SelectedValue + "', Scode='" + SubjectCode.SelectedValue +"', RollNo='" + StudentRollNo.SelectedValue + "', Attendence='" + Attendence.SelectedValue + "' ; ";
            
            SqlCommand command1 = new SqlCommand(updateStatement, update);
            command1.ExecuteNonQuery();

            Label1.Text = "Updated User";

            update.Close();
        }
    }
}