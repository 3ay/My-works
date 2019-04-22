<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormOutputAll.aspx.cs" Inherits="Pattern.WebFormOutputAll" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong>Все заметки<asp:Button ID="Button1" runat="server" Height="22px" OnClick="Button1_Click" style="margin-left: 31px" Text="Вывести" Width="55px" />
            </strong></div>
        <p>
            <asp:TextBox ID="Output" runat="server" Height="164px" OnTextChanged="Page_Load" Width="185px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
