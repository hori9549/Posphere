Public Class frm301バージョン情報
    Private Sub frmバージョン情報_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub btnSysInfo_Click(sender As Object, e As EventArgs) Handles btnSysInfo.Click
        'コマンドライン引数に「"C:\test\1.txt"」を指定してメモ帳を起動する
        System.Diagnostics.Process.Start("msinfo32.exe")
    End Sub
End Class