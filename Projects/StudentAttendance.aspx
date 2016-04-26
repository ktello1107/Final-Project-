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
        ID:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Hour:</strong><asp:DropDownList ID="HourList" runat="server">
            <asp:ListItem Value="1" Selected="True">1st Hour</asp:ListItem>
            <asp:ListItem Value="2">2nd Hour</asp:ListItem>
            <asp:ListItem Value="3">3rd Hour</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <strong>Subject Code:<asp:DropDownList ID="SubjectCode" runat="server" DataSourceID="SqlDataSource2" DataTextField="Ssname" DataValueField="Scode">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Scode], [Ssname] FROM [Subject]"></asp:SqlDataSource>
        <br />
        </strong>
        <br />
        <strong>Select Student:&nbsp;
        <asp:DropDownList ID="StudentRollNo" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="RollNo">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [RollNo], [Name] FROM [StudentInformation]"></asp:SqlDataSource>
        <br />
        <br />
        Attendence:&nbsp;
        </strong>
        <asp:DropDownList ID="Attendence" runat="server">
            <asp:ListItem>Absent</asp:ListItem>
            <asp:ListItem>Present</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Update" runat="server" Text="Update" OnClick="Update_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Delete" runat="server" Text="Delete " OnClick="Delete_Click" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
    
    </div>
        <asp:Button ID="Logout" runat="server" OnClick="Button2_Click" Text="Logout" />
    &nbsp;
        <asp:Button ID="Main" runat="server" Text="Return to Main" OnClick="Button3_Click" />
        &nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <strong>Select which Attendance ID you would like to Delete:&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="SelectedAttendance" runat="server" DataSourceID="SqlDataSource3" DataTextField="Id" DataValueField="Id">
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Delete" />
        </strong>
        <br />
        <br />
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Id], [Attendance] FROM [Attendance]"></asp:SqlDataSource>
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
