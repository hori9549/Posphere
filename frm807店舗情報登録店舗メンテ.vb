
'20191122今田涼子
Imports System.Data
Imports System.Data.SqlClient

Public Class frm807店舗情報登録店舗メンテ
    Private s店舗CD As String
    Private ini As clsINI = New clsINI("設定.ini")

    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter
    Private dtbl明細 As New DataTable




    Private Sub frm807店舗情報登録店舗メンテ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '------------------------------------------
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable
        Dim mCmbselectIndex As Integer = -1


        msSQL = "SELECT *"
        msSQL += "FROM dbo.M店舗"
        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)

        s店舗CD = myTable.Rows(0).Item("店舗CD").ToString()
        txt店舗名.Text = myTable.Rows(0).Item("店舗名").ToString()
        txt郵便番号１.Text = myTable.Rows(0).Item("郵便1").ToString()
        txt郵便番号２.Text = myTable.Rows(0).Item("郵便2").ToString()
        txt住所１.Text = myTable.Rows(0).Item("住所1").ToString()
        txt住所２.Text = myTable.Rows(0).Item("住所2").ToString()
        txt電話.Text = myTable.Rows(0).Item("TEL").ToString()
        txtFAX.Text = myTable.Rows(0).Item("FAX").ToString()
        txt会社名.Text = myTable.Rows(0).Item("会社名").ToString()
        txt代表者.Text = myTable.Rows(0).Item("代表者").ToString()


        '------------------------------------------
        'cmbメニュー文字.Text = ""
        cmbメニュー文字.Text = ini.GetProfileString("端末", "メニュー文字", "")

        If cmbメニュー文字.Text = "通常" Then
            cmbメニュー文字.Text = "通常"
        Else
            cmbメニュー文字.Text = "拡大"
        End If
        cmbメニュー文字.SelectedIndex = 0
        '------------------------------------------------       ''------------------------------------------
        'cmb会計明細.Text = ""
        cmb会計明細.Text = ini.GetProfileString("端末", "会計明細文字", "")

        If cmb会計明細.Text = "通常" Then
            cmb会計明細.Text = "通常"
        Else
            cmb会計明細.Text = "拡大"
        End If
        cmb会計明細.SelectedIndex = 0
        '----------------------------------------------
        'cmbページタグ数.Text = ""
        cmbページタグ数.Text = ini.GetProfileString("page", "MODE", "")

        If cmbページタグ数.Text = "ページタグ=4" Then
            cmbページタグ数.Text = "ページタグ=4"
        Else
            cmbページタグ数.Text = "ページタグ=8"
        End If
        cmbページタグ数.SelectedIndex = 0
        '----------------------------------------------
        'cmb宣伝文印刷.Text = ""
        cmb宣伝文印刷.Text = ini.GetProfileString("receipt", "宣伝文印刷", "")

        If cmb宣伝文印刷.Text = "YES 	宣伝文を印刷する" Then
            cmb宣伝文印刷.Text = "YES 	宣伝文を印刷する"
        Else
            cmb宣伝文印刷.Text = "NO 	宣伝文を印刷しない"
        End If
        cmb宣伝文印刷.SelectedIndex = 0
        '----------------------------------------------
        'cmb末尾ロゴ.Text = ""
        cmb末尾ロゴ.Text = ini.GetProfileString("receipt", "LOGO", "")

        If cmb末尾ロゴ.Text = "末尾ロゴを印刷しない" Then
            cmb末尾ロゴ.Text = "末尾ロゴを印刷しない"
        Else
            cmb末尾ロゴ.Text = "末尾ロゴを印刷する"
        End If
        cmb末尾ロゴ.SelectedIndex = 0
        '----------------------------------------------
        'cmbクーポンカット.Text = ""
        cmbクーポンカット.Text = ini.GetProfileString("receipt", "クーポンカット", "")

        If cmbクーポンカット.Text = "0 クーポンをカットしない" Then
            cmbクーポンカット.Text = "0 クーポンをカットしない"
        Else
            cmbクーポンカット.Text = "1 クーポンをカットする"
        End If
        cmbクーポンカット.SelectedIndex = 0
        '----------------------------------------------
        'cmb領収名.Text = ""
        cmb領収名.Text = ini.GetProfileString("領収", "領収名", "")

        If cmb領収名.Text = "領収書" Then
            cmb領収名.Text = "領収書"
        Else
            cmb領収名.Text = "領収証"
        End If
        cmb領収名.SelectedIndex = 0
        '----------------------------------------------
        'cmb収入印紙枠.Text = ""
        cmb収入印紙枠.Text = ini.GetProfileString("領収", "収入印紙印字", "")

        If cmb収入印紙枠.Text = "YES　収入印紙欄を印刷する" Then
            cmb収入印紙枠.Text = "YES　収入印紙欄を印刷する"
        Else
            cmb収入印紙枠.Text = "NO　収入印紙欄を印刷しない"
        End If
        cmb収入印紙枠.SelectedIndex = 0
        '----------------------------------------------
        'cmbカット.Text = ""
        cmbカット.Text = ini.GetProfileString("ticket", "MODE", "")

        If cmbカット.Text = "0 各商品ごとにカット" Then
            cmbカット.Text = "0 各商品ごとにカット"
        Else
            cmbカット.Text = "1 1取引でカット"
        End If
        cmbカット.SelectedIndex = 0
        '----------------------------------------------
        'cmb控発行.Text = ""
        cmb控発行.Text = ini.GetProfileString("ticket", "COPY", "")

        If cmb控発行.Text = "0 発行控えを発行しない" Then
            cmb控発行.Text = "0 発行控えを発行しない"
        Else
            cmb控発行.Text = "1 発行控えを発行する"
        End If
        cmb控発行.SelectedIndex = 0
        '----------------------------------------------
        ''cmb初期モード.Text = ""
        cmb初期モード.Text = ini.GetProfileString("TO", "起動MODE", "")

        If cmb控発行.Text = "0 通常販売モードで起動する" Then
            cmb控発行.Text = "0 通常販売モードで起動する"
        Else
            cmb控発行.Text = "1 テイクアウト販売モードで起動する"
        End If
        cmb初期モード.SelectedIndex = 0
        '----------------------------------------------
        'cmbモードリセット.Text = ""
        cmbモードリセット.Text = ini.GetProfileString("TO", "操作MODE", "")

        If cmb控発行.Text = "0 商品毎に起動モードに戻す" Then
            cmb控発行.Text = "0 商品毎に起動モードに戻す"
        ElseIf cmb控発行.Text = "1 発行控えを発行する" Then
            cmb控発行.Text = "1 発行控えを発行する"
        Else
            cmb控発行.Text = "2 会計毎に起動モードに戻す"

        End If
        cmbモードリセット.SelectedIndex = 0
        '----------------------------------------------
        'txtレシート宣伝文１
        txtレシート宣伝文１.Text = ini.GetProfileString("receipt", "宣伝文1", "")
        '----------------------------------------------------
        'txtレシート宣伝文２
        txtレシート宣伝文２.Text = ini.GetProfileString("receipt", "宣伝文2", "")
        '----------------------------------------------------
        'txtレシート宣伝文３
        txtレシート宣伝文３.Text = ini.GetProfileString("receipt", "宣伝文3", "")
        '----------------------------------------------------
        'txt末尾ロゴ1
        txt末尾ロゴ.Text = ini.GetProfileString("receipt", "KING", "")
        '----------------------------------------------------
        'txt領収但書
        txt領収但書.Text = ini.GetProfileString("領収", "但し書き", "")
        '----------------------------------------------------
        'txt備考.
        txt備考.Text = ini.GetProfileString("領収", "収入印紙備考", "")
        '----------------------------------------------------
        'txt印字記号
        txt印字記号.Text = ini.GetProfileString("ticket", "KIGO", "")
        '----------------------------------------------------
        'txt停止
        txt停止.Text = ini.GetProfileString("CUSTOMER", "TEISI", "")
        '----------------------------------------------------
        'txt登録
        txt登録.Text = ini.GetProfileString("CUSTOMER", "TOUROKU", "")
        '----------------------------------------------------
        'txt背面宣伝文１
        txt背面宣伝文１.Text = ini.GetProfileString("背面", "宣伝文1", "")
        '----------------------------------------------------
        'txt背面宣伝文２
        txt背面宣伝文２.Text = ini.GetProfileString("背面", "宣伝文2", "")
        '----------------------------------------------------
        'txt背面宣伝文３
        txt背面宣伝文３.Text = ini.GetProfileString("背面", "宣伝文3", "")
        '----------------------------------------------------
        'txt背面宣伝文４
        txt背面宣伝文４.Text = ini.GetProfileString("背面", "宣伝文4", "")
        '----------------------------------------------------
        'txt会計挨拶１
        txt会計挨拶１.Text = ini.GetProfileString("背面", "会計挨拶1", "")
        '----------------------------------------------------
        'txt会計挨拶２
        txt会計挨拶２.Text = ini.GetProfileString("背面", "会計挨拶2", "")
        '----------------------------------------------------
        'txt会計挨拶３
        txt会計挨拶３.Text = ini.GetProfileString("背面", "会計挨拶3", "")
        '----------------------------------------------------
        'txt会計挨拶４
        txt会計挨拶４.Text = ini.GetProfileString("背面", "会計挨拶4", "")
        '----------------------------------------------------


        '★txt店舗名.Text = "国見SA下り線"
        '★txt郵便番号１.Text = "969"
        '★txt郵便番号２.Text = "1711"
        '★txt住所１.Text = "福島県"
        '★txt住所２.Text = "伊達郡国見町大字貝田字山口"
        '★txt電話.Text = "024-585-3561"
        '★txtFAX.Text = "024-585-5697"
        '★txt会社名.Text = "(株)名鉄レストラン"
        '★txt代表者.Text =””
        'cmbメニュー文字.Items.Add("通常")
        'cmbメニュー文字.Items.Add("拡大")
        'cmbメニュー文字.SelectedIndex = 0
        'cmb会計明細.Items.Add("通常")
        'cmb会計明細.Items.Add("拡大")
        'cmb会計明細.SelectedIndex = 0
        'cmbページタグ数.Items.Add("ページタグ数「４」")
        'cmbページタグ数.Items.Add("ページタグ数「８」")
        'cmbページタグ数.SelectedIndex = 0
        'cmb宣伝文印刷.Items.Add("宣伝文を印刷する")
        'cmb宣伝文印刷.Items.Add("宣伝文を印刷しない")
        'cmb宣伝文印刷.SelectedIndex = 0
        ''txtレシート宣伝文１.Text = "「休もっか」「休もうよ」と気軽に"
        ''txtレシート宣伝文２.Text = "毎日でも立ち寄っていただける"
        ''txtレシート宣伝文３.Text = "普段使いのSA・PAです"
        'cmb末尾ロゴ.Items.Add("印刷する")
        'cmb末尾ロゴ.Items.Add("印刷しない")
        'cmb末尾ロゴ.SelectedIndex = 0
        'txt末尾ロゴ.Text = "0"
        'cmbクーポンカット.Text = "クーポンをカットしない"
        'cmbクーポンカット.Items.Add("クーポンをカットする")
        'cmb領収名.Items.Add("領収書")
        'cmb領収名.Items.Add("領収証")
        'cmb領収名.SelectedIndex = 0
        ''txt領収但書.Text = "　　　　代として上記金額正に領収致しました"
        'cmb収入印紙枠.Items.Add("収入印紙枠を印刷する"）
        'cmb収入印紙枠.Items.Add("収入印紙枠を印刷しない")
        'cmb収入印紙枠.SelectedIndex = 0
        ''txt備考.Text = "この領収書は感熱紙にため保管には十分ご注意下さい"
        ''txt印字記号.Text = "E"
        'cmbカット.Items.Add("1取引でカット"）
        'cmbカット.Items.Add("各商品ごとカット")
        'cmbカット.SelectedIndex = 0
        'cmb控発行.Items.Add("発行する")
        'cmb控発行.Items.Add("発行しない")
        'cmb控発行.SelectedIndex = 0
        'txt停止.Text = "停　止　中"
        'txt登録.Text = "いらっしゃいませ"
        'txt背面宣伝文２.Text = "いらっしゃいませ！"
        'txt会計挨拶１.Text = "ありがとうございました。"
        'txt会計挨拶３.Text = "またおこしくださいませ！"
        'cmb初期モード.Items.Add("起動時、テイクアウト販売モードとする"）
        'cmb初期モード.Items.Add("起動時、通常販売モードとする")
        'cmb初期モード.SelectedIndex = 0
        'cmbモードリセット.Items.Add("ボタン操作で初期モードにリセットする"）
        'cmbモードリセット.Items.Add("１明細ごとに自動で初期モードにリセットする")
        'cmbモードリセット.Items.Add("ボタン操作で初期モードにリセットする")
        'cmbモードリセット.Items.Add("会計後に自動で初期モードにリセットする")
        'cmbモードリセット.SelectedIndex = 0

    End Sub


    Private Sub btn更新_Click(sender As Object, e As EventArgs) Handles btn更新.Click

        Dim cDB As New clsDB
        Dim msSQL As String
        'Dim myTable As New DataTable
        'Dim mCmbselectIndex As Integer = -1

        Try
            'トランザクション開始
            Call cDB.BeginTransaction()
            '更新
            msSQL = "UPDATE M店舗 "

            msSQL += "SET 店舗名 = '" + txt店舗名.Text + "' "
            msSQL += ", 郵便1 = '" + txt郵便番号１.Text + "' "
            msSQL += ", 郵便2 = '" + txt郵便番号２.Text + "' "
            msSQL += ", 住所1 = '" + txt住所１.Text + "' "
            msSQL += ", 住所2 = '" + txt住所２.Text + "' "
            msSQL += ", TEL = '" + txt電話.Text + "' "
            msSQL += ", FAX = '" + txtFAX.Text + "' "
            msSQL += ", 会社名 = '" + txt会社名.Text + "' "
            msSQL += ", 代表者 = '" + txt代表者.Text + "' "

            msSQL += " WHERE 店舗CD = '" & s店舗CD & "' "

            'SQLを実行
            mCommand = cDB.getsqlComand(msSQL)
            'mSDA.SelectCommand = mCommand
            Call mCommand.ExecuteNonQuery()

            'コミット
            Call cDB.Commit()
            MessageBox.Show("正常に更新しました", "店舗情報登録(店舗メンテ)")
        Catch ex As Exception
            'ロールバック
            Call cDB.Rollback()
            MessageBox.Show("更新に失敗しました！",
                    "店舗情報登録(店舗メンテ)")

        End Try




        '------------------------------
        ini.WriteProfileString("端末", "メニュー文字", cmbメニュー文字.Text)
        '------------------------------
        ini.WriteProfileString("端末", "会計明細文字", cmb会計明細.Text)
        '----------------------------------------------
        'cmbページタグ数.Text = ""
        ini.WriteProfileString("page", "MODE", cmbページタグ数.Text)
        '----------------------------------------------
        'cmb宣伝文印刷.Text = ""
        ini.WriteProfileString("receipt", "宣伝文印刷", cmb宣伝文印刷.Text)
        '----------------------------------------------
        'cmb末尾ロゴ.Text = ""
        ini.WriteProfileString("receipt", "LOGO", cmb末尾ロゴ.Text)
        '----------------------------------------------
        'cmbクーポンカット.Text = ""
        ini.WriteProfileString("receipt", "クーポンカット", cmbクーポンカット.Text)
        '----------------------------------------------
        'cmb領収名.Text = ""
        ini.WriteProfileString("領収", "領収名", cmb領収名.Text)
        '----------------------------------------------
        'cmb収入印紙枠.Text = ""
        ini.WriteProfileString("領収", "収入印紙印字", cmb収入印紙枠.Text)
        '----------------------------------------------
        'cmbカット.Text = ""
        ini.WriteProfileString("ticket", "MODE", cmbカット.Text)
        '----------------------------------------------
        'cmb控発行.Text = ""
        ini.WriteProfileString("ticket", "COPY", cmb控発行.Text)
        '----------------------------------------------
        ''cmb初期モード.Text = ""
        ini.WriteProfileString("TO", "起動MODE", cmb初期モード.Text)
        '----------------------------------------------
        'cmbモードリセット.Text = ""
        ini.WriteProfileString("TO", "操作MODE", cmbモードリセット.Text)
        '----------------------------------------------

        '----------------------------------------------
        'txtレシート宣伝文１
        ini.WriteProfileString("receipt", "宣伝文1", txtレシート宣伝文１.Text)
        '----------------------------------------------------
        'txtレシート宣伝文２
        ini.WriteProfileString("receipt", "宣伝文2", txtレシート宣伝文２.Text)
        '----------------------------------------------------
        'txtレシート宣伝文３
        ini.WriteProfileString("receipt", "宣伝文3", txtレシート宣伝文３.Text)
        '----------------------------------------------------
        'txt末尾ロゴ
        ini.WriteProfileString("receipt", "KING", txt末尾ロゴ.Text)
        '----------------------------------------------------
        'txt領収但書
        ini.WriteProfileString("領収", "但し書き", txt領収但書.Text)
        '----------------------------------------------------
        'txt備考.
        ini.WriteProfileString("領収", "収入印紙備考", txt備考.Text)
        '----------------------------------------------------
        'txt印字記号
        ini.WriteProfileString("ticket", "KIGO", txt印字記号.Text)
        '----------------------------------------------------
        'txt停止
        ini.WriteProfileString("CUSTOMER", "TEISI", txt停止.Text)
        '----------------------------------------------------
        'txt登録
        ini.WriteProfileString("CUSTOMER", "TOUROKU", txt登録.Text)
        '----------------------------------------------------
        'txt背面宣伝文１
        ini.WriteProfileString("背面", "宣伝文1", txt背面宣伝文１.Text)
        '----------------------------------------------------
        'txt背面宣伝文２
        ini.WriteProfileString("背面", "宣伝文2", txt背面宣伝文２.Text)
        '----------------------------------------------------
        'txt背面宣伝文３
        ini.WriteProfileString("背面", "宣伝文3", txt背面宣伝文３.Text)
        '----------------------------------------------------
        'txt背面宣伝文４
        ini.WriteProfileString("背面", "宣伝文4", txt背面宣伝文４.Text)
        '----------------------------------------------------
        'txt会計挨拶１
        ini.WriteProfileString("背面", "会計挨拶1", txt会計挨拶１.Text)
        '----------------------------------------------------
        'txt会計挨拶２
        ini.WriteProfileString("背面", "会計挨拶2", txt会計挨拶２.Text)
        '----------------------------------------------------
        'txt会計挨拶３
        ini.WriteProfileString("背面", "会計挨拶3", txt会計挨拶３.Text)
        '----------------------------------------------------
        'txt会計挨拶４
        ini.WriteProfileString("背面", "会計挨拶4", txt会計挨拶４.Text)
        '----------------------------------------------------

    End Sub

    Private Sub btn終了_Click(sender As Object, e As EventArgs) Handles btn終了.Click
        Me.Close()

    End Sub


End Class



'Dim writer As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("Test.txt", True, sjisEnc)

'Dim writer As StreamWriter = New StreamWriter("Test.txt", True, sjisEnc)
'Using Writer = New StreamWriter("{C:\Users\wakasa\Desktop\PosSystemSrcV001_202002041800\Posレジ_Ver001_202002041800\Posphere}", True)
'Using Writer = New StreamWriter("{C:\Users\wakasa\Desktop\PosSystemSrcV001_202002041800\Posレジ_Ver001_202002041800\Posphere}", True)
'writer.WriteLine("テスト書き込みです。")

'txtレシート宣伝文１.Text = "「休もっか」「休もうよ」と気軽に"
'txtレシート宣伝文１.Text = "「休もっか」そうだね「休もうよ」と気軽に"


'writer.WriteLine(txtレシート宣伝文１.Text = "「休もっか」「休もうよ」と気軽に")
'writer.WriteLine(txtレシート宣伝文２.Text = "毎日でも立ち寄っていただける")
'writer.WriteLine(txtレシート宣伝文３.Text = "普段使いのSA・PAです")

'writer.Close()
'End Using
'------------------------------------
'-----------------------------------
'Dim enc As System.Text.Encoding = System.Text.Encoding.GetEncoding("shift_jis")
'Dim iniFileName As String = "設定.ini"
'Dim StreamWriter As String = "設定.ini"
'Dim writer As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("Test.txt", True, sjisEnc)


'WriteProfileString




