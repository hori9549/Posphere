Public Class frm201トップ
    Private Shared _mutex As System.Threading.Mutex

    Private Sub frmトップvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ''多重起動禁止========================================================
            _mutex = New System.Threading.Mutex(False, Application.ProductName)

            If _mutex.WaitOne(0, False) = False Then
                MessageBox.Show("多重起動はできません。")
                Call Application.Exit()
            End If
            ''====================================================================
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try
        lblバージョン.Text = "Ver" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()

        ''データ取得
        Call POS_M課税区分取得()
        Call POS_M品目取得()
        Call POS_M分類取得()
        Call POS_M頁取得(3, 1)
        Call POS_M品目ボタン設定取得(3, 1)

        'Dim sfrm As New sfrmパスワード
        'sfrm.遷移フォーム = frmPOS
        'sfrm.パスワード = "1"

        'If sfrm.遷移フォーム Is Nothing Then
        '    Call Application.Exit()
        'Else
        '    Call sfrm.ShowDialog()
        '    Me.Hide()

        'End If
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click
        txtパスワード.Text += sender.text
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txtパスワード.Text = ""
    End Sub

    Private Sub btn終了_Click(sender As Object, e As EventArgs) Handles btn終了.Click
        Call Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtパスワード.Text = "1" Then
            frm400POS.Show()
            txtパスワード.Text = ""
            Me.Visible = False
        Else
            MessageBox.Show("パスワード認証に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnバージョン情報_Click(sender As Object, e As EventArgs) Handles btnバージョン情報.Click
        Dim sfrm As New frm301バージョン情報
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btnマスタ反映_Click(sender As Object, e As EventArgs) Handles btnマスタ反映.Click
        Dim sfrm As New frm817マスタ反映
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn転送開始_Click(sender As Object, e As EventArgs) Handles btn転送開始.Click

    End Sub

    Private Sub btnFTP転送終了_Click(sender As Object, e As EventArgs) Handles btnFTP転送終了.Click

    End Sub

    Private Sub btn5A_Click(sender As Object, e As EventArgs) Handles btn5A.Click

    End Sub

    Private Sub btn6B_Click(sender As Object, e As EventArgs) Handles btn6B.Click

    End Sub

    Private Sub btn7C_Click(sender As Object, e As EventArgs) Handles btn7C.Click

    End Sub

    Private Sub btnEXE設定_Click(sender As Object, e As EventArgs) Handles btnEXE設定.Click
        Dim sfrm As New frm305EXE設定
        Call sfrm.ShowDialog()
    End Sub
End Class