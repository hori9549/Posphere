
''20200228漆谷　集計ボタンの挙動を追加-------------------------------
''20200229漆谷　集計結果出力処理を別フォームとして切り分け-------------------------------
''20200307漆谷　データベースの更新に伴い検索結果のSELECT文にJOINを追加-------------------------------
''              SELECT文に検索条件を指定した際にWHERE句を追加-------------------------------

Imports System.Data
Imports System.Data.SqlClient

Public Class frm502売上点検_部門別集計

    Public frmBefor As Form

    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Private Sub frm501売上点検_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn集計_Click(sender As Object, e As EventArgs) Handles btn集計.Click
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        grp検索項目.DataSource = Nothing

        'データベースから取得したいデータ群をSQLで検索
        msSQL = "SELECT master.部門名, cun_peoples.取引回数, num_peoples.取引人数, counter.数量, money.金額 ,discount.値引・割引 ,tra_amount.取引金額"
        msSQL += " From M部門 As master"
        msSQL += " INNER Join(select 部門CD, SUM(人数) As 取引回数  from Dレジ取引_未精算 where 明細区分 = '100' and 機能CD = '0' and 数量 <> 0 group by 部門CD)"
        msSQL += " AS cun_peoples ON master.部門CD = cun_peoples.部門CD"
        ''部門別集計結果に空白列「取引人数」を出力するカラうちSQL
        msSQL += " INNER Join(select 部門CD, Left(部門CD, 0) As 取引人数 from Dレジ取引_未精算 where 明細区分 = '100' and 機能CD = '0' and 数量 <> 0 group by 部門CD)"
        msSQL += " AS num_peoples ON master.部門CD = num_peoples.部門CD"
        msSQL += " INNER Join(select 部門CD, SUM(数量) As 数量 from Dレジ取引_未精算 where 明細区分 = '100' and 機能CD = '0' and 数量 <> 0 group by 部門CD)"
        msSQL += " AS counter ON master.部門CD = counter.部門CD"
        msSQL += " INNER Join(select 部門CD, FORMAT( SUM(数量 * 単価), '#,###') As 金額 from Dレジ取引_未精算 where 明細区分 = '100' and 機能CD = '0' and 数量 <> 0 group by 部門CD)"
        msSQL += " AS money ON master.部門CD = money.部門CD"
        msSQL += " INNER Join(select 部門CD, FORMAT( sum(バンドル値引金額) + sum(単品値引金額) + sum(明細値引金額) + sum(小計値引金額) + sum(クーポン値引金額), '#,###') As 値引・割引 from Dレジ取引_未精算 group by 部門CD )"
        msSQL += " AS discount ON master.部門CD = discount.部門CD"
        msSQL += " INNER Join(select 部門CD, FORMAT( sum(金額), '#,###') As 取引金額 from Dレジ取引_未精算 group by 部門CD)"
        msSQL += " AS tra_amount ON master.部門CD = tra_amount.部門CD"

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