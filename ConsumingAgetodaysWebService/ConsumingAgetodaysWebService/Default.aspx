<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ConsumingAgetodaysWebService.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> Test the cousuming of my webservice !!</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="textbox1" runat ="server"></asp:TextBox>
        <br/>
        <asp:TextBox ID="textbox2" runat ="server"></asp:TextBox>
        <br/>
        <asp:TextBox ID="textbox3" runat ="server"></asp:TextBox>
        <br/>
        <asp:Button ID="button1" runat="server" Text="Calculate" />
        <br/>
        <asp:Label ID="label1" runat="server" Text="Label"></asp:Label>       
    </form>
</body>
</html>
