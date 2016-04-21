<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentAttendance.aspx.cs" Inherits="Projects.InstructorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <strong>Enter Student Attendance<br />
        <br />
        Date:</strong>
        <br />
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <br />
        <strong>
        <br />
        Teacher ID:
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <br />
        Hour:</strong><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        <strong>Subject Code:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        </strong>
        <br />
        <strong>Student Roll Number:&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Attendence:&nbsp;
        </strong>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Text="Delete" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
    
    </div>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Logout" />
    &nbsp;
        <asp:Button ID="Button3" runat="server" Text="Return to Main" OnClick="Button3_Click" />
    </form>
</body>
</html>
