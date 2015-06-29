<%@ Page Language="VB" AutoEventWireup="false" CodeFile="test.aspx.vb" Inherits="test" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.1/themes/base/jquery-ui.css" 
        rel="stylesheet" type="text/css"/>
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.2/jquery.min.js" </script>
    <script src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.11/jquery-ui.min.js" </script>

    <style>
        .ui-autocomplete { 
            cursor:pointer; 
            height:120px; 
            overflow-y:scroll;
        }    
    </style>
</head>
<body>

 
    <form id="form1" runat="server">
    <div>
    <script>
        $(document).ready(function () {
            BindControls();
        });

        function BindControls() {
            var Countries = ['ARGENTINA',
                'AUSTRALIA',
                'BRAZIL',
                'BELARUS',
                'BHUTAN',
                'CHILE',
                'CAMBODIA',
                'CANADA',
                'CHILE',
                'DENMARK',
                'DOMINICA'];

            $('#tbCountries').autocomplete({
                source: Countries,
                minLength: 0,
                scroll: true
            }).focus(function () {
                $(this).autocomplete("search", "");
            });
        }
    </script>
    <div style="font:14px arial">
        <input type="text" id="tbCountries" />
    </div>
     <asp:Image ID="Image2" runat="server" ImageUrl = "~/img/1.jpg" Height = "400px" Width = "400px"/>
<br />
<asp:Button ID="btnGenerate" OnClick = "GenerateThumbnail" runat="server" Text="Generate Thumbnail" />
<hr />
<asp:Image ID="Image3" runat="server" Visible = "false" Height="50px" Width="56px"/>

        <asp:Button ID="Button1" runat="server" Text="Button" />
        <asp:FileUpload ID="FileUpload1" runat="server" />
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns = "false"
       Font-Names = "Arial" >
    <Columns>
       <asp:BoundField DataField = "IPID" HeaderText = "ID" />
       <asp:BoundField DataField = "PID" HeaderText = "PID" />
       <asp:ImageField DataImageUrlField="IMAGE" ControlStyle-Width="100"
        ControlStyle-Height = "100" HeaderText = "IMAGE"/>
    </Columns>
    </asp:GridView>
        <asp:Button ID="Button2" runat="server" Text="Button" />
    
    </div>
    </form>
</body>
</html>
