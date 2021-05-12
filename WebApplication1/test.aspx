<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="WebApplication1.test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="post">
        <div>          
            <asp:TextBox ID="user" runat="server"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="帳號"></asp:Label>
            <br>
            <input type="text" id="passwd" name="passwd"> 密碼<br />
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="暱稱"></asp:Label>
            <br>
            <input type="submit" value="Submit">
        </div>
    </form>
</body>
</html>
