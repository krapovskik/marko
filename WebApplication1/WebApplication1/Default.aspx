<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Hello!</h1>
    Ime <asp:TextBox ID="txtIme" runat="server"></asp:TextBox> <br />
    Prezime <asp:TextBox ID="txtPrezime" runat="server"></asp:TextBox> <br />
    <asp:Button ID="btn1" runat="server" Text="Button" OnClick="btn1_Click" />
</asp:Content>

