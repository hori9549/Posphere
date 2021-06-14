
''20200228漆谷　集計ボタンの挙動を追加-------------------------------

Imports System.Data
Imports System.Data.SqlClient

Public Class frm508売上点検_ジャーナル

    Public frmBefor As Form

    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Private Sub frm507売上点検_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'データベースから担当者のデータ群をSQLで検索
        cmb担当者.Items.Add("全て")
        Call コンボボックスへのデータ挿入("M担当", "担当者CD", "担当者名", cmb担当者)

        'データベースから部門名のデータ群をSQLで検索
        cmb部門.Items.Add("全て")
        Call コンボボックスへのデータ挿入("M部門", "部門CD", "部門名", cmb部門)

        'データベースから登録区分のデータ群をSQLで検索
        ''call コンボボックスへのデータ挿入("", "", "", cmb登録区分)
        cmb登録区分.Items.Add("全て")
        cmb登録区分.Items.Add("登録")
        cmb登録区分.Items.Add("訂正")
        cmb登録区分.Items.Add("登消")
        cmb登録区分.Items.Add("訂消")

        'データベースから明細区分のデータ群をSQLで検索
        cmb明細区分.Items.Add("全て")
        Call コンボボックスへのデータ挿入("M明細区分", "明細区分", "明細区分名", cmb明細区分)

    End Sub

    Private Sub btn集計_Click(sender As Object, e As EventArgs) Handles btn集計.Click
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        grp検索項目.DataSource = Nothing

        'データベースから取得したいデータ群をSQLで検索
        msSQL = "SELECT "
        msSQL += "substring(取引日付, 5, 2) + '/' + substring(取引日付, 7, 2) + ' ' + substring(取引時刻, 1, 2) + ':' + substring(取引時刻, 3, 2) AS 取引時刻, "
        msSQL += "レシートNO, "
        msSQL += "登録区分, "
        msSQL += "行NO, "
        msSQL += "表示名, "
        msSQL += "数量, "
        msSQL += "FORMAT(単価, 'C', 'ja-JP') AS 単価, "
        msSQL += "FORMAT(金額, 'C', 'ja-JP') AS 金額, "
        msSQL += "担当者名, "
        msSQL += "客層名 "
        msSQL += "FROM Dレジ取引_未精算"

        '検索条件が指定されている場合のWHERE句

        msSQL += " WHERE レシートNO >= '" + txtレシートNO先頭.Text + "' AND レシートNO <= '" + txtレシートNO終端.Text + "' "


        If cmb担当者.Text <> "全て" Then

            msSQL += " AND "
            msSQL += " 担当者CD = '" + cmb担当者.Text.Substring(0, 3) + "'"
        End If

        If cmb部門.Text <> "全て" Then

            msSQL += " AND "
            msSQL += " 部門CD = '" + cmb部門.Text.Substring(0, 4) + "'"
        End If

        If cmb登録区分.Text <> "全て" Then

            msSQL += " AND "
            msSQL += " 登録区分 = '" + cmb登録区分.Text + "' "

        End If

        If cmb明細区分.Text <> "全て" Then

            msSQL += " AND "
            msSQL += " 明細区分 = '" + cmb明細区分.Text.Substring(0, 3) + "'"

        End If

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成

        grp検索項目.DataSource = myTable

        Call cDB.Close()

        '印刷ボタンをアクティブに変更
        btn印刷.Enabled = True

    End Sub

    Private Sub btn印刷_Click(sender As Object, e As EventArgs) Handles btn印刷.Click



    End Sub

    Private Sub btn終了_Click(sender As Object, e As EventArgs) Handles btn終了.Click

        Call Me.Close()

    End Sub

    Private Sub コンボボックスへのデータ挿入(テーブル名 As String, コロン前 As String, コロン後 As String, 対象コンボボックス As ComboBox)
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable
        Dim strTemp As String '検索条件の「部門コンボボックス」に登録する文字列を生成する際に使う作業用変数


        'データベースから取得したいデータ群をSQLで検索
        msSQL = "SELECT * "
        msSQL += "FROM " + テーブル名

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成

        'SQLで検索したデータ群のレコードを、1レコードずつ取り出す
        For nRowCounter As Integer = 0 To myTable.Rows.Count - 1
            strTemp = "" '次に「部門コンボボックス」に登録する文字列　を　クリア（初期化：長さ０の文字列）する

            '取り出したレコードのフィールドを1つずつ取得する場合は以下の処理で取り出せるよ
            'For nColumuCounter As Integer = 0 To myTable.Columns.Count - 1
            '    strTemp += myTable.Rows(nRowCounter).Item(nColumuCounter).ToString()
            'Next

            '「部門コンボボックス」に登録する文字列データの生成
            strTemp += myTable.Rows(nRowCounter).Item(コロン前).ToString()
            strTemp += ":"
            strTemp += myTable.Rows(nRowCounter).Item(コロン後).ToString()

            '生成した文字列を「部門コンボボックス」に登録する
            対象コンボボックス.Items.Add(strTemp)

        Next

        Call cDB.Close()

    End Sub


End Class