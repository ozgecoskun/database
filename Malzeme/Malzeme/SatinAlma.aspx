<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Site.Master" AutoEventWireup="true" CodeBehind="SatinAlma.aspx.cs" Inherits="Malzeme.SatinAlma" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 203px;
        }
        .auto-style2 {
            height: 19px;
        }
        .auto-style7 {
            width: 150px;
        }
        .auto-style8 {
            height: 19px;
            width: 150px;
        }
        .auto-style9 {
            width: 183px;
        }
        .auto-style10 {
            height: 19px;
            width: 183px;
        }
        .auto-style14 {
        }
        .auto-style15 {
            height: 19px;
            width: 203px;
        }
        .auto-style16 {
            height: 21px;
            }
        .auto-style17 {
            height: 21px;
            width: 183px;
        }
        .auto-style18 {
            height: 21px;
            width: 150px;
        }
        .auto-style19 {
            height: 21px;
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
            <td class="auto-style14" colspan="3">
                &nbsp;</td>
            <td class="auto-style14" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14" colspan="2">
                <asp:Label ID="Label12" runat="server" Text="Malzeme Türü"></asp:Label>
            </td>
            <td class="auto-style14">
                <asp:DropDownList ID="ddlMalzemeTuru" runat="server" DataTextField="MlzTuru" DataValueField="Id" style="margin-left: 0px" Width="135px">
                </asp:DropDownList>
            </td>
            <td class="auto-style7">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14" colspan="2">
                <asp:Label ID="Label1" runat="server" Text="Fiyat Birimi "></asp:Label>
            </td>
            <td class="auto-style9">
                <asp:TextBox ID="txtFiyatBirimi" runat="server" Width="130px"></asp:TextBox>
            </td>
            <td class="auto-style7">
                <asp:Label ID="Label6" runat="server" Text="SA Sipariş Metni"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSASiparisMetni" runat="server" Width="130px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style15" colspan="2">
                <asp:Label ID="Label2" runat="server" Text="Plan Fiyat"></asp:Label>
            </td>
            <td class="auto-style10">
                <asp:TextBox ID="txtPlanFiyat" runat="server" Width="130px"></asp:TextBox>
            </td>
            <td class="auto-style8">
                <asp:Label ID="Label7" runat="server" Text="Kaydeden Kullanici" ></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="txtKaydedenKullanici" runat="server" Width="130px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style14" colspan="2">
                <asp:Label ID="Label3" runat="server" Text="Plan Fiyat Tarihi 
"></asp:Label>
            </td>
            <td class="auto-style9">
                <asp:TextBox ID="txtPlanFiyatTarihi" runat="server" Width="130px"></asp:TextBox>
            </td>
            <td class="auto-style7">
                <asp:Label ID="Label8" runat="server" Text="Kayıt Tarihi"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtKayitTarihi" runat="server" Width="130px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style14" colspan="2">
                <asp:Label ID="Label4" runat="server" Text="Asgari Parti Büyüklüğü"></asp:Label>
            </td>
            <td class="auto-style9">
                <asp:TextBox ID="txtAsgariPartiBuyuklugu" runat="server" Width="130px"></asp:TextBox>
            </td>
            <td class="auto-style7">
                <asp:Label ID="Label9" runat="server" Text="Güncelleyen Kullanıcı"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtGuncelleyenKullanici" runat="server" Width="130px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style16" colspan="2">
                <asp:Label ID="Label5" runat="server" Text="Yuvarlama Değeri"></asp:Label>
            </td>
            <td class="auto-style17">
                <asp:TextBox ID="txtYuvarlamaDegeri" runat="server" Width="130px"></asp:TextBox>
            </td>
            <td class="auto-style18">
                <asp:Label ID="Label11" runat="server" Text="Güncelleme Tarihi"></asp:Label>
            </td>
            <td class="auto-style19">
                <asp:TextBox ID="txtGuncellemeTarihi" runat="server" Width="130px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label10" runat="server" Text="Planlanan Teslimat Süresi"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPlanlananTeslimatSuresi" runat="server" Width="130px"></asp:TextBox>
            </td>
            <td>
            </td>
            <td>
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
                <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" OnClick="btnKaydet_Click" />
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
