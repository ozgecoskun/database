<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Site.Master" AutoEventWireup="true" CodeBehind="MalzemeSinifKarakteristik.aspx.cs" Inherits="Malzeme.MalzemeSinifKarakteristik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
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
                <asp:Label ID="Label1" runat="server" Text="Malzeme Kodu"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtMalzemeKodu" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Sınıflar"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlSiniflar" runat="server" DataTextField="SinifAdi" DataValueField="Id">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="2">
                <asp:Button ID="btnGiris" runat="server" Text="Giriş" OnClick="btnGiris_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="2">
                 <asp:GridView ID="gridSiniflar" CssClass="grid" runat="server" AutoGenerateColumns="False"
                        CellPadding="1" CellSpacing="2" BorderStyle="None" EnableModelValidation="True">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="Malzeme Kodu" HeaderText="Malzmem Kodu" />
                             <asp:BoundField DataField="KarakteristikId" HeaderText="Karakteristik" />
                            <asp:BoundField DataField="Kararkteristik Degeri" HeaderText="Kararkteristik Değeri" />
                           
                         
                        </Columns>
                    </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
