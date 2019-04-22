<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormFindNote.aspx.cs" Inherits="Pattern.WebFormFindNote" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Найти заметку
        </div>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Height="20px" Width="138px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 11px" Text="Найти" />
        </p>
        <p>
            Заметка: </p>
        <asp:TextBox ID="TextBox2" runat="server" Height="115px" Width="139px"></asp:TextBox>
    </form>
</body>
</html>
