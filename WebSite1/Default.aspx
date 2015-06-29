<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<!-- Start WOWSlider.com HEAD section -->
<link rel="stylesheet" type="text/css" href="engine1/style.css" />
<script type="text/javascript" src="engine1/jquery.js"></script>
<!-- End WOWSlider.com HEAD section -->
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <!-- Start WOWSlider.com BODY section -->


        <asp:Panel ID="Panel1" runat="server">

        <div id="wowslider-container1">
<div class="ws_images"><ul>
		<li><a href="http://wowslider.com/vi"><img src="data1/images/images.jpg" alt="bootstrap slider" title="images" id="wows1_0"/></a></li>
		<li><img src="data1/images/imgres.jpg" alt="imgres" title="imgres" id="wows1_1"/></li>
	</ul></div>
	<div class="ws_bullets"><div>
		<a href="#" title="images"><span><img src="data1/tooltips/images.jpg" alt="images"/>1</span></a>
      <a href="#" title="imgres"><span><img src="data1/tooltips/imgres.jpg" alt="imgres"/>2</span></a>
       

	</div>
   </div>  
	<div class="ws_script" style="position:absolute;left:-99%"><a href="http://wowslider.com">css image gallery</a> by WOWSlider.com v7.7</div>
     	       <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
	
	
<div class="ws_shadow"></div>
</div>
        </asp:Panel>	
<script type="text/javascript" src="engine1/wowslider.js"></script>
<script type="text/javascript" src="engine1/script.js"></script>
<!-- End WOWSlider.com BODY section -->
       <asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox>
	
	
    </div>
    </form>
</body>
</html>
