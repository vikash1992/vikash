<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="search.aspx.vb" Inherits="search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
      
        .my_btn{ 
  font-family:Arial; 
  font-size:10pt; 
  font-weight:normal; 
  height:30px; 
  line-height:30px; 
  width:98px; 
  border:0px;
  background-image:url('../pro_image/1.png'); 
  cursor:pointer;
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
            width :450px;
            height :30px;
        }
        .modal
        {
            position: fixed;
            top: 0;
            left: 0;
            background-color: black;
            z-index: 99;
            opacity: 0.8;
            filter: alpha(opacity=80);
            -moz-opacity: 0.8;
            min-height: 100%;
            width: 100%;
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
     
        .style14
        {
            height: 40px;
        }
        .style15
        {
            height: 42px;
        }
     
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server" >
         <asp:ScriptManager ID="ScriptManager1" runat="server">
           </asp:ScriptManager>  
     <script >
         $(function () {
             modalPosition();
             $(window).resize(function () {
                 modalPosition();
             });
             $('.openModal').click(function (e) {
                 var bar = $('.bar');
                 bar.width('0%')
                 var percent = $('.percent');
                 percent.html('0%');
                 var status = $('#status');
                 status.empty();
                 $("#fupload").val("");
                 $("#imgprv").attr("src", "");

                 $('.modal, .modal-backdrop').fadeIn('fast');

                 e.preventDefault();
             });
             $('.close-modal').click(function (e) {
                 $('.modal, .modal-backdrop').fadeOut('fast');
             });
             $("#btnUpload").click(function (evt) {
                 if ($("#fupload").val() == "") {
                     alert('Select any picture');
                     evt.preventDefault();
                 }
                 else {
                     var bar = $('.bar');
                     var percent = $('.percent');
                     var status = $('#status');
                     $('form').ajaxForm({
                         url: "FileUploadHandler.ashx",
                         type: "POST",
                         beforeSend: function () {
                             status.empty();
                             var percentVal = '0%';
                             bar.width(percentVal)
                             percent.html(percentVal);

                         },
                         uploadProgress: function (event, position, total, percentComplete) {
                             var percentVal = percentComplete + '%';
                             bar.width(percentVal)
                             percent.html(percentVal);

                         },
                         success: function () {
                             var percentVal = '100%';
                             bar.width(percentVal)
                             percent.html(percentVal);
                             $('.modal, .modal-backdrop').fadeOut(1500);



                         },
                         complete: function (xhr) {
                             status.html(xhr.responseText);
                         }
                     });
                 }

             });

             //Image preview
             prvimg = {
                 UpdatePreview: function (obj) {
                     if (!window.FileReader) {
                     } else {
                         var reader = new FileReader();
                         var target = null;

                         reader.onload = function (e) {
                             target = e.target || e.srcElement;

                             $("#imgprv").prop("src", target.result);
                         };
                         reader.readAsDataURL(obj.files[0]);
                     }
                 }
             };
         });
         function modalPosition() {
             var width = $('.modal').width();
             var pageWidth = $(window).width();
             var x = (pageWidth / 2) - (width / 2);
             $('.modal').css({ left: x + "px" });
         }
      </script>
      <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate >
    <table class="style5">
        
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                 
                <table class="style5">
                    <tr>
                        <td>
                            
                            <asp:Panel ID="Panel4" runat="server" Width="207px" >
                                <table class="style6" style="width: 185px; height: 256px;">
                                    <tr>
                                        <td class="style14">
                                            <asp:DropDownList ID="DropDownList1"  
                                                OnSelectedIndexChanged ="DropDownList1_SelectedIndexChanged" 
                                                AutoPostBack = "true" runat="server" Height="30px" Width="182px" CssClass="dropDownBox">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style14">
                                            <asp:DropDownList ID="DropDownList2" 
                                                OnSelectedIndexChanged ="DropDownList2_SelectedIndexChanged" 
                                                AutoPostBack = "true" runat="server" Height="30px" Width="182px" CssClass="dropDownBox">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style14">
                                            <asp:DropDownList ID="DropDownList3"  CssClass="dropDownBox" OnSelectedIndexChanged ="DropDownList3_SelectedIndexChanged" 
                                                AutoPostBack = "true" runat="server" Height="30px" Width="182px">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style15">
                                            <asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="true" CssClass="dropDownBox"
                                                Height="30px" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged" 
                                                Width="182px">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Panel ID="Panel2" runat="server" Height="398px" ScrollBars="Vertical" 
                                                Width="206px">
                                            </asp:Panel>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                          

                        </td>
                        <td>
                            <asp:Panel ID="Panel3" runat="server" ScrollBars="Vertical" Width ="502px" 
                                Height = "570px" HorizontalAlign="Left" style="overflow-x:scroll;">
                                <div class="loading" align="center">
          Please wait....<br />
        <br />
        <img src="loader.gif" alt="" />
    </div>
                            </asp:Panel>
                        </td>
                        <td>
                
                <embed src="img/ban.swf" 
                                    style="width: 151px; height: 580px; margin-left: 7px;"></td>
                    </tr>
                </table>
                
            </td>
        </tr>
    </table>
    
  </ContentTemplate>
                            </asp:UpdatePanel>
                            





       
 <%--   <asp:Button ID="btn_open" runat="server" Text="Upload files" CssClass="openModal" />
 --%>  
 
     
           <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate >
         
  <div class="modal">
    <div class="modal-header">
        <h3>upload Picture <a class="close-modal" href="#">&times;</a></h3>
    </div>
    <div class="modal-body">
       <div class="uploadfile">
 <table>
 <tr>
 <td>File:</td>
 <td>
 <asp:FileUpload ID="fupload" runat="server" onchange='prvimg.UpdatePreview(this)' /></td>
 <td>
     <asp:Button ID="Button1"  Text="Button" />
 </td>
 <td><asp:Image ID="imgprv" runat="server" Height="90px" Width="75px" /></td>
     </tr>

 </table>
 <div class="progress">
 <div class="bar"></div >
 <div class="percent">0%</div >
 <div id="status"></div>
 </div>
    </div>
       
    </div>
    <div class="modal-footer">
         <asp:Button ID="btnUpload" runat="server" cssClass="button" Text="Upload Selected File" />
    </div>
</div>
<div class="modal-backdrop"></div>
    
    </div>  </ContentTemplate>
           </asp:UpdatePanel>
</asp:Content>

