<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Default3.aspx.vb" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
    
         <!-- Bootstrap -->
     
  
    <style type="text/css">
       
        
        
        
     .styled-button-2 {
	-webkit-box-shadow:rgba(0,0,0,0.2) 0 1px 0 0;
	-moz-box-shadow:rgba(0,0,0,0.2) 0 1px 0 0;
	box-shadow:rgba(0,0,0,0.2) 0 1px 0 0;
	border-bottom-color:#333;
	border:1px solid #61c4ea;
	background-color:#7cceee;
	border-radius:5px;
	-moz-border-radius:5px;
	-webkit-border-radius:5px;
	color:#333;
	font-family:'Verdana',Arial,sans-serif;
	font-size:14px;
	text-shadow:#b2e2f5 0 1px 0;
	padding:5px
}
        .style4
        {
            width: 386px;
        }
    </style>
 
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
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
    <table class="style4">
    <tr>
        <td class="style6">
                        &nbsp;</td>
        <td>
            <table class="style4">
                <tr>
                    <td class="style5">
                    </td>
                </tr>
                <tr>
                    <td class="style8">
                        <table class="style8">
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
                        <asp:Panel ID="Panel2" runat="server" 
                            Height="258px" Width="386px">
                            <table class="form-signin" align="center">
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                    <%--<div class="demo">
<div class="ui-widget">
<label for="tbAuto">Enter UserName: </label>
<input type="text" id="txtSearch" class="autosuggest"/>
 <asp:TextBox ID="txtSearch" runat="server"  class="autosuggest"></asp:TextBox>
 
    <asp:Button ID="Button3" runat="server" Text="Button" />
                </div>
    
</div>--%> 

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
                                        <asp:Label ID="Label1" runat="server"></asp:Label>
                                    </td>
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
                                         <asp:TextBox ID="TextBox1" runat="server" Width="210px"  
                                             class="input-xlarge focused" Height="16px" ></asp:TextBox> 
                                    </td>
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
                                        <asp:TextBox ID="TextBox2" runat="server" Width="210px" TextMode="Password" 
                                            Height="16px"></asp:TextBox>
                                    </td>
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
                                        &nbsp;<asp:Button ID="Button1" runat="server" Text="LOG IN" Width="110px" 
                                            class="styled-button-2"/>
                                        <asp:Button ID="Button2" runat="server" Text="SIGNUP" Width="104px" 
                                            class="styled-button-2"/>
                                    </td>
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
                                        <asp:LinkButton ID="LinkButton2"   runat="server" ForeColor="Blue">Forget_Passaword</asp:LinkButton>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
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
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td class="style7">
                        &nbsp;</td>
                </tr>
            </table>
        </td>
        <td>
            &nbsp;</td>
    </tr>
</table>
<div class="modal">
    <div class="modal-header">
        <h3>Enter Code <a class="close-modal" href="#">&times;</a></h3>
    </div>
    <div class="modal-body">
       <div class="uploadfile">
 <table>
 <tr>
 <td>File:</td>
   <td>
     <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
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
</asp:Content>

