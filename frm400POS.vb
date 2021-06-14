

Public Class frm400POS
    Private dtbl明細 As New DataTable

    Private pro登録ステータス As String = "登録"
    Public Property 登録ステータス() As String
        Get
            Return pro登録ステータス
        End Get
        Set(value As String)
            pro登録ステータス = value
        End Set

    End Property

    Private pro分類頁 As Integer = 1
    Public Property 分類頁() As Integer
        Get
            Return pro分類頁
        End Get
        Set(value As Integer)
            pro分類頁 = value
        End Set

    End Property

    Private Sub frmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tssl時間.Text = Now.ToShortTimeString
        btn登録ステータス.Text = 登録ステータス

        dgv明細.DataSource = dtbl明細
        Call sub明細レイアウト()

        ''ボタンサイズ変更
        btn品目1.Width = btn品目1.Width * 1
        btn品目1.Height = btn品目1.Height * 1

        txt入力.Text = ""

        Call 商品頁表示(Me, pro分類頁)
    End Sub

    ''データテーブルレイアウト
    Private Sub sub明細レイアウト()
        With dtbl明細
            .Columns.Add("No")
            .Columns.Add("JAN")
            .Columns.Add("区分")
            .Columns.Add("取引名")
            .Columns.Add("数量", GetType(Decimal))
            .Columns.Add("単価", GetType(Decimal))
            .Columns.Add("金額", GetType(Decimal))
            .Columns.Add("消費税率", GetType(Decimal))
            .Columns.Add("消費税", GetType(Decimal))

        End With

        ''主キーとなる列名をセット
        Dim colColumn(0) As DataColumn
        colColumn(0) = dtbl明細.Columns("JAN")

        ''主キーにセット
        dtbl明細.CaseSensitive = True ''大文字小文字比較
        dtbl明細.PrimaryKey = colColumn

    End Sub

    ''データテーブル検索
    Private Function row明細行検索(ByVal setJAN As String) As DataRow
        Dim FindData(0) As String
        Dim FindTable As DataTable = dtbl明細

        FindData(0) = setJAN

        ''検索開始
        Return FindTable.Rows.Find(FindData)

    End Function

    Private Sub frmPOS_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Call frm201トップ.Show()

    End Sub

    Private Sub btn終了_Click(sender As Object, e As EventArgs)
        Call Me.Close()

    End Sub

    Private Sub btn数字_Click(sender As Object, e As EventArgs) Handles btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click, btn1.Click, btn000.Click, btn00.Click, btn0.Click
        txt入力.Text += sender.tag
    End Sub

    Private Sub btn登録ステータス_Click(sender As Object, e As EventArgs) Handles btn登録ステータス.Click
        'grb登録ステータス.Visible = True
        Dim sfrm As New sfrmPOS処理
        sfrm.登録ステータス = 登録ステータス
        Call sfrm.ShowDialog()

        登録ステータス = sfrm.登録ステータス
        btn登録ステータス.Text = 登録ステータス
    End Sub

    Private Sub btnメニュー_Click(sender As Object, e As EventArgs) Handles btnメニュー.Click
        'grb登録ステータス.Visible = True
        Dim sfrm As New sfrmPOSメニュー
        Call sfrm.ShowDialog()

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="setJAN">setJAN</param>
    ''' <remarks></remarks>
    Private Sub 品目選択(setJAN As String)
        If setJAN = "" Then Exit Sub

        Dim get商品() As DataRow = 商品検索(setJAN)
        If get商品.Count <= 0 Then
            Exit Sub
        End If

        Dim row明細 As DataRow
        Dim get課税 As DataRow = POS_M課税区分検索(get商品(0)("課税区分"))

        ''合計確認（合計がある場合は、明細クリア）
        row明細 = row明細行検索("GrandoTal")
        If row明細 IsNot Nothing Then
            Call dtbl明細.Clear()
        End If

        row明細 = row明細行検索(setJAN)
        If row明細 Is Nothing Then
            row明細 = dtbl明細.NewRow
            row明細("No") = 0
            row明細("JAN") = setJAN
            row明細("区分") = "取引"
            row明細("取引名") = get商品(0)("品目名")
            row明細("数量") = 1
            row明細("単価") = get商品(0)("取引単価")
            row明細("金額") = row明細("数量") * row明細("単価")
            row明細("消費税率") = get課税("税率") / 100
            row明細("消費税") = (row明細("金額") / (1 + row明細("消費税率"))) * row明細("消費税率")
            dtbl明細.Rows.Add(row明細) '行の追加
        Else
            row明細("数量") += 1
            row明細("金額") = row明細("数量") * row明細("単価")
            row明細("消費税") = (row明細("金額") / (1 + row明細("消費税率"))) * row明細("消費税率")

        End If

        Call 明細処理()
    End Sub

    Private Sub btn品目選択_Click(sender As Object, e As EventArgs) Handles btn品目1.Click, btn品目2.Click, btn品目3.Click, btn品目4.Click, btn品目5.Click, btn品目6.Click, _
                                                                            btn品目7.Click, btn品目8.Click, btn品目9.Click, btn品目10.Click, btn品目11.Click, btn品目12.Click, _
                                                                            btn品目13.Click, btn品目14.Click, btn品目15.Click, btn品目16.Click, btn品目17.Click, btn品目18.Click, _
                                                                            btn品目19.Click, btn品目20.Click, btn品目21.Click, btn品目22.Click, btn品目23.Click, btn品目24.Click, _
                                                                            btn品目25.Click, btn品目26.Click, btn品目27.Click, btn品目28.Click, btn品目29.Click, btn品目30.Click, _
                                                                            btn品目31.Click, btn品目32.Click, btn品目33.Click, btn品目34.Click, btn品目35.Click, btn品目36.Click
        Call 品目選択(sender.tag)
        txt入力.Text = ""
    End Sub

    Private Sub 明細処理()
        ''小計削除
        Dim row明細 As DataRow
        row明細 = row明細行検索("SubTotal")
        If row明細 IsNot Nothing Then Call dtbl明細.Rows.Remove(row明細) ''行削除

        ''No連番設定
        Dim n連番 As Integer = 1
        Dim n合計金額 As Integer = 0
        For Each get行 As DataRow In dtbl明細.Rows
            get行("No") = n連番

            dgv明細.Rows(n連番 - 1).Selected = False
            n合計金額 += CInt(get行("金額"))
            n連番 += 1
        Next

        ''最終行を表示
        dgv明細.FirstDisplayedScrollingRowIndex = dgv明細.RowCount - 1
    End Sub

    Private Sub btn個_Click(sender As Object, e As EventArgs) Handles btn個.Click
        Dim row明細 As DataRow

        For Each get行 As DataGridViewRow In dgv明細.SelectedRows
            row明細 = row明細行検索(dtbl明細(get行.Index)("JAN"))

            If txt入力.Text = "" Then
                row明細("数量") += 1
            Else
                row明細("数量") = CInt(txt入力.Text)
            End If

            row明細("金額") = row明細("数量") * row明細("単価")
            row明細("消費税") = row明細("金額") * row明細("消費税率")
        Next

        txt入力.Text = ""

        Call 明細処理()
    End Sub

    Private Sub btn小計_Click(sender As Object, e As EventArgs) Handles btn小計.Click
        If dgv明細.Rows.Count <= 0 Then Exit Sub
        Dim sfrm As New frm401POS預り
        sfrm.明細 = dtbl明細
        Call sfrm.ShowDialog()

        dgv明細.FirstDisplayedScrollingRowIndex = dgv明細.Rows.Count - 1
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txt入力.Text = ""

    End Sub

    Private Sub btn指定取消_Click(sender As Object, e As EventArgs) Handles btn指定取消.Click
        Dim row明細 As DataRow

        For Each get行 As DataGridViewRow In dgv明細.SelectedRows
            row明細 = row明細行検索(dtbl明細(get行.Index)("JAN"))
            dtbl明細.Rows.Remove(row明細)

        Next
    End Sub

    Private Sub btn下_Click(sender As Object, e As EventArgs) Handles btn下.Click
        If dgv明細.FirstDisplayedScrollingRowIndex < 0 Then Exit Sub
        If dgv明細.FirstDisplayedScrollingRowIndex = dgv明細.RowCount - 1 Then Exit Sub

        dgv明細.FirstDisplayedScrollingRowIndex += 1
    End Sub

    Private Sub btn上_Click(sender As Object, e As EventArgs) Handles btn上.Click
        If dgv明細.FirstDisplayedScrollingRowIndex <= 0 Then Exit Sub

        dgv明細.FirstDisplayedScrollingRowIndex -= 1
    End Sub

    Private Sub btn頁選択_Click(sender As Object, e As EventArgs) Handles btnBB.Click, btnB.Click, btnN.Click, btnNN.Click

        Select Case sender.name
            Case "btnBB"
                pro分類頁 = 1
            Case "btnB"
                If pro分類頁 <= 1 Then Exit Select
                pro分類頁 -= 1
            Case "btnN"
                If pro分類頁 >= 37 Then Exit Select
                pro分類頁 += 1
            Case "btnNN"
                pro分類頁 = 37
            Case Else

        End Select

        Call 商品頁表示(Me, pro分類頁)
    End Sub


    Private Sub btn分類_Click(sender As Object, e As EventArgs) Handles btn分類1.Click, btn分類2.Click, btn分類3.Click, btn分類4.Click
        Call 商品表示(Me, sender.tag)

    End Sub

    Private Sub frmPOS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If (e.Handled = False And _
           txt入力.Focused = False) Then
            'e.KeyChar >= "a" And _
            'e.KeyChar <= "z"

            Call txt入力.Focus()
            txt入力.AppendText(e.KeyChar.ToString())

            e.Handled = True
        End If
    End Sub

    Private Sub txt入力_KeyDown(sender As Object, e As KeyEventArgs) Handles txt入力.KeyDown
        If e.KeyCode = Keys.Enter Then
            品目選択(txt入力.Text)
            txt入力.Text = ""

        End If
    End Sub

    Private Sub btnJAN_Click(sender As Object, e As EventArgs) Handles btnJAN.Click
        '品目選択(txt入力.Text)
        'txt入力.Text = ""
        Dim sfrm As New frm403JAN商品検索
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn領収_Click(sender As Object, e As EventArgs) Handles btn領収.Click
        Dim sfrm As New frm404領収書印刷
        Call sfrm.ShowDialog()
    End Sub
End Class