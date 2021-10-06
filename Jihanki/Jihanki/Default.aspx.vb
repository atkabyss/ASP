
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'クリアボタン
        TextBox1.Text = 0
        TextBox2.Text = 0
        TextBox3.Text = 0
        TextBox4.Text = 0

        Label1.Text = 0
        Label2.Text = 0
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        '購入ボタン

        '合計金額
        Label1.Text = TextBox1.Text * 500 _
                    + TextBox2.Text * 300 _
                    + TextBox3.Text * 150 _


        'おつり
        Label2.Text = TextBox4.Text - Label1.Text

    End Sub
End Class
