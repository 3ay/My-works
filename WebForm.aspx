<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="Pattern.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 295px">
    <form id="form1" runat="server">
        <div style="width: 223px">
            Управление заметками</div>
        <p>
            <asp:Button ID="Button1" runat="server" Height="37px" OnClick="Button1_Click" Text="Добавить заметку" Width="186px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </p>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Редактировать заметку" Width="183px" />
        <br />
        <asp:Button ID="Button3" runat="server" style="margin-left: 1px; margin-top: 22px" Text="Вывести все заметки" Width="180px" OnClick="Button3_Click" />
        <br />
        <br />
        <asp:Button ID="Delete_note" runat="server" OnClick="Delete_note_Click" Text="Удалить заметку" Width="180px" />
        <br />
        <br />
        <asp:Button ID="Finf_note" runat="server" OnClick="Finf_note_Click" style="margin-left: 2px" Text="Найти заметку" Width="176px" />
    </form>
</body>
</html>
