
''20200228漆谷　集計ボタンの挙動を追加-------------------------------

Imports System.Data
Imports System.Data.SqlClient

Public Class frm500売上点検

    ''集計種別選択用-------------------------------
    Private colBacCol As Color

    Private Sub frm500売上点検_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn終了_Click(sender As Object, e As EventArgs)

        Call Me.Close()

    End Sub


    Private Sub ボタン色の変更(btnGet As Windows.Forms.Button)

        btn品目別集計.BackColor = SystemColors.Control
        btn品目別集計.UseVisualStyleBackColor = True
        btn部門別集計.BackColor = SystemColors.Control
        btn部門別集計.UseVisualStyleBackColor = True
        btn客層別集計.BackColor = SystemColors.Control
        btn客層別集計.UseVisualStyleBackColor = True
        btn分類別集計.BackColor = SystemColors.Control
        btn分類別集計.UseVisualStyleBackColor = True
        btn現金外集計.BackColor = SystemColors.Control
        btn現金外集計.UseVisualStyleBackColor = True
        btn時間帯別集計.BackColor = SystemColors.Control
        btn時間帯別集計.UseVisualStyleBackColor = True
        btn会計集計.BackColor = SystemColors.Control
        btn会計集計.UseVisualStyleBackColor = True
        btnジャーナル.BackColor = SystemColors.Control
        btnジャーナル.UseVisualStyleBackColor = True
        btnオーダーエントリー.BackColor = SystemColors.Control
        btnオーダーエントリー.UseVisualStyleBackColor = True
        btn電子ジャーナル.BackColor = SystemColors.Control
        btn電子ジャーナル.UseVisualStyleBackColor = True

        btnGet.BackColor = colBacCol

    End Sub

    Private Sub btn品目別集計_Click(sender As Object, e As EventArgs) Handles btn品目別集計.Click

        Dim sfrm As New frm501売上点検_品目別集計
        Call sfrm.ShowDialog()

    End Sub

    Private Sub btn部門別集計_Click(sender As Object, e As EventArgs) Handles btn部門別集計.Click

        Dim sfrm As New frm502売上点検_部門別集計
        Call sfrm.ShowDialog()

    End Sub

    Private Sub btn客層別集計_Click(sender As Object, e As EventArgs) Handles btn客層別集計.Click

        Dim sfrm As New frm503売上点検_客層別集計
        Call sfrm.ShowDialog()

    End Sub

    Private Sub btn分類別集計_Click(sender As Object, e As EventArgs) Handles btn分類別集計.Click

        Dim sfrm As New frm504売上点検_分類別集計
        Call sfrm.ShowDialog()

    End Sub

    Private Sub btn現金外集計_Click(sender As Object, e As EventArgs) Handles btn現金外集計.Click

        Dim sfrm As New frm505売上点検_現金外集計
        Call sfrm.ShowDialog()

    End Sub

    Private Sub btn時間帯別集計_Click(sender As Object, e As EventArgs) Handles btn時間帯別集計.Click

        Dim sfrm As New frm506売上点検_時間帯別集計
        Call sfrm.ShowDialog()

    End Sub

    Private Sub btn会計集計_Click(sender As Object, e As EventArgs) Handles btn会計集計.Click

        Dim sfrm As New frm507売上点検_会計集計
        Call sfrm.ShowDialog()

    End Sub

    Private Sub btnジャーナル_Click(sender As Object, e As EventArgs) Handles btnジャーナル.Click

        Dim sfrm As New frm508売上点検_ジャーナル
        Call sfrm.ShowDialog()

    End Sub

    Private Sub btnオーダーエントリー_Click(sender As Object, e As EventArgs) Handles btnオーダーエントリー.Click

    End Sub

    Private Sub btn電子ジャーナル_Click(sender As Object, e As EventArgs) Handles btn電子ジャーナル.Click

        Dim sfrm As New frm510売上点検_電子ジャーナル
        Call sfrm.ShowDialog()

    End Sub

    Private Sub btn終了_Click_1(sender As Object, e As EventArgs) Handles btn終了.Click

        Call Me.Close()

    End Sub
End Class