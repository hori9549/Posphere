Public Class sfrmPOS処理
    Private pro登録ステータス As String = "登録"
    Public Property 登録ステータス() As String
        Get
            Return pro登録ステータス
        End Get
        Set(value As String)
            pro登録ステータス = value
        End Set

    End Property

    Private Sub sfrmPOSメニュー_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn終了_Click(sender As Object, e As EventArgs) Handles btn終了.Click
        frm400POS.登録ステータス = "終了"
        Call frm400POS.Close()
    End Sub

    Private Sub rdo_Click(sender As Object, e As EventArgs) Handles rdo登録.Click, rdo訂正.Click, rdo点検.Click, rdo練習.Click

        If rdo登録.Checked Then 登録ステータス = "登録"
        If rdo訂正.Checked Then 登録ステータス = "訂正"
        If rdo点検.Checked Then 登録ステータス = "点検"
        If rdo練習.Checked Then 登録ステータス = "練習"

        frm400POS.登録ステータス = 登録ステータス
        Call Me.Close()

    End Sub

    Private Sub rdo登録_CheckedChanged(sender As Object, e As EventArgs) Handles rdo登録.CheckedChanged

    End Sub

    Private Sub rdo訂正_CheckedChanged(sender As Object, e As EventArgs) Handles rdo訂正.CheckedChanged

    End Sub

    Private Sub rdo練習_CheckedChanged(sender As Object, e As EventArgs) Handles rdo練習.CheckedChanged

    End Sub

    Private Sub rdo点検_CheckedChanged(sender As Object, e As EventArgs) Handles rdo点検.CheckedChanged
        Dim sfrm As New frm500売上点検
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn精算_Click(sender As Object, e As EventArgs) Handles btn精算.Click
        Dim sfrm As New frm600精算処理
        Call sfrm.ShowDialog()
    End Sub

    Private Sub rdo管理_CheckedChanged(sender As Object, e As EventArgs) Handles rdo管理.CheckedChanged
        Dim sfrm As New Frm700管理画面
        Call sfrm.ShowDialog()
    End Sub
End Class