
''20200228漆谷　集計ボタンの挙動を追加-------------------------------

Imports System.Data
Imports System.Data.SqlClient

Public Class frm506売上点検_時間帯別集計

    Public frmBefor As Form

    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Private Sub frm505売上点検_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn集計_Click(sender As Object, e As EventArgs) Handles btn集計.Click
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        grp検索項目.DataSource = Nothing

        'データベースから取得したいデータ群をSQLで検索
        msSQL = " Select Case"
        msSQL += " when 取引時刻 >= '000000' and 取引時刻 < '010000' then '00:00-00:59'"
        msSQL += " when 取引時刻 >= '010000' and 取引時刻 < '020000' then '01:00-01:59'"
        msSQL += " when 取引時刻 >= '020000' and 取引時刻 < '030000' then '02:00-02:59'"
        msSQL += " when 取引時刻 >= '030000' and 取引時刻 < '040000' then '03:00-03:59'"
        msSQL += " when 取引時刻 >= '040000' and 取引時刻 < '050000' then '04:00-04:59'"
        msSQL += " when 取引時刻 >= '050000' and 取引時刻 < '060000' then '05:00-05:59'"
        msSQL += " when 取引時刻 >= '060000' and 取引時刻 < '070000' then '06:00-06:59'"
        msSQL += " when 取引時刻 >= '070000' and 取引時刻 < '080000' then '07:00-07:59'"
        msSQL += " when 取引時刻 >= '080000' and 取引時刻 < '090000' then '08:00-08:59'"
        msSQL += " when 取引時刻 >= '090000' and 取引時刻 < '100000' then '09:00-19:59'"
        msSQL += " when 取引時刻 >= '100000' and 取引時刻 < '110000' then '10:00-10:59'"
        msSQL += " when 取引時刻 >= '110000' and 取引時刻 < '120000' then '11:00-11:59'"
        msSQL += " when 取引時刻 >= '120000' and 取引時刻 < '130000' then '12:00-12:59'"
        msSQL += " when 取引時刻 >= '130000' and 取引時刻 < '140000' then '13:00-13:59'"
        msSQL += " when 取引時刻 >= '140000' and 取引時刻 < '150000' then '14:00-14:59'"
        msSQL += " when 取引時刻 >= '150000' and 取引時刻 < '160000' then '15:00-15:59'"
        msSQL += " when 取引時刻 >= '160000' and 取引時刻 < '170000' then '16:00-16:59'"
        msSQL += " when 取引時刻 >= '170000' and 取引時刻 < '180000' then '17:00-17:59'"
        msSQL += " when 取引時刻 >= '180000' and 取引時刻 < '190000' then '18:00-18:59'"
        msSQL += " when 取引時刻 >= '190000' and 取引時刻 < '200000' then '19:00-29:59'"
        msSQL += " when 取引時刻 >= '200000' and 取引時刻 < '210000' then '20:00-20:59'"
        msSQL += " when 取引時刻 >= '210000' and 取引時刻 < '220000' then '21:00-21:59'"
        msSQL += " when 取引時刻 >= '220000' and 取引時刻 < '230000' then '22:00-22:59'"
        msSQL += " when 取引時刻 >= '230000' and 取引時刻 < '240000' then '23:00-23:59'"
        msSQL += " Else 'その他' END 時間帯,"
        msSQL += " count(人数) As 取引回数,"
        msSQL += " SUM(人数) As 取引人数,"
        msSQL += " SUM(数量) As 数量,"
        msSQL += " FORMAT( SUM(数量 * 単価), '#,###') As 金額,"
        msSQL += " FORMAT( sum(バンドル値引金額) + sum(単品値引金額) + sum(明細値引金額) + sum(小計値引金額) + sum(クーポン値引金額), '#,###') As 値引・割引,"
        msSQL += " FORMAT( SUM(金額), '#,###') As 取引金額"
        msSQL += " From Dレジ取引"
        msSQL += " Where 商品CD <> ''"
        msSQL += " GROUP BY 時間帯 "
        msSQL += " ORDER BY 取引時刻"

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