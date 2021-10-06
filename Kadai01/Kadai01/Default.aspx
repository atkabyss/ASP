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
            課題０１　消費税の計算<br />
            IS13-1<br />
            K019C1068　石井恭輔<br />
            <br />
            購入金額：<asp:TextBox ID="TextBox1" runat="server" Font-Size="X-Large" Width="125px"></asp:TextBox>
            円<br />
            <br />
            税込価格：<asp:TextBox ID="TextBox2" runat="server" Font-Size="X-Large" Width="125px"></asp:TextBox>
            円<br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="35px" Text="計算" Width="90px" />
            　<asp:Button ID="Button2" runat="server" Height="35px" Text="クリア" Width="90px" />
        </div>
    </form>
</body>
</html>
