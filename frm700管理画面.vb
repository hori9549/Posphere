'20191119_わかさあやこ
Public Class Frm700管理画面
    Private Sub btn1取引集計表_Click(sender As Object, e As EventArgs) Handles btn1取引集計表.Click
        Dim sfrm As New frm801取引集計表
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn2ジャーナル照会_Click(sender As Object, e As EventArgs) Handles btn2ジャーナル照会.Click
        Dim sfrm As New frm802ジャーナル照会
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn3電子ジャーナル照会_Click(sender As Object, e As EventArgs) Handles btn3電子ジャーナル照会.Click
        Dim sfrm As New frm803電子ジャーナル照会
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn4会計集計表_Click(sender As Object, e As EventArgs) Handles btn4会計集計表.Click
        'Dim sfrm As New frm80
        'Call sfrm.ShowDialog()
    End Sub

    Private Sub btn5店舗情報登録_Click(sender As Object, e As EventArgs) Handles btn5店舗情報登録.Click
        Dim sfrm As New frm805店舗情報登録
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn6端末情報登録_Click(sender As Object, e As EventArgs) Handles btn6端末情報登録.Click
        Dim sfrm As New frm806端末情報登録
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn7店舗情報登録店舗メンテ_Click(sender As Object, e As EventArgs) Handles btn7店舗情報登録店舗メンテ.Click
        Dim sfrm As New frm807店舗情報登録店舗メンテ
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn8設定情報印刷_Click(sender As Object, e As EventArgs) Handles btn8設定情報印刷.Click
    End Sub

    Private Sub btn9データーベース参照_Click(sender As Object, e As EventArgs) Handles btn9データーベース参照.Click
        Dim sfrm As New frm809データベース参照
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn17マスタ反映_Click(sender As Object, e As EventArgs) Handles btn17マスタ反映.Click
        Dim sfrm As New frm817マスタ反映
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn18バックアップ_Click(sender As Object, e As EventArgs) Handles btn18バックアップ.Click

    End Sub

    Private Sub btn19日付時刻変更_Click(sender As Object, e As EventArgs) Handles btn19日付時刻変更.Click
        Dim sfrm As New frm819日付時刻変更
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn20DB最適化_Click(sender As Object, e As EventArgs) Handles btn20DB最適化.Click

    End Sub

    Private Sub btn21DBユーティリティー_Click(sender As Object, e As EventArgs) Handles btn21DBユーティリティー.Click

    End Sub

    Private Sub btn24終了_Click(sender As Object, e As EventArgs) Handles btn24終了.Click
        Me.Close()
    End Sub
End Class