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
        <strong>Hour:</strong>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Period 1</asp:ListItem>
            <asp:ListItem>Period 2</asp:ListItem>
            <asp:ListItem>Period 3</asp:ListItem>
        </asp:DropDownList>
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
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Present</asp:ListItem>
            <asp:ListItem>Absent</asp:ListItem>
        </asp:DropDownList>
        </strong>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" />
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
