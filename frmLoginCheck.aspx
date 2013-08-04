<%@ Page Language="VB" AutoEventWireup="false" CodeFile="frmLoginCheck.aspx.vb" Inherits="frmLoginCheck" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
        <asp:Label ID="lblStatus" runat="server" Height="100px" Text="Label" Width="500px"></asp:Label>
        <br />
        <asp:Button ID="btnTryAgain" runat="server" PostBackUrl="~/frmLogin.aspx" Text="Try Again" /></div>
    </form>
</body>
</html>
