<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="test1.aspx.vb" Inherits="test1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            width: 100%;
        }
        
        
        
        .fileUploadQueueItem {
	font: 11px Verdana, Geneva, sans-serif;
	background-color: #F5F5F5;
	border: 3px solid #E5E5E5;
	margin-top: 5px;
	padding: 10px;
	width: 300px;
}
.fileUploadQueueItem .cancel {
	float: right;
}
.fileUploadProgress {
	background-color: #FFFFFF;
	border-top: 1px solid #808080;
	border-left: 1px solid #808080;
	border-right: 1px solid #C5C5C5;
	border-bottom: 1px solid #C5C5C5;
	margin-top: 10px;
	width: 100%;
}
.fileUploadProgressBar {
	background-color: #0099FF;
}
        
      .vis4
{
        }
.vis4:hover 
{
    
position: relative;
    
   
width: 150px;
height: 100px;
border: 10px solid black;
background-color:#000000;
color:#fff;
}

    </style>
    <script type = "text/javascript">
        $(window).load(
    function () {
        $("#<%=FileUpload1.ClientID %>").fileUpload({
            'uploader': 'scripts/uploader.swf',
            'cancelImg': 'images/cancel.png',
            'buttonText': 'Browse Files',
            'script': 'Upload.ashx',
            'folder': 'uploads',
            'fileDesc': 'Image Files',
            'fileExt': '*.jpg;*.jpeg;*.gif;*.png',
            'multi': true,
            'auto': true
        });
    }
);
</script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
   
    <br />
    <br />
    <asp:Table ID="Table1" runat="server" cssclass="vis4" >
        <asp:TableFooterRow>
        <asp:TableCell >
         <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl ="loader.gif">
           
        </asp:ImageButton>
        </asp:TableCell>
        
        </asp:TableFooterRow>
       
    </asp:Table>
   
    <asp:Button ID="Button5" runat="server" Text="Button" />
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
   
    <asp:Panel ID="Panel4" runat="server" BackColor="#666666" 
    BackImageUrl="~/img/18.jpg" BorderStyle="None" Font-Size="Smaller" 
    ForeColor="#660066" GroupingText="rgrtetete" Height="200px" ScrollBars="Auto" 
    Width="200px">
</asp:Panel>
<asp:MultiView ID="MultiView1" runat="server">
</asp:MultiView>
<asp:FileUpload ID="FileUpload1" multiple="true" runat="server" BorderStyle="None" />
    <asp:Button ID="Button1" runat="server" Text="Button" /> 
            <div id="Info" runat="server" style="padding:20px 0;">
                <asp:Button ID="Button3" runat="server" Text="xfsfs" style="height: 26px" />
                <asp:Button ID="Button2" runat="server" Text="Button" />
                <asp:Button ID="Button4" runat="server" Text="Button" />
                <table class="style5">
                    <tr>
                        <td>
                             
                            <asp:Panel ID="Panel3" runat="server"  >

                            
                            </asp:Panel>
                            
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
                <asp:Image ID="Image1" runat="server" />
    </div>
     

</asp:Content>

