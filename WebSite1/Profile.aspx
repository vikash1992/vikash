<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Profile.aspx.vb" Inherits="Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
   
        
     
    .style11
    {
        width: 300px;
    }
    .style13
    {
        width: 43px;
    }
   
        
     
    .style14
    {
        width: 36%;
    }
    .style15
    {
        width: 30%;
    }
    .style4
    {
        width: 462px;
    }
   
        
     
        .loading
        {
            font-family: Arial;
            font-size: 10pt;
            border: 5px solid #67CFF5;
            width: 200px;
            height: 100px;
            display: none;
            position: fixed;
            background-color: White;
            z-index: 999;
        }
     
                
     
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
   
    <div  >
       
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   <br />
       
        <table class="style4">
        <tr>

            <td class="style13">
                &nbsp;</td>

            <td class="style11">
                   <asp:ImageButton ID="ImageButton1" runat="server" 
                     Width="292px" Height="171px" ImageUrl="~/img/DUMMY.jpeg" />
                <br />
                <asp:FileUpload ID="FileUpload1" runat="server" Width="144px" />
                <asp:Button ID="Button5" runat="server" Text="Uplode" />
           
                   <br />
                   <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Red" 
                       Text="Label"></asp:Label>
           
            </td>

            <td class="style15">
                



                <asp:Button ID="Button1" runat="server" Text="Add_New_Item" Width="198px" class="styled-button-2"  />
                 <br />
                   <asp:Button ID="Button4" runat="server" Text="Add_Constractor" Width="198px" class="styled-button-2"  />
                  <br />
                 <asp:Button ID="Button2" runat="server" Text="Add_Old_Item" Width="198px" class="styled-button-2" />
                   <br />
                  <asp:Button ID="Button3" runat="server" Text="Add_Rentel" Width="198px" class="styled-button-2"  />
                   <br />
                  <asp:Button ID="Button6" runat="server" Text="Add_Rentel" Width="198px" 
                    class="styled-button-2"  />
  
            </td>
        </tr>
    </table>
  

  <%--<div class="loading" align="center">
        Code Sending. Please wait.<br />
        <br />
        <img src="loader.gif" alt="" />
    </div>
--%>
</div>
    <br />
    <table class="style14">
        <tr>
            <td>
                



                <br />
                <asp:Panel ID="Panel2" runat="server">
                    <asp:Panel ID="Panel3" runat="server" Width ="502px" 
                                Height = "570px" HorizontalAlign="Left" style="overflow-x:scroll;">
                        <div class="loading" align="center">
                            Please wait....<br />
                            <br />
                            <img src="loader.gif" alt="" />
                        </div>
                    </asp:Panel>
                </asp:Panel>
  
            </td>
        </tr>
</table>
    <br />
    
    
</asp:Content>

