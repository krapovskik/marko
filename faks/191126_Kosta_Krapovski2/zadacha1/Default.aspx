<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Table ID="Table1" runat="server" Width="247px">
        <asp:TableRow>
            <asp:TableCell HorizontalAlign="Right">
                Име
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtIme" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell HorizontalAlign="Right">
                Презиме
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtPrezime" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell HorizontalAlign="Right">
                Од
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="ddlOd" runat="server">
                        <asp:ListItem></asp:ListItem>    
                        <asp:ListItem>Скопје</asp:ListItem>
                        <asp:ListItem>Тетово</asp:ListItem>
                        <asp:ListItem>Охрид</asp:ListItem>
                        <asp:ListItem>Гостивар</asp:ListItem>
                        <asp:ListItem>Куманово</asp:ListItem>
                        <asp:ListItem>Прилеп</asp:ListItem>
                    </asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell HorizontalAlign="Right">
                До
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="ddlDo" runat="server">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>Скопје</asp:ListItem>
                        <asp:ListItem>Тетово</asp:ListItem>
                        <asp:ListItem>Охрид</asp:ListItem>
                        <asp:ListItem>Гостивар</asp:ListItem>
                        <asp:ListItem>Куманово</asp:ListItem>
                        <asp:ListItem>Прилеп</asp:ListItem>
                    </asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell HorizontalAlign="Right">
                Датум на тргање
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="ddlDen" runat="server"></asp:DropDownList> 
                <asp:DropDownList ID="ddlMesec" runat="server" OnSelectedIndexChanged="ddlMesec_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                <asp:DropDownList ID="ddlGodina" runat="server" OnSelectedIndexChanged="ddlGodina_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList> 
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell HorizontalAlign="Right">
                Време на тргање
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="ddlVreme" runat="server"></asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell HorizontalAlign="Right">
                Превозно средство
            </asp:TableCell>
            <asp:TableCell>
                  <asp:ListBox ID="lbSredstvo" runat="server">
                      <asp:ListItem>Авион</asp:ListItem>
                      <asp:ListItem>Воз</asp:ListItem>
                  </asp:ListBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell HorizontalAlign="Right">
                Зона
            </asp:TableCell>
            <asp:TableCell>
                 <asp:RadioButtonList ID="rblZona" runat="server">
                     <asp:ListItem>Пушачи</asp:ListItem>
                     <asp:ListItem>Непушачи</asp:ListItem>
                 </asp:RadioButtonList> 
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell HorizontalAlign="Right">
                Класа
            </asp:TableCell>
            <asp:TableCell>
                <asp:RadioButtonList ID="rblKlasa" runat="server">
                    <asp:ListItem>Економска</asp:ListItem>
                    <asp:ListItem>Бизнис</asp:ListItem>
                </asp:RadioButtonList>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell HorizontalAlign="Right">
                Послуга
            </asp:TableCell>
            <asp:TableCell>
                <asp:CheckBoxList ID="cblPosluga" runat="server">
                    <asp:ListItem>Пијалок</asp:ListItem>
                    <asp:ListItem>Кафе</asp:ListItem>
                    <asp:ListItem>Оброк</asp:ListItem>
                </asp:CheckBoxList>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell HorizontalAlign="Right">
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="btnPodnesi" OnClick="btnPodnesi_Click" runat="server" Text="Поднеси" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <div style="position:absolute;top:50px;left:450px;width:500px">
        <asp:Panel ID="pnlPanela1" runat="server">
                Почитуван патнику <br />
                <asp:Label ID="lblPatnik" runat="server" Text=""></asp:Label>
                Издадена ви е карта за <br />
                <asp:Label ID="lblSredstvo" runat="server" Text=""></asp:Label>
                со почетна дестинација <br />
                <asp:Label ID="lblOd" runat="server" Text=""></asp:Label>
                и крајна дестинација <br />
                <asp:Label ID="lblDo" runat="server" Text=""></asp:Label>
                Времето на поаѓање <br />
                <asp:Label ID="lblVreme" runat="server" Text=""></asp:Label>
                <br /> Вашето место на седење ќе биде во зоната <br />
                за <asp:Label ID="lblZona" runat="server" Text=""></asp:Label>
                во <asp:Label ID="lblKlasa" runat="server" Text=""></asp:Label>
                и во текот на патувањето ќе бидете послужени со 
                <asp:Label ID="lblPosluga" runat="server" Text=""></asp:Label>
                <asp:Image ID="imgSlika" runat="server" Height="200" Width="300" /> <br />
                Ви благодариме на довербата и ви посакуваме среќен пат!
            </asp:Panel>
    </div>
 
    
</asp:Content>

            
        
            
            
