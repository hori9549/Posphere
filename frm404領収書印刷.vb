'20191203 今田涼子
Imports System.Data
Imports System.Data.SqlClient





Public Class frm404領収書印刷
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Private printingText As String
    Private printingPosition As Integer
    Private printFont As Font

    Private Sub lbl発行_Click(sender As Object, e As EventArgs) Handles lbl発行.Click

    End Sub

    Private Sub dgv一覧_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv一覧.CellContentClick

    End Sub
    Private Sub frm領収書印刷_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cDB As New clsDB '★
        Dim msSQL As String
        'Dim myTable String '検索条件の「部門コンボボックス」に登録する文字列を生成する際に使う作業用変数
        Dim myTable As New DataTable '★

        'データベースから取得したいデータ群をSQLで検索
        msSQL = "SELECT 取引日付, 取引時刻,　レシートNO,　登録区分,　数量, 金額,　客層名,　担当者CD " '★


        'Dim cDB As New clsDB '★
        msSQL += "FROM Dレジ取引" '★
        mCommand = cDB.getsqlComand(msSQL) '★上の二行に対するおまじない
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) 'データセット作成
        dgv一覧.DataSource = myTable
        'dgv一覧.DataSource = myTable
        'dgv一覧.DataSource = dtbl明細
        'With dtbl明細
        '    .Columns.Add("日付")
        '    .Columns.Add("時刻")
        '    .Columns.Add("レシートNO")
        '    .Columns.Add("区分")
        '    .Columns.Add("点数")
        '    .Columns.Add("金額")
        '    .Columns.Add("客層")
        '    .Columns.Add("担当")
        'End With

        '' Call dtbl明細.Rows.Add()

        'Dim row明細 As DataRow
        'row明細 = dtbl明細.NewRow

        'row明細("日付") = "11/04"
        'row明細("時刻") = "11:02"
        'row明細("レシートNO") = "000024"
        'row明細("区分") = "登録"
        'row明細("点数") = "1"
        'row明細("金額") = "\0"
        'row明細("客層") = "その他"
        'row明細("担当") = "001"

        'dtbl明細.Rows.Add(row明細)  '行の追加


        'Dim row明細2 As DataRow
        'row明細2 = dtbl明細.NewRow

        'row明細2("日付") = "11/04"
        'row明細2("時刻") = "11:02"
        'row明細2("レシートNO") = "000023"
        'row明細2("区分") = "登録"
        'row明細2("点数") = "1"
        'row明細2("金額") = "\0"
        'row明細2("客層") = "その他"
        'row明細2("担当") = "001"

        'dtbl明細.Rows.Add(row明細2)  '行の追加


        'Dim row明細3 As DataRow
        'row明細3 = dtbl明細.NewRow

        'row明細3("日付") = "10/14"
        'row明細3("時刻") = "16:11"
        'row明細3("レシートNO") = "000020"
        'row明細3("区分") = "登録"
        'row明細3("点数") = "2"
        'row明細3("金額") = "\0"
        'row明細3("客層") = "その他"
        'row明細3("担当") = "001"

        'dtbl明細.Rows.Add(row明細3)  '行の追加


        'Dim row明細4 As DataRow
        'row明細4 = dtbl明細.NewRow

        'row明細4("日付") = "10/14"
        'row明細4("時刻") = "16:10"
        'row明細4("レシートNO") = "000019"
        'row明細4("区分") = "登録"
        'row明細4("点数") = "2"
        'row明細4("金額") = "\0"
        'row明細4("客層") = "その他"
        'row明細4("担当") = "001"

        'dtbl明細.Rows.Add(row明細4)  '行の追加


        'Dim row明細5 As DataRow
        'row明細5 = dtbl明細.NewRow

        'row明細5("日付") = "10/14"
        'row明細5("時刻") = "16:09"
        'row明細5("レシートNO") = "000018"
        'row明細5("区分") = "登録"
        'row明細5("点数") = "8"
        'row明細5("金額") = "\0"
        'row明細5("客層") = "その他"
        'row明細5("担当") = "001"

        'dtbl明細.Rows.Add(row明細5)  '行の追加


        'Dim row明細6 As DataRow
        'row明細6 = dtbl明細.NewRow

        'row明細6("日付") = "10/02"
        'row明細6("時刻") = "14:33"
        'row明細6("レシートNO") = "000016"
        'row明細6("区分") = "登録"
        'row明細6("点数") = "2"
        'row明細6("金額") = "\0"
        'row明細6("客層") = "その他"
        'row明細6("担当") = "001"

        'dtbl明細.Rows.Add(row明細6)  '行の追加


        'Dim row明細7 As DataRow
        'row明細7 = dtbl明細.NewRow

        'row明細7("日付") = "10/02"
        'row明細7("時刻") = "14:30"
        'row明細7("レシートNO") = "000015"
        'row明細7("区分") = "登録"
        'row明細7("点数") = "3"
        'row明細7("金額") = "\0"
        'row明細7("客層") = "その他"
        'row明細7("担当") = "001"

        'dtbl明細.Rows.Add(row明細7)  '行の追加


        'Dim row明細8 As DataRow
        'row明細8 = dtbl明細.NewRow

        'row明細8("日付") = "10/02"
        'row明細8("時刻") = "14:30"
        'row明細8("レシートNO") = "000014"
        'row明細8("区分") = "登録"
        'row明細8("点数") = "2"
        'row明細8("金額") = "\0"
        'row明細8("客層") = "その他"
        'row明細8("担当") = "001"

        'dtbl明細.Rows.Add(row明細8)  '行の追加


        'Dim row明細9 As DataRow
        'row明細9 = dtbl明細.NewRow

        'row明細9("日付") = "10/02"
        'row明細9("時刻") = "14:28"
        'row明細9("レシートNO") = "000013"
        'row明細9("区分") = "登録"
        'row明細9("点数") = "2"
        'row明細9("金額") = "\0"
        'row明細9("客層") = "その他"
        'row明細9("担当") = "001"

        'dtbl明細.Rows.Add(row明細9)  '行の追加







    End Sub

    Private Sub btn閉じる_Click(sender As Object, e As EventArgs) Handles btn閉じる.Click
        Me.Close()

    End Sub

    Private Sub btn印刷_Click(sender As Object, e As EventArgs) Handles btn印刷.Click

        Dim cDB As New clsDB '★
        Dim msSQL As String
        'Dim myTable String '検索条件の「部門コンボボックス」に登録する文字列を生成する際に使う作業用変数
        Dim myTable As New DataTable '★

        Dim printingText As String
        Dim printingPosition As Integer
        Dim printFont As Font

        Call mSDA.Fill(myTable) 'データセット作成
        dgv一覧.DataSource = myTable

        '印刷する文字列と位置を設定する

        printingText = dgv一覧.DataSource = dgv一覧
        printingPosition = 0
        '印刷に使うフォントを指定する
        printFont = New Font("ＭＳ Ｐゴシック", 10)
        'PrintDocumentオブジェクトの作成
        Dim pd As New System.Drawing.Printing.PrintDocument
        'PrintPageイベントハンドラの追加
        'AddHandler pd.PrintPage, AddressOf pd_PrintPage
        '印刷を開始する
        pd.Print()
    End Sub
End Class

Friend Class FontPrivate
End Class
