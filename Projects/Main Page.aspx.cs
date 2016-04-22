using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace Projects
{
    public partial class Main_Page : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
                        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentAttendance.aspx?");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Student Info.aspx?");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx?");

        }
    }
}