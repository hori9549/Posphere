'20191203漆谷

Imports System.Data
Imports System.Data.SqlClient

Public Class frm805店舗情報登録

    Private ini As clsINI = New clsINI("設定.ini")

    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Public cmb_M店舗_SelectedIndex As Integer
    Private Sub frm店舗基本情報_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim tdTable As New DataTable '端末テーブルをtdTableという変数名にセットした
        Dim nCmbselectIndex As Integer = -1

        'データベースから取得したいデータ群をSQLで検索
        msSQL = ""
        msSQL += "SELECT * "
        msSQL += "FROM M店舗"


        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(tdTable) ''検索してきたデータをセット

        txt店舗CD.Text = tdTable.Rows(0).Item("店舗CD").ToString()
        txt店舗名.Text = tdTable.Rows(0).Item("店舗名").ToString()
        txt郵便1.Text = tdTable.Rows(0).Item("郵便1").ToString()
        txt郵便2.Text = tdTable.Rows(0).Item("郵便2").ToString()
        txt住所1.Text = tdTable.Rows(0).Item("住所1").ToString()
        txt住所2.Text = tdTable.Rows(0).Item("住所2").ToString()
        txt電話.Text = tdTable.Rows(0).Item("TEL").ToString()
        txtFAX.Text = tdTable.Rows(0).Item("FAX").ToString()
        txt会社名.Text = tdTable.Rows(0).Item("会社名").ToString()
        txt代表者.Text = tdTable.Rows(0).Item("代表者").ToString()

        '------------------------------------------------------------
        'INIファイルからデータを取得

        Dim bParseResult As Boolean
        Dim strIniData As String

        ''その他基本情報

        txtデータ保存月数.Text = ini.GetProfileString("端末", "データ保存月数", "")


        strIniData = ini.GetProfileString("端末", "担当入力", "1")
        bParseResult = Integer.TryParse(strIniData, cmb担当入力.SelectedIndex)
        If bParseResult = False Then
            cmb担当入力.SelectedIndex = 1
        End If


        strIniData = ini.GetProfileString("端末", "客層入力", "2")
        bParseResult = Integer.TryParse(strIniData, cmb客層入力.SelectedIndex)
        If bParseResult = False Then
            cmb客層入力.SelectedIndex = 2
        End If

        strIniData = ini.GetProfileString("端末", "客数入力", "0")
        bParseResult = Integer.TryParse(strIniData, cmb人数入力.SelectedIndex)
        If bParseResult = False Then
            cmb人数入力.SelectedIndex = 0
        End If

        strIniData = ini.GetProfileString("端末", "ゼロ単価", "0")
        bParseResult = Integer.TryParse(strIniData, cmbゼロ単価.SelectedIndex)
        If bParseResult = False Then
            cmbゼロ単価.SelectedIndex = 0
        End If

        txt人数制限.Text = ini.GetProfileString("端末", "人数制限", "")
        txt明細数制限.Text = ini.GetProfileString("端末", "明細数制限", "")



        strIniData = ini.GetProfileString("端末", "指定取消", "NO")
        If strIniData = "YES" Then
            cmb指定取消.SelectedIndex = 0
        Else
            cmb指定取消.SelectedIndex = 1
        End If

        strIniData = ini.GetProfileString("端末", "消費税端数", "0")
        bParseResult = Integer.TryParse(strIniData, cmb消費税端数.SelectedIndex)
        If bParseResult = False Then
            cmb消費税端数.SelectedIndex = 0
        End If

        '--------------------------------------------------------------------
        ''預かり金入力設定

        strIniData = ini.GetProfileString("端末", "預かり投入", "0")
        bParseResult = Integer.TryParse(strIniData, cmb現金.SelectedIndex)
        If bParseResult = False Then
            cmb現金.SelectedIndex = 0
        End If


        strIniData = ini.GetProfileString("端末", "その他省略", "YES")
        If strIniData = "NO" Then
            cmb現金以外.SelectedIndex = 0
        Else
            cmb現金以外.SelectedIndex = 1
        End If

        strIniData = ini.GetProfileString("端末", "釣銭準備金", "0")
        bParseResult = Integer.TryParse(strIniData, cmb釣銭準備金.SelectedIndex)
        If bParseResult = False Then
            cmb釣銭準備金.SelectedIndex = 0
        End If

        txt釣銭機残値.Text = ini.GetProfileString("端末", "釣銭機残値", "")

        '---------------------------------------------------------------------------------
        ''DB情報

        txtBKUP複写先フォルダ１.Text = ini.GetProfileString("端末", "BACKUP_DEF", "")
        txtBKUP複写先フォルダ２.Text = ini.GetProfileString("端末", "BACKUP", "")
        txtDBサイズ警告上限値.Text = ini.GetProfileString("端末", "CHKSIZ", "")

        '---------------------------------------------------------------------------------
        ''バーコード設定
        strIniData = ini.GetProfileString("端末", "BARCODE20", "NO")
        If strIniData = "YES" Then
            cmb単価付バーコード.SelectedIndex = 0
        Else
            cmb単価付バーコード.SelectedIndex = 1
        End If


        strIniData = ini.GetProfileString("端末", "BARCODE978", "YES")
        If strIniData = "YES" Then
            cmb書籍バーコード.SelectedIndex = 0
        Else
            cmb書籍バーコード.SelectedIndex = 1
        End If


        strIniData = ini.GetProfileString("端末", "BARCODE491", "YES")
        If strIniData = "YES" Then
            cmb雑誌バーコード.SelectedIndex = 0
        Else
            cmb雑誌バーコード.SelectedIndex = 1
        End If


        '---------------------------------------------------------------------------------
        ''画面文字サイズ設定
        strIniData = ini.GetProfileString("端末", "メニュー文字", "通常")
        If strIniData = "通常" Then
            cmbメニュー文字.SelectedIndex = 0
        Else
            cmbメニュー文字.SelectedIndex = 1
        End If


        strIniData = ini.GetProfileString("端末", "会計明細文字", "通常")
        If strIniData = "通常" Then
            cmb会計明細文字.SelectedIndex = 0
        Else
            cmb会計明細文字.SelectedIndex = 1
        End If

        '----------------------------------------------------------------------
        ''その他設定
        strIniData = ini.GetProfileString("SEISAN", "INPCHK", "YES")
        If strIniData = "YES" Then
            cmb金種表入力ﾁｪｯｸ.SelectedIndex = 0
        Else
            cmb金種表入力ﾁｪｯｸ.SelectedIndex = 1
        End If

        strIniData = ini.GetProfileString("page", "MODE", "0")
        bParseResult = Integer.TryParse(strIniData, cmbページタグ数.SelectedIndex)
        If bParseResult = False Then
            cmbページタグ数.SelectedIndex = 0
        End If

        '---------------------------------------------------------------------
        ''販売モードとテイクアウト
        strIniData = ini.GetProfileString("TO", "起動MODE", "1")
        bParseResult = Integer.TryParse(strIniData, cmb初期モード.SelectedIndex)
        If bParseResult = False Then
            cmb初期モード.SelectedIndex = 1
        End If

        strIniData = ini.GetProfileString("TO", "操作MODE", "1")
        bParseResult = Integer.TryParse(strIniData, cmbモードリセット.SelectedIndex)
        If bParseResult = False Then
            cmbモードリセット.SelectedIndex = 1
        End If

        Call cDB.Close()
    End Sub

    Private Sub tabレシート領収レポート_Click(sender As Object, e As EventArgs) Handles tabレシート領収レポート.Click, tabc店舗基本情報.SelectedIndexChanged

        ''レシート情報
        Dim bParseResult As Boolean
        Dim strIniData As String

        strIniData = ini.GetProfileString("receipt", "COPY", "0")
        bParseResult = Integer.TryParse(strIniData, cmbl控発行.SelectedIndex)
        If bParseResult = False Then
            cmbl控発行.SelectedIndex = 0
        End If

        strIniData = ini.GetProfileString("receipt", "宣伝文印刷", "NO")
        If strIniData = "YES" Then
            cmb宣伝文印刷.SelectedIndex = 0
        Else
            cmb宣伝文印刷.SelectedIndex = 1
        End If

        txt宣伝文1.Text = ini.GetProfileString("receipt", "宣伝文1", "")
        txt宣伝文2.Text = ini.GetProfileString("receipt", "宣伝文2", "")
        txt宣伝文3.Text = ini.GetProfileString("receipt", "宣伝文3", "")

        strIniData = ini.GetProfileString("receipt", "LOGO", "1")
        bParseResult = Integer.TryParse(strIniData, cmb末尾ロゴ印刷.SelectedIndex)
        If bParseResult = False Then
            cmb末尾ロゴ印刷.SelectedIndex = 1
        End If

        txt末尾ロゴ印刷.Text = ini.GetProfileString("receipt", "KING", "0")

        strIniData = ini.GetProfileString("receipt", "レシート税印字", "1")
        bParseResult = Integer.TryParse(strIniData, cmb税額内訳印刷.SelectedIndex)
        If bParseResult = False Then
            cmb税額内訳印刷.SelectedIndex = 1
        End If

        strIniData = ini.GetProfileString("receipt", "レシートコード印字", "1")
        bParseResult = Integer.TryParse(strIniData, cmbJANコード印刷.SelectedIndex)
        If bParseResult = False Then
            cmbJANコード印刷.SelectedIndex = 1
        End If


        strIniData = ini.GetProfileString("receipt", "レシートNO", "1")
        bParseResult = Integer.TryParse(strIniData, cmbレシートNO.SelectedIndex)
        If bParseResult = False Then
            cmbレシートNO.SelectedIndex = 1
        End If

        strIniData = ini.GetProfileString("receipt", "取引名印字", "2")
        bParseResult = Integer.TryParse(strIniData, cmb取引名印字文字サイズ.SelectedIndex)
        If bParseResult = False Then
            cmb取引名印字文字サイズ.SelectedIndex = 2
        End If


        txtタイトル.Text = ini.GetProfileString("receipt", "タイトル", "")

        strIniData = ini.GetProfileString("receipt", "合計点数印字", "1")
        bParseResult = Integer.TryParse(strIniData, cmb合計点数印字.SelectedIndex)
        If bParseResult = False Then
            cmb合計点数印字.SelectedIndex = 1
        End If

        strIniData = ini.GetProfileString("receipt", "クーポンカット", "0")
        bParseResult = Integer.TryParse(strIniData, cmbクーポンカット.SelectedIndex)
        If bParseResult = False Then
            cmbクーポンカット.SelectedIndex = 0
        End If

        '------------------------------------------------------------------------------
        ''領収情報

        strIniData = ini.GetProfileString("領収", "領収名", "領収書")
        If strIniData = "領収書" Then
            cmb領収名.SelectedIndex = 0
        Else
            cmb領収名.SelectedIndex = 1
        End If

        txt領収但し書き.Text = ini.GetProfileString("領収", "但し書き", "")

        strIniData = ini.GetProfileString("領収", "収入印紙印字", "YES")
        If strIniData = "YES" Then
            cmb収入印紙枠印刷.SelectedIndex = 0
        Else
            cmb収入印紙枠印刷.SelectedIndex = 1
        End If

        txt備考.Text = ini.GetProfileString("領収", "収入印紙備考", "")

        '---------------------------------------------------------------
        ''点検・精算レポート
        strIniData = ini.GetProfileString("REPORTS", "客数", "1")
        bParseResult = Integer.TryParse(strIniData, cmb客数印字.SelectedIndex)
        If bParseResult = False Then
            cmb客数印字.SelectedIndex = 0
        End If

        strIniData = ini.GetProfileString("REPORTS", "組人数内訳", "1")
        bParseResult = Integer.TryParse(strIniData, cmb組人数内訳印字.SelectedIndex)
        If bParseResult = False Then
            cmb組人数内訳印字.SelectedIndex = 1
        End If

        strIniData = ini.GetProfileString("REPORTS", "返品訂正", "1")
        bParseResult = Integer.TryParse(strIniData, cmb返品訂正集計印字.SelectedIndex)
        If bParseResult = False Then
            cmb客数印字.SelectedIndex = 0
        End If

        strIniData = ini.GetProfileString("REPORTS", "０件明細印刷_時間帯", "YES")
        If strIniData = "YES" Then
            cmb時間帯0件明細印字.SelectedIndex = 0
        Else
            cmb時間帯0件明細印字.SelectedIndex = 1
        End If

        strIniData = ini.GetProfileString("REPORTS", "０件明細印刷_客層", "YES")
        If strIniData = "YES" Then
            cmb客層0件明細印字.SelectedIndex = 0
        Else
            cmb客層0件明細印字.SelectedIndex = 1
        End If

    End Sub
    Private Sub tabFTPインポート_Click(sender As Object, e As EventArgs) Handles tabFTPインポート.Click, tabc店舗基本情報.SelectedIndexChanged

        Dim bParseResult As Boolean
        Dim strIniData As String

        'FTP設定
        strIniData = ini.GetProfileString("FTP", "MODE", "1")
        bParseResult = Integer.TryParse(strIniData, cmb使用区分.SelectedIndex)
        If bParseResult = False Then
            cmb使用区分.SelectedIndex = 1
        End If

        txt接続先.Text = ini.GetProfileString("FTP", "DOMAIN", "")
        txt送受信間隔.Text = ini.GetProfileString("FTP", "TIMMER", "")
        txtタイムアウト.Text = ini.GetProfileString("FTP", "TIMEOUT", "")

        ''送信時設定
        txt送信時ユーザー名.Text = ini.GetProfileString("FTP", "送信USER", "")
        txt送信時パスワード.Text = ini.GetProfileString("FTP", "送信PASS", "")
        txt送信時パスワード.PasswordChar = "*"c
        txt送信時対象ファイル種類.Text = ini.GetProfileString("FTP", "送信フィルタ", "")
        txt送信先サーバフォルダ.Text = ini.GetProfileString("FTP", "送信サーバーフォルダ", "/")

        strIniData = ini.GetProfileString("FTP", "送信モード", "1")
        bParseResult = Integer.TryParse(strIniData, cmb送信モード.SelectedIndex)
        If bParseResult = False Then
            cmb送信モード.SelectedIndex = 1
        End If


        ''受信時設定
        txt受信時ユーザー名.Text = ini.GetProfileString("FTP", "受信USER", "")
        txt受信時パスワード.Text = ini.GetProfileString("FTP", "受信PASS", "")
        txt受信時パスワード.PasswordChar = "*"c
        txt受信時対象ファイル種類.Text = ini.GetProfileString("FTP", "受信フィルタ", "")
        txt受信元サーバフォルダ.Text = ini.GetProfileString("FTP", "受信サーバーフォルダ", "")


        'マスタインポート設定
        strIniData = ini.GetProfileString("IMPORTS", "MODE", "1")
        bParseResult = Integer.TryParse(strIniData, cmb自動起動区分.SelectedIndex)
        If bParseResult = False Then
            cmb自動起動区分.SelectedIndex = 1
        End If

        txtCSV格納フォルダ.Text = ini.GetProfileString("IMPORTS", "PATH", "")

    End Sub
    Private Sub btn送信時設定通信確認_Click(sender As Object, e As EventArgs) Handles btn送信時設定通信確認.Click
        MessageBox.Show("接続できません。(CONNECT)", "店舗情報登録", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn受信時設定通信確認_Click(sender As Object, e As EventArgs) Handles btn受信時設定通信確認.Click
        MessageBox.Show("接続できません。(CONNECT)", "店舗情報登録", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn参照_Click(sender As Object, e As EventArgs) Handles btn参照.Click
        Dim fbd As New FolderBrowserDialog
        fbd.Description = "フォルダを指定してください。"
        fbd.RootFolder = Environment.SpecialFolder.Desktop
        fbd.SelectedPath = "C:\Windows"
        fbd.ShowNewFolderButton = True

        If fbd.ShowDialog(Me) = DialogResult.OK Then
            txtCSV格納フォルダ.Text = fbd.SelectedPath
        End If

    End Sub
    Private Sub tabログジャーナル_Click(sender As Object, e As EventArgs) Handles tabログジャーナル.Click, tabc店舗基本情報.SelectedIndexChanged

        Dim bParseResult As Boolean
        Dim strIniData As String
        ''電子ジャーナル出力
        txtフォルダサイズ上限値.Text = ini.GetProfileString("JNL", "CHKSIZ", "")

        '------------------------------------------------------------------------
        ''ジャーナル出力
        strIniData = ini.GetProfileString("一括取消", "MODE", "1")
        bParseResult = Integer.TryParse(strIniData, cmb一括取消の出力.SelectedIndex)
        If bParseResult = False Then
            cmb一括取消の出力.SelectedIndex = 1
        End If


        txt電子ジャーナル出力先フォルダ.Text = ini.GetProfileString("JNL", "PATH", "")

        strIniData = ini.GetProfileString("JOURNAL", "HEAD", "NO")
        If strIniData = "YES" Then
            cmb見出し行.SelectedIndex = 0
        Else
            cmb見出し行.SelectedIndex = 1
        End If

        txtジャーナル出力先フォルダ.Text = ini.GetProfileString("JOURNAL", "PATH", "")

    End Sub
    Private Sub btn電子ジャーナル出力先フォルダ参照_Click(sender As Object, e As EventArgs) Handles btn電子ジャーナル出力先フォルダ参照.Click
        Dim fbd As New FolderBrowserDialog
        fbd.Description = "フォルダを指定してください。"
        fbd.RootFolder = Environment.SpecialFolder.Desktop
        fbd.SelectedPath = "C:\Windows"
        fbd.ShowNewFolderButton = True

        If fbd.ShowDialog(Me) = DialogResult.OK Then
            txt電子ジャーナル出力先フォルダ.Text = fbd.SelectedPath
        End If

    End Sub

    Private Sub btnジャーナル出力先フォルダ参照_Click(sender As Object, e As EventArgs) Handles btnジャーナル出力先フォルダ参照.Click
        Dim fbd As New FolderBrowserDialog
        fbd.Description = "フォルダを指定してください。"
        fbd.RootFolder = Environment.SpecialFolder.Desktop
        fbd.SelectedPath = "C:\Windows"
        fbd.ShowNewFolderButton = True

        If fbd.ShowDialog(Me) = DialogResult.OK Then
            txtジャーナル出力先フォルダ.Text = fbd.SelectedPath
        End If

    End Sub

    Private Sub btn更新_Click(sender As Object, e As EventArgs) Handles btn更新.Click
        'SQLのデータを更新
        Dim cDB As New clsDB
        Dim msSQL As String

        Try
            'トランザクション開始
            Call cDB.BeginTransaction()
            '更新
            msSQL = "Update M店舗 "
            msSQL += "SET 店舗名 = '" + txt店舗名.Text + "' "
            msSQL += ", 郵便1 = '" + txt郵便1.Text + "' "
            msSQL += ", 郵便2 = '" + txt郵便2.Text + "' "
            msSQL += ", 住所1 = '" + txt住所1.Text + "' "
            msSQL += ", 住所2 = '" + txt住所2.Text + "' "
            msSQL += ", TEL = '" + txt電話.Text + "' "
            msSQL += ", FAX = '" + txtFAX.Text + "' "
            msSQL += ", 会社名 = '" + txt会社名.Text + "' "
            msSQL += ", 代表者 = '" + txt代表者.Text + "' "

            msSQL += " WHERE 店舗CD = '" + txt店舗CD.Text + "' "

            'SQLを実行
            mCommand = cDB.getsqlComand(msSQL)
            Call mCommand.ExecuteNonQuery()

            'コミット
            Call cDB.Commit()

            '-----------------------------------------------------------
            'INIファイルのデータを更新

            '--端末
            ini.WriteProfileString("端末", "データ保存月数", txtデータ保存月数.Text)
            ini.WriteProfileString("端末", "担当入力", cmb担当入力.SelectedIndex.ToString)
            ini.WriteProfileString("端末", "客層入力", cmb客層入力.SelectedIndex.ToString)
            ini.WriteProfileString("端末", "客数入力", cmb人数入力.SelectedIndex.ToString)
            ini.WriteProfileString("端末", "ゼロ単価", cmbゼロ単価.SelectedIndex.ToString)
            ini.WriteProfileString("端末", "人数制限", txt人数制限.Text)
            ini.WriteProfileString("端末", "明細数制限", txt明細数制限.Text)
            If cmb指定取消.SelectedIndex = 1 Then
                ini.WriteProfileString("端末", "指定取消", "YES")
            Else
                ini.WriteProfileString("端末", "指定取消", "NO")
            End If
            ini.WriteProfileString("端末", "預かり投入", cmb現金.SelectedIndex.ToString)
            ini.WriteProfileString("端末", "消費税端数", cmb消費税端数.SelectedIndex.ToString)

            If cmb現金以外.SelectedIndex = 1 Then
                ini.WriteProfileString("端末", "その他省略", "YES")
            Else
                ini.WriteProfileString("端末", "その他省略", "NO")
            End If

            ini.WriteProfileString("端末", "釣銭準備金", cmb釣銭準備金.SelectedIndex.ToString)
            ini.WriteProfileString("端末", "釣銭機残値", txt釣銭機残値.Text)
            ini.WriteProfileString("端末", "BACKUP_DEF", txtBKUP複写先フォルダ１.Text)
            ini.WriteProfileString("端末", "BACKUP", txtBKUP複写先フォルダ２.Text)
            ini.WriteProfileString("端末", "CHKSIZ", txtDBサイズ警告上限値.Text)

            If cmb単価付バーコード.SelectedIndex = 0 Then
                ini.WriteProfileString("端末", "BARCODE20", "YES")
            Else
                ini.WriteProfileString("端末", "BARCODE20", "NO")
            End If

            If cmb書籍バーコード.SelectedIndex = 0 Then
                ini.WriteProfileString("端末", "BARCODE978", "YES")
            Else
                ini.WriteProfileString("端末", "BARCODE978", "NO")
            End If

            If cmb雑誌バーコード.SelectedIndex = 0 Then
                ini.WriteProfileString("端末", "BARCODE491", "YES")
            Else
                ini.WriteProfileString("端末", "BARCODE491", "NO")
            End If

            ini.WriteProfileString("端末", "メニュー文字", cmbメニュー文字.SelectedItem)

            ini.WriteProfileString("端末", "会計明細文字", cmb会計明細文字.SelectedItem)

            '--SEISAN
            If cmb金種表入力ﾁｪｯｸ.SelectedIndex = 0 Then
                ini.WriteProfileString("SEISAN", "INPCHK", "YES")
            Else
                ini.WriteProfileString("SEISAN", "INPCHK", "NO")
            End If

            '--page
            ini.WriteProfileString("page", "MODE", cmbページタグ数.SelectedIndex.ToString)

            '--TO
            ini.WriteProfileString("TO", "起動MODE", cmb初期モード.SelectedIndex.ToString)
            ini.WriteProfileString("TO", "操作MODE", cmbモードリセット.SelectedIndex.ToString)

            '--receipt
            ini.WriteProfileString("receipt", "COPY", cmbl控発行.SelectedIndex.ToString)

            If cmb宣伝文印刷.SelectedIndex = 0 Then
                ini.WriteProfileString("receipt", "宣伝文印刷", "YES")
            Else
                ini.WriteProfileString("receipt", "宣伝文印刷", "NO")
            End If

            ini.WriteProfileString("receipt", "宣伝文1", txt宣伝文1.Text)
            ini.WriteProfileString("receipt", "宣伝文2", txt宣伝文2.Text)
            ini.WriteProfileString("receipt", "宣伝文3", txt宣伝文3.Text)
            ini.WriteProfileString("receipt", "LOGO", cmb末尾ロゴ印刷.SelectedIndex.ToString)
            ini.WriteProfileString("receipt", "レシート税印字", cmb税額内訳印刷.SelectedIndex.ToString)
            ini.WriteProfileString("receipt", "レシートコード印字", cmbJANコード印刷.SelectedIndex.ToString)
            ini.WriteProfileString("receipt", "レシートNO", cmbレシートNO.SelectedIndex.ToString)
            ini.WriteProfileString("receipt", "取引名印字", cmb取引名印字文字サイズ.SelectedIndex.ToString)
            ini.WriteProfileString("receipt", "タイトル", txtタイトル.Text)
            ini.WriteProfileString("receipt", "合計点数印字", cmb合計点数印字.SelectedIndex.ToString)
            ini.WriteProfileString("receipt", "クーポンカット", cmbクーポンカット.SelectedIndex.ToString)

            '--領収
            If cmb領収名.SelectedIndex = 0 Then
                ini.WriteProfileString("領収", "領収名", "領収書")
            Else
                ini.WriteProfileString("領収", "領収名", "領収証")
            End If

            ini.WriteProfileString("領収", "但し書き", txt領収但し書き.Text)

            If cmb収入印紙枠印刷.SelectedIndex = 0 Then
                ini.WriteProfileString("領収", "収入印紙印字", "YES")
            Else
                ini.WriteProfileString("領収", "収入印紙印字", "NO")
            End If

            ini.WriteProfileString("領収", "収入印紙備考", txt備考.Text)

            '--REPORTS
            ini.WriteProfileString("REPORTS", "客数", cmb客数印字.SelectedIndex.ToString)
            ini.WriteProfileString("REPORTS", "組人数内訳", cmb組人数内訳印字.SelectedIndex.ToString)
            ini.WriteProfileString("REPORTS", "返品訂正", cmb返品訂正集計印字.SelectedIndex.ToString)

            If cmb時間帯0件明細印字.SelectedIndex = 0 Then
                ini.WriteProfileString("REPORTS", "０件明細印刷_時間帯", "YES")
            Else
                ini.WriteProfileString("REPORTS", "０件明細印刷_時間帯", "NO")
            End If

            If cmb客層0件明細印字.SelectedIndex = 0 Then
                ini.WriteProfileString("REPORTS", "０件明細印刷_客層", "YES")
            Else
                ini.WriteProfileString("REPORTS", "０件明細印刷_客層", "NO")
            End If

            '--FTP
            ini.WriteProfileString("FTP", "MODE", cmb使用区分.SelectedIndex.ToString)
            ini.WriteProfileString("FTP", "DOMAIN", txt接続先.Text)
            ini.WriteProfileString("FTP", "TIMMER", txt送受信間隔.Text)
            ini.WriteProfileString("FTP", "TIMEOUT", txtタイムアウト.Text)

            ini.WriteProfileString("FTP", "送信USER", txt送信時ユーザー名.Text)
            ini.WriteProfileString("FTP", "送信PASS", txt送信時パスワード.Text)
            ini.WriteProfileString("FTP", "送信フィルタ", txt送信時対象ファイル種類.Text)
            ini.WriteProfileString("FTP", "送信サーバーフォルダ", txt送信先サーバフォルダ.Text)
            ini.WriteProfileString("FTP", "送信モード", cmb送信モード.SelectedIndex.ToString)

            ini.WriteProfileString("FTP", "受信USER", txt受信時ユーザー名.Text)
            ini.WriteProfileString("FTP", "受信PASS", txt受信時パスワード.Text)
            ini.WriteProfileString("FTP", "受信フィルタ", txt受信時対象ファイル種類.Text)
            ini.WriteProfileString("FTP", "受信サーバーフォルダ", txt受信元サーバフォルダ.Text)

            '--IMPORTS
            ini.WriteProfileString("IMPORTS", "MODE", cmb自動起動区分.SelectedIndex.ToString)
            ini.WriteProfileString("IMPORTS", "PATH", txtCSV格納フォルダ.Text)

            '--JNL
            ini.WriteProfileString("JNL", "CHKSIZ", txtフォルダサイズ上限値.Text)
            ini.WriteProfileString("JNL", "PATH", txt電子ジャーナル出力先フォルダ.Text)

            '--一括取消
            ini.WriteProfileString("一括取消", "MODE", cmb一括取消の出力.SelectedIndex.ToString)

            '--JOURNAL
            If cmb客層0件明細印字.SelectedIndex = 0 Then
                ini.WriteProfileString("JOURNAL", "HEAD", "YES")
            Else
                ini.WriteProfileString("JOURNAL", "HEAD", "NO")
            End If
            ini.WriteProfileString("JOURNAL", "PATH", txtジャーナル出力先フォルダ.Text)

            MessageBox.Show("正常に更新しました！",
                            "端末情報登録")
        Catch ex As Exception
            'ロールバック
            Call cDB.Rollback()
            MessageBox.Show("更新に失敗しました！",
                "端末情報登録")
        End Try

    End Sub
    Private Sub btn終了_Click(sender As Object, e As EventArgs) Handles btn終了.Click
        Me.Close()
    End Sub

End Class