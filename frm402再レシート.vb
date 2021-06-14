Imports System.Data
Imports System.Data.SqlClient

'2019_Koichi_Shimazu
Public Class frm402再レシート
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter


    Private printingText As String
    Private printingPosition As Integer
    Private printFont As Font


    Private Sub btn閉じる_Click(sender As Object, e As EventArgs) Handles btn閉じる.Click
        Me.Close()
    End Sub


    Private Sub frm再レシート_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cDB As New clsDB '★
        Dim msSQL As String
        'Dim myTable String '検索条件の「部門コンボボックス」に登録する文字列を生成する際に使う作業用変数
        Dim myTable As New DataTable '★ 

        'データベースから取得したいデータ群をSQLで検索
        msSQL = "SELECT 取引日付, 取引時刻,　レシートNO,　登録区分,　数量,金額,　客層名,　担当者　" '★
        msSQL += "FROM Dレジ取引" '★
        mCommand = cDB.getsqlComand(msSQL) '★上の二行に対するおまじない
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) 'データセット作成

        dgv一覧.DataSource = myTable



    End Sub




    Private Sub btn食券再発行_Click(sender As Object, e As EventArgs) Handles btn食券再発行.Click



    End Sub

    Private Sub btn印刷_Click(sender As Object, e As EventArgs) Handles btn印刷.Click

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