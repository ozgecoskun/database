<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Site.Master" AutoEventWireup="true" CodeBehind="AramaSayfasi.aspx.cs" Inherits="Malzeme.AramaSayfasi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            height: 26px;
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
            <td class="auto-style2">
                <asp:Label ID="Label1" runat="server" Text="Malzeme Kodu"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="txtMalzemeKodu" runat="server" Width="130px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Bölümü"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtBolum" runat="server" Width="130px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnAra" runat="server" Text="Ara" OnClick="btnAra_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                <asp:GridView ID="grdListe" CssClass="grid" runat="server" AutoGenerateColumns="False"
                    CellPadding="1" CellSpacing="2" BorderStyle="None" EnableModelValidation="True">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                      
                        <asp:HyperLinkField DataNavigateUrlFields="MalzemeKodu" DataNavigateUrlFormatString="MalzemeGenel.aspx?MalzemeKodu={0}"
                            DataTextField="MalzemeKodu" HeaderText="Malzeme Kodu" />
                        <asp:BoundField DataField="IdMalzemeTuru" HeaderText="Malzeme Türü" />
                        <asp:BoundField DataField="IdUretimYeri" HeaderText="Üretim Yeri" />
                        <asp:BoundField DataField="MalzemeKısaMetni" HeaderText="Malzeme Kısa Metni" />
                        <asp:BoundField DataField="DepoYeri" HeaderText="Depo Yeri" />
                        <asp:BoundField DataField="DepoAdresi" HeaderText="Depo Adresi" />
                        <asp:BoundField DataField="KaydedenKullanici" HeaderText="Kaydeden Kullanici" />
                        <asp:BoundField DataField="KayitTarihi" HeaderText="Kayıt Tarihi" />
                        <asp:BoundField DataField="GuncelleyenKullanici" HeaderText="Güncelleyen Kullanıcı" />
                        <asp:BoundField DataField="GuncellemeTarihi" HeaderText="Güncelleme Tarihi" />
                        <asp:BoundField DataField="IdOnayDurumu" HeaderText="Onay Durumu" />

                    </Columns>
                </asp:GridView>

            </td>

        </tr>


    </table>
</asp:Content>
