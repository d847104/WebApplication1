<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="upload.aspx.cs" Inherits="WebApplication1._132" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <asp:Button ID="Button1" runat="server" Text="Click" OnClick="Button_Click" UseSubmitBehavior="False" />
    <asp:Label ID="Massage" runat="server" Text=""></asp:Label>
    <br />
    <asp:Image ID="Image1" runat="server" />
</asp:Content>
