Public Class sfrmPOSメニュー


    Private Sub sfrmPOSメニュー_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btn終了_Click(sender As Object, e As EventArgs)
        frm400POS.登録ステータス = "終了"
        Call frm400POS.Close()
    End Sub

    Private Sub rdo_CheckedChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub btn閉じる_Click(sender As Object, e As EventArgs) Handles btn閉じる.Click
        Call Me.Close()
    End Sub
End Class