<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vendor.aspx.cs" Inherits="WebApplication3.vendor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 1082px;
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Welcome"></asp:Label>
            <br />
        </div>
        <asp:Button ID="postproducts" runat="server" Height="36px" OnClick="postProduct" Text="Post_product" />
        <br />
        <asp:Label ID="Label3" runat="server" Text="please enter these information"></asp:Label>
&nbsp;:<br />
        <asp:Label ID="product_name" runat="server" Text="Product_name"></asp:Label>
        <asp:TextBox ID="text_box_productname" runat="server" style="margin-left: 57px"></asp:TextBox>
&nbsp;<br />
        <asp:Label ID="category" runat="server" Text="Category"></asp:Label>
        <asp:TextBox ID="text_box_category" runat="server" style="margin-left: 90px"></asp:TextBox>
        <br />
        <asp:Label ID="description" runat="server" Text="Product_description"></asp:Label>
        <asp:TextBox ID="text_box_productdescription" runat="server" style="margin-left: 23px"></asp:TextBox>
        <br />
        <asp:Label ID="price" runat="server" Text="Price"></asp:Label>
        <asp:TextBox ID="text_box_price" runat="server" style="margin-left: 116px"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Color"></asp:Label>
        <asp:TextBox ID="text_box_color" runat="server" style="margin-left: 115px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="viewproducts" runat="server" Height="38px" OnClick="vendorviewProducts" Text="View_products" Width="113px" />
        <br />
        <br />
        <br />
        <asp:Button ID="editproducts" runat="server" Height="31px" OnClick="vendoreditProducts" Text="Edit_products" Width="113px" />
        <br />
        <asp:Label ID="Label10" runat="server" Text="please enter these information"></asp:Label>
&nbsp;:<br />
        <asp:Label ID="Label4" runat="server" Text="Product_serial_number"></asp:Label>
        <asp:TextBox ID="text_box_serialno" runat="server" style="margin-left: 30px"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Product_name"></asp:Label>
        <asp:TextBox ID="txtbox_product_name" runat="server" style="margin-left: 80px"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Category"></asp:Label>
        <asp:TextBox ID="txtbox_category" runat="server" style="margin-left: 112px"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Product description"></asp:Label>
        <asp:TextBox ID="txtbox_product_description" runat="server" style="margin-left: 49px"></asp:TextBox>
        <br />
        <asp:Label ID="Label8" runat="server" Text="Price"></asp:Label>
        <asp:TextBox ID="txtbox_price" runat="server" style="margin-left: 137px"></asp:TextBox>
        <br />
        <asp:Label ID="Label9" runat="server" Text="Color"></asp:Label>
        <asp:TextBox ID="txtbox_color" runat="server" style="margin-left: 133px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="createoffers" runat="server" Height="32px" OnClick="createoffersproc" Text="Create_offers" Width="115px" />
        <br />
        <asp:Label ID="Label11" runat="server" Text="please enter these information"></asp:Label>
        :<br />
        <asp:Label ID="Label12" runat="server" Text="Offer amount"></asp:Label>
        <asp:TextBox ID="txt_box_offerramount" runat="server" style="margin-left: 83px"></asp:TextBox>
        <br />
        <asp:Label ID="Label13" runat="server" Text="Expiry date"></asp:Label>
        <asp:TextBox ID="txt_box_expirydate" runat="server" style="margin-left: 94px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="applyoffer" Text="Apply offer" />
        <br />
        <asp:Label ID="Label14" runat="server" Text="please enter these information"></asp:Label>
        :<br />
        <asp:Label ID="Label15" runat="server" Text="Offer id"></asp:Label>
        <asp:TextBox ID="txt_offerid" runat="server" style="margin-left: 113px"></asp:TextBox>
        <br />
        <asp:Label ID="Label16" runat="server" Text="Product serial no."></asp:Label>
        <asp:TextBox ID="txt_box_pserial" runat="server" style="margin-left: 53px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Height="29px" OnClick="checkandremoveexpireoffer" Text="Check and remove expired offer" Width="204px" />
        <br />
        <asp:Label ID="Label17" runat="server" Text="please enter these information"></asp:Label>
        :<br />
        <asp:Label ID="Label18" runat="server" Text="Offer id"></asp:Label>
        <asp:TextBox ID="text_offer_id" runat="server" style="margin-left: 61px"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="add mobile number" />
        <br />
    </form>
</body>
</html>
