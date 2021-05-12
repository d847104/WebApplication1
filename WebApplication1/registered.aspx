<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registered.aspx.cs" Inherits="WebApplication1.registered" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="user" runat="server"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="帳號"></asp:Label>
            <br/>
            <asp:TextBox ID="passwd" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="密碼"></asp:Label>
            <br/>
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="姓名"></asp:Label>
            <br/>
            <asp:Button ID="Button1" runat="server" Text="提交" />
        </div>
    </form>
</body>
</html>
