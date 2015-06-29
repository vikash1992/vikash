<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AddPictureItem.aspx.vb" Inherits="AddPictureItem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style5
    {
        width: 104%;
    }
        .style11
        {
            width: 1029px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
 
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate >
    
    <asp:Panel ID="Panel3" runat="server" Width="814px">
        <table class="style5">
            <tr>
                <td>
                    <asp:Image ID="Image1" runat="server" Height="268px" Width="467px" />
                    <br />
                </td>
                <td>
                    <asp:Panel ID="Panel4" runat="server" Height="218px" Width="319px">
                        <asp:Label ID="Label11" runat="server" Text="PRICE" Width="280px"></asp:Label>
                        <br />
                        <br />
                        <asp:Label ID="Label1" runat="server" Text="name" Width="280px"></asp:Label>
                        <br />
                        <br />
                        <asp:Label ID="Label2" runat="server" Text="address"></asp:Label>
                        &nbsp;,<asp:Label ID="Label3" runat="server" Text="city"></asp:Label>
                        ,&nbsp;<asp:Label ID="Label4" runat="server" Text="state"></asp:Label>
                        <br />
                        <br />
                        <asp:Label ID="Label5" runat="server" Text="mobile" Width="300px"></asp:Label>
                        <br />
                        &nbsp;<asp:Label ID="Label6" runat="server" Text="email" Width="278px"></asp:Label>
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
                        <asp:Button ID="Button1" runat="server" class="styled-button-2" Text="Edit" 
                            Width="304px" />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                    </asp:Panel>
                </td>
            </tr>
        </table>
    </asp:Panel>
    </ContentTemplate>
    </asp:UpdatePanel>
    
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
           <div style="height: 6px">
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
 <asp:FileUpload ID="fupload" runat="server" onchange='prvimg.UpdatePreview(this)' />
 </td>
 <td><asp:Image ID="imgprv" runat="server" Height="90px" Width="75px" />
 </td>
     </tr>

 </table>
<%-- <div class="progress">
 <div class="bar"></div >
 <div class="percent">0%</div >
 <div id="status"></div>
 </div>--%>
    </div>
       
    </div>
    <div class="modal-footer">
         <asp:Button ID="btnUpload" runat="server"  Text="Upload Selected File" />
    </div>
</div>
<div class="modal-backdrop"></div>
    
    <asp:Button ID="btn_open" runat="server" Text="Upload files" class="styled-button-2" 
                   CssClass="openModal" Visible="False" />
    
    </div>
        <br />
        <asp:Panel ID="Panel6" runat="server" style="margin-left: 9px" 
    Width="818px">
            <table class="style11">
                <tr>
                    <td>
                        <asp:Panel ID="Panel5" runat="server" Width="320px">
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td>
                        <table class="style8" style="width: 28%">
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
            </table>
</asp:Panel>
        <br />
        <br />
 
           
   <%-- <asp:FileUpload ID="Add_Pic" runat="server" Width="108px"  />
    <asp:Button ID="Uplode" runat="server" Text="Button" Width="82px"  />
    --%>
</asp:Content>

