<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="test2.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Login" runat="server" Text="目前在線人數："></asp:Label>
    <br/>
    <br />
    <asp:Label ID="logCheck" runat="server" Text="登入中"></asp:Label>
    <asp:Button ID="Logout" runat="server" Text="登出" OnClick="Logout_Click"/>
    <br />
    <br />
    <asp:ImageButton ID="ImageButton1" runat="server" Height="100px" ImageAlign="Middle" ImageUrl="~/pic/剪刀.png" Width="100px" OnClick="Button_Click"/>
    <asp:ImageButton ID="ImageButton2" runat="server" Height="100px" ImageAlign="Middle" ImageUrl="~/pic/石頭.png" Width="100px" OnClick="Button_Click"/>
    <asp:ImageButton ID="ImageButton3" runat="server" Height="100px" ImageAlign="Middle" ImageUrl="~/pic/布.png" Width="100px" OnClick="Button_Click"/>
    <br />
    <br />
<asp:Image ID="computerImage" runat="server" Height="100px" ImageAlign="Middle" ImageUrl="~/pic/布.png" Width="100px" />
    <br />
    <br />
    <asp:Label ID="userResult" runat="server" Text="玩家出："></asp:Label>
    <br />
    <asp:Label ID="computerResult" runat="server" Text="電腦出："></asp:Label>
    <br />
    <br />
    <asp:Label ID="final" runat="server" Text="結果："></asp:Label>
    <br />
    <asp:Timer ID="controlTime" runat="server" OnTick="Timer_Tick" Interval="1000">
    </asp:Timer>
    <asp:Label ID="chat" runat="server" Text="聊天室"></asp:Label>
    <br />
    <asp:Label ID="input" runat="server" Text="輸入內容："></asp:Label>
    <asp:TextBox ID="inputText" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    <br />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Label ID="time" runat="server" Text="剩餘時間："></asp:Label>
            <br />
            <asp:Label ID="chatBox" runat="server" Text=" "></asp:Label>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="controlTime" EventName="Tick" />
        </Triggers>
    </asp:UpdatePanel>
    <br />
    <br />
    <br />
    <br />
    <br />
    </asp:Content>
