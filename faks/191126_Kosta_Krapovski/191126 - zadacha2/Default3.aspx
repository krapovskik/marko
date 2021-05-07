<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default3.aspx.cs" Inherits="WebApplication1.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:TextBox ID="txtLozinka" runat="server" TextMode="Password" ReadOnly="True">mrezhno programiranje</asp:TextBox> <br />
        <asp:TextBox ID="txtPoraka" runat="server" TextMode="MultiLine" AutoPostBack="True" OnTextChanged="txtPoraka_TextChanged"></asp:TextBox> <br />
        <asp:Button ID="btnProveri" runat="server" Text="Proveri" OnClick="btnProveri_Click" /> <br />
        <asp:Button ID="btnPrvaStrana" runat="server" Text="PrvaStrana" Enabled="False" OnClick="btnPrvaStrana_Click" />
    </div>
    
</asp:Content>
