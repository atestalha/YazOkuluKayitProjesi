<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="MesajYaz.aspx.cs" Inherits="WebApplication1.MesajYaz" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="Form1" runat="server">

    <div>
        <asp:Label for="TxtGonderen" runat="server" Text="Gönderen:" Style="font-weight: 700"></asp:Label>
        <asp:TextBox ID="TxtGonderen" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label for="TxtAlici" runat="server" Text="Alıcı:" Style="font-weight: 700"></asp:Label>
        <asp:TextBox ID="TxtAlici" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label for="TxtBaslik" runat="server" Text="Başlık:" Style="font-weight: 700"></asp:Label>
        <asp:TextBox ID="TxtBaslik" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label for="TxtIcerik" runat="server" Text="Duyuru İçerik:" Style="font-weight: 700"></asp:Label>
        <textarea id="TxtIcerık" cols="20" rows="7" class="form-control" runat="server"></textarea>

        <br />
        <div>
            <asp:Label for="TxtTarih" runat="server" Text="Tarih:" Style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtTarih" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <asp:Button ID="Button1" runat="server" Text="MESAJ GÖNDER" CssClass="btn btn-info" OnClick="Button1_Click"  />
</form>

</asp:Content>
