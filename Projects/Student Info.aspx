<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student Info.aspx.cs" Inherits="Projects.Student_Info" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Please Enter Student Information<br />
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
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        <br />
    
    </div>
    </form>
</body>
</html>
