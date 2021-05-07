<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="jumbotron">
        <asp:Label ID="lblVreme1" runat="server" Text="Kontrola za prikaz na vreme" Font-Names="Arial" Font-Size="Medium" ForeColor="Navy"></asp:Label> <br />
        <asp:Label ID="lblVreme2" runat="server" Text="Kontrola za prikaz na vreme2" Font-Names="Arial" Font-Size="Medium" ForeColor="Navy"></asp:Label> <br />
        <asp:Button ID="btnVreme" runat="server" Text="Kontrola za prikaz na vreme2" Font-Names="Arial" Font-Size="Medium" ForeColor="Navy" OnClick="btnVreme_Click"></asp:Button> <br />
        <asp:HyperLink ID="hlSledno" runat="server" NavigateUrl="~/Default2.aspx">Sledno1</asp:HyperLink> <br />
        <asp:HyperLink ID="hlSledno1" runat="server" NavigateUrl="~/Default3.aspx">Sledno2</asp:HyperLink>


    </div>

</asp:Content>
