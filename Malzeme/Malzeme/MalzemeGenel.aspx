<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Site.Master" AutoEventWireup="true" CodeBehind="MalzemeGenel.aspx.cs" Inherits="Malzeme.MalzemeGenel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style5 {
            width: 220px;
        }
        .auto-style6 {
            width: 220px;
            height: 26px;
        }
        .auto-style7 {
            height: 26px;
        }
        .auto-style8 {
            width: 60px;
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
            <td class="auto-style5" colspan="3">
                <asp:Label ID="Label1" runat="server" Text="Malzeme Kodu"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="txtMalzemeKodu" runat="server" Width="130px"></asp:TextBox>
            </td>
            <td class="auto-style5">
                <asp:Label ID="Label12" runat="server" Text="Üretim Denetim Sorumlusu"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUretimDenetimSorumlusu" runat="server" Width="130px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5" colspan="3">
                <asp:Label ID="Label2" runat="server" Text="Malzeme Türü"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:DropDownList ID="ddlMalzemeTuru" runat="server" DataTextField="MlzTuru" DataValueField="Id" style="margin-left: 0px" Width="135px">
                </asp:DropDownList>
            </td>
            <td class="auto-style5">
                <asp:Label ID="Label13" runat="server" Text="Üretim Denetim Profili"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUretimDenetimProfili" runat="server" Width="130px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6" colspan="3">
                <asp:Label ID="Label3" runat="server" Text="Üretim Yeri"></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:DropDownList ID="ddlUretimYeri" runat="server" DataTextField="UYAdi" DataValueField="Id" Width="135px">
                </asp:DropDownList>
            </td>
            <td class="auto-style6">
                <asp:Label ID="Label14" runat="server" Text="Depo Adresi"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:TextBox ID="txtDepoAdresi" runat="server" Width="130px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5" colspan="3">
                <asp:Label ID="Label4" runat="server" Text="Depo Yeri"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="txtDepoYeri" runat="server" Width="130px"></asp:TextBox>
            </td>
            <td class="auto-style5">
                <asp:Label ID="Label15" runat="server" Text="Emniyet Stoğu"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEmniyetStogu" runat="server" Width="130px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5" colspan="3">
                <asp:Label ID="Label5" runat="server" Text="Malzeme Kısa Metni (TR)"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="txtMalzemeKısaMetni" runat="server" Width="130px"></asp:TextBox>
            </td>
            <td class="auto-style5">
                <asp:Label ID="Label17" runat="server" Text="Kaydeden Kullanıcı"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtKaydedenKullanici" runat="server" Width="130px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5" colspan="3">
                <asp:Label ID="Label6" runat="server" Text="Temel Ölçü Birimi"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:DropDownList ID="ddlTemelOlcuBirimi" runat="server" DataTextField="TOB" DataValueField="Id" Width="135px">
                </asp:DropDownList>
            </td>
            <td class="auto-style5">
                <asp:Label ID="Label18" runat="server" Text="Kayıt Tarihi"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtKayitTarihi" runat="server" Width="130px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5" colspan="3">
                <asp:Label ID="Label7" runat="server" Text="Mal Grubu"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:DropDownList ID="ddlMalGrubu" runat="server" Width="135px" DataTextField="MalGrubu" DataValueField="Id">
                </asp:DropDownList>
            </td>
            <td class="auto-style5">
                <asp:Label ID="Label19" runat="server" Text="Güncelleyen Kullanıcı"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtGuncelleyenKullanici" runat="server" Width="130px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5" colspan="3">
                <asp:Label ID="Label8" runat="server" Text="MIP Karakteristiği "></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:DropDownList ID="ddlMIPKarakteristigi" runat="server" DataTextField="MipKrk" DataValueField="Id" Width="135px">
                </asp:DropDownList>
            </td>
            <td class="auto-style5">
                <asp:Label ID="Label20" runat="server" Text="Güncelleme Tarihi"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtGuncellemeTarihi" runat="server" Width="130px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5" colspan="3">
                <asp:Label ID="Label9" runat="server" Text="MIP Sorumlusu"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:DropDownList ID="ddlMipSorumlusu" runat="server" DataTextField="MipSorumlusu" DataValueField="Id" Width="135px">
                </asp:DropDownList>
            </td>
            <td class="auto-style5">
                Onay Durumu</td>
            <td>
                <asp:DropDownList ID="ddlOnayDurum" runat="server" DataTextField="OnayDurum" Enabled="true" DataValueField="Id" Height="16px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style6" colspan="3">
                <asp:Label ID="Label10" runat="server" Text="MIP Parti Büyüklüğü"></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:TextBox ID="txtMipPartiBuyuklugu" runat="server" Width="130px"></asp:TextBox>
            </td>
            <td class="auto-style6">
                </td>
            <td class="auto-style7">
                </td>
        </tr>
        <tr>
            <td class="auto-style5" colspan="3">
                <asp:Label ID="Label11" runat="server" Text="Tedarik Türü"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:DropDownList ID="ddlTedarikTuru" runat="server" DataTextField="TedarikTuru" DataValueField="Id" Width="135px">
                </asp:DropDownList>
            </td>
            <td class="auto-style5">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5" colspan="3">
                &nbsp;</td>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="auto-style5">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" OnClick="btnKaydet_Click" />
            </td>
            <td class="auto-style5">
                <asp:Button ID="btnGonder" runat="server" style="margin-left: 0px" Text="Mail Gönder" OnClick="btnGonder_Click" />
            </td>
            <td class="auto-style8">
                &nbsp;</td>
            <td class="auto-style5">
                <asp:Button ID="btnOnay" runat="server" Text="Onay" OnClick="btnOnay_Click"   />
            </td>
            <td class="auto-style5">
                <asp:Button ID="btnSatinAlma" runat="server" Text="Satın Alma" OnClick="btnSatinAlma_Click"  />
            </td>
            <td>
                <asp:Button ID="btnFinans" runat="server" Text="Finans" OnClick="btnFinans_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
