'2019_12_Koichi_Shimazu

Imports System.Data
Imports System.Data.SqlClient


Public Class frm806端末情報登録

    Private ini As clsINI = New clsINI("設定.ini")

    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    'Dim tblComboList As New DataTable
    Public cmb_M端末_SelectedIndex As Integer


    Private Sub frm端末情報登録_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cDB As New clsDB
        Dim msSQL As String
        Dim tmTable As New DataTable '端末テーブルをtmTableという変数名にセットした
        Dim nCmbselectIndex As Integer = -1

        'データベースから取得したいデータ群をSQLで検索
        msSQL = ""
        msSQL += "SELECT * "
        msSQL += "FROM M端末"


        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(tmTable) ''検索してきたデータをセット

        txt端末CD入力.Text = tmTable.Rows(0).Item("端末CD").ToString()

        txt管理名称.Text = tmTable.Rows(0).Item("端末名").ToString()

        If tmTable.Rows(0).Item("効果音").ToString() = "YES" Then
            cmbボタン効果音.SelectedIndex = 0
        Else
            cmbボタン効果音.SelectedIndex = 1
        End If

        'デザイン画面で「NO」をセット済み
        If tmTable.Rows(0).Item("決済端末").ToString() = "NO" Then
            cmbカード決済端末.SelectedIndex = 0
        Else
            cmbカード決済端末.Items.Add(tmTable.Rows(0).Item("決済端末").ToString())
            cmbカード決済端末.SelectedIndex = 1
        End If

        'デザイン画面で「NO」をセット済み
        If tmTable.Rows(0).Item("キャッシュドロア").ToString() = "NO" Then
            cmbｷｬｼｭﾄﾞﾛｱ.SelectedIndex = 0
        Else
            cmbｷｬｼｭﾄﾞﾛｱ.Items.Add(tmTable.Rows(0).Item("キャッシュドロア").ToString())
            cmbｷｬｼｭﾄﾞﾛｱ.SelectedIndex = 1
        End If

        'デザイン画面で「NO」をセット済み
        If tmTable.Rows(0).Item("釣銭機").ToString() = "NO" Then
            cmbつり銭機.SelectedIndex = 0
        Else
            cmbつり銭機.Items.Add(tmTable.Rows(0).Item("釣銭機").ToString())
            cmbつり銭機.SelectedIndex = 1
        End If

        'デザイン画面で「NO」をセット済み
        If tmTable.Rows(0).Item("カスタマディスプレイ").ToString() = "NO" Then
            cmbｶｽﾀﾏﾃﾞｨｽﾌﾟﾚｲ.SelectedIndex = 0
        Else
            cmbｶｽﾀﾏﾃﾞｨｽﾌﾟﾚｲ.Items.Add(tmTable.Rows(0).Item("カスタマディスプレイ").ToString())
            cmbｶｽﾀﾏﾃﾞｨｽﾌﾟﾚｲ.SelectedIndex = 1
        End If

        'デザイン画面で「NO」をセット済み
        If tmTable.Rows(0).Item("背面ディスプレイ").ToString() = "NO" Then
            cmb背面ﾃﾞｨｽﾌﾟﾚｲ.SelectedIndex = 0
        Else
            cmb背面ﾃﾞｨｽﾌﾟﾚｲ.Items.Add(tmTable.Rows(0).Item("背面ディスプレイ").ToString())
            cmb背面ﾃﾞｨｽﾌﾟﾚｲ.SelectedIndex = 1
        End If

        'デザイン画面で「NO」をセット済み
        If tmTable.Rows(0).Item("スキャナ").ToString() = "NO" Then
            cmbﾊﾞｰｺｰﾄﾞﾘｰﾀﾞｰ.SelectedIndex = 0
        Else
            Dim strBcReder() As String
            Dim nRecCount As Integer = 1        '"NO"の要素が1つ必ず追加されているので1からスタート
            strBcReder = tmTable.Rows(0).Item("スキャナ").ToString().Split("+")
            If strBcReder.Length > 1 Then
                For Each strTemp In strBcReder
                    cmbﾊﾞｰｺｰﾄﾞﾘｰﾀﾞｰ.Items.Add(LTrim(RTrim(strTemp)))
                    nRecCount += 1
                Next
            End If

            cmbﾊﾞｰｺｰﾄﾞﾘｰﾀﾞｰ.Items.Add(tmTable.Rows(0).Item("スキャナ").ToString())
            cmbﾊﾞｰｺｰﾄﾞﾘｰﾀﾞｰ.SelectedIndex = nRecCount
        End If


        'デザイン画面で「NO」をセット済み
        If tmTable.Rows(0).Item("キーボード").ToString() = "NO" Then
            cmb拡張キーボード.SelectedIndex = 0
        Else
            cmb拡張キーボード.Items.Add(tmTable.Rows(0).Item("キーボード").ToString())
            cmb拡張キーボード.SelectedIndex = 1
        End If


        Call cDB.Close()

        '-----------------------------------------------------------------------------

        ''INIファイルからデータを読み込み
        'txt業態店舗CD入力.Text = ""
        txt業態店舗CD入力.Text = ini.GetProfileString("端末", "業態店舗", "")

        'cmb天候入力.Text = ""
        cmb天候入力.Text = ini.GetProfileString("端末", "天候入力", "")

        If cmb天候入力.Text = "天候を入力しない" Then
            cmb天候入力.SelectedIndex = 0
        Else
            cmb天候入力.SelectedIndex = 1
        End If


        '----------------------------------------------------------------------
        'cmb使用区分.text = ""
        cmb使用区分.Text = ini.GetProfileString("ORD", "MODE", "")

        If cmb使用区分.Text = "オーダリングを使用しない" Then
            cmb使用区分.SelectedIndex = 0
        ElseIf cmb使用区分.Text = "オーダリングを使用する" Then
            cmb使用区分.SelectedIndex = 1
        Else
            cmb使用区分.SelectedIndex = 2
        End If

        '---------------------------------------------------------------------------------

        'cmb前後払い.Text = ""
        cmb前後払い.Text = ini.GetProfileString("ORD", "KAIKEI", "")

        If cmb前後払い.Text = "前払い" Then
            cmb前後払い.SelectedIndex = 0
        Else
            cmb前後払い.SelectedIndex = 1

        End If

        'cmboes会計.Text = ""
        cmboes会計.Text = ini.GetProfileString("ORD", "OES01", "")

        If cmboes会計.Text = "OESへ未会計で送信する" Then
            cmboes会計.SelectedIndex = 0
        Else
            cmboes会計.SelectedIndex = 1
        End If


        ''txtOES入力.Text
        txtOES入力.Text = ini.GetProfileString("ORD", "OES01", "")


        'cmbゼロ円明細.Text
        cmbゼロ円明細.Text = ini.GetProfileString("ORD", "MEISAIO", "")

        If cmbゼロ円明細.Text = "0円明細を取り込む(ｾﾚｸﾄ品等)" Then
            cmbゼロ円明細.SelectedIndex = 0
        Else
            cmbゼロ円明細.SelectedIndex = 1
        End If


        ''cmbメニュー集計.Text
        cmbメニュー集計.Text = ini.GetProfileString("ORD", "SUM", "")

        If cmbメニュー集計.Text = "同一メニューを集計して連携を行う" Then
            cmbメニュー集計.SelectedIndex = 0
        Else
            cmbメニュー集計.SelectedIndex = 1
        End If


        'cmb数量単価.Text
        cmb数量単価.Text = ini.GetProfileString("ORD", "UPDT", "")

        If cmb数量単価.Text = "明細の数量・単価の変更は不可" Then
            cmb数量単価.SelectedIndex = 0
        Else
            cmb数量単価.SelectedIndex = 1
        End If

        'txt会計済入力.Text = ""
        txt会計済入力.Text = ini.GetProfileString("ORD", "TABLE_TIME", "")

        '---------------------------------------------------------------------------------

        'txt接続COMポート入力.Text = ""
        txt接続COMポート入力.Text = ini.GetProfileString("端末", "固定スキャナCOM", "")

        '----------------------------------------------------------------------
        'カスタマディスプレイ
        'txt停止入力.Text = ""
        txt停止入力.Text = ini.GetProfileString("CUSTOMER", "TEISI", "")

        'txt登録入力.Text
        txt登録入力.Text = ini.GetProfileString("CUSTOMER", "TOUROKU", "")

        '----------------------------------------------------------------------
        'INFOX
        txt接続COMポート1入力.Text = ini.GetProfileString("端末", "INFOX1COM", "")

        txt接続COMポート2入力.Text = ini.GetProfileString("端末", "INFOX2COM", "")

        txt応答ﾀｲﾑ入力.Text = ini.GetProfileString("端末", "INFOXTIMEOUT", "")

        'cmb支払種別入力.Text
        cmb支払種別入力.Text = ini.GetProfileString("端末", "INFOXMODE", "")

        If cmb支払種別入力.Text = "支払い種別の入力を行う" Then
            cmb支払種別入力.SelectedIndex = 0
        Else
            cmb支払種別入力.SelectedIndex = 1
        End If
        '----------------------------------------------------------------------
        '背面ディスプレイ
        'txt切替ﾀｲﾏｰ.Text = ""
        txt切替ﾀｲﾏｰ.Text = ini.GetProfileString("背面", "TIME", "")


        'txt画像ﾌｧｲﾙ1.Text = ""
        'txt画像ﾌｧｲﾙ2.Text = ""
        'txt画像ﾌｧｲﾙ3.Text = ""
        'txt画像ﾌｧｲﾙ4.Text = ""
        'txt画像ﾌｧｲﾙ5.Text = ""
        'txt画像ﾌｧｲﾙ6.Text = ""
        'txt画像ﾌｧｲﾙ7.Text = ""
        'txt画像ﾌｧｲﾙ8.Text = ""
        'txt画像ﾌｧｲﾙ9.Text = ""
        'txt画像ﾌｧｲﾙ10.Text = ""

        txt画像ﾌｧｲﾙ1.Text = ini.GetProfileString("背面", "PATH1", "")
        txt画像ﾌｧｲﾙ2.Text = ini.GetProfileString("背面", "PATH2", "")
        txt画像ﾌｧｲﾙ3.Text = ini.GetProfileString("背面", "PATH3", "")
        txt画像ﾌｧｲﾙ4.Text = ini.GetProfileString("背面", "PATH4", "")
        txt画像ﾌｧｲﾙ5.Text = ini.GetProfileString("背面", "PATH5", "")
        txt画像ﾌｧｲﾙ6.Text = ini.GetProfileString("背面", "PATH6", "")
        txt画像ﾌｧｲﾙ7.Text = ini.GetProfileString("背面", "PATH7", "")
        txt画像ﾌｧｲﾙ8.Text = ini.GetProfileString("背面", "PATH8", "")
        txt画像ﾌｧｲﾙ9.Text = ini.GetProfileString("背面", "PATH9", "")
        txt画像ﾌｧｲﾙ10.Text = ini.GetProfileString("背面", "PATH10", "")

        ''---------------------------------------------------------------------------------
        ''txt宣伝文入力1.Text = ""
        ''txt宣伝文入力2.Text = ""
        ''txt宣伝文入力3.Text = ""
        ''txt宣伝文入力4.Text = ""

        txt宣伝文入力1.Text = ini.GetProfileString("背面", "宣伝文1", "")
        txt宣伝文入力2.Text = ini.GetProfileString("背面", "宣伝文2", "")
        txt宣伝文入力3.Text = ini.GetProfileString("背面", "宣伝文3", "")
        txt宣伝文入力4.Text = ini.GetProfileString("背面", "宣伝文4", "")


        '----------------------------------------------------------------------
        'txt会計挨拶入力1.Text = ""
        'txt会計挨拶入力2.Text = ""
        'txt会計挨拶入力3.Text = ""
        'txt会計挨拶入力4.Text = ""

        txt会計挨拶入力1.Text = ini.GetProfileString("背面", "会計挨拶1", "")
        txt会計挨拶入力2.Text = ini.GetProfileString("背面", "会計挨拶2", "")
        txt会計挨拶入力3.Text = ini.GetProfileString("背面", "会計挨拶3", "")
        txt会計挨拶入力4.Text = ini.GetProfileString("背面", "会計挨拶4", "")

        '----------------------------------------------------------------------
        '取得場所が不明な箇所の表示
        txt印字記号.Text = "E"

        cmbカット.Items.Add("1取引でカット")
        cmbカット.Items.Add("各商品ごとにカット")
        cmbカット.SelectedIndex = 0

        cmb控発行.Items.Add("発行する")
        cmb控発行.Items.Add("発行しない")
        cmb控発行.SelectedIndex = 0
    End Sub


    Private Sub btn_画像ﾌｧｲﾙ1_Click(sender As Object, e As EventArgs) Handles btn_画像ﾌｧｲﾙ1.Click
        'FolderBrowserDialogクラスのインスタンスを作成
        Dim fbd As New FolderBrowserDialog

        '上部に表示する説明テキストを指定する
        fbd.Description = "フォルダを指定してください。"
        'ルートフォルダを指定する
        'デフォルトでDesktop
        fbd.RootFolder = Environment.SpecialFolder.Desktop
        '最初に選択するフォルダを指定する
        'RootFolder以下にあるフォルダである必要がある
        fbd.SelectedPath = "C:\Windows"
        'ユーザーが新しいフォルダを作成できるようにする
        'デフォルトでTrue
        fbd.ShowNewFolderButton = True

        'ダイアログを表示する
        If fbd.ShowDialog(Me) = DialogResult.OK Then
            '選択されたフォルダを表示する
            txt画像ﾌｧｲﾙ1.Text = fbd.SelectedPath
        End If
    End Sub

    Private Sub btn_画像ﾌｧｲﾙ2_Click(sender As Object, e As EventArgs) Handles btn_画像ﾌｧｲﾙ2.Click
        Dim fbd As New FolderBrowserDialog
        fbd.Description = "フォルダを指定してください。"
        fbd.RootFolder = Environment.SpecialFolder.Desktop
        fbd.SelectedPath = "C:\Windows"
        fbd.ShowNewFolderButton = True

        If fbd.ShowDialog(Me) = DialogResult.OK Then
            txt画像ﾌｧｲﾙ2.Text = fbd.SelectedPath
        End If
    End Sub

    Private Sub btn_画像ﾌｧｲﾙ3_Click(sender As Object, e As EventArgs) Handles btn_画像ﾌｧｲﾙ3.Click
        Dim fbd As New FolderBrowserDialog
        fbd.Description = "フォルダを指定してください。"
        fbd.RootFolder = Environment.SpecialFolder.Desktop
        fbd.SelectedPath = "C:\Windows"
        fbd.ShowNewFolderButton = True

        If fbd.ShowDialog(Me) = DialogResult.OK Then
            txt画像ﾌｧｲﾙ3.Text = fbd.SelectedPath
        End If
    End Sub

    Private Sub btn_画像ﾌｧｲﾙ4_Click(sender As Object, e As EventArgs) Handles btn_画像ﾌｧｲﾙ4.Click
        Dim fbd As New FolderBrowserDialog
        fbd.Description = "フォルダを指定してください。"
        fbd.RootFolder = Environment.SpecialFolder.Desktop
        fbd.SelectedPath = "C:\Windows"
        fbd.ShowNewFolderButton = True

        If fbd.ShowDialog(Me) = DialogResult.OK Then
            txt画像ﾌｧｲﾙ4.Text = fbd.SelectedPath
        End If
    End Sub

    Private Sub btn_画像ﾌｧｲﾙ5_Click(sender As Object, e As EventArgs) Handles btn_画像ﾌｧｲﾙ5.Click
        Dim fbd As New FolderBrowserDialog
        fbd.Description = "フォルダを指定してください。"
        fbd.RootFolder = Environment.SpecialFolder.Desktop
        fbd.SelectedPath = "C:\Windows"
        fbd.ShowNewFolderButton = True

        If fbd.ShowDialog(Me) = DialogResult.OK Then
            txt画像ﾌｧｲﾙ5.Text = fbd.SelectedPath
        End If
    End Sub

    Private Sub btn_画像ﾌｧｲﾙ6_Click(sender As Object, e As EventArgs) Handles btn_画像ﾌｧｲﾙ6.Click
        Dim fbd As New FolderBrowserDialog
        fbd.Description = "フォルダを指定してください。"
        fbd.RootFolder = Environment.SpecialFolder.Desktop
        fbd.SelectedPath = "C:\Windows"
        fbd.ShowNewFolderButton = True

        If fbd.ShowDialog(Me) = DialogResult.OK Then
            txt画像ﾌｧｲﾙ6.Text = fbd.SelectedPath
        End If
    End Sub

    Private Sub btn_画像ﾌｧｲﾙ7_Click(sender As Object, e As EventArgs) Handles btn_画像ﾌｧｲﾙ7.Click
        Dim fbd As New FolderBrowserDialog
        fbd.Description = "フォルダを指定してください。"
        fbd.RootFolder = Environment.SpecialFolder.Desktop
        fbd.SelectedPath = "C:\Windows"
        fbd.ShowNewFolderButton = True

        If fbd.ShowDialog(Me) = DialogResult.OK Then
            txt画像ﾌｧｲﾙ7.Text = fbd.SelectedPath
        End If
    End Sub

    Private Sub btn_画像ﾌｧｲﾙ8_Click(sender As Object, e As EventArgs) Handles btn_画像ﾌｧｲﾙ8.Click
        Dim fbd As New FolderBrowserDialog
        fbd.Description = "フォルダを指定してください。"
        fbd.RootFolder = Environment.SpecialFolder.Desktop
        fbd.SelectedPath = "C:\Windows"
        fbd.ShowNewFolderButton = True

        If fbd.ShowDialog(Me) = DialogResult.OK Then
            txt画像ﾌｧｲﾙ8.Text = fbd.SelectedPath
        End If
    End Sub

    Private Sub btn_画像ﾌｧｲﾙ9_Click(sender As Object, e As EventArgs) Handles btn_画像ﾌｧｲﾙ9.Click
        Dim fbd As New FolderBrowserDialog
        fbd.Description = "フォルダを指定してください。"
        fbd.RootFolder = Environment.SpecialFolder.Desktop
        fbd.SelectedPath = "C:\Windows"
        fbd.ShowNewFolderButton = True

        If fbd.ShowDialog(Me) = DialogResult.OK Then
            txt画像ﾌｧｲﾙ9.Text = fbd.SelectedPath
        End If
    End Sub

    Private Sub btn_画像ﾌｧｲﾙ10_Click(sender As Object, e As EventArgs) Handles btn_画像ﾌｧｲﾙ10.Click
        Dim fbd As New FolderBrowserDialog
        fbd.Description = "フォルダを指定してください。"
        fbd.RootFolder = Environment.SpecialFolder.Desktop
        fbd.SelectedPath = "C:\Windows"
        fbd.ShowNewFolderButton = True

        If fbd.ShowDialog(Me) = DialogResult.OK Then
            txt画像ﾌｧｲﾙ10.Text = fbd.SelectedPath
        End If
    End Sub

    Private Sub btn終了_Click(sender As Object, e As EventArgs) Handles btn終了.Click
        Me.Close()
    End Sub


    Private Sub btn更新_Click(sender As Object, e As EventArgs) Handles btn更新.Click

        'SQLのデータを更新
        Dim cDB As New clsDB
        Dim msSQL As String

        Try
            'トランザクション開始
            Call cDB.BeginTransaction()
            '更新
            msSQL = "Update M端末 "
            msSQL += "SET 端末名 = '" + txt管理名称.Text + "' "
            msSQL += ", 決済端末 = '" + cmbカード決済端末.SelectedItem.ToString + "' "
            msSQL += ", キャッシュドロア = '" + cmbｷｬｼｭﾄﾞﾛｱ.SelectedItem.ToString + "' "
            msSQL += ", 釣銭機 = '" + cmbつり銭機.SelectedItem.ToString + "' "
            msSQL += ", カスタマディスプレイ = '" + cmbｶｽﾀﾏﾃﾞｨｽﾌﾟﾚｲ.SelectedItem.ToString + "' "
            msSQL += ", 背面ディスプレイ = '" + cmb背面ﾃﾞｨｽﾌﾟﾚｲ.SelectedItem.ToString + "' "
            msSQL += ", スキャナ = '" + cmbﾊﾞｰｺｰﾄﾞﾘｰﾀﾞｰ.SelectedItem.ToString + "' "
            msSQL += ", キーボード = '" + cmb拡張キーボード.SelectedItem.ToString + "' "

            If cmbボタン効果音.SelectedIndex = 0 Then
                msSQL += ", 効果音 = 'YES' "
            Else
                msSQL += ", 効果音 = 'NO' "
            End If

            msSQL += " WHERE 端末CD = '" + txt端末CD入力.Text + "' "

            'SQLを実行
            mCommand = cDB.getsqlComand(msSQL)
            Call mCommand.ExecuteNonQuery()

            'コミット
            Call cDB.Commit()
            MessageBox.Show("正常に更新しました！",
                            "端末情報登録")
        Catch ex As Exception
        'ロールバック
        Call cDB.Rollback()
        MessageBox.Show("更新に失敗しました！",
                "端末情報登録")
        End Try

        '-----------------------------------------------------------
        'INIファイルのデータを更新

        ini.WriteProfileString("ORD", "MODE", cmb使用区分.Text)
        ini.WriteProfileString("ORD", "KAIKEI", cmb前後払い.Text)
        ini.WriteProfileString("ORD", "KAIKEIKBN", cmboes会計.Text)
        ini.WriteProfileString("ORD", "OES01", txtOES入力.Text)
        ini.WriteProfileString("ORD", "MEISAIO", cmbゼロ円明細.Text)
        ini.WriteProfileString("ORD", "SUM", cmbメニュー集計.Text)
        ini.WriteProfileString("ORD", "UPDT", cmb数量単価.Text)
        ini.WriteProfileString("ORD", "TABLE_TIME", txt会計済入力.Text)
        ini.WriteProfileString("端末", "固定スキャナCOM", txt接続COMポート入力.Text)
        ini.WriteProfileString("CUSTOME", "TEISI", txt停止入力.Text)
        ini.WriteProfileString("端末", "INFOX1COM", txt接続COMポート1入力.Text)
        ini.WriteProfileString("端末", "INFOX2COM", txt接続COMポート2入力.Text)
        ini.WriteProfileString("端末", "INFOXMODE", cmb支払種別入力.Text)
        ini.WriteProfileString("端末", "INFOXTIMEOUT", txt応答ﾀｲﾑ入力.Text)

        ini.WriteProfileString("背面", "PATH1", txt画像ﾌｧｲﾙ1.Text)
        ini.WriteProfileString("背面", "PATH2", txt画像ﾌｧｲﾙ2.Text)
        ini.WriteProfileString("背面", "PATH3", txt画像ﾌｧｲﾙ3.Text)
        ini.WriteProfileString("背面", "PATH4", txt画像ﾌｧｲﾙ4.Text)
        ini.WriteProfileString("背面", "PATH5", txt画像ﾌｧｲﾙ5.Text)
        ini.WriteProfileString("背面", "PATH6", txt画像ﾌｧｲﾙ6.Text)
        ini.WriteProfileString("背面", "PATH7", txt画像ﾌｧｲﾙ7.Text)
        ini.WriteProfileString("背面", "PATH8", txt画像ﾌｧｲﾙ8.Text)
        ini.WriteProfileString("背面", "PATH9", txt画像ﾌｧｲﾙ9.Text)
        ini.WriteProfileString("背面", "PATH10", txt画像ﾌｧｲﾙ10.Text)

        ini.WriteProfileString("背面", "宣伝文1", txt宣伝文入力1.Text)
        ini.WriteProfileString("背面", "宣伝文2", txt宣伝文入力2.Text)
        ini.WriteProfileString("背面", "宣伝文3", txt宣伝文入力3.Text)
        ini.WriteProfileString("背面", "宣伝文4", txt宣伝文入力4.Text)

        ini.WriteProfileString("背面", "会計挨拶1", txt会計挨拶入力1.Text)
        ini.WriteProfileString("背面", "会計挨拶2", txt会計挨拶入力2.Text)
        ini.WriteProfileString("背面", "会計挨拶3", txt会計挨拶入力3.Text)
        ini.WriteProfileString("背面", "会計挨拶4", txt会計挨拶入力4.Text)

        Me.Close()

    End Sub

End Class