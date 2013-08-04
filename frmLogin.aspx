<%@ Page Language="VB" AutoEventWireup="false" CodeFile="frmLogin.aspx.vb" Inherits="frmLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
        <strong><span style="font-family: Comic Sans MS"><span style="font-size: 13pt; color: #0000ff">
            Cool</span><font color="#ff6600" face="Comic Sans MS" size="4">Biz</font></span><font
                face="Comic Sans MS" size="4"> <font color="#993366">Productions</font>, Inc.</font></strong><br />
        <br />
        Please enter your UserName and
        <br />
        Password in order to log into the system.<br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="User Name:" Width="100px"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" Width="100px"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="Password:" Width="100px"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" Width="100px"></asp:TextBox><br />
        <asp:Button ID="btnLogin" runat="server" Text="Login" Width="100px" PostBackUrl="~/frmLoginCheck.aspx" /></div>
    </form>
</body>
</html>
