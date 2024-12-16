<%@ Page Title="" Language="C#" MasterPageFile="~/Ogrenci.Master" AutoEventWireup="true" CodeBehind="DefaultOgrenci.aspx.cs" Inherits="WebApplication1.DefaultOgrenci" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <form id="Form1" runat="server">

   <%-- <div>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="Numara"></asp:TextBox>
    </div>--%>
    <br />
    <div>
        <asp:TextBox ID="TextBox2" runat="server" CssClass="Ad-Soyad"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:TextBox ID="TextBox3" runat="server" CssClass="Telefon"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:TextBox ID="TextBox4" runat="server" CssClass="Şifre"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:TextBox ID="TextBox5" runat="server" CssClass="Mail"></asp:TextBox>
    </div>
        <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-primary"/>
</form>

</asp:Content>
