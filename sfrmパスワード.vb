Public Class sfrmパスワード
    Private pro遷移フォーム As Form
    Property 遷移フォーム As Form
        Get
            Return pro遷移フォーム
        End Get
        Set(value As Form)
            pro遷移フォーム = value
        End Set
    End Property

    Private proパスワード As String
    Property パスワード As String
        Get
            Return proパスワード
        End Get
        Set(value As String)
            proパスワード = value
        End Set
    End Property

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click

        txtパスワード.Text += sender.text
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txtパスワード.Text = ""
    End Sub

    Private Sub btn終了_Click(sender As Object, e As EventArgs) Handles btn終了.Click
        遷移フォーム = Nothing
        Call Me.Close()
        Call frm201トップ.Show()

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        If proパスワード = StrConv(txtパスワード.Text, VbStrConv.Narrow) Then
            pro遷移フォーム.Show()
            Call Me.Close()
        Else
            MessageBox.Show("パスワード認証に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub sfrmパスワード_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class