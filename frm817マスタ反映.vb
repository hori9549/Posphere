Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class frm817マスタ反映

    Private ini As clsINI = New clsINI("設定.ini")

    'データベース接続用
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Public cmb_M単品スケジュール_SelectedIndex As Integer

    Private Sub frmマスタ反映_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt最上部.Text = "外部CSVより各マスタを取り込みます。"
        txt1.Text = ini.GetProfileString("FTP", "受信POSフォルダ", "")
        txt更新日時.Text = "最終更新日時" + "：" + Now
        chb1.CheckState = CheckState.Checked

        Dim di As New System.IO.DirectoryInfo(txt1.Text)
        Dim files As System.IO.FileInfo() =
            di.GetFiles("12PC.csv", System.IO.SearchOption.AllDirectories)

        'ListView1に結果を表示する
        For Each f As System.IO.FileInfo In files
            ListView1.Items.Add(f.Name)
        Next

    End Sub

End Class