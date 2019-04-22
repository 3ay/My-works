<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormAddNote.aspx.cs" Inherits="Pattern.WebFormAddNote" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 500px;
            width: 549px;
            margin-left: 369px;
        }
        #output_value {
            height: 433px;
        }
    </style>
</head>
<body style="height: 503px">
    <form id="output_value" runat="server">
        <div style="text-align: center; width: 521px;">
            <strong>Введите название заметки и описание</strong><br />
        </div>
        <asp:TextBox ID="Note_name" runat="server" style="text-align: center; margin-left: 139px; margin-top: 14px;" Width="247px"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="Note_description" runat="server" Height="254px" style="text-align: center; margin-left: 141px;" Width="244px"></asp:TextBox>
        <br />
        <asp:Button ID="Add_note" runat="server" Height="30px" style="margin-left: 144px; margin-top: 23px" Text="Добавить заметку" Width="122px" OnClick="Add_note_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Status" runat="server" Text="Status"></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 145px; margin-top: 12px" Text="В главное меню" Width="117px" />
    </form>
</body>
</html>
