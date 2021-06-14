Public Class frm401POS預り
    Private myVideo As New clsVideo
    Private dtbl明細 As New DataTable
    Private n合計件数 As Integer
    Private n合計金額 As Decimal
    Private n現金預り As Decimal
    Private n現金以外 As Decimal
    Private n差引 As Decimal
    Private nつり銭 As Decimal
    Private n消費税8 As Decimal
    Private n消費税10 As Decimal

    Public WriteOnly Property 明細() As DataTable
        Set(value As DataTable)
            dtbl明細 = value
        End Set

    End Property

    Private Sub sfrmPOSメニュー_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt入力.Text = ""
        dgv明細.DataSource = dtbl明細

        Call 明細処理()
    End Sub


    ''データテーブル検索
    Private Function row明細行検索(ByVal setJAN As String) As DataRow

        Dim FindData(0) As String
        Dim FindTable As DataTable = dtbl明細

        FindData(0) = setJAN

        ''検索開始
        Return FindTable.Rows.Find(FindData)

    End Function

    Private Sub 明細処理()
        Dim sum合計件数 As Integer = 0
        Dim sum合計金額 As Decimal = 0
        Dim sum現金預り As Decimal = 0
        Dim sum現金以外 As Decimal = 0
        Dim sum差引 As Decimal = 0
        Dim sumつり銭 As Decimal = 0
        Dim sum消費税8 As Decimal = 0
        Dim sum消費税10 As Decimal = 0

        Dim row明細 As DataRow
        ''合計確認（合計がある場合は、明細クリア）
        row明細 = row明細行検索("GrandoTal")
        If row明細 IsNot Nothing Then

        End If


        ''小計削除
        row明細 = row明細行検索("SubTotal")
        If row明細 IsNot Nothing Then Call dtbl明細.Rows.Remove(row明細) ''行削除

        ''No連番設定
        Dim n連番 As Integer = 1
        For Each get行 As DataRow In dtbl明細.Rows
            get行("No") = n連番

            dgv明細.Rows(n連番 - 1).Selected = False
            sum合計件数 += CLng(get行("数量"))
            sum合計金額 += CLng(get行("金額"))
            Select Case get行("消費税率")
                Case 0.08 : sum消費税8 += CInt(get行("消費税"))
                Case 0.1 : sum消費税10 += CInt(get行("消費税"))

            End Select

            n連番 += 1
        Next


        ''消費税行追加
        If sum消費税8 <> 0 Then
            row明細 = dtbl明細.NewRow
            row明細("No") = ""
            row明細("JAN") = "Tax8"
            row明細("区分") = ""
            row明細("取引名") = "　－ 消費税 8％ －"
            row明細("数量") = 0
            row明細("単価") = 0
            row明細("金額") = sum消費税8
            row明細("消費税率") = 0
            row明細("消費税") = 0
            dtbl明細.Rows.Add(row明細) '行の追加
        End If

        If sum消費税10 <> 0 Then
            row明細 = dtbl明細.NewRow
            row明細("No") = ""
            row明細("JAN") = "Tax10"
            row明細("区分") = ""
            row明細("取引名") = "　－ 消費税10％ －"
            row明細("数量") = 0
            row明細("単価") = 0
            row明細("金額") = sum消費税10
            row明細("消費税率") = 0
            row明細("消費税") = 0
            dtbl明細.Rows.Add(row明細) '行の追加
        End If

        ''小計
        ''行追加
        row明細 = dtbl明細.NewRow
        row明細("No") = ""
        row明細("JAN") = "SubTotal"
        row明細("区分") = ""
        row明細("取引名") = "　－ 小　　　計 －"
        row明細("数量") = 0
        row明細("単価") = 0
        row明細("金額") = sum合計金額
        row明細("消費税率") = 0
        row明細("消費税") = sum消費税8 + sum消費税10
        dtbl明細.Rows.Add(row明細) '行の追加


        ''プロパティ設定
        n合計件数 = sum合計件数
        n合計金額 = sum合計金額
        n現金預り = 0
        n現金以外 = 0
        n差引 = 0
        nつり銭 = 0
        n消費税8 = sum消費税8
        n消費税10 = sum消費税10

        ''表示
        txt合計数量.Text = n合計件数
        txt合計金額.Text = n合計金額
        txt現金預り.Text = 0
        txt現金以外.Text = 0
        txt差引.Text = 0
        txtつり銭.Text = 0
        txt消費税8.Text = n消費税8
        txt消費税10.Text = n消費税10

        ''
        'dgv明細.Rows(dtbl明細.Rows.Count - 1).Selected = True
        dgv明細.FirstDisplayedScrollingRowIndex = dgv明細.RowCount - 1
    End Sub

    Private Sub btn終了_Click(sender As Object, e As EventArgs)
        frm400POS.登録ステータス = "終了"
        Call frm400POS.Close()
    End Sub

    Private Sub btn閉じる_Click(sender As Object, e As EventArgs) Handles btn閉じる.Click
        Dim row明細 As DataRow

        row明細 = row明細行検索("SubTotal")
        dtbl明細.Rows.Remove(row明細)

        row明細 = row明細行検索("Tax8")
        If Not row明細 Is Nothing Then dtbl明細.Rows.Remove(row明細)

        row明細 = row明細行検索("Tax10")
        If Not row明細 Is Nothing Then dtbl明細.Rows.Remove(row明細)

        row明細 = row明細行検索("GrandoTal")
        If Not row明細 Is Nothing Then dtbl明細.Rows.Remove(row明細)

        row明細 = row明細行検索("Deposit")
        If Not row明細 Is Nothing Then dtbl明細.Rows.Remove(row明細)

        row明細 = row明細行検索("Change")
        If Not row明細 Is Nothing Then dtbl明細.Rows.Remove(row明細)

        Call Me.Close()
    End Sub

    Private Sub btn千円預り_Click(sender As Object, e As EventArgs) Handles btn千円預り.Click
        If txt入力.Text = "" Then
            txt入力.Text = 1000
        Else
            txt入力.Text = CInt(txt入力.Text) + 1000
        End If

    End Sub

    Private Sub btn万円預り_Click(sender As Object, e As EventArgs) Handles btn万円預り.Click
        If txt入力.Text = "" Then
            txt入力.Text = 10000
        Else
            txt入力.Text = CInt(txt入力.Text) + 10000
        End If

    End Sub

    Private Sub btn現預_Click(sender As Object, e As EventArgs) Handles btn現預.Click
        Call myVideo.画像撮影(1)

        With txt入力
            Select Case .Text
                Case ""
                    MessageBox.Show("預り金額がありません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub

                Case Else
                    If .Text.Length > 9 Then
                        MessageBox.Show("取扱金額がオーバーしています。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
            End Select
        End With


        n現金預り = CLng(txt入力.Text)

        If n現金預り < n合計金額 Then
            MessageBox.Show("預り金額が足りません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        nつり銭 = n現金預り - n合計金額

        ''預り金削除
        Dim row明細 As DataRow
        'row明細 = row明細行検索("Tax8")
        'If row明細 IsNot Nothing Then Call dtbl明細.Rows.Remove(row明細)
        'row明細 = row明細行検索("Tax10")
        'If row明細 IsNot Nothing Then Call dtbl明細.Rows.Remove(row明細)
        row明細 = row明細行検索("GrandoTal")
        If row明細 IsNot Nothing Then Call dtbl明細.Rows.Remove(row明細) ''行削除
        row明細 = row明細行検索("Deposit")
        If row明細 IsNot Nothing Then Call dtbl明細.Rows.Remove(row明細) ''行削除
        row明細 = row明細行検索("Change")
        If row明細 IsNot Nothing Then Call dtbl明細.Rows.Remove(row明細) ''行削除

        ''合計
        row明細 = dtbl明細.NewRow
        row明細("No") = ""
        row明細("JAN") = "GrandoTal"
        row明細("区分") = ""
        row明細("取引名") = "　－ 合　　　計 －"
        row明細("数量") = n合計件数
        row明細("単価") = 0
        row明細("金額") = n合計金額
        row明細("消費税率") = 0
        row明細("消費税") = 0
        dtbl明細.Rows.Add(row明細) '行の追加

        ''預かり
        row明細 = dtbl明細.NewRow
        row明細("No") = ""
        row明細("JAN") = "Deposit"
        row明細("区分") = ""
        row明細("取引名") = "　－ お　預　り －"
        row明細("数量") = 0
        row明細("単価") = 0
        row明細("金額") = CLng(txt入力.Text)
        row明細("消費税率") = 0
        row明細("消費税") = 0
        dtbl明細.Rows.Add(row明細) '行の追加

        ''お釣り
        row明細 = dtbl明細.NewRow
        row明細("No") = ""
        row明細("JAN") = "Change"
        row明細("区分") = ""
        row明細("取引名") = "　－ お　釣　り －"
        row明細("数量") = 0
        row明細("単価") = 0
        row明細("金額") = nつり銭
        row明細("消費税率") = 0
        row明細("消費税") = 0
        dtbl明細.Rows.Add(row明細) '行の追加

        ''表示
        txt合計数量.Text = n合計件数.ToString("#,0")
        txt合計金額.Text = n合計金額.ToString("#,0")
        txt現金預り.Text = n現金預り.ToString("#,0")
        txt現金以外.Text = n現金以外.ToString("#,0")
        txt差引.Text = n差引.ToString("#,0")
        txtつり銭.Text = nつり銭.ToString("#,0")
        txt消費税8.Text = n消費税8.ToString("#,0")
        txt消費税10.Text = n消費税10.ToString("#,0")

        Call Me.Close()
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txt入力.Text = ""
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

    Private Sub btn数字_Click(sender As Object, e As EventArgs) Handles btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click, btn1.Click, btn000.Click, btn00.Click, btn0.Click
        If txt入力.TextLength > 13 Then Exit Sub

        txt入力.Text += sender.tag
    End Sub

    Private Sub btn小計_Click(sender As Object, e As EventArgs) Handles btn小計.Click

    End Sub
End Class