<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Site.Master" AutoEventWireup="true" CodeBehind="LoginEkrani.aspx.cs" Inherits="Malzeme.LoginEkranii" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 193px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="toolbar" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="sections" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="content" runat="server">
    <table class="auto-style1">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Kullanıcı Adı"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtKullaniciAdi" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Şifre"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSifre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lbBilgi" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Button ID="btnGiris" runat="server" Text="Giriş" OnClick="btnGiris_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnYeniKayit" runat="server" Text="Yeni Kayit" OnClick="btnYeniKayit_Click" />
            </td>
            <td>
                <asp:Button ID="btnCokla" runat="server" Text="Çoklama" />
            </td>
        </tr>
    </table>
</asp:Content>
