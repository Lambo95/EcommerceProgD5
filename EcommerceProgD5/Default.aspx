<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EcommerceProgD5.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
                <asp:Repeater ID="Repeater1" runat="server" ItemType="EcommerceProgD5.Prodotto">
                    <ItemTemplate>
                        <div class="col-4">
                            <div class="card p-3">
                                <asp:Image ID="Image1" runat="server" ImageUrl="<%#Item.Img %>" />
                                <p><%# Item.Descrizione %></p>
                                <p class="text-center"><b><%# Item.Prezzo.ToString("C2") %></b></p>
                                <a class="text-decoration-none text-center mb-2" href="Dettagli.aspx?idprodotto=<%#Item.Id %>"><i class="bi bi-search"></i></a>
                                <asp:Button ID="AggiungiAlCarrello" CssClass="btn btn-success" text="Aggiungi al carrello" runat="server" CommandArgument=<%#Item.Id %>  OnClick="AggiungiAlCarrello_Click" />
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
</asp:Content>
