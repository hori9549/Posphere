
''20200228漆谷　集計ボタンの挙動を追加-------------------------------

Imports System.Data
Imports System.Data.SqlClient

Public Class frm505売上点検_現金外集計

    Public frmBefor As Form

    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    ''集計種別選択用-------------------------------
    Private flgSQLselect As String
    Private colBacCol As Color

    Private Sub frm504売上点検_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn集計_Click(sender As Object, e As EventArgs) Handles btn集計.Click

        grp検索項目.DataSource = Nothing
        Call 検索結果表示("(select TOP(1) 取引分類名 from M取引分類 where 取引分類CD = Dレジ取引_未精算.取引分類CD) as 取引分類, 表示名 as 取引名, count(*)As 取引件数, FORMAT(sum(金額), '#,###') As 取引金額", "Dレジ取引_未精算", "明細区分 = '750' group by Dレジ取引_未精算.取引分類CD, 表示名")

        '印刷ボタンをアクティブに変更
        btn印刷.Enabled = True

    End Sub

    Private Sub btn印刷_Click(sender As Object, e As EventArgs) Handles btn印刷.Click

    End Sub

    Private Sub btn終了_Click(sender As Object, e As EventArgs) Handles btn終了.Click

        Call Me.Close()

    End Sub

    Private Sub 検索結果表示(項目名 As String, テーブル名 As String, 条件文 As String)

        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        Dim strSelectTable As String

        'データベースから取得したいデータ群をSQLで検索
        msSQL = "SELECT " + 項目名
        msSQL += " FROM "
        msSQL += テーブル名
        msSQL += " WHERE "
        msSQL += 条件文

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成

        grp検索項目.DataSource = myTable

        Call cDB.Close()

    End Sub


End Class