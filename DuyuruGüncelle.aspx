<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="DuyuruGüncelle.aspx.cs" Inherits="WebApplication1.DuyuruGüncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <form id="Form1" runat="server">

    <div>
        <asp:Label for="TxtDuyuruID" runat="server" Text="Duyuru Id:" Style="font-weight: 700"></asp:Label>
        <asp:TextBox ID="TxtDuyuruID" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label for="TxtDuyuruBaslık" runat="server" Text="Duyuru Başlık:" Style="font-weight: 700"></asp:Label>
        <asp:TextBox ID="TxtDuyuruBaslık" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label for="TextArea1" runat="server" >DUYURU İÇERİK</asp:Label>
        <textarea id="TextArea1" cols="20" rows="6" class="form-control" runat="server"></textarea>
    </div>

    <br />
    <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-primary" OnClick="Button1_Click" />
</form>

</asp:Content>
