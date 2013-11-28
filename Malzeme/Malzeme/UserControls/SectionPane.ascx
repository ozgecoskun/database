<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SectionPane.ascx.cs" Inherits="Template.Web.UserControls.SectionPane" %>
 <div style="width: 194px; margin-bottom: 10px">
    <table style="border-collapse: collapse" class="qlh" border="0" cellspacing="0" cellpadding="0">
        <tr style="height: 3px">
            <td colspan="2">
                <img class="unity" src="../Images/template/null.gif" />
            </td>
        </tr>
        <tr>
            <td style="padding-left: 10px">
                <a class="qlh" href="<%= this.Url %>"><%= this.Label %></a>
            </td>
            <td style="width: 20px; padding-right: 10px" align="right">
                <span>
                    <img style="cursor: default" align="absMiddle" src="../Images/template/more.gif" />
                </span>
            </td>
        </tr>
        <tr style="height: 4px">
            <td colspan="2">
                <img class="unity" src="../Images/template/null.gif" />
            </td>
        </tr>
    </table>
    <div style="width: 100%" class="qlcc">
        <div class="qlp">
            <asp:Repeater ID="repeater1" runat="server">
                <HeaderTemplate>
                <ul class="qll">
                </HeaderTemplate>
                <ItemTemplate>
                    <li class="qli" title=""><a class="qlc" href='<%# Eval("Url") %>'><%# Eval("Label") %></a></li>
                </ItemTemplate>
                <FooterTemplate>
                </ul>
                </FooterTemplate>
            </asp:Repeater>

            <ul class="qll" id="ulempty" runat="server">
            (Listede veri yok)</ul>
        </div>
    </div>
    <table style="border-collapse: collapse" class="qlb" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td>
                <img class="unity" src="../Images/template/null.gif" />
            </td>
        </tr>
    </table>
</div>