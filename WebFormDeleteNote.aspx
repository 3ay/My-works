<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormDeleteNote.aspx.cs" Inherits="Pattern.WebFormDeleteNote" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Удаление элемента</div>
        <asp:TextBox ID="TextBox1" runat="server" Width="118px"></asp:TextBox>
&nbsp;введите заметку<br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Удалить" />
    </form>
</body>
</html>
