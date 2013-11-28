<%@ Control Language="C#" AutoEventWireup="true" Inherits="UserControls_IndependentPager"
    CodeBehind="IndependentPager.ascx.cs" %>
<asp:HiddenField ID="hfTotalRows" Value="0" runat="server" />
<div align="center" style="background: #F1F1F1">
    <b>
        <asp:Literal ID="ltlInfo" runat="server"></asp:Literal></b>
</div>
<div align="center" class="pgrback" style="padding: 1;">
    <asp:Repeater ID="Repeater1" runat="server">
        <HeaderTemplate>
            <table>
                <tr>
        </HeaderTemplate>
        <ItemTemplate>
            <td>
                <asp:LinkButton CssClass='<%# "pgit pg" + Eval("PageNo") %>' CommandArgument='<%# Eval("PageNo") %>'
                    Text='<%# Eval("Text") %>' CommandName="ChangePage" runat="server" OnClick="PagerItem_Click"></asp:LinkButton>
            </td>
        </ItemTemplate>
        <FooterTemplate>
            </tr></table>
        </FooterTemplate>
    </asp:Repeater>
</div>
