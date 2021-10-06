<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            text-align: center;
            font-size: xx-large;
        }
    </style>
</head>
<body style="text-align: left">
    <form id="form1" runat="server">
        <div style="text-align: center; font-size: xx-large">
            フォトアルバム<br />
            IS１３－１<br />
            K019C1068　石井恭輔</div>
        <asp:GridView align="center" ID="GridView1" runat="server" AutoGenerateColumns="False" EnableModelValidation="True" Height="145px" Width="608px" DataKeyNames="日時" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" />
                <asp:BoundField DataField="日時" HeaderText="日時" HtmlEncode="False" ReadOnly="True" SortExpression="日時" />
                <asp:ImageField DataImageUrlField="写真" HeaderText="写真">
                    <ControlStyle Height="150px" Width="150px" />
                </asp:ImageField>
                <asp:BoundField DataField="コメント" HeaderText="コメント" SortExpression="コメント" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AlbumDBConnectionString %>" DeleteCommand="DELETE FROM [Album] WHERE [日時] = @日時" InsertCommand="INSERT INTO [Album] ([日時], [写真], [コメント]) VALUES (@日時, @写真, @コメント)" SelectCommand="SELECT * FROM [Album]" UpdateCommand="UPDATE [Album] SET [写真] = @写真, [コメント] = @コメント WHERE [日時] = @日時">
            <DeleteParameters>
                <asp:Parameter Name="日時" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="日時" Type="String" />
                <asp:Parameter Name="写真" Type="String" />
                <asp:Parameter Name="コメント" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="写真" Type="String" />
                <asp:Parameter Name="コメント" Type="String" />
                <asp:Parameter Name="日時" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <br />
        コメント<asp:TextBox ID="TextBox1" runat="server" Font-Size="X-Large"></asp:TextBox>
        <br />
        <br />
        システムメッセージ<br />
        <asp:TextBox ID="TextBox2" runat="server" Height="60px" TextMode="MultiLine" Width="339px"></asp:TextBox>
        <br />
        <br />
        パスワード<asp:TextBox ID="TextBox3" runat="server" Font-Size="X-Large" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Font-Size="X-Large" OnClick="Button1_Click1" Text="登録" />
    </form>
</body>
</html>
