<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Edit.aspx.vb" Inherits="Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style11
        {
            width: 100%;
        }
        .style12
        {
            width: 661px;
        }
        .style4
        {
            width: 100%;
        }
        .style7
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
  
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:Panel ID="Panel1" runat="server">
        <table class="style11">
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <table class="style11">
                        <tr>
                            <td>
                                <table class="style11">
                                    <tr>
                                        <td class="style12">
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                    <ContentTemplate>
                                        <table class="style4">
                                            <tr>
                                                <td>
                                                    &nbsp;</td>
                                                <td>
                                                    <table class="style4">
                                                        <tr>
                                                            <td>
                                                                &nbsp;</td>
                                                            <td>
                                                                <asp:Label ID="Label1" runat="server" ForeColor="#CC0000"></asp:Label>
                                                            </td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                &nbsp;</td>
                                                            <td>
                                                                <asp:DropDownList ID="DropDownList8" runat="server" AutoPostBack="true" 
                                                                    Height="30px" OnSelectedIndexChanged="DropDownList8_SelectedIndexChanged" 
                                                                    Width="268px">
                                                                </asp:DropDownList>
                                                            </td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                &nbsp;</td>
                                                            <td>
                                                                <asp:TextBox ID="TextBox3" runat="server" ReadOnly="True" Width="250px" 
                                                                    Height="16px"></asp:TextBox>
                                                            </td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                &nbsp;</td>
                                                            <td>
                                                                <asp:TextBox ID="TextBox4" runat="server" placeholder="E-Mail" Width="250px" 
                                                                    ReadOnly="True" Height="16px"></asp:TextBox>
                                                            </td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                &nbsp;</td>
                                                            <td>
                                                                <asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="true" 
                                                                    Height="30px" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged" 
                                                                    Width="268px">
                                                                </asp:DropDownList>
                                                            </td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style6">
                                                            </td>
                                                            <td class="style6">
                                                                <asp:DropDownList ID="DropDownList5" runat="server" AutoPostBack="true" 
                                                                    Height="30px" OnSelectedIndexChanged="DropDownList5_SelectedIndexChanged" 
                                                                    Width="268px">
                                                                </asp:DropDownList>
                                                            </td>
                                                            <td class="style6">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                &nbsp;</td>
                                                            <td>
                                                                <asp:TextBox ID="TextBox7" runat="server" placeholder="About This" 
                                                                    Width="250px" Height="16px"></asp:TextBox>
                                                            </td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                &nbsp;</td>
                                                            <td>
                                                                <asp:TextBox ID="TextBox8" runat="server" placeholder="Mobile_No" Width="250px" 
                                                                    Height="16px"></asp:TextBox>
                                                            </td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                &nbsp;</td>
                                                            <td>
                                                                <asp:DropDownList ID="DropDownList6" runat="server" AutoPostBack="true" 
                                                                    Height="31px" OnSelectedIndexChanged="DropDownList6_SelectedIndexChanged" 
                                                                    Width="268px">
                                                                </asp:DropDownList>
                                                            </td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                &nbsp;</td>
                                                            <td>
                                                                <asp:DropDownList ID="DropDownList7" runat="server" AutoPostBack="true" 
                                                                    Height="30px" Width="268px">
                                                                </asp:DropDownList>
                                                                <table class="style7">
                                                                    <tr>
                                                                        <td>
                                                                            <asp:TextBox ID="TextBox10" runat="server" placeholder="Address" Width="250px" 
                                                                                Height="16px"></asp:TextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <asp:TextBox ID="TextBox11" runat="server" placeholder="Price\Rent" 
                                                                                Width="250px" Height="16px"></asp:TextBox>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                &nbsp;</td>
                                                            <td>
                                                                <asp:Button ID="Button1" runat="server" Text="Update" class="styled-button-2" 
                                                                    Height="30px" Width="133px"/>
                                                                <asp:Button ID="Button2" runat="server" Text="Delete" class="styled-button-2" 
                                                                    Height="30px" Width="132px" />
                                                            </td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                    </table>
                                                </td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                        </table>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                    </table>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>

