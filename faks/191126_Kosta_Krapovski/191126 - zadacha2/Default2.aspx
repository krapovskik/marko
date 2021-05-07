<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default2.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:Table ID="Table1" runat="server" HorizontalAlign="Center" >
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <asp:Panel ID="pnlPanela" runat="server" Font-Names="Arial" BackColor="Fuchsia">
                        <asp:TextBox ID="txtOperand1" runat="server" EnableViewState="False"></asp:TextBox> <br />
                        <asp:TextBox ID="txtOperand2" runat="server" AutoPostBack="True" OnTextChanged="txtOperand2_TextChanged"></asp:TextBox> <br />
                        <asp:Label ID="lblRezultat" runat="server" EnableViewState="False"></asp:Label> <br />
                        <asp:Button ID="btnSoberi" runat="server" Text="Soberi" OnClick="btnSoberi_Click" />
                    </asp:Panel>
                    <asp:CheckBox ID="chbVidlivo" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Vidlivo" AutoPostBack="True" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>




    </div>
</asp:Content>
