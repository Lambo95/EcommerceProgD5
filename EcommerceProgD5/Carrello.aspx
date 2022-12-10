<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="EcommerceProgD5.Carrello" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table class="table">
                <thead>
                    <tr>
                        <th scope="col">Immagine</th>
                        <th scope="col">Nome Prodotto</th>
                        <th scope="col">Prezzo</th>
                    </tr>
                </thead>
         </table>
    <asp:Repeater ID="Repeater1" runat="server" ItemType="EcommerceProgD5.Prodotto">
        <ItemTemplate>
            <table class="table">
                <tbody>
                    <tr>
                        <td><asp:Image style="height:5em" ID="Image2" runat="server" ImageUrl="<%#Item.Img %>" /></td>
                        <td><%# Item.Titolo%></td>
                        <td><%# Item.Prezzo %> €</td>
                    </tr>
                </tbody>
            </table>
        </ItemTemplate>
    </asp:Repeater>
    <div class="text-center p-5">
       <%-- Il bottone funzione se cliccato due volte?!?--%>
    <asp:Button  CssClass="btn btn-danger " ID="SvuotaCestino" runat="server" Text="Svuota cestino" OnClick="SvuotaCestino_Click" PostBackUrl="~/Carrello.aspx" />
        </div>
</asp:Content>
