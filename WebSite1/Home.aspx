<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Home.aspx.vb" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        
    .style11
    {
        width: 623px;
    }
    .style12
    {
        width: 324px;
    }
    .style13
    {
        width: 81px;
    }
      .info
        {
            background-color: Black ;
            filter: alpha(opacity=60);
            opacity: 0.6;
            position: relative ;
            display: BLACK ;
            color: White  ;
            font-family: Arial;
            font-size: 10pt;
           
        }
        
        .style14
        {
            width: 138px;
        }
        .style15
        {
            width: 164px;
        }
        .style16
        {
            width: 189px;
        }
                
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
     
    <table class="style8" style="width: 66%">
        <tr>
            <td class="style12">
                <asp:Panel ID="Panel2" runat="server" Height="485px" ScrollBars="Vertical" 
                    Width="206px">
                </asp:Panel>
            </td>
            <td class="style11">
                <table class="style10" style="width: 471px; height: 549px;">
                    <tr>
                        <td class="style6">
                            </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            <table class="style10" style="width: 476px; height: 501px;">
                                <tr>
                                    <td class="style15">
                                        <asp:ImageButton ID="ImageButton1" runat="server"   CssClass ="zoom2"
                                             ImageUrl="~/image/1.jpg"  />
                                    </td>
                                    <td class="style14">
                                        <asp:ImageButton ID="ImageButton13" runat="server"  CssClass ="zoom2" 
                                             ImageUrl="~/image/Car hire - Budget Hyundai i30 - LR.jpg"  />
                                    </td>
                                    <td class="style16">
                                        <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/image/herohonda-glamour-fi.jpg"  CssClass ="zoom2" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style15">
                                        <asp:ImageButton ID="ImageButton4" runat="server"  ImageUrl="~/image/edging-a-wall.jpg"  CssClass ="zoom2"/>
                                    </td>
                                    <td class="style14">
                                        <asp:ImageButton ID="ImageButton7" runat="server"  CssClass ="zoom2" ImageUrl="~/image/electronicboard2.jpg"  />
                                    </td>
                                    <td class="style16">
                                        <asp:ImageButton ID="ImageButton12" runat="server"  ImageUrl="~/image/Hammer.jpg" CssClass ="zoom2"/>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style15">
                                        <asp:ImageButton ID="ImageButton5" runat="server"   ImageUrl="~/image/wm226668tt.jpg"  CssClass ="zoom2" />
                                    </td>
                                    <td class="style14">
                                        <asp:ImageButton ID="ImageButton8" runat="server" ImageUrl="~/image/painting6.jpg" CssClass ="zoom2"/>
                                    </td>
                                    <td class="style16">
                                        <asp:ImageButton ID="ImageButton11" runat="server" ImageUrl="~/image/9.jpg"  CssClass ="zoom2"/>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style15">
                                        <asp:ImageButton ID="ImageButton6" runat="server"  ImageUrl="~/image/6.jpg"  CssClass ="zoom2"/>
                                    </td>
                                    <td class="style14">
                                        <asp:ImageButton ID="ImageButton9" runat="server"   ImageUrl="~/image/15.jpg"  CssClass ="zoom2"  />
                                    </td>
                                    <td class="style16">
                                        <asp:ImageButton ID="ImageButton10" runat="server"  ImageUrl="~/image/18.jpg"  CssClass ="zoom2" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
            <td class="style13">
                
                <embed src="img/ban.swf" 
                                    style="width: 151px; height: 580px; margin-left: 7px;">
                
                </td>
        </tr>
    </table>
     
</asp:Content>

