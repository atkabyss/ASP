
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = 0

        Label1.Text = ""
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iYear = TextBox1.Text

        If (iYear Mod 400 = 0) Then
            Label1.Text = "うるう年です"
            '// 100で割り切れる場合は通常年
        ElseIf (iYear Mod 100 = 0) Then
            Label1.Text = "うるう年です"
            '// 4で割り切れる場合はうるう年
        ElseIf (iYear Mod 4 = 0) Then
            Label1.Text = "うるう年です"
            '// 上記条件に一致しない場合は通常年
        Else
            Label1.Text = "うるう年ではありません"
        End If
    End Sub
End Class
