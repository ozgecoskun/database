<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Site.Master" AutoEventWireup="true" CodeBehind="MalzemeFinans.aspx.cs" Inherits="Malzeme.MalzemeFinans" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
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
            <td colspan="2">
                <asp:Label ID="Label1" runat="server" Text="Malzeme Türü"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlMalzemeTuru" runat="server" DataTextField="MlzTuru" DataValueField="Id" Width="135px">
                </asp:DropDownList>
            </td>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label2" runat="server" Text="Değerleme Tipi 
"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlDegerlemeTipi" runat="server" DataTextField="DegerlemeTipi" DataValueField="Id" Width="135px">
                </asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Kaydeden Kullanıcı"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtKaydedenKullanici" runat="server" Width="130px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label3" runat="server" Text="Kar Merkezi"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlKarMerkezi" runat="server" DataTextField="KarMerkezi" DataValueField="Id" Width="135px">
                </asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Kayıt Tarihi"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtKayitTarihi" runat="server" Width="130px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label4" runat="server" Text="Maliyet hesaplama parti büyüklüğü"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtMaliyetHesaplamaPartiByklugu" runat="server" Width="130px"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Güncelleyen Kullanıcı"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtGuncelleyenKullanici" runat="server" Width="130px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label5" runat="server" Text="KDV Oranı"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlKDVOrani" runat="server" DataTextField="KDV" DataValueField="Id" Width="135px">
                </asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Güncelleme Tarihi"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtGuncellemeTarihi" runat="server" Width="130px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" OnClick="btnKaydet_Click"  />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
