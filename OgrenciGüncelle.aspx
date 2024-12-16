<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="OgrenciGüncelle.aspx.cs" Inherits="WebApplication1.OgrenciGüncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="Form1" runat="server">

        <div>
            <asp:Label for="TxtOgrID" runat="server" Text="Öğrenci Id:" Style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtOgrID" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label for="TxtOgrNumara" runat="server" Text="Öğrenci Numarası:" Style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtOgrNumara" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label for="TxtOgrAd" runat="server" Text="Öğrenci Adı:" Style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtOgrAd" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label for="TxtOgrSoyad" runat="server" Text="Öğrenci Soyadı:" Style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtOgrSoyad" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label for="TxtOgrFotograf" runat="server" Text="Öğrenci Fotograf Linki:" Style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtOgrFotograf" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label for="TxtOgrTelefon" runat="server" Text="Öğrenci Telefon:" Style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtOgrTelefon" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label for="TxtOgrMaıl" runat="server" Text="Öğrenci Maıl:" Style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtOgrMaıl" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label for="TxtOgrSıfre" runat="server" Text="Öğrenci Şifre:" Style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtOgrSıfre" runat="server" CssClass="form-control"></asp:TextBox>
        </div>


        <br />
        <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-primary" OnClick="Button1_Click" />
    </form>

</asp:Content>
