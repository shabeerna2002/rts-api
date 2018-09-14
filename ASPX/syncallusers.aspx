<%@ Page Language="VB" AutoEventWireup="false" CodeFile="syncallusers.aspx.vb" Inherits="syncallusers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: small;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Height="49px" Text="Sync" Width="167px" />
            <br />
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server" CssClass="auto-style1">
        </asp:GridView>
        <br />
        <br />
        <br />
    </form>
</body>
</html>
