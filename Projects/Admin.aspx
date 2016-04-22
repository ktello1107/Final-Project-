<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Projects.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #0000FF;
            font-family: Calibri;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <span class="auto-style1"><strong>New Teacher Login</strong></span><br />
        <br />
        <strong>ID:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Subject Code:</strong>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <strong>Subject Name:</strong>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        <strong>Teacher Name:</strong>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <strong>
        <br />
        Password:
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        </strong>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Create" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button3_Click" Text="Go To Login" />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
