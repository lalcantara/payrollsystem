<%@ Page Language="VB" AutoEventWireup="false" CodeFile="frmPersonnel.aspx.vb" Inherits="frmPersonnel" %>

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
                face="Comic Sans MS" size="4"> <font color="#993366">Productions</font>, Inc.<asp:Panel
                    ID="Panel1" runat="server" Height="300px" HorizontalAlign="Left" Width="250px">
                    <asp:Label ID="Label1" runat="server" Font-Bold="False" Font-Names="Times New Roman"
                        Font-Size="12pt" Text="First Name:" Width="85px"></asp:Label>
                    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox><br />
                    <asp:Label ID="Label2" runat="server" Font-Bold="False" Font-Names="Times New Roman"
                        Font-Size="12pt" Text="Last Name:" Width="85px"></asp:Label>
                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox><br />
                    <asp:Label ID="Label3" runat="server" Font-Bold="False" Font-Names="Times New Roman"
                        Font-Size="12pt" Text="Pay Rate:" Width="85px"></asp:Label>
                    <asp:TextBox ID="txtPayRate" runat="server"></asp:TextBox><br />
                    <asp:Label ID="Label4" runat="server" Font-Bold="False" Font-Names="Times New Roman"
                        Font-Size="12pt" Text="Start Date:" Width="85px"></asp:Label>
                    <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox><br />
                    <asp:Label ID="Label5" runat="server" Font-Bold="False" Font-Names="Times New Roman"
                        Font-Size="12pt" Text="End Date:" Width="85px"></asp:Label>
                    <asp:TextBox ID="txtEndDate" runat="server"></asp:TextBox><br />
                    <br />
                    <!Submit button will post information to ~/frmPersonalVerfied.aspx><asp:Button ID="btnSubmit" runat="server" PostBackUrl="~/frmPersonalVerfied.aspx"
                        Text="Submit" />
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
                    <asp:Button ID="btnViewActivity" runat="server" PostBackUrl="~/frmUserActivity.aspx"
                        Text="View Activity" />
                    <asp:Button ID="btnViewPersonnel" runat="server" PostBackUrl="~/frmViewPersonnel.aspx"
                        Text="View Personnel" /></asp:Panel>
            </font></strong>
    
    </div>
    </form>
</body>
</html>
