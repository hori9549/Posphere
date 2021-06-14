'20191119 今田涼子
Imports System.Data
    Imports System.Data.SqlClient

Public Class frm403JAN商品検索

    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Private Sub frm403JAN商品検索_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable
        Dim myTable2 As New DataTable
        Dim strTemp As String '検索条件の「分類コンボボックス」に登録する文字列を生成する際に使う作業用変数
        Dim strTemp2 As String '検索条件の「部門コンボボックス」に登録する文字列を生成する際に使う作業用変数

        'データベースから取得したいデータ群をSQLで検索
        msSQL = "SELECT 分類CD,分類名 "
        msSQL += "FROM M分類 "
        msSQL += "ORDER BY 分類CD"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成

        'SQLで検索したデータ群のレコードを、1レコードずつ取り出す
        For nRowCounter As Integer = 0 To myTable.Rows.Count - 1
            strTemp = "" '次に「cmb分類」に登録する文字列　を　クリア（初期化：長さ０の文字列）する

            '    '取り出したレコードのフィールドを1つずつ取得する場合は以下の処理で取り出せるよ
            'For nColumuCounter As Integer = 0 To myTable.Columns.Count - 1
            '    '    strTemp += myTable.Rows(nRowCounter).Item(nColumuCounter).ToString()
            '    'Next

            '    '「cmb分類」に登録する文字列データの生成
            strTemp += myTable.Rows(nRowCounter).Item("分類名").ToString()
            '    strTemp += ":"
            '    strTemp += myTable.Rows(nRowCounter).Item("パターン名称").ToString()

            '    '生成した文字列を「cmb分類」に登録する
            cmb分類.Items.Add(strTemp)

        Next

        Call cDB.Close()

        cmb分類.SelectedIndex = 0

        'データベースから取得したいデータ群をSQLで検索
        msSQL = "SELECT 部門CD,部門名 "
        msSQL += "FROM M部門 "
        msSQL += "ORDER BY 部門CD"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable2) ''データセット作成

        'SQLで検索したデータ群のレコードを、1レコードずつ取り出す
        For nRowCounter As Integer = 0 To myTable2.Rows.Count - 1
            strTemp2 = "" '次に「cmb部門」に登録する文字列　を　クリア（初期化：長さ０の文字列）する


            '「cmb部門」に登録する文字列データの生成
            strTemp2 += myTable2.Rows(nRowCounter).Item("部門名").ToString()
            '    strTemp += ":"
            '    strTemp += myTable.Rows(nRowCounter).Item("パターン名称").ToString()

            '    '生成した文字列を「cmb部門」に登録する
            cmb部門.Items.Add(strTemp2)

        Next

        Call cDB.Close()

        cmb部門.SelectedIndex = 0


        grp英字.Visible = False
        grpカナ.Visible = True



    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnあ.Click, btnい.Click, btnう.Click, btnえ.Click, btnお.Click,
        btnか.Click, btnき.Click, btnく.Click, btnけ.Click, btnこ.Click, btnさ.Click, btnし.Click, btnす.Click, btnせ.Click, btnそ.Click,
        btnた.Click, btnち.Click, btnつ.Click, btnて.Click, btnと.Click, btnな.Click, btnに.Click, btnぬ.Click, btnね.Click, btnの.Click,
        btnは.Click, btnひ.Click, btnふ.Click, btnへ.Click, btnほ.Click, btnま.Click, btnみ.Click, btnむ.Click, btnめ.Click, btnも.Click,
        btnや.Click, btnゆ.Click, btnよ.Click, btnら.Click, btnり.Click, btnる.Click, btnれ.Click, btnろ.Click, btnわ.Click, btnを.Click, btnん.Click,
        btnァ.Click, btnィ.Click, btnゥ.Click, btnェ.Click, btnォ.Click, btnッ.Click, btnャ.Click, btnュ.Click, btnョ.Click,
        btnー.Click, btn半濁点.Click, btn濁点.Click,
        btn０.Click, btn１.Click, btn２.Click, btn３.Click, btn４.Click, btn５.Click, btn６.Click, btn７.Click, btn８.Click, btn９.Click,
        btnマイナス.Click, btnピリオド.Click,
        btnA.Click, btnB.Click, btnC.Click, btnD.Click, btnE.Click, btnF.Click, btnG.Click, btnH.Click, btnI.Click, btnJ.Click,
        btnK.Click, btnL.Click, btnM.Click, btnN.Click, btnO.Click, btnP.Click, btnQ.Click, btnR.Click, btnS.Click, btnT.Click,
        btnU.Click, btnV.Click, btnW.Click, btnX.Click, btnY.Click, btnZ.Click

        txt検索カナ.Text = txt検索カナ.Text + sender.text
    End Sub

    Private Sub btn閉じる_Click(sender As Object, e As EventArgs) Handles btn閉じる.Click
        Me.Close()

    End Sub


    Private Sub btn検索_Click(sender As Object, e As EventArgs) Handles btn検索.Click

        Dim cDB As New clsDB
        Dim msSQL As String
        Dim tblComboList As New DataTable
        'Dim bWhereSwitch As Boolean = False '登録済みの条件1つ目を見つけたかどうか？
        '-------------------------------------------------------------------------------------------------------------------------
        'テーブルを結合して、dgv一覧の ｜部門｜検索カナ｜商品名｜ に表示
        msSQL = "Select b.部門名 As 部門,a.検索カナ,a.品目名 As 商品名 "
        msSQL += "From (M品目 As a inner join M部門 As b on a.部門CD = b.部門CD)
                      inner join M分類 As c on a.分類CD = c.分類CD "
        If cmb分類.SelectedIndex > 0 Then
            msSQL += "AND 分類名 = '" + cmb分類.SelectedItem.ToString() + "' "
        End If
        If cmb部門.SelectedIndex > 0 Then
            msSQL += "AND 部門名 = '" + cmb部門.SelectedItem.ToString() + "' "
        End If
        If txt検索カナ.TextLength > 0 Then
            '    ''txt検索カナに入力した文字を結合したテーブルから検索したい
            msSQL += "AND 検索カナ LIKE '%" + txt検索カナ.Text + "%' "
            'msSQL += "OR "
            'If cmb分類.SelectedIndex > 0 And cmb部門.SelectedIndex > 0 And txt検索カナ.TextLength >= 1 Then
            '    msSQL += "品目名 = '" + cmb分類.SelectedItem.ToString() + "' "
            '    msSQL += "AND 部門名 = '" + cmb部門.SelectedItem.ToString() + "' "
            '    msSQL += "AND 品目名 LIKE '%" + txt検索カナ.Text + "%'"
            'End If
        End If
        If txtJANコード.TextLength > 0 Then
            msSQL += "AND JANCD1 = '" + txtJANコード.Text + "'"
        End If
        '-------------------------------------------------------------------------------------------------------------------------
        '=========================================================================================================================
        'Else
        ''    ''テーブルを結合して、dgv一覧の ｜部門｜検索カナ｜商品名｜ に表示
        ''    msSQL = "Select b.部門名 As 部門,a.検索カナ,a.品目名 As 商品名 "
        ''    msSQL += "From POS_M品目 As a, POS_M部門 As b "
        ''    msSQL += "Where a.部門CD = b.部門CD "
        ''    msSQL += "Order By a.商品CD"


        ''    mCommand = cDB.getsqlComand(msSQL)
        ''    mSDA.SelectCommand = mCommand

        ''    Call mSDA.Fill(tblComboList)

        ''    dgv一覧.DataSource = tblComboList

        ''    Call cDB.Close()
        'End If
        '=========================================================================================================================
        '-------------------------------------------------------------------------------------------------------------------------
        msSQL += "Order By a.部門CD + a.検索カナ"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(tblComboList)

        dgv検索一覧.DataSource = tblComboList

        Call cDB.Close()
        '-------------------------------------------------------------------------------------------------------------------------
        If tblComboList.Rows.Count = 0 Then
            MessageBox.Show("検索結果はゼロです", "検索結果", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

    End Sub


    'JANコードに表示・・・数字のみ
    Private Sub btn１_Click(sender As Object, e As EventArgs) Handles btn０.Click, btn１.Click, btn２.Click, btn３.Click,
        btn４.Click, btn５.Click, btn６.Click, btn７.Click, btn８.Click, btn９.Click

        txtJANコード.Text = txtJANコード.Text + sender.text
    End Sub
    Private Sub txtJANコード_TextChanged(sender As Object, e As EventArgs) Handles txtJANコード.TextChanged
        '入力文字数を13桁に制限
        txtJANコード.MaxLength = 13
    End Sub

    Private Sub btn英字_Click(sender As Object, e As EventArgs) Handles btn英字.Click
        If grp英字.Visible = False Then
            grp英字.Visible = True
            grpカナ.Visible = False
        Else
            grp英字.Visible = True
        End If
    End Sub

    Private Sub btnカナ_Click(sender As Object, e As EventArgs) Handles btnカナ.Click
        If grpカナ.Visible = False Then
            grpカナ.Visible = True
            grp英字.Visible = False
        Else
            grpカナ.Visible = True
        End If

    End Sub

    Private Sub btn全消_Click(sender As Object, e As EventArgs) Handles btn全消.Click
        txt検索カナ.Text = ""
        txtJANコード.Text = ""

    End Sub


    'Private Sub btn選択_Click(sender As Object, e As EventArgs) Handles btn選択.Click
    '    If btn選択.ForeColor = Color.Black Then
    '    Else
    '        Dim sfrm As New frm●●●
    '        Call sfrm.ShowDialog()
    '    End If

    'End Sub

    '-------------条件クリアボタンを追加したほうが使いやすい？------------

    'Private Sub btn条件クリア_Click(sender As Object, e As EventArgs) Handles btn条件クリア.Click
    '    Dim cDB As New clsDB
    '    Dim msSQL As String
    '    Dim tblComboList As New DataTable

    '    ''テーブルを結合して、dgv一覧の ｜部門｜検索カナ｜商品名｜ に表示
    '    msSQL = "Select b.部門名 As 部門,a.検索カナ,a.品目名 As 商品名 "
    '    msSQL += "From M品目 As a, M部門 As b "
    '    msSQL += "Where a.部門CD = b.部門CD "
    '    msSQL += "Order By a.商品CD"

    '    mCommand = cDB.getsqlComand(msSQL)
    '    mSDA.SelectCommand = mCommand

    '    Call mSDA.Fill(tblComboList)

    '    dgv検索一覧.DataSource = tblComboList

    '    Call cDB.Close()
    '    '-------------------------------------------------------------------------------------------------------------------------
    '    cmb分類.SelectedIndex = 0
    '    cmb部門.SelectedIndex = 0
    '    txt検索カナ.Text = ""
    '    txtJANコード.Text = ""

    '    ''btnのテキスト色を変更
    '    'btn選択.ForeColor = Color.Gray
    '    'btn条件クリア.ForeColor = Color.Gray

    '    ''btnの無効化
    '    btn選択.Enabled = False
    '    'btn条件クリア.Enabled = False

    '    ''dgvの内容をクリアする
    '    'dgv一覧.DataSource = ""

    'End Sub


    'Private Sub dgv一覧_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv一覧.CellContentDoubleClick
    '    Dim sfrm As New frm●●●●
    '    Call sfrm.ShowDialog()

    'End Sub


End Class