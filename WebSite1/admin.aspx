<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="admin.aspx.vb" Inherits="admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="style17" style="width: 88%">
    <tr>
        <td>
            <br />
        </td>
    </tr>
    <tr>
        <td>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">

            <ContentTemplate>
            <asp:Panel ID="Panel2" runat="server">
            </asp:Panel>
  </ContentTemplate>
            </asp:UpdatePanel>
            
            </td>
    </tr>
</table>
</asp:Content>

