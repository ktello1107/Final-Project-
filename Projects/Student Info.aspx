<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student Info.aspx.cs" Inherits="Projects.Student_Info" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <strong>Please Enter Student Information</strong><br />
        <br />
        <br />
        Student Roll Number: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Student Name:&nbsp; <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        Department:&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        Student Date of Birth:&nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        Student Address:&nbsp;
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <br />
        Student Mobile Phone Number:&nbsp;
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        <br />
        Student Email:&nbsp;
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <br />
        <br />
        Notes:&nbsp;
        <br />
        <asp:TextBox ID="TextBox8" runat="server" Rows="5" TextMode="MultiLine"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Go To Main Page" />
        <br />
        <br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Calculate" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Logout" Height="39px" />
        <br />
    
    </div>
    </form>
</body>
</html>
