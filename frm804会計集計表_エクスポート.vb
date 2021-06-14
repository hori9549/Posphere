Imports System.Data
Imports System.Data.SqlClient
Public Class frm804会計集計表_エクスポート
    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Public tgtTableName As String
    Private Sub frm804会計集計表_エクスポート_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable


        'データベースから取得したいデータ群をSQLで検索
        'フィールド（列）の一覧取得
        msSQL = "SELECT name "
        msSQL += "FROM sys.columns "
        msSQL += "WHERE object_id = (SELECT object_id "
        msSQL += "            From sys.tables "
        msSQL += "            Where Name = '" + tgtTableName + "'"
        msSQL += "            )"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(myTable) ''データセット作成

        dgv出力可能.DataSource = myTable

        '列ヘッダ・行ヘッダを非表示する
        dgv出力可能.ColumnHeadersVisible = False
        dgv出力可能.RowHeadersVisible = False

        Call cDB.Close()
    End Sub

    Private Sub btnキャンセル_Click(sender As Object, e As EventArgs) Handles btnキャンセル.Click
        Me.Close()
    End Sub
End Class