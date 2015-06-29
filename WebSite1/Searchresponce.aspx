<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Searchresponce.aspx.vb" Inherits="Searchresponce" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
       
      
        </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server" >
   
  
    <asp:ScriptManager ID="ScriptManager1" runat="server">
                                            </asp:ScriptManager>
                                          
    <table class="style5" style="width: 1014px"   >
        <tr>
            <td class="style7">
                            <asp:Panel ID="Panel4" runat="server" GroupingText="Contact-Detail" 
                                Height="492px" Width="412px">
                                <table align="center" class="style5">
                                    <tr>
                                        <td>
                                             <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                                <ContentTemplate>
                                                    <asp:Panel ID="Panel3" runat="server" style="margin-left: 0px" Width="359px">
                                                        <asp:Image ID="Image1" runat="server" Height="187px" Width="358px" />
                                                        <br />
                                                    </asp:Panel>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </td>
                                    </tr>
                                </table>
                                <br />
                                <asp:Label ID="Label1" runat="server" Text="name" Width ="400"></asp:Label>
                                <br />
                                <br />
                                <asp:Label ID="Label2" runat="server" Text="address"></asp:Label>
                                &nbsp;,<asp:Label ID="Label3" runat="server" Text="city"></asp:Label>
                                ,&nbsp;<asp:Label ID="Label4" runat="server" Text="state"></asp:Label>
                                <br />
                                <asp:Label ID="Label5" runat="server" Text="mobile" Width = "370"></asp:Label>
                                <br />&nbsp;<asp:Label ID="Label6" runat="server" Text="email" Width="400"></asp:Label>
                                <br />
                                <br />
                                <asp:Label ID="Label7" runat="server" Text="type"></asp:Label>
                                ,<asp:Label ID="Label8" runat="server" Text="item_type"></asp:Label>
                                &nbsp;,<asp:Label ID="Label9" runat="server" Text="sub_item_type"></asp:Label>
                                <br />
                                <asp:Label ID="Label10" runat="server" Text="about"></asp:Label>
                                <br />
                                <br />
                                <br />
                                <br />
                            </asp:Panel>
                 </td>
            <td>
                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                <ContentTemplate >
                
                
                <asp:Panel ID="Panel6" runat="server" Height="470px" ScrollBars="Vertical">
                    <table class="style6" align ="left" >
                        <tr>
                            <td>
                                <asp:Panel ID="Panel5" runat="server" Width="320px">
                                    <br />
                                </asp:Panel>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <table class="style8" style="width: 100%">
                                    <tr>
                                        <td>
                                            <asp:Image ID="Image2" runat="server" Height="35px" Width="45px" />
                                        </td>
                                        <td>
                                            <asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="273px"></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>

                </ContentTemplate>
                </asp:UpdatePanel>


&nbsp;</td>
        </tr>
    </table>
  
   
    <br />
     <asp:UpdatePanel ID="UpdatePanel2" runat="server" width="600px">
    <ContentTemplate >
        &nbsp;
  
   
    </ContentTemplate>
    </asp:UpdatePanel>
   
</asp:Content>

