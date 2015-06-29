<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Subtype.aspx.vb" Inherits="Subtype" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style11
        {
            width: 939px;
        }
    .dropDownBox
    {}
        .style19
        {
            width: 454px;
        }
        .style20
        {
            width: 350px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="style11">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <table class="style11">
                    <tr>
                        <td class="style19">
                            &nbsp;</td>
                        <td class="style20">
                            <asp:DropDownList ID="DropDownList1" runat="server" Height="30px" Width="223px" 
                                CssClass="dropDownBox">
                            </asp:DropDownList>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style19">
                            &nbsp;</td>
                        <td class="style20">
                            <asp:TextBox ID="TextBox1" runat="server" Height="24px" Width="219px" Placeholder="Sub Item Name"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style19">
                            &nbsp;</td>
                        <td class="style20">
                            <asp:Button ID="Button1" runat="server" class="styled-button-2" Text="SUBMIT" 
                                Width="80px" Font-Bold="True" Height="30px" />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style19">
                            &nbsp;</td>
                        <td class="style20">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style19">
                            &nbsp;</td>
                        <td class="style20">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

