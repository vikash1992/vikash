<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Changepassword.aspx.vb" Inherits="Changepassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style11
        {
            width: 450px;
        }
        .style13
        {
            width: 1079px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Panel ID="Panel2" runat="server" Height="329px">
        <table class="style8" style="height: 102px; width: 19%;">
            <tr>
                <td align="center" class="style13">
                    &nbsp;</td>
                <td align="center">
                    <table class="style8" style="width: 86%">
                        <tr>
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
                                <asp:Label ID="Label1" runat="server"></asp:Label>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server" Width="197px" placeholder="Code" 
                                    Height="16px"></asp:TextBox>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                <asp:TextBox ID="TextBox2" runat="server" Width="197px" placeholder="Password" 
                                    TextMode="Password" Height="16px"></asp:TextBox>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                <asp:TextBox ID="TextBox3" runat="server" Width="197px" 
                                    placeholder=" Re-Password" TextMode="Password" Height="16px"></asp:TextBox>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                <asp:Button ID="Button1" runat="server" class="styled-button-2" Height="30px" 
                                    Text="Change" Width="100px" />
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                </td>
                <td align="center">
                    &nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>

