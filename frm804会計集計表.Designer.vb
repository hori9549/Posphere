<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm精算処理
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
        Me.cmb計上日付 = New System.Windows.Forms.ComboBox()
        Me.lblから = New System.Windows.Forms.Label()
        Me.btn集計 = New System.Windows.Forms.Button()
        Me.btnレシート印刷 = New System.Windows.Forms.Button()
        Me.btnエクスポート = New System.Windows.Forms.Button()
        Me.btn終了 = New System.Windows.Forms.Button()
        Me.lbl会計集計表 = New System.Windows.Forms.Label()
        Me.lbl釣銭準備金 = New System.Windows.Forms.Label()
        Me.lbl現金預かり = New System.Windows.Forms.Label()
        Me.lbl釣銭支払い = New System.Windows.Forms.Label()
        Me.lbl入金 = New System.Windows.Forms.Label()
        Me.lbl釣銭回収 = New System.Windows.Forms.Label()
        Me.lbl出金 = New System.Windows.Forms.Label()
        Me.lbl現金有り高 = New System.Windows.Forms.Label()
        Me.lbl現計 = New System.Windows.Forms.Label()
        Me.lbl信計1 = New System.Windows.Forms.Label()
        Me.lbl信計2 = New System.Windows.Forms.Label()
        Me.lbl信計3 = New System.Windows.Forms.Label()
        Me.lbl信計4 = New System.Windows.Forms.Label()
        Me.lblⅡ計釣有 = New System.Windows.Forms.Label()
        Me.lblⅡ計釣無 = New System.Windows.Forms.Label()
        Me.lblⅡ計クーポン = New System.Windows.Forms.Label()
        Me.lbl内消費税 = New System.Windows.Forms.Label()
        Me.lbl内軽減消費税 = New System.Windows.Forms.Label()
        Me.lbl外消費税 = New System.Windows.Forms.Label()
        Me.lbl外軽減消費税 = New System.Windows.Forms.Label()
        Me.lbl税抜売上額 = New System.Windows.Forms.Label()
        Me.lbl貸計 = New System.Windows.Forms.Label()
        Me.lbl現金外計 = New System.Windows.Forms.Label()
        Me.lbl過不足金 = New System.Windows.Forms.Label()
        Me.lbl純売上額 = New System.Windows.Forms.Label()
        Me.lbl雑収入 = New System.Windows.Forms.Label()
        Me.txt釣銭支払い_件数 = New System.Windows.Forms.TextBox()
        Me.txt現金預かり_件数 = New System.Windows.Forms.TextBox()
        Me.txt釣銭準備金_件数 = New System.Windows.Forms.TextBox()
        Me.txt現金有り高 = New System.Windows.Forms.TextBox()
        Me.txt現計_件数 = New System.Windows.Forms.TextBox()
        Me.txt信計1_件数 = New System.Windows.Forms.TextBox()
        Me.txt入金_件数 = New System.Windows.Forms.TextBox()
        Me.txt釣銭回収_件数 = New System.Windows.Forms.TextBox()
        Me.txt出金_件数 = New System.Windows.Forms.TextBox()
        Me.txtII計釣有_件数 = New System.Windows.Forms.TextBox()
        Me.txtII計釣無_件数 = New System.Windows.Forms.TextBox()
        Me.txtII計クーポン_件数 = New System.Windows.Forms.TextBox()
        Me.txt信計2_件数 = New System.Windows.Forms.TextBox()
        Me.txt信計3_件数 = New System.Windows.Forms.TextBox()
        Me.txt信計4_件数 = New System.Windows.Forms.TextBox()
        Me.txt貸計_件数 = New System.Windows.Forms.TextBox()
        Me.txt現金外計 = New System.Windows.Forms.TextBox()
        Me.txt過不足金 = New System.Windows.Forms.TextBox()
        Me.txt純売上額 = New System.Windows.Forms.TextBox()
        Me.txt雑収入 = New System.Windows.Forms.TextBox()
        Me.txt内消費税 = New System.Windows.Forms.TextBox()
        Me.txt内軽減消費税 = New System.Windows.Forms.TextBox()
        Me.txt外消費税 = New System.Windows.Forms.TextBox()
        Me.txt外軽減消費税 = New System.Windows.Forms.TextBox()
        Me.txt税抜売上額 = New System.Windows.Forms.TextBox()
        Me.txt釣銭準備金_金額 = New System.Windows.Forms.TextBox()
        Me.txt現金預かり_金額 = New System.Windows.Forms.TextBox()
        Me.txt釣銭支払い_金額 = New System.Windows.Forms.TextBox()
        Me.txt入金_金額 = New System.Windows.Forms.TextBox()
        Me.txt釣銭回収_金額 = New System.Windows.Forms.TextBox()
        Me.txt出金_金額 = New System.Windows.Forms.TextBox()
        Me.txt現計_金額 = New System.Windows.Forms.TextBox()
        Me.txt信計1_金額 = New System.Windows.Forms.TextBox()
        Me.txt信計2_金額 = New System.Windows.Forms.TextBox()
        Me.txt信計3_金額 = New System.Windows.Forms.TextBox()
        Me.txt信計4_金額 = New System.Windows.Forms.TextBox()
        Me.txtII計釣有_金額 = New System.Windows.Forms.TextBox()
        Me.txtII計釣無_金額 = New System.Windows.Forms.TextBox()
        Me.txtII計クーポン_金額 = New System.Windows.Forms.TextBox()
        Me.txt貸計_金額 = New System.Windows.Forms.TextBox()
        Me.txt単品値引_金額 = New System.Windows.Forms.TextBox()
        Me.txtハンドル値引_金額 = New System.Windows.Forms.TextBox()
        Me.txtクーポン値引_金額 = New System.Windows.Forms.TextBox()
        Me.txt明細割引_金額 = New System.Windows.Forms.TextBox()
        Me.txt小計値引_金額 = New System.Windows.Forms.TextBox()
        Me.txt小計割引_金額 = New System.Windows.Forms.TextBox()
        Me.txt訂正_金額 = New System.Windows.Forms.TextBox()
        Me.txt返品_金額 = New System.Windows.Forms.TextBox()
        Me.txt明細値引_金額 = New System.Windows.Forms.TextBox()
        Me.txtクーポン値引_件数 = New System.Windows.Forms.TextBox()
        Me.txt総売上額 = New System.Windows.Forms.TextBox()
        Me.txt明細値引_件数 = New System.Windows.Forms.TextBox()
        Me.txt明細割引_件数 = New System.Windows.Forms.TextBox()
        Me.txt小計値引_件数 = New System.Windows.Forms.TextBox()
        Me.txt小計割引_件数 = New System.Windows.Forms.TextBox()
        Me.txt単品値引_件数 = New System.Windows.Forms.TextBox()
        Me.txtハンドル値引_件数 = New System.Windows.Forms.TextBox()
        Me.txt訂正_件数 = New System.Windows.Forms.TextBox()
        Me.txt返品_件数 = New System.Windows.Forms.TextBox()
        Me.lblクーポン値引 = New System.Windows.Forms.Label()
        Me.lbl総売上額 = New System.Windows.Forms.Label()
        Me.lbl明細割引 = New System.Windows.Forms.Label()
        Me.lbl小計値引 = New System.Windows.Forms.Label()
        Me.lbl小計割引 = New System.Windows.Forms.Label()
        Me.lbl単品値引 = New System.Windows.Forms.Label()
        Me.lblハンドル値引 = New System.Windows.Forms.Label()
        Me.lbl訂正 = New System.Windows.Forms.Label()
        Me.lbl返品 = New System.Windows.Forms.Label()
        Me.lbl明細値引 = New System.Windows.Forms.Label()
        Me.txt訂正一括取消_金額 = New System.Windows.Forms.TextBox()
        Me.txt登録指定取消_金額 = New System.Windows.Forms.TextBox()
        Me.txt訂正指定取消_金額 = New System.Windows.Forms.TextBox()
        Me.txt取引回数_金額 = New System.Windows.Forms.TextBox()
        Me.txt取引人数_金額 = New System.Windows.Forms.TextBox()
        Me.txt登録一括取消_金額 = New System.Windows.Forms.TextBox()
        Me.txtクーポン発行_金額 = New System.Windows.Forms.TextBox()
        Me.txt領収書発行_金額 = New System.Windows.Forms.TextBox()
        Me.txt両替_金額 = New System.Windows.Forms.TextBox()
        Me.txt訂正指定取消_件数 = New System.Windows.Forms.TextBox()
        Me.txt両替_件数 = New System.Windows.Forms.TextBox()
        Me.txt取引回数_件数 = New System.Windows.Forms.TextBox()
        Me.txt取引人数_件数 = New System.Windows.Forms.TextBox()
        Me.txt登録一括取消_件数 = New System.Windows.Forms.TextBox()
        Me.txt訂正一括取消_件数 = New System.Windows.Forms.TextBox()
        Me.txt登録指定取消_件数 = New System.Windows.Forms.TextBox()
        Me.txtクーポン発行_件数 = New System.Windows.Forms.TextBox()
        Me.txt領収書発行_件数 = New System.Windows.Forms.TextBox()
        Me.lbl訂正指定取消 = New System.Windows.Forms.Label()
        Me.lbl取引回数 = New System.Windows.Forms.Label()
        Me.lbl取引人数 = New System.Windows.Forms.Label()
        Me.lbl登録一括取消 = New System.Windows.Forms.Label()
        Me.lbl訂正一括取消 = New System.Windows.Forms.Label()
        Me.lbl登録指定取消 = New System.Windows.Forms.Label()
        Me.lblクーポン発行 = New System.Windows.Forms.Label()
        Me.lbl領収書発行 = New System.Windows.Forms.Label()
        Me.lbl両替 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'cmb計上日付
        '
        Me.cmb計上日付.FormattingEnabled = True
        Me.cmb計上日付.Location = New System.Drawing.Point(18, 42)
        Me.cmb計上日付.Name = "cmb計上日付"
        Me.cmb計上日付.Size = New System.Drawing.Size(68, 20)
        Me.cmb計上日付.TabIndex = 1
        Me.cmb計上日付.Text = "計上日付"
        '
        'lblから
        '
        Me.lblから.AutoSize = True
        Me.lblから.Location = New System.Drawing.Point(222, 48)
        Me.lblから.Name = "lblから"
        Me.lblから.Size = New System.Drawing.Size(17, 12)
        Me.lblから.TabIndex = 4
        Me.lblから.Text = "～"
        '
        'btn集計
        '
        Me.btn集計.Location = New System.Drawing.Point(686, 45)
        Me.btn集計.Name = "btn集計"
        Me.btn集計.Size = New System.Drawing.Size(80, 35)
        Me.btn集計.TabIndex = 5
        Me.btn集計.Text = "集　計"
        Me.btn集計.UseVisualStyleBackColor = True
        '
        'btnレシート印刷
        '
        Me.btnレシート印刷.Location = New System.Drawing.Point(764, 45)
        Me.btnレシート印刷.Name = "btnレシート印刷"
        Me.btnレシート印刷.Size = New System.Drawing.Size(80, 35)
        Me.btnレシート印刷.TabIndex = 6
        Me.btnレシート印刷.Text = "レシート印刷"
        Me.btnレシート印刷.UseVisualStyleBackColor = True
        '
        'btnエクスポート
        '
        Me.btnエクスポート.Location = New System.Drawing.Point(841, 45)
        Me.btnエクスポート.Name = "btnエクスポート"
        Me.btnエクスポート.Size = New System.Drawing.Size(80, 35)
        Me.btnエクスポート.TabIndex = 7
        Me.btnエクスポート.Text = "エクスポート"
        Me.btnエクスポート.UseVisualStyleBackColor = True
        '
        'btn終了
        '
        Me.btn終了.Location = New System.Drawing.Point(918, 45)
        Me.btn終了.Name = "btn終了"
        Me.btn終了.Size = New System.Drawing.Size(80, 35)
        Me.btn終了.TabIndex = 8
        Me.btn終了.Text = "終　了(C)"
        Me.btn終了.UseVisualStyleBackColor = True
        '
        'lbl会計集計表
        '
        Me.lbl会計集計表.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl会計集計表.Location = New System.Drawing.Point(14, 106)
        Me.lbl会計集計表.Name = "lbl会計集計表"
        Me.lbl会計集計表.Size = New System.Drawing.Size(706, 14)
        Me.lbl会計集計表.TabIndex = 9
        Me.lbl会計集計表.Text = "会　計　集　計　表　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　" &
    "　　　　　"
        '
        'lbl釣銭準備金
        '
        Me.lbl釣銭準備金.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl釣銭準備金.Location = New System.Drawing.Point(11, 125)
        Me.lbl釣銭準備金.Name = "lbl釣銭準備金"
        Me.lbl釣銭準備金.Size = New System.Drawing.Size(91, 14)
        Me.lbl釣銭準備金.TabIndex = 10
        Me.lbl釣銭準備金.Text = "釣銭準備金"
        Me.lbl釣銭準備金.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl現金預かり
        '
        Me.lbl現金預かり.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl現金預かり.Location = New System.Drawing.Point(11, 148)
        Me.lbl現金預かり.Name = "lbl現金預かり"
        Me.lbl現金預かり.Size = New System.Drawing.Size(91, 14)
        Me.lbl現金預かり.TabIndex = 11
        Me.lbl現金預かり.Text = "現金預かり"
        Me.lbl現金預かり.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl釣銭支払い
        '
        Me.lbl釣銭支払い.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl釣銭支払い.Location = New System.Drawing.Point(11, 165)
        Me.lbl釣銭支払い.Name = "lbl釣銭支払い"
        Me.lbl釣銭支払い.Size = New System.Drawing.Size(91, 14)
        Me.lbl釣銭支払い.TabIndex = 12
        Me.lbl釣銭支払い.Text = "釣銭支払い"
        Me.lbl釣銭支払い.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl入金
        '
        Me.lbl入金.AutoSize = True
        Me.lbl入金.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl入金.Location = New System.Drawing.Point(57, 185)
        Me.lbl入金.Name = "lbl入金"
        Me.lbl入金.Size = New System.Drawing.Size(35, 14)
        Me.lbl入金.TabIndex = 13
        Me.lbl入金.Text = "入金"
        '
        'lbl釣銭回収
        '
        Me.lbl釣銭回収.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl釣銭回収.Location = New System.Drawing.Point(11, 205)
        Me.lbl釣銭回収.Name = "lbl釣銭回収"
        Me.lbl釣銭回収.Size = New System.Drawing.Size(91, 14)
        Me.lbl釣銭回収.TabIndex = 14
        Me.lbl釣銭回収.Text = "釣銭回収"
        Me.lbl釣銭回収.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl出金
        '
        Me.lbl出金.AutoSize = True
        Me.lbl出金.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl出金.Location = New System.Drawing.Point(57, 225)
        Me.lbl出金.Name = "lbl出金"
        Me.lbl出金.Size = New System.Drawing.Size(35, 14)
        Me.lbl出金.TabIndex = 19
        Me.lbl出金.Text = "出金"
        '
        'lbl現金有り高
        '
        Me.lbl現金有り高.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl現金有り高.Location = New System.Drawing.Point(11, 248)
        Me.lbl現金有り高.Name = "lbl現金有り高"
        Me.lbl現金有り高.Size = New System.Drawing.Size(91, 14)
        Me.lbl現金有り高.TabIndex = 18
        Me.lbl現金有り高.Text = "現金有り高"
        Me.lbl現金有り高.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl現計
        '
        Me.lbl現計.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl現計.Location = New System.Drawing.Point(11, 268)
        Me.lbl現計.Name = "lbl現計"
        Me.lbl現計.Size = New System.Drawing.Size(91, 14)
        Me.lbl現計.TabIndex = 17
        Me.lbl現計.Text = "現　計"
        Me.lbl現計.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl信計1
        '
        Me.lbl信計1.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl信計1.Location = New System.Drawing.Point(11, 288)
        Me.lbl信計1.Name = "lbl信計1"
        Me.lbl信計1.Size = New System.Drawing.Size(91, 14)
        Me.lbl信計1.TabIndex = 16
        Me.lbl信計1.Text = "信計1"
        Me.lbl信計1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl信計2
        '
        Me.lbl信計2.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl信計2.Location = New System.Drawing.Point(11, 305)
        Me.lbl信計2.Name = "lbl信計2"
        Me.lbl信計2.Size = New System.Drawing.Size(91, 14)
        Me.lbl信計2.TabIndex = 15
        Me.lbl信計2.Text = "信計2"
        Me.lbl信計2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl信計3
        '
        Me.lbl信計3.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl信計3.Location = New System.Drawing.Point(11, 325)
        Me.lbl信計3.Name = "lbl信計3"
        Me.lbl信計3.Size = New System.Drawing.Size(91, 14)
        Me.lbl信計3.TabIndex = 24
        Me.lbl信計3.Text = "信計3"
        Me.lbl信計3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl信計4
        '
        Me.lbl信計4.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl信計4.Location = New System.Drawing.Point(11, 345)
        Me.lbl信計4.Name = "lbl信計4"
        Me.lbl信計4.Size = New System.Drawing.Size(91, 14)
        Me.lbl信計4.TabIndex = 23
        Me.lbl信計4.Text = "信計4"
        Me.lbl信計4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblⅡ計釣有
        '
        Me.lblⅡ計釣有.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblⅡ計釣有.Location = New System.Drawing.Point(11, 367)
        Me.lblⅡ計釣有.Name = "lblⅡ計釣有"
        Me.lblⅡ計釣有.Size = New System.Drawing.Size(91, 14)
        Me.lblⅡ計釣有.TabIndex = 22
        Me.lblⅡ計釣有.Text = "Ⅱ計釣有"
        Me.lblⅡ計釣有.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblⅡ計釣無
        '
        Me.lblⅡ計釣無.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblⅡ計釣無.Location = New System.Drawing.Point(11, 385)
        Me.lblⅡ計釣無.Name = "lblⅡ計釣無"
        Me.lblⅡ計釣無.Size = New System.Drawing.Size(91, 14)
        Me.lblⅡ計釣無.TabIndex = 21
        Me.lblⅡ計釣無.Text = "Ⅱ計釣無"
        Me.lblⅡ計釣無.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblⅡ計クーポン
        '
        Me.lblⅡ計クーポン.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblⅡ計クーポン.Location = New System.Drawing.Point(11, 405)
        Me.lblⅡ計クーポン.Name = "lblⅡ計クーポン"
        Me.lblⅡ計クーポン.Size = New System.Drawing.Size(91, 14)
        Me.lblⅡ計クーポン.TabIndex = 20
        Me.lblⅡ計クーポン.Text = "Ⅱ計クーポン"
        Me.lblⅡ計クーポン.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl内消費税
        '
        Me.lbl内消費税.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl内消費税.Location = New System.Drawing.Point(11, 527)
        Me.lbl内消費税.Name = "lbl内消費税"
        Me.lbl内消費税.Size = New System.Drawing.Size(91, 14)
        Me.lbl内消費税.TabIndex = 35
        Me.lbl内消費税.Text = "内消費税"
        Me.lbl内消費税.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl内軽減消費税
        '
        Me.lbl内軽減消費税.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl内軽減消費税.Location = New System.Drawing.Point(11, 548)
        Me.lbl内軽減消費税.Name = "lbl内軽減消費税"
        Me.lbl内軽減消費税.Size = New System.Drawing.Size(91, 14)
        Me.lbl内軽減消費税.TabIndex = 34
        Me.lbl内軽減消費税.Text = "内軽減消費税"
        Me.lbl内軽減消費税.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl外消費税
        '
        Me.lbl外消費税.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl外消費税.Location = New System.Drawing.Point(11, 568)
        Me.lbl外消費税.Name = "lbl外消費税"
        Me.lbl外消費税.Size = New System.Drawing.Size(91, 14)
        Me.lbl外消費税.TabIndex = 33
        Me.lbl外消費税.Text = "外消費税"
        Me.lbl外消費税.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl外軽減消費税
        '
        Me.lbl外軽減消費税.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl外軽減消費税.Location = New System.Drawing.Point(11, 588)
        Me.lbl外軽減消費税.Name = "lbl外軽減消費税"
        Me.lbl外軽減消費税.Size = New System.Drawing.Size(91, 14)
        Me.lbl外軽減消費税.TabIndex = 32
        Me.lbl外軽減消費税.Text = "外軽減消費税"
        Me.lbl外軽減消費税.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl税抜売上額
        '
        Me.lbl税抜売上額.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl税抜売上額.Location = New System.Drawing.Point(11, 608)
        Me.lbl税抜売上額.Name = "lbl税抜売上額"
        Me.lbl税抜売上額.Size = New System.Drawing.Size(91, 14)
        Me.lbl税抜売上額.TabIndex = 31
        Me.lbl税抜売上額.Text = "税抜売上額"
        Me.lbl税抜売上額.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl貸計
        '
        Me.lbl貸計.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl貸計.Location = New System.Drawing.Point(11, 426)
        Me.lbl貸計.Name = "lbl貸計"
        Me.lbl貸計.Size = New System.Drawing.Size(91, 14)
        Me.lbl貸計.TabIndex = 30
        Me.lbl貸計.Text = "貸計"
        Me.lbl貸計.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl現金外計
        '
        Me.lbl現金外計.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl現金外計.Location = New System.Drawing.Point(11, 446)
        Me.lbl現金外計.Name = "lbl現金外計"
        Me.lbl現金外計.Size = New System.Drawing.Size(91, 14)
        Me.lbl現金外計.TabIndex = 29
        Me.lbl現金外計.Text = "現金外計"
        Me.lbl現金外計.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl過不足金
        '
        Me.lbl過不足金.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl過不足金.Location = New System.Drawing.Point(11, 466)
        Me.lbl過不足金.Name = "lbl過不足金"
        Me.lbl過不足金.Size = New System.Drawing.Size(91, 14)
        Me.lbl過不足金.TabIndex = 28
        Me.lbl過不足金.Text = "過不足金"
        Me.lbl過不足金.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl純売上額
        '
        Me.lbl純売上額.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl純売上額.Location = New System.Drawing.Point(11, 487)
        Me.lbl純売上額.Name = "lbl純売上額"
        Me.lbl純売上額.Size = New System.Drawing.Size(91, 14)
        Me.lbl純売上額.TabIndex = 27
        Me.lbl純売上額.Text = "純売上額"
        Me.lbl純売上額.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl雑収入
        '
        Me.lbl雑収入.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl雑収入.Location = New System.Drawing.Point(11, 507)
        Me.lbl雑収入.Name = "lbl雑収入"
        Me.lbl雑収入.Size = New System.Drawing.Size(91, 14)
        Me.lbl雑収入.TabIndex = 26
        Me.lbl雑収入.Text = "雑収入"
        Me.lbl雑収入.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt釣銭支払い_件数
        '
        Me.txt釣銭支払い_件数.Location = New System.Drawing.Point(107, 163)
        Me.txt釣銭支払い_件数.Name = "txt釣銭支払い_件数"
        Me.txt釣銭支払い_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt釣銭支払い_件数.TabIndex = 40
        '
        'txt現金預かり_件数
        '
        Me.txt現金預かり_件数.Location = New System.Drawing.Point(107, 143)
        Me.txt現金預かり_件数.Name = "txt現金預かり_件数"
        Me.txt現金預かり_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt現金預かり_件数.TabIndex = 41
        '
        'txt釣銭準備金_件数
        '
        Me.txt釣銭準備金_件数.Location = New System.Drawing.Point(107, 123)
        Me.txt釣銭準備金_件数.Name = "txt釣銭準備金_件数"
        Me.txt釣銭準備金_件数.Size = New System.Drawing.Size(109, 19)
        Me.txt釣銭準備金_件数.TabIndex = 42
        '
        'txt現金有り高
        '
        Me.txt現金有り高.Location = New System.Drawing.Point(107, 243)
        Me.txt現金有り高.Name = "txt現金有り高"
        Me.txt現金有り高.Size = New System.Drawing.Size(247, 19)
        Me.txt現金有り高.TabIndex = 45
        '
        'txt現計_件数
        '
        Me.txt現計_件数.Location = New System.Drawing.Point(107, 263)
        Me.txt現計_件数.Name = "txt現計_件数"
        Me.txt現計_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt現計_件数.TabIndex = 44
        '
        'txt信計1_件数
        '
        Me.txt信計1_件数.Location = New System.Drawing.Point(107, 283)
        Me.txt信計1_件数.Name = "txt信計1_件数"
        Me.txt信計1_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt信計1_件数.TabIndex = 43
        '
        'txt入金_件数
        '
        Me.txt入金_件数.Location = New System.Drawing.Point(107, 183)
        Me.txt入金_件数.Name = "txt入金_件数"
        Me.txt入金_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt入金_件数.TabIndex = 48
        '
        'txt釣銭回収_件数
        '
        Me.txt釣銭回収_件数.Location = New System.Drawing.Point(107, 203)
        Me.txt釣銭回収_件数.Name = "txt釣銭回収_件数"
        Me.txt釣銭回収_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt釣銭回収_件数.TabIndex = 47
        '
        'txt出金_件数
        '
        Me.txt出金_件数.Location = New System.Drawing.Point(107, 223)
        Me.txt出金_件数.Name = "txt出金_件数"
        Me.txt出金_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt出金_件数.TabIndex = 46
        '
        'txtII計釣有_件数
        '
        Me.txtII計釣有_件数.Location = New System.Drawing.Point(107, 363)
        Me.txtII計釣有_件数.Name = "txtII計釣有_件数"
        Me.txtII計釣有_件数.Size = New System.Drawing.Size(100, 19)
        Me.txtII計釣有_件数.TabIndex = 51
        '
        'txtII計釣無_件数
        '
        Me.txtII計釣無_件数.Location = New System.Drawing.Point(107, 383)
        Me.txtII計釣無_件数.Name = "txtII計釣無_件数"
        Me.txtII計釣無_件数.Size = New System.Drawing.Size(100, 19)
        Me.txtII計釣無_件数.TabIndex = 50
        '
        'txtII計クーポン_件数
        '
        Me.txtII計クーポン_件数.Location = New System.Drawing.Point(107, 403)
        Me.txtII計クーポン_件数.Name = "txtII計クーポン_件数"
        Me.txtII計クーポン_件数.Size = New System.Drawing.Size(100, 19)
        Me.txtII計クーポン_件数.TabIndex = 49
        '
        'txt信計2_件数
        '
        Me.txt信計2_件数.Location = New System.Drawing.Point(107, 303)
        Me.txt信計2_件数.Name = "txt信計2_件数"
        Me.txt信計2_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt信計2_件数.TabIndex = 54
        '
        'txt信計3_件数
        '
        Me.txt信計3_件数.Location = New System.Drawing.Point(107, 323)
        Me.txt信計3_件数.Name = "txt信計3_件数"
        Me.txt信計3_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt信計3_件数.TabIndex = 53
        '
        'txt信計4_件数
        '
        Me.txt信計4_件数.Location = New System.Drawing.Point(107, 343)
        Me.txt信計4_件数.Name = "txt信計4_件数"
        Me.txt信計4_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt信計4_件数.TabIndex = 52
        '
        'txt貸計_件数
        '
        Me.txt貸計_件数.Location = New System.Drawing.Point(107, 423)
        Me.txt貸計_件数.Name = "txt貸計_件数"
        Me.txt貸計_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt貸計_件数.TabIndex = 57
        '
        'txt現金外計
        '
        Me.txt現金外計.Location = New System.Drawing.Point(107, 443)
        Me.txt現金外計.Name = "txt現金外計"
        Me.txt現金外計.Size = New System.Drawing.Size(247, 19)
        Me.txt現金外計.TabIndex = 56
        '
        'txt過不足金
        '
        Me.txt過不足金.Location = New System.Drawing.Point(107, 463)
        Me.txt過不足金.Name = "txt過不足金"
        Me.txt過不足金.Size = New System.Drawing.Size(247, 19)
        Me.txt過不足金.TabIndex = 55
        '
        'txt純売上額
        '
        Me.txt純売上額.Location = New System.Drawing.Point(107, 483)
        Me.txt純売上額.Name = "txt純売上額"
        Me.txt純売上額.Size = New System.Drawing.Size(247, 19)
        Me.txt純売上額.TabIndex = 60
        '
        'txt雑収入
        '
        Me.txt雑収入.Location = New System.Drawing.Point(107, 503)
        Me.txt雑収入.Name = "txt雑収入"
        Me.txt雑収入.Size = New System.Drawing.Size(247, 19)
        Me.txt雑収入.TabIndex = 59
        '
        'txt内消費税
        '
        Me.txt内消費税.Location = New System.Drawing.Point(107, 523)
        Me.txt内消費税.Name = "txt内消費税"
        Me.txt内消費税.Size = New System.Drawing.Size(247, 19)
        Me.txt内消費税.TabIndex = 58
        '
        'txt内軽減消費税
        '
        Me.txt内軽減消費税.Location = New System.Drawing.Point(107, 543)
        Me.txt内軽減消費税.Name = "txt内軽減消費税"
        Me.txt内軽減消費税.Size = New System.Drawing.Size(247, 19)
        Me.txt内軽減消費税.TabIndex = 63
        '
        'txt外消費税
        '
        Me.txt外消費税.Location = New System.Drawing.Point(107, 563)
        Me.txt外消費税.Name = "txt外消費税"
        Me.txt外消費税.Size = New System.Drawing.Size(247, 19)
        Me.txt外消費税.TabIndex = 62
        '
        'txt外軽減消費税
        '
        Me.txt外軽減消費税.Location = New System.Drawing.Point(107, 583)
        Me.txt外軽減消費税.Name = "txt外軽減消費税"
        Me.txt外軽減消費税.Size = New System.Drawing.Size(247, 19)
        Me.txt外軽減消費税.TabIndex = 61
        '
        'txt税抜売上額
        '
        Me.txt税抜売上額.Location = New System.Drawing.Point(107, 603)
        Me.txt税抜売上額.Name = "txt税抜売上額"
        Me.txt税抜売上額.Size = New System.Drawing.Size(247, 19)
        Me.txt税抜売上額.TabIndex = 66
        '
        'txt釣銭準備金_金額
        '
        Me.txt釣銭準備金_金額.Location = New System.Drawing.Point(204, 123)
        Me.txt釣銭準備金_金額.Name = "txt釣銭準備金_金額"
        Me.txt釣銭準備金_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt釣銭準備金_金額.TabIndex = 69
        '
        'txt現金預かり_金額
        '
        Me.txt現金預かり_金額.Location = New System.Drawing.Point(204, 143)
        Me.txt現金預かり_金額.Name = "txt現金預かり_金額"
        Me.txt現金預かり_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt現金預かり_金額.TabIndex = 68
        '
        'txt釣銭支払い_金額
        '
        Me.txt釣銭支払い_金額.Location = New System.Drawing.Point(204, 163)
        Me.txt釣銭支払い_金額.Name = "txt釣銭支払い_金額"
        Me.txt釣銭支払い_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt釣銭支払い_金額.TabIndex = 67
        '
        'txt入金_金額
        '
        Me.txt入金_金額.Location = New System.Drawing.Point(204, 183)
        Me.txt入金_金額.Name = "txt入金_金額"
        Me.txt入金_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt入金_金額.TabIndex = 72
        '
        'txt釣銭回収_金額
        '
        Me.txt釣銭回収_金額.Location = New System.Drawing.Point(204, 203)
        Me.txt釣銭回収_金額.Name = "txt釣銭回収_金額"
        Me.txt釣銭回収_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt釣銭回収_金額.TabIndex = 71
        '
        'txt出金_金額
        '
        Me.txt出金_金額.Location = New System.Drawing.Point(204, 223)
        Me.txt出金_金額.Name = "txt出金_金額"
        Me.txt出金_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt出金_金額.TabIndex = 70
        '
        'txt現計_金額
        '
        Me.txt現計_金額.Location = New System.Drawing.Point(204, 263)
        Me.txt現計_金額.Name = "txt現計_金額"
        Me.txt現計_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt現計_金額.TabIndex = 75
        '
        'txt信計1_金額
        '
        Me.txt信計1_金額.Location = New System.Drawing.Point(204, 283)
        Me.txt信計1_金額.Name = "txt信計1_金額"
        Me.txt信計1_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt信計1_金額.TabIndex = 74
        '
        'txt信計2_金額
        '
        Me.txt信計2_金額.Location = New System.Drawing.Point(204, 303)
        Me.txt信計2_金額.Name = "txt信計2_金額"
        Me.txt信計2_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt信計2_金額.TabIndex = 73
        '
        'txt信計3_金額
        '
        Me.txt信計3_金額.Location = New System.Drawing.Point(204, 323)
        Me.txt信計3_金額.Name = "txt信計3_金額"
        Me.txt信計3_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt信計3_金額.TabIndex = 78
        '
        'txt信計4_金額
        '
        Me.txt信計4_金額.Location = New System.Drawing.Point(204, 343)
        Me.txt信計4_金額.Name = "txt信計4_金額"
        Me.txt信計4_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt信計4_金額.TabIndex = 77
        '
        'txtII計釣有_金額
        '
        Me.txtII計釣有_金額.Location = New System.Drawing.Point(204, 363)
        Me.txtII計釣有_金額.Name = "txtII計釣有_金額"
        Me.txtII計釣有_金額.Size = New System.Drawing.Size(150, 19)
        Me.txtII計釣有_金額.TabIndex = 76
        '
        'txtII計釣無_金額
        '
        Me.txtII計釣無_金額.Location = New System.Drawing.Point(204, 383)
        Me.txtII計釣無_金額.Name = "txtII計釣無_金額"
        Me.txtII計釣無_金額.Size = New System.Drawing.Size(150, 19)
        Me.txtII計釣無_金額.TabIndex = 81
        '
        'txtII計クーポン_金額
        '
        Me.txtII計クーポン_金額.Location = New System.Drawing.Point(204, 403)
        Me.txtII計クーポン_金額.Name = "txtII計クーポン_金額"
        Me.txtII計クーポン_金額.Size = New System.Drawing.Size(150, 19)
        Me.txtII計クーポン_金額.TabIndex = 80
        '
        'txt貸計_金額
        '
        Me.txt貸計_金額.Location = New System.Drawing.Point(204, 423)
        Me.txt貸計_金額.Name = "txt貸計_金額"
        Me.txt貸計_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt貸計_金額.TabIndex = 79
        '
        'txt単品値引_金額
        '
        Me.txt単品値引_金額.Location = New System.Drawing.Point(570, 243)
        Me.txt単品値引_金額.Name = "txt単品値引_金額"
        Me.txt単品値引_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt単品値引_金額.TabIndex = 110
        '
        'txtハンドル値引_金額
        '
        Me.txtハンドル値引_金額.Location = New System.Drawing.Point(570, 263)
        Me.txtハンドル値引_金額.Name = "txtハンドル値引_金額"
        Me.txtハンドル値引_金額.Size = New System.Drawing.Size(150, 19)
        Me.txtハンドル値引_金額.TabIndex = 109
        '
        'txtクーポン値引_金額
        '
        Me.txtクーポン値引_金額.Location = New System.Drawing.Point(570, 283)
        Me.txtクーポン値引_金額.Name = "txtクーポン値引_金額"
        Me.txtクーポン値引_金額.Size = New System.Drawing.Size(150, 19)
        Me.txtクーポン値引_金額.TabIndex = 108
        '
        'txt明細割引_金額
        '
        Me.txt明細割引_金額.Location = New System.Drawing.Point(570, 183)
        Me.txt明細割引_金額.Name = "txt明細割引_金額"
        Me.txt明細割引_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt明細割引_金額.TabIndex = 107
        '
        'txt小計値引_金額
        '
        Me.txt小計値引_金額.Location = New System.Drawing.Point(570, 203)
        Me.txt小計値引_金額.Name = "txt小計値引_金額"
        Me.txt小計値引_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt小計値引_金額.TabIndex = 106
        '
        'txt小計割引_金額
        '
        Me.txt小計割引_金額.Location = New System.Drawing.Point(570, 223)
        Me.txt小計割引_金額.Name = "txt小計割引_金額"
        Me.txt小計割引_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt小計割引_金額.TabIndex = 105
        '
        'txt訂正_金額
        '
        Me.txt訂正_金額.Location = New System.Drawing.Point(570, 123)
        Me.txt訂正_金額.Name = "txt訂正_金額"
        Me.txt訂正_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt訂正_金額.TabIndex = 104
        '
        'txt返品_金額
        '
        Me.txt返品_金額.Location = New System.Drawing.Point(570, 143)
        Me.txt返品_金額.Name = "txt返品_金額"
        Me.txt返品_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt返品_金額.TabIndex = 103
        '
        'txt明細値引_金額
        '
        Me.txt明細値引_金額.Location = New System.Drawing.Point(570, 163)
        Me.txt明細値引_金額.Name = "txt明細値引_金額"
        Me.txt明細値引_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt明細値引_金額.TabIndex = 102
        '
        'txtクーポン値引_件数
        '
        Me.txtクーポン値引_件数.Location = New System.Drawing.Point(473, 283)
        Me.txtクーポン値引_件数.Name = "txtクーポン値引_件数"
        Me.txtクーポン値引_件数.Size = New System.Drawing.Size(100, 19)
        Me.txtクーポン値引_件数.TabIndex = 101
        '
        'txt総売上額
        '
        Me.txt総売上額.Location = New System.Drawing.Point(473, 303)
        Me.txt総売上額.Name = "txt総売上額"
        Me.txt総売上額.Size = New System.Drawing.Size(247, 19)
        Me.txt総売上額.TabIndex = 100
        '
        'txt明細値引_件数
        '
        Me.txt明細値引_件数.Location = New System.Drawing.Point(473, 163)
        Me.txt明細値引_件数.Name = "txt明細値引_件数"
        Me.txt明細値引_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt明細値引_件数.TabIndex = 99
        '
        'txt明細割引_件数
        '
        Me.txt明細割引_件数.Location = New System.Drawing.Point(473, 183)
        Me.txt明細割引_件数.Name = "txt明細割引_件数"
        Me.txt明細割引_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt明細割引_件数.TabIndex = 98
        '
        'txt小計値引_件数
        '
        Me.txt小計値引_件数.Location = New System.Drawing.Point(473, 203)
        Me.txt小計値引_件数.Name = "txt小計値引_件数"
        Me.txt小計値引_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt小計値引_件数.TabIndex = 97
        '
        'txt小計割引_件数
        '
        Me.txt小計割引_件数.Location = New System.Drawing.Point(473, 223)
        Me.txt小計割引_件数.Name = "txt小計割引_件数"
        Me.txt小計割引_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt小計割引_件数.TabIndex = 96
        '
        'txt単品値引_件数
        '
        Me.txt単品値引_件数.Location = New System.Drawing.Point(473, 243)
        Me.txt単品値引_件数.Name = "txt単品値引_件数"
        Me.txt単品値引_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt単品値引_件数.TabIndex = 95
        '
        'txtハンドル値引_件数
        '
        Me.txtハンドル値引_件数.Location = New System.Drawing.Point(473, 263)
        Me.txtハンドル値引_件数.Name = "txtハンドル値引_件数"
        Me.txtハンドル値引_件数.Size = New System.Drawing.Size(100, 19)
        Me.txtハンドル値引_件数.TabIndex = 94
        '
        'txt訂正_件数
        '
        Me.txt訂正_件数.Location = New System.Drawing.Point(473, 123)
        Me.txt訂正_件数.Name = "txt訂正_件数"
        Me.txt訂正_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt訂正_件数.TabIndex = 93
        '
        'txt返品_件数
        '
        Me.txt返品_件数.Location = New System.Drawing.Point(473, 143)
        Me.txt返品_件数.Name = "txt返品_件数"
        Me.txt返品_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt返品_件数.TabIndex = 92
        '
        'lblクーポン値引
        '
        Me.lblクーポン値引.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblクーポン値引.Location = New System.Drawing.Point(377, 283)
        Me.lblクーポン値引.Name = "lblクーポン値引"
        Me.lblクーポン値引.Size = New System.Drawing.Size(91, 14)
        Me.lblクーポン値引.TabIndex = 91
        Me.lblクーポン値引.Text = "クーポン値引"
        Me.lblクーポン値引.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl総売上額
        '
        Me.lbl総売上額.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl総売上額.Location = New System.Drawing.Point(377, 303)
        Me.lbl総売上額.Name = "lbl総売上額"
        Me.lbl総売上額.Size = New System.Drawing.Size(91, 14)
        Me.lbl総売上額.TabIndex = 90
        Me.lbl総売上額.Text = "総売上額"
        Me.lbl総売上額.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl明細割引
        '
        Me.lbl明細割引.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl明細割引.Location = New System.Drawing.Point(377, 182)
        Me.lbl明細割引.Name = "lbl明細割引"
        Me.lbl明細割引.Size = New System.Drawing.Size(91, 14)
        Me.lbl明細割引.TabIndex = 89
        Me.lbl明細割引.Text = "明細割引"
        Me.lbl明細割引.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl小計値引
        '
        Me.lbl小計値引.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl小計値引.Location = New System.Drawing.Point(377, 202)
        Me.lbl小計値引.Name = "lbl小計値引"
        Me.lbl小計値引.Size = New System.Drawing.Size(91, 14)
        Me.lbl小計値引.TabIndex = 88
        Me.lbl小計値引.Text = "小計値引"
        Me.lbl小計値引.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl小計割引
        '
        Me.lbl小計割引.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl小計割引.Location = New System.Drawing.Point(377, 224)
        Me.lbl小計割引.Name = "lbl小計割引"
        Me.lbl小計割引.Size = New System.Drawing.Size(91, 14)
        Me.lbl小計割引.TabIndex = 87
        Me.lbl小計割引.Text = "小計割引"
        Me.lbl小計割引.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl単品値引
        '
        Me.lbl単品値引.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl単品値引.Location = New System.Drawing.Point(377, 242)
        Me.lbl単品値引.Name = "lbl単品値引"
        Me.lbl単品値引.Size = New System.Drawing.Size(91, 14)
        Me.lbl単品値引.TabIndex = 86
        Me.lbl単品値引.Text = "単品値引"
        Me.lbl単品値引.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblハンドル値引
        '
        Me.lblハンドル値引.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblハンドル値引.Location = New System.Drawing.Point(377, 262)
        Me.lblハンドル値引.Name = "lblハンドル値引"
        Me.lblハンドル値引.Size = New System.Drawing.Size(91, 14)
        Me.lblハンドル値引.TabIndex = 85
        Me.lblハンドル値引.Text = "ハンドル値引"
        Me.lblハンドル値引.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl訂正
        '
        Me.lbl訂正.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl訂正.Location = New System.Drawing.Point(377, 125)
        Me.lbl訂正.Name = "lbl訂正"
        Me.lbl訂正.Size = New System.Drawing.Size(91, 14)
        Me.lbl訂正.TabIndex = 84
        Me.lbl訂正.Text = "訂　正"
        Me.lbl訂正.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl返品
        '
        Me.lbl返品.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl返品.Location = New System.Drawing.Point(377, 145)
        Me.lbl返品.Name = "lbl返品"
        Me.lbl返品.Size = New System.Drawing.Size(91, 14)
        Me.lbl返品.TabIndex = 83
        Me.lbl返品.Text = "返　品"
        Me.lbl返品.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl明細値引
        '
        Me.lbl明細値引.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl明細値引.Location = New System.Drawing.Point(377, 162)
        Me.lbl明細値引.Name = "lbl明細値引"
        Me.lbl明細値引.Size = New System.Drawing.Size(91, 14)
        Me.lbl明細値引.TabIndex = 82
        Me.lbl明細値引.Text = "明細値引"
        Me.lbl明細値引.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt訂正一括取消_金額
        '
        Me.txt訂正一括取消_金額.Location = New System.Drawing.Point(570, 463)
        Me.txt訂正一括取消_金額.Name = "txt訂正一括取消_金額"
        Me.txt訂正一括取消_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt訂正一括取消_金額.TabIndex = 137
        '
        'txt登録指定取消_金額
        '
        Me.txt登録指定取消_金額.Location = New System.Drawing.Point(570, 483)
        Me.txt登録指定取消_金額.Name = "txt登録指定取消_金額"
        Me.txt登録指定取消_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt登録指定取消_金額.TabIndex = 136
        '
        'txt訂正指定取消_金額
        '
        Me.txt訂正指定取消_金額.Location = New System.Drawing.Point(570, 503)
        Me.txt訂正指定取消_金額.Name = "txt訂正指定取消_金額"
        Me.txt訂正指定取消_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt訂正指定取消_金額.TabIndex = 135
        '
        'txt取引回数_金額
        '
        Me.txt取引回数_金額.Location = New System.Drawing.Point(570, 403)
        Me.txt取引回数_金額.Name = "txt取引回数_金額"
        Me.txt取引回数_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt取引回数_金額.TabIndex = 134
        '
        'txt取引人数_金額
        '
        Me.txt取引人数_金額.Location = New System.Drawing.Point(570, 423)
        Me.txt取引人数_金額.Name = "txt取引人数_金額"
        Me.txt取引人数_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt取引人数_金額.TabIndex = 133
        '
        'txt登録一括取消_金額
        '
        Me.txt登録一括取消_金額.Location = New System.Drawing.Point(570, 443)
        Me.txt登録一括取消_金額.Name = "txt登録一括取消_金額"
        Me.txt登録一括取消_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt登録一括取消_金額.TabIndex = 132
        '
        'txtクーポン発行_金額
        '
        Me.txtクーポン発行_金額.Location = New System.Drawing.Point(570, 343)
        Me.txtクーポン発行_金額.Name = "txtクーポン発行_金額"
        Me.txtクーポン発行_金額.Size = New System.Drawing.Size(150, 19)
        Me.txtクーポン発行_金額.TabIndex = 131
        '
        'txt領収書発行_金額
        '
        Me.txt領収書発行_金額.Location = New System.Drawing.Point(570, 363)
        Me.txt領収書発行_金額.Name = "txt領収書発行_金額"
        Me.txt領収書発行_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt領収書発行_金額.TabIndex = 130
        '
        'txt両替_金額
        '
        Me.txt両替_金額.Location = New System.Drawing.Point(570, 383)
        Me.txt両替_金額.Name = "txt両替_金額"
        Me.txt両替_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt両替_金額.TabIndex = 129
        '
        'txt訂正指定取消_件数
        '
        Me.txt訂正指定取消_件数.Location = New System.Drawing.Point(473, 503)
        Me.txt訂正指定取消_件数.Name = "txt訂正指定取消_件数"
        Me.txt訂正指定取消_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt訂正指定取消_件数.TabIndex = 128
        '
        'txt両替_件数
        '
        Me.txt両替_件数.Location = New System.Drawing.Point(473, 383)
        Me.txt両替_件数.Name = "txt両替_件数"
        Me.txt両替_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt両替_件数.TabIndex = 127
        '
        'txt取引回数_件数
        '
        Me.txt取引回数_件数.Location = New System.Drawing.Point(473, 403)
        Me.txt取引回数_件数.Name = "txt取引回数_件数"
        Me.txt取引回数_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt取引回数_件数.TabIndex = 126
        '
        'txt取引人数_件数
        '
        Me.txt取引人数_件数.Location = New System.Drawing.Point(473, 423)
        Me.txt取引人数_件数.Name = "txt取引人数_件数"
        Me.txt取引人数_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt取引人数_件数.TabIndex = 125
        '
        'txt登録一括取消_件数
        '
        Me.txt登録一括取消_件数.Location = New System.Drawing.Point(473, 443)
        Me.txt登録一括取消_件数.Name = "txt登録一括取消_件数"
        Me.txt登録一括取消_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt登録一括取消_件数.TabIndex = 124
        '
        'txt訂正一括取消_件数
        '
        Me.txt訂正一括取消_件数.Location = New System.Drawing.Point(473, 463)
        Me.txt訂正一括取消_件数.Name = "txt訂正一括取消_件数"
        Me.txt訂正一括取消_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt訂正一括取消_件数.TabIndex = 123
        '
        'txt登録指定取消_件数
        '
        Me.txt登録指定取消_件数.Location = New System.Drawing.Point(473, 483)
        Me.txt登録指定取消_件数.Name = "txt登録指定取消_件数"
        Me.txt登録指定取消_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt登録指定取消_件数.TabIndex = 122
        '
        'txtクーポン発行_件数
        '
        Me.txtクーポン発行_件数.Location = New System.Drawing.Point(473, 343)
        Me.txtクーポン発行_件数.Name = "txtクーポン発行_件数"
        Me.txtクーポン発行_件数.Size = New System.Drawing.Size(100, 19)
        Me.txtクーポン発行_件数.TabIndex = 121
        '
        'txt領収書発行_件数
        '
        Me.txt領収書発行_件数.Location = New System.Drawing.Point(473, 363)
        Me.txt領収書発行_件数.Name = "txt領収書発行_件数"
        Me.txt領収書発行_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt領収書発行_件数.TabIndex = 120
        '
        'lbl訂正指定取消
        '
        Me.lbl訂正指定取消.AutoSize = True
        Me.lbl訂正指定取消.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl訂正指定取消.Location = New System.Drawing.Point(377, 506)
        Me.lbl訂正指定取消.Name = "lbl訂正指定取消"
        Me.lbl訂正指定取消.Size = New System.Drawing.Size(91, 14)
        Me.lbl訂正指定取消.TabIndex = 119
        Me.lbl訂正指定取消.Text = "訂正指定取消"
        Me.lbl訂正指定取消.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl取引回数
        '
        Me.lbl取引回数.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl取引回数.Location = New System.Drawing.Point(377, 405)
        Me.lbl取引回数.Name = "lbl取引回数"
        Me.lbl取引回数.Size = New System.Drawing.Size(91, 14)
        Me.lbl取引回数.TabIndex = 118
        Me.lbl取引回数.Text = "取引回数"
        Me.lbl取引回数.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl取引人数
        '
        Me.lbl取引人数.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl取引人数.Location = New System.Drawing.Point(377, 425)
        Me.lbl取引人数.Name = "lbl取引人数"
        Me.lbl取引人数.Size = New System.Drawing.Size(91, 14)
        Me.lbl取引人数.TabIndex = 117
        Me.lbl取引人数.Text = "取引人数"
        Me.lbl取引人数.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl登録一括取消
        '
        Me.lbl登録一括取消.AutoSize = True
        Me.lbl登録一括取消.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl登録一括取消.Location = New System.Drawing.Point(377, 447)
        Me.lbl登録一括取消.Name = "lbl登録一括取消"
        Me.lbl登録一括取消.Size = New System.Drawing.Size(91, 14)
        Me.lbl登録一括取消.TabIndex = 116
        Me.lbl登録一括取消.Text = "登録一括取消"
        Me.lbl登録一括取消.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl訂正一括取消
        '
        Me.lbl訂正一括取消.AutoSize = True
        Me.lbl訂正一括取消.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl訂正一括取消.Location = New System.Drawing.Point(377, 465)
        Me.lbl訂正一括取消.Name = "lbl訂正一括取消"
        Me.lbl訂正一括取消.Size = New System.Drawing.Size(91, 14)
        Me.lbl訂正一括取消.TabIndex = 115
        Me.lbl訂正一括取消.Text = "訂正一括取消"
        Me.lbl訂正一括取消.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl登録指定取消
        '
        Me.lbl登録指定取消.AutoSize = True
        Me.lbl登録指定取消.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl登録指定取消.Location = New System.Drawing.Point(377, 485)
        Me.lbl登録指定取消.Name = "lbl登録指定取消"
        Me.lbl登録指定取消.Size = New System.Drawing.Size(91, 14)
        Me.lbl登録指定取消.TabIndex = 114
        Me.lbl登録指定取消.Text = "登録指定取消"
        Me.lbl登録指定取消.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblクーポン発行
        '
        Me.lblクーポン発行.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblクーポン発行.Location = New System.Drawing.Point(377, 348)
        Me.lblクーポン発行.Name = "lblクーポン発行"
        Me.lblクーポン発行.Size = New System.Drawing.Size(91, 14)
        Me.lblクーポン発行.TabIndex = 113
        Me.lblクーポン発行.Text = "クーポン発行"
        Me.lblクーポン発行.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl領収書発行
        '
        Me.lbl領収書発行.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl領収書発行.Location = New System.Drawing.Point(377, 368)
        Me.lbl領収書発行.Name = "lbl領収書発行"
        Me.lbl領収書発行.Size = New System.Drawing.Size(91, 14)
        Me.lbl領収書発行.TabIndex = 112
        Me.lbl領収書発行.Text = "領収書発行"
        Me.lbl領収書発行.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl両替
        '
        Me.lbl両替.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl両替.Location = New System.Drawing.Point(377, 385)
        Me.lbl両替.Name = "lbl両替"
        Me.lbl両替.Size = New System.Drawing.Size(91, 14)
        Me.lbl両替.TabIndex = 111
        Me.lbl両替.Text = "両　替"
        Me.lbl両替.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(92, 43)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(124, 19)
        Me.DateTimePicker1.TabIndex = 138
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(245, 43)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(124, 19)
        Me.DateTimePicker2.TabIndex = 139
        '
        'frm精算処理
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txt訂正一括取消_金額)
        Me.Controls.Add(Me.txt登録指定取消_金額)
        Me.Controls.Add(Me.txt訂正指定取消_金額)
        Me.Controls.Add(Me.txt取引回数_金額)
        Me.Controls.Add(Me.txt取引人数_金額)
        Me.Controls.Add(Me.txt登録一括取消_金額)
        Me.Controls.Add(Me.txtクーポン発行_金額)
        Me.Controls.Add(Me.txt領収書発行_金額)
        Me.Controls.Add(Me.txt両替_金額)
        Me.Controls.Add(Me.txt訂正指定取消_件数)
        Me.Controls.Add(Me.txt両替_件数)
        Me.Controls.Add(Me.txt取引回数_件数)
        Me.Controls.Add(Me.txt取引人数_件数)
        Me.Controls.Add(Me.txt登録一括取消_件数)
        Me.Controls.Add(Me.txt訂正一括取消_件数)
        Me.Controls.Add(Me.txt登録指定取消_件数)
        Me.Controls.Add(Me.txtクーポン発行_件数)
        Me.Controls.Add(Me.txt領収書発行_件数)
        Me.Controls.Add(Me.lbl訂正指定取消)
        Me.Controls.Add(Me.lbl取引回数)
        Me.Controls.Add(Me.lbl取引人数)
        Me.Controls.Add(Me.lbl登録一括取消)
        Me.Controls.Add(Me.lbl訂正一括取消)
        Me.Controls.Add(Me.lbl登録指定取消)
        Me.Controls.Add(Me.lblクーポン発行)
        Me.Controls.Add(Me.lbl領収書発行)
        Me.Controls.Add(Me.lbl両替)
        Me.Controls.Add(Me.txt単品値引_金額)
        Me.Controls.Add(Me.txtハンドル値引_金額)
        Me.Controls.Add(Me.txtクーポン値引_金額)
        Me.Controls.Add(Me.txt明細割引_金額)
        Me.Controls.Add(Me.txt小計値引_金額)
        Me.Controls.Add(Me.txt小計割引_金額)
        Me.Controls.Add(Me.txt訂正_金額)
        Me.Controls.Add(Me.txt返品_金額)
        Me.Controls.Add(Me.txt明細値引_金額)
        Me.Controls.Add(Me.txtクーポン値引_件数)
        Me.Controls.Add(Me.txt総売上額)
        Me.Controls.Add(Me.txt明細値引_件数)
        Me.Controls.Add(Me.txt明細割引_件数)
        Me.Controls.Add(Me.txt小計値引_件数)
        Me.Controls.Add(Me.txt小計割引_件数)
        Me.Controls.Add(Me.txt単品値引_件数)
        Me.Controls.Add(Me.txtハンドル値引_件数)
        Me.Controls.Add(Me.txt訂正_件数)
        Me.Controls.Add(Me.txt返品_件数)
        Me.Controls.Add(Me.lblクーポン値引)
        Me.Controls.Add(Me.lbl総売上額)
        Me.Controls.Add(Me.lbl明細割引)
        Me.Controls.Add(Me.lbl小計値引)
        Me.Controls.Add(Me.lbl小計割引)
        Me.Controls.Add(Me.lbl単品値引)
        Me.Controls.Add(Me.lblハンドル値引)
        Me.Controls.Add(Me.lbl訂正)
        Me.Controls.Add(Me.lbl返品)
        Me.Controls.Add(Me.lbl明細値引)
        Me.Controls.Add(Me.txtII計釣無_金額)
        Me.Controls.Add(Me.txtII計クーポン_金額)
        Me.Controls.Add(Me.txt貸計_金額)
        Me.Controls.Add(Me.txt信計3_金額)
        Me.Controls.Add(Me.txt信計4_金額)
        Me.Controls.Add(Me.txtII計釣有_金額)
        Me.Controls.Add(Me.txt現計_金額)
        Me.Controls.Add(Me.txt信計1_金額)
        Me.Controls.Add(Me.txt信計2_金額)
        Me.Controls.Add(Me.txt入金_金額)
        Me.Controls.Add(Me.txt釣銭回収_金額)
        Me.Controls.Add(Me.txt出金_金額)
        Me.Controls.Add(Me.txt釣銭準備金_金額)
        Me.Controls.Add(Me.txt現金預かり_金額)
        Me.Controls.Add(Me.txt釣銭支払い_金額)
        Me.Controls.Add(Me.txt税抜売上額)
        Me.Controls.Add(Me.txt内軽減消費税)
        Me.Controls.Add(Me.txt外消費税)
        Me.Controls.Add(Me.txt外軽減消費税)
        Me.Controls.Add(Me.txt純売上額)
        Me.Controls.Add(Me.txt雑収入)
        Me.Controls.Add(Me.txt内消費税)
        Me.Controls.Add(Me.txt貸計_件数)
        Me.Controls.Add(Me.txt現金外計)
        Me.Controls.Add(Me.txt過不足金)
        Me.Controls.Add(Me.txt信計2_件数)
        Me.Controls.Add(Me.txt信計3_件数)
        Me.Controls.Add(Me.txt信計4_件数)
        Me.Controls.Add(Me.txtII計釣有_件数)
        Me.Controls.Add(Me.txtII計釣無_件数)
        Me.Controls.Add(Me.txtII計クーポン_件数)
        Me.Controls.Add(Me.txt入金_件数)
        Me.Controls.Add(Me.txt釣銭回収_件数)
        Me.Controls.Add(Me.txt出金_件数)
        Me.Controls.Add(Me.txt現金有り高)
        Me.Controls.Add(Me.txt現計_件数)
        Me.Controls.Add(Me.txt信計1_件数)
        Me.Controls.Add(Me.txt釣銭準備金_件数)
        Me.Controls.Add(Me.txt現金預かり_件数)
        Me.Controls.Add(Me.txt釣銭支払い_件数)
        Me.Controls.Add(Me.lbl内消費税)
        Me.Controls.Add(Me.lbl内軽減消費税)
        Me.Controls.Add(Me.lbl外消費税)
        Me.Controls.Add(Me.lbl外軽減消費税)
        Me.Controls.Add(Me.lbl税抜売上額)
        Me.Controls.Add(Me.lbl貸計)
        Me.Controls.Add(Me.lbl現金外計)
        Me.Controls.Add(Me.lbl過不足金)
        Me.Controls.Add(Me.lbl純売上額)
        Me.Controls.Add(Me.lbl雑収入)
        Me.Controls.Add(Me.lbl信計3)
        Me.Controls.Add(Me.lbl信計4)
        Me.Controls.Add(Me.lblⅡ計釣有)
        Me.Controls.Add(Me.lblⅡ計釣無)
        Me.Controls.Add(Me.lblⅡ計クーポン)
        Me.Controls.Add(Me.lbl出金)
        Me.Controls.Add(Me.lbl現金有り高)
        Me.Controls.Add(Me.lbl現計)
        Me.Controls.Add(Me.lbl信計1)
        Me.Controls.Add(Me.lbl信計2)
        Me.Controls.Add(Me.lbl釣銭回収)
        Me.Controls.Add(Me.lbl入金)
        Me.Controls.Add(Me.lbl釣銭支払い)
        Me.Controls.Add(Me.lbl現金預かり)
        Me.Controls.Add(Me.lbl釣銭準備金)
        Me.Controls.Add(Me.lbl会計集計表)
        Me.Controls.Add(Me.btn終了)
        Me.Controls.Add(Me.btnエクスポート)
        Me.Controls.Add(Me.btnレシート印刷)
        Me.Controls.Add(Me.btn集計)
        Me.Controls.Add(Me.lblから)
        Me.Controls.Add(Me.cmb計上日付)
        Me.Name = "frm精算処理"
        Me.RightToLeftLayout = True
        Me.Text = "精算処理"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb計上日付 As ComboBox
    Friend WithEvents lblから As Label
    Friend WithEvents btn集計 As Button
    Friend WithEvents btnレシート印刷 As Button
    Friend WithEvents btnエクスポート As Button
    Friend WithEvents btn終了 As Button
    Friend WithEvents lbl会計集計表 As Label
    Friend WithEvents lbl釣銭準備金 As Label
    Friend WithEvents lbl現金預かり As Label
    Friend WithEvents lbl釣銭支払い As Label
    Friend WithEvents lbl入金 As Label
    Friend WithEvents lbl釣銭回収 As Label
    Friend WithEvents lbl出金 As Label
    Friend WithEvents lbl現金有り高 As Label
    Friend WithEvents lbl現計 As Label
    Friend WithEvents lbl信計1 As Label
    Friend WithEvents lbl信計2 As Label
    Friend WithEvents lbl信計3 As Label
    Friend WithEvents lbl信計4 As Label
    Friend WithEvents lblⅡ計釣有 As Label
    Friend WithEvents lblⅡ計釣無 As Label
    Friend WithEvents lblⅡ計クーポン As Label
    Friend WithEvents lbl内消費税 As Label
    Friend WithEvents lbl内軽減消費税 As Label
    Friend WithEvents lbl外消費税 As Label
    Friend WithEvents lbl外軽減消費税 As Label
    Friend WithEvents lbl税抜売上額 As Label
    Friend WithEvents lbl貸計 As Label
    Friend WithEvents lbl現金外計 As Label
    Friend WithEvents lbl過不足金 As Label
    Friend WithEvents lbl純売上額 As Label
    Friend WithEvents lbl雑収入 As Label
    Friend WithEvents txt釣銭支払い_件数 As TextBox
    Friend WithEvents txt現金預かり_件数 As TextBox
    Friend WithEvents txt釣銭準備金_件数 As TextBox
    Friend WithEvents txt現金有り高 As TextBox
    Friend WithEvents txt現計_件数 As TextBox
    Friend WithEvents txt信計1_件数 As TextBox
    Friend WithEvents txt入金_件数 As TextBox
    Friend WithEvents txt釣銭回収_件数 As TextBox
    Friend WithEvents txt出金_件数 As TextBox
    Friend WithEvents txtII計釣有_件数 As TextBox
    Friend WithEvents txtII計釣無_件数 As TextBox
    Friend WithEvents txtII計クーポン_件数 As TextBox
    Friend WithEvents txt信計2_件数 As TextBox
    Friend WithEvents txt信計3_件数 As TextBox
    Friend WithEvents txt信計4_件数 As TextBox
    Friend WithEvents txt貸計_件数 As TextBox
    Friend WithEvents txt現金外計 As TextBox
    Friend WithEvents txt過不足金 As TextBox
    Friend WithEvents txt純売上額 As TextBox
    Friend WithEvents txt雑収入 As TextBox
    Friend WithEvents txt内消費税 As TextBox
    Friend WithEvents txt内軽減消費税 As TextBox
    Friend WithEvents txt外消費税 As TextBox
    Friend WithEvents txt外軽減消費税 As TextBox
    Friend WithEvents txt税抜売上額 As TextBox
    Friend WithEvents txt釣銭準備金_金額 As TextBox
    Friend WithEvents txt現金預かり_金額 As TextBox
    Friend WithEvents txt釣銭支払い_金額 As TextBox
    Friend WithEvents txt入金_金額 As TextBox
    Friend WithEvents txt釣銭回収_金額 As TextBox
    Friend WithEvents txt出金_金額 As TextBox
    Friend WithEvents txt現計_金額 As TextBox
    Friend WithEvents txt信計1_金額 As TextBox
    Friend WithEvents txt信計2_金額 As TextBox
    Friend WithEvents txt信計3_金額 As TextBox
    Friend WithEvents txt信計4_金額 As TextBox
    Friend WithEvents txtII計釣有_金額 As TextBox
    Friend WithEvents txtII計釣無_金額 As TextBox
    Friend WithEvents txtII計クーポン_金額 As TextBox
    Friend WithEvents txt貸計_金額 As TextBox
    Friend WithEvents txt単品値引_金額 As TextBox
    Friend WithEvents txtハンドル値引_金額 As TextBox
    Friend WithEvents txtクーポン値引_金額 As TextBox
    Friend WithEvents txt明細割引_金額 As TextBox
    Friend WithEvents txt小計値引_金額 As TextBox
    Friend WithEvents txt小計割引_金額 As TextBox
    Friend WithEvents txt訂正_金額 As TextBox
    Friend WithEvents txt返品_金額 As TextBox
    Friend WithEvents txt明細値引_金額 As TextBox
    Friend WithEvents txtクーポン値引_件数 As TextBox
    Friend WithEvents txt総売上額 As TextBox
    Friend WithEvents txt明細値引_件数 As TextBox
    Friend WithEvents txt明細割引_件数 As TextBox
    Friend WithEvents txt小計値引_件数 As TextBox
    Friend WithEvents txt小計割引_件数 As TextBox
    Friend WithEvents txt単品値引_件数 As TextBox
    Friend WithEvents txtハンドル値引_件数 As TextBox
    Friend WithEvents txt訂正_件数 As TextBox
    Friend WithEvents txt返品_件数 As TextBox
    Friend WithEvents lblクーポン値引 As Label
    Friend WithEvents lbl総売上額 As Label
    Friend WithEvents lbl明細割引 As Label
    Friend WithEvents lbl小計値引 As Label
    Friend WithEvents lbl小計割引 As Label
    Friend WithEvents lbl単品値引 As Label
    Friend WithEvents lblハンドル値引 As Label
    Friend WithEvents lbl訂正 As Label
    Friend WithEvents lbl返品 As Label
    Friend WithEvents lbl明細値引 As Label
    Friend WithEvents txt訂正一括取消_金額 As TextBox
    Friend WithEvents txt登録指定取消_金額 As TextBox
    Friend WithEvents txt訂正指定取消_金額 As TextBox
    Friend WithEvents txt取引回数_金額 As TextBox
    Friend WithEvents txt取引人数_金額 As TextBox
    Friend WithEvents txt登録一括取消_金額 As TextBox
    Friend WithEvents txtクーポン発行_金額 As TextBox
    Friend WithEvents txt領収書発行_金額 As TextBox
    Friend WithEvents txt両替_金額 As TextBox
    Friend WithEvents txt訂正指定取消_件数 As TextBox
    Friend WithEvents txt両替_件数 As TextBox
    Friend WithEvents txt取引回数_件数 As TextBox
    Friend WithEvents txt取引人数_件数 As TextBox
    Friend WithEvents txt登録一括取消_件数 As TextBox
    Friend WithEvents txt訂正一括取消_件数 As TextBox
    Friend WithEvents txt登録指定取消_件数 As TextBox
    Friend WithEvents txtクーポン発行_件数 As TextBox
    Friend WithEvents txt領収書発行_件数 As TextBox
    Friend WithEvents lbl訂正指定取消 As Label
    Friend WithEvents lbl取引回数 As Label
    Friend WithEvents lbl取引人数 As Label
    Friend WithEvents lbl登録一括取消 As Label
    Friend WithEvents lbl訂正一括取消 As Label
    Friend WithEvents lbl登録指定取消 As Label
    Friend WithEvents lblクーポン発行 As Label
    Friend WithEvents lbl領収書発行 As Label
    Friend WithEvents lbl両替 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
End Class
