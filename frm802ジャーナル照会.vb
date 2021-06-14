'20200628漆谷:コンボボックスの表示を設定
'            :DGVへの出力を設定
'            :不明点→「抽出」「レシート印刷」「エクスポート」ボタンの機能
'            :不明点→DGVの出力内容が正しいか

Imports System.Data
Imports System.Data.SqlClient

Public Class frm802ジャーナル照会
    Private dtbl明細 As New DataTable

    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb部門.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb担当者.SelectedIndexChanged

    End Sub

    Private Sub lbl登録区分_Click(sender As Object, e As EventArgs) Handles lbl登録区分.Click

    End Sub

    Private Sub 明細区分_Click(sender As Object, e As EventArgs) Handles lbl明細区分.Click

    End Sub

    Private Sub frmジャーナル照会_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cmb担当者.Items.Add("117:松本 昭美")
        'cmb担当者.Items.Add("201:江川 初枝")
        'cmb担当者.Items.Add("501:服部 静子")

        'データベースから担当者のデータ群をSQLで検索
        cmb担当者.Items.Add("全て")
        Call コンボボックスへのデータ挿入("M担当", "担当者CD", "担当者名", cmb担当者)

        'データベースから部門のデータ群をSQLで検索
        cmb部門.Items.Add("全て")
        Call コンボボックスへのデータ挿入("M部門", "部門CD", "部門名", cmb部門)

        'データベースから登録区分のデータ群を直接登録
        ''call コンボボックスへのデータ挿入("", "", "", cmb登録区分)
        cmb登録区分.Items.Add("全て")
        cmb登録区分.Items.Add("登録")
        cmb登録区分.Items.Add("訂正")
        cmb登録区分.Items.Add("登消")
        cmb登録区分.Items.Add("訂消")

        'データベースから明細区分のデータ群をSQLで検索
        cmb明細区分.Items.Add("全て")
        Call コンボボックスへのデータ挿入("M明細区分", "明細区分", "明細区分名", cmb明細区分)

        dgvジャーナル照会.DataSource = dtbl明細

        dtbl明細.Columns.Add("端末CD")
        dtbl明細.Columns.Add("取引日時")
        dtbl明細.Columns.Add("レシートNO")
        dtbl明細.Columns.Add("区分")
        dtbl明細.Columns.Add("No")
        dtbl明細.Columns.Add("取引名")
        dtbl明細.Columns.Add("数量")
        dtbl明細.Columns.Add("単価")
        dtbl明細.Columns.Add("金額")
        dtbl明細.Columns.Add("担当者名")
        dtbl明細.Columns.Add("客層名")

        btnレシート印刷.Enabled = False
        btnエクスポート.Enabled = False

    End Sub

    Private Sub lbl担当者_Click(sender As Object, e As EventArgs) Handles lbl担当者.Click

    End Sub

    Private Sub dgvジャーナル照会_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvジャーナル照会.CellContentClick

    End Sub

    Private Sub btn過去分レシート再発行_Click(sender As Object, e As EventArgs) Handles btn過去分レシート再発行.Click

        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        dgvジャーナル照会.DataSource = Nothing

        'データベースから取得したいデータ群をSQLで検索
        msSQL = "SELECT "
        msSQL += "substring(取引日付, 5, 2) + '/' + substring(取引日付, 7, 2) + ' ' "
        msSQL += "+ substring(取引時刻, 1, 2) + ':' + substring(取引時刻, 3, 2) AS 取引時刻, "
        msSQL += ""
        msSQL += "レシートNO, "
        msSQL += "登録区分, "
        msSQL += "行NO, "
        msSQL += "表示名, "
        msSQL += "数量, "
        msSQL += "FORMAT(単価, 'C', 'ja-JP') AS 単価, "
        msSQL += "FORMAT(金額, 'C', 'ja-JP') AS 金額, "
        msSQL += "担当者名, "
        msSQL += "客層名 "
        msSQL += "FROM Dレジ取引"

        '検索条件が指定されている場合のWHERE句
        msSQL += " WHERE 取引日付 >= "
        msSQL += DateTimePicker1.Value.ToString.Substring(0, 4)
        msSQL += DateTimePicker1.Value.ToString.Substring(5, 2)
        msSQL += DateTimePicker1.Value.ToString.Substring(8, 2)
        msSQL += " And 取引日付 <= "
        msSQL += DateTimePicker2.Value.ToString.Substring(0, 4)
        msSQL += DateTimePicker2.Value.ToString.Substring(5, 2)
        msSQL += DateTimePicker2.Value.ToString.Substring(8, 2)

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

        dgvジャーナル照会.DataSource = myTable

        Call cDB.Close()

        '印刷ボタンをアクティブに変更
        btnレシート印刷.Enabled = True
        btnエクスポート.Enabled = True

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

    Private Sub btn抽出_Click(sender As Object, e As EventArgs) Handles btn抽出.Click

    End Sub

    Private Sub btnレシート印刷_Click(sender As Object, e As EventArgs) Handles btnレシート印刷.Click

    End Sub

    Private Sub btnエクスポート_Click(sender As Object, e As EventArgs) Handles btnエクスポート.Click

    End Sub

    Private Sub btn終了_Click(sender As Object, e As EventArgs) Handles btn終了.Click

        Call Me.Close()

    End Sub

End Class