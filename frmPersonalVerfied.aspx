<%@ Page Language="VB" AutoEventWireup="false" CodeFile="frmPersonalVerfied.aspx.vb" Inherits="frmPersonalVerfied" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Information to submit:"></asp:Label>
        <br />
        <!Text Box where inputed information on frmPersonnel.aspx will post when btnSubmit is activated><asp:TextBox ID="txtVerifiedInfo" runat="server" Height="80px" TextMode="MultiLine"
            Width="400px"></asp:TextBox><br />
        <asp:Button ID="btnViewPersonnel" runat="server" PostBackUrl="~/frmViewPersonnel.aspx"
            Text="View Personnel" /></div>
    </form>
</body>
</html>
