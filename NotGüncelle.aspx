<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="NotGüncelle.aspx.cs" Inherits="WebApplication1.NotGüncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <form id="Form1" runat="server">

     <div>
         <asp:Label for="TxtDersAd" runat="server" Text="Ders Ad:" Style="font-weight: 700"></asp:Label>
         <asp:TextBox ID="TxtDersAd" runat="server" CssClass="form-control"></asp:TextBox>
     </div>
     <br />
     <div>
         <asp:Label for="TxtOgrId" runat="server" Text="Öğrenci ID:" Style="font-weight: 700"></asp:Label>
         <asp:TextBox ID="TxtOgrId" runat="server" CssClass="form-control"></asp:TextBox>
     </div>
     <br />
     <div>
         <asp:Label for="TxtOgrAdSoyad" runat="server" Text="Öğrenci Ad-Soyadı:" Style="font-weight: 700"></asp:Label>
         <asp:TextBox ID="TxtOgrAdSoyad" runat="server" CssClass="form-control"></asp:TextBox>
     </div>
     <br />
     <div>
         <asp:Label for="TxtSınav1" runat="server" Text="Sınav 1:" Style="font-weight: 700"></asp:Label>
         <asp:TextBox ID="TxtSınav1" runat="server" CssClass="form-control"></asp:TextBox>
     </div>
     <br />
     <div>
         <asp:Label for="TxtSınav2" runat="server" Text="Sınav 2:" Style="font-weight: 700"></asp:Label>
         <asp:TextBox ID="TxtSınav2" runat="server" CssClass="form-control"></asp:TextBox>
     </div>
     <br />
     <div>
         <asp:Label for="TxtSınav3" runat="server" Text="Sınav 3:" Style="font-weight: 700"></asp:Label>
         <asp:TextBox ID="TxtSınav3" runat="server" CssClass="form-control"></asp:TextBox>
     </div>
     <br />
     <div>
         <asp:Label for="TxtOrtalama" runat="server" Text="Ortalama:" Style="font-weight: 700"></asp:Label>
         <asp:TextBox ID="TxtOrtalama" runat="server" CssClass="form-control"></asp:TextBox>
     </div>
     <br />
     <div>
         <asp:Label for="TxtDurum" runat="server" Text="Durum:" Style="font-weight: 700"></asp:Label>
         <asp:TextBox ID="TxtDurum" runat="server" CssClass="form-control"></asp:TextBox>
     </div>

     <br />
     <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-primary" OnClick="Button1_Click" />
     <asp:Button ID="Button2" runat="server" Text="Hesapla" CssClass="btn btn-check" OnClick="Button2_Click" />
 </form>

</asp:Content>
