
''20200228漆谷　集計ボタンの挙動を追加-------------------------------

Imports System.Data
Imports System.Data.SqlClient

Public Class frm504売上点検_分類別集計

    Public frmBefor As Form

    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    ''集計種別選択用-------------------------------
    Private flgSQLselect As String
    Private colBacCol As Color

    Private Sub frm503売上点検_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn集計_Click(sender As Object, e As EventArgs) Handles btn集計.Click
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        grp検索項目.DataSource = Nothing

        'データベースから取得したいデータ群をSQLで検索
        msSQL = "SELECT master.分類名, cun_peoples.取引回数, num_peoples.取引人数, counter.数量, money.金額 ,discount.値引・割引 ,tra_amount.取引金額"
        msSQL += " From M分類 As master"
        msSQL += " INNER Join(select 分類CD, SUM(人数) As 取引回数  from Dレジ取引_未精算 where 明細区分 = '100' and 機能CD = '0' and 数量 <> 0 group by 分類CD)"
        msSQL += " AS cun_peoples ON master.分類CD = cun_peoples.分類CD"
        ''分類別集計結果に空白列「取引人数」を出力するカラうちSQL
        msSQL += " INNER Join(select 分類CD, Left(分類CD, 0) As 取引人数 from Dレジ取引_未精算 where 明細区分 = '100' and 機能CD = '0' and 数量 <> 0 group by 分類CD)"
        msSQL += " AS num_peoples ON master.分類CD = num_peoples.分類CD"
        msSQL += " INNER Join(select 分類CD, SUM(数量) As 数量 from Dレジ取引_未精算 where 明細区分 = '100' and 機能CD = '0' and 数量 <> 0 group by 分類CD)"
        msSQL += " AS counter ON master.分類CD = counter.分類CD"
        msSQL += " INNER Join(select 分類CD, FORMAT( SUM(数量 * 単価), '#,###') As 金額 from Dレジ取引_未精算 where 明細区分 = '100' and 機能CD = '0' and 数量 <> 0 group by 分類CD)"
        msSQL += " AS money ON master.分類CD = money.分類CD"
        msSQL += " INNER Join(select 分類CD, FORMAT( sum(バンドル値引金額) + sum(単品値引金額) + sum(明細値引金額) + sum(小計値引金額) + sum(クーポン値引金額), '#,###') As 値引・割引 from Dレジ取引_未精算 group by 分類CD )"
        msSQL += " AS discount ON master.分類CD = discount.分類CD"
        msSQL += " INNER Join(select 分類CD, FORMAT( sum(金額), '#,###') As 取引金額 from Dレジ取引_未精算 group by 分類CD)"
        msSQL += " AS tra_amount ON master.分類CD = tra_amount.分類CD"

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