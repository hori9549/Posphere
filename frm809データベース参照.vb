Imports System.Data
Imports System.Data.SqlClient

Public Class frm809データベース参照
    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Private Sub lbl検索条件_Click(sender As Object, e As EventArgs) Handles lbl検索条件.Click

    End Sub

    Private Sub frmデータベース参照_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable
        Dim strTemp As String '検索条件の「部門コンボボックス」に登録する文字列を生成する際に使う作業用変数

        'データベースから取得したいデータ群をSQLで検索
        msSQL = "SELECT name "
        msSQL += "FROM sys.tables"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成

        'SQLで検索したデータ群のレコードを、1レコードずつ取り出す
        For nRowCounter As Integer = 0 To myTable.Rows.Count - 1
            strTemp = "" '次に「cmbDPOS管理」に登録する文字列　を　クリア（初期化：長さ０の文字列）する

            '    '取り出したレコードのフィールドを1つずつ取得する場合は以下の処理で取り出せるよ
            'For nColumuCounter As Integer = 0 To myTable.Columns.Count - 1
            '    '    strTemp += myTable.Rows(nRowCounter).Item(nColumuCounter).ToString()
            '    'Next

            '    '「cmbDPOS管理」に登録する文字列データの生成
            strTemp += myTable.Rows(nRowCounter).Item("name").ToString()
            '    strTemp += ":"
            '    strTemp += myTable.Rows(nRowCounter).Item("パターン名称").ToString()

            '    '生成した文字列を「cmbDPOS管理」に登録する
            cmbDPOS管理.Items.Add(strTemp)

        Next

        Call cDB.Close()

        cmbDPOS管理.SelectedIndex = 0

    End Sub

    Private Sub btn終了_Click(sender As Object, e As EventArgs) Handles btn終了.Click
        Me.Close()

    End Sub

    Private Sub bun抽出_Click(sender As Object, e As EventArgs) Handles bun抽出.Click
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        Dim bWhereSwitch As Boolean = False '登録済みの条件1つ目を見つけたかどうか？


        'メッセージボックスを表示させたい場合は↓を使う
        'MessageBox.Show(cmbDPOS管理.SelectedIndex.ToString() + " : " + cmbDPOS管理.SelectedItem.ToString())


        'データベースから取得したいデータ群をSQLで検索
        msSQL = "SELECT * "
        msSQL += "FROM "
        msSQL += cmbDPOS管理.SelectedItem.ToString()

        If cmb条件１.SelectedIndex > 0 And cmb条件１記号.SelectedIndex > 0 And txt条件１値.TextLength >= 1 Then
            If bWhereSwitch = False Then
                msSQL += " where "
                bWhereSwitch = True
            Else
                msSQL += " AND "
            End If
            msSQL += cmb条件１.SelectedItem.ToString() + cmb条件１記号.SelectedItem.ToString() + "'" + txt条件１値.Text + "' "
        End If

        If cmb条件２.SelectedIndex > 0 And cmb条件２記号.SelectedIndex > 0 And txt条件２値.TextLength >= 1 Then
            If bWhereSwitch = False Then
                msSQL += " where "
                bWhereSwitch = True
            Else
                msSQL += " AND "
            End If
            msSQL += cmb条件２.SelectedItem.ToString() + cmb条件２記号.SelectedItem.ToString() + "'" + txt条件２値.Text + "' "
        End If

        If cmb条件３.SelectedIndex > 0 And cmb条件３記号.SelectedIndex > 0 And txt条件３値.TextLength >= 1 Then
            If bWhereSwitch = False Then
                msSQL += " where "
                bWhereSwitch = True
            Else
                msSQL += " AND "
            End If
            msSQL += cmb条件３.SelectedItem.ToString() + cmb条件３記号.SelectedItem.ToString() + "'" + txt条件３値.Text + "' "
        End If

        If cmb条件４.SelectedIndex > 0 And cmb条件４記号.SelectedIndex > 0 And txt条件４値.TextLength >= 1 Then
            If bWhereSwitch = False Then
                msSQL += " where "
                bWhereSwitch = True
            Else
                msSQL += " AND "
            End If
            msSQL += cmb条件４.SelectedItem.ToString() + cmb条件４記号.SelectedItem.ToString() + "'" + txt条件４値.Text + "' "
        End If

        If cmb条件５.SelectedIndex > 0 And cmb条件５記号.SelectedIndex > 0 And txt条件５値.TextLength >= 1 Then
            If bWhereSwitch = False Then
                msSQL += " where "
                bWhereSwitch = True
            Else
                msSQL += " AND "
            End If
            msSQL += cmb条件５.SelectedItem.ToString() + cmb条件５記号.SelectedItem.ToString() + "'" + txt条件５値.Text + "' "
        End If

        If cmb条件６.SelectedIndex > 0 And cmb条件６記号.SelectedIndex > 0 And txt条件６値.TextLength >= 1 Then
            If bWhereSwitch = False Then
                msSQL += " where "
                bWhereSwitch = True
            Else
                msSQL += " AND "
            End If
            msSQL += cmb条件６.SelectedItem.ToString() + cmb条件６記号.SelectedItem.ToString() + "'" + txt条件６値.Text + "' "
        End If

        If cmb条件７.SelectedIndex > 0 And cmb条件７記号.SelectedIndex > 0 And txt条件７値.TextLength >= 1 Then
            If bWhereSwitch = False Then
                msSQL += " where "
                bWhereSwitch = True
            Else
                msSQL += " AND "
            End If
            msSQL += cmb条件７.SelectedItem.ToString() + cmb条件７記号.SelectedItem.ToString() + "'" + txt条件７値.Text + "' "
        End If

        If cmb条件８.SelectedIndex > 0 And cmb条件８記号.SelectedIndex > 0 And txt条件８値.TextLength >= 1 Then
            If bWhereSwitch = False Then
                msSQL += " where "
                bWhereSwitch = True
            Else
                msSQL += " AND "
            End If
            msSQL += cmb条件８.SelectedItem.ToString() + cmb条件８記号.SelectedItem.ToString() + "'" + txt条件８値.Text + "' "
        End If




        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成

        dgvデータベース参照.DataSource = myTable

        Call cDB.Close()




    End Sub

    Private Sub cmbDPOS管理_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDPOS管理.SelectedIndexChanged
        cmb条件１.Items.Clear()
        cmb条件２.Items.Clear()
        cmb条件３.Items.Clear()
        cmb条件４.Items.Clear()
        cmb条件５.Items.Clear()
        cmb条件６.Items.Clear()
        cmb条件７.Items.Clear()
        cmb条件８.Items.Clear()

        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable
        Dim strTemp As String '検索条件の「部門コンボボックス」に登録する文字列を生成する際に使う作業用変数

        'データベースから取得したいデータ群をSQLで検索
        'フィールド（列）の一覧取得
        msSQL = "SELECT name "
        msSQL += "FROM sys.columns "
        msSQL += "WHERE object_id = (SELECT object_id "
        msSQL += "            From sys.tables "
        msSQL += "            Where Name = '" + cmbDPOS管理.SelectedItem.ToString + "'"
        msSQL += "            )"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成

        '    '初期項目の文字列””を「cmb条件１～８」に登録する
        cmb条件１.Items.Add("")
        cmb条件２.Items.Add("")
        cmb条件３.Items.Add("")
        cmb条件４.Items.Add("")
        cmb条件５.Items.Add("")
        cmb条件６.Items.Add("")
        cmb条件７.Items.Add("")
        cmb条件８.Items.Add("")
        'SQLで検索したデータ群のレコードを、1レコードずつ取り出す
        For nRowCounter As Integer = 0 To myTable.Rows.Count - 1
            '    '「cmb条件１～８」に登録する文字列データの生成
            strTemp = myTable.Rows(nRowCounter).Item("name").ToString()

            '    '生成した文字列を「cmb条件１～８」に登録する
            cmb条件１.Items.Add(strTemp)
            cmb条件２.Items.Add(strTemp)
            cmb条件３.Items.Add(strTemp)
            cmb条件４.Items.Add(strTemp)
            cmb条件５.Items.Add(strTemp)
            cmb条件６.Items.Add(strTemp)
            cmb条件７.Items.Add(strTemp)
            cmb条件８.Items.Add(strTemp)

        Next

        cmb条件１.SelectedIndex = 0
        cmb条件２.SelectedIndex = 0
        cmb条件３.SelectedIndex = 0
        cmb条件４.SelectedIndex = 0
        cmb条件５.SelectedIndex = 0
        cmb条件６.SelectedIndex = 0
        cmb条件７.SelectedIndex = 0
        cmb条件８.SelectedIndex = 0



        Call cDB.Close()
    End Sub

    Private Sub btnエクスポート_Click(sender As Object, e As EventArgs) Handles btnエクスポート.Click
        '保存用のファイルを開く
        Using writer As New System.IO.StreamWriter("C:\work\test2.csv", False, System.Text.Encoding.GetEncoding("shift_jis"))
            Dim rowCount As Integer = dgvデータベース参照.Rows.Count

            ' ユーザによる行追加が許可されている場合は、最後の新規入力用の
            ' 1行分を差し引く
            'Dim rowCount As Integer = dgvデータベース参照.Rows.Count
            'If (dgvデータベース参照.AllowUserToAddRows = True) Then
            '    rowCount = rowCount - 1
            'End If

            ' 行
            For i As Integer = 0 To rowCount - 1
                ' リストの初期化
                Dim strList As New List(Of String)

                ' 列
                For j As Integer = 0 To dgvデータベース参照.Columns.Count - 1
                    strList.Add(dgvデータベース参照(j, i).Value.ToString())
                Next
                Dim strArray As String() = strList.ToArray() ' 配列へ変換

                ' CSV 形式に変換
                Dim strCsvData As String = String.Join(",", strArray)

                writer.WriteLine(strCsvData)
            Next
        End Using
    End Sub

    Private Sub btn条件クリア_Click(sender As Object, e As EventArgs) Handles btn条件クリア.Click
        cmbDPOS管理.SelectedIndex = 0

        cmb条件１.SelectedIndex = 0
        cmb条件２.SelectedIndex = 0
        cmb条件３.SelectedIndex = 0
        cmb条件４.SelectedIndex = 0
        cmb条件５.SelectedIndex = 0
        cmb条件６.SelectedIndex = 0
        cmb条件７.SelectedIndex = 0
        cmb条件８.SelectedIndex = 0

        cmb条件１記号.SelectedIndex = 0
        cmb条件２記号.SelectedIndex = 0
        cmb条件３記号.SelectedIndex = 0
        cmb条件４記号.SelectedIndex = 0
        cmb条件５記号.SelectedIndex = 0
        cmb条件６記号.SelectedIndex = 0
        cmb条件７記号.SelectedIndex = 0
        cmb条件８記号.SelectedIndex = 0

        txt条件１値.Text = ""
        txt条件２値.Text = ""
        txt条件３値.Text = ""
        txt条件４値.Text = ""
        txt条件５値.Text = ""
        txt条件６値.Text = ""
        txt条件７値.Text = ""
        txt条件８値.Text = ""

        dgvデータベース参照.DataSource = ""


    End Sub
End Class