<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PclCalculadora.Web.Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>We suggest the following:</h3>
    <ol class="round">
        <li class="one">
            <h5>Primer número:</h5>
            <asp:TextBox ID="tbNumero1" runat="server"></asp:TextBox>
        </li>
        <li class="two">
            <h5>Segundo número:</h5>
            <asp:TextBox ID="tbNumero2" runat="server"></asp:TextBox>
        </li>
        <li class="three">
            <asp:Button Text="Calcular" OnClick="Button_Click" ID="button" runat="server"></asp:Button>
            <h5>Resultado</h5>
            <asp:Label ID="resultado" runat="server"></asp:Label>
        </li>
    </ol>
</asp:Content>
