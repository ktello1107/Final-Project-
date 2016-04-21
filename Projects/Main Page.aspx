<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main Page.aspx.cs" Inherits="Projects.Main_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            color: #0000FF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <strong>Welcome to the Student Attendance Management</strong>
        <br />
        <br />
        <br />
        What would you like to do?



        <br />
        <br />
        Update Student Information&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Enter Here" />
        <br />
        <br />
        Enter Student Information&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Enter Here" />
        <br />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Logout" />
        <br />
        <br />
        <br />



    </div>
    </form>
</body>
</html>
