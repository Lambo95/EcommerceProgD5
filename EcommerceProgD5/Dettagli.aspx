<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Dettagli.aspx.cs" Inherits="EcommerceProgD5.Dettagli" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-center">
        <asp:Image ID="imgProdotto" runat="server" /><br />
        <asp:Label ID="lblNomeProdotto" runat="server" Font-Bold="true" Font-Size="20px" Text=""></asp:Label>
        <br />
        <asp:Label ID="lblPrezzoProdotto" runat="server" Font-Bold="true" Font-Size="20px" Text=""></asp:Label>
        <br />
        <asp:Button ID="Button1" CssClass="btn btn-success" Text="Aggiungi al carrello" runat="server" OnClick="AggiungiAlCarrello_Click" />
    </div>
</asp:Content>
