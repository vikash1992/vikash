<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="itemadd.aspx.vb" Inherits="itemadd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            width: 100%;
        }
        .style6
        {
            height: 16px;
        }
        .style7
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"/>
     
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate >
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
                                Width="259px">
                            </asp:DropDownList>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server"   Width="240px" ReadOnly="True" 
                                Height="16px"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:TextBox ID="TextBox4" runat="server" placeholder="E-Mail" Width="240px" 
                                Height="16px"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:DropDownList ID="DropDownList4" runat="server"   
                                OnSelectedIndexChanged ="DropDownList4_SelectedIndexChanged"   Height="30px" 
                                AutoPostBack = "true" Width="259px">
                            </asp:DropDownList>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style6">
                            </td>
                        <td class="style6">
                            <asp:DropDownList ID="DropDownList5"  AutoPostBack = "true" runat="server"  OnSelectedIndexChanged="DropDownList5_SelectedIndexChanged"
                                  Height="29px" Width="259px">
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
                                Width="240px" Height="17px"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:TextBox ID="TextBox8" runat="server" placeholder="Mobile_No" 
                                Width="240px" Height="16px"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:DropDownList ID="DropDownList6" runat="server"  Height="30px" 
                                Width="259px"  AutoPostBack = "true" 
                                OnSelectedIndexChanged ="DropDownList6_SelectedIndexChanged" >
                            </asp:DropDownList>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:DropDownList ID="DropDownList7" runat="server" Height="30px" Width="259px" 
                                AutoPostBack = "true">
                            </asp:DropDownList>
                            <table class="style7">
                                <tr>
                                    <td>
                                        <asp:TextBox ID="TextBox10" runat="server" placeholder="Address" 
                                            Width="240px" Height="16px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="TextBox11" runat="server" placeholder="Price\Rent" 
                                            Width="240px" Height="16px"></asp:TextBox>
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
                            <asp:Button ID="Button1" runat="server" Text="Add_Picture" 
                                style="height: 26px" />
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

    
</asp:Content>

