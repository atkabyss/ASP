<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center; font-size: xx-large">
            課題０５　うるう年の判定<br />
            IS13-1 K019C1068<br />
            石井　恭輔<br />
            <br />
            <asp:Image ID="Image1" runat="server" Height="100px" ImageUrl="令和.png" Width="100px" />
            <br />
            西暦<asp:TextBox ID="TextBox1" runat="server" Height="20px" style="margin-top: 0px" Width="70px"></asp:TextBox>
            年<br />
            判定結果：<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="30px" Text="計算" Width="70px" />
            　<asp:Button ID="Button2" runat="server" Height="30px" Text="クリア" Width="70px" />
        </div>
    </form>
</body>
</html>
