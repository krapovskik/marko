<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Najava.aspx.cs" Inherits="WebApplication3.Najava" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron text-center">
        <asp:TextBox ID="txtKorisnik" runat="server"></asp:TextBox> <br />
        <asp:TextBox ID="txtLozinka" runat="server" TextMode="Password"></asp:TextBox> <br />
        <asp:Button ID="btnPodnesi" runat="server" Text="Поднеси" OnClick="btnPodnesi_Click" /> <br />
        Обиди: <asp:Label ID="lblObidi" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
