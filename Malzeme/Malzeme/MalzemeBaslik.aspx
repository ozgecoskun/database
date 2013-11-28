<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Site.Master" AutoEventWireup="true" CodeBehind="MalzemeBaslik.aspx.cs" Inherits="Malzeme.MalzemeBaslik" %>
<%@ Register TagPrefix="uc" TagName="MainTab" Src="~/UserControls/MainTab.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 71px;
        }
        .auto-style3 {
            width: 134px;
        }
        .auto-style4 {
            height: 71px;
            width: 134px;
        }
        .auto-style5 {
            width: 185px;
        }
        .auto-style6 {
            height: 71px;
            width: 185px;
        }
        .auto-style7 {
            width: 177px;
        }
        .auto-style8 {
            height: 71px;
            width: 177px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="toolbar" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="sections" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="content" runat="server">
    <table cellpadding="0" cellspacing="0" class="auto-style1">
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label1" runat="server" Text="Malzeme Türü"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:DropDownList ID="ddlMalzemeTuru" runat="server" Width="135px" DataTextField="MlzTuru" DataValueField="Id" style="margin-left: 0px">
                </asp:DropDownList>
            </td>
            <td class="auto-style7">
                <asp:Label ID="Label3" runat="server" Text="Kaydeden Kullanıcı"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtKaydedenKullanici" runat="server" Width="130px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label2" runat="server" Text="Malzeme No"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="txtMalzemeNo" runat="server" Width="130px"></asp:TextBox>
            </td>
            <td class="auto-style7">
                <asp:Label ID="Label4" runat="server" Text="Kayıt Tarihi"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtKayitTarihi" runat="server" Width="130px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label6" runat="server" Text="Malzeme Adı"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="txtMalzemeAdi" runat="server" Width="130px"></asp:TextBox>
            </td>
            <td class="auto-style7">
                <asp:Label ID="Label9" runat="server" Text="Güncelleyen Kullanıcı"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtGuncelleyenKullanici" runat="server" Width="130px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label7" runat="server" Text="Üretim Yeri"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:DropDownList ID="ddlUretimYeri" runat="server" Width="135px" DataTextField="UYAdi" DataValueField="Id">
                </asp:DropDownList>
            </td>
            <td class="auto-style7">
                <asp:Label ID="Label10" runat="server" Text="Güncelleme Tarihi"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtGuncellemeTarihi" runat="server" Width="130px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label8" runat="server" Text="Malzeme Durumu"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="txtMalzemeDurumu" runat="server" Width="130px"></asp:TextBox>
            </td>
            <td class="auto-style7">Onay Dururmu</td>
            <td>
                <asp:DropDownList ID="ddlOnayDurumu" runat="server" Width="135px" DataTextField="OnayDurum" DataValueField="Id">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style6">
                <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" OnClick="btnKaydet_Click" />
            </td>
            <td class="auto-style8">
                <asp:Button ID="btnCoklama" runat="server" Text="Çoklama" OnClick="btnCoklama_Click" />
            </td>
            <td class="auto-style2">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
