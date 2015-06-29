<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Reg.aspx.vb" Inherits="Reg" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
       .dropDownBox
{
    font-size: 13px;
    color: #3b3b3b;
    padding: 5px;
    background: -moz-linear-gradient(
    top,
    #f0f0f0 0%,
    #d6d6d6);
    background: -webkit-gradient(
    linear, left top, left bottom, 
    from(#f0f0f0),
    to(#d6d6d6));
    -moz-border-radius: 3px;
    -webkit-border-radius: 3px;
    border-radius: 3px;
    border: 1px solid #999999;
    -moz-box-shadow: 0px 1px 2px rgba(000,000,000,0.5), inset 0px 1px 0px rgba(255,255,255,1);
    -webkit-box-shadow: 0px 1px 2px rgba(000,000,000,0.5), inset 0px 1px 0px rgba(255,255,255,1); 
    box-shadow: 0px 1px 2px rgba(000,000,000,0.5), inset 0px 1px 0px rgba(255,255,255,1);
     text-shadow: 0px 1px 0px rgba(255,255,255,1), 0px 1px 0px rgba(255,255,255,0);
}
    .style12
    {
        width: 1210px;
    }
    .style4
    {
        width: 306px;
    }
    </style>
  
 
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate >
    <table class="style4">
        <tr>
            <td class="style12">
                &nbsp;</td>
            <td>
                <table class="style4">
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" placeholder="F-Name" Width="120px" 
                                Height="16px" ></asp:TextBox>
                            <asp:TextBox ID="TextBox3" runat="server" placeholder="S-Name" Width="120px" 
                                Height="16px"  /></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server" placeholder="E-Mail" Width="261px" 
                                Height="16px"></asp:TextBox>
                              
				
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:TextBox ID="TextBox4" runat="server" placeholder="PassWord" Width="261px" 
                                TextMode="Password" Height="16px"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:TextBox ID="TextBox5" runat="server" placeholder="PassWord" Width="261px" 
                                TextMode="Password" Height="16px"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:TextBox ID="TextBox6" runat="server" placeholder="Mobile_No" Width="261px" 
                                Height="16px"></asp:TextBox>

                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:DropDownList ID="DropDownList4" runat="server" Font-Bold="False" CssClass="dropDownBox"
                                Font-Size="Small" Height="27px" Width="280px">
                                <asp:ListItem>Gender</asp:ListItem>
                                <asp:ListItem>Female</asp:ListItem>
                                <asp:ListItem>Male</asp:ListItem>
                                <asp:ListItem>Other</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <BotDetect:Captcha ID="captchaBox" runat="server" Height="46px" 
                                style="margin-left: 23px" Width="240px" />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style5">
                            </td>
                        <td class="style5">
                            
                            
                            <asp:TextBox ID="txtCaptcha" runat="server" Width="174px" Height="16px" palceholder="CaptchaBox"></asp:TextBox>
                            <asp:Button ID="Button1" runat="server" Text="SUBMIT" Font-Bold="True" Height="30px" Width="77px" CssClass="openModal"/>
                        </td>
                        <td>
                            </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            
                            
                              &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
                &nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>


    <div>
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
 <td>
     <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
     <asp:Button ID="Button2" runat="server" Text="Button" /></td>
 <td><asp:Image ID="imgprv" runat="server" Height="90px" Width="75px" />
 </td>
     </tr>

 </table>
 <%--<script >
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
      </script>--%>
<%-- <div class="progress">
 <div class="bar"></div >
 <div class="percent">0%</div >
 <div id="status"></div>
 </div>--%>
    </div>
       
    </div>
    <%--<div class="modal-footer">
         <asp:Button ID="btnUpload" runat="server"  Text="Upload Selected File" />
    </div>--%>
</div>
<div class="modal-backdrop"></div>
    
     
    
    </div>
     </ContentTemplate>
    </asp:UpdatePanel>
   
</asp:Content>

