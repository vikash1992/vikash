<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Type.aspx.vb" Inherits="Type" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style11
        {
            width: 100%;
        }
    .dropDownBox
    {}
        .style20
        {
            width: 277px;
        }
        .style21
        {
            width: 256px;
        }
        .style22
        {
            width: 264px;
        }
        .style23
        {
            width: 217px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Panel ID="Panel1" runat="server" Width="856px">
        <br />
        <br />
        <br />
        <table class="style11">
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <table class="style11">
                        <tr>
                            <td class="style23">
                                &nbsp;</td>
                            <td class="style20">
                                <asp:Label ID="Label1" runat="server"></asp:Label>
                            </td>
                            <td class="style21">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style23">
                                &nbsp;</td>
                            <td class="style20">
                                <asp:DropDownList ID="DropDownList4" runat="server" Height="30px" Width="227px" 
                                    CssClass="dropDownBox">
                                    <asp:ListItem>Select_Type</asp:ListItem>
                                    <asp:ListItem>New</asp:ListItem>
                                    <asp:ListItem>Old</asp:ListItem>
                                    <asp:ListItem>On Rent</asp:ListItem>
                                    <asp:ListItem>Service Providers</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td class="style21">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style23">
                                &nbsp;</td>
                            <td class="style20">
                                <asp:TextBox ID="TextBox1" runat="server" placeholder="Product Name" 
                                    Width="226px"></asp:TextBox>
                            </td>
                            <td class="style21">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style23">
                                &nbsp;</td>
                            <td class="style20">
                                <asp:Button ID="Button1" runat="server" Text="SUBMIT" class="styled-button-2" 
                                    Font-Bold="True" Height="30px" />
                            </td>
                            <td class="style21">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style23">
                                &nbsp;</td>
                            <td class="style20">
                                &nbsp;</td>
                            <td class="style21">
                                &nbsp;</td>
                        </tr>
                    </table>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        <br />
    </asp:Panel>
</asp:Content>

