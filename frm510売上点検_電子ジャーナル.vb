
''20200228漆谷　集計ボタンの挙動を追加-------------------------------

Imports System.Data
Imports System.Data.SqlClient

Public Class frm510売上点検_電子ジャーナル

    Public frmBefor As Form

    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Private Sub frm509売上点検_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmb表示内容.Items.Add("全て")
        cmb表示内容.Items.Add("登録")
        cmb表示内容.Items.Add("訂正")
        cmb表示内容.Items.Add("練習")
        cmb表示内容.Items.Add("取消")
        cmb表示内容.Items.Add("再ﾚｼｰﾄ")
        cmb表示内容.Items.Add("領収")

    End Sub

    Private Sub btn集計_Click(sender As Object, e As EventArgs) Handles btn集計.Click





        '印刷ボタンをアクティブに変更
        btn印刷.Enabled = True

    End Sub

    Private Sub btn印刷_Click(sender As Object, e As EventArgs) Handles btn印刷.Click



    End Sub

    Private Sub btn終了_Click(sender As Object, e As EventArgs) Handles btn終了.Click

        Call Me.Close()

    End Sub

    Private Sub but表示_Click(sender As Object, e As EventArgs) Handles but表示.Click

        Call リストボックスへのデータ挿入("Dレジ取引_未精算", "レシートNO", "明細区分", lst表示内容)


    End Sub

    Private Sub リストボックスへのデータ挿入(テーブル名 As String, コロン前 As String, コロン後 As String, 対象リストボックス As ListBox)
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable
        Dim strTemp As String '検索条件の「部門コンボボックス」に登録する文字列を生成する際に使う作業用変数


        '日付用の変数
        Dim myDate As New DateTime


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
            'strTemp += myTable.Rows(nRowCounter).Item(nColumuCounter).ToString()

            'lst表示内容.Items.Add(strTemp)
            'Next

            If myTable.Rows(nRowCounter).Item("行NO").ToString() = "1" Then

                lst表示内容.Items.Add("―――――――――――――――――――")

                strTemp = "明細区分　＝　"
                strTemp += myTable.Rows(nRowCounter).Item("明細区分").ToString()

                lst表示内容.Items.Add(strTemp)

            End If

            If myTable.Rows(nRowCounter).Item("行NO").ToString() = "1" Then

                strTemp = myTable.Rows(nRowCounter).Item("取引日付").ToString().Substring(0, 4) + "/" _
                        + myTable.Rows(nRowCounter).Item("取引日付").ToString().Substring(4, 2) + "/" _
                        + myTable.Rows(nRowCounter).Item("取引日付").ToString().Substring(6, 2) + " " _
                        + myTable.Rows(nRowCounter).Item("取引時刻").ToString().Substring(0, 2) + ":" _
                        + myTable.Rows(nRowCounter).Item("取引時刻").ToString().Substring(2, 2) + ":" _
                        + myTable.Rows(nRowCounter).Item("取引時刻").ToString().Substring(4, 2)

                myDate = DateTime.Parse(strTemp)

                strTemp = myDate.ToString("yyyy年MM月dd日(ddd)")
                strTemp += "　"
                strTemp += myDate.ToString("hh時mm分")

                lst表示内容.Items.Add(strTemp)

            End If

            If myTable.Rows(nRowCounter).Item("行NO").ToString() = "1" And myTable.Rows(nRowCounter).Item("明細区分").ToString() = "100" Then

                lst表示内容.Items.Add("------------- 領　収　書 -------------")

            End If

            If myTable.Rows(nRowCounter).Item("登録区分").ToString() = "登消" Then

                lst表示内容.Items.Add("--------------- 取　消 ---------------")

            End If

            If myTable.Rows(nRowCounter).Item("JANCD").ToString() <> "" Then

                strTemp = myTable.Rows(nRowCounter).Item("JANCD").ToString()
                lst表示内容.Items.Add(strTemp)

                strTemp = myTable.Rows(nRowCounter).Item("表示名").ToString()
                strTemp += "　"
                strTemp += Integer.Parse(myTable.Rows(nRowCounter).Item("金額"), Globalization.NumberStyles.Any).ToString("C")

                lst表示内容.Items.Add(strTemp)

            End If

            If myTable.Rows(nRowCounter).Item("表示名").ToString() = "小　計" Or
               myTable.Rows(nRowCounter).Item("表示名").ToString() = "お預り" Or
               myTable.Rows(nRowCounter).Item("表示名").ToString() = "お釣り" Then

                strTemp = myTable.Rows(nRowCounter).Item("表示名").ToString()
                strTemp += "　　　　　"
                strTemp += Integer.Parse(myTable.Rows(nRowCounter).Item("金額"), Globalization.NumberStyles.Any).ToString("C")

                lst表示内容.Items.Add(strTemp)

            End If

            If myTable.Rows(nRowCounter).Item("表示名").ToString() = "合　計" Then

                strTemp = myTable.Rows(nRowCounter).Item("表示名").ToString()
                strTemp += "　"
                strTemp += myTable.Rows(nRowCounter).Item("数量").ToString()
                strTemp += "点"
                strTemp += "　　　"
                strTemp += Integer.Parse(myTable.Rows(nRowCounter).Item("金額"), Globalization.NumberStyles.Any).ToString("C")

                lst表示内容.Items.Add(strTemp)

            End If

        Next

        Call cDB.Close()

        '印刷ボタンをアクティブに変更
        btn印刷.Enabled = True

    End Sub

    Private Sub btn検索_Click(sender As Object, e As EventArgs) Handles btn検索.Click

        MessageBox.Show("検索条件を指定してください。", "SpreadN", MessageBoxButtons.OK)

    End Sub

End Class