<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm805店舗情報登録
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tabc店舗基本情報 = New System.Windows.Forms.TabControl()
        Me.tab基本情報 = New System.Windows.Forms.TabPage()
        Me.grp販売モードとテイクアウト = New System.Windows.Forms.GroupBox()
        Me.lblモードリセット = New System.Windows.Forms.Label()
        Me.lbl初期モード = New System.Windows.Forms.Label()
        Me.cmb初期モード = New System.Windows.Forms.ComboBox()
        Me.cmbモードリセット = New System.Windows.Forms.ComboBox()
        Me.grpその他設定 = New System.Windows.Forms.GroupBox()
        Me.lblページタグ数 = New System.Windows.Forms.Label()
        Me.lbl金種表入力チェック = New System.Windows.Forms.Label()
        Me.cmb金種表入力ﾁｪｯｸ = New System.Windows.Forms.ComboBox()
        Me.cmbページタグ数 = New System.Windows.Forms.ComboBox()
        Me.grp画面文字サイズ設定 = New System.Windows.Forms.GroupBox()
        Me.lbl会計明細文字 = New System.Windows.Forms.Label()
        Me.lblメニュー文字 = New System.Windows.Forms.Label()
        Me.cmbメニュー文字 = New System.Windows.Forms.ComboBox()
        Me.cmb会計明細文字 = New System.Windows.Forms.ComboBox()
        Me.grpバーコード設定 = New System.Windows.Forms.GroupBox()
        Me.lbl雑誌バーコード = New System.Windows.Forms.Label()
        Me.cmb雑誌バーコード = New System.Windows.Forms.ComboBox()
        Me.lbl書籍バーコード = New System.Windows.Forms.Label()
        Me.lbl単価付バーコード = New System.Windows.Forms.Label()
        Me.cmb単価付バーコード = New System.Windows.Forms.ComboBox()
        Me.cmb書籍バーコード = New System.Windows.Forms.ComboBox()
        Me.grpDB情報 = New System.Windows.Forms.GroupBox()
        Me.txtDBサイズ警告上限値 = New System.Windows.Forms.TextBox()
        Me.txtBKUP複写先フォルダ２ = New System.Windows.Forms.TextBox()
        Me.txtBKUP複写先フォルダ１ = New System.Windows.Forms.TextBox()
        Me.lblBKUP複写先フォルダ１ = New System.Windows.Forms.Label()
        Me.lblDBサイズ警告上限値 = New System.Windows.Forms.Label()
        Me.lblBKUP複写先フォルダ２ = New System.Windows.Forms.Label()
        Me.grp預かり金入力設定 = New System.Windows.Forms.GroupBox()
        Me.cmb釣銭準備金 = New System.Windows.Forms.ComboBox()
        Me.txt釣銭機残値 = New System.Windows.Forms.TextBox()
        Me.lbl釣銭機残値 = New System.Windows.Forms.Label()
        Me.lbl釣銭準備金 = New System.Windows.Forms.Label()
        Me.cmb現金以外 = New System.Windows.Forms.ComboBox()
        Me.lbl現金以外 = New System.Windows.Forms.Label()
        Me.lbl現金 = New System.Windows.Forms.Label()
        Me.cmb現金 = New System.Windows.Forms.ComboBox()
        Me.grpその他基本情報 = New System.Windows.Forms.GroupBox()
        Me.txt明細数制限 = New System.Windows.Forms.TextBox()
        Me.lbl明細数制限 = New System.Windows.Forms.Label()
        Me.txt人数制限 = New System.Windows.Forms.TextBox()
        Me.txtデータ保存月数 = New System.Windows.Forms.TextBox()
        Me.lbl消費税端数 = New System.Windows.Forms.Label()
        Me.cmb消費税端数 = New System.Windows.Forms.ComboBox()
        Me.lbl指定取消 = New System.Windows.Forms.Label()
        Me.lbl人数制限 = New System.Windows.Forms.Label()
        Me.cmb指定取消 = New System.Windows.Forms.ComboBox()
        Me.lblゼロ単価 = New System.Windows.Forms.Label()
        Me.cmbゼロ単価 = New System.Windows.Forms.ComboBox()
        Me.lbl人数入力 = New System.Windows.Forms.Label()
        Me.lbl客層入力 = New System.Windows.Forms.Label()
        Me.cmb客層入力 = New System.Windows.Forms.ComboBox()
        Me.cmb人数入力 = New System.Windows.Forms.ComboBox()
        Me.lbl担当入力 = New System.Windows.Forms.Label()
        Me.lblデータ保存月数 = New System.Windows.Forms.Label()
        Me.cmb担当入力 = New System.Windows.Forms.ComboBox()
        Me.grp店舗情報 = New System.Windows.Forms.GroupBox()
        Me.lbl住所ハイフン = New System.Windows.Forms.Label()
        Me.txt代表者 = New System.Windows.Forms.TextBox()
        Me.txt会社名 = New System.Windows.Forms.TextBox()
        Me.txtFAX = New System.Windows.Forms.TextBox()
        Me.txt電話 = New System.Windows.Forms.TextBox()
        Me.txt住所2 = New System.Windows.Forms.TextBox()
        Me.txt住所1 = New System.Windows.Forms.TextBox()
        Me.txt郵便2 = New System.Windows.Forms.TextBox()
        Me.txt郵便1 = New System.Windows.Forms.TextBox()
        Me.txt店舗名 = New System.Windows.Forms.TextBox()
        Me.txt店舗CD = New System.Windows.Forms.TextBox()
        Me.lbl電話FAX = New System.Windows.Forms.Label()
        Me.lbl代表者 = New System.Windows.Forms.Label()
        Me.lbl会社名 = New System.Windows.Forms.Label()
        Me.lbl店舗CD = New System.Windows.Forms.Label()
        Me.lbl住所 = New System.Windows.Forms.Label()
        Me.lbl店舗名 = New System.Windows.Forms.Label()
        Me.tabレシート領収レポート = New System.Windows.Forms.TabPage()
        Me.grp点検清算レポート = New System.Windows.Forms.GroupBox()
        Me.lbl客層0件明細印字 = New System.Windows.Forms.Label()
        Me.cmb客層0件明細印字 = New System.Windows.Forms.ComboBox()
        Me.lbl時間帯0件明細印字 = New System.Windows.Forms.Label()
        Me.lbl返品訂正集計印字 = New System.Windows.Forms.Label()
        Me.cmb返品訂正集計印字 = New System.Windows.Forms.ComboBox()
        Me.cmb時間帯0件明細印字 = New System.Windows.Forms.ComboBox()
        Me.lbl組人数内訳印字 = New System.Windows.Forms.Label()
        Me.lbl客数印字 = New System.Windows.Forms.Label()
        Me.cmb客数印字 = New System.Windows.Forms.ComboBox()
        Me.cmb組人数内訳印字 = New System.Windows.Forms.ComboBox()
        Me.grp領収情報 = New System.Windows.Forms.GroupBox()
        Me.txt備考 = New System.Windows.Forms.TextBox()
        Me.txt領収但し書き = New System.Windows.Forms.TextBox()
        Me.lbl備考 = New System.Windows.Forms.Label()
        Me.lbl収入印紙枠印刷 = New System.Windows.Forms.Label()
        Me.cmb収入印紙枠印刷 = New System.Windows.Forms.ComboBox()
        Me.lbl領収但し書き = New System.Windows.Forms.Label()
        Me.lbl領収名 = New System.Windows.Forms.Label()
        Me.cmb領収名 = New System.Windows.Forms.ComboBox()
        Me.grpレシート情報 = New System.Windows.Forms.GroupBox()
        Me.txtタイトル = New System.Windows.Forms.TextBox()
        Me.txt末尾ロゴ印刷 = New System.Windows.Forms.TextBox()
        Me.txt宣伝文3 = New System.Windows.Forms.TextBox()
        Me.txt宣伝文2 = New System.Windows.Forms.TextBox()
        Me.txt宣伝文1 = New System.Windows.Forms.TextBox()
        Me.lbl取引名印字文字サイズ追記 = New System.Windows.Forms.Label()
        Me.lbl末尾ロゴ印刷追記 = New System.Windows.Forms.Label()
        Me.lblクーポンカット = New System.Windows.Forms.Label()
        Me.lbl合計点数印字 = New System.Windows.Forms.Label()
        Me.cmb合計点数印字 = New System.Windows.Forms.ComboBox()
        Me.cmbクーポンカット = New System.Windows.Forms.ComboBox()
        Me.lblレシートNO = New System.Windows.Forms.Label()
        Me.lblタイトル = New System.Windows.Forms.Label()
        Me.lbl取引名印字文字サイズ = New System.Windows.Forms.Label()
        Me.cmbレシートNO = New System.Windows.Forms.ComboBox()
        Me.cmb取引名印字文字サイズ = New System.Windows.Forms.ComboBox()
        Me.lbl末尾ロゴ印刷 = New System.Windows.Forms.Label()
        Me.lblJANコード印刷 = New System.Windows.Forms.Label()
        Me.lbl税額内訳印刷 = New System.Windows.Forms.Label()
        Me.cmb末尾ロゴ印刷 = New System.Windows.Forms.ComboBox()
        Me.cmb税額内訳印刷 = New System.Windows.Forms.ComboBox()
        Me.cmbJANコード印刷 = New System.Windows.Forms.ComboBox()
        Me.lbl控発行 = New System.Windows.Forms.Label()
        Me.lbl宣伝文 = New System.Windows.Forms.Label()
        Me.lbl宣伝文印刷 = New System.Windows.Forms.Label()
        Me.cmbl控発行 = New System.Windows.Forms.ComboBox()
        Me.cmb宣伝文印刷 = New System.Windows.Forms.ComboBox()
        Me.tabFTPインポート = New System.Windows.Forms.TabPage()
        Me.grpマスタインポート設定 = New System.Windows.Forms.GroupBox()
        Me.txtCSV格納フォルダ = New System.Windows.Forms.TextBox()
        Me.btn参照 = New System.Windows.Forms.Button()
        Me.cmb自動起動区分 = New System.Windows.Forms.ComboBox()
        Me.lblCSV格納フォルダ = New System.Windows.Forms.Label()
        Me.lbl自動起動区分 = New System.Windows.Forms.Label()
        Me.grpFTP設定 = New System.Windows.Forms.GroupBox()
        Me.grp受信時設定 = New System.Windows.Forms.GroupBox()
        Me.btn受信時設定通信確認 = New System.Windows.Forms.Button()
        Me.txt受信元サーバフォルダ = New System.Windows.Forms.TextBox()
        Me.lbl受信元サーバフォルダ = New System.Windows.Forms.Label()
        Me.txt受信時対象ファイル種類 = New System.Windows.Forms.TextBox()
        Me.txt受信時パスワード = New System.Windows.Forms.TextBox()
        Me.txt受信時ユーザー名 = New System.Windows.Forms.TextBox()
        Me.lbl受信時対象ファイル種類 = New System.Windows.Forms.Label()
        Me.lbl受信時パスワード = New System.Windows.Forms.Label()
        Me.lbl受信時ユーザー名 = New System.Windows.Forms.Label()
        Me.grp送信時設定 = New System.Windows.Forms.GroupBox()
        Me.btn送信時設定通信確認 = New System.Windows.Forms.Button()
        Me.txt送信先サーバフォルダ = New System.Windows.Forms.TextBox()
        Me.lbl送信モード = New System.Windows.Forms.Label()
        Me.lbl送信先サーバフォルダ = New System.Windows.Forms.Label()
        Me.txt送信時対象ファイル種類 = New System.Windows.Forms.TextBox()
        Me.txt送信時パスワード = New System.Windows.Forms.TextBox()
        Me.cmb送信モード = New System.Windows.Forms.ComboBox()
        Me.txt送信時ユーザー名 = New System.Windows.Forms.TextBox()
        Me.lbl送信時対象ファイル種類 = New System.Windows.Forms.Label()
        Me.lbl送信時パスワード = New System.Windows.Forms.Label()
        Me.lbl送信時ユーザー名 = New System.Windows.Forms.Label()
        Me.txtタイムアウト = New System.Windows.Forms.TextBox()
        Me.txt送受信間隔 = New System.Windows.Forms.TextBox()
        Me.txt接続先 = New System.Windows.Forms.TextBox()
        Me.lblタイムアウト = New System.Windows.Forms.Label()
        Me.lbl使用区分 = New System.Windows.Forms.Label()
        Me.lbl送受信間隔 = New System.Windows.Forms.Label()
        Me.lbl接続先 = New System.Windows.Forms.Label()
        Me.cmb使用区分 = New System.Windows.Forms.ComboBox()
        Me.tabログジャーナル = New System.Windows.Forms.TabPage()
        Me.grpジャーナル出力 = New System.Windows.Forms.GroupBox()
        Me.cmb見出し行 = New System.Windows.Forms.ComboBox()
        Me.lbl見出し行 = New System.Windows.Forms.Label()
        Me.txtジャーナル出力先フォルダ = New System.Windows.Forms.TextBox()
        Me.btnジャーナル出力先フォルダ参照 = New System.Windows.Forms.Button()
        Me.cmb一括取消の出力 = New System.Windows.Forms.ComboBox()
        Me.lblジャーナル出力先フォルダ = New System.Windows.Forms.Label()
        Me.lbl一括取消の出力 = New System.Windows.Forms.Label()
        Me.grp電子ジャーナル出力 = New System.Windows.Forms.GroupBox()
        Me.txtフォルダサイズ上限値 = New System.Windows.Forms.TextBox()
        Me.txt電子ジャーナル出力先フォルダ = New System.Windows.Forms.TextBox()
        Me.btn電子ジャーナル出力先フォルダ参照 = New System.Windows.Forms.Button()
        Me.lblフォルダサイズ上限値 = New System.Windows.Forms.Label()
        Me.lbl電子ジャーナル出力先フォルダ = New System.Windows.Forms.Label()
        Me.btn終了 = New System.Windows.Forms.Button()
        Me.btn更新 = New System.Windows.Forms.Button()
        Me.tabc店舗基本情報.SuspendLayout()
        Me.tab基本情報.SuspendLayout()
        Me.grp販売モードとテイクアウト.SuspendLayout()
        Me.grpその他設定.SuspendLayout()
        Me.grp画面文字サイズ設定.SuspendLayout()
        Me.grpバーコード設定.SuspendLayout()
        Me.grpDB情報.SuspendLayout()
        Me.grp預かり金入力設定.SuspendLayout()
        Me.grpその他基本情報.SuspendLayout()
        Me.grp店舗情報.SuspendLayout()
        Me.tabレシート領収レポート.SuspendLayout()
        Me.grp点検清算レポート.SuspendLayout()
        Me.grp領収情報.SuspendLayout()
        Me.grpレシート情報.SuspendLayout()
        Me.tabFTPインポート.SuspendLayout()
        Me.grpマスタインポート設定.SuspendLayout()
        Me.grpFTP設定.SuspendLayout()
        Me.grp受信時設定.SuspendLayout()
        Me.grp送信時設定.SuspendLayout()
        Me.tabログジャーナル.SuspendLayout()
        Me.grpジャーナル出力.SuspendLayout()
        Me.grp電子ジャーナル出力.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabc店舗基本情報
        '
        Me.tabc店舗基本情報.Controls.Add(Me.tab基本情報)
        Me.tabc店舗基本情報.Controls.Add(Me.tabレシート領収レポート)
        Me.tabc店舗基本情報.Controls.Add(Me.tabFTPインポート)
        Me.tabc店舗基本情報.Controls.Add(Me.tabログジャーナル)
        Me.tabc店舗基本情報.Location = New System.Drawing.Point(12, 50)
        Me.tabc店舗基本情報.Name = "tabc店舗基本情報"
        Me.tabc店舗基本情報.SelectedIndex = 0
        Me.tabc店舗基本情報.Size = New System.Drawing.Size(987, 667)
        Me.tabc店舗基本情報.TabIndex = 0
        '
        'tab基本情報
        '
        Me.tab基本情報.Controls.Add(Me.grp販売モードとテイクアウト)
        Me.tab基本情報.Controls.Add(Me.grpその他設定)
        Me.tab基本情報.Controls.Add(Me.grp画面文字サイズ設定)
        Me.tab基本情報.Controls.Add(Me.grpバーコード設定)
        Me.tab基本情報.Controls.Add(Me.grpDB情報)
        Me.tab基本情報.Controls.Add(Me.grp預かり金入力設定)
        Me.tab基本情報.Controls.Add(Me.grpその他基本情報)
        Me.tab基本情報.Controls.Add(Me.grp店舗情報)
        Me.tab基本情報.Location = New System.Drawing.Point(4, 22)
        Me.tab基本情報.Name = "tab基本情報"
        Me.tab基本情報.Padding = New System.Windows.Forms.Padding(3)
        Me.tab基本情報.Size = New System.Drawing.Size(979, 641)
        Me.tab基本情報.TabIndex = 0
        Me.tab基本情報.Text = "基本情報"
        Me.tab基本情報.UseVisualStyleBackColor = True
        '
        'grp販売モードとテイクアウト
        '
        Me.grp販売モードとテイクアウト.Controls.Add(Me.lblモードリセット)
        Me.grp販売モードとテイクアウト.Controls.Add(Me.lbl初期モード)
        Me.grp販売モードとテイクアウト.Controls.Add(Me.cmb初期モード)
        Me.grp販売モードとテイクアウト.Controls.Add(Me.cmbモードリセット)
        Me.grp販売モードとテイクアウト.Location = New System.Drawing.Point(422, 447)
        Me.grp販売モードとテイクアウト.Name = "grp販売モードとテイクアウト"
        Me.grp販売モードとテイクアウト.Size = New System.Drawing.Size(551, 93)
        Me.grp販売モードとテイクアウト.TabIndex = 45
        Me.grp販売モードとテイクアウト.TabStop = False
        Me.grp販売モードとテイクアウト.Text = "販売モードとテイクアウト"
        '
        'lblモードリセット
        '
        Me.lblモードリセット.AutoSize = True
        Me.lblモードリセット.Location = New System.Drawing.Point(11, 44)
        Me.lblモードリセット.Name = "lblモードリセット"
        Me.lblモードリセット.Size = New System.Drawing.Size(65, 12)
        Me.lblモードリセット.TabIndex = 27
        Me.lblモードリセット.Text = "モードリセット"
        '
        'lbl初期モード
        '
        Me.lbl初期モード.AutoSize = True
        Me.lbl初期モード.Location = New System.Drawing.Point(11, 21)
        Me.lbl初期モード.Name = "lbl初期モード"
        Me.lbl初期モード.Size = New System.Drawing.Size(57, 12)
        Me.lbl初期モード.TabIndex = 28
        Me.lbl初期モード.Text = "初期モード"
        '
        'cmb初期モード
        '
        Me.cmb初期モード.FormattingEnabled = True
        Me.cmb初期モード.Items.AddRange(New Object() {"起動時、通常販売モードとする", "起動時、テイクアウト販売モードとする"})
        Me.cmb初期モード.Location = New System.Drawing.Point(117, 18)
        Me.cmb初期モード.Name = "cmb初期モード"
        Me.cmb初期モード.Size = New System.Drawing.Size(413, 20)
        Me.cmb初期モード.TabIndex = 30
        '
        'cmbモードリセット
        '
        Me.cmbモードリセット.FormattingEnabled = True
        Me.cmbモードリセット.Items.AddRange(New Object() {"商品毎に起動モードに戻す", "ボタン操作で初期モードにリセットする", "会計毎に起動モードに戻す"})
        Me.cmbモードリセット.Location = New System.Drawing.Point(117, 41)
        Me.cmbモードリセット.Name = "cmbモードリセット"
        Me.cmbモードリセット.Size = New System.Drawing.Size(413, 20)
        Me.cmbモードリセット.TabIndex = 29
        '
        'grpその他設定
        '
        Me.grpその他設定.Controls.Add(Me.lblページタグ数)
        Me.grpその他設定.Controls.Add(Me.lbl金種表入力チェック)
        Me.grpその他設定.Controls.Add(Me.cmb金種表入力ﾁｪｯｸ)
        Me.grpその他設定.Controls.Add(Me.cmbページタグ数)
        Me.grpその他設定.Location = New System.Drawing.Point(422, 352)
        Me.grpその他設定.Name = "grpその他設定"
        Me.grpその他設定.Size = New System.Drawing.Size(551, 89)
        Me.grpその他設定.TabIndex = 44
        Me.grpその他設定.TabStop = False
        Me.grpその他設定.Text = "その他設定"
        '
        'lblページタグ数
        '
        Me.lblページタグ数.AutoSize = True
        Me.lblページタグ数.Location = New System.Drawing.Point(11, 44)
        Me.lblページタグ数.Name = "lblページタグ数"
        Me.lblページタグ数.Size = New System.Drawing.Size(64, 12)
        Me.lblページタグ数.TabIndex = 27
        Me.lblページタグ数.Text = "ページタグ数"
        '
        'lbl金種表入力チェック
        '
        Me.lbl金種表入力チェック.AutoSize = True
        Me.lbl金種表入力チェック.Location = New System.Drawing.Point(11, 21)
        Me.lbl金種表入力チェック.Name = "lbl金種表入力チェック"
        Me.lbl金種表入力チェック.Size = New System.Drawing.Size(90, 12)
        Me.lbl金種表入力チェック.TabIndex = 28
        Me.lbl金種表入力チェック.Text = "金種表入力ﾁｪｯｸ"
        '
        'cmb金種表入力ﾁｪｯｸ
        '
        Me.cmb金種表入力ﾁｪｯｸ.FormattingEnabled = True
        Me.cmb金種表入力ﾁｪｯｸ.Items.AddRange(New Object() {"入力チェックを行う", "入力チェックを行わない"})
        Me.cmb金種表入力ﾁｪｯｸ.Location = New System.Drawing.Point(117, 18)
        Me.cmb金種表入力ﾁｪｯｸ.Name = "cmb金種表入力ﾁｪｯｸ"
        Me.cmb金種表入力ﾁｪｯｸ.Size = New System.Drawing.Size(413, 20)
        Me.cmb金種表入力ﾁｪｯｸ.TabIndex = 30
        '
        'cmbページタグ数
        '
        Me.cmbページタグ数.FormattingEnabled = True
        Me.cmbページタグ数.Items.AddRange(New Object() {"ページタグ数「４」", "ページタグ数「８」"})
        Me.cmbページタグ数.Location = New System.Drawing.Point(117, 41)
        Me.cmbページタグ数.Name = "cmbページタグ数"
        Me.cmbページタグ数.Size = New System.Drawing.Size(413, 20)
        Me.cmbページタグ数.TabIndex = 29
        '
        'grp画面文字サイズ設定
        '
        Me.grp画面文字サイズ設定.Controls.Add(Me.lbl会計明細文字)
        Me.grp画面文字サイズ設定.Controls.Add(Me.lblメニュー文字)
        Me.grp画面文字サイズ設定.Controls.Add(Me.cmbメニュー文字)
        Me.grp画面文字サイズ設定.Controls.Add(Me.cmb会計明細文字)
        Me.grp画面文字サイズ設定.Location = New System.Drawing.Point(422, 284)
        Me.grp画面文字サイズ設定.Name = "grp画面文字サイズ設定"
        Me.grp画面文字サイズ設定.Size = New System.Drawing.Size(551, 62)
        Me.grp画面文字サイズ設定.TabIndex = 44
        Me.grp画面文字サイズ設定.TabStop = False
        Me.grp画面文字サイズ設定.Text = "画面文字サイズ設定"
        '
        'lbl会計明細文字
        '
        Me.lbl会計明細文字.AutoSize = True
        Me.lbl会計明細文字.Location = New System.Drawing.Point(262, 21)
        Me.lbl会計明細文字.Name = "lbl会計明細文字"
        Me.lbl会計明細文字.Size = New System.Drawing.Size(77, 12)
        Me.lbl会計明細文字.TabIndex = 27
        Me.lbl会計明細文字.Text = "会計明細文字"
        '
        'lblメニュー文字
        '
        Me.lblメニュー文字.AutoSize = True
        Me.lblメニュー文字.Location = New System.Drawing.Point(11, 21)
        Me.lblメニュー文字.Name = "lblメニュー文字"
        Me.lblメニュー文字.Size = New System.Drawing.Size(64, 12)
        Me.lblメニュー文字.TabIndex = 28
        Me.lblメニュー文字.Text = "メニュー文字"
        '
        'cmbメニュー文字
        '
        Me.cmbメニュー文字.FormattingEnabled = True
        Me.cmbメニュー文字.Items.AddRange(New Object() {"通常", "拡大"})
        Me.cmbメニュー文字.Location = New System.Drawing.Point(117, 18)
        Me.cmbメニュー文字.Name = "cmbメニュー文字"
        Me.cmbメニュー文字.Size = New System.Drawing.Size(91, 20)
        Me.cmbメニュー文字.TabIndex = 30
        '
        'cmb会計明細文字
        '
        Me.cmb会計明細文字.FormattingEnabled = True
        Me.cmb会計明細文字.Items.AddRange(New Object() {"通常", "拡大"})
        Me.cmb会計明細文字.Location = New System.Drawing.Point(368, 18)
        Me.cmb会計明細文字.Name = "cmb会計明細文字"
        Me.cmb会計明細文字.Size = New System.Drawing.Size(91, 20)
        Me.cmb会計明細文字.TabIndex = 29
        '
        'grpバーコード設定
        '
        Me.grpバーコード設定.Controls.Add(Me.lbl雑誌バーコード)
        Me.grpバーコード設定.Controls.Add(Me.cmb雑誌バーコード)
        Me.grpバーコード設定.Controls.Add(Me.lbl書籍バーコード)
        Me.grpバーコード設定.Controls.Add(Me.lbl単価付バーコード)
        Me.grpバーコード設定.Controls.Add(Me.cmb単価付バーコード)
        Me.grpバーコード設定.Controls.Add(Me.cmb書籍バーコード)
        Me.grpバーコード設定.Location = New System.Drawing.Point(422, 164)
        Me.grpバーコード設定.Name = "grpバーコード設定"
        Me.grpバーコード設定.Size = New System.Drawing.Size(551, 114)
        Me.grpバーコード設定.TabIndex = 43
        Me.grpバーコード設定.TabStop = False
        Me.grpバーコード設定.Text = "バーコード設定"
        '
        'lbl雑誌バーコード
        '
        Me.lbl雑誌バーコード.AutoSize = True
        Me.lbl雑誌バーコード.Location = New System.Drawing.Point(11, 67)
        Me.lbl雑誌バーコード.Name = "lbl雑誌バーコード"
        Me.lbl雑誌バーコード.Size = New System.Drawing.Size(71, 12)
        Me.lbl雑誌バーコード.TabIndex = 32
        Me.lbl雑誌バーコード.Text = "雑誌ﾊﾞｰｺｰﾄﾞ"
        '
        'cmb雑誌バーコード
        '
        Me.cmb雑誌バーコード.FormattingEnabled = True
        Me.cmb雑誌バーコード.Items.AddRange(New Object() {"バーコード上3桁=491バーコード雑誌として扱う", "バーコード上3桁=491バーコード雑誌として扱わない"})
        Me.cmb雑誌バーコード.Location = New System.Drawing.Point(117, 64)
        Me.cmb雑誌バーコード.Name = "cmb雑誌バーコード"
        Me.cmb雑誌バーコード.Size = New System.Drawing.Size(413, 20)
        Me.cmb雑誌バーコード.TabIndex = 34
        '
        'lbl書籍バーコード
        '
        Me.lbl書籍バーコード.AutoSize = True
        Me.lbl書籍バーコード.Location = New System.Drawing.Point(11, 44)
        Me.lbl書籍バーコード.Name = "lbl書籍バーコード"
        Me.lbl書籍バーコード.Size = New System.Drawing.Size(71, 12)
        Me.lbl書籍バーコード.TabIndex = 27
        Me.lbl書籍バーコード.Text = "書籍ﾊﾞｰｺｰﾄﾞ"
        '
        'lbl単価付バーコード
        '
        Me.lbl単価付バーコード.AutoSize = True
        Me.lbl単価付バーコード.Location = New System.Drawing.Point(11, 21)
        Me.lbl単価付バーコード.Name = "lbl単価付バーコード"
        Me.lbl単価付バーコード.Size = New System.Drawing.Size(83, 12)
        Me.lbl単価付バーコード.TabIndex = 28
        Me.lbl単価付バーコード.Text = "単価付ﾊﾞｰｺｰﾄﾞ"
        '
        'cmb単価付バーコード
        '
        Me.cmb単価付バーコード.FormattingEnabled = True
        Me.cmb単価付バーコード.Items.AddRange(New Object() {"バーコード上2桁=20 単価付バーコードとする", "バーコード上2桁=20 単価付バーコードとしない"})
        Me.cmb単価付バーコード.Location = New System.Drawing.Point(117, 18)
        Me.cmb単価付バーコード.Name = "cmb単価付バーコード"
        Me.cmb単価付バーコード.Size = New System.Drawing.Size(413, 20)
        Me.cmb単価付バーコード.TabIndex = 30
        '
        'cmb書籍バーコード
        '
        Me.cmb書籍バーコード.FormattingEnabled = True
        Me.cmb書籍バーコード.Items.AddRange(New Object() {"バーコード上3桁=978バーコード書籍として扱う", "バーコード上3桁=978バーコード書籍として扱わない"})
        Me.cmb書籍バーコード.Location = New System.Drawing.Point(117, 41)
        Me.cmb書籍バーコード.Name = "cmb書籍バーコード"
        Me.cmb書籍バーコード.Size = New System.Drawing.Size(413, 20)
        Me.cmb書籍バーコード.TabIndex = 29
        '
        'grpDB情報
        '
        Me.grpDB情報.Controls.Add(Me.txtDBサイズ警告上限値)
        Me.grpDB情報.Controls.Add(Me.txtBKUP複写先フォルダ２)
        Me.grpDB情報.Controls.Add(Me.txtBKUP複写先フォルダ１)
        Me.grpDB情報.Controls.Add(Me.lblBKUP複写先フォルダ１)
        Me.grpDB情報.Controls.Add(Me.lblDBサイズ警告上限値)
        Me.grpDB情報.Controls.Add(Me.lblBKUP複写先フォルダ２)
        Me.grpDB情報.Location = New System.Drawing.Point(422, 6)
        Me.grpDB情報.Name = "grpDB情報"
        Me.grpDB情報.Size = New System.Drawing.Size(551, 152)
        Me.grpDB情報.TabIndex = 47
        Me.grpDB情報.TabStop = False
        Me.grpDB情報.Text = "DB情報"
        '
        'txtDBサイズ警告上限値
        '
        Me.txtDBサイズ警告上限値.Location = New System.Drawing.Point(160, 110)
        Me.txtDBサイズ警告上限値.Name = "txtDBサイズ警告上限値"
        Me.txtDBサイズ警告上限値.Size = New System.Drawing.Size(48, 19)
        Me.txtDBサイズ警告上限値.TabIndex = 37
        '
        'txtBKUP複写先フォルダ２
        '
        Me.txtBKUP複写先フォルダ２.Location = New System.Drawing.Point(13, 88)
        Me.txtBKUP複写先フォルダ２.Name = "txtBKUP複写先フォルダ２"
        Me.txtBKUP複写先フォルダ２.Size = New System.Drawing.Size(517, 19)
        Me.txtBKUP複写先フォルダ２.TabIndex = 36
        '
        'txtBKUP複写先フォルダ１
        '
        Me.txtBKUP複写先フォルダ１.Location = New System.Drawing.Point(13, 43)
        Me.txtBKUP複写先フォルダ１.Name = "txtBKUP複写先フォルダ１"
        Me.txtBKUP複写先フォルダ１.Size = New System.Drawing.Size(517, 19)
        Me.txtBKUP複写先フォルダ１.TabIndex = 35
        '
        'lblBKUP複写先フォルダ１
        '
        Me.lblBKUP複写先フォルダ１.AutoSize = True
        Me.lblBKUP複写先フォルダ１.Location = New System.Drawing.Point(11, 24)
        Me.lblBKUP複写先フォルダ１.Name = "lblBKUP複写先フォルダ１"
        Me.lblBKUP複写先フォルダ１.Size = New System.Drawing.Size(123, 12)
        Me.lblBKUP複写先フォルダ１.TabIndex = 3
        Me.lblBKUP複写先フォルダ１.Text = "ﾊﾞｯｸｱｯﾌﾟ複写先ﾌｫﾙﾀﾞ1"
        '
        'lblDBサイズ警告上限値
        '
        Me.lblDBサイズ警告上限値.AutoSize = True
        Me.lblDBサイズ警告上限値.Location = New System.Drawing.Point(11, 113)
        Me.lblDBサイズ警告上限値.Name = "lblDBサイズ警告上限値"
        Me.lblDBサイズ警告上限値.Size = New System.Drawing.Size(132, 12)
        Me.lblDBサイズ警告上限値.TabIndex = 5
        Me.lblDBサイズ警告上限値.Text = "DBｻｲｽﾞ警告上限値(MB)"
        '
        'lblBKUP複写先フォルダ２
        '
        Me.lblBKUP複写先フォルダ２.AutoSize = True
        Me.lblBKUP複写先フォルダ２.Location = New System.Drawing.Point(11, 70)
        Me.lblBKUP複写先フォルダ２.Name = "lblBKUP複写先フォルダ２"
        Me.lblBKUP複写先フォルダ２.Size = New System.Drawing.Size(123, 12)
        Me.lblBKUP複写先フォルダ２.TabIndex = 6
        Me.lblBKUP複写先フォルダ２.Text = "ﾊﾞｯｸｱｯﾌﾟ複写先ﾌｫﾙﾀﾞ2"
        '
        'grp預かり金入力設定
        '
        Me.grp預かり金入力設定.Controls.Add(Me.cmb釣銭準備金)
        Me.grp預かり金入力設定.Controls.Add(Me.txt釣銭機残値)
        Me.grp預かり金入力設定.Controls.Add(Me.lbl釣銭機残値)
        Me.grp預かり金入力設定.Controls.Add(Me.lbl釣銭準備金)
        Me.grp預かり金入力設定.Controls.Add(Me.cmb現金以外)
        Me.grp預かり金入力設定.Controls.Add(Me.lbl現金以外)
        Me.grp預かり金入力設定.Controls.Add(Me.lbl現金)
        Me.grp預かり金入力設定.Controls.Add(Me.cmb現金)
        Me.grp預かり金入力設定.Location = New System.Drawing.Point(6, 466)
        Me.grp預かり金入力設定.Name = "grp預かり金入力設定"
        Me.grp預かり金入力設定.Size = New System.Drawing.Size(393, 111)
        Me.grp預かり金入力設定.TabIndex = 20
        Me.grp預かり金入力設定.TabStop = False
        Me.grp預かり金入力設定.Text = "預かり金入力設定"
        '
        'cmb釣銭準備金
        '
        Me.cmb釣銭準備金.FormattingEnabled = True
        Me.cmb釣銭準備金.Items.AddRange(New Object() {"表示する", "表示しない"})
        Me.cmb釣銭準備金.Location = New System.Drawing.Point(117, 63)
        Me.cmb釣銭準備金.Name = "cmb釣銭準備金"
        Me.cmb釣銭準備金.Size = New System.Drawing.Size(101, 20)
        Me.cmb釣銭準備金.TabIndex = 42
        '
        'txt釣銭機残値
        '
        Me.txt釣銭機残値.Location = New System.Drawing.Point(295, 63)
        Me.txt釣銭機残値.Name = "txt釣銭機残値"
        Me.txt釣銭機残値.Size = New System.Drawing.Size(78, 19)
        Me.txt釣銭機残値.TabIndex = 40
        '
        'lbl釣銭機残値
        '
        Me.lbl釣銭機残値.AutoSize = True
        Me.lbl釣銭機残値.Location = New System.Drawing.Point(224, 66)
        Me.lbl釣銭機残値.Name = "lbl釣銭機残値"
        Me.lbl釣銭機残値.Size = New System.Drawing.Size(65, 12)
        Me.lbl釣銭機残値.TabIndex = 31
        Me.lbl釣銭機残値.Text = "釣銭機残値"
        '
        'lbl釣銭準備金
        '
        Me.lbl釣銭準備金.AutoSize = True
        Me.lbl釣銭準備金.Location = New System.Drawing.Point(12, 66)
        Me.lbl釣銭準備金.Name = "lbl釣銭準備金"
        Me.lbl釣銭準備金.Size = New System.Drawing.Size(65, 12)
        Me.lbl釣銭準備金.TabIndex = 32
        Me.lbl釣銭準備金.Text = "釣銭準備金"
        '
        'cmb現金以外
        '
        Me.cmb現金以外.FormattingEnabled = True
        Me.cmb現金以外.Items.AddRange(New Object() {"現金以外の預かりを必ず入力する", "現金以外の預かりを省略可能とする"})
        Me.cmb現金以外.Location = New System.Drawing.Point(117, 41)
        Me.cmb現金以外.Name = "cmb現金以外"
        Me.cmb現金以外.Size = New System.Drawing.Size(256, 20)
        Me.cmb現金以外.TabIndex = 34
        '
        'lbl現金以外
        '
        Me.lbl現金以外.AutoSize = True
        Me.lbl現金以外.Location = New System.Drawing.Point(12, 44)
        Me.lbl現金以外.Name = "lbl現金以外"
        Me.lbl現金以外.Size = New System.Drawing.Size(53, 12)
        Me.lbl現金以外.TabIndex = 27
        Me.lbl現金以外.Text = "現金以外"
        '
        'lbl現金
        '
        Me.lbl現金.AutoSize = True
        Me.lbl現金.Location = New System.Drawing.Point(12, 21)
        Me.lbl現金.Name = "lbl現金"
        Me.lbl現金.Size = New System.Drawing.Size(29, 12)
        Me.lbl現金.TabIndex = 28
        Me.lbl現金.Text = "現金"
        '
        'cmb現金
        '
        Me.cmb現金.FormattingEnabled = True
        Me.cmb現金.Items.AddRange(New Object() {"預かり金額を入力する（省略不可）", "預かり金額を入力する（省略可）", "釣銭機から預かり金を取得する"})
        Me.cmb現金.Location = New System.Drawing.Point(117, 18)
        Me.cmb現金.Name = "cmb現金"
        Me.cmb現金.Size = New System.Drawing.Size(256, 20)
        Me.cmb現金.TabIndex = 30
        '
        'grpその他基本情報
        '
        Me.grpその他基本情報.Controls.Add(Me.txt明細数制限)
        Me.grpその他基本情報.Controls.Add(Me.lbl明細数制限)
        Me.grpその他基本情報.Controls.Add(Me.txt人数制限)
        Me.grpその他基本情報.Controls.Add(Me.txtデータ保存月数)
        Me.grpその他基本情報.Controls.Add(Me.lbl消費税端数)
        Me.grpその他基本情報.Controls.Add(Me.cmb消費税端数)
        Me.grpその他基本情報.Controls.Add(Me.lbl指定取消)
        Me.grpその他基本情報.Controls.Add(Me.lbl人数制限)
        Me.grpその他基本情報.Controls.Add(Me.cmb指定取消)
        Me.grpその他基本情報.Controls.Add(Me.lblゼロ単価)
        Me.grpその他基本情報.Controls.Add(Me.cmbゼロ単価)
        Me.grpその他基本情報.Controls.Add(Me.lbl人数入力)
        Me.grpその他基本情報.Controls.Add(Me.lbl客層入力)
        Me.grpその他基本情報.Controls.Add(Me.cmb客層入力)
        Me.grpその他基本情報.Controls.Add(Me.cmb人数入力)
        Me.grpその他基本情報.Controls.Add(Me.lbl担当入力)
        Me.grpその他基本情報.Controls.Add(Me.lblデータ保存月数)
        Me.grpその他基本情報.Controls.Add(Me.cmb担当入力)
        Me.grpその他基本情報.Location = New System.Drawing.Point(6, 229)
        Me.grpその他基本情報.Name = "grpその他基本情報"
        Me.grpその他基本情報.Size = New System.Drawing.Size(393, 231)
        Me.grpその他基本情報.TabIndex = 19
        Me.grpその他基本情報.TabStop = False
        Me.grpその他基本情報.Text = "その他基本情報"
        '
        'txt明細数制限
        '
        Me.txt明細数制限.Location = New System.Drawing.Point(245, 133)
        Me.txt明細数制限.Name = "txt明細数制限"
        Me.txt明細数制限.Size = New System.Drawing.Size(38, 19)
        Me.txt明細数制限.TabIndex = 49
        '
        'lbl明細数制限
        '
        Me.lbl明細数制限.AutoSize = True
        Me.lbl明細数制限.Location = New System.Drawing.Point(165, 136)
        Me.lbl明細数制限.Name = "lbl明細数制限"
        Me.lbl明細数制限.Size = New System.Drawing.Size(65, 12)
        Me.lbl明細数制限.TabIndex = 48
        Me.lbl明細数制限.Text = "明細数制限"
        '
        'txt人数制限
        '
        Me.txt人数制限.Location = New System.Drawing.Point(117, 133)
        Me.txt人数制限.Name = "txt人数制限"
        Me.txt人数制限.Size = New System.Drawing.Size(38, 19)
        Me.txt人数制限.TabIndex = 47
        '
        'txtデータ保存月数
        '
        Me.txtデータ保存月数.Location = New System.Drawing.Point(117, 18)
        Me.txtデータ保存月数.Name = "txtデータ保存月数"
        Me.txtデータ保存月数.Size = New System.Drawing.Size(38, 19)
        Me.txtデータ保存月数.TabIndex = 46
        '
        'lbl消費税端数
        '
        Me.lbl消費税端数.AutoSize = True
        Me.lbl消費税端数.Location = New System.Drawing.Point(11, 182)
        Me.lbl消費税端数.Name = "lbl消費税端数"
        Me.lbl消費税端数.Size = New System.Drawing.Size(65, 12)
        Me.lbl消費税端数.TabIndex = 41
        Me.lbl消費税端数.Text = "消費税端数"
        '
        'cmb消費税端数
        '
        Me.cmb消費税端数.FormattingEnabled = True
        Me.cmb消費税端数.Items.AddRange(New Object() {"切り捨て", "切り上げ", "四捨五入"})
        Me.cmb消費税端数.Location = New System.Drawing.Point(117, 179)
        Me.cmb消費税端数.Name = "cmb消費税端数"
        Me.cmb消費税端数.Size = New System.Drawing.Size(256, 20)
        Me.cmb消費税端数.TabIndex = 42
        '
        'lbl指定取消
        '
        Me.lbl指定取消.AutoSize = True
        Me.lbl指定取消.Location = New System.Drawing.Point(11, 159)
        Me.lbl指定取消.Name = "lbl指定取消"
        Me.lbl指定取消.Size = New System.Drawing.Size(53, 12)
        Me.lbl指定取消.TabIndex = 37
        Me.lbl指定取消.Text = "指定取消"
        '
        'lbl人数制限
        '
        Me.lbl人数制限.AutoSize = True
        Me.lbl人数制限.Location = New System.Drawing.Point(11, 136)
        Me.lbl人数制限.Name = "lbl人数制限"
        Me.lbl人数制限.Size = New System.Drawing.Size(53, 12)
        Me.lbl人数制限.TabIndex = 38
        Me.lbl人数制限.Text = "人数制限"
        '
        'cmb指定取消
        '
        Me.cmb指定取消.FormattingEnabled = True
        Me.cmb指定取消.Items.AddRange(New Object() {"指定取消で明細を削除する", "指定取消で明細を削除しない（グレーアウト）"})
        Me.cmb指定取消.Location = New System.Drawing.Point(117, 156)
        Me.cmb指定取消.Name = "cmb指定取消"
        Me.cmb指定取消.Size = New System.Drawing.Size(256, 20)
        Me.cmb指定取消.TabIndex = 39
        '
        'lblゼロ単価
        '
        Me.lblゼロ単価.AutoSize = True
        Me.lblゼロ単価.Location = New System.Drawing.Point(11, 113)
        Me.lblゼロ単価.Name = "lblゼロ単価"
        Me.lblゼロ単価.Size = New System.Drawing.Size(48, 12)
        Me.lblゼロ単価.TabIndex = 35
        Me.lblゼロ単価.Text = "ゼロ単価"
        '
        'cmbゼロ単価
        '
        Me.cmbゼロ単価.FormattingEnabled = True
        Me.cmbゼロ単価.Items.AddRange(New Object() {"ゼロ単価を許可する", "ゼロ単価を警告する"})
        Me.cmbゼロ単価.Location = New System.Drawing.Point(117, 110)
        Me.cmbゼロ単価.Name = "cmbゼロ単価"
        Me.cmbゼロ単価.Size = New System.Drawing.Size(256, 20)
        Me.cmbゼロ単価.TabIndex = 36
        '
        'lbl人数入力
        '
        Me.lbl人数入力.AutoSize = True
        Me.lbl人数入力.Location = New System.Drawing.Point(11, 90)
        Me.lbl人数入力.Name = "lbl人数入力"
        Me.lbl人数入力.Size = New System.Drawing.Size(53, 12)
        Me.lbl人数入力.TabIndex = 31
        Me.lbl人数入力.Text = "人数入力"
        '
        'lbl客層入力
        '
        Me.lbl客層入力.AutoSize = True
        Me.lbl客層入力.Location = New System.Drawing.Point(11, 67)
        Me.lbl客層入力.Name = "lbl客層入力"
        Me.lbl客層入力.Size = New System.Drawing.Size(53, 12)
        Me.lbl客層入力.TabIndex = 32
        Me.lbl客層入力.Text = "客層入力"
        '
        'cmb客層入力
        '
        Me.cmb客層入力.FormattingEnabled = True
        Me.cmb客層入力.Items.AddRange(New Object() {"客層を省略可能とする。", "客層１のみ必ず入力する。", "客層１・客層２を必ず入力する。"})
        Me.cmb客層入力.Location = New System.Drawing.Point(117, 64)
        Me.cmb客層入力.Name = "cmb客層入力"
        Me.cmb客層入力.Size = New System.Drawing.Size(256, 20)
        Me.cmb客層入力.TabIndex = 34
        '
        'cmb人数入力
        '
        Me.cmb人数入力.FormattingEnabled = True
        Me.cmb人数入力.Items.AddRange(New Object() {"利用人数を省略可能とする。", "利用人数を必ず入力する。"})
        Me.cmb人数入力.Location = New System.Drawing.Point(117, 87)
        Me.cmb人数入力.Name = "cmb人数入力"
        Me.cmb人数入力.Size = New System.Drawing.Size(256, 20)
        Me.cmb人数入力.TabIndex = 33
        '
        'lbl担当入力
        '
        Me.lbl担当入力.AutoSize = True
        Me.lbl担当入力.Location = New System.Drawing.Point(11, 44)
        Me.lbl担当入力.Name = "lbl担当入力"
        Me.lbl担当入力.Size = New System.Drawing.Size(53, 12)
        Me.lbl担当入力.TabIndex = 27
        Me.lbl担当入力.Text = "担当入力"
        '
        'lblデータ保存月数
        '
        Me.lblデータ保存月数.AutoSize = True
        Me.lblデータ保存月数.Location = New System.Drawing.Point(11, 21)
        Me.lblデータ保存月数.Name = "lblデータ保存月数"
        Me.lblデータ保存月数.Size = New System.Drawing.Size(77, 12)
        Me.lblデータ保存月数.TabIndex = 28
        Me.lblデータ保存月数.Text = "ﾃﾞｰﾀ保存月数"
        '
        'cmb担当入力
        '
        Me.cmb担当入力.FormattingEnabled = True
        Me.cmb担当入力.Items.AddRange(New Object() {"担当を会計毎に入力しない。", "担当を会計毎に入力する。"})
        Me.cmb担当入力.Location = New System.Drawing.Point(117, 41)
        Me.cmb担当入力.Name = "cmb担当入力"
        Me.cmb担当入力.Size = New System.Drawing.Size(256, 20)
        Me.cmb担当入力.TabIndex = 29
        '
        'grp店舗情報
        '
        Me.grp店舗情報.Controls.Add(Me.lbl住所ハイフン)
        Me.grp店舗情報.Controls.Add(Me.txt代表者)
        Me.grp店舗情報.Controls.Add(Me.txt会社名)
        Me.grp店舗情報.Controls.Add(Me.txtFAX)
        Me.grp店舗情報.Controls.Add(Me.txt電話)
        Me.grp店舗情報.Controls.Add(Me.txt住所2)
        Me.grp店舗情報.Controls.Add(Me.txt住所1)
        Me.grp店舗情報.Controls.Add(Me.txt郵便2)
        Me.grp店舗情報.Controls.Add(Me.txt郵便1)
        Me.grp店舗情報.Controls.Add(Me.txt店舗名)
        Me.grp店舗情報.Controls.Add(Me.txt店舗CD)
        Me.grp店舗情報.Controls.Add(Me.lbl電話FAX)
        Me.grp店舗情報.Controls.Add(Me.lbl代表者)
        Me.grp店舗情報.Controls.Add(Me.lbl会社名)
        Me.grp店舗情報.Controls.Add(Me.lbl店舗CD)
        Me.grp店舗情報.Controls.Add(Me.lbl住所)
        Me.grp店舗情報.Controls.Add(Me.lbl店舗名)
        Me.grp店舗情報.Location = New System.Drawing.Point(6, 6)
        Me.grp店舗情報.Name = "grp店舗情報"
        Me.grp店舗情報.Size = New System.Drawing.Size(393, 217)
        Me.grp店舗情報.TabIndex = 18
        Me.grp店舗情報.TabStop = False
        Me.grp店舗情報.Text = "店舗情報"
        '
        'lbl住所ハイフン
        '
        Me.lbl住所ハイフン.AutoSize = True
        Me.lbl住所ハイフン.Location = New System.Drawing.Point(156, 69)
        Me.lbl住所ハイフン.Name = "lbl住所ハイフン"
        Me.lbl住所ハイフン.Size = New System.Drawing.Size(11, 12)
        Me.lbl住所ハイフン.TabIndex = 46
        Me.lbl住所ハイフン.Text = "-"
        '
        'txt代表者
        '
        Me.txt代表者.Location = New System.Drawing.Point(117, 177)
        Me.txt代表者.Name = "txt代表者"
        Me.txt代表者.Size = New System.Drawing.Size(206, 19)
        Me.txt代表者.TabIndex = 45
        '
        'txt会社名
        '
        Me.txt会社名.Location = New System.Drawing.Point(117, 155)
        Me.txt会社名.Name = "txt会社名"
        Me.txt会社名.Size = New System.Drawing.Size(206, 19)
        Me.txt会社名.TabIndex = 44
        '
        'txtFAX
        '
        Me.txtFAX.Location = New System.Drawing.Point(223, 133)
        Me.txtFAX.Name = "txtFAX"
        Me.txtFAX.Size = New System.Drawing.Size(101, 19)
        Me.txtFAX.TabIndex = 43
        '
        'txt電話
        '
        Me.txt電話.Location = New System.Drawing.Point(117, 133)
        Me.txt電話.Name = "txt電話"
        Me.txt電話.Size = New System.Drawing.Size(101, 19)
        Me.txt電話.TabIndex = 42
        '
        'txt住所2
        '
        Me.txt住所2.Location = New System.Drawing.Point(117, 110)
        Me.txt住所2.Name = "txt住所2"
        Me.txt住所2.Size = New System.Drawing.Size(206, 19)
        Me.txt住所2.TabIndex = 41
        '
        'txt住所1
        '
        Me.txt住所1.Location = New System.Drawing.Point(117, 88)
        Me.txt住所1.Name = "txt住所1"
        Me.txt住所1.Size = New System.Drawing.Size(206, 19)
        Me.txt住所1.TabIndex = 40
        '
        'txt郵便2
        '
        Me.txt郵便2.Location = New System.Drawing.Point(167, 67)
        Me.txt郵便2.Name = "txt郵便2"
        Me.txt郵便2.Size = New System.Drawing.Size(48, 19)
        Me.txt郵便2.TabIndex = 39
        '
        'txt郵便1
        '
        Me.txt郵便1.Location = New System.Drawing.Point(117, 67)
        Me.txt郵便1.Name = "txt郵便1"
        Me.txt郵便1.Size = New System.Drawing.Size(38, 19)
        Me.txt郵便1.TabIndex = 37
        '
        'txt店舗名
        '
        Me.txt店舗名.Location = New System.Drawing.Point(117, 43)
        Me.txt店舗名.Name = "txt店舗名"
        Me.txt店舗名.Size = New System.Drawing.Size(206, 19)
        Me.txt店舗名.TabIndex = 36
        '
        'txt店舗CD
        '
        Me.txt店舗CD.Location = New System.Drawing.Point(117, 21)
        Me.txt店舗CD.Name = "txt店舗CD"
        Me.txt店舗CD.Size = New System.Drawing.Size(206, 19)
        Me.txt店舗CD.TabIndex = 35
        '
        'lbl電話FAX
        '
        Me.lbl電話FAX.AutoSize = True
        Me.lbl電話FAX.Location = New System.Drawing.Point(12, 136)
        Me.lbl電話FAX.Name = "lbl電話FAX"
        Me.lbl電話FAX.Size = New System.Drawing.Size(65, 12)
        Me.lbl電話FAX.TabIndex = 11
        Me.lbl電話FAX.Text = "電話 / FAX"
        '
        'lbl代表者
        '
        Me.lbl代表者.AutoSize = True
        Me.lbl代表者.Location = New System.Drawing.Point(12, 181)
        Me.lbl代表者.Name = "lbl代表者"
        Me.lbl代表者.Size = New System.Drawing.Size(41, 12)
        Me.lbl代表者.TabIndex = 12
        Me.lbl代表者.Text = "代表者"
        '
        'lbl会社名
        '
        Me.lbl会社名.AutoSize = True
        Me.lbl会社名.Location = New System.Drawing.Point(12, 158)
        Me.lbl会社名.Name = "lbl会社名"
        Me.lbl会社名.Size = New System.Drawing.Size(41, 12)
        Me.lbl会社名.TabIndex = 13
        Me.lbl会社名.Text = "会社名"
        '
        'lbl店舗CD
        '
        Me.lbl店舗CD.AutoSize = True
        Me.lbl店舗CD.Location = New System.Drawing.Point(11, 24)
        Me.lbl店舗CD.Name = "lbl店舗CD"
        Me.lbl店舗CD.Size = New System.Drawing.Size(45, 12)
        Me.lbl店舗CD.TabIndex = 3
        Me.lbl店舗CD.Text = "店舗CD"
        '
        'lbl住所
        '
        Me.lbl住所.AutoSize = True
        Me.lbl住所.Location = New System.Drawing.Point(12, 70)
        Me.lbl住所.Name = "lbl住所"
        Me.lbl住所.Size = New System.Drawing.Size(29, 12)
        Me.lbl住所.TabIndex = 5
        Me.lbl住所.Text = "住所"
        '
        'lbl店舗名
        '
        Me.lbl店舗名.AutoSize = True
        Me.lbl店舗名.Location = New System.Drawing.Point(11, 47)
        Me.lbl店舗名.Name = "lbl店舗名"
        Me.lbl店舗名.Size = New System.Drawing.Size(41, 12)
        Me.lbl店舗名.TabIndex = 6
        Me.lbl店舗名.Text = "店舗名"
        '
        'tabレシート領収レポート
        '
        Me.tabレシート領収レポート.Controls.Add(Me.grp点検清算レポート)
        Me.tabレシート領収レポート.Controls.Add(Me.grp領収情報)
        Me.tabレシート領収レポート.Controls.Add(Me.grpレシート情報)
        Me.tabレシート領収レポート.Location = New System.Drawing.Point(4, 22)
        Me.tabレシート領収レポート.Name = "tabレシート領収レポート"
        Me.tabレシート領収レポート.Padding = New System.Windows.Forms.Padding(3)
        Me.tabレシート領収レポート.Size = New System.Drawing.Size(979, 641)
        Me.tabレシート領収レポート.TabIndex = 1
        Me.tabレシート領収レポート.Text = "レシート・領収・レポート"
        Me.tabレシート領収レポート.UseVisualStyleBackColor = True
        '
        'grp点検清算レポート
        '
        Me.grp点検清算レポート.Controls.Add(Me.lbl客層0件明細印字)
        Me.grp点検清算レポート.Controls.Add(Me.cmb客層0件明細印字)
        Me.grp点検清算レポート.Controls.Add(Me.lbl時間帯0件明細印字)
        Me.grp点検清算レポート.Controls.Add(Me.lbl返品訂正集計印字)
        Me.grp点検清算レポート.Controls.Add(Me.cmb返品訂正集計印字)
        Me.grp点検清算レポート.Controls.Add(Me.cmb時間帯0件明細印字)
        Me.grp点検清算レポート.Controls.Add(Me.lbl組人数内訳印字)
        Me.grp点検清算レポート.Controls.Add(Me.lbl客数印字)
        Me.grp点検清算レポート.Controls.Add(Me.cmb客数印字)
        Me.grp点検清算レポート.Controls.Add(Me.cmb組人数内訳印字)
        Me.grp点検清算レポート.Location = New System.Drawing.Point(6, 481)
        Me.grp点検清算レポート.Name = "grp点検清算レポート"
        Me.grp点検清算レポート.Size = New System.Drawing.Size(967, 153)
        Me.grp点検清算レポート.TabIndex = 17
        Me.grp点検清算レポート.TabStop = False
        Me.grp点検清算レポート.Text = "点検・清算レポート"
        '
        'lbl客層0件明細印字
        '
        Me.lbl客層0件明細印字.AutoSize = True
        Me.lbl客層0件明細印字.Location = New System.Drawing.Point(11, 113)
        Me.lbl客層0件明細印字.Name = "lbl客層0件明細印字"
        Me.lbl客層0件明細印字.Size = New System.Drawing.Size(95, 12)
        Me.lbl客層0件明細印字.TabIndex = 35
        Me.lbl客層0件明細印字.Text = "客層0件明細印字"
        '
        'cmb客層0件明細印字
        '
        Me.cmb客層0件明細印字.FormattingEnabled = True
        Me.cmb客層0件明細印字.Items.AddRange(New Object() {"客層別ﾚﾎﾟｰﾄにて取引０件の明細を印刷する", "客層別ﾚﾎﾟｰﾄにて取引０件の明細を印刷しない"})
        Me.cmb客層0件明細印字.Location = New System.Drawing.Point(172, 110)
        Me.cmb客層0件明細印字.Name = "cmb客層0件明細印字"
        Me.cmb客層0件明細印字.Size = New System.Drawing.Size(276, 20)
        Me.cmb客層0件明細印字.TabIndex = 36
        '
        'lbl時間帯0件明細印字
        '
        Me.lbl時間帯0件明細印字.AutoSize = True
        Me.lbl時間帯0件明細印字.Location = New System.Drawing.Point(11, 90)
        Me.lbl時間帯0件明細印字.Name = "lbl時間帯0件明細印字"
        Me.lbl時間帯0件明細印字.Size = New System.Drawing.Size(107, 12)
        Me.lbl時間帯0件明細印字.TabIndex = 31
        Me.lbl時間帯0件明細印字.Text = "時間帯0件明細印字"
        '
        'lbl返品訂正集計印字
        '
        Me.lbl返品訂正集計印字.AutoSize = True
        Me.lbl返品訂正集計印字.Location = New System.Drawing.Point(11, 67)
        Me.lbl返品訂正集計印字.Name = "lbl返品訂正集計印字"
        Me.lbl返品訂正集計印字.Size = New System.Drawing.Size(101, 12)
        Me.lbl返品訂正集計印字.TabIndex = 32
        Me.lbl返品訂正集計印字.Text = "返品訂正集計印字"
        '
        'cmb返品訂正集計印字
        '
        Me.cmb返品訂正集計印字.FormattingEnabled = True
        Me.cmb返品訂正集計印字.Items.AddRange(New Object() {"訂正を個別に集計印字する", "訂正を個別に集計しないで印字する"})
        Me.cmb返品訂正集計印字.Location = New System.Drawing.Point(172, 64)
        Me.cmb返品訂正集計印字.Name = "cmb返品訂正集計印字"
        Me.cmb返品訂正集計印字.Size = New System.Drawing.Size(276, 20)
        Me.cmb返品訂正集計印字.TabIndex = 34
        '
        'cmb時間帯0件明細印字
        '
        Me.cmb時間帯0件明細印字.FormattingEnabled = True
        Me.cmb時間帯0件明細印字.Items.AddRange(New Object() {"時間帯別ﾚﾎﾟｰﾄにて取引０件の明細を印刷する", "時間帯別ﾚﾎﾟｰﾄにて取引０件の明細を印刷しない"})
        Me.cmb時間帯0件明細印字.Location = New System.Drawing.Point(172, 87)
        Me.cmb時間帯0件明細印字.Name = "cmb時間帯0件明細印字"
        Me.cmb時間帯0件明細印字.Size = New System.Drawing.Size(276, 20)
        Me.cmb時間帯0件明細印字.TabIndex = 33
        '
        'lbl組人数内訳印字
        '
        Me.lbl組人数内訳印字.AutoSize = True
        Me.lbl組人数内訳印字.Location = New System.Drawing.Point(11, 44)
        Me.lbl組人数内訳印字.Name = "lbl組人数内訳印字"
        Me.lbl組人数内訳印字.Size = New System.Drawing.Size(89, 12)
        Me.lbl組人数内訳印字.TabIndex = 27
        Me.lbl組人数内訳印字.Text = "組人数内訳印字"
        '
        'lbl客数印字
        '
        Me.lbl客数印字.AutoSize = True
        Me.lbl客数印字.Location = New System.Drawing.Point(11, 21)
        Me.lbl客数印字.Name = "lbl客数印字"
        Me.lbl客数印字.Size = New System.Drawing.Size(53, 12)
        Me.lbl客数印字.TabIndex = 28
        Me.lbl客数印字.Text = "客数印字"
        '
        'cmb客数印字
        '
        Me.cmb客数印字.FormattingEnabled = True
        Me.cmb客数印字.Items.AddRange(New Object() {"客数を印字しない", "客数を印字する"})
        Me.cmb客数印字.Location = New System.Drawing.Point(172, 18)
        Me.cmb客数印字.Name = "cmb客数印字"
        Me.cmb客数印字.Size = New System.Drawing.Size(276, 20)
        Me.cmb客数印字.TabIndex = 30
        '
        'cmb組人数内訳印字
        '
        Me.cmb組人数内訳印字.FormattingEnabled = True
        Me.cmb組人数内訳印字.Items.AddRange(New Object() {"組人数内訳を印字しない", "組人数内訳を印字する"})
        Me.cmb組人数内訳印字.Location = New System.Drawing.Point(172, 41)
        Me.cmb組人数内訳印字.Name = "cmb組人数内訳印字"
        Me.cmb組人数内訳印字.Size = New System.Drawing.Size(276, 20)
        Me.cmb組人数内訳印字.TabIndex = 29
        '
        'grp領収情報
        '
        Me.grp領収情報.Controls.Add(Me.txt備考)
        Me.grp領収情報.Controls.Add(Me.txt領収但し書き)
        Me.grp領収情報.Controls.Add(Me.lbl備考)
        Me.grp領収情報.Controls.Add(Me.lbl収入印紙枠印刷)
        Me.grp領収情報.Controls.Add(Me.cmb収入印紙枠印刷)
        Me.grp領収情報.Controls.Add(Me.lbl領収但し書き)
        Me.grp領収情報.Controls.Add(Me.lbl領収名)
        Me.grp領収情報.Controls.Add(Me.cmb領収名)
        Me.grp領収情報.Location = New System.Drawing.Point(6, 353)
        Me.grp領収情報.Name = "grp領収情報"
        Me.grp領収情報.Size = New System.Drawing.Size(967, 122)
        Me.grp領収情報.TabIndex = 17
        Me.grp領収情報.TabStop = False
        Me.grp領収情報.Text = "領収情報"
        '
        'txt備考
        '
        Me.txt備考.Location = New System.Drawing.Point(172, 86)
        Me.txt備考.Name = "txt備考"
        Me.txt備考.Size = New System.Drawing.Size(401, 19)
        Me.txt備考.TabIndex = 41
        '
        'txt領収但し書き
        '
        Me.txt領収但し書き.Location = New System.Drawing.Point(172, 41)
        Me.txt領収但し書き.Name = "txt領収但し書き"
        Me.txt領収但し書き.Size = New System.Drawing.Size(401, 19)
        Me.txt領収但し書き.TabIndex = 40
        '
        'lbl備考
        '
        Me.lbl備考.AutoSize = True
        Me.lbl備考.Location = New System.Drawing.Point(12, 89)
        Me.lbl備考.Name = "lbl備考"
        Me.lbl備考.Size = New System.Drawing.Size(29, 12)
        Me.lbl備考.TabIndex = 31
        Me.lbl備考.Text = "備考"
        '
        'lbl収入印紙枠印刷
        '
        Me.lbl収入印紙枠印刷.AutoSize = True
        Me.lbl収入印紙枠印刷.Location = New System.Drawing.Point(12, 66)
        Me.lbl収入印紙枠印刷.Name = "lbl収入印紙枠印刷"
        Me.lbl収入印紙枠印刷.Size = New System.Drawing.Size(89, 12)
        Me.lbl収入印紙枠印刷.TabIndex = 32
        Me.lbl収入印紙枠印刷.Text = "収入印紙枠印刷"
        '
        'cmb収入印紙枠印刷
        '
        Me.cmb収入印紙枠印刷.FormattingEnabled = True
        Me.cmb収入印紙枠印刷.Items.AddRange(New Object() {"収入印紙欄を印刷する", "収入印紙欄を印刷しない"})
        Me.cmb収入印紙枠印刷.Location = New System.Drawing.Point(172, 63)
        Me.cmb収入印紙枠印刷.Name = "cmb収入印紙枠印刷"
        Me.cmb収入印紙枠印刷.Size = New System.Drawing.Size(276, 20)
        Me.cmb収入印紙枠印刷.TabIndex = 34
        '
        'lbl領収但し書き
        '
        Me.lbl領収但し書き.AutoSize = True
        Me.lbl領収但し書き.Location = New System.Drawing.Point(12, 44)
        Me.lbl領収但し書き.Name = "lbl領収但し書き"
        Me.lbl領収但し書き.Size = New System.Drawing.Size(71, 12)
        Me.lbl領収但し書き.TabIndex = 27
        Me.lbl領収但し書き.Text = "領収但し書き"
        '
        'lbl領収名
        '
        Me.lbl領収名.AutoSize = True
        Me.lbl領収名.Location = New System.Drawing.Point(12, 21)
        Me.lbl領収名.Name = "lbl領収名"
        Me.lbl領収名.Size = New System.Drawing.Size(41, 12)
        Me.lbl領収名.TabIndex = 28
        Me.lbl領収名.Text = "領収名"
        '
        'cmb領収名
        '
        Me.cmb領収名.FormattingEnabled = True
        Me.cmb領収名.Items.AddRange(New Object() {"領収書", "領収証"})
        Me.cmb領収名.Location = New System.Drawing.Point(172, 18)
        Me.cmb領収名.Name = "cmb領収名"
        Me.cmb領収名.Size = New System.Drawing.Size(101, 20)
        Me.cmb領収名.TabIndex = 30
        '
        'grpレシート情報
        '
        Me.grpレシート情報.Controls.Add(Me.txtタイトル)
        Me.grpレシート情報.Controls.Add(Me.txt末尾ロゴ印刷)
        Me.grpレシート情報.Controls.Add(Me.txt宣伝文3)
        Me.grpレシート情報.Controls.Add(Me.txt宣伝文2)
        Me.grpレシート情報.Controls.Add(Me.txt宣伝文1)
        Me.grpレシート情報.Controls.Add(Me.lbl取引名印字文字サイズ追記)
        Me.grpレシート情報.Controls.Add(Me.lbl末尾ロゴ印刷追記)
        Me.grpレシート情報.Controls.Add(Me.lblクーポンカット)
        Me.grpレシート情報.Controls.Add(Me.lbl合計点数印字)
        Me.grpレシート情報.Controls.Add(Me.cmb合計点数印字)
        Me.grpレシート情報.Controls.Add(Me.cmbクーポンカット)
        Me.grpレシート情報.Controls.Add(Me.lblレシートNO)
        Me.grpレシート情報.Controls.Add(Me.lblタイトル)
        Me.grpレシート情報.Controls.Add(Me.lbl取引名印字文字サイズ)
        Me.grpレシート情報.Controls.Add(Me.cmbレシートNO)
        Me.grpレシート情報.Controls.Add(Me.cmb取引名印字文字サイズ)
        Me.grpレシート情報.Controls.Add(Me.lbl末尾ロゴ印刷)
        Me.grpレシート情報.Controls.Add(Me.lblJANコード印刷)
        Me.grpレシート情報.Controls.Add(Me.lbl税額内訳印刷)
        Me.grpレシート情報.Controls.Add(Me.cmb末尾ロゴ印刷)
        Me.grpレシート情報.Controls.Add(Me.cmb税額内訳印刷)
        Me.grpレシート情報.Controls.Add(Me.cmbJANコード印刷)
        Me.grpレシート情報.Controls.Add(Me.lbl控発行)
        Me.grpレシート情報.Controls.Add(Me.lbl宣伝文)
        Me.grpレシート情報.Controls.Add(Me.lbl宣伝文印刷)
        Me.grpレシート情報.Controls.Add(Me.cmbl控発行)
        Me.grpレシート情報.Controls.Add(Me.cmb宣伝文印刷)
        Me.grpレシート情報.Location = New System.Drawing.Point(6, 15)
        Me.grpレシート情報.Name = "grpレシート情報"
        Me.grpレシート情報.Size = New System.Drawing.Size(967, 332)
        Me.grpレシート情報.TabIndex = 17
        Me.grpレシート情報.TabStop = False
        Me.grpレシート情報.Text = "レシート情報"
        '
        'txtタイトル
        '
        Me.txtタイトル.Location = New System.Drawing.Point(172, 248)
        Me.txtタイトル.Name = "txtタイトル"
        Me.txtタイトル.Size = New System.Drawing.Size(101, 19)
        Me.txtタイトル.TabIndex = 39
        '
        'txt末尾ロゴ印刷
        '
        Me.txt末尾ロゴ印刷.Location = New System.Drawing.Point(384, 133)
        Me.txt末尾ロゴ印刷.Name = "txt末尾ロゴ印刷"
        Me.txt末尾ロゴ印刷.Size = New System.Drawing.Size(64, 19)
        Me.txt末尾ロゴ印刷.TabIndex = 38
        '
        'txt宣伝文3
        '
        Me.txt宣伝文3.Location = New System.Drawing.Point(172, 111)
        Me.txt宣伝文3.Name = "txt宣伝文3"
        Me.txt宣伝文3.Size = New System.Drawing.Size(276, 19)
        Me.txt宣伝文3.TabIndex = 37
        '
        'txt宣伝文2
        '
        Me.txt宣伝文2.Location = New System.Drawing.Point(172, 89)
        Me.txt宣伝文2.Name = "txt宣伝文2"
        Me.txt宣伝文2.Size = New System.Drawing.Size(276, 19)
        Me.txt宣伝文2.TabIndex = 36
        '
        'txt宣伝文1
        '
        Me.txt宣伝文1.Location = New System.Drawing.Point(172, 67)
        Me.txt宣伝文1.Name = "txt宣伝文1"
        Me.txt宣伝文1.Size = New System.Drawing.Size(276, 19)
        Me.txt宣伝文1.TabIndex = 35
        '
        'lbl取引名印字文字サイズ追記
        '
        Me.lbl取引名印字文字サイズ追記.AutoSize = True
        Me.lbl取引名印字文字サイズ追記.Location = New System.Drawing.Point(454, 228)
        Me.lbl取引名印字文字サイズ追記.Name = "lbl取引名印字文字サイズ追記"
        Me.lbl取引名印字文字サイズ追記.Size = New System.Drawing.Size(176, 12)
        Me.lbl取引名印字文字サイズ追記.TabIndex = 28
        Me.lbl取引名印字文字サイズ追記.Text = "（合計・お預り・お釣りの文字サイズ）"
        '
        'lbl末尾ロゴ印刷追記
        '
        Me.lbl末尾ロゴ印刷追記.AutoSize = True
        Me.lbl末尾ロゴ印刷追記.Location = New System.Drawing.Point(454, 136)
        Me.lbl末尾ロゴ印刷追記.Name = "lbl末尾ロゴ印刷追記"
        Me.lbl末尾ロゴ印刷追記.Size = New System.Drawing.Size(249, 12)
        Me.lbl末尾ロゴ印刷追記.TabIndex = 27
        Me.lbl末尾ロゴ印刷追記.Text = "円以上　（\1,000以上の場合は「1000」を設定する）"
        '
        'lblクーポンカット
        '
        Me.lblクーポンカット.AutoSize = True
        Me.lblクーポンカット.Location = New System.Drawing.Point(10, 296)
        Me.lblクーポンカット.Name = "lblクーポンカット"
        Me.lblクーポンカット.Size = New System.Drawing.Size(66, 12)
        Me.lblクーポンカット.TabIndex = 23
        Me.lblクーポンカット.Text = "クーポンカット"
        '
        'lbl合計点数印字
        '
        Me.lbl合計点数印字.AutoSize = True
        Me.lbl合計点数印字.Location = New System.Drawing.Point(11, 273)
        Me.lbl合計点数印字.Name = "lbl合計点数印字"
        Me.lbl合計点数印字.Size = New System.Drawing.Size(77, 12)
        Me.lbl合計点数印字.TabIndex = 24
        Me.lbl合計点数印字.Text = "合計点数印字"
        '
        'cmb合計点数印字
        '
        Me.cmb合計点数印字.FormattingEnabled = True
        Me.cmb合計点数印字.Items.AddRange(New Object() {"印字なし", "印字あり"})
        Me.cmb合計点数印字.Location = New System.Drawing.Point(172, 270)
        Me.cmb合計点数印字.Name = "cmb合計点数印字"
        Me.cmb合計点数印字.Size = New System.Drawing.Size(276, 20)
        Me.cmb合計点数印字.TabIndex = 26
        '
        'cmbクーポンカット
        '
        Me.cmbクーポンカット.FormattingEnabled = True
        Me.cmbクーポンカット.Items.AddRange(New Object() {"クーポンをカットしない。", "クーポンをカットする。"})
        Me.cmbクーポンカット.Location = New System.Drawing.Point(172, 293)
        Me.cmbクーポンカット.Name = "cmbクーポンカット"
        Me.cmbクーポンカット.Size = New System.Drawing.Size(276, 20)
        Me.cmbクーポンカット.TabIndex = 25
        '
        'lblレシートNO
        '
        Me.lblレシートNO.AutoSize = True
        Me.lblレシートNO.Location = New System.Drawing.Point(11, 205)
        Me.lblレシートNO.Name = "lblレシートNO"
        Me.lblレシートNO.Size = New System.Drawing.Size(58, 12)
        Me.lblレシートNO.TabIndex = 17
        Me.lblレシートNO.Text = "レシートNO"
        '
        'lblタイトル
        '
        Me.lblタイトル.AutoSize = True
        Me.lblタイトル.Location = New System.Drawing.Point(12, 251)
        Me.lblタイトル.Name = "lblタイトル"
        Me.lblタイトル.Size = New System.Drawing.Size(40, 12)
        Me.lblタイトル.TabIndex = 18
        Me.lblタイトル.Text = "タイトル"
        '
        'lbl取引名印字文字サイズ
        '
        Me.lbl取引名印字文字サイズ.AutoSize = True
        Me.lbl取引名印字文字サイズ.Location = New System.Drawing.Point(12, 228)
        Me.lbl取引名印字文字サイズ.Name = "lbl取引名印字文字サイズ"
        Me.lbl取引名印字文字サイズ.Size = New System.Drawing.Size(115, 12)
        Me.lbl取引名印字文字サイズ.TabIndex = 19
        Me.lbl取引名印字文字サイズ.Text = "取引名印字文字ｻｲｽﾞ"
        '
        'cmbレシートNO
        '
        Me.cmbレシートNO.FormattingEnabled = True
        Me.cmbレシートNO.Items.AddRange(New Object() {"精算毎に連番を採る", "永続的に連番を採る"})
        Me.cmbレシートNO.Location = New System.Drawing.Point(172, 202)
        Me.cmbレシートNO.Name = "cmbレシートNO"
        Me.cmbレシートNO.Size = New System.Drawing.Size(276, 20)
        Me.cmbレシートNO.TabIndex = 20
        '
        'cmb取引名印字文字サイズ
        '
        Me.cmb取引名印字文字サイズ.FormattingEnabled = True
        Me.cmb取引名印字文字サイズ.Items.AddRange(New Object() {"（合計・預かり・お釣り）", "通常文字", "拡大文字（横倍）"})
        Me.cmb取引名印字文字サイズ.Location = New System.Drawing.Point(172, 225)
        Me.cmb取引名印字文字サイズ.Name = "cmb取引名印字文字サイズ"
        Me.cmb取引名印字文字サイズ.Size = New System.Drawing.Size(276, 20)
        Me.cmb取引名印字文字サイズ.TabIndex = 22
        '
        'lbl末尾ロゴ印刷
        '
        Me.lbl末尾ロゴ印刷.AutoSize = True
        Me.lbl末尾ロゴ印刷.Location = New System.Drawing.Point(12, 136)
        Me.lbl末尾ロゴ印刷.Name = "lbl末尾ロゴ印刷"
        Me.lbl末尾ロゴ印刷.Size = New System.Drawing.Size(71, 12)
        Me.lbl末尾ロゴ印刷.TabIndex = 11
        Me.lbl末尾ロゴ印刷.Text = "末尾ロゴ印刷"
        '
        'lblJANコード印刷
        '
        Me.lblJANコード印刷.AutoSize = True
        Me.lblJANコード印刷.Location = New System.Drawing.Point(12, 182)
        Me.lblJANコード印刷.Name = "lblJANコード印刷"
        Me.lblJANコード印刷.Size = New System.Drawing.Size(75, 12)
        Me.lblJANコード印刷.TabIndex = 12
        Me.lblJANコード印刷.Text = "JANｺｰﾄﾞ印刷"
        '
        'lbl税額内訳印刷
        '
        Me.lbl税額内訳印刷.AutoSize = True
        Me.lbl税額内訳印刷.Location = New System.Drawing.Point(12, 159)
        Me.lbl税額内訳印刷.Name = "lbl税額内訳印刷"
        Me.lbl税額内訳印刷.Size = New System.Drawing.Size(77, 12)
        Me.lbl税額内訳印刷.TabIndex = 13
        Me.lbl税額内訳印刷.Text = "税額内訳印刷"
        '
        'cmb末尾ロゴ印刷
        '
        Me.cmb末尾ロゴ印刷.FormattingEnabled = True
        Me.cmb末尾ロゴ印刷.Items.AddRange(New Object() {"印刷しない", "印刷する"})
        Me.cmb末尾ロゴ印刷.Location = New System.Drawing.Point(172, 133)
        Me.cmb末尾ロゴ印刷.Name = "cmb末尾ロゴ印刷"
        Me.cmb末尾ロゴ印刷.Size = New System.Drawing.Size(206, 20)
        Me.cmb末尾ロゴ印刷.TabIndex = 14
        '
        'cmb税額内訳印刷
        '
        Me.cmb税額内訳印刷.FormattingEnabled = True
        Me.cmb税額内訳印刷.Items.AddRange(New Object() {"印刷しない", "印刷する"})
        Me.cmb税額内訳印刷.Location = New System.Drawing.Point(172, 156)
        Me.cmb税額内訳印刷.Name = "cmb税額内訳印刷"
        Me.cmb税額内訳印刷.Size = New System.Drawing.Size(276, 20)
        Me.cmb税額内訳印刷.TabIndex = 16
        '
        'cmbJANコード印刷
        '
        Me.cmbJANコード印刷.FormattingEnabled = True
        Me.cmbJANコード印刷.Items.AddRange(New Object() {"印刷しない", "印刷する"})
        Me.cmbJANコード印刷.Location = New System.Drawing.Point(172, 179)
        Me.cmbJANコード印刷.Name = "cmbJANコード印刷"
        Me.cmbJANコード印刷.Size = New System.Drawing.Size(276, 20)
        Me.cmbJANコード印刷.TabIndex = 15
        '
        'lbl控発行
        '
        Me.lbl控発行.AutoSize = True
        Me.lbl控発行.Location = New System.Drawing.Point(11, 24)
        Me.lbl控発行.Name = "lbl控発行"
        Me.lbl控発行.Size = New System.Drawing.Size(41, 12)
        Me.lbl控発行.TabIndex = 3
        Me.lbl控発行.Text = "控発行"
        '
        'lbl宣伝文
        '
        Me.lbl宣伝文.AutoSize = True
        Me.lbl宣伝文.Location = New System.Drawing.Point(12, 70)
        Me.lbl宣伝文.Name = "lbl宣伝文"
        Me.lbl宣伝文.Size = New System.Drawing.Size(41, 12)
        Me.lbl宣伝文.TabIndex = 5
        Me.lbl宣伝文.Text = "宣伝文"
        '
        'lbl宣伝文印刷
        '
        Me.lbl宣伝文印刷.AutoSize = True
        Me.lbl宣伝文印刷.Location = New System.Drawing.Point(11, 47)
        Me.lbl宣伝文印刷.Name = "lbl宣伝文印刷"
        Me.lbl宣伝文印刷.Size = New System.Drawing.Size(65, 12)
        Me.lbl宣伝文印刷.TabIndex = 6
        Me.lbl宣伝文印刷.Text = "宣伝文印刷"
        '
        'cmbl控発行
        '
        Me.cmbl控発行.FormattingEnabled = True
        Me.cmbl控発行.Items.AddRange(New Object() {"発行控を発行しない", "発行控を発行する※現計以外の取引が対象", "発行控を発行する※現計も含む"})
        Me.cmbl控発行.Location = New System.Drawing.Point(172, 21)
        Me.cmbl控発行.Name = "cmbl控発行"
        Me.cmbl控発行.Size = New System.Drawing.Size(276, 20)
        Me.cmbl控発行.TabIndex = 8
        '
        'cmb宣伝文印刷
        '
        Me.cmb宣伝文印刷.FormattingEnabled = True
        Me.cmb宣伝文印刷.Items.AddRange(New Object() {"宣伝文を印刷する", "宣伝文を印刷しない"})
        Me.cmb宣伝文印刷.Location = New System.Drawing.Point(172, 44)
        Me.cmb宣伝文印刷.Name = "cmb宣伝文印刷"
        Me.cmb宣伝文印刷.Size = New System.Drawing.Size(276, 20)
        Me.cmb宣伝文印刷.TabIndex = 10
        '
        'tabFTPインポート
        '
        Me.tabFTPインポート.Controls.Add(Me.grpマスタインポート設定)
        Me.tabFTPインポート.Controls.Add(Me.grpFTP設定)
        Me.tabFTPインポート.Location = New System.Drawing.Point(4, 22)
        Me.tabFTPインポート.Name = "tabFTPインポート"
        Me.tabFTPインポート.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFTPインポート.Size = New System.Drawing.Size(979, 641)
        Me.tabFTPインポート.TabIndex = 2
        Me.tabFTPインポート.Text = "FTP・インポート"
        Me.tabFTPインポート.UseVisualStyleBackColor = True
        '
        'grpマスタインポート設定
        '
        Me.grpマスタインポート設定.Controls.Add(Me.txtCSV格納フォルダ)
        Me.grpマスタインポート設定.Controls.Add(Me.btn参照)
        Me.grpマスタインポート設定.Controls.Add(Me.cmb自動起動区分)
        Me.grpマスタインポート設定.Controls.Add(Me.lblCSV格納フォルダ)
        Me.grpマスタインポート設定.Controls.Add(Me.lbl自動起動区分)
        Me.grpマスタインポート設定.Location = New System.Drawing.Point(6, 410)
        Me.grpマスタインポート設定.Name = "grpマスタインポート設定"
        Me.grpマスタインポート設定.Size = New System.Drawing.Size(967, 80)
        Me.grpマスタインポート設定.TabIndex = 39
        Me.grpマスタインポート設定.TabStop = False
        Me.grpマスタインポート設定.Text = "マスタインポート設定"
        '
        'txtCSV格納フォルダ
        '
        Me.txtCSV格納フォルダ.Location = New System.Drawing.Point(172, 40)
        Me.txtCSV格納フォルダ.Name = "txtCSV格納フォルダ"
        Me.txtCSV格納フォルダ.Size = New System.Drawing.Size(387, 19)
        Me.txtCSV格納フォルダ.TabIndex = 50
        '
        'btn参照
        '
        Me.btn参照.Location = New System.Drawing.Point(565, 34)
        Me.btn参照.Name = "btn参照"
        Me.btn参照.Size = New System.Drawing.Size(61, 25)
        Me.btn参照.TabIndex = 49
        Me.btn参照.Text = "参照"
        Me.btn参照.UseVisualStyleBackColor = True
        '
        'cmb自動起動区分
        '
        Me.cmb自動起動区分.FormattingEnabled = True
        Me.cmb自動起動区分.Items.AddRange(New Object() {"自動起動しない", "自動起動する"})
        Me.cmb自動起動区分.Location = New System.Drawing.Point(172, 18)
        Me.cmb自動起動区分.Name = "cmb自動起動区分"
        Me.cmb自動起動区分.Size = New System.Drawing.Size(314, 20)
        Me.cmb自動起動区分.TabIndex = 43
        '
        'lblCSV格納フォルダ
        '
        Me.lblCSV格納フォルダ.AutoSize = True
        Me.lblCSV格納フォルダ.Location = New System.Drawing.Point(12, 43)
        Me.lblCSV格納フォルダ.Name = "lblCSV格納フォルダ"
        Me.lblCSV格納フォルダ.Size = New System.Drawing.Size(82, 12)
        Me.lblCSV格納フォルダ.TabIndex = 27
        Me.lblCSV格納フォルダ.Text = "CSV格納ﾌｫﾙﾀﾞ"
        '
        'lbl自動起動区分
        '
        Me.lbl自動起動区分.AutoSize = True
        Me.lbl自動起動区分.Location = New System.Drawing.Point(12, 21)
        Me.lbl自動起動区分.Name = "lbl自動起動区分"
        Me.lbl自動起動区分.Size = New System.Drawing.Size(77, 12)
        Me.lbl自動起動区分.TabIndex = 28
        Me.lbl自動起動区分.Text = "自動起動区分"
        '
        'grpFTP設定
        '
        Me.grpFTP設定.Controls.Add(Me.grp受信時設定)
        Me.grpFTP設定.Controls.Add(Me.grp送信時設定)
        Me.grpFTP設定.Controls.Add(Me.txtタイムアウト)
        Me.grpFTP設定.Controls.Add(Me.txt送受信間隔)
        Me.grpFTP設定.Controls.Add(Me.txt接続先)
        Me.grpFTP設定.Controls.Add(Me.lblタイムアウト)
        Me.grpFTP設定.Controls.Add(Me.lbl使用区分)
        Me.grpFTP設定.Controls.Add(Me.lbl送受信間隔)
        Me.grpFTP設定.Controls.Add(Me.lbl接続先)
        Me.grpFTP設定.Controls.Add(Me.cmb使用区分)
        Me.grpFTP設定.Location = New System.Drawing.Point(6, 6)
        Me.grpFTP設定.Name = "grpFTP設定"
        Me.grpFTP設定.Size = New System.Drawing.Size(967, 383)
        Me.grpFTP設定.TabIndex = 18
        Me.grpFTP設定.TabStop = False
        Me.grpFTP設定.Text = "FTP設定"
        '
        'grp受信時設定
        '
        Me.grp受信時設定.Controls.Add(Me.btn受信時設定通信確認)
        Me.grp受信時設定.Controls.Add(Me.txt受信元サーバフォルダ)
        Me.grp受信時設定.Controls.Add(Me.lbl受信元サーバフォルダ)
        Me.grp受信時設定.Controls.Add(Me.txt受信時対象ファイル種類)
        Me.grp受信時設定.Controls.Add(Me.txt受信時パスワード)
        Me.grp受信時設定.Controls.Add(Me.txt受信時ユーザー名)
        Me.grp受信時設定.Controls.Add(Me.lbl受信時対象ファイル種類)
        Me.grp受信時設定.Controls.Add(Me.lbl受信時パスワード)
        Me.grp受信時設定.Controls.Add(Me.lbl受信時ユーザー名)
        Me.grp受信時設定.Location = New System.Drawing.Point(13, 218)
        Me.grp受信時設定.Name = "grp受信時設定"
        Me.grp受信時設定.Size = New System.Drawing.Size(718, 120)
        Me.grp受信時設定.TabIndex = 50
        Me.grp受信時設定.TabStop = False
        Me.grp受信時設定.Text = "受信時設定"
        '
        'btn受信時設定通信確認
        '
        Me.btn受信時設定通信確認.Location = New System.Drawing.Point(577, 71)
        Me.btn受信時設定通信確認.Name = "btn受信時設定通信確認"
        Me.btn受信時設定通信確認.Size = New System.Drawing.Size(86, 32)
        Me.btn受信時設定通信確認.TabIndex = 49
        Me.btn受信時設定通信確認.Text = "通信確認"
        Me.btn受信時設定通信確認.UseVisualStyleBackColor = True
        '
        'txt受信元サーバフォルダ
        '
        Me.txt受信元サーバフォルダ.Location = New System.Drawing.Point(159, 84)
        Me.txt受信元サーバフォルダ.Name = "txt受信元サーバフォルダ"
        Me.txt受信元サーバフォルダ.Size = New System.Drawing.Size(412, 19)
        Me.txt受信元サーバフォルダ.TabIndex = 48
        '
        'lbl受信元サーバフォルダ
        '
        Me.lbl受信元サーバフォルダ.AutoSize = True
        Me.lbl受信元サーバフォルダ.Location = New System.Drawing.Point(12, 87)
        Me.lbl受信元サーバフォルダ.Name = "lbl受信元サーバフォルダ"
        Me.lbl受信元サーバフォルダ.Size = New System.Drawing.Size(106, 12)
        Me.lbl受信元サーバフォルダ.TabIndex = 46
        Me.lbl受信元サーバフォルダ.Text = "受信元サーバフォルダ"
        '
        'txt受信時対象ファイル種類
        '
        Me.txt受信時対象ファイル種類.Location = New System.Drawing.Point(159, 62)
        Me.txt受信時対象ファイル種類.Name = "txt受信時対象ファイル種類"
        Me.txt受信時対象ファイル種類.Size = New System.Drawing.Size(193, 19)
        Me.txt受信時対象ファイル種類.TabIndex = 45
        '
        'txt受信時パスワード
        '
        Me.txt受信時パスワード.Location = New System.Drawing.Point(159, 40)
        Me.txt受信時パスワード.Name = "txt受信時パスワード"
        Me.txt受信時パスワード.Size = New System.Drawing.Size(193, 19)
        Me.txt受信時パスワード.TabIndex = 44
        '
        'txt受信時ユーザー名
        '
        Me.txt受信時ユーザー名.Location = New System.Drawing.Point(159, 18)
        Me.txt受信時ユーザー名.Name = "txt受信時ユーザー名"
        Me.txt受信時ユーザー名.Size = New System.Drawing.Size(193, 19)
        Me.txt受信時ユーザー名.TabIndex = 40
        '
        'lbl受信時対象ファイル種類
        '
        Me.lbl受信時対象ファイル種類.AutoSize = True
        Me.lbl受信時対象ファイル種類.Location = New System.Drawing.Point(12, 65)
        Me.lbl受信時対象ファイル種類.Name = "lbl受信時対象ファイル種類"
        Me.lbl受信時対象ファイル種類.Size = New System.Drawing.Size(87, 12)
        Me.lbl受信時対象ファイル種類.TabIndex = 32
        Me.lbl受信時対象ファイル種類.Text = "対象ファイル種類"
        '
        'lbl受信時パスワード
        '
        Me.lbl受信時パスワード.AutoSize = True
        Me.lbl受信時パスワード.Location = New System.Drawing.Point(12, 43)
        Me.lbl受信時パスワード.Name = "lbl受信時パスワード"
        Me.lbl受信時パスワード.Size = New System.Drawing.Size(52, 12)
        Me.lbl受信時パスワード.TabIndex = 27
        Me.lbl受信時パスワード.Text = "パスワード"
        '
        'lbl受信時ユーザー名
        '
        Me.lbl受信時ユーザー名.AutoSize = True
        Me.lbl受信時ユーザー名.Location = New System.Drawing.Point(12, 21)
        Me.lbl受信時ユーザー名.Name = "lbl受信時ユーザー名"
        Me.lbl受信時ユーザー名.Size = New System.Drawing.Size(57, 12)
        Me.lbl受信時ユーザー名.TabIndex = 28
        Me.lbl受信時ユーザー名.Text = "ユーザー名"
        '
        'grp送信時設定
        '
        Me.grp送信時設定.Controls.Add(Me.btn送信時設定通信確認)
        Me.grp送信時設定.Controls.Add(Me.txt送信先サーバフォルダ)
        Me.grp送信時設定.Controls.Add(Me.lbl送信モード)
        Me.grp送信時設定.Controls.Add(Me.lbl送信先サーバフォルダ)
        Me.grp送信時設定.Controls.Add(Me.txt送信時対象ファイル種類)
        Me.grp送信時設定.Controls.Add(Me.txt送信時パスワード)
        Me.grp送信時設定.Controls.Add(Me.cmb送信モード)
        Me.grp送信時設定.Controls.Add(Me.txt送信時ユーザー名)
        Me.grp送信時設定.Controls.Add(Me.lbl送信時対象ファイル種類)
        Me.grp送信時設定.Controls.Add(Me.lbl送信時パスワード)
        Me.grp送信時設定.Controls.Add(Me.lbl送信時ユーザー名)
        Me.grp送信時設定.Location = New System.Drawing.Point(13, 69)
        Me.grp送信時設定.Name = "grp送信時設定"
        Me.grp送信時設定.Size = New System.Drawing.Size(718, 143)
        Me.grp送信時設定.TabIndex = 38
        Me.grp送信時設定.TabStop = False
        Me.grp送信時設定.Text = "送信時設定"
        '
        'btn送信時設定通信確認
        '
        Me.btn送信時設定通信確認.Location = New System.Drawing.Point(577, 94)
        Me.btn送信時設定通信確認.Name = "btn送信時設定通信確認"
        Me.btn送信時設定通信確認.Size = New System.Drawing.Size(86, 32)
        Me.btn送信時設定通信確認.TabIndex = 49
        Me.btn送信時設定通信確認.Text = "通信確認"
        Me.btn送信時設定通信確認.UseVisualStyleBackColor = True
        '
        'txt送信先サーバフォルダ
        '
        Me.txt送信先サーバフォルダ.Location = New System.Drawing.Point(159, 84)
        Me.txt送信先サーバフォルダ.Name = "txt送信先サーバフォルダ"
        Me.txt送信先サーバフォルダ.Size = New System.Drawing.Size(412, 19)
        Me.txt送信先サーバフォルダ.TabIndex = 48
        '
        'lbl送信モード
        '
        Me.lbl送信モード.AutoSize = True
        Me.lbl送信モード.Location = New System.Drawing.Point(12, 109)
        Me.lbl送信モード.Name = "lbl送信モード"
        Me.lbl送信モード.Size = New System.Drawing.Size(57, 12)
        Me.lbl送信モード.TabIndex = 47
        Me.lbl送信モード.Text = "送信モード"
        '
        'lbl送信先サーバフォルダ
        '
        Me.lbl送信先サーバフォルダ.AutoSize = True
        Me.lbl送信先サーバフォルダ.Location = New System.Drawing.Point(12, 87)
        Me.lbl送信先サーバフォルダ.Name = "lbl送信先サーバフォルダ"
        Me.lbl送信先サーバフォルダ.Size = New System.Drawing.Size(106, 12)
        Me.lbl送信先サーバフォルダ.TabIndex = 46
        Me.lbl送信先サーバフォルダ.Text = "送信先サーバフォルダ"
        '
        'txt送信時対象ファイル種類
        '
        Me.txt送信時対象ファイル種類.Location = New System.Drawing.Point(159, 62)
        Me.txt送信時対象ファイル種類.Name = "txt送信時対象ファイル種類"
        Me.txt送信時対象ファイル種類.Size = New System.Drawing.Size(193, 19)
        Me.txt送信時対象ファイル種類.TabIndex = 45
        '
        'txt送信時パスワード
        '
        Me.txt送信時パスワード.Location = New System.Drawing.Point(159, 40)
        Me.txt送信時パスワード.Name = "txt送信時パスワード"
        Me.txt送信時パスワード.Size = New System.Drawing.Size(193, 19)
        Me.txt送信時パスワード.TabIndex = 44
        '
        'cmb送信モード
        '
        Me.cmb送信モード.FormattingEnabled = True
        Me.cmb送信モード.Items.AddRange(New Object() {"別ファイルで送信", "１つのファイルにして送信"})
        Me.cmb送信モード.Location = New System.Drawing.Point(159, 106)
        Me.cmb送信モード.Name = "cmb送信モード"
        Me.cmb送信モード.Size = New System.Drawing.Size(412, 20)
        Me.cmb送信モード.TabIndex = 43
        '
        'txt送信時ユーザー名
        '
        Me.txt送信時ユーザー名.Location = New System.Drawing.Point(159, 18)
        Me.txt送信時ユーザー名.Name = "txt送信時ユーザー名"
        Me.txt送信時ユーザー名.Size = New System.Drawing.Size(193, 19)
        Me.txt送信時ユーザー名.TabIndex = 40
        '
        'lbl送信時対象ファイル種類
        '
        Me.lbl送信時対象ファイル種類.AutoSize = True
        Me.lbl送信時対象ファイル種類.Location = New System.Drawing.Point(12, 65)
        Me.lbl送信時対象ファイル種類.Name = "lbl送信時対象ファイル種類"
        Me.lbl送信時対象ファイル種類.Size = New System.Drawing.Size(87, 12)
        Me.lbl送信時対象ファイル種類.TabIndex = 32
        Me.lbl送信時対象ファイル種類.Text = "対象ファイル種類"
        '
        'lbl送信時パスワード
        '
        Me.lbl送信時パスワード.AutoSize = True
        Me.lbl送信時パスワード.Location = New System.Drawing.Point(12, 43)
        Me.lbl送信時パスワード.Name = "lbl送信時パスワード"
        Me.lbl送信時パスワード.Size = New System.Drawing.Size(52, 12)
        Me.lbl送信時パスワード.TabIndex = 27
        Me.lbl送信時パスワード.Text = "パスワード"
        '
        'lbl送信時ユーザー名
        '
        Me.lbl送信時ユーザー名.AutoSize = True
        Me.lbl送信時ユーザー名.Location = New System.Drawing.Point(12, 21)
        Me.lbl送信時ユーザー名.Name = "lbl送信時ユーザー名"
        Me.lbl送信時ユーザー名.Size = New System.Drawing.Size(57, 12)
        Me.lbl送信時ユーザー名.TabIndex = 28
        Me.lbl送信時ユーザー名.Text = "ユーザー名"
        '
        'txtタイムアウト
        '
        Me.txtタイムアウト.Location = New System.Drawing.Point(574, 44)
        Me.txtタイムアウト.Name = "txtタイムアウト"
        Me.txtタイムアウト.Size = New System.Drawing.Size(38, 19)
        Me.txtタイムアウト.TabIndex = 37
        '
        'txt送受信間隔
        '
        Me.txt送受信間隔.Location = New System.Drawing.Point(574, 21)
        Me.txt送受信間隔.Name = "txt送受信間隔"
        Me.txt送受信間隔.Size = New System.Drawing.Size(38, 19)
        Me.txt送受信間隔.TabIndex = 36
        '
        'txt接続先
        '
        Me.txt接続先.Location = New System.Drawing.Point(128, 44)
        Me.txt接続先.Name = "txt接続先"
        Me.txt接続先.Size = New System.Drawing.Size(117, 19)
        Me.txt接続先.TabIndex = 35
        '
        'lblタイムアウト
        '
        Me.lblタイムアウト.AutoSize = True
        Me.lblタイムアウト.Location = New System.Drawing.Point(470, 47)
        Me.lblタイムアウト.Name = "lblタイムアウト"
        Me.lblタイムアウト.Size = New System.Drawing.Size(82, 12)
        Me.lblタイムアウト.TabIndex = 11
        Me.lblタイムアウト.Text = "タイムアウト（秒）"
        '
        'lbl使用区分
        '
        Me.lbl使用区分.AutoSize = True
        Me.lbl使用区分.Location = New System.Drawing.Point(11, 24)
        Me.lbl使用区分.Name = "lbl使用区分"
        Me.lbl使用区分.Size = New System.Drawing.Size(53, 12)
        Me.lbl使用区分.TabIndex = 3
        Me.lbl使用区分.Text = "使用区分"
        '
        'lbl送受信間隔
        '
        Me.lbl送受信間隔.AutoSize = True
        Me.lbl送受信間隔.Location = New System.Drawing.Point(470, 24)
        Me.lbl送受信間隔.Name = "lbl送受信間隔"
        Me.lbl送受信間隔.Size = New System.Drawing.Size(89, 12)
        Me.lbl送受信間隔.TabIndex = 5
        Me.lbl送受信間隔.Text = "送受信間隔（分）"
        '
        'lbl接続先
        '
        Me.lbl接続先.AutoSize = True
        Me.lbl接続先.Location = New System.Drawing.Point(11, 47)
        Me.lbl接続先.Name = "lbl接続先"
        Me.lbl接続先.Size = New System.Drawing.Size(99, 12)
        Me.lbl接続先.TabIndex = 6
        Me.lbl接続先.Text = "接続先（IPアドレス）"
        '
        'cmb使用区分
        '
        Me.cmb使用区分.FormattingEnabled = True
        Me.cmb使用区分.Items.AddRange(New Object() {"FTPを使用しない", "FTPを使用する（タスクに常駐し、リアル送信）", "FTPを使用する（精算時に起動し送信）"})
        Me.cmb使用区分.Location = New System.Drawing.Point(128, 21)
        Me.cmb使用区分.Name = "cmb使用区分"
        Me.cmb使用区分.Size = New System.Drawing.Size(320, 20)
        Me.cmb使用区分.TabIndex = 8
        '
        'tabログジャーナル
        '
        Me.tabログジャーナル.Controls.Add(Me.grpジャーナル出力)
        Me.tabログジャーナル.Controls.Add(Me.grp電子ジャーナル出力)
        Me.tabログジャーナル.Location = New System.Drawing.Point(4, 22)
        Me.tabログジャーナル.Name = "tabログジャーナル"
        Me.tabログジャーナル.Padding = New System.Windows.Forms.Padding(3)
        Me.tabログジャーナル.Size = New System.Drawing.Size(979, 641)
        Me.tabログジャーナル.TabIndex = 3
        Me.tabログジャーナル.Text = "ログ・ジャーナル"
        Me.tabログジャーナル.UseVisualStyleBackColor = True
        '
        'grpジャーナル出力
        '
        Me.grpジャーナル出力.Controls.Add(Me.cmb見出し行)
        Me.grpジャーナル出力.Controls.Add(Me.lbl見出し行)
        Me.grpジャーナル出力.Controls.Add(Me.txtジャーナル出力先フォルダ)
        Me.grpジャーナル出力.Controls.Add(Me.btnジャーナル出力先フォルダ参照)
        Me.grpジャーナル出力.Controls.Add(Me.cmb一括取消の出力)
        Me.grpジャーナル出力.Controls.Add(Me.lblジャーナル出力先フォルダ)
        Me.grpジャーナル出力.Controls.Add(Me.lbl一括取消の出力)
        Me.grpジャーナル出力.Location = New System.Drawing.Point(6, 129)
        Me.grpジャーナル出力.Name = "grpジャーナル出力"
        Me.grpジャーナル出力.Size = New System.Drawing.Size(967, 106)
        Me.grpジャーナル出力.TabIndex = 51
        Me.grpジャーナル出力.TabStop = False
        Me.grpジャーナル出力.Text = "ジャーナル出力"
        '
        'cmb見出し行
        '
        Me.cmb見出し行.FormattingEnabled = True
        Me.cmb見出し行.Items.AddRange(New Object() {"出力する", "出力しない"})
        Me.cmb見出し行.Location = New System.Drawing.Point(130, 63)
        Me.cmb見出し行.Name = "cmb見出し行"
        Me.cmb見出し行.Size = New System.Drawing.Size(178, 20)
        Me.cmb見出し行.TabIndex = 52
        '
        'lbl見出し行
        '
        Me.lbl見出し行.AutoSize = True
        Me.lbl見出し行.Location = New System.Drawing.Point(12, 66)
        Me.lbl見出し行.Name = "lbl見出し行"
        Me.lbl見出し行.Size = New System.Drawing.Size(50, 12)
        Me.lbl見出し行.TabIndex = 51
        Me.lbl見出し行.Text = "見出し行"
        '
        'txtジャーナル出力先フォルダ
        '
        Me.txtジャーナル出力先フォルダ.Location = New System.Drawing.Point(130, 41)
        Me.txtジャーナル出力先フォルダ.Name = "txtジャーナル出力先フォルダ"
        Me.txtジャーナル出力先フォルダ.Size = New System.Drawing.Size(434, 19)
        Me.txtジャーナル出力先フォルダ.TabIndex = 50
        '
        'btnジャーナル出力先フォルダ参照
        '
        Me.btnジャーナル出力先フォルダ参照.Location = New System.Drawing.Point(582, 41)
        Me.btnジャーナル出力先フォルダ参照.Name = "btnジャーナル出力先フォルダ参照"
        Me.btnジャーナル出力先フォルダ参照.Size = New System.Drawing.Size(57, 19)
        Me.btnジャーナル出力先フォルダ参照.TabIndex = 49
        Me.btnジャーナル出力先フォルダ参照.Text = "参照"
        Me.btnジャーナル出力先フォルダ参照.UseVisualStyleBackColor = True
        '
        'cmb一括取消の出力
        '
        Me.cmb一括取消の出力.FormattingEnabled = True
        Me.cmb一括取消の出力.Items.AddRange(New Object() {"一括取消のカウントと金額のみを管理ジャーナルのDBには書き込みは行いません。", "一括取消をジャーナルに記録し、一括取消レシートも発行します。"})
        Me.cmb一括取消の出力.Location = New System.Drawing.Point(130, 18)
        Me.cmb一括取消の出力.Name = "cmb一括取消の出力"
        Me.cmb一括取消の出力.Size = New System.Drawing.Size(434, 20)
        Me.cmb一括取消の出力.TabIndex = 43
        '
        'lblジャーナル出力先フォルダ
        '
        Me.lblジャーナル出力先フォルダ.AutoSize = True
        Me.lblジャーナル出力先フォルダ.Location = New System.Drawing.Point(12, 44)
        Me.lblジャーナル出力先フォルダ.Name = "lblジャーナル出力先フォルダ"
        Me.lblジャーナル出力先フォルダ.Size = New System.Drawing.Size(71, 12)
        Me.lblジャーナル出力先フォルダ.TabIndex = 27
        Me.lblジャーナル出力先フォルダ.Text = "出力先ﾌｫﾙﾀﾞ"
        '
        'lbl一括取消の出力
        '
        Me.lbl一括取消の出力.AutoSize = True
        Me.lbl一括取消の出力.Location = New System.Drawing.Point(12, 21)
        Me.lbl一括取消の出力.Name = "lbl一括取消の出力"
        Me.lbl一括取消の出力.Size = New System.Drawing.Size(87, 12)
        Me.lbl一括取消の出力.TabIndex = 28
        Me.lbl一括取消の出力.Text = "一括取消の出力"
        '
        'grp電子ジャーナル出力
        '
        Me.grp電子ジャーナル出力.Controls.Add(Me.txtフォルダサイズ上限値)
        Me.grp電子ジャーナル出力.Controls.Add(Me.txt電子ジャーナル出力先フォルダ)
        Me.grp電子ジャーナル出力.Controls.Add(Me.btn電子ジャーナル出力先フォルダ参照)
        Me.grp電子ジャーナル出力.Controls.Add(Me.lblフォルダサイズ上限値)
        Me.grp電子ジャーナル出力.Controls.Add(Me.lbl電子ジャーナル出力先フォルダ)
        Me.grp電子ジャーナル出力.Location = New System.Drawing.Point(6, 6)
        Me.grp電子ジャーナル出力.Name = "grp電子ジャーナル出力"
        Me.grp電子ジャーナル出力.Size = New System.Drawing.Size(967, 80)
        Me.grp電子ジャーナル出力.TabIndex = 40
        Me.grp電子ジャーナル出力.TabStop = False
        Me.grp電子ジャーナル出力.Text = "電子ジャーナル出力"
        '
        'txtフォルダサイズ上限値
        '
        Me.txtフォルダサイズ上限値.Location = New System.Drawing.Point(172, 40)
        Me.txtフォルダサイズ上限値.Name = "txtフォルダサイズ上限値"
        Me.txtフォルダサイズ上限値.Size = New System.Drawing.Size(74, 19)
        Me.txtフォルダサイズ上限値.TabIndex = 51
        '
        'txt電子ジャーナル出力先フォルダ
        '
        Me.txt電子ジャーナル出力先フォルダ.Location = New System.Drawing.Point(172, 18)
        Me.txt電子ジャーナル出力先フォルダ.Name = "txt電子ジャーナル出力先フォルダ"
        Me.txt電子ジャーナル出力先フォルダ.Size = New System.Drawing.Size(392, 19)
        Me.txt電子ジャーナル出力先フォルダ.TabIndex = 50
        '
        'btn電子ジャーナル出力先フォルダ参照
        '
        Me.btn電子ジャーナル出力先フォルダ参照.Location = New System.Drawing.Point(582, 18)
        Me.btn電子ジャーナル出力先フォルダ参照.Name = "btn電子ジャーナル出力先フォルダ参照"
        Me.btn電子ジャーナル出力先フォルダ参照.Size = New System.Drawing.Size(57, 19)
        Me.btn電子ジャーナル出力先フォルダ参照.TabIndex = 49
        Me.btn電子ジャーナル出力先フォルダ参照.Text = "参照"
        Me.btn電子ジャーナル出力先フォルダ参照.UseVisualStyleBackColor = True
        '
        'lblフォルダサイズ上限値
        '
        Me.lblフォルダサイズ上限値.AutoSize = True
        Me.lblフォルダサイズ上限値.Location = New System.Drawing.Point(12, 43)
        Me.lblフォルダサイズ上限値.Name = "lblフォルダサイズ上限値"
        Me.lblフォルダサイズ上限値.Size = New System.Drawing.Size(124, 12)
        Me.lblフォルダサイズ上限値.TabIndex = 27
        Me.lblフォルダサイズ上限値.Text = "ﾌｫﾙﾀﾞｻｲｽﾞ上限値（MB)"
        '
        'lbl電子ジャーナル出力先フォルダ
        '
        Me.lbl電子ジャーナル出力先フォルダ.AutoSize = True
        Me.lbl電子ジャーナル出力先フォルダ.Location = New System.Drawing.Point(12, 21)
        Me.lbl電子ジャーナル出力先フォルダ.Name = "lbl電子ジャーナル出力先フォルダ"
        Me.lbl電子ジャーナル出力先フォルダ.Size = New System.Drawing.Size(71, 12)
        Me.lbl電子ジャーナル出力先フォルダ.TabIndex = 28
        Me.lbl電子ジャーナル出力先フォルダ.Text = "出力先ﾌｫﾙﾀﾞ"
        '
        'btn終了
        '
        Me.btn終了.Location = New System.Drawing.Point(913, 12)
        Me.btn終了.Name = "btn終了"
        Me.btn終了.Size = New System.Drawing.Size(86, 32)
        Me.btn終了.TabIndex = 28
        Me.btn終了.Text = "終了"
        Me.btn終了.UseVisualStyleBackColor = True
        '
        'btn更新
        '
        Me.btn更新.Location = New System.Drawing.Point(828, 12)
        Me.btn更新.Name = "btn更新"
        Me.btn更新.Size = New System.Drawing.Size(86, 32)
        Me.btn更新.TabIndex = 27
        Me.btn更新.Text = "更新"
        Me.btn更新.UseVisualStyleBackColor = True
        '
        'frm805店舗情報登録
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.btn終了)
        Me.Controls.Add(Me.btn更新)
        Me.Controls.Add(Me.tabc店舗基本情報)
        Me.Name = "frm805店舗情報登録"
        Me.Text = "店舗情報登録"
        Me.tabc店舗基本情報.ResumeLayout(False)
        Me.tab基本情報.ResumeLayout(False)
        Me.grp販売モードとテイクアウト.ResumeLayout(False)
        Me.grp販売モードとテイクアウト.PerformLayout()
        Me.grpその他設定.ResumeLayout(False)
        Me.grpその他設定.PerformLayout()
        Me.grp画面文字サイズ設定.ResumeLayout(False)
        Me.grp画面文字サイズ設定.PerformLayout()
        Me.grpバーコード設定.ResumeLayout(False)
        Me.grpバーコード設定.PerformLayout()
        Me.grpDB情報.ResumeLayout(False)
        Me.grpDB情報.PerformLayout()
        Me.grp預かり金入力設定.ResumeLayout(False)
        Me.grp預かり金入力設定.PerformLayout()
        Me.grpその他基本情報.ResumeLayout(False)
        Me.grpその他基本情報.PerformLayout()
        Me.grp店舗情報.ResumeLayout(False)
        Me.grp店舗情報.PerformLayout()
        Me.tabレシート領収レポート.ResumeLayout(False)
        Me.grp点検清算レポート.ResumeLayout(False)
        Me.grp点検清算レポート.PerformLayout()
        Me.grp領収情報.ResumeLayout(False)
        Me.grp領収情報.PerformLayout()
        Me.grpレシート情報.ResumeLayout(False)
        Me.grpレシート情報.PerformLayout()
        Me.tabFTPインポート.ResumeLayout(False)
        Me.grpマスタインポート設定.ResumeLayout(False)
        Me.grpマスタインポート設定.PerformLayout()
        Me.grpFTP設定.ResumeLayout(False)
        Me.grpFTP設定.PerformLayout()
        Me.grp受信時設定.ResumeLayout(False)
        Me.grp受信時設定.PerformLayout()
        Me.grp送信時設定.ResumeLayout(False)
        Me.grp送信時設定.PerformLayout()
        Me.tabログジャーナル.ResumeLayout(False)
        Me.grpジャーナル出力.ResumeLayout(False)
        Me.grpジャーナル出力.PerformLayout()
        Me.grp電子ジャーナル出力.ResumeLayout(False)
        Me.grp電子ジャーナル出力.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabc店舗基本情報 As TabControl
    Friend WithEvents tab基本情報 As TabPage
    Friend WithEvents tabレシート領収レポート As TabPage
    Friend WithEvents tabFTPインポート As TabPage
    Friend WithEvents tabログジャーナル As TabPage
    Friend WithEvents btn終了 As Button
    Friend WithEvents btn更新 As Button
    Friend WithEvents grp点検清算レポート As GroupBox
    Friend WithEvents grp領収情報 As GroupBox
    Friend WithEvents grpレシート情報 As GroupBox
    Friend WithEvents lblレシートNO As Label
    Friend WithEvents lblタイトル As Label
    Friend WithEvents lbl取引名印字文字サイズ As Label
    Friend WithEvents cmbレシートNO As ComboBox
    Friend WithEvents cmb取引名印字文字サイズ As ComboBox
    Friend WithEvents lbl末尾ロゴ印刷 As Label
    Friend WithEvents lblJANコード印刷 As Label
    Friend WithEvents lbl税額内訳印刷 As Label
    Friend WithEvents cmb末尾ロゴ印刷 As ComboBox
    Friend WithEvents cmb税額内訳印刷 As ComboBox
    Friend WithEvents cmbJANコード印刷 As ComboBox
    Friend WithEvents lbl控発行 As Label
    Friend WithEvents lbl宣伝文 As Label
    Friend WithEvents lbl宣伝文印刷 As Label
    Friend WithEvents cmbl控発行 As ComboBox
    Friend WithEvents cmb宣伝文印刷 As ComboBox
    Friend WithEvents lbl客層0件明細印字 As Label
    Friend WithEvents cmb客層0件明細印字 As ComboBox
    Friend WithEvents lbl時間帯0件明細印字 As Label
    Friend WithEvents lbl返品訂正集計印字 As Label
    Friend WithEvents cmb返品訂正集計印字 As ComboBox
    Friend WithEvents cmb時間帯0件明細印字 As ComboBox
    Friend WithEvents lbl組人数内訳印字 As Label
    Friend WithEvents lbl客数印字 As Label
    Friend WithEvents cmb客数印字 As ComboBox
    Friend WithEvents cmb組人数内訳印字 As ComboBox
    Friend WithEvents lbl備考 As Label
    Friend WithEvents lbl収入印紙枠印刷 As Label
    Friend WithEvents cmb収入印紙枠印刷 As ComboBox
    Friend WithEvents lbl領収但し書き As Label
    Friend WithEvents lbl領収名 As Label
    Friend WithEvents cmb領収名 As ComboBox
    Friend WithEvents lbl取引名印字文字サイズ追記 As Label
    Friend WithEvents lbl末尾ロゴ印刷追記 As Label
    Friend WithEvents lblクーポンカット As Label
    Friend WithEvents lbl合計点数印字 As Label
    Friend WithEvents cmb合計点数印字 As ComboBox
    Friend WithEvents cmbクーポンカット As ComboBox
    Friend WithEvents txt備考 As TextBox
    Friend WithEvents txt領収但し書き As TextBox
    Friend WithEvents txtタイトル As TextBox
    Friend WithEvents txt末尾ロゴ印刷 As TextBox
    Friend WithEvents txt宣伝文3 As TextBox
    Friend WithEvents txt宣伝文2 As TextBox
    Friend WithEvents txt宣伝文1 As TextBox
    Friend WithEvents grp店舗情報 As GroupBox
    Friend WithEvents lbl住所ハイフン As Label
    Friend WithEvents txt代表者 As TextBox
    Friend WithEvents txt会社名 As TextBox
    Friend WithEvents txtFAX As TextBox
    Friend WithEvents txt電話 As TextBox
    Friend WithEvents txt住所2 As TextBox
    Friend WithEvents txt住所1 As TextBox
    Friend WithEvents txt郵便2 As TextBox
    Friend WithEvents txt郵便1 As TextBox
    Friend WithEvents txt店舗名 As TextBox
    Friend WithEvents txt店舗CD As TextBox
    Friend WithEvents lbl電話FAX As Label
    Friend WithEvents lbl代表者 As Label
    Friend WithEvents lbl会社名 As Label
    Friend WithEvents lbl店舗CD As Label
    Friend WithEvents lbl住所 As Label
    Friend WithEvents lbl店舗名 As Label
    Friend WithEvents grp預かり金入力設定 As GroupBox
    Friend WithEvents cmb釣銭準備金 As ComboBox
    Friend WithEvents txt釣銭機残値 As TextBox
    Friend WithEvents lbl釣銭機残値 As Label
    Friend WithEvents lbl釣銭準備金 As Label
    Friend WithEvents cmb現金以外 As ComboBox
    Friend WithEvents lbl現金以外 As Label
    Friend WithEvents lbl現金 As Label
    Friend WithEvents cmb現金 As ComboBox
    Friend WithEvents grpその他基本情報 As GroupBox
    Friend WithEvents lblゼロ単価 As Label
    Friend WithEvents cmbゼロ単価 As ComboBox
    Friend WithEvents lbl人数入力 As Label
    Friend WithEvents lbl客層入力 As Label
    Friend WithEvents cmb客層入力 As ComboBox
    Friend WithEvents cmb人数入力 As ComboBox
    Friend WithEvents lbl担当入力 As Label
    Friend WithEvents lblデータ保存月数 As Label
    Friend WithEvents cmb担当入力 As ComboBox
    Friend WithEvents grpバーコード設定 As GroupBox
    Friend WithEvents lbl雑誌バーコード As Label
    Friend WithEvents cmb雑誌バーコード As ComboBox
    Friend WithEvents lbl書籍バーコード As Label
    Friend WithEvents lbl単価付バーコード As Label
    Friend WithEvents cmb単価付バーコード As ComboBox
    Friend WithEvents cmb書籍バーコード As ComboBox
    Friend WithEvents grpDB情報 As GroupBox
    Friend WithEvents txtDBサイズ警告上限値 As TextBox
    Friend WithEvents txtBKUP複写先フォルダ２ As TextBox
    Friend WithEvents txtBKUP複写先フォルダ１ As TextBox
    Friend WithEvents lblBKUP複写先フォルダ１ As Label
    Friend WithEvents lblDBサイズ警告上限値 As Label
    Friend WithEvents lblBKUP複写先フォルダ２ As Label
    Friend WithEvents lbl消費税端数 As Label
    Friend WithEvents cmb消費税端数 As ComboBox
    Friend WithEvents lbl指定取消 As Label
    Friend WithEvents lbl人数制限 As Label
    Friend WithEvents cmb指定取消 As ComboBox
    Friend WithEvents grp販売モードとテイクアウト As GroupBox
    Friend WithEvents lblモードリセット As Label
    Friend WithEvents lbl初期モード As Label
    Friend WithEvents cmb初期モード As ComboBox
    Friend WithEvents cmbモードリセット As ComboBox
    Friend WithEvents grpその他設定 As GroupBox
    Friend WithEvents lblページタグ数 As Label
    Friend WithEvents lbl金種表入力チェック As Label
    Friend WithEvents cmb金種表入力ﾁｪｯｸ As ComboBox
    Friend WithEvents cmbページタグ数 As ComboBox
    Friend WithEvents grp画面文字サイズ設定 As GroupBox
    Friend WithEvents lbl会計明細文字 As Label
    Friend WithEvents lblメニュー文字 As Label
    Friend WithEvents cmbメニュー文字 As ComboBox
    Friend WithEvents cmb会計明細文字 As ComboBox
    Friend WithEvents grpFTP設定 As GroupBox
    Friend WithEvents txtタイムアウト As TextBox
    Friend WithEvents txt送受信間隔 As TextBox
    Friend WithEvents txt接続先 As TextBox
    Friend WithEvents lblタイムアウト As Label
    Friend WithEvents lbl使用区分 As Label
    Friend WithEvents lbl送受信間隔 As Label
    Friend WithEvents lbl接続先 As Label
    Friend WithEvents cmb使用区分 As ComboBox
    Friend WithEvents grpマスタインポート設定 As GroupBox
    Friend WithEvents txtCSV格納フォルダ As TextBox
    Friend WithEvents btn参照 As Button
    Friend WithEvents cmb自動起動区分 As ComboBox
    Friend WithEvents lblCSV格納フォルダ As Label
    Friend WithEvents lbl自動起動区分 As Label
    Friend WithEvents grp受信時設定 As GroupBox
    Friend WithEvents btn受信時設定通信確認 As Button
    Friend WithEvents txt受信元サーバフォルダ As TextBox
    Friend WithEvents lbl受信元サーバフォルダ As Label
    Friend WithEvents txt受信時対象ファイル種類 As TextBox
    Friend WithEvents txt受信時パスワード As TextBox
    Friend WithEvents txt受信時ユーザー名 As TextBox
    Friend WithEvents lbl受信時対象ファイル種類 As Label
    Friend WithEvents lbl受信時パスワード As Label
    Friend WithEvents lbl受信時ユーザー名 As Label
    Friend WithEvents grp送信時設定 As GroupBox
    Friend WithEvents btn送信時設定通信確認 As Button
    Friend WithEvents txt送信先サーバフォルダ As TextBox
    Friend WithEvents lbl送信モード As Label
    Friend WithEvents lbl送信先サーバフォルダ As Label
    Friend WithEvents txt送信時対象ファイル種類 As TextBox
    Friend WithEvents txt送信時パスワード As TextBox
    Friend WithEvents cmb送信モード As ComboBox
    Friend WithEvents txt送信時ユーザー名 As TextBox
    Friend WithEvents lbl送信時対象ファイル種類 As Label
    Friend WithEvents lbl送信時パスワード As Label
    Friend WithEvents lbl送信時ユーザー名 As Label
    Friend WithEvents grpジャーナル出力 As GroupBox
    Friend WithEvents cmb見出し行 As ComboBox
    Friend WithEvents lbl見出し行 As Label
    Friend WithEvents txtジャーナル出力先フォルダ As TextBox
    Friend WithEvents btnジャーナル出力先フォルダ参照 As Button
    Friend WithEvents cmb一括取消の出力 As ComboBox
    Friend WithEvents lblジャーナル出力先フォルダ As Label
    Friend WithEvents lbl一括取消の出力 As Label
    Friend WithEvents grp電子ジャーナル出力 As GroupBox
    Friend WithEvents txtフォルダサイズ上限値 As TextBox
    Friend WithEvents txt電子ジャーナル出力先フォルダ As TextBox
    Friend WithEvents lblフォルダサイズ上限値 As Label
    Friend WithEvents lbl電子ジャーナル出力先フォルダ As Label
    Friend WithEvents txtデータ保存月数 As TextBox
    Friend WithEvents txt明細数制限 As TextBox
    Friend WithEvents lbl明細数制限 As Label
    Friend WithEvents txt人数制限 As TextBox
    Public WithEvents btn電子ジャーナル出力先フォルダ参照 As Button
End Class
