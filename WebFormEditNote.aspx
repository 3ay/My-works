<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormEditNote.aspx.cs" Inherits="Pattern.WebFormEditNote" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 362px;
            width: 617px;
        }
    </style>
</head>
<body style="width: 646px; height: 443px">
    <form id="form1" runat="server">
        <div style="height: 25px">
            <strong>Редактировать заметку</strong><br />
        </div>
      
        <asp:TextBox ID="Find_note_field" runat="server" OnTextChanged="Page_Load" Width="147px" Height="23px"></asp:TextBox>
        <asp:Button ID="FindNote_button" runat="server" OnClick="Find_Note_Click" OnDataBinding="Page_Load" style="margin-left: 27px" Text="Найти заметку" Width="165px" />        
        <br />
        <br />
        Найдена заметка<br />
        <br />
        <asp:TextBox ID="Name_note_field" runat="server" OnTextChanged="Page_Load" Width="148px" Height="16px" style="margin-left: 0px; margin-top: 0px; margin-bottom: 0px"></asp:TextBox>        
        <br />
        <asp:TextBox ID="Description_note_field" runat="server" Height="148px" OnTextChanged="Page_Load" Width="149px" style="margin-left: 0px; margin-top: 20px"></asp:TextBox>
        <asp:Button ID="Edit_note_button" runat="server" style="margin-left: 27px" Text="Редактировать заметку" Width="164px" OnClick="Edit_note_button_Click" />
        
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 183px" Text="В главное меню" Width="164px" />
        
    </form>
</body>
</html>
