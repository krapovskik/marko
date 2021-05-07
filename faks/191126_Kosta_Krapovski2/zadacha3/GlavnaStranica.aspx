<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GlavnaStranica.aspx.cs" Inherits="WebApplication3.GlavnaStranica" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron text-center">
        Hello! <br />
        <asp:Button ID="btnOdjava" runat="server" Text="Одјави се" OnClick="btnOdjava_Click" />
    </div>

</asp:Content>
