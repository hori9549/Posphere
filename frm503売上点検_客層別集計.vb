
''20200228漆谷　集計ボタンの挙動を追加-------------------------------
''20200229漆谷　集計結果出力処理を別フォームとして切り分け-------------------------------
''20200307漆谷　データベースの更新に伴い検索結果のSELECT文にJOINを追加-------------------------------
''              SELECT文に検索条件を指定した際にWHERE句を追加-------------------------------

Imports System.Data
Imports System.Data.SqlClient

Public Class frm503売上点検_客層別集計

    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Private Sub frm502売上点検_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn集計_Click(sender As Object, e As EventArgs) Handles btn集計.Click
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        grp検索項目.DataSource = Nothing

        'データベースから取得したいデータ群をSQLで検索
        msSQL = "SELECT CASE"
        msSQL += " when 客層CD = '2' then '男20代'"
        msSQL += " when 客層CD = '3' then '男30代'"
        msSQL += " when 客層CD = '4' then '男40代'"
        msSQL += " when 客層CD = '5' then '男50以上'"
        msSQL += " when 客層CD = '7' then '女20代'"
        msSQL += " when 客層CD = '8' then '女30代'"
        msSQL += " when 客層CD = '9' then '女40代'"
        msSQL += " when 客層CD = '10' then '女50以上'"
        msSQL += " when 客層CD = '11' then '券売機'"
        msSQL += " Else 'その他' END 客層名,"
        msSQL += " COUNT(*) As 取引回数,"
        msSQL += " SUM(人数) As 人数,"
        msSQL += " SUM(数量) As 数量,"
        msSQL += " Format(SUM(数量 * 単価), '#,###') As 金額,"
        msSQL += " Format(sum(バンドル値引金額) + sum(単品値引金額) + sum(明細値引金額) + sum(小計値引金額) + sum(クーポン値引金額), '#,###') As 値引・割引,"
        msSQL += " Format(sum(金額), '#,###') As 取引金額"
        msSQL += " From Dレジ取引_未精算"
        msSQL += " Where 表示名 = '合 計'"
        msSQL += " Group By 客層CD"
        msSQL += " Order By 客層CD"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成

        grp検索項目.DataSource = myTable

        Call cDB.Close()

        '印刷ボタンをアクティブに変更
        btn印刷.Enabled = True

    End Sub

    Private Sub btn印刷_Click(sender As Object, e As EventArgs) Handles btn印刷.Click

        '印刷機能を追加

    End Sub

    Private Sub btn終了_Click(sender As Object, e As EventArgs) Handles btn終了.Click

        Call Me.Close()

    End Sub

End Class