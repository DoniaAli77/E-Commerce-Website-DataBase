
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication3.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 23px; width: 772px; margin-left: 4px">
    <form id="form1" runat="server">
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="reg" runat="server" Text="Registration"></asp:Label>
        </p>
        <p>
            <asp:Label ID="reg_first_name" runat="server" Text="First name"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="text_box_first_name" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label7" runat="server" Text="Last name"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="textbox_last_name" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="reg_username" runat="server" Text="Username"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="textbox_username" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
        </p>
        <asp:TextBox ID="textbox_password" runat="server" ></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="reg_email" runat="server" Text="Email"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="textbox_email" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label8" runat="server" Text="Bank account number"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="textbox_Bank_account_num" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label9" runat="server" Text="Company name"></asp:Label>
        <br />
        <asp:TextBox ID="textbox_Companyname" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="registervendor" runat="server" OnClick="registerationvendor" Text="registervendor" />
        <asp:Button ID="registercustomer" runat="server" OnClick="registerationcustomer" Text="registercustomer" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="I already have an account" />
    </form>
</body>
</html>