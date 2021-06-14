<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm806端末情報登録
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
        Me.btn更新 = New System.Windows.Forms.Button()
        Me.btn終了 = New System.Windows.Forms.Button()
        Me.gbx基本情報 = New System.Windows.Forms.GroupBox()
        Me.cmb天候入力 = New System.Windows.Forms.ComboBox()
        Me.cmbボタン効果音 = New System.Windows.Forms.ComboBox()
        Me.txt管理名称 = New System.Windows.Forms.TextBox()
        Me.lbl業態店舗CD = New System.Windows.Forms.Label()
        Me.txt業態店舗CD入力 = New System.Windows.Forms.TextBox()
        Me.txt端末CD入力 = New System.Windows.Forms.TextBox()
        Me.lbl天候入力 = New System.Windows.Forms.Label()
        Me.lblボタン効果音 = New System.Windows.Forms.Label()
        Me.lbl管理名称 = New System.Windows.Forms.Label()
        Me.lbl端末CD = New System.Windows.Forms.Label()
        Me.gbx端末情報設定 = New System.Windows.Forms.GroupBox()
        Me.cmb拡張キーボード = New System.Windows.Forms.ComboBox()
        Me.lbl拡張キーボード = New System.Windows.Forms.Label()
        Me.cmbﾊﾞｰｺｰﾄﾞﾘｰﾀﾞｰ = New System.Windows.Forms.ComboBox()
        Me.cmb背面ﾃﾞｨｽﾌﾟﾚｲ = New System.Windows.Forms.ComboBox()
        Me.cmbｶｽﾀﾏﾃﾞｨｽﾌﾟﾚｲ = New System.Windows.Forms.ComboBox()
        Me.cmbつり銭機 = New System.Windows.Forms.ComboBox()
        Me.cmbｷｬｼｭﾄﾞﾛｱ = New System.Windows.Forms.ComboBox()
        Me.cmbカード決済端末 = New System.Windows.Forms.ComboBox()
        Me.lblﾊﾞｰｺｰﾄﾞﾘｰﾀﾞｰ = New System.Windows.Forms.Label()
        Me.lbl背面ﾃﾞｨｽﾌﾟﾚｲ = New System.Windows.Forms.Label()
        Me.lblｶｽﾀﾏﾃﾞｨｽﾌﾟﾚｲ = New System.Windows.Forms.Label()
        Me.lblつり銭機 = New System.Windows.Forms.Label()
        Me.lblｷｬｼｭﾄﾞﾛｱ = New System.Windows.Forms.Label()
        Me.lblカード決済端末 = New System.Windows.Forms.Label()
        Me.gbx食券発行 = New System.Windows.Forms.GroupBox()
        Me.cmb控発行 = New System.Windows.Forms.ComboBox()
        Me.cmbカット = New System.Windows.Forms.ComboBox()
        Me.txt印字記号 = New System.Windows.Forms.TextBox()
        Me.lbl控発行 = New System.Windows.Forms.Label()
        Me.lblカット = New System.Windows.Forms.Label()
        Me.lbl印字記号 = New System.Windows.Forms.Label()
        Me.gbxオーダリング = New System.Windows.Forms.GroupBox()
        Me.会計後の利用不可時間 = New System.Windows.Forms.Label()
        Me.txtOES入力 = New System.Windows.Forms.TextBox()
        Me.txt会計済入力 = New System.Windows.Forms.TextBox()
        Me.cmb数量単価 = New System.Windows.Forms.ComboBox()
        Me.cmbメニュー集計 = New System.Windows.Forms.ComboBox()
        Me.cmbゼロ円明細 = New System.Windows.Forms.ComboBox()
        Me.cmboes会計 = New System.Windows.Forms.ComboBox()
        Me.cmb前後払い = New System.Windows.Forms.ComboBox()
        Me.cmb使用区分 = New System.Windows.Forms.ComboBox()
        Me.lbl会計済ｲﾝﾀｰﾊﾞﾙ = New System.Windows.Forms.Label()
        Me.lbl数量単価変更 = New System.Windows.Forms.Label()
        Me.lblメニュー集計 = New System.Windows.Forms.Label()
        Me.lblゼロ円明細 = New System.Windows.Forms.Label()
        Me.lblOESIPｱﾄﾞﾚｽ = New System.Windows.Forms.Label()
        Me.lblOES会計済区分 = New System.Windows.Forms.Label()
        Me.lbl前払い後払い = New System.Windows.Forms.Label()
        Me.lbl使用区分 = New System.Windows.Forms.Label()
        Me.gbx固定スキャナ = New System.Windows.Forms.GroupBox()
        Me.txt接続COMポート入力 = New System.Windows.Forms.TextBox()
        Me.lbl接続COMポート = New System.Windows.Forms.Label()
        Me.gbxカスタマディスプレイ = New System.Windows.Forms.GroupBox()
        Me.txt登録入力 = New System.Windows.Forms.TextBox()
        Me.txt停止入力 = New System.Windows.Forms.TextBox()
        Me.lbl登録 = New System.Windows.Forms.Label()
        Me.lbl停止 = New System.Windows.Forms.Label()
        Me.gbxINFOX = New System.Windows.Forms.GroupBox()
        Me.cmb支払種別入力 = New System.Windows.Forms.ComboBox()
        Me.txt応答ﾀｲﾑ入力 = New System.Windows.Forms.TextBox()
        Me.txt接続COMポート2入力 = New System.Windows.Forms.TextBox()
        Me.txt接続COMポート1入力 = New System.Windows.Forms.TextBox()
        Me.lbl応答ﾀｲﾑｱｳﾄ秒 = New System.Windows.Forms.Label()
        Me.lbl支払種別入力 = New System.Windows.Forms.Label()
        Me.lbl接続COMポート2 = New System.Windows.Forms.Label()
        Me.lbl接続COMポート1 = New System.Windows.Forms.Label()
        Me.gbx背面ディスプレイ = New System.Windows.Forms.GroupBox()
        Me.txt会計挨拶入力1 = New System.Windows.Forms.TextBox()
        Me.txt会計挨拶入力2 = New System.Windows.Forms.TextBox()
        Me.txt会計挨拶入力3 = New System.Windows.Forms.TextBox()
        Me.txt会計挨拶入力4 = New System.Windows.Forms.TextBox()
        Me.txt宣伝文入力2 = New System.Windows.Forms.TextBox()
        Me.txt宣伝文入力3 = New System.Windows.Forms.TextBox()
        Me.txt宣伝文入力4 = New System.Windows.Forms.TextBox()
        Me.txt宣伝文入力1 = New System.Windows.Forms.TextBox()
        Me.btn_画像ﾌｧｲﾙ10 = New System.Windows.Forms.Button()
        Me.btn_画像ﾌｧｲﾙ2 = New System.Windows.Forms.Button()
        Me.btn_画像ﾌｧｲﾙ3 = New System.Windows.Forms.Button()
        Me.btn_画像ﾌｧｲﾙ4 = New System.Windows.Forms.Button()
        Me.btn_画像ﾌｧｲﾙ5 = New System.Windows.Forms.Button()
        Me.btn_画像ﾌｧｲﾙ6 = New System.Windows.Forms.Button()
        Me.btn_画像ﾌｧｲﾙ7 = New System.Windows.Forms.Button()
        Me.btn_画像ﾌｧｲﾙ8 = New System.Windows.Forms.Button()
        Me.btn_画像ﾌｧｲﾙ9 = New System.Windows.Forms.Button()
        Me.btn_画像ﾌｧｲﾙ1 = New System.Windows.Forms.Button()
        Me.txt画像ﾌｧｲﾙ10 = New System.Windows.Forms.TextBox()
        Me.txt画像ﾌｧｲﾙ9 = New System.Windows.Forms.TextBox()
        Me.txt画像ﾌｧｲﾙ8 = New System.Windows.Forms.TextBox()
        Me.txt画像ﾌｧｲﾙ7 = New System.Windows.Forms.TextBox()
        Me.txt画像ﾌｧｲﾙ6 = New System.Windows.Forms.TextBox()
        Me.txt画像ﾌｧｲﾙ5 = New System.Windows.Forms.TextBox()
        Me.txt画像ﾌｧｲﾙ4 = New System.Windows.Forms.TextBox()
        Me.txt画像ﾌｧｲﾙ3 = New System.Windows.Forms.TextBox()
        Me.txt画像ﾌｧｲﾙ2 = New System.Windows.Forms.TextBox()
        Me.txt画像ﾌｧｲﾙ1 = New System.Windows.Forms.TextBox()
        Me.txt切替ﾀｲﾏｰ = New System.Windows.Forms.TextBox()
        Me.lbl会計挨拶 = New System.Windows.Forms.Label()
        Me.lbl宣伝文 = New System.Windows.Forms.Label()
        Me.lbl画像ﾌｧｲﾙ = New System.Windows.Forms.Label()
        Me.lbl切替ﾀｲﾏｰ秒 = New System.Windows.Forms.Label()
        Me.gbx基本情報.SuspendLayout()
        Me.gbx端末情報設定.SuspendLayout()
        Me.gbx食券発行.SuspendLayout()
        Me.gbxオーダリング.SuspendLayout()
        Me.gbx固定スキャナ.SuspendLayout()
        Me.gbxカスタマディスプレイ.SuspendLayout()
        Me.gbxINFOX.SuspendLayout()
        Me.gbx背面ディスプレイ.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn更新
        '
        Me.btn更新.Location = New System.Drawing.Point(837, 12)
        Me.btn更新.Name = "btn更新"
        Me.btn更新.Size = New System.Drawing.Size(80, 30)
        Me.btn更新.TabIndex = 0
        Me.btn更新.Text = "更新"
        Me.btn更新.UseVisualStyleBackColor = True
        '
        'btn終了
        '
        Me.btn終了.Location = New System.Drawing.Point(916, 12)
        Me.btn終了.Name = "btn終了"
        Me.btn終了.Size = New System.Drawing.Size(80, 30)
        Me.btn終了.TabIndex = 1
        Me.btn終了.Text = "終了(C)"
        Me.btn終了.UseVisualStyleBackColor = True
        '
        'gbx基本情報
        '
        Me.gbx基本情報.Controls.Add(Me.cmb天候入力)
        Me.gbx基本情報.Controls.Add(Me.cmbボタン効果音)
        Me.gbx基本情報.Controls.Add(Me.txt管理名称)
        Me.gbx基本情報.Controls.Add(Me.lbl業態店舗CD)
        Me.gbx基本情報.Controls.Add(Me.txt業態店舗CD入力)
        Me.gbx基本情報.Controls.Add(Me.txt端末CD入力)
        Me.gbx基本情報.Controls.Add(Me.lbl天候入力)
        Me.gbx基本情報.Controls.Add(Me.lblボタン効果音)
        Me.gbx基本情報.Controls.Add(Me.lbl管理名称)
        Me.gbx基本情報.Controls.Add(Me.lbl端末CD)
        Me.gbx基本情報.Location = New System.Drawing.Point(12, 12)
        Me.gbx基本情報.Name = "gbx基本情報"
        Me.gbx基本情報.Size = New System.Drawing.Size(400, 111)
        Me.gbx基本情報.TabIndex = 2
        Me.gbx基本情報.TabStop = False
        Me.gbx基本情報.Text = "基本情報"
        '
        'cmb天候入力
        '
        Me.cmb天候入力.FormattingEnabled = True
        Me.cmb天候入力.Items.AddRange(New Object() {"天候を入力しない", "天候を入力する"})
        Me.cmb天候入力.Location = New System.Drawing.Point(108, 79)
        Me.cmb天候入力.Name = "cmb天候入力"
        Me.cmb天候入力.Size = New System.Drawing.Size(236, 20)
        Me.cmb天候入力.TabIndex = 9
        '
        'cmbボタン効果音
        '
        Me.cmbボタン効果音.FormattingEnabled = True
        Me.cmbボタン効果音.Items.AddRange(New Object() {"効果音あり", "効果音なし"})
        Me.cmbボタン効果音.Location = New System.Drawing.Point(108, 57)
        Me.cmbボタン効果音.Name = "cmbボタン効果音"
        Me.cmbボタン効果音.Size = New System.Drawing.Size(236, 20)
        Me.cmbボタン効果音.TabIndex = 8
        '
        'txt管理名称
        '
        Me.txt管理名称.Location = New System.Drawing.Point(108, 38)
        Me.txt管理名称.Name = "txt管理名称"
        Me.txt管理名称.Size = New System.Drawing.Size(236, 19)
        Me.txt管理名称.TabIndex = 7
        '
        'lbl業態店舗CD
        '
        Me.lbl業態店舗CD.Location = New System.Drawing.Point(178, 21)
        Me.lbl業態店舗CD.Name = "lbl業態店舗CD"
        Me.lbl業態店舗CD.Size = New System.Drawing.Size(80, 12)
        Me.lbl業態店舗CD.TabIndex = 6
        Me.lbl業態店舗CD.Text = "業態店舗CD"
        '
        'txt業態店舗CD入力
        '
        Me.txt業態店舗CD入力.Location = New System.Drawing.Point(264, 18)
        Me.txt業態店舗CD入力.Name = "txt業態店舗CD入力"
        Me.txt業態店舗CD入力.Size = New System.Drawing.Size(80, 19)
        Me.txt業態店舗CD入力.TabIndex = 5
        '
        'txt端末CD入力
        '
        Me.txt端末CD入力.Location = New System.Drawing.Point(108, 18)
        Me.txt端末CD入力.Name = "txt端末CD入力"
        Me.txt端末CD入力.Size = New System.Drawing.Size(64, 19)
        Me.txt端末CD入力.TabIndex = 4
        '
        'lbl天候入力
        '
        Me.lbl天候入力.Location = New System.Drawing.Point(26, 82)
        Me.lbl天候入力.Name = "lbl天候入力"
        Me.lbl天候入力.Size = New System.Drawing.Size(80, 15)
        Me.lbl天候入力.TabIndex = 3
        Me.lbl天候入力.Text = "天候入力"
        Me.lbl天候入力.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblボタン効果音
        '
        Me.lblボタン効果音.Location = New System.Drawing.Point(26, 59)
        Me.lblボタン効果音.Name = "lblボタン効果音"
        Me.lblボタン効果音.Size = New System.Drawing.Size(80, 15)
        Me.lblボタン効果音.TabIndex = 2
        Me.lblボタン効果音.Text = "ボタン効果音"
        Me.lblボタン効果音.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl管理名称
        '
        Me.lbl管理名称.Location = New System.Drawing.Point(26, 38)
        Me.lbl管理名称.Name = "lbl管理名称"
        Me.lbl管理名称.Size = New System.Drawing.Size(80, 15)
        Me.lbl管理名称.TabIndex = 1
        Me.lbl管理名称.Text = "管理名称"
        Me.lbl管理名称.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl端末CD
        '
        Me.lbl端末CD.Location = New System.Drawing.Point(26, 18)
        Me.lbl端末CD.Name = "lbl端末CD"
        Me.lbl端末CD.Size = New System.Drawing.Size(80, 15)
        Me.lbl端末CD.TabIndex = 0
        Me.lbl端末CD.Text = "端末CD"
        Me.lbl端末CD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbx端末情報設定
        '
        Me.gbx端末情報設定.Controls.Add(Me.cmb拡張キーボード)
        Me.gbx端末情報設定.Controls.Add(Me.lbl拡張キーボード)
        Me.gbx端末情報設定.Controls.Add(Me.cmbﾊﾞｰｺｰﾄﾞﾘｰﾀﾞｰ)
        Me.gbx端末情報設定.Controls.Add(Me.cmb背面ﾃﾞｨｽﾌﾟﾚｲ)
        Me.gbx端末情報設定.Controls.Add(Me.cmbｶｽﾀﾏﾃﾞｨｽﾌﾟﾚｲ)
        Me.gbx端末情報設定.Controls.Add(Me.cmbつり銭機)
        Me.gbx端末情報設定.Controls.Add(Me.cmbｷｬｼｭﾄﾞﾛｱ)
        Me.gbx端末情報設定.Controls.Add(Me.cmbカード決済端末)
        Me.gbx端末情報設定.Controls.Add(Me.lblﾊﾞｰｺｰﾄﾞﾘｰﾀﾞｰ)
        Me.gbx端末情報設定.Controls.Add(Me.lbl背面ﾃﾞｨｽﾌﾟﾚｲ)
        Me.gbx端末情報設定.Controls.Add(Me.lblｶｽﾀﾏﾃﾞｨｽﾌﾟﾚｲ)
        Me.gbx端末情報設定.Controls.Add(Me.lblつり銭機)
        Me.gbx端末情報設定.Controls.Add(Me.lblｷｬｼｭﾄﾞﾛｱ)
        Me.gbx端末情報設定.Controls.Add(Me.lblカード決済端末)
        Me.gbx端末情報設定.Location = New System.Drawing.Point(14, 146)
        Me.gbx端末情報設定.Name = "gbx端末情報設定"
        Me.gbx端末情報設定.Size = New System.Drawing.Size(400, 196)
        Me.gbx端末情報設定.TabIndex = 3
        Me.gbx端末情報設定.TabStop = False
        Me.gbx端末情報設定.Text = "端末情報設定"
        '
        'cmb拡張キーボード
        '
        Me.cmb拡張キーボード.FormattingEnabled = True
        Me.cmb拡張キーボード.Items.AddRange(New Object() {"YES"})
        Me.cmb拡張キーボード.Location = New System.Drawing.Point(106, 147)
        Me.cmb拡張キーボード.Name = "cmb拡張キーボード"
        Me.cmb拡張キーボード.Size = New System.Drawing.Size(280, 20)
        Me.cmb拡張キーボード.TabIndex = 12
        '
        'lbl拡張キーボード
        '
        Me.lbl拡張キーボード.Location = New System.Drawing.Point(24, 154)
        Me.lbl拡張キーボード.Name = "lbl拡張キーボード"
        Me.lbl拡張キーボード.Size = New System.Drawing.Size(80, 15)
        Me.lbl拡張キーボード.TabIndex = 6
        Me.lbl拡張キーボード.Text = "拡張キーボード"
        Me.lbl拡張キーボード.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbﾊﾞｰｺｰﾄﾞﾘｰﾀﾞｰ
        '
        Me.cmbﾊﾞｰｺｰﾄﾞﾘｰﾀﾞｰ.FormattingEnabled = True
        Me.cmbﾊﾞｰｺｰﾄﾞﾘｰﾀﾞｰ.Items.AddRange(New Object() {"NO"})
        Me.cmbﾊﾞｰｺｰﾄﾞﾘｰﾀﾞｰ.Location = New System.Drawing.Point(106, 126)
        Me.cmbﾊﾞｰｺｰﾄﾞﾘｰﾀﾞｰ.Name = "cmbﾊﾞｰｺｰﾄﾞﾘｰﾀﾞｰ"
        Me.cmbﾊﾞｰｺｰﾄﾞﾘｰﾀﾞｰ.Size = New System.Drawing.Size(280, 20)
        Me.cmbﾊﾞｰｺｰﾄﾞﾘｰﾀﾞｰ.TabIndex = 11
        '
        'cmb背面ﾃﾞｨｽﾌﾟﾚｲ
        '
        Me.cmb背面ﾃﾞｨｽﾌﾟﾚｲ.FormattingEnabled = True
        Me.cmb背面ﾃﾞｨｽﾌﾟﾚｲ.Items.AddRange(New Object() {"NO"})
        Me.cmb背面ﾃﾞｨｽﾌﾟﾚｲ.Location = New System.Drawing.Point(106, 105)
        Me.cmb背面ﾃﾞｨｽﾌﾟﾚｲ.Name = "cmb背面ﾃﾞｨｽﾌﾟﾚｲ"
        Me.cmb背面ﾃﾞｨｽﾌﾟﾚｲ.Size = New System.Drawing.Size(280, 20)
        Me.cmb背面ﾃﾞｨｽﾌﾟﾚｲ.TabIndex = 10
        '
        'cmbｶｽﾀﾏﾃﾞｨｽﾌﾟﾚｲ
        '
        Me.cmbｶｽﾀﾏﾃﾞｨｽﾌﾟﾚｲ.FormattingEnabled = True
        Me.cmbｶｽﾀﾏﾃﾞｨｽﾌﾟﾚｲ.Items.AddRange(New Object() {"NO"})
        Me.cmbｶｽﾀﾏﾃﾞｨｽﾌﾟﾚｲ.Location = New System.Drawing.Point(106, 84)
        Me.cmbｶｽﾀﾏﾃﾞｨｽﾌﾟﾚｲ.Name = "cmbｶｽﾀﾏﾃﾞｨｽﾌﾟﾚｲ"
        Me.cmbｶｽﾀﾏﾃﾞｨｽﾌﾟﾚｲ.Size = New System.Drawing.Size(280, 20)
        Me.cmbｶｽﾀﾏﾃﾞｨｽﾌﾟﾚｲ.TabIndex = 9
        '
        'cmbつり銭機
        '
        Me.cmbつり銭機.FormattingEnabled = True
        Me.cmbつり銭機.Items.AddRange(New Object() {"NO"})
        Me.cmbつり銭機.Location = New System.Drawing.Point(106, 63)
        Me.cmbつり銭機.Name = "cmbつり銭機"
        Me.cmbつり銭機.Size = New System.Drawing.Size(280, 20)
        Me.cmbつり銭機.TabIndex = 8
        '
        'cmbｷｬｼｭﾄﾞﾛｱ
        '
        Me.cmbｷｬｼｭﾄﾞﾛｱ.FormattingEnabled = True
        Me.cmbｷｬｼｭﾄﾞﾛｱ.Items.AddRange(New Object() {"NO"})
        Me.cmbｷｬｼｭﾄﾞﾛｱ.Location = New System.Drawing.Point(106, 42)
        Me.cmbｷｬｼｭﾄﾞﾛｱ.Name = "cmbｷｬｼｭﾄﾞﾛｱ"
        Me.cmbｷｬｼｭﾄﾞﾛｱ.Size = New System.Drawing.Size(280, 20)
        Me.cmbｷｬｼｭﾄﾞﾛｱ.TabIndex = 7
        '
        'cmbカード決済端末
        '
        Me.cmbカード決済端末.FormattingEnabled = True
        Me.cmbカード決済端末.Items.AddRange(New Object() {"NO"})
        Me.cmbカード決済端末.Location = New System.Drawing.Point(106, 21)
        Me.cmbカード決済端末.Name = "cmbカード決済端末"
        Me.cmbカード決済端末.Size = New System.Drawing.Size(280, 20)
        Me.cmbカード決済端末.TabIndex = 6
        '
        'lblﾊﾞｰｺｰﾄﾞﾘｰﾀﾞｰ
        '
        Me.lblﾊﾞｰｺｰﾄﾞﾘｰﾀﾞｰ.Location = New System.Drawing.Point(24, 131)
        Me.lblﾊﾞｰｺｰﾄﾞﾘｰﾀﾞｰ.Name = "lblﾊﾞｰｺｰﾄﾞﾘｰﾀﾞｰ"
        Me.lblﾊﾞｰｺｰﾄﾞﾘｰﾀﾞｰ.Size = New System.Drawing.Size(80, 15)
        Me.lblﾊﾞｰｺｰﾄﾞﾘｰﾀﾞｰ.TabIndex = 5
        Me.lblﾊﾞｰｺｰﾄﾞﾘｰﾀﾞｰ.Text = "ﾊﾞｰｺｰﾄﾞﾘｰﾀﾞｰ"
        Me.lblﾊﾞｰｺｰﾄﾞﾘｰﾀﾞｰ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl背面ﾃﾞｨｽﾌﾟﾚｲ
        '
        Me.lbl背面ﾃﾞｨｽﾌﾟﾚｲ.Location = New System.Drawing.Point(24, 108)
        Me.lbl背面ﾃﾞｨｽﾌﾟﾚｲ.Name = "lbl背面ﾃﾞｨｽﾌﾟﾚｲ"
        Me.lbl背面ﾃﾞｨｽﾌﾟﾚｲ.Size = New System.Drawing.Size(80, 15)
        Me.lbl背面ﾃﾞｨｽﾌﾟﾚｲ.TabIndex = 4
        Me.lbl背面ﾃﾞｨｽﾌﾟﾚｲ.Text = "背面ﾃﾞｨｽﾌﾟﾚｲ"
        Me.lbl背面ﾃﾞｨｽﾌﾟﾚｲ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblｶｽﾀﾏﾃﾞｨｽﾌﾟﾚｲ
        '
        Me.lblｶｽﾀﾏﾃﾞｨｽﾌﾟﾚｲ.Location = New System.Drawing.Point(24, 87)
        Me.lblｶｽﾀﾏﾃﾞｨｽﾌﾟﾚｲ.Name = "lblｶｽﾀﾏﾃﾞｨｽﾌﾟﾚｲ"
        Me.lblｶｽﾀﾏﾃﾞｨｽﾌﾟﾚｲ.Size = New System.Drawing.Size(80, 15)
        Me.lblｶｽﾀﾏﾃﾞｨｽﾌﾟﾚｲ.TabIndex = 3
        Me.lblｶｽﾀﾏﾃﾞｨｽﾌﾟﾚｲ.Text = "ｶｽﾀﾏﾃﾞｨｽﾌﾟﾚｲ"
        Me.lblｶｽﾀﾏﾃﾞｨｽﾌﾟﾚｲ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblつり銭機
        '
        Me.lblつり銭機.Location = New System.Drawing.Point(24, 67)
        Me.lblつり銭機.Name = "lblつり銭機"
        Me.lblつり銭機.Size = New System.Drawing.Size(80, 15)
        Me.lblつり銭機.TabIndex = 2
        Me.lblつり銭機.Text = "つり銭機"
        Me.lblつり銭機.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblｷｬｼｭﾄﾞﾛｱ
        '
        Me.lblｷｬｼｭﾄﾞﾛｱ.Location = New System.Drawing.Point(24, 45)
        Me.lblｷｬｼｭﾄﾞﾛｱ.Name = "lblｷｬｼｭﾄﾞﾛｱ"
        Me.lblｷｬｼｭﾄﾞﾛｱ.Size = New System.Drawing.Size(80, 15)
        Me.lblｷｬｼｭﾄﾞﾛｱ.TabIndex = 1
        Me.lblｷｬｼｭﾄﾞﾛｱ.Text = "ｷｬｼｭﾄﾞﾛｱ"
        Me.lblｷｬｼｭﾄﾞﾛｱ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblカード決済端末
        '
        Me.lblカード決済端末.Location = New System.Drawing.Point(24, 24)
        Me.lblカード決済端末.Name = "lblカード決済端末"
        Me.lblカード決済端末.Size = New System.Drawing.Size(80, 15)
        Me.lblカード決済端末.TabIndex = 0
        Me.lblカード決済端末.Text = "カード決済端末"
        Me.lblカード決済端末.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbx食券発行
        '
        Me.gbx食券発行.Controls.Add(Me.cmb控発行)
        Me.gbx食券発行.Controls.Add(Me.cmbカット)
        Me.gbx食券発行.Controls.Add(Me.txt印字記号)
        Me.gbx食券発行.Controls.Add(Me.lbl控発行)
        Me.gbx食券発行.Controls.Add(Me.lblカット)
        Me.gbx食券発行.Controls.Add(Me.lbl印字記号)
        Me.gbx食券発行.Location = New System.Drawing.Point(12, 348)
        Me.gbx食券発行.Name = "gbx食券発行"
        Me.gbx食券発行.Size = New System.Drawing.Size(400, 96)
        Me.gbx食券発行.TabIndex = 4
        Me.gbx食券発行.TabStop = False
        Me.gbx食券発行.Text = "食券発行"
        '
        'cmb控発行
        '
        Me.cmb控発行.FormattingEnabled = True
        Me.cmb控発行.Location = New System.Drawing.Point(100, 63)
        Me.cmb控発行.Name = "cmb控発行"
        Me.cmb控発行.Size = New System.Drawing.Size(280, 20)
        Me.cmb控発行.TabIndex = 5
        '
        'cmbカット
        '
        Me.cmbカット.FormattingEnabled = True
        Me.cmbカット.Location = New System.Drawing.Point(100, 42)
        Me.cmbカット.Name = "cmbカット"
        Me.cmbカット.Size = New System.Drawing.Size(280, 20)
        Me.cmbカット.TabIndex = 4
        '
        'txt印字記号
        '
        Me.txt印字記号.Location = New System.Drawing.Point(100, 22)
        Me.txt印字記号.Name = "txt印字記号"
        Me.txt印字記号.Size = New System.Drawing.Size(38, 19)
        Me.txt印字記号.TabIndex = 3
        '
        'lbl控発行
        '
        Me.lbl控発行.Location = New System.Drawing.Point(18, 71)
        Me.lbl控発行.Name = "lbl控発行"
        Me.lbl控発行.Size = New System.Drawing.Size(80, 15)
        Me.lbl控発行.TabIndex = 2
        Me.lbl控発行.Text = "控発行"
        Me.lbl控発行.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblカット
        '
        Me.lblカット.Location = New System.Drawing.Point(18, 50)
        Me.lblカット.Name = "lblカット"
        Me.lblカット.Size = New System.Drawing.Size(80, 15)
        Me.lblカット.TabIndex = 1
        Me.lblカット.Text = "カット"
        Me.lblカット.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl印字記号
        '
        Me.lbl印字記号.Location = New System.Drawing.Point(18, 25)
        Me.lbl印字記号.Name = "lbl印字記号"
        Me.lbl印字記号.Size = New System.Drawing.Size(80, 15)
        Me.lbl印字記号.TabIndex = 0
        Me.lbl印字記号.Text = "印字記号"
        Me.lbl印字記号.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbxオーダリング
        '
        Me.gbxオーダリング.Controls.Add(Me.会計後の利用不可時間)
        Me.gbxオーダリング.Controls.Add(Me.txtOES入力)
        Me.gbxオーダリング.Controls.Add(Me.txt会計済入力)
        Me.gbxオーダリング.Controls.Add(Me.cmb数量単価)
        Me.gbxオーダリング.Controls.Add(Me.cmbメニュー集計)
        Me.gbxオーダリング.Controls.Add(Me.cmbゼロ円明細)
        Me.gbxオーダリング.Controls.Add(Me.cmboes会計)
        Me.gbxオーダリング.Controls.Add(Me.cmb前後払い)
        Me.gbxオーダリング.Controls.Add(Me.cmb使用区分)
        Me.gbxオーダリング.Controls.Add(Me.lbl会計済ｲﾝﾀｰﾊﾞﾙ)
        Me.gbxオーダリング.Controls.Add(Me.lbl数量単価変更)
        Me.gbxオーダリング.Controls.Add(Me.lblメニュー集計)
        Me.gbxオーダリング.Controls.Add(Me.lblゼロ円明細)
        Me.gbxオーダリング.Controls.Add(Me.lblOESIPｱﾄﾞﾚｽ)
        Me.gbxオーダリング.Controls.Add(Me.lblOES会計済区分)
        Me.gbxオーダリング.Controls.Add(Me.lbl前払い後払い)
        Me.gbxオーダリング.Controls.Add(Me.lbl使用区分)
        Me.gbxオーダリング.Location = New System.Drawing.Point(14, 450)
        Me.gbxオーダリング.Name = "gbxオーダリング"
        Me.gbxオーダリング.Size = New System.Drawing.Size(400, 206)
        Me.gbxオーダリング.TabIndex = 5
        Me.gbxオーダリング.TabStop = False
        Me.gbxオーダリング.Text = "オーダリング"
        '
        '会計後の利用不可時間
        '
        Me.会計後の利用不可時間.AutoSize = True
        Me.会計後の利用不可時間.Location = New System.Drawing.Point(161, 178)
        Me.会計後の利用不可時間.Name = "会計後の利用不可時間"
        Me.会計後の利用不可時間.Size = New System.Drawing.Size(147, 12)
        Me.会計後の利用不可時間.TabIndex = 16
        Me.会計後の利用不可時間.Text = "会計後の利用不可時間（秒）"
        Me.会計後の利用不可時間.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtOES入力
        '
        Me.txtOES入力.Location = New System.Drawing.Point(100, 94)
        Me.txtOES入力.Name = "txtOES入力"
        Me.txtOES入力.Size = New System.Drawing.Size(129, 19)
        Me.txtOES入力.TabIndex = 15
        '
        'txt会計済入力
        '
        Me.txt会計済入力.Location = New System.Drawing.Point(100, 173)
        Me.txt会計済入力.Name = "txt会計済入力"
        Me.txt会計済入力.Size = New System.Drawing.Size(38, 19)
        Me.txt会計済入力.TabIndex = 14
        '
        'cmb数量単価
        '
        Me.cmb数量単価.FormattingEnabled = True
        Me.cmb数量単価.Items.AddRange(New Object() {"明細の数量・単価の変更は不可", "明細の数量・単価の変更を許可"})
        Me.cmb数量単価.Location = New System.Drawing.Point(100, 153)
        Me.cmb数量単価.Name = "cmb数量単価"
        Me.cmb数量単価.Size = New System.Drawing.Size(280, 20)
        Me.cmb数量単価.TabIndex = 13
        '
        'cmbメニュー集計
        '
        Me.cmbメニュー集計.FormattingEnabled = True
        Me.cmbメニュー集計.Items.AddRange(New Object() {"同一メニューを集計して連携を行う", "同一メニューでも集計しないで連携を行う"})
        Me.cmbメニュー集計.Location = New System.Drawing.Point(100, 133)
        Me.cmbメニュー集計.Name = "cmbメニュー集計"
        Me.cmbメニュー集計.Size = New System.Drawing.Size(280, 20)
        Me.cmbメニュー集計.TabIndex = 12
        '
        'cmbゼロ円明細
        '
        Me.cmbゼロ円明細.FormattingEnabled = True
        Me.cmbゼロ円明細.Items.AddRange(New Object() {"0円明細を取り込む(ｾﾚｸﾄ品等)", "0円明細を取り込まない(ｾﾚｸﾄ品等)"})
        Me.cmbゼロ円明細.Location = New System.Drawing.Point(100, 113)
        Me.cmbゼロ円明細.Name = "cmbゼロ円明細"
        Me.cmbゼロ円明細.Size = New System.Drawing.Size(280, 20)
        Me.cmbゼロ円明細.TabIndex = 11
        '
        'cmboes会計
        '
        Me.cmboes会計.FormattingEnabled = True
        Me.cmboes会計.Items.AddRange(New Object() {"OESへ未会計で送信する", "OESへ会計済で送信する"})
        Me.cmboes会計.Location = New System.Drawing.Point(100, 74)
        Me.cmboes会計.Name = "cmboes会計"
        Me.cmboes会計.Size = New System.Drawing.Size(280, 20)
        Me.cmboes会計.TabIndex = 10
        '
        'cmb前後払い
        '
        Me.cmb前後払い.FormattingEnabled = True
        Me.cmb前後払い.Items.AddRange(New Object() {"前払い", "後払い"})
        Me.cmb前後払い.Location = New System.Drawing.Point(100, 54)
        Me.cmb前後払い.Name = "cmb前後払い"
        Me.cmb前後払い.Size = New System.Drawing.Size(280, 20)
        Me.cmb前後払い.TabIndex = 9
        '
        'cmb使用区分
        '
        Me.cmb使用区分.FormattingEnabled = True
        Me.cmb使用区分.Items.AddRange(New Object() {"オーダリングを使用しない", "オーダリングを使用する", "キッチンプリンタを使用する"})
        Me.cmb使用区分.Location = New System.Drawing.Point(100, 34)
        Me.cmb使用区分.Name = "cmb使用区分"
        Me.cmb使用区分.Size = New System.Drawing.Size(280, 20)
        Me.cmb使用区分.TabIndex = 8
        '
        'lbl会計済ｲﾝﾀｰﾊﾞﾙ
        '
        Me.lbl会計済ｲﾝﾀｰﾊﾞﾙ.Location = New System.Drawing.Point(21, 176)
        Me.lbl会計済ｲﾝﾀｰﾊﾞﾙ.Name = "lbl会計済ｲﾝﾀｰﾊﾞﾙ"
        Me.lbl会計済ｲﾝﾀｰﾊﾞﾙ.Size = New System.Drawing.Size(80, 15)
        Me.lbl会計済ｲﾝﾀｰﾊﾞﾙ.TabIndex = 7
        Me.lbl会計済ｲﾝﾀｰﾊﾞﾙ.Text = "会計済ｲﾝﾀｰﾊﾞﾙ"
        Me.lbl会計済ｲﾝﾀｰﾊﾞﾙ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl数量単価変更
        '
        Me.lbl数量単価変更.Location = New System.Drawing.Point(21, 156)
        Me.lbl数量単価変更.Name = "lbl数量単価変更"
        Me.lbl数量単価変更.Size = New System.Drawing.Size(80, 15)
        Me.lbl数量単価変更.TabIndex = 6
        Me.lbl数量単価変更.Text = "数量・単価変更"
        Me.lbl数量単価変更.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblメニュー集計
        '
        Me.lblメニュー集計.Location = New System.Drawing.Point(21, 136)
        Me.lblメニュー集計.Name = "lblメニュー集計"
        Me.lblメニュー集計.Size = New System.Drawing.Size(80, 15)
        Me.lblメニュー集計.TabIndex = 5
        Me.lblメニュー集計.Text = "メニュー集計"
        Me.lblメニュー集計.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblゼロ円明細
        '
        Me.lblゼロ円明細.Location = New System.Drawing.Point(21, 116)
        Me.lblゼロ円明細.Name = "lblゼロ円明細"
        Me.lblゼロ円明細.Size = New System.Drawing.Size(80, 15)
        Me.lblゼロ円明細.TabIndex = 4
        Me.lblゼロ円明細.Text = "ゼロ円明細"
        Me.lblゼロ円明細.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOESIPｱﾄﾞﾚｽ
        '
        Me.lblOESIPｱﾄﾞﾚｽ.Location = New System.Drawing.Point(21, 97)
        Me.lblOESIPｱﾄﾞﾚｽ.Name = "lblOESIPｱﾄﾞﾚｽ"
        Me.lblOESIPｱﾄﾞﾚｽ.Size = New System.Drawing.Size(80, 15)
        Me.lblOESIPｱﾄﾞﾚｽ.TabIndex = 3
        Me.lblOESIPｱﾄﾞﾚｽ.Text = "OES(IPｱﾄﾞﾚｽ)"
        Me.lblOESIPｱﾄﾞﾚｽ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOES会計済区分
        '
        Me.lblOES会計済区分.Location = New System.Drawing.Point(21, 77)
        Me.lblOES会計済区分.Name = "lblOES会計済区分"
        Me.lblOES会計済区分.Size = New System.Drawing.Size(80, 15)
        Me.lblOES会計済区分.TabIndex = 2
        Me.lblOES会計済区分.Text = "OES会計済区分"
        Me.lblOES会計済区分.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl前払い後払い
        '
        Me.lbl前払い後払い.Location = New System.Drawing.Point(21, 57)
        Me.lbl前払い後払い.Name = "lbl前払い後払い"
        Me.lbl前払い後払い.Size = New System.Drawing.Size(80, 15)
        Me.lbl前払い後払い.TabIndex = 1
        Me.lbl前払い後払い.Text = "前払／後払"
        Me.lbl前払い後払い.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl使用区分
        '
        Me.lbl使用区分.Location = New System.Drawing.Point(18, 37)
        Me.lbl使用区分.Name = "lbl使用区分"
        Me.lbl使用区分.Size = New System.Drawing.Size(80, 15)
        Me.lbl使用区分.TabIndex = 0
        Me.lbl使用区分.Text = "使用区分"
        Me.lbl使用区分.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbx固定スキャナ
        '
        Me.gbx固定スキャナ.Controls.Add(Me.txt接続COMポート入力)
        Me.gbx固定スキャナ.Controls.Add(Me.lbl接続COMポート)
        Me.gbx固定スキャナ.Location = New System.Drawing.Point(450, 12)
        Me.gbx固定スキャナ.Name = "gbx固定スキャナ"
        Me.gbx固定スキャナ.Size = New System.Drawing.Size(263, 37)
        Me.gbx固定スキャナ.TabIndex = 6
        Me.gbx固定スキャナ.TabStop = False
        Me.gbx固定スキャナ.Text = "固定スキャナ"
        '
        'txt接続COMポート入力
        '
        Me.txt接続COMポート入力.Location = New System.Drawing.Point(113, 17)
        Me.txt接続COMポート入力.Name = "txt接続COMポート入力"
        Me.txt接続COMポート入力.Size = New System.Drawing.Size(17, 19)
        Me.txt接続COMポート入力.TabIndex = 1
        '
        'lbl接続COMポート
        '
        Me.lbl接続COMポート.Location = New System.Drawing.Point(14, 21)
        Me.lbl接続COMポート.Name = "lbl接続COMポート"
        Me.lbl接続COMポート.Size = New System.Drawing.Size(82, 15)
        Me.lbl接続COMポート.TabIndex = 0
        Me.lbl接続COMポート.Text = "接続COMポート"
        '
        'gbxカスタマディスプレイ
        '
        Me.gbxカスタマディスプレイ.Controls.Add(Me.txt登録入力)
        Me.gbxカスタマディスプレイ.Controls.Add(Me.txt停止入力)
        Me.gbxカスタマディスプレイ.Controls.Add(Me.lbl登録)
        Me.gbxカスタマディスプレイ.Controls.Add(Me.lbl停止)
        Me.gbxカスタマディスプレイ.Location = New System.Drawing.Point(450, 55)
        Me.gbxカスタマディスプレイ.Name = "gbxカスタマディスプレイ"
        Me.gbxカスタマディスプレイ.Size = New System.Drawing.Size(425, 68)
        Me.gbxカスタマディスプレイ.TabIndex = 7
        Me.gbxカスタマディスプレイ.TabStop = False
        Me.gbxカスタマディスプレイ.Text = "カスタマディスプレイ"
        '
        'txt登録入力
        '
        Me.txt登録入力.Location = New System.Drawing.Point(113, 39)
        Me.txt登録入力.Name = "txt登録入力"
        Me.txt登録入力.Size = New System.Drawing.Size(280, 19)
        Me.txt登録入力.TabIndex = 3
        '
        'txt停止入力
        '
        Me.txt停止入力.Location = New System.Drawing.Point(113, 20)
        Me.txt停止入力.Name = "txt停止入力"
        Me.txt停止入力.Size = New System.Drawing.Size(280, 19)
        Me.txt停止入力.TabIndex = 2
        '
        'lbl登録
        '
        Me.lbl登録.Location = New System.Drawing.Point(31, 42)
        Me.lbl登録.Name = "lbl登録"
        Me.lbl登録.Size = New System.Drawing.Size(80, 15)
        Me.lbl登録.TabIndex = 1
        Me.lbl登録.Text = "登録"
        Me.lbl登録.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl停止
        '
        Me.lbl停止.Location = New System.Drawing.Point(31, 23)
        Me.lbl停止.Name = "lbl停止"
        Me.lbl停止.Size = New System.Drawing.Size(80, 15)
        Me.lbl停止.TabIndex = 0
        Me.lbl停止.Text = "停止"
        Me.lbl停止.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbxINFOX
        '
        Me.gbxINFOX.Controls.Add(Me.cmb支払種別入力)
        Me.gbxINFOX.Controls.Add(Me.txt応答ﾀｲﾑ入力)
        Me.gbxINFOX.Controls.Add(Me.txt接続COMポート2入力)
        Me.gbxINFOX.Controls.Add(Me.txt接続COMポート1入力)
        Me.gbxINFOX.Controls.Add(Me.lbl応答ﾀｲﾑｱｳﾄ秒)
        Me.gbxINFOX.Controls.Add(Me.lbl支払種別入力)
        Me.gbxINFOX.Controls.Add(Me.lbl接続COMポート2)
        Me.gbxINFOX.Controls.Add(Me.lbl接続COMポート1)
        Me.gbxINFOX.Location = New System.Drawing.Point(450, 133)
        Me.gbxINFOX.Name = "gbxINFOX"
        Me.gbxINFOX.Size = New System.Drawing.Size(543, 101)
        Me.gbxINFOX.TabIndex = 8
        Me.gbxINFOX.TabStop = False
        Me.gbxINFOX.Text = "INFOX"
        '
        'cmb支払種別入力
        '
        Me.cmb支払種別入力.FormattingEnabled = True
        Me.cmb支払種別入力.Items.AddRange(New Object() {"支払い種別の入力を行う", "支払い種別の入力を行わない"})
        Me.cmb支払種別入力.Location = New System.Drawing.Point(114, 44)
        Me.cmb支払種別入力.Name = "cmb支払種別入力"
        Me.cmb支払種別入力.Size = New System.Drawing.Size(199, 20)
        Me.cmb支払種別入力.TabIndex = 8
        '
        'txt応答ﾀｲﾑ入力
        '
        Me.txt応答ﾀｲﾑ入力.Location = New System.Drawing.Point(114, 65)
        Me.txt応答ﾀｲﾑ入力.Name = "txt応答ﾀｲﾑ入力"
        Me.txt応答ﾀｲﾑ入力.Size = New System.Drawing.Size(31, 19)
        Me.txt応答ﾀｲﾑ入力.TabIndex = 7
        '
        'txt接続COMポート2入力
        '
        Me.txt接続COMポート2入力.Location = New System.Drawing.Point(282, 24)
        Me.txt接続COMポート2入力.Name = "txt接続COMポート2入力"
        Me.txt接続COMポート2入力.Size = New System.Drawing.Size(31, 19)
        Me.txt接続COMポート2入力.TabIndex = 6
        '
        'txt接続COMポート1入力
        '
        Me.txt接続COMポート1入力.Location = New System.Drawing.Point(114, 24)
        Me.txt接続COMポート1入力.Name = "txt接続COMポート1入力"
        Me.txt接続COMポート1入力.Size = New System.Drawing.Size(31, 19)
        Me.txt接続COMポート1入力.TabIndex = 5
        '
        'lbl応答ﾀｲﾑｱｳﾄ秒
        '
        Me.lbl応答ﾀｲﾑｱｳﾄ秒.Location = New System.Drawing.Point(14, 67)
        Me.lbl応答ﾀｲﾑｱｳﾄ秒.Name = "lbl応答ﾀｲﾑｱｳﾄ秒"
        Me.lbl応答ﾀｲﾑｱｳﾄ秒.Size = New System.Drawing.Size(100, 15)
        Me.lbl応答ﾀｲﾑｱｳﾄ秒.TabIndex = 4
        Me.lbl応答ﾀｲﾑｱｳﾄ秒.Text = "応答ﾀｲﾑｱｳﾄ（秒）"
        Me.lbl応答ﾀｲﾑｱｳﾄ秒.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl支払種別入力
        '
        Me.lbl支払種別入力.Location = New System.Drawing.Point(14, 46)
        Me.lbl支払種別入力.Name = "lbl支払種別入力"
        Me.lbl支払種別入力.Size = New System.Drawing.Size(100, 15)
        Me.lbl支払種別入力.TabIndex = 3
        Me.lbl支払種別入力.Text = "支払種別入力"
        Me.lbl支払種別入力.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl接続COMポート2
        '
        Me.lbl接続COMポート2.Location = New System.Drawing.Point(163, 25)
        Me.lbl接続COMポート2.Name = "lbl接続COMポート2"
        Me.lbl接続COMポート2.Size = New System.Drawing.Size(100, 15)
        Me.lbl接続COMポート2.TabIndex = 2
        Me.lbl接続COMポート2.Text = "接続COMポート2"
        Me.lbl接続COMポート2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl接続COMポート1
        '
        Me.lbl接続COMポート1.Location = New System.Drawing.Point(14, 25)
        Me.lbl接続COMポート1.Name = "lbl接続COMポート1"
        Me.lbl接続COMポート1.Size = New System.Drawing.Size(100, 15)
        Me.lbl接続COMポート1.TabIndex = 1
        Me.lbl接続COMポート1.Text = "接続COMポート1"
        Me.lbl接続COMポート1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbx背面ディスプレイ
        '
        Me.gbx背面ディスプレイ.Controls.Add(Me.txt会計挨拶入力1)
        Me.gbx背面ディスプレイ.Controls.Add(Me.txt会計挨拶入力2)
        Me.gbx背面ディスプレイ.Controls.Add(Me.txt会計挨拶入力3)
        Me.gbx背面ディスプレイ.Controls.Add(Me.txt会計挨拶入力4)
        Me.gbx背面ディスプレイ.Controls.Add(Me.txt宣伝文入力2)
        Me.gbx背面ディスプレイ.Controls.Add(Me.txt宣伝文入力3)
        Me.gbx背面ディスプレイ.Controls.Add(Me.txt宣伝文入力4)
        Me.gbx背面ディスプレイ.Controls.Add(Me.txt宣伝文入力1)
        Me.gbx背面ディスプレイ.Controls.Add(Me.btn_画像ﾌｧｲﾙ10)
        Me.gbx背面ディスプレイ.Controls.Add(Me.btn_画像ﾌｧｲﾙ2)
        Me.gbx背面ディスプレイ.Controls.Add(Me.btn_画像ﾌｧｲﾙ3)
        Me.gbx背面ディスプレイ.Controls.Add(Me.btn_画像ﾌｧｲﾙ4)
        Me.gbx背面ディスプレイ.Controls.Add(Me.btn_画像ﾌｧｲﾙ5)
        Me.gbx背面ディスプレイ.Controls.Add(Me.btn_画像ﾌｧｲﾙ6)
        Me.gbx背面ディスプレイ.Controls.Add(Me.btn_画像ﾌｧｲﾙ7)
        Me.gbx背面ディスプレイ.Controls.Add(Me.btn_画像ﾌｧｲﾙ8)
        Me.gbx背面ディスプレイ.Controls.Add(Me.btn_画像ﾌｧｲﾙ9)
        Me.gbx背面ディスプレイ.Controls.Add(Me.btn_画像ﾌｧｲﾙ1)
        Me.gbx背面ディスプレイ.Controls.Add(Me.txt画像ﾌｧｲﾙ10)
        Me.gbx背面ディスプレイ.Controls.Add(Me.txt画像ﾌｧｲﾙ9)
        Me.gbx背面ディスプレイ.Controls.Add(Me.txt画像ﾌｧｲﾙ8)
        Me.gbx背面ディスプレイ.Controls.Add(Me.txt画像ﾌｧｲﾙ7)
        Me.gbx背面ディスプレイ.Controls.Add(Me.txt画像ﾌｧｲﾙ6)
        Me.gbx背面ディスプレイ.Controls.Add(Me.txt画像ﾌｧｲﾙ5)
        Me.gbx背面ディスプレイ.Controls.Add(Me.txt画像ﾌｧｲﾙ4)
        Me.gbx背面ディスプレイ.Controls.Add(Me.txt画像ﾌｧｲﾙ3)
        Me.gbx背面ディスプレイ.Controls.Add(Me.txt画像ﾌｧｲﾙ2)
        Me.gbx背面ディスプレイ.Controls.Add(Me.txt画像ﾌｧｲﾙ1)
        Me.gbx背面ディスプレイ.Controls.Add(Me.txt切替ﾀｲﾏｰ)
        Me.gbx背面ディスプレイ.Controls.Add(Me.lbl会計挨拶)
        Me.gbx背面ディスプレイ.Controls.Add(Me.lbl宣伝文)
        Me.gbx背面ディスプレイ.Controls.Add(Me.lbl画像ﾌｧｲﾙ)
        Me.gbx背面ディスプレイ.Controls.Add(Me.lbl切替ﾀｲﾏｰ秒)
        Me.gbx背面ディスプレイ.Location = New System.Drawing.Point(450, 240)
        Me.gbx背面ディスプレイ.Name = "gbx背面ディスプレイ"
        Me.gbx背面ディスプレイ.Size = New System.Drawing.Size(546, 413)
        Me.gbx背面ディスプレイ.TabIndex = 9
        Me.gbx背面ディスプレイ.TabStop = False
        Me.gbx背面ディスプレイ.Text = "背面ディスプレイ"
        '
        'txt会計挨拶入力1
        '
        Me.txt会計挨拶入力1.Location = New System.Drawing.Point(113, 297)
        Me.txt会計挨拶入力1.Name = "txt会計挨拶入力1"
        Me.txt会計挨拶入力1.Size = New System.Drawing.Size(200, 19)
        Me.txt会計挨拶入力1.TabIndex = 33
        '
        'txt会計挨拶入力2
        '
        Me.txt会計挨拶入力2.Location = New System.Drawing.Point(113, 315)
        Me.txt会計挨拶入力2.Name = "txt会計挨拶入力2"
        Me.txt会計挨拶入力2.Size = New System.Drawing.Size(200, 19)
        Me.txt会計挨拶入力2.TabIndex = 32
        '
        'txt会計挨拶入力3
        '
        Me.txt会計挨拶入力3.Location = New System.Drawing.Point(113, 333)
        Me.txt会計挨拶入力3.Name = "txt会計挨拶入力3"
        Me.txt会計挨拶入力3.Size = New System.Drawing.Size(200, 19)
        Me.txt会計挨拶入力3.TabIndex = 31
        '
        'txt会計挨拶入力4
        '
        Me.txt会計挨拶入力4.Location = New System.Drawing.Point(113, 351)
        Me.txt会計挨拶入力4.Name = "txt会計挨拶入力4"
        Me.txt会計挨拶入力4.Size = New System.Drawing.Size(200, 19)
        Me.txt会計挨拶入力4.TabIndex = 30
        '
        'txt宣伝文入力2
        '
        Me.txt宣伝文入力2.Location = New System.Drawing.Point(113, 241)
        Me.txt宣伝文入力2.Name = "txt宣伝文入力2"
        Me.txt宣伝文入力2.Size = New System.Drawing.Size(200, 19)
        Me.txt宣伝文入力2.TabIndex = 29
        '
        'txt宣伝文入力3
        '
        Me.txt宣伝文入力3.Location = New System.Drawing.Point(113, 259)
        Me.txt宣伝文入力3.Name = "txt宣伝文入力3"
        Me.txt宣伝文入力3.Size = New System.Drawing.Size(200, 19)
        Me.txt宣伝文入力3.TabIndex = 28
        '
        'txt宣伝文入力4
        '
        Me.txt宣伝文入力4.Location = New System.Drawing.Point(113, 277)
        Me.txt宣伝文入力4.Name = "txt宣伝文入力4"
        Me.txt宣伝文入力4.Size = New System.Drawing.Size(200, 19)
        Me.txt宣伝文入力4.TabIndex = 27
        '
        'txt宣伝文入力1
        '
        Me.txt宣伝文入力1.Location = New System.Drawing.Point(113, 223)
        Me.txt宣伝文入力1.Name = "txt宣伝文入力1"
        Me.txt宣伝文入力1.Size = New System.Drawing.Size(200, 19)
        Me.txt宣伝文入力1.TabIndex = 26
        '
        'btn_画像ﾌｧｲﾙ10
        '
        Me.btn_画像ﾌｧｲﾙ10.Location = New System.Drawing.Point(493, 203)
        Me.btn_画像ﾌｧｲﾙ10.Name = "btn_画像ﾌｧｲﾙ10"
        Me.btn_画像ﾌｧｲﾙ10.Size = New System.Drawing.Size(50, 19)
        Me.btn_画像ﾌｧｲﾙ10.TabIndex = 25
        Me.btn_画像ﾌｧｲﾙ10.Text = "参照"
        Me.btn_画像ﾌｧｲﾙ10.UseVisualStyleBackColor = True
        '
        'btn_画像ﾌｧｲﾙ2
        '
        Me.btn_画像ﾌｧｲﾙ2.Location = New System.Drawing.Point(493, 64)
        Me.btn_画像ﾌｧｲﾙ2.Name = "btn_画像ﾌｧｲﾙ2"
        Me.btn_画像ﾌｧｲﾙ2.Size = New System.Drawing.Size(50, 19)
        Me.btn_画像ﾌｧｲﾙ2.TabIndex = 24
        Me.btn_画像ﾌｧｲﾙ2.Text = "参照"
        Me.btn_画像ﾌｧｲﾙ2.UseVisualStyleBackColor = True
        '
        'btn_画像ﾌｧｲﾙ3
        '
        Me.btn_画像ﾌｧｲﾙ3.Location = New System.Drawing.Point(493, 82)
        Me.btn_画像ﾌｧｲﾙ3.Name = "btn_画像ﾌｧｲﾙ3"
        Me.btn_画像ﾌｧｲﾙ3.Size = New System.Drawing.Size(50, 19)
        Me.btn_画像ﾌｧｲﾙ3.TabIndex = 23
        Me.btn_画像ﾌｧｲﾙ3.Text = "参照"
        Me.btn_画像ﾌｧｲﾙ3.UseVisualStyleBackColor = True
        '
        'btn_画像ﾌｧｲﾙ4
        '
        Me.btn_画像ﾌｧｲﾙ4.Location = New System.Drawing.Point(493, 100)
        Me.btn_画像ﾌｧｲﾙ4.Name = "btn_画像ﾌｧｲﾙ4"
        Me.btn_画像ﾌｧｲﾙ4.Size = New System.Drawing.Size(50, 19)
        Me.btn_画像ﾌｧｲﾙ4.TabIndex = 22
        Me.btn_画像ﾌｧｲﾙ4.Text = "参照"
        Me.btn_画像ﾌｧｲﾙ4.UseVisualStyleBackColor = True
        '
        'btn_画像ﾌｧｲﾙ5
        '
        Me.btn_画像ﾌｧｲﾙ5.Location = New System.Drawing.Point(493, 118)
        Me.btn_画像ﾌｧｲﾙ5.Name = "btn_画像ﾌｧｲﾙ5"
        Me.btn_画像ﾌｧｲﾙ5.Size = New System.Drawing.Size(50, 19)
        Me.btn_画像ﾌｧｲﾙ5.TabIndex = 21
        Me.btn_画像ﾌｧｲﾙ5.Text = "参照"
        Me.btn_画像ﾌｧｲﾙ5.UseVisualStyleBackColor = True
        '
        'btn_画像ﾌｧｲﾙ6
        '
        Me.btn_画像ﾌｧｲﾙ6.Location = New System.Drawing.Point(493, 134)
        Me.btn_画像ﾌｧｲﾙ6.Name = "btn_画像ﾌｧｲﾙ6"
        Me.btn_画像ﾌｧｲﾙ6.Size = New System.Drawing.Size(50, 19)
        Me.btn_画像ﾌｧｲﾙ6.TabIndex = 20
        Me.btn_画像ﾌｧｲﾙ6.Text = "参照"
        Me.btn_画像ﾌｧｲﾙ6.UseVisualStyleBackColor = True
        '
        'btn_画像ﾌｧｲﾙ7
        '
        Me.btn_画像ﾌｧｲﾙ7.Location = New System.Drawing.Point(493, 149)
        Me.btn_画像ﾌｧｲﾙ7.Name = "btn_画像ﾌｧｲﾙ7"
        Me.btn_画像ﾌｧｲﾙ7.Size = New System.Drawing.Size(50, 19)
        Me.btn_画像ﾌｧｲﾙ7.TabIndex = 18
        Me.btn_画像ﾌｧｲﾙ7.Text = "参照"
        Me.btn_画像ﾌｧｲﾙ7.UseVisualStyleBackColor = True
        '
        'btn_画像ﾌｧｲﾙ8
        '
        Me.btn_画像ﾌｧｲﾙ8.Location = New System.Drawing.Point(493, 167)
        Me.btn_画像ﾌｧｲﾙ8.Name = "btn_画像ﾌｧｲﾙ8"
        Me.btn_画像ﾌｧｲﾙ8.Size = New System.Drawing.Size(50, 19)
        Me.btn_画像ﾌｧｲﾙ8.TabIndex = 17
        Me.btn_画像ﾌｧｲﾙ8.Text = "参照"
        Me.btn_画像ﾌｧｲﾙ8.UseVisualStyleBackColor = True
        '
        'btn_画像ﾌｧｲﾙ9
        '
        Me.btn_画像ﾌｧｲﾙ9.Location = New System.Drawing.Point(493, 185)
        Me.btn_画像ﾌｧｲﾙ9.Name = "btn_画像ﾌｧｲﾙ9"
        Me.btn_画像ﾌｧｲﾙ9.Size = New System.Drawing.Size(50, 19)
        Me.btn_画像ﾌｧｲﾙ9.TabIndex = 16
        Me.btn_画像ﾌｧｲﾙ9.Text = "参照"
        Me.btn_画像ﾌｧｲﾙ9.UseVisualStyleBackColor = True
        '
        'btn_画像ﾌｧｲﾙ1
        '
        Me.btn_画像ﾌｧｲﾙ1.Location = New System.Drawing.Point(493, 46)
        Me.btn_画像ﾌｧｲﾙ1.Name = "btn_画像ﾌｧｲﾙ1"
        Me.btn_画像ﾌｧｲﾙ1.Size = New System.Drawing.Size(50, 19)
        Me.btn_画像ﾌｧｲﾙ1.TabIndex = 15
        Me.btn_画像ﾌｧｲﾙ1.Text = "参照"
        Me.btn_画像ﾌｧｲﾙ1.UseVisualStyleBackColor = True
        '
        'txt画像ﾌｧｲﾙ10
        '
        Me.txt画像ﾌｧｲﾙ10.Location = New System.Drawing.Point(113, 203)
        Me.txt画像ﾌｧｲﾙ10.Name = "txt画像ﾌｧｲﾙ10"
        Me.txt画像ﾌｧｲﾙ10.Size = New System.Drawing.Size(380, 19)
        Me.txt画像ﾌｧｲﾙ10.TabIndex = 14
        '
        'txt画像ﾌｧｲﾙ9
        '
        Me.txt画像ﾌｧｲﾙ9.Location = New System.Drawing.Point(113, 185)
        Me.txt画像ﾌｧｲﾙ9.Name = "txt画像ﾌｧｲﾙ9"
        Me.txt画像ﾌｧｲﾙ9.Size = New System.Drawing.Size(380, 19)
        Me.txt画像ﾌｧｲﾙ9.TabIndex = 13
        '
        'txt画像ﾌｧｲﾙ8
        '
        Me.txt画像ﾌｧｲﾙ8.Location = New System.Drawing.Point(113, 167)
        Me.txt画像ﾌｧｲﾙ8.Name = "txt画像ﾌｧｲﾙ8"
        Me.txt画像ﾌｧｲﾙ8.Size = New System.Drawing.Size(380, 19)
        Me.txt画像ﾌｧｲﾙ8.TabIndex = 12
        '
        'txt画像ﾌｧｲﾙ7
        '
        Me.txt画像ﾌｧｲﾙ7.Location = New System.Drawing.Point(113, 149)
        Me.txt画像ﾌｧｲﾙ7.Name = "txt画像ﾌｧｲﾙ7"
        Me.txt画像ﾌｧｲﾙ7.Size = New System.Drawing.Size(380, 19)
        Me.txt画像ﾌｧｲﾙ7.TabIndex = 11
        '
        'txt画像ﾌｧｲﾙ6
        '
        Me.txt画像ﾌｧｲﾙ6.Location = New System.Drawing.Point(113, 134)
        Me.txt画像ﾌｧｲﾙ6.Name = "txt画像ﾌｧｲﾙ6"
        Me.txt画像ﾌｧｲﾙ6.Size = New System.Drawing.Size(380, 19)
        Me.txt画像ﾌｧｲﾙ6.TabIndex = 10
        '
        'txt画像ﾌｧｲﾙ5
        '
        Me.txt画像ﾌｧｲﾙ5.Location = New System.Drawing.Point(113, 118)
        Me.txt画像ﾌｧｲﾙ5.Name = "txt画像ﾌｧｲﾙ5"
        Me.txt画像ﾌｧｲﾙ5.Size = New System.Drawing.Size(380, 19)
        Me.txt画像ﾌｧｲﾙ5.TabIndex = 9
        '
        'txt画像ﾌｧｲﾙ4
        '
        Me.txt画像ﾌｧｲﾙ4.Location = New System.Drawing.Point(113, 100)
        Me.txt画像ﾌｧｲﾙ4.Name = "txt画像ﾌｧｲﾙ4"
        Me.txt画像ﾌｧｲﾙ4.Size = New System.Drawing.Size(380, 19)
        Me.txt画像ﾌｧｲﾙ4.TabIndex = 8
        '
        'txt画像ﾌｧｲﾙ3
        '
        Me.txt画像ﾌｧｲﾙ3.Location = New System.Drawing.Point(113, 82)
        Me.txt画像ﾌｧｲﾙ3.Name = "txt画像ﾌｧｲﾙ3"
        Me.txt画像ﾌｧｲﾙ3.Size = New System.Drawing.Size(380, 19)
        Me.txt画像ﾌｧｲﾙ3.TabIndex = 7
        '
        'txt画像ﾌｧｲﾙ2
        '
        Me.txt画像ﾌｧｲﾙ2.Location = New System.Drawing.Point(113, 64)
        Me.txt画像ﾌｧｲﾙ2.Name = "txt画像ﾌｧｲﾙ2"
        Me.txt画像ﾌｧｲﾙ2.Size = New System.Drawing.Size(380, 19)
        Me.txt画像ﾌｧｲﾙ2.TabIndex = 6
        '
        'txt画像ﾌｧｲﾙ1
        '
        Me.txt画像ﾌｧｲﾙ1.Location = New System.Drawing.Point(113, 46)
        Me.txt画像ﾌｧｲﾙ1.Name = "txt画像ﾌｧｲﾙ1"
        Me.txt画像ﾌｧｲﾙ1.Size = New System.Drawing.Size(380, 19)
        Me.txt画像ﾌｧｲﾙ1.TabIndex = 5
        '
        'txt切替ﾀｲﾏｰ
        '
        Me.txt切替ﾀｲﾏｰ.Location = New System.Drawing.Point(113, 27)
        Me.txt切替ﾀｲﾏｰ.Name = "txt切替ﾀｲﾏｰ"
        Me.txt切替ﾀｲﾏｰ.Size = New System.Drawing.Size(25, 19)
        Me.txt切替ﾀｲﾏｰ.TabIndex = 4
        '
        'lbl会計挨拶
        '
        Me.lbl会計挨拶.Location = New System.Drawing.Point(12, 300)
        Me.lbl会計挨拶.Name = "lbl会計挨拶"
        Me.lbl会計挨拶.Size = New System.Drawing.Size(100, 70)
        Me.lbl会計挨拶.TabIndex = 3
        Me.lbl会計挨拶.Text = "会計挨拶" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(全角12文字)"
        Me.lbl会計挨拶.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl宣伝文
        '
        Me.lbl宣伝文.Location = New System.Drawing.Point(10, 226)
        Me.lbl宣伝文.Name = "lbl宣伝文"
        Me.lbl宣伝文.Size = New System.Drawing.Size(102, 70)
        Me.lbl宣伝文.TabIndex = 2
        Me.lbl宣伝文.Text = "宣伝文" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(全角12文字)"
        Me.lbl宣伝文.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl画像ﾌｧｲﾙ
        '
        Me.lbl画像ﾌｧｲﾙ.Location = New System.Drawing.Point(11, 53)
        Me.lbl画像ﾌｧｲﾙ.Name = "lbl画像ﾌｧｲﾙ"
        Me.lbl画像ﾌｧｲﾙ.Size = New System.Drawing.Size(100, 172)
        Me.lbl画像ﾌｧｲﾙ.TabIndex = 1
        Me.lbl画像ﾌｧｲﾙ.Text = "画像ﾌｧｲﾙ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(ﾌﾙﾊﾟｽ)"
        Me.lbl画像ﾌｧｲﾙ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl切替ﾀｲﾏｰ秒
        '
        Me.lbl切替ﾀｲﾏｰ秒.Location = New System.Drawing.Point(12, 30)
        Me.lbl切替ﾀｲﾏｰ秒.Name = "lbl切替ﾀｲﾏｰ秒"
        Me.lbl切替ﾀｲﾏｰ秒.Size = New System.Drawing.Size(100, 15)
        Me.lbl切替ﾀｲﾏｰ秒.TabIndex = 0
        Me.lbl切替ﾀｲﾏｰ秒.Text = "切替ﾀｲﾏｰ（秒）"
        Me.lbl切替ﾀｲﾏｰ秒.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm806端末情報登録
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.gbx背面ディスプレイ)
        Me.Controls.Add(Me.gbxINFOX)
        Me.Controls.Add(Me.gbxカスタマディスプレイ)
        Me.Controls.Add(Me.gbx固定スキャナ)
        Me.Controls.Add(Me.gbxオーダリング)
        Me.Controls.Add(Me.gbx端末情報設定)
        Me.Controls.Add(Me.gbx基本情報)
        Me.Controls.Add(Me.btn終了)
        Me.Controls.Add(Me.gbx食券発行)
        Me.Controls.Add(Me.btn更新)
        Me.Name = "frm806端末情報登録"
        Me.Text = "端末情報登録"
        Me.gbx基本情報.ResumeLayout(False)
        Me.gbx基本情報.PerformLayout()
        Me.gbx端末情報設定.ResumeLayout(False)
        Me.gbx食券発行.ResumeLayout(False)
        Me.gbx食券発行.PerformLayout()
        Me.gbxオーダリング.ResumeLayout(False)
        Me.gbxオーダリング.PerformLayout()
        Me.gbx固定スキャナ.ResumeLayout(False)
        Me.gbx固定スキャナ.PerformLayout()
        Me.gbxカスタマディスプレイ.ResumeLayout(False)
        Me.gbxカスタマディスプレイ.PerformLayout()
        Me.gbxINFOX.ResumeLayout(False)
        Me.gbxINFOX.PerformLayout()
        Me.gbx背面ディスプレイ.ResumeLayout(False)
        Me.gbx背面ディスプレイ.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn更新 As Button
    Friend WithEvents btn終了 As Button
    Friend WithEvents gbx基本情報 As GroupBox
    Friend WithEvents lblボタン効果音 As Label
    Friend WithEvents lbl管理名称 As Label
    Friend WithEvents lbl端末CD As Label
    Friend WithEvents gbx端末情報設定 As GroupBox
    Friend WithEvents gbx食券発行 As GroupBox
    Friend WithEvents gbxオーダリング As GroupBox
    Friend WithEvents gbx固定スキャナ As GroupBox
    Friend WithEvents gbxカスタマディスプレイ As GroupBox
    Friend WithEvents gbxINFOX As GroupBox
    Friend WithEvents gbx背面ディスプレイ As GroupBox
    Friend WithEvents lbl天候入力 As Label
    Friend WithEvents lbl業態店舗CD As Label
    Friend WithEvents txt業態店舗CD入力 As TextBox
    Friend WithEvents txt端末CD入力 As TextBox
    Friend WithEvents cmb天候入力 As ComboBox
    Friend WithEvents cmbボタン効果音 As ComboBox
    Friend WithEvents txt管理名称 As TextBox
    Friend WithEvents cmb拡張キーボード As ComboBox
    Friend WithEvents lbl拡張キーボード As Label
    Friend WithEvents cmbﾊﾞｰｺｰﾄﾞﾘｰﾀﾞｰ As ComboBox
    Friend WithEvents cmb背面ﾃﾞｨｽﾌﾟﾚｲ As ComboBox
    Friend WithEvents cmbｶｽﾀﾏﾃﾞｨｽﾌﾟﾚｲ As ComboBox
    Friend WithEvents cmbつり銭機 As ComboBox
    Friend WithEvents cmbｷｬｼｭﾄﾞﾛｱ As ComboBox
    Friend WithEvents cmbカード決済端末 As ComboBox
    Friend WithEvents lblﾊﾞｰｺｰﾄﾞﾘｰﾀﾞｰ As Label
    Friend WithEvents lbl背面ﾃﾞｨｽﾌﾟﾚｲ As Label
    Friend WithEvents lblｶｽﾀﾏﾃﾞｨｽﾌﾟﾚｲ As Label
    Friend WithEvents lblつり銭機 As Label
    Friend WithEvents lblｷｬｼｭﾄﾞﾛｱ As Label
    Friend WithEvents lblカード決済端末 As Label
    Friend WithEvents cmb控発行 As ComboBox
    Friend WithEvents cmbカット As ComboBox
    Friend WithEvents txt印字記号 As TextBox
    Friend WithEvents lbl控発行 As Label
    Friend WithEvents lblカット As Label
    Friend WithEvents lbl印字記号 As Label
    Friend WithEvents txtOES入力 As TextBox
    Friend WithEvents txt会計済入力 As TextBox
    Friend WithEvents cmb数量単価 As ComboBox
    Friend WithEvents cmbメニュー集計 As ComboBox
    Friend WithEvents cmbゼロ円明細 As ComboBox
    Friend WithEvents cmboes会計 As ComboBox
    Friend WithEvents cmb前後払い As ComboBox
    Friend WithEvents cmb使用区分 As ComboBox
    Friend WithEvents lbl会計済ｲﾝﾀｰﾊﾞﾙ As Label
    Friend WithEvents lbl数量単価変更 As Label
    Friend WithEvents lblメニュー集計 As Label
    Friend WithEvents lblゼロ円明細 As Label
    Friend WithEvents lblOESIPｱﾄﾞﾚｽ As Label
    Friend WithEvents lblOES会計済区分 As Label
    Friend WithEvents lbl前払い後払い As Label
    Friend WithEvents lbl使用区分 As Label
    Friend WithEvents 会計後の利用不可時間 As Label
    Friend WithEvents txt接続COMポート入力 As TextBox
    Friend WithEvents lbl接続COMポート As Label
    Friend WithEvents txt登録入力 As TextBox
    Friend WithEvents txt停止入力 As TextBox
    Friend WithEvents lbl登録 As Label
    Friend WithEvents lbl停止 As Label
    Friend WithEvents lbl応答ﾀｲﾑｱｳﾄ秒 As Label
    Friend WithEvents lbl支払種別入力 As Label
    Friend WithEvents lbl接続COMポート2 As Label
    Friend WithEvents lbl接続COMポート1 As Label
    Friend WithEvents cmb支払種別入力 As ComboBox
    Friend WithEvents txt応答ﾀｲﾑ入力 As TextBox
    Friend WithEvents txt接続COMポート2入力 As TextBox
    Friend WithEvents txt接続COMポート1入力 As TextBox
    Friend WithEvents lbl会計挨拶 As Label
    Friend WithEvents lbl宣伝文 As Label
    Friend WithEvents lbl画像ﾌｧｲﾙ As Label
    Friend WithEvents lbl切替ﾀｲﾏｰ秒 As Label
    Friend WithEvents txt会計挨拶入力1 As TextBox
    Friend WithEvents txt会計挨拶入力2 As TextBox
    Friend WithEvents txt会計挨拶入力3 As TextBox
    Friend WithEvents txt会計挨拶入力4 As TextBox
    Friend WithEvents txt宣伝文入力2 As TextBox
    Friend WithEvents txt宣伝文入力3 As TextBox
    Friend WithEvents txt宣伝文入力4 As TextBox
    Friend WithEvents txt宣伝文入力1 As TextBox
    Friend WithEvents btn_画像ﾌｧｲﾙ10 As Button
    Friend WithEvents btn_画像ﾌｧｲﾙ2 As Button
    Friend WithEvents btn_画像ﾌｧｲﾙ3 As Button
    Friend WithEvents btn_画像ﾌｧｲﾙ4 As Button
    Friend WithEvents btn_画像ﾌｧｲﾙ5 As Button
    Friend WithEvents btn_画像ﾌｧｲﾙ6 As Button
    Friend WithEvents btn_画像ﾌｧｲﾙ7 As Button
    Friend WithEvents btn_画像ﾌｧｲﾙ8 As Button
    Friend WithEvents btn_画像ﾌｧｲﾙ9 As Button
    Friend WithEvents btn_画像ﾌｧｲﾙ1 As Button
    Friend WithEvents txt画像ﾌｧｲﾙ10 As TextBox
    Friend WithEvents txt画像ﾌｧｲﾙ9 As TextBox
    Friend WithEvents txt画像ﾌｧｲﾙ8 As TextBox
    Friend WithEvents txt画像ﾌｧｲﾙ7 As TextBox
    Friend WithEvents txt画像ﾌｧｲﾙ6 As TextBox
    Friend WithEvents txt画像ﾌｧｲﾙ5 As TextBox
    Friend WithEvents txt画像ﾌｧｲﾙ4 As TextBox
    Friend WithEvents txt画像ﾌｧｲﾙ3 As TextBox
    Friend WithEvents txt画像ﾌｧｲﾙ2 As TextBox
    Friend WithEvents txt画像ﾌｧｲﾙ1 As TextBox
    Friend WithEvents txt切替ﾀｲﾏｰ As TextBox
End Class
