<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Default2.aspx.cs" Inherits="WebApplication1.Default2" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    Hello <% =Request.QueryString["name"] %> <% =Request.QueryString["lastname"] %> 
</asp:Content>
