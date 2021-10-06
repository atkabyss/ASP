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
            課題０４　自動販売機<br />
            IS１３－１　K019C1068<br />
            石井　恭輔<br />
            <asp:Image ID="Image1" runat="server" Height="100px" ImageUrl="アイス.png" Width="100px" />
            　<asp:Image ID="Image2" runat="server" Height="100px" ImageUrl="クラッカー.png" Width="100px" />
            　<asp:Image ID="Image3" runat="server" Height="100px" ImageUrl="ジュース.png" Width="100px" />
            <br />
            ５００円　３００円　１５０円<br />
            <asp:TextBox ID="TextBox1" runat="server" Height="20px" style="text-align: right" Width="60px"></asp:TextBox>
            個　<asp:TextBox ID="TextBox2" runat="server" Height="20px" style="text-align: right" Width="60px"></asp:TextBox>
            個　<asp:TextBox ID="TextBox3" runat="server" Height="20px" style="text-align: right" Width="60px"></asp:TextBox>
            個<br />
            <br />
            投入金額：　<asp:TextBox ID="TextBox4" runat="server" Height="20px" style="text-align: right" Width="80px"></asp:TextBox>
            円<br />
            合計金額：　<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            円<br />
            おつり：　<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            円<br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="30px" Text="購入" Width="100px" />
            　<asp:Button ID="Button2" runat="server" Height="30px" Text="クリア" Width="100px" />
        </div>
    </form>
</body>
</html>
