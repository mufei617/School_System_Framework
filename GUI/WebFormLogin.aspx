<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormLogin.aspx.cs" Inherits="ReviewForMidterm.GUI.WebFormLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            username:</div>
        <asp:TextBox ID="TextBoxusername" runat="server"></asp:TextBox>
        <br />
        Password:<br />
        <asp:TextBox ID="TextBoxpassword" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="ButtonLogin" runat="server" OnClick="ButtonLogin_Click" Text="go" />
        <asp:Label ID="Labelshow" runat="server"></asp:Label>
    </form>
</body>
</html>
