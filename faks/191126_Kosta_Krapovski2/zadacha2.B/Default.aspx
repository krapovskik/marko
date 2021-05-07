<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    Име<asp:TextBox ID="txtIme" runat="server"></asp:TextBox> 
    <asp:RequiredFieldValidator 
        ID="imeVal" 
        ControlToValidate="txtIme"
        runat="server" 
        ErrorMessage="Името е задолжително!">*
    </asp:RequiredFieldValidator>
    <br />
    Презиме<asp:TextBox ID="txtPrezime" runat="server"></asp:TextBox> 
    <asp:RequiredFieldValidator 
        ID="prezimeVal" 
        ControlToValidate="txtPrezime"
        runat="server" 
        ErrorMessage="Презимето е задолжително!">*
    </asp:RequiredFieldValidator>
    <br />
    ФИНКИ ID<asp:TextBox ID="txtID" runat="server"></asp:TextBox> @ finki.ukim.mk 
    <asp:RequiredFieldValidator 
        ID="idRVal" 
        ControlToValidate="txtID"
        runat="server" 
        ErrorMessage="ID е задолжително!">*
    </asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator 
        ID="idVal" 
        ControlToValidate="txtID"
        ValidationExpression="[A-Z]+[_]?[0-9]{2,}"
        runat="server" 
        ErrorMessage="Неправилен формат на ID!">*
    </asp:RegularExpressionValidator>
    <br />
    Лозинка<asp:TextBox ID="txtLozinka" runat="server" TextMode="Password"></asp:TextBox> 
    <asp:RequiredFieldValidator 
        ID="passVal" 
        ControlToValidate="txtLozinka"
        runat="server" 
        ErrorMessage="Лозинката е задолжителна!">*
    </asp:RequiredFieldValidator><br />
    Потврда<asp:TextBox ID="txtPotvrda" runat="server" TextMode="Password"></asp:TextBox> 
    <asp:RequiredFieldValidator 
        ID="cpassVal" 
        ControlToValidate="txtPotvrda"
        runat="server" 
        ErrorMessage="Потврдата е задолжителна!">*
    </asp:RequiredFieldValidator>
    <asp:CompareValidator 
        ID="cpassCVal" 
        ControlToValidate="txtPotvrda"
        ControlToCompare="txtLozinka"
        runat="server" 
        ErrorMessage="Лозинките се различни!">*
    </asp:CompareValidator>
    <br />
    Адреса<asp:TextBox ID="txtAdresa" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator 
        ID="adresaVal" 
        ControlToValidate="txtAdresa"
        runat="server" 
        ErrorMessage="Адресата е задолжителна!">*
    </asp:RequiredFieldValidator>
    <br />
    Тел<asp:TextBox ID="txtTel" runat="server"></asp:TextBox> 
    <asp:RequiredFieldValidator 
        ID="telVal" 
        ControlToValidate="txtTel"
        runat="server" 
        ErrorMessage="Телефонскиот број е задолжителен!">*
    </asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator 
        ID="telRVal" 
        runat="server" 
        ControlToValidate="txtTel"
        ValidationExpression="\+(389)\s[0-9]\s[0-9]{4}\s[0-9]{3}|\+(389)\s[0-9]{2}\s[0-9]{3}\s[0-9]{3}"
        ErrorMessage="Неправилен формат">*
    </asp:RegularExpressionValidator>
    <br />
    Пол: <br />
    <asp:RadioButtonList ID="rblPol" runat="server" RepeatDirection="Horizontal">
        <asp:ListItem>М</asp:ListItem>
        <asp:ListItem>Ж</asp:ListItem>
    </asp:RadioButtonList> 
    <asp:RequiredFieldValidator 
        ID="polVal" 
        ControlToValidate="rblPol"
        runat="server" 
        Display ="Static"
        ErrorMessage="Избери пол!">*
    </asp:RequiredFieldValidator>
    <br />
    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar> <br />
    Занимање <br />
    <asp:DropDownList ID="ddlZanimanje" runat="server">
        <asp:ListItem>-занимање-</asp:ListItem>
        <asp:ListItem>FullStack Developer</asp:ListItem>
        <asp:ListItem>Backend Developer</asp:ListItem>
        <asp:ListItem>Frontend Developer</asp:ListItem>
        <asp:ListItem>Konobar</asp:ListItem>
        <asp:ListItem>Shanker</asp:ListItem>
    </asp:DropDownList> 
    <asp:RequiredFieldValidator 
        ID="zanimanjeVal" 
        ControlToValidate="ddlZanimanje"
        runat="server" 
        InitialValue ="-занимање-"
        ErrorMessage="Избери занимање">*
    </asp:RequiredFieldValidator>
    <br />
    Години на вршење на избраната дејност <br />
    <asp:TextBox ID="txtGodiniZanimanje" runat="server"></asp:TextBox> 
    <asp:RequiredFieldValidator 
        ID="godiniZanimanjeVal" 
        ControlToValidate="txtGodiniZanimanje"
        runat="server" 
        ErrorMessage="Полето е задолжително!">*
    </asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator 
        ID="godiniZanimanjeRVal" 
        runat="server" 
        ControlToValidate ="txtGodiniZanimanje"
        ValidationExpression="\d"
        ErrorMessage="Недозволена вредност!">*
    </asp:RegularExpressionValidator>
    <br />
    <asp:Button ID="btnPodnesi" runat="server" Text="Поднеси" OnClick="btnPodnesi_Click" /> <br />
    <asp:Label ID="lblSmetka" runat="server" Text=""></asp:Label>
    <asp:ValidationSummary ID="sumVal" runat="server" />
</asp:Content>

