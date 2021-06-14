<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm600精算処理
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm600精算処理))
        Me.btn個別未収清算 = New System.Windows.Forms.Button()
        Me.btn清算開始 = New System.Windows.Forms.Button()
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
        Me.lbl説明文 = New System.Windows.Forms.Label()
        Me.grb1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.grb2 = New System.Windows.Forms.GroupBox()
        Me.lbl担当者 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lbl清算日時 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lbl端末CD = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btn清算取り消し = New System.Windows.Forms.Button()
        Me.grb3 = New System.Windows.Forms.GroupBox()
        Me.txt金種表 = New System.Windows.Forms.TextBox()
        Me.lbl金種表 = New System.Windows.Forms.Label()
        Me.txt1枚数 = New System.Windows.Forms.TextBox()
        Me.txt1en = New System.Windows.Forms.TextBox()
        Me.lbl1en = New System.Windows.Forms.Label()
        Me.txt5枚数 = New System.Windows.Forms.TextBox()
        Me.txt5en = New System.Windows.Forms.TextBox()
        Me.lbl5en = New System.Windows.Forms.Label()
        Me.txt10枚数 = New System.Windows.Forms.TextBox()
        Me.txt10en = New System.Windows.Forms.TextBox()
        Me.lbl10en = New System.Windows.Forms.Label()
        Me.txt50枚数 = New System.Windows.Forms.TextBox()
        Me.txt50en = New System.Windows.Forms.TextBox()
        Me.lbl50en = New System.Windows.Forms.Label()
        Me.txt100枚数 = New System.Windows.Forms.TextBox()
        Me.txt100en = New System.Windows.Forms.TextBox()
        Me.lbl100en = New System.Windows.Forms.Label()
        Me.txt500枚数 = New System.Windows.Forms.TextBox()
        Me.txt500en = New System.Windows.Forms.TextBox()
        Me.lbl500en = New System.Windows.Forms.Label()
        Me.txt1000枚数 = New System.Windows.Forms.TextBox()
        Me.txt1000en = New System.Windows.Forms.TextBox()
        Me.lbl1000en = New System.Windows.Forms.Label()
        Me.txt2000枚数 = New System.Windows.Forms.TextBox()
        Me.txt2000en = New System.Windows.Forms.TextBox()
        Me.lbl2000en = New System.Windows.Forms.Label()
        Me.txt5000枚数 = New System.Windows.Forms.TextBox()
        Me.txt5000en = New System.Windows.Forms.TextBox()
        Me.lbl5000en = New System.Windows.Forms.Label()
        Me.txt10000枚数 = New System.Windows.Forms.TextBox()
        Me.txt10000en = New System.Windows.Forms.TextBox()
        Me.lbl10000en = New System.Windows.Forms.Label()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.grb1.SuspendLayout()
        Me.grb2.SuspendLayout()
        Me.grb3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn個別未収清算
        '
        Me.btn個別未収清算.Location = New System.Drawing.Point(744, 15)
        Me.btn個別未収清算.Name = "btn個別未収清算"
        Me.btn個別未収清算.Size = New System.Drawing.Size(80, 35)
        Me.btn個別未収清算.TabIndex = 6
        Me.btn個別未収清算.Text = "ｵｰﾀﾞｰｴﾝﾄﾘｰ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "個別未収清算"
        Me.btn個別未収清算.UseVisualStyleBackColor = True
        '
        'btn清算開始
        '
        Me.btn清算開始.Location = New System.Drawing.Point(821, 15)
        Me.btn清算開始.Name = "btn清算開始"
        Me.btn清算開始.Size = New System.Drawing.Size(80, 35)
        Me.btn清算開始.TabIndex = 7
        Me.btn清算開始.Text = "清算開始"
        Me.btn清算開始.UseVisualStyleBackColor = True
        '
        'btn終了
        '
        Me.btn終了.Location = New System.Drawing.Point(898, 15)
        Me.btn終了.Name = "btn終了"
        Me.btn終了.Size = New System.Drawing.Size(80, 35)
        Me.btn終了.TabIndex = 8
        Me.btn終了.Text = "終　了(C)"
        Me.btn終了.UseVisualStyleBackColor = True
        '
        'lbl会計集計表
        '
        Me.lbl会計集計表.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl会計集計表.Location = New System.Drawing.Point(19, 15)
        Me.lbl会計集計表.Name = "lbl会計集計表"
        Me.lbl会計集計表.Size = New System.Drawing.Size(706, 14)
        Me.lbl会計集計表.TabIndex = 9
        Me.lbl会計集計表.Text = "会　計　集　計　表　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　" &
    "　　　　　"
        '
        'lbl釣銭準備金
        '
        Me.lbl釣銭準備金.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl釣銭準備金.Location = New System.Drawing.Point(16, 34)
        Me.lbl釣銭準備金.Name = "lbl釣銭準備金"
        Me.lbl釣銭準備金.Size = New System.Drawing.Size(91, 14)
        Me.lbl釣銭準備金.TabIndex = 10
        Me.lbl釣銭準備金.Text = "釣銭準備金"
        Me.lbl釣銭準備金.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl現金預かり
        '
        Me.lbl現金預かり.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl現金預かり.Location = New System.Drawing.Point(16, 57)
        Me.lbl現金預かり.Name = "lbl現金預かり"
        Me.lbl現金預かり.Size = New System.Drawing.Size(91, 14)
        Me.lbl現金預かり.TabIndex = 11
        Me.lbl現金預かり.Text = "現金預かり"
        Me.lbl現金預かり.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl釣銭支払い
        '
        Me.lbl釣銭支払い.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl釣銭支払い.Location = New System.Drawing.Point(16, 74)
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
        Me.lbl入金.Location = New System.Drawing.Point(62, 94)
        Me.lbl入金.Name = "lbl入金"
        Me.lbl入金.Size = New System.Drawing.Size(35, 14)
        Me.lbl入金.TabIndex = 13
        Me.lbl入金.Text = "入金"
        '
        'lbl釣銭回収
        '
        Me.lbl釣銭回収.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl釣銭回収.Location = New System.Drawing.Point(16, 114)
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
        Me.lbl出金.Location = New System.Drawing.Point(62, 134)
        Me.lbl出金.Name = "lbl出金"
        Me.lbl出金.Size = New System.Drawing.Size(35, 14)
        Me.lbl出金.TabIndex = 19
        Me.lbl出金.Text = "出金"
        '
        'lbl現金有り高
        '
        Me.lbl現金有り高.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl現金有り高.Location = New System.Drawing.Point(16, 157)
        Me.lbl現金有り高.Name = "lbl現金有り高"
        Me.lbl現金有り高.Size = New System.Drawing.Size(91, 14)
        Me.lbl現金有り高.TabIndex = 18
        Me.lbl現金有り高.Text = "現金有り高"
        Me.lbl現金有り高.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl現計
        '
        Me.lbl現計.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl現計.Location = New System.Drawing.Point(16, 177)
        Me.lbl現計.Name = "lbl現計"
        Me.lbl現計.Size = New System.Drawing.Size(91, 14)
        Me.lbl現計.TabIndex = 17
        Me.lbl現計.Text = "現　計"
        Me.lbl現計.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl信計1
        '
        Me.lbl信計1.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl信計1.Location = New System.Drawing.Point(16, 197)
        Me.lbl信計1.Name = "lbl信計1"
        Me.lbl信計1.Size = New System.Drawing.Size(91, 14)
        Me.lbl信計1.TabIndex = 16
        Me.lbl信計1.Text = "信計1"
        Me.lbl信計1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl信計2
        '
        Me.lbl信計2.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl信計2.Location = New System.Drawing.Point(16, 214)
        Me.lbl信計2.Name = "lbl信計2"
        Me.lbl信計2.Size = New System.Drawing.Size(91, 14)
        Me.lbl信計2.TabIndex = 15
        Me.lbl信計2.Text = "信計2"
        Me.lbl信計2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl信計3
        '
        Me.lbl信計3.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl信計3.Location = New System.Drawing.Point(16, 234)
        Me.lbl信計3.Name = "lbl信計3"
        Me.lbl信計3.Size = New System.Drawing.Size(91, 14)
        Me.lbl信計3.TabIndex = 24
        Me.lbl信計3.Text = "信計3"
        Me.lbl信計3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl信計4
        '
        Me.lbl信計4.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl信計4.Location = New System.Drawing.Point(16, 254)
        Me.lbl信計4.Name = "lbl信計4"
        Me.lbl信計4.Size = New System.Drawing.Size(91, 14)
        Me.lbl信計4.TabIndex = 23
        Me.lbl信計4.Text = "信計4"
        Me.lbl信計4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblⅡ計釣有
        '
        Me.lblⅡ計釣有.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblⅡ計釣有.Location = New System.Drawing.Point(16, 276)
        Me.lblⅡ計釣有.Name = "lblⅡ計釣有"
        Me.lblⅡ計釣有.Size = New System.Drawing.Size(91, 14)
        Me.lblⅡ計釣有.TabIndex = 22
        Me.lblⅡ計釣有.Text = "Ⅱ計釣有"
        Me.lblⅡ計釣有.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblⅡ計釣無
        '
        Me.lblⅡ計釣無.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblⅡ計釣無.Location = New System.Drawing.Point(16, 294)
        Me.lblⅡ計釣無.Name = "lblⅡ計釣無"
        Me.lblⅡ計釣無.Size = New System.Drawing.Size(91, 14)
        Me.lblⅡ計釣無.TabIndex = 21
        Me.lblⅡ計釣無.Text = "Ⅱ計釣無"
        Me.lblⅡ計釣無.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblⅡ計クーポン
        '
        Me.lblⅡ計クーポン.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblⅡ計クーポン.Location = New System.Drawing.Point(16, 314)
        Me.lblⅡ計クーポン.Name = "lblⅡ計クーポン"
        Me.lblⅡ計クーポン.Size = New System.Drawing.Size(91, 14)
        Me.lblⅡ計クーポン.TabIndex = 20
        Me.lblⅡ計クーポン.Text = "Ⅱ計クーポン"
        Me.lblⅡ計クーポン.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl内消費税
        '
        Me.lbl内消費税.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl内消費税.Location = New System.Drawing.Point(16, 436)
        Me.lbl内消費税.Name = "lbl内消費税"
        Me.lbl内消費税.Size = New System.Drawing.Size(91, 14)
        Me.lbl内消費税.TabIndex = 35
        Me.lbl内消費税.Text = "内消費税"
        Me.lbl内消費税.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl内軽減消費税
        '
        Me.lbl内軽減消費税.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl内軽減消費税.Location = New System.Drawing.Point(16, 457)
        Me.lbl内軽減消費税.Name = "lbl内軽減消費税"
        Me.lbl内軽減消費税.Size = New System.Drawing.Size(91, 14)
        Me.lbl内軽減消費税.TabIndex = 34
        Me.lbl内軽減消費税.Text = "内軽減消費税"
        Me.lbl内軽減消費税.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl外消費税
        '
        Me.lbl外消費税.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl外消費税.Location = New System.Drawing.Point(16, 477)
        Me.lbl外消費税.Name = "lbl外消費税"
        Me.lbl外消費税.Size = New System.Drawing.Size(91, 14)
        Me.lbl外消費税.TabIndex = 33
        Me.lbl外消費税.Text = "外消費税"
        Me.lbl外消費税.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl外軽減消費税
        '
        Me.lbl外軽減消費税.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl外軽減消費税.Location = New System.Drawing.Point(16, 497)
        Me.lbl外軽減消費税.Name = "lbl外軽減消費税"
        Me.lbl外軽減消費税.Size = New System.Drawing.Size(91, 14)
        Me.lbl外軽減消費税.TabIndex = 32
        Me.lbl外軽減消費税.Text = "外軽減消費税"
        Me.lbl外軽減消費税.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl税抜売上額
        '
        Me.lbl税抜売上額.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl税抜売上額.Location = New System.Drawing.Point(16, 517)
        Me.lbl税抜売上額.Name = "lbl税抜売上額"
        Me.lbl税抜売上額.Size = New System.Drawing.Size(91, 14)
        Me.lbl税抜売上額.TabIndex = 31
        Me.lbl税抜売上額.Text = "税抜売上額"
        Me.lbl税抜売上額.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl貸計
        '
        Me.lbl貸計.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl貸計.Location = New System.Drawing.Point(16, 335)
        Me.lbl貸計.Name = "lbl貸計"
        Me.lbl貸計.Size = New System.Drawing.Size(91, 14)
        Me.lbl貸計.TabIndex = 30
        Me.lbl貸計.Text = "貸計"
        Me.lbl貸計.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl現金外計
        '
        Me.lbl現金外計.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl現金外計.Location = New System.Drawing.Point(16, 355)
        Me.lbl現金外計.Name = "lbl現金外計"
        Me.lbl現金外計.Size = New System.Drawing.Size(91, 14)
        Me.lbl現金外計.TabIndex = 29
        Me.lbl現金外計.Text = "現金外計"
        Me.lbl現金外計.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl過不足金
        '
        Me.lbl過不足金.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl過不足金.Location = New System.Drawing.Point(16, 375)
        Me.lbl過不足金.Name = "lbl過不足金"
        Me.lbl過不足金.Size = New System.Drawing.Size(91, 14)
        Me.lbl過不足金.TabIndex = 28
        Me.lbl過不足金.Text = "過不足金"
        Me.lbl過不足金.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl純売上額
        '
        Me.lbl純売上額.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl純売上額.Location = New System.Drawing.Point(16, 396)
        Me.lbl純売上額.Name = "lbl純売上額"
        Me.lbl純売上額.Size = New System.Drawing.Size(91, 14)
        Me.lbl純売上額.TabIndex = 27
        Me.lbl純売上額.Text = "純売上額"
        Me.lbl純売上額.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl雑収入
        '
        Me.lbl雑収入.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl雑収入.Location = New System.Drawing.Point(16, 416)
        Me.lbl雑収入.Name = "lbl雑収入"
        Me.lbl雑収入.Size = New System.Drawing.Size(91, 14)
        Me.lbl雑収入.TabIndex = 26
        Me.lbl雑収入.Text = "雑収入"
        Me.lbl雑収入.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt釣銭支払い_件数
        '
        Me.txt釣銭支払い_件数.Location = New System.Drawing.Point(112, 72)
        Me.txt釣銭支払い_件数.Name = "txt釣銭支払い_件数"
        Me.txt釣銭支払い_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt釣銭支払い_件数.TabIndex = 40
        '
        'txt現金預かり_件数
        '
        Me.txt現金預かり_件数.Location = New System.Drawing.Point(112, 52)
        Me.txt現金預かり_件数.Name = "txt現金預かり_件数"
        Me.txt現金預かり_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt現金預かり_件数.TabIndex = 41
        '
        'txt釣銭準備金_件数
        '
        Me.txt釣銭準備金_件数.Location = New System.Drawing.Point(112, 32)
        Me.txt釣銭準備金_件数.Name = "txt釣銭準備金_件数"
        Me.txt釣銭準備金_件数.Size = New System.Drawing.Size(109, 19)
        Me.txt釣銭準備金_件数.TabIndex = 42
        '
        'txt現金有り高
        '
        Me.txt現金有り高.Location = New System.Drawing.Point(112, 152)
        Me.txt現金有り高.Name = "txt現金有り高"
        Me.txt現金有り高.Size = New System.Drawing.Size(247, 19)
        Me.txt現金有り高.TabIndex = 45
        '
        'txt現計_件数
        '
        Me.txt現計_件数.Location = New System.Drawing.Point(112, 172)
        Me.txt現計_件数.Name = "txt現計_件数"
        Me.txt現計_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt現計_件数.TabIndex = 44
        '
        'txt信計1_件数
        '
        Me.txt信計1_件数.Location = New System.Drawing.Point(112, 192)
        Me.txt信計1_件数.Name = "txt信計1_件数"
        Me.txt信計1_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt信計1_件数.TabIndex = 43
        '
        'txt入金_件数
        '
        Me.txt入金_件数.Location = New System.Drawing.Point(112, 92)
        Me.txt入金_件数.Name = "txt入金_件数"
        Me.txt入金_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt入金_件数.TabIndex = 48
        '
        'txt釣銭回収_件数
        '
        Me.txt釣銭回収_件数.Location = New System.Drawing.Point(112, 112)
        Me.txt釣銭回収_件数.Name = "txt釣銭回収_件数"
        Me.txt釣銭回収_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt釣銭回収_件数.TabIndex = 47
        '
        'txt出金_件数
        '
        Me.txt出金_件数.Location = New System.Drawing.Point(112, 132)
        Me.txt出金_件数.Name = "txt出金_件数"
        Me.txt出金_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt出金_件数.TabIndex = 46
        '
        'txtII計釣有_件数
        '
        Me.txtII計釣有_件数.Location = New System.Drawing.Point(112, 272)
        Me.txtII計釣有_件数.Name = "txtII計釣有_件数"
        Me.txtII計釣有_件数.Size = New System.Drawing.Size(100, 19)
        Me.txtII計釣有_件数.TabIndex = 51
        '
        'txtII計釣無_件数
        '
        Me.txtII計釣無_件数.Location = New System.Drawing.Point(112, 292)
        Me.txtII計釣無_件数.Name = "txtII計釣無_件数"
        Me.txtII計釣無_件数.Size = New System.Drawing.Size(100, 19)
        Me.txtII計釣無_件数.TabIndex = 50
        '
        'txtII計クーポン_件数
        '
        Me.txtII計クーポン_件数.Location = New System.Drawing.Point(112, 312)
        Me.txtII計クーポン_件数.Name = "txtII計クーポン_件数"
        Me.txtII計クーポン_件数.Size = New System.Drawing.Size(100, 19)
        Me.txtII計クーポン_件数.TabIndex = 49
        '
        'txt信計2_件数
        '
        Me.txt信計2_件数.Location = New System.Drawing.Point(112, 212)
        Me.txt信計2_件数.Name = "txt信計2_件数"
        Me.txt信計2_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt信計2_件数.TabIndex = 54
        '
        'txt信計3_件数
        '
        Me.txt信計3_件数.Location = New System.Drawing.Point(112, 232)
        Me.txt信計3_件数.Name = "txt信計3_件数"
        Me.txt信計3_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt信計3_件数.TabIndex = 53
        '
        'txt信計4_件数
        '
        Me.txt信計4_件数.Location = New System.Drawing.Point(112, 252)
        Me.txt信計4_件数.Name = "txt信計4_件数"
        Me.txt信計4_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt信計4_件数.TabIndex = 52
        '
        'txt貸計_件数
        '
        Me.txt貸計_件数.Location = New System.Drawing.Point(112, 332)
        Me.txt貸計_件数.Name = "txt貸計_件数"
        Me.txt貸計_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt貸計_件数.TabIndex = 57
        '
        'txt現金外計
        '
        Me.txt現金外計.Location = New System.Drawing.Point(112, 352)
        Me.txt現金外計.Name = "txt現金外計"
        Me.txt現金外計.Size = New System.Drawing.Size(247, 19)
        Me.txt現金外計.TabIndex = 56
        '
        'txt過不足金
        '
        Me.txt過不足金.Location = New System.Drawing.Point(112, 372)
        Me.txt過不足金.Name = "txt過不足金"
        Me.txt過不足金.Size = New System.Drawing.Size(247, 19)
        Me.txt過不足金.TabIndex = 55
        '
        'txt純売上額
        '
        Me.txt純売上額.Location = New System.Drawing.Point(112, 392)
        Me.txt純売上額.Name = "txt純売上額"
        Me.txt純売上額.Size = New System.Drawing.Size(247, 19)
        Me.txt純売上額.TabIndex = 60
        '
        'txt雑収入
        '
        Me.txt雑収入.Location = New System.Drawing.Point(112, 412)
        Me.txt雑収入.Name = "txt雑収入"
        Me.txt雑収入.Size = New System.Drawing.Size(247, 19)
        Me.txt雑収入.TabIndex = 59
        '
        'txt内消費税
        '
        Me.txt内消費税.Location = New System.Drawing.Point(112, 432)
        Me.txt内消費税.Name = "txt内消費税"
        Me.txt内消費税.Size = New System.Drawing.Size(247, 19)
        Me.txt内消費税.TabIndex = 58
        '
        'txt内軽減消費税
        '
        Me.txt内軽減消費税.Location = New System.Drawing.Point(112, 452)
        Me.txt内軽減消費税.Name = "txt内軽減消費税"
        Me.txt内軽減消費税.Size = New System.Drawing.Size(247, 19)
        Me.txt内軽減消費税.TabIndex = 63
        '
        'txt外消費税
        '
        Me.txt外消費税.Location = New System.Drawing.Point(112, 472)
        Me.txt外消費税.Name = "txt外消費税"
        Me.txt外消費税.Size = New System.Drawing.Size(247, 19)
        Me.txt外消費税.TabIndex = 62
        '
        'txt外軽減消費税
        '
        Me.txt外軽減消費税.Location = New System.Drawing.Point(112, 492)
        Me.txt外軽減消費税.Name = "txt外軽減消費税"
        Me.txt外軽減消費税.Size = New System.Drawing.Size(247, 19)
        Me.txt外軽減消費税.TabIndex = 61
        '
        'txt税抜売上額
        '
        Me.txt税抜売上額.Location = New System.Drawing.Point(112, 512)
        Me.txt税抜売上額.Name = "txt税抜売上額"
        Me.txt税抜売上額.Size = New System.Drawing.Size(247, 19)
        Me.txt税抜売上額.TabIndex = 66
        '
        'txt釣銭準備金_金額
        '
        Me.txt釣銭準備金_金額.Location = New System.Drawing.Point(209, 32)
        Me.txt釣銭準備金_金額.Name = "txt釣銭準備金_金額"
        Me.txt釣銭準備金_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt釣銭準備金_金額.TabIndex = 69
        '
        'txt現金預かり_金額
        '
        Me.txt現金預かり_金額.Location = New System.Drawing.Point(209, 52)
        Me.txt現金預かり_金額.Name = "txt現金預かり_金額"
        Me.txt現金預かり_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt現金預かり_金額.TabIndex = 68
        '
        'txt釣銭支払い_金額
        '
        Me.txt釣銭支払い_金額.Location = New System.Drawing.Point(209, 72)
        Me.txt釣銭支払い_金額.Name = "txt釣銭支払い_金額"
        Me.txt釣銭支払い_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt釣銭支払い_金額.TabIndex = 67
        '
        'txt入金_金額
        '
        Me.txt入金_金額.Location = New System.Drawing.Point(209, 92)
        Me.txt入金_金額.Name = "txt入金_金額"
        Me.txt入金_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt入金_金額.TabIndex = 72
        '
        'txt釣銭回収_金額
        '
        Me.txt釣銭回収_金額.Location = New System.Drawing.Point(209, 112)
        Me.txt釣銭回収_金額.Name = "txt釣銭回収_金額"
        Me.txt釣銭回収_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt釣銭回収_金額.TabIndex = 71
        '
        'txt出金_金額
        '
        Me.txt出金_金額.Location = New System.Drawing.Point(209, 132)
        Me.txt出金_金額.Name = "txt出金_金額"
        Me.txt出金_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt出金_金額.TabIndex = 70
        '
        'txt現計_金額
        '
        Me.txt現計_金額.Location = New System.Drawing.Point(209, 172)
        Me.txt現計_金額.Name = "txt現計_金額"
        Me.txt現計_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt現計_金額.TabIndex = 75
        '
        'txt信計1_金額
        '
        Me.txt信計1_金額.Location = New System.Drawing.Point(209, 192)
        Me.txt信計1_金額.Name = "txt信計1_金額"
        Me.txt信計1_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt信計1_金額.TabIndex = 74
        '
        'txt信計2_金額
        '
        Me.txt信計2_金額.Location = New System.Drawing.Point(209, 212)
        Me.txt信計2_金額.Name = "txt信計2_金額"
        Me.txt信計2_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt信計2_金額.TabIndex = 73
        '
        'txt信計3_金額
        '
        Me.txt信計3_金額.Location = New System.Drawing.Point(209, 232)
        Me.txt信計3_金額.Name = "txt信計3_金額"
        Me.txt信計3_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt信計3_金額.TabIndex = 78
        '
        'txt信計4_金額
        '
        Me.txt信計4_金額.Location = New System.Drawing.Point(209, 252)
        Me.txt信計4_金額.Name = "txt信計4_金額"
        Me.txt信計4_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt信計4_金額.TabIndex = 77
        '
        'txtII計釣有_金額
        '
        Me.txtII計釣有_金額.Location = New System.Drawing.Point(209, 272)
        Me.txtII計釣有_金額.Name = "txtII計釣有_金額"
        Me.txtII計釣有_金額.Size = New System.Drawing.Size(150, 19)
        Me.txtII計釣有_金額.TabIndex = 76
        '
        'txtII計釣無_金額
        '
        Me.txtII計釣無_金額.Location = New System.Drawing.Point(209, 292)
        Me.txtII計釣無_金額.Name = "txtII計釣無_金額"
        Me.txtII計釣無_金額.Size = New System.Drawing.Size(150, 19)
        Me.txtII計釣無_金額.TabIndex = 81
        '
        'txtII計クーポン_金額
        '
        Me.txtII計クーポン_金額.Location = New System.Drawing.Point(209, 312)
        Me.txtII計クーポン_金額.Name = "txtII計クーポン_金額"
        Me.txtII計クーポン_金額.Size = New System.Drawing.Size(150, 19)
        Me.txtII計クーポン_金額.TabIndex = 80
        '
        'txt貸計_金額
        '
        Me.txt貸計_金額.Location = New System.Drawing.Point(209, 332)
        Me.txt貸計_金額.Name = "txt貸計_金額"
        Me.txt貸計_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt貸計_金額.TabIndex = 79
        '
        'txt単品値引_金額
        '
        Me.txt単品値引_金額.Location = New System.Drawing.Point(575, 152)
        Me.txt単品値引_金額.Name = "txt単品値引_金額"
        Me.txt単品値引_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt単品値引_金額.TabIndex = 110
        '
        'txtハンドル値引_金額
        '
        Me.txtハンドル値引_金額.Location = New System.Drawing.Point(575, 172)
        Me.txtハンドル値引_金額.Name = "txtハンドル値引_金額"
        Me.txtハンドル値引_金額.Size = New System.Drawing.Size(150, 19)
        Me.txtハンドル値引_金額.TabIndex = 109
        '
        'txtクーポン値引_金額
        '
        Me.txtクーポン値引_金額.Location = New System.Drawing.Point(575, 192)
        Me.txtクーポン値引_金額.Name = "txtクーポン値引_金額"
        Me.txtクーポン値引_金額.Size = New System.Drawing.Size(150, 19)
        Me.txtクーポン値引_金額.TabIndex = 108
        '
        'txt明細割引_金額
        '
        Me.txt明細割引_金額.Location = New System.Drawing.Point(575, 92)
        Me.txt明細割引_金額.Name = "txt明細割引_金額"
        Me.txt明細割引_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt明細割引_金額.TabIndex = 107
        '
        'txt小計値引_金額
        '
        Me.txt小計値引_金額.Location = New System.Drawing.Point(575, 112)
        Me.txt小計値引_金額.Name = "txt小計値引_金額"
        Me.txt小計値引_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt小計値引_金額.TabIndex = 106
        '
        'txt小計割引_金額
        '
        Me.txt小計割引_金額.Location = New System.Drawing.Point(575, 132)
        Me.txt小計割引_金額.Name = "txt小計割引_金額"
        Me.txt小計割引_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt小計割引_金額.TabIndex = 105
        '
        'txt訂正_金額
        '
        Me.txt訂正_金額.Location = New System.Drawing.Point(575, 32)
        Me.txt訂正_金額.Name = "txt訂正_金額"
        Me.txt訂正_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt訂正_金額.TabIndex = 104
        '
        'txt返品_金額
        '
        Me.txt返品_金額.Location = New System.Drawing.Point(575, 52)
        Me.txt返品_金額.Name = "txt返品_金額"
        Me.txt返品_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt返品_金額.TabIndex = 103
        '
        'txt明細値引_金額
        '
        Me.txt明細値引_金額.Location = New System.Drawing.Point(575, 72)
        Me.txt明細値引_金額.Name = "txt明細値引_金額"
        Me.txt明細値引_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt明細値引_金額.TabIndex = 102
        '
        'txtクーポン値引_件数
        '
        Me.txtクーポン値引_件数.Location = New System.Drawing.Point(478, 192)
        Me.txtクーポン値引_件数.Name = "txtクーポン値引_件数"
        Me.txtクーポン値引_件数.Size = New System.Drawing.Size(100, 19)
        Me.txtクーポン値引_件数.TabIndex = 101
        '
        'txt総売上額
        '
        Me.txt総売上額.Location = New System.Drawing.Point(478, 212)
        Me.txt総売上額.Name = "txt総売上額"
        Me.txt総売上額.Size = New System.Drawing.Size(247, 19)
        Me.txt総売上額.TabIndex = 100
        '
        'txt明細値引_件数
        '
        Me.txt明細値引_件数.Location = New System.Drawing.Point(478, 72)
        Me.txt明細値引_件数.Name = "txt明細値引_件数"
        Me.txt明細値引_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt明細値引_件数.TabIndex = 99
        '
        'txt明細割引_件数
        '
        Me.txt明細割引_件数.Location = New System.Drawing.Point(478, 92)
        Me.txt明細割引_件数.Name = "txt明細割引_件数"
        Me.txt明細割引_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt明細割引_件数.TabIndex = 98
        '
        'txt小計値引_件数
        '
        Me.txt小計値引_件数.Location = New System.Drawing.Point(478, 112)
        Me.txt小計値引_件数.Name = "txt小計値引_件数"
        Me.txt小計値引_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt小計値引_件数.TabIndex = 97
        '
        'txt小計割引_件数
        '
        Me.txt小計割引_件数.Location = New System.Drawing.Point(478, 132)
        Me.txt小計割引_件数.Name = "txt小計割引_件数"
        Me.txt小計割引_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt小計割引_件数.TabIndex = 96
        '
        'txt単品値引_件数
        '
        Me.txt単品値引_件数.Location = New System.Drawing.Point(478, 152)
        Me.txt単品値引_件数.Name = "txt単品値引_件数"
        Me.txt単品値引_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt単品値引_件数.TabIndex = 95
        '
        'txtハンドル値引_件数
        '
        Me.txtハンドル値引_件数.Location = New System.Drawing.Point(478, 172)
        Me.txtハンドル値引_件数.Name = "txtハンドル値引_件数"
        Me.txtハンドル値引_件数.Size = New System.Drawing.Size(100, 19)
        Me.txtハンドル値引_件数.TabIndex = 94
        '
        'txt訂正_件数
        '
        Me.txt訂正_件数.Location = New System.Drawing.Point(478, 32)
        Me.txt訂正_件数.Name = "txt訂正_件数"
        Me.txt訂正_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt訂正_件数.TabIndex = 93
        '
        'txt返品_件数
        '
        Me.txt返品_件数.Location = New System.Drawing.Point(478, 52)
        Me.txt返品_件数.Name = "txt返品_件数"
        Me.txt返品_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt返品_件数.TabIndex = 92
        '
        'lblクーポン値引
        '
        Me.lblクーポン値引.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblクーポン値引.Location = New System.Drawing.Point(382, 192)
        Me.lblクーポン値引.Name = "lblクーポン値引"
        Me.lblクーポン値引.Size = New System.Drawing.Size(91, 14)
        Me.lblクーポン値引.TabIndex = 91
        Me.lblクーポン値引.Text = "クーポン値引"
        Me.lblクーポン値引.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl総売上額
        '
        Me.lbl総売上額.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl総売上額.Location = New System.Drawing.Point(382, 212)
        Me.lbl総売上額.Name = "lbl総売上額"
        Me.lbl総売上額.Size = New System.Drawing.Size(91, 14)
        Me.lbl総売上額.TabIndex = 90
        Me.lbl総売上額.Text = "総売上額"
        Me.lbl総売上額.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl明細割引
        '
        Me.lbl明細割引.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl明細割引.Location = New System.Drawing.Point(382, 91)
        Me.lbl明細割引.Name = "lbl明細割引"
        Me.lbl明細割引.Size = New System.Drawing.Size(91, 14)
        Me.lbl明細割引.TabIndex = 89
        Me.lbl明細割引.Text = "明細割引"
        Me.lbl明細割引.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl小計値引
        '
        Me.lbl小計値引.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl小計値引.Location = New System.Drawing.Point(382, 111)
        Me.lbl小計値引.Name = "lbl小計値引"
        Me.lbl小計値引.Size = New System.Drawing.Size(91, 14)
        Me.lbl小計値引.TabIndex = 88
        Me.lbl小計値引.Text = "小計値引"
        Me.lbl小計値引.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl小計割引
        '
        Me.lbl小計割引.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl小計割引.Location = New System.Drawing.Point(382, 133)
        Me.lbl小計割引.Name = "lbl小計割引"
        Me.lbl小計割引.Size = New System.Drawing.Size(91, 14)
        Me.lbl小計割引.TabIndex = 87
        Me.lbl小計割引.Text = "小計割引"
        Me.lbl小計割引.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl単品値引
        '
        Me.lbl単品値引.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl単品値引.Location = New System.Drawing.Point(382, 151)
        Me.lbl単品値引.Name = "lbl単品値引"
        Me.lbl単品値引.Size = New System.Drawing.Size(91, 14)
        Me.lbl単品値引.TabIndex = 86
        Me.lbl単品値引.Text = "単品値引"
        Me.lbl単品値引.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblハンドル値引
        '
        Me.lblハンドル値引.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblハンドル値引.Location = New System.Drawing.Point(382, 171)
        Me.lblハンドル値引.Name = "lblハンドル値引"
        Me.lblハンドル値引.Size = New System.Drawing.Size(91, 14)
        Me.lblハンドル値引.TabIndex = 85
        Me.lblハンドル値引.Text = "ハンドル値引"
        Me.lblハンドル値引.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl訂正
        '
        Me.lbl訂正.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl訂正.Location = New System.Drawing.Point(382, 34)
        Me.lbl訂正.Name = "lbl訂正"
        Me.lbl訂正.Size = New System.Drawing.Size(91, 14)
        Me.lbl訂正.TabIndex = 84
        Me.lbl訂正.Text = "訂　正"
        Me.lbl訂正.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl返品
        '
        Me.lbl返品.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl返品.Location = New System.Drawing.Point(382, 54)
        Me.lbl返品.Name = "lbl返品"
        Me.lbl返品.Size = New System.Drawing.Size(91, 14)
        Me.lbl返品.TabIndex = 83
        Me.lbl返品.Text = "返　品"
        Me.lbl返品.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl明細値引
        '
        Me.lbl明細値引.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl明細値引.Location = New System.Drawing.Point(382, 71)
        Me.lbl明細値引.Name = "lbl明細値引"
        Me.lbl明細値引.Size = New System.Drawing.Size(91, 14)
        Me.lbl明細値引.TabIndex = 82
        Me.lbl明細値引.Text = "明細値引"
        Me.lbl明細値引.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt訂正一括取消_金額
        '
        Me.txt訂正一括取消_金額.Location = New System.Drawing.Point(575, 372)
        Me.txt訂正一括取消_金額.Name = "txt訂正一括取消_金額"
        Me.txt訂正一括取消_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt訂正一括取消_金額.TabIndex = 137
        '
        'txt登録指定取消_金額
        '
        Me.txt登録指定取消_金額.Location = New System.Drawing.Point(575, 392)
        Me.txt登録指定取消_金額.Name = "txt登録指定取消_金額"
        Me.txt登録指定取消_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt登録指定取消_金額.TabIndex = 136
        '
        'txt訂正指定取消_金額
        '
        Me.txt訂正指定取消_金額.Location = New System.Drawing.Point(575, 412)
        Me.txt訂正指定取消_金額.Name = "txt訂正指定取消_金額"
        Me.txt訂正指定取消_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt訂正指定取消_金額.TabIndex = 135
        '
        'txt取引回数_金額
        '
        Me.txt取引回数_金額.Location = New System.Drawing.Point(575, 312)
        Me.txt取引回数_金額.Name = "txt取引回数_金額"
        Me.txt取引回数_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt取引回数_金額.TabIndex = 134
        '
        'txt取引人数_金額
        '
        Me.txt取引人数_金額.Location = New System.Drawing.Point(575, 332)
        Me.txt取引人数_金額.Name = "txt取引人数_金額"
        Me.txt取引人数_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt取引人数_金額.TabIndex = 133
        '
        'txt登録一括取消_金額
        '
        Me.txt登録一括取消_金額.Location = New System.Drawing.Point(575, 352)
        Me.txt登録一括取消_金額.Name = "txt登録一括取消_金額"
        Me.txt登録一括取消_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt登録一括取消_金額.TabIndex = 132
        '
        'txtクーポン発行_金額
        '
        Me.txtクーポン発行_金額.Location = New System.Drawing.Point(575, 252)
        Me.txtクーポン発行_金額.Name = "txtクーポン発行_金額"
        Me.txtクーポン発行_金額.Size = New System.Drawing.Size(150, 19)
        Me.txtクーポン発行_金額.TabIndex = 131
        '
        'txt領収書発行_金額
        '
        Me.txt領収書発行_金額.Location = New System.Drawing.Point(575, 272)
        Me.txt領収書発行_金額.Name = "txt領収書発行_金額"
        Me.txt領収書発行_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt領収書発行_金額.TabIndex = 130
        '
        'txt両替_金額
        '
        Me.txt両替_金額.Location = New System.Drawing.Point(575, 292)
        Me.txt両替_金額.Name = "txt両替_金額"
        Me.txt両替_金額.Size = New System.Drawing.Size(150, 19)
        Me.txt両替_金額.TabIndex = 129
        '
        'txt訂正指定取消_件数
        '
        Me.txt訂正指定取消_件数.Location = New System.Drawing.Point(478, 412)
        Me.txt訂正指定取消_件数.Name = "txt訂正指定取消_件数"
        Me.txt訂正指定取消_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt訂正指定取消_件数.TabIndex = 128
        '
        'txt両替_件数
        '
        Me.txt両替_件数.Location = New System.Drawing.Point(478, 292)
        Me.txt両替_件数.Name = "txt両替_件数"
        Me.txt両替_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt両替_件数.TabIndex = 127
        '
        'txt取引回数_件数
        '
        Me.txt取引回数_件数.Location = New System.Drawing.Point(478, 312)
        Me.txt取引回数_件数.Name = "txt取引回数_件数"
        Me.txt取引回数_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt取引回数_件数.TabIndex = 126
        '
        'txt取引人数_件数
        '
        Me.txt取引人数_件数.Location = New System.Drawing.Point(478, 332)
        Me.txt取引人数_件数.Name = "txt取引人数_件数"
        Me.txt取引人数_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt取引人数_件数.TabIndex = 125
        '
        'txt登録一括取消_件数
        '
        Me.txt登録一括取消_件数.Location = New System.Drawing.Point(478, 352)
        Me.txt登録一括取消_件数.Name = "txt登録一括取消_件数"
        Me.txt登録一括取消_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt登録一括取消_件数.TabIndex = 124
        '
        'txt訂正一括取消_件数
        '
        Me.txt訂正一括取消_件数.Location = New System.Drawing.Point(478, 372)
        Me.txt訂正一括取消_件数.Name = "txt訂正一括取消_件数"
        Me.txt訂正一括取消_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt訂正一括取消_件数.TabIndex = 123
        '
        'txt登録指定取消_件数
        '
        Me.txt登録指定取消_件数.Location = New System.Drawing.Point(478, 392)
        Me.txt登録指定取消_件数.Name = "txt登録指定取消_件数"
        Me.txt登録指定取消_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt登録指定取消_件数.TabIndex = 122
        '
        'txtクーポン発行_件数
        '
        Me.txtクーポン発行_件数.Location = New System.Drawing.Point(478, 252)
        Me.txtクーポン発行_件数.Name = "txtクーポン発行_件数"
        Me.txtクーポン発行_件数.Size = New System.Drawing.Size(100, 19)
        Me.txtクーポン発行_件数.TabIndex = 121
        '
        'txt領収書発行_件数
        '
        Me.txt領収書発行_件数.Location = New System.Drawing.Point(478, 272)
        Me.txt領収書発行_件数.Name = "txt領収書発行_件数"
        Me.txt領収書発行_件数.Size = New System.Drawing.Size(100, 19)
        Me.txt領収書発行_件数.TabIndex = 120
        '
        'lbl訂正指定取消
        '
        Me.lbl訂正指定取消.AutoSize = True
        Me.lbl訂正指定取消.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl訂正指定取消.Location = New System.Drawing.Point(382, 415)
        Me.lbl訂正指定取消.Name = "lbl訂正指定取消"
        Me.lbl訂正指定取消.Size = New System.Drawing.Size(91, 14)
        Me.lbl訂正指定取消.TabIndex = 119
        Me.lbl訂正指定取消.Text = "訂正指定取消"
        Me.lbl訂正指定取消.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl取引回数
        '
        Me.lbl取引回数.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl取引回数.Location = New System.Drawing.Point(382, 314)
        Me.lbl取引回数.Name = "lbl取引回数"
        Me.lbl取引回数.Size = New System.Drawing.Size(91, 14)
        Me.lbl取引回数.TabIndex = 118
        Me.lbl取引回数.Text = "取引回数"
        Me.lbl取引回数.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl取引人数
        '
        Me.lbl取引人数.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl取引人数.Location = New System.Drawing.Point(382, 334)
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
        Me.lbl登録一括取消.Location = New System.Drawing.Point(382, 356)
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
        Me.lbl訂正一括取消.Location = New System.Drawing.Point(382, 374)
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
        Me.lbl登録指定取消.Location = New System.Drawing.Point(382, 394)
        Me.lbl登録指定取消.Name = "lbl登録指定取消"
        Me.lbl登録指定取消.Size = New System.Drawing.Size(91, 14)
        Me.lbl登録指定取消.TabIndex = 114
        Me.lbl登録指定取消.Text = "登録指定取消"
        Me.lbl登録指定取消.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblクーポン発行
        '
        Me.lblクーポン発行.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblクーポン発行.Location = New System.Drawing.Point(382, 257)
        Me.lblクーポン発行.Name = "lblクーポン発行"
        Me.lblクーポン発行.Size = New System.Drawing.Size(91, 14)
        Me.lblクーポン発行.TabIndex = 113
        Me.lblクーポン発行.Text = "クーポン発行"
        Me.lblクーポン発行.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl領収書発行
        '
        Me.lbl領収書発行.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl領収書発行.Location = New System.Drawing.Point(382, 277)
        Me.lbl領収書発行.Name = "lbl領収書発行"
        Me.lbl領収書発行.Size = New System.Drawing.Size(91, 14)
        Me.lbl領収書発行.TabIndex = 112
        Me.lbl領収書発行.Text = "領収書発行"
        Me.lbl領収書発行.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl両替
        '
        Me.lbl両替.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl両替.Location = New System.Drawing.Point(382, 294)
        Me.lbl両替.Name = "lbl両替"
        Me.lbl両替.Size = New System.Drawing.Size(91, 14)
        Me.lbl両替.TabIndex = 111
        Me.lbl両替.Text = "両　替"
        Me.lbl両替.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl説明文
        '
        Me.lbl説明文.AutoSize = True
        Me.lbl説明文.Location = New System.Drawing.Point(16, 9)
        Me.lbl説明文.Name = "lbl説明文"
        Me.lbl説明文.Size = New System.Drawing.Size(319, 12)
        Me.lbl説明文.TabIndex = 138
        Me.lbl説明文.Text = "現在までの取引を清算し、取引データをデータベースに更新します。"
        '
        'grb1
        '
        Me.grb1.Controls.Add(Me.CheckBox10)
        Me.grb1.Controls.Add(Me.CheckBox9)
        Me.grb1.Controls.Add(Me.CheckBox8)
        Me.grb1.Controls.Add(Me.CheckBox7)
        Me.grb1.Controls.Add(Me.CheckBox6)
        Me.grb1.Controls.Add(Me.CheckBox5)
        Me.grb1.Controls.Add(Me.CheckBox4)
        Me.grb1.Controls.Add(Me.CheckBox3)
        Me.grb1.Controls.Add(Me.CheckBox2)
        Me.grb1.Controls.Add(Me.CheckBox1)
        Me.grb1.Controls.Add(Me.btn終了)
        Me.grb1.Controls.Add(Me.btn個別未収清算)
        Me.grb1.Controls.Add(Me.btn清算開始)
        Me.grb1.Location = New System.Drawing.Point(12, 24)
        Me.grb1.Name = "grb1"
        Me.grb1.Size = New System.Drawing.Size(984, 56)
        Me.grb1.TabIndex = 139
        Me.grb1.TabStop = False
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.Location = New System.Drawing.Point(367, 34)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(165, 16)
        Me.CheckBox10.TabIndex = 18
        Me.CheckBox10.Text = "オーダーエントリー全未収清算"
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Location = New System.Drawing.Point(191, 34)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(166, 16)
        Me.CheckBox9.TabIndex = 17
        Me.CheckBox9.Text = "オーダーエントリー未収レポート"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(103, 34)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox8.TabIndex = 16
        Me.CheckBox8.Text = "ジャーナル"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(15, 34)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox7.TabIndex = 15
        Me.CheckBox7.Text = "会計集計"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(455, 15)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(96, 16)
        Me.CheckBox6.TabIndex = 14
        Me.CheckBox6.Text = "時間帯別集計"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(367, 15)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(84, 16)
        Me.CheckBox5.TabIndex = 13
        Me.CheckBox5.Text = "現金外集計"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(279, 15)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(84, 16)
        Me.CheckBox4.TabIndex = 12
        Me.CheckBox4.Text = "分類別集計"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(191, 15)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(84, 16)
        Me.CheckBox3.TabIndex = 11
        Me.CheckBox3.Text = "客層別集計"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(103, 15)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(84, 16)
        Me.CheckBox2.TabIndex = 10
        Me.CheckBox2.Text = "部門別集計"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(15, 15)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(84, 16)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "品目別集計"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'grb2
        '
        Me.grb2.Controls.Add(Me.lbl担当者)
        Me.grb2.Controls.Add(Me.TextBox3)
        Me.grb2.Controls.Add(Me.lbl清算日時)
        Me.grb2.Controls.Add(Me.TextBox2)
        Me.grb2.Controls.Add(Me.lbl端末CD)
        Me.grb2.Controls.Add(Me.TextBox1)
        Me.grb2.Location = New System.Drawing.Point(12, 86)
        Me.grb2.Name = "grb2"
        Me.grb2.Size = New System.Drawing.Size(984, 51)
        Me.grb2.TabIndex = 140
        Me.grb2.TabStop = False
        '
        'lbl担当者
        '
        Me.lbl担当者.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl担当者.Location = New System.Drawing.Point(494, 20)
        Me.lbl担当者.Name = "lbl担当者"
        Me.lbl担当者.Size = New System.Drawing.Size(91, 14)
        Me.lbl担当者.TabIndex = 47
        Me.lbl担当者.Text = "担 当 者"
        Me.lbl担当者.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(850, 16)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(109, 19)
        Me.TextBox3.TabIndex = 48
        '
        'lbl清算日時
        '
        Me.lbl清算日時.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl清算日時.Location = New System.Drawing.Point(229, 21)
        Me.lbl清算日時.Name = "lbl清算日時"
        Me.lbl清算日時.Size = New System.Drawing.Size(91, 14)
        Me.lbl清算日時.TabIndex = 45
        Me.lbl清算日時.Text = "清算日時"
        Me.lbl清算日時.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(325, 19)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(109, 19)
        Me.TextBox2.TabIndex = 46
        '
        'lbl端末CD
        '
        Me.lbl端末CD.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl端末CD.Location = New System.Drawing.Point(7, 20)
        Me.lbl端末CD.Name = "lbl端末CD"
        Me.lbl端末CD.Size = New System.Drawing.Size(91, 14)
        Me.lbl端末CD.TabIndex = 43
        Me.lbl端末CD.Text = "端末CD"
        Me.lbl端末CD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(103, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(109, 19)
        Me.TextBox1.TabIndex = 44
        '
        'btn清算取り消し
        '
        Me.btn清算取り消し.Location = New System.Drawing.Point(17, 537)
        Me.btn清算取り消し.Name = "btn清算取り消し"
        Me.btn清算取り消し.Size = New System.Drawing.Size(132, 35)
        Me.btn清算取り消し.TabIndex = 138
        Me.btn清算取り消し.Text = "※ 清 算 取 り 消 し"
        Me.btn清算取り消し.UseVisualStyleBackColor = True
        '
        'grb3
        '
        Me.grb3.Controls.Add(Me.txt金種表)
        Me.grb3.Controls.Add(Me.lbl金種表)
        Me.grb3.Controls.Add(Me.txt1枚数)
        Me.grb3.Controls.Add(Me.txt1en)
        Me.grb3.Controls.Add(Me.lbl1en)
        Me.grb3.Controls.Add(Me.txt5枚数)
        Me.grb3.Controls.Add(Me.txt5en)
        Me.grb3.Controls.Add(Me.lbl5en)
        Me.grb3.Controls.Add(Me.txt10枚数)
        Me.grb3.Controls.Add(Me.txt10en)
        Me.grb3.Controls.Add(Me.lbl10en)
        Me.grb3.Controls.Add(Me.txt50枚数)
        Me.grb3.Controls.Add(Me.txt50en)
        Me.grb3.Controls.Add(Me.lbl50en)
        Me.grb3.Controls.Add(Me.txt100枚数)
        Me.grb3.Controls.Add(Me.txt100en)
        Me.grb3.Controls.Add(Me.lbl100en)
        Me.grb3.Controls.Add(Me.txt500枚数)
        Me.grb3.Controls.Add(Me.txt500en)
        Me.grb3.Controls.Add(Me.lbl500en)
        Me.grb3.Controls.Add(Me.txt1000枚数)
        Me.grb3.Controls.Add(Me.txt1000en)
        Me.grb3.Controls.Add(Me.lbl1000en)
        Me.grb3.Controls.Add(Me.txt2000枚数)
        Me.grb3.Controls.Add(Me.txt2000en)
        Me.grb3.Controls.Add(Me.lbl2000en)
        Me.grb3.Controls.Add(Me.txt5000枚数)
        Me.grb3.Controls.Add(Me.txt5000en)
        Me.grb3.Controls.Add(Me.lbl5000en)
        Me.grb3.Controls.Add(Me.txt10000枚数)
        Me.grb3.Controls.Add(Me.txt10000en)
        Me.grb3.Controls.Add(Me.lbl10000en)
        Me.grb3.Controls.Add(Me.btnEnd)
        Me.grb3.Controls.Add(Me.btnC)
        Me.grb3.Controls.Add(Me.btn9)
        Me.grb3.Controls.Add(Me.btn8)
        Me.grb3.Controls.Add(Me.btn7)
        Me.grb3.Controls.Add(Me.btn6)
        Me.grb3.Controls.Add(Me.btn5)
        Me.grb3.Controls.Add(Me.btn4)
        Me.grb3.Controls.Add(Me.btn3)
        Me.grb3.Controls.Add(Me.btn2)
        Me.grb3.Controls.Add(Me.btn1)
        Me.grb3.Controls.Add(Me.btn0)
        Me.grb3.Controls.Add(Me.btn清算取り消し)
        Me.grb3.Controls.Add(Me.lbl会計集計表)
        Me.grb3.Controls.Add(Me.txt信計3_金額)
        Me.grb3.Controls.Add(Me.lbl釣銭準備金)
        Me.grb3.Controls.Add(Me.txt信計4_金額)
        Me.grb3.Controls.Add(Me.lbl現金預かり)
        Me.grb3.Controls.Add(Me.txt貸計_金額)
        Me.grb3.Controls.Add(Me.txt訂正一括取消_金額)
        Me.grb3.Controls.Add(Me.txtII計釣有_金額)
        Me.grb3.Controls.Add(Me.lbl釣銭支払い)
        Me.grb3.Controls.Add(Me.txtII計クーポン_金額)
        Me.grb3.Controls.Add(Me.txt登録指定取消_金額)
        Me.grb3.Controls.Add(Me.txt現計_金額)
        Me.grb3.Controls.Add(Me.lbl入金)
        Me.grb3.Controls.Add(Me.txtII計釣無_金額)
        Me.grb3.Controls.Add(Me.txt訂正指定取消_金額)
        Me.grb3.Controls.Add(Me.txt信計1_金額)
        Me.grb3.Controls.Add(Me.lbl釣銭回収)
        Me.grb3.Controls.Add(Me.lbl明細値引)
        Me.grb3.Controls.Add(Me.txt取引回数_金額)
        Me.grb3.Controls.Add(Me.txt信計2_金額)
        Me.grb3.Controls.Add(Me.lbl信計2)
        Me.grb3.Controls.Add(Me.lbl返品)
        Me.grb3.Controls.Add(Me.txt取引人数_金額)
        Me.grb3.Controls.Add(Me.txt入金_金額)
        Me.grb3.Controls.Add(Me.lbl信計1)
        Me.grb3.Controls.Add(Me.lbl訂正)
        Me.grb3.Controls.Add(Me.txt登録一括取消_金額)
        Me.grb3.Controls.Add(Me.txt釣銭回収_金額)
        Me.grb3.Controls.Add(Me.lbl現計)
        Me.grb3.Controls.Add(Me.lblハンドル値引)
        Me.grb3.Controls.Add(Me.txtクーポン発行_金額)
        Me.grb3.Controls.Add(Me.txt出金_金額)
        Me.grb3.Controls.Add(Me.lbl現金有り高)
        Me.grb3.Controls.Add(Me.lbl単品値引)
        Me.grb3.Controls.Add(Me.txt領収書発行_金額)
        Me.grb3.Controls.Add(Me.txt釣銭準備金_金額)
        Me.grb3.Controls.Add(Me.lbl出金)
        Me.grb3.Controls.Add(Me.lbl小計割引)
        Me.grb3.Controls.Add(Me.txt両替_金額)
        Me.grb3.Controls.Add(Me.txt現金預かり_金額)
        Me.grb3.Controls.Add(Me.lblⅡ計クーポン)
        Me.grb3.Controls.Add(Me.lbl小計値引)
        Me.grb3.Controls.Add(Me.txt訂正指定取消_件数)
        Me.grb3.Controls.Add(Me.txt釣銭支払い_金額)
        Me.grb3.Controls.Add(Me.lblⅡ計釣無)
        Me.grb3.Controls.Add(Me.lbl明細割引)
        Me.grb3.Controls.Add(Me.txt両替_件数)
        Me.grb3.Controls.Add(Me.txt税抜売上額)
        Me.grb3.Controls.Add(Me.lblⅡ計釣有)
        Me.grb3.Controls.Add(Me.lbl総売上額)
        Me.grb3.Controls.Add(Me.txt取引回数_件数)
        Me.grb3.Controls.Add(Me.txt内軽減消費税)
        Me.grb3.Controls.Add(Me.lbl信計4)
        Me.grb3.Controls.Add(Me.lblクーポン値引)
        Me.grb3.Controls.Add(Me.txt取引人数_件数)
        Me.grb3.Controls.Add(Me.txt外消費税)
        Me.grb3.Controls.Add(Me.lbl信計3)
        Me.grb3.Controls.Add(Me.txt返品_件数)
        Me.grb3.Controls.Add(Me.txt登録一括取消_件数)
        Me.grb3.Controls.Add(Me.txt外軽減消費税)
        Me.grb3.Controls.Add(Me.lbl雑収入)
        Me.grb3.Controls.Add(Me.txt訂正_件数)
        Me.grb3.Controls.Add(Me.txt訂正一括取消_件数)
        Me.grb3.Controls.Add(Me.txt純売上額)
        Me.grb3.Controls.Add(Me.lbl純売上額)
        Me.grb3.Controls.Add(Me.txtハンドル値引_件数)
        Me.grb3.Controls.Add(Me.txt登録指定取消_件数)
        Me.grb3.Controls.Add(Me.txt雑収入)
        Me.grb3.Controls.Add(Me.lbl過不足金)
        Me.grb3.Controls.Add(Me.txt単品値引_件数)
        Me.grb3.Controls.Add(Me.txtクーポン発行_件数)
        Me.grb3.Controls.Add(Me.txt内消費税)
        Me.grb3.Controls.Add(Me.lbl現金外計)
        Me.grb3.Controls.Add(Me.txt小計割引_件数)
        Me.grb3.Controls.Add(Me.txt領収書発行_件数)
        Me.grb3.Controls.Add(Me.txt貸計_件数)
        Me.grb3.Controls.Add(Me.lbl貸計)
        Me.grb3.Controls.Add(Me.txt小計値引_件数)
        Me.grb3.Controls.Add(Me.lbl訂正指定取消)
        Me.grb3.Controls.Add(Me.txt現金外計)
        Me.grb3.Controls.Add(Me.lbl税抜売上額)
        Me.grb3.Controls.Add(Me.txt明細割引_件数)
        Me.grb3.Controls.Add(Me.lbl取引回数)
        Me.grb3.Controls.Add(Me.txt過不足金)
        Me.grb3.Controls.Add(Me.lbl外軽減消費税)
        Me.grb3.Controls.Add(Me.txt明細値引_件数)
        Me.grb3.Controls.Add(Me.lbl取引人数)
        Me.grb3.Controls.Add(Me.txt信計2_件数)
        Me.grb3.Controls.Add(Me.lbl外消費税)
        Me.grb3.Controls.Add(Me.txt総売上額)
        Me.grb3.Controls.Add(Me.lbl登録一括取消)
        Me.grb3.Controls.Add(Me.txt信計3_件数)
        Me.grb3.Controls.Add(Me.lbl内軽減消費税)
        Me.grb3.Controls.Add(Me.txtクーポン値引_件数)
        Me.grb3.Controls.Add(Me.lbl訂正一括取消)
        Me.grb3.Controls.Add(Me.txt信計4_件数)
        Me.grb3.Controls.Add(Me.lbl内消費税)
        Me.grb3.Controls.Add(Me.txt明細値引_金額)
        Me.grb3.Controls.Add(Me.lbl登録指定取消)
        Me.grb3.Controls.Add(Me.txtII計釣有_件数)
        Me.grb3.Controls.Add(Me.txt釣銭支払い_件数)
        Me.grb3.Controls.Add(Me.txt返品_金額)
        Me.grb3.Controls.Add(Me.lblクーポン発行)
        Me.grb3.Controls.Add(Me.txtII計釣無_件数)
        Me.grb3.Controls.Add(Me.txt現金預かり_件数)
        Me.grb3.Controls.Add(Me.txt訂正_金額)
        Me.grb3.Controls.Add(Me.lbl領収書発行)
        Me.grb3.Controls.Add(Me.txtII計クーポン_件数)
        Me.grb3.Controls.Add(Me.txt釣銭準備金_件数)
        Me.grb3.Controls.Add(Me.txt小計割引_金額)
        Me.grb3.Controls.Add(Me.lbl両替)
        Me.grb3.Controls.Add(Me.txt入金_件数)
        Me.grb3.Controls.Add(Me.txt信計1_件数)
        Me.grb3.Controls.Add(Me.txt小計値引_金額)
        Me.grb3.Controls.Add(Me.txt単品値引_金額)
        Me.grb3.Controls.Add(Me.txt釣銭回収_件数)
        Me.grb3.Controls.Add(Me.txt現計_件数)
        Me.grb3.Controls.Add(Me.txt明細割引_金額)
        Me.grb3.Controls.Add(Me.txtハンドル値引_金額)
        Me.grb3.Controls.Add(Me.txt出金_件数)
        Me.grb3.Controls.Add(Me.txt現金有り高)
        Me.grb3.Controls.Add(Me.txtクーポン値引_金額)
        Me.grb3.Location = New System.Drawing.Point(12, 143)
        Me.grb3.Name = "grb3"
        Me.grb3.Size = New System.Drawing.Size(984, 583)
        Me.grb3.TabIndex = 141
        Me.grb3.TabStop = False
        '
        'txt金種表
        '
        Me.txt金種表.Location = New System.Drawing.Point(745, 34)
        Me.txt金種表.Name = "txt金種表"
        Me.txt金種表.ReadOnly = True
        Me.txt金種表.Size = New System.Drawing.Size(233, 19)
        Me.txt金種表.TabIndex = 302
        Me.txt金種表.Text = "0"
        Me.txt金種表.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl金種表
        '
        Me.lbl金種表.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl金種表.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl金種表.Location = New System.Drawing.Point(760, 12)
        Me.lbl金種表.Name = "lbl金種表"
        Me.lbl金種表.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl金種表.Size = New System.Drawing.Size(185, 17)
        Me.lbl金種表.TabIndex = 301
        Me.lbl金種表.Text = "金　種　表"
        Me.lbl金種表.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt1枚数
        '
        Me.txt1枚数.Location = New System.Drawing.Point(923, 295)
        Me.txt1枚数.Name = "txt1枚数"
        Me.txt1枚数.ReadOnly = True
        Me.txt1枚数.Size = New System.Drawing.Size(55, 19)
        Me.txt1枚数.TabIndex = 300
        Me.txt1枚数.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt1en
        '
        Me.txt1en.Location = New System.Drawing.Point(817, 294)
        Me.txt1en.Name = "txt1en"
        Me.txt1en.ReadOnly = True
        Me.txt1en.Size = New System.Drawing.Size(100, 19)
        Me.txt1en.TabIndex = 299
        Me.txt1en.Text = "0"
        Me.txt1en.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl1en
        '
        Me.lbl1en.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl1en.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl1en.Location = New System.Drawing.Point(727, 297)
        Me.lbl1en.Name = "lbl1en"
        Me.lbl1en.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl1en.Size = New System.Drawing.Size(70, 17)
        Me.lbl1en.TabIndex = 298
        Me.lbl1en.Text = "1"
        Me.lbl1en.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt5枚数
        '
        Me.txt5枚数.Location = New System.Drawing.Point(923, 270)
        Me.txt5枚数.Name = "txt5枚数"
        Me.txt5枚数.ReadOnly = True
        Me.txt5枚数.Size = New System.Drawing.Size(55, 19)
        Me.txt5枚数.TabIndex = 297
        Me.txt5枚数.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt5en
        '
        Me.txt5en.Location = New System.Drawing.Point(817, 269)
        Me.txt5en.Name = "txt5en"
        Me.txt5en.ReadOnly = True
        Me.txt5en.Size = New System.Drawing.Size(100, 19)
        Me.txt5en.TabIndex = 296
        Me.txt5en.Text = "0"
        Me.txt5en.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl5en
        '
        Me.lbl5en.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl5en.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl5en.Location = New System.Drawing.Point(727, 272)
        Me.lbl5en.Name = "lbl5en"
        Me.lbl5en.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl5en.Size = New System.Drawing.Size(70, 17)
        Me.lbl5en.TabIndex = 295
        Me.lbl5en.Text = "5"
        Me.lbl5en.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt10枚数
        '
        Me.txt10枚数.Location = New System.Drawing.Point(923, 245)
        Me.txt10枚数.Name = "txt10枚数"
        Me.txt10枚数.ReadOnly = True
        Me.txt10枚数.Size = New System.Drawing.Size(55, 19)
        Me.txt10枚数.TabIndex = 294
        Me.txt10枚数.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt10en
        '
        Me.txt10en.Location = New System.Drawing.Point(817, 244)
        Me.txt10en.Name = "txt10en"
        Me.txt10en.ReadOnly = True
        Me.txt10en.Size = New System.Drawing.Size(100, 19)
        Me.txt10en.TabIndex = 293
        Me.txt10en.Text = "0"
        Me.txt10en.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl10en
        '
        Me.lbl10en.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl10en.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl10en.Location = New System.Drawing.Point(727, 247)
        Me.lbl10en.Name = "lbl10en"
        Me.lbl10en.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl10en.Size = New System.Drawing.Size(70, 17)
        Me.lbl10en.TabIndex = 292
        Me.lbl10en.Text = "10"
        Me.lbl10en.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt50枚数
        '
        Me.txt50枚数.Location = New System.Drawing.Point(923, 220)
        Me.txt50枚数.Name = "txt50枚数"
        Me.txt50枚数.ReadOnly = True
        Me.txt50枚数.Size = New System.Drawing.Size(55, 19)
        Me.txt50枚数.TabIndex = 291
        Me.txt50枚数.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt50en
        '
        Me.txt50en.Location = New System.Drawing.Point(817, 219)
        Me.txt50en.Name = "txt50en"
        Me.txt50en.ReadOnly = True
        Me.txt50en.Size = New System.Drawing.Size(100, 19)
        Me.txt50en.TabIndex = 290
        Me.txt50en.Text = "0"
        Me.txt50en.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl50en
        '
        Me.lbl50en.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl50en.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl50en.Location = New System.Drawing.Point(727, 222)
        Me.lbl50en.Name = "lbl50en"
        Me.lbl50en.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl50en.Size = New System.Drawing.Size(70, 17)
        Me.lbl50en.TabIndex = 289
        Me.lbl50en.Text = "50"
        Me.lbl50en.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt100枚数
        '
        Me.txt100枚数.Location = New System.Drawing.Point(923, 195)
        Me.txt100枚数.Name = "txt100枚数"
        Me.txt100枚数.ReadOnly = True
        Me.txt100枚数.Size = New System.Drawing.Size(55, 19)
        Me.txt100枚数.TabIndex = 288
        Me.txt100枚数.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt100en
        '
        Me.txt100en.Location = New System.Drawing.Point(817, 194)
        Me.txt100en.Name = "txt100en"
        Me.txt100en.ReadOnly = True
        Me.txt100en.Size = New System.Drawing.Size(100, 19)
        Me.txt100en.TabIndex = 287
        Me.txt100en.Text = "0"
        Me.txt100en.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl100en
        '
        Me.lbl100en.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl100en.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl100en.Location = New System.Drawing.Point(727, 197)
        Me.lbl100en.Name = "lbl100en"
        Me.lbl100en.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl100en.Size = New System.Drawing.Size(70, 17)
        Me.lbl100en.TabIndex = 286
        Me.lbl100en.Text = "100"
        Me.lbl100en.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt500枚数
        '
        Me.txt500枚数.Location = New System.Drawing.Point(923, 170)
        Me.txt500枚数.Name = "txt500枚数"
        Me.txt500枚数.ReadOnly = True
        Me.txt500枚数.Size = New System.Drawing.Size(55, 19)
        Me.txt500枚数.TabIndex = 285
        Me.txt500枚数.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt500en
        '
        Me.txt500en.Location = New System.Drawing.Point(817, 169)
        Me.txt500en.Name = "txt500en"
        Me.txt500en.ReadOnly = True
        Me.txt500en.Size = New System.Drawing.Size(100, 19)
        Me.txt500en.TabIndex = 284
        Me.txt500en.Text = "0"
        Me.txt500en.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl500en
        '
        Me.lbl500en.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl500en.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl500en.Location = New System.Drawing.Point(727, 172)
        Me.lbl500en.Name = "lbl500en"
        Me.lbl500en.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl500en.Size = New System.Drawing.Size(70, 17)
        Me.lbl500en.TabIndex = 283
        Me.lbl500en.Text = "500"
        Me.lbl500en.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt1000枚数
        '
        Me.txt1000枚数.Location = New System.Drawing.Point(923, 145)
        Me.txt1000枚数.Name = "txt1000枚数"
        Me.txt1000枚数.ReadOnly = True
        Me.txt1000枚数.Size = New System.Drawing.Size(55, 19)
        Me.txt1000枚数.TabIndex = 282
        Me.txt1000枚数.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt1000en
        '
        Me.txt1000en.Location = New System.Drawing.Point(817, 144)
        Me.txt1000en.Name = "txt1000en"
        Me.txt1000en.ReadOnly = True
        Me.txt1000en.Size = New System.Drawing.Size(100, 19)
        Me.txt1000en.TabIndex = 281
        Me.txt1000en.Text = "0"
        Me.txt1000en.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl1000en
        '
        Me.lbl1000en.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl1000en.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl1000en.Location = New System.Drawing.Point(727, 147)
        Me.lbl1000en.Name = "lbl1000en"
        Me.lbl1000en.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl1000en.Size = New System.Drawing.Size(70, 17)
        Me.lbl1000en.TabIndex = 280
        Me.lbl1000en.Text = "1,000"
        Me.lbl1000en.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt2000枚数
        '
        Me.txt2000枚数.Location = New System.Drawing.Point(923, 120)
        Me.txt2000枚数.Name = "txt2000枚数"
        Me.txt2000枚数.ReadOnly = True
        Me.txt2000枚数.Size = New System.Drawing.Size(55, 19)
        Me.txt2000枚数.TabIndex = 279
        Me.txt2000枚数.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt2000en
        '
        Me.txt2000en.Location = New System.Drawing.Point(817, 119)
        Me.txt2000en.Name = "txt2000en"
        Me.txt2000en.ReadOnly = True
        Me.txt2000en.Size = New System.Drawing.Size(100, 19)
        Me.txt2000en.TabIndex = 278
        Me.txt2000en.Text = "0"
        Me.txt2000en.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl2000en
        '
        Me.lbl2000en.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl2000en.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl2000en.Location = New System.Drawing.Point(727, 122)
        Me.lbl2000en.Name = "lbl2000en"
        Me.lbl2000en.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl2000en.Size = New System.Drawing.Size(70, 17)
        Me.lbl2000en.TabIndex = 277
        Me.lbl2000en.Text = "2,000"
        Me.lbl2000en.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt5000枚数
        '
        Me.txt5000枚数.Location = New System.Drawing.Point(923, 95)
        Me.txt5000枚数.Name = "txt5000枚数"
        Me.txt5000枚数.ReadOnly = True
        Me.txt5000枚数.Size = New System.Drawing.Size(55, 19)
        Me.txt5000枚数.TabIndex = 276
        Me.txt5000枚数.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt5000en
        '
        Me.txt5000en.Location = New System.Drawing.Point(817, 94)
        Me.txt5000en.Name = "txt5000en"
        Me.txt5000en.ReadOnly = True
        Me.txt5000en.Size = New System.Drawing.Size(100, 19)
        Me.txt5000en.TabIndex = 275
        Me.txt5000en.Text = "0"
        Me.txt5000en.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl5000en
        '
        Me.lbl5000en.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl5000en.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl5000en.Location = New System.Drawing.Point(727, 97)
        Me.lbl5000en.Name = "lbl5000en"
        Me.lbl5000en.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl5000en.Size = New System.Drawing.Size(70, 17)
        Me.lbl5000en.TabIndex = 274
        Me.lbl5000en.Text = "5,000"
        Me.lbl5000en.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt10000枚数
        '
        Me.txt10000枚数.Location = New System.Drawing.Point(923, 70)
        Me.txt10000枚数.Name = "txt10000枚数"
        Me.txt10000枚数.ReadOnly = True
        Me.txt10000枚数.Size = New System.Drawing.Size(55, 19)
        Me.txt10000枚数.TabIndex = 273
        Me.txt10000枚数.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt10000en
        '
        Me.txt10000en.Location = New System.Drawing.Point(817, 69)
        Me.txt10000en.Name = "txt10000en"
        Me.txt10000en.ReadOnly = True
        Me.txt10000en.Size = New System.Drawing.Size(100, 19)
        Me.txt10000en.TabIndex = 272
        Me.txt10000en.Text = "0"
        Me.txt10000en.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl10000en
        '
        Me.lbl10000en.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl10000en.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl10000en.Location = New System.Drawing.Point(727, 72)
        Me.lbl10000en.Name = "lbl10000en"
        Me.lbl10000en.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl10000en.Size = New System.Drawing.Size(70, 17)
        Me.lbl10000en.TabIndex = 271
        Me.lbl10000en.Text = "10,000"
        Me.lbl10000en.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnEnd
        '
        Me.btnEnd.BackgroundImage = CType(resources.GetObject("btnEnd.BackgroundImage"), System.Drawing.Image)
        Me.btnEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEnd.FlatAppearance.BorderSize = 0
        Me.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnd.Font = New System.Drawing.Font("メイリオ", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnEnd.Location = New System.Drawing.Point(899, 516)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(71, 66)
        Me.btnEnd.TabIndex = 270
        Me.btnEnd.Tag = "0"
        Me.btnEnd.Text = "OK"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'btnC
        '
        Me.btnC.BackgroundImage = CType(resources.GetObject("btnC.BackgroundImage"), System.Drawing.Image)
        Me.btnC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnC.FlatAppearance.BorderSize = 0
        Me.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnC.Font = New System.Drawing.Font("メイリオ", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btnC.Location = New System.Drawing.Point(822, 516)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(71, 66)
        Me.btnC.TabIndex = 269
        Me.btnC.Tag = "0"
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = False
        '
        'btn9
        '
        Me.btn9.BackgroundImage = CType(resources.GetObject("btn9.BackgroundImage"), System.Drawing.Image)
        Me.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn9.FlatAppearance.BorderSize = 0
        Me.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn9.Font = New System.Drawing.Font("メイリオ", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btn9.ForeColor = System.Drawing.Color.White
        Me.btn9.Location = New System.Drawing.Point(899, 314)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(71, 66)
        Me.btn9.TabIndex = 268
        Me.btn9.Tag = "0"
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = False
        '
        'btn8
        '
        Me.btn8.BackgroundImage = CType(resources.GetObject("btn8.BackgroundImage"), System.Drawing.Image)
        Me.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn8.FlatAppearance.BorderSize = 0
        Me.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn8.Font = New System.Drawing.Font("メイリオ", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btn8.ForeColor = System.Drawing.Color.White
        Me.btn8.Location = New System.Drawing.Point(822, 314)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(71, 66)
        Me.btn8.TabIndex = 267
        Me.btn8.Tag = "0"
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = False
        '
        'btn7
        '
        Me.btn7.BackgroundImage = CType(resources.GetObject("btn7.BackgroundImage"), System.Drawing.Image)
        Me.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn7.FlatAppearance.BorderSize = 0
        Me.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn7.Font = New System.Drawing.Font("メイリオ", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btn7.ForeColor = System.Drawing.Color.White
        Me.btn7.Location = New System.Drawing.Point(745, 314)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(71, 66)
        Me.btn7.TabIndex = 266
        Me.btn7.Tag = "0"
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = False
        '
        'btn6
        '
        Me.btn6.BackgroundImage = CType(resources.GetObject("btn6.BackgroundImage"), System.Drawing.Image)
        Me.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn6.FlatAppearance.BorderSize = 0
        Me.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn6.Font = New System.Drawing.Font("メイリオ", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btn6.ForeColor = System.Drawing.Color.White
        Me.btn6.Location = New System.Drawing.Point(899, 381)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(71, 66)
        Me.btn6.TabIndex = 265
        Me.btn6.Tag = "0"
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = False
        '
        'btn5
        '
        Me.btn5.BackgroundImage = CType(resources.GetObject("btn5.BackgroundImage"), System.Drawing.Image)
        Me.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn5.FlatAppearance.BorderSize = 0
        Me.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn5.Font = New System.Drawing.Font("メイリオ", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btn5.ForeColor = System.Drawing.Color.White
        Me.btn5.Location = New System.Drawing.Point(822, 381)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(71, 66)
        Me.btn5.TabIndex = 264
        Me.btn5.Tag = "0"
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.BackgroundImage = CType(resources.GetObject("btn4.BackgroundImage"), System.Drawing.Image)
        Me.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn4.FlatAppearance.BorderSize = 0
        Me.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn4.Font = New System.Drawing.Font("メイリオ", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btn4.ForeColor = System.Drawing.Color.White
        Me.btn4.Location = New System.Drawing.Point(745, 381)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(71, 66)
        Me.btn4.TabIndex = 263
        Me.btn4.Tag = "0"
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackgroundImage = CType(resources.GetObject("btn3.BackgroundImage"), System.Drawing.Image)
        Me.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn3.FlatAppearance.BorderSize = 0
        Me.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn3.Font = New System.Drawing.Font("メイリオ", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btn3.ForeColor = System.Drawing.Color.White
        Me.btn3.Location = New System.Drawing.Point(899, 449)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(71, 66)
        Me.btn3.TabIndex = 262
        Me.btn3.Tag = "0"
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackgroundImage = CType(resources.GetObject("btn2.BackgroundImage"), System.Drawing.Image)
        Me.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn2.FlatAppearance.BorderSize = 0
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2.Font = New System.Drawing.Font("メイリオ", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btn2.ForeColor = System.Drawing.Color.White
        Me.btn2.Location = New System.Drawing.Point(822, 449)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(71, 66)
        Me.btn2.TabIndex = 261
        Me.btn2.Tag = "0"
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn1
        '
        Me.btn1.BackgroundImage = CType(resources.GetObject("btn1.BackgroundImage"), System.Drawing.Image)
        Me.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn1.FlatAppearance.BorderSize = 0
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1.Font = New System.Drawing.Font("メイリオ", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btn1.ForeColor = System.Drawing.Color.White
        Me.btn1.Location = New System.Drawing.Point(745, 449)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(71, 66)
        Me.btn1.TabIndex = 260
        Me.btn1.Tag = "0"
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'btn0
        '
        Me.btn0.BackgroundImage = CType(resources.GetObject("btn0.BackgroundImage"), System.Drawing.Image)
        Me.btn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn0.FlatAppearance.BorderSize = 0
        Me.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn0.Font = New System.Drawing.Font("メイリオ", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btn0.ForeColor = System.Drawing.Color.White
        Me.btn0.Location = New System.Drawing.Point(745, 516)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(71, 66)
        Me.btn0.TabIndex = 259
        Me.btn0.Tag = "0"
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = False
        '
        'frm600精算処理
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.grb3)
        Me.Controls.Add(Me.grb2)
        Me.Controls.Add(Me.grb1)
        Me.Controls.Add(Me.lbl説明文)
        Me.Name = "frm600精算処理"
        Me.RightToLeftLayout = True
        Me.grb1.ResumeLayout(False)
        Me.grb1.PerformLayout()
        Me.grb2.ResumeLayout(False)
        Me.grb2.PerformLayout()
        Me.grb3.ResumeLayout(False)
        Me.grb3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn個別未収清算 As Button
    Friend WithEvents btn清算開始 As Button
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
    Friend WithEvents lbl説明文 As Label
    Friend WithEvents grb1 As GroupBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents grb2 As GroupBox
    Friend WithEvents lbl担当者 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lbl清算日時 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lbl端末CD As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn清算取り消し As Button
    Friend WithEvents grb3 As GroupBox
    Friend WithEvents txt金種表 As TextBox
    Friend WithEvents lbl金種表 As Label
    Friend WithEvents txt1枚数 As TextBox
    Friend WithEvents txt1en As TextBox
    Friend WithEvents lbl1en As Label
    Friend WithEvents txt5枚数 As TextBox
    Friend WithEvents txt5en As TextBox
    Friend WithEvents lbl5en As Label
    Friend WithEvents txt10枚数 As TextBox
    Friend WithEvents txt10en As TextBox
    Friend WithEvents lbl10en As Label
    Friend WithEvents txt50枚数 As TextBox
    Friend WithEvents txt50en As TextBox
    Friend WithEvents lbl50en As Label
    Friend WithEvents txt100枚数 As TextBox
    Friend WithEvents txt100en As TextBox
    Friend WithEvents lbl100en As Label
    Friend WithEvents txt500枚数 As TextBox
    Friend WithEvents txt500en As TextBox
    Friend WithEvents lbl500en As Label
    Friend WithEvents txt1000枚数 As TextBox
    Friend WithEvents txt1000en As TextBox
    Friend WithEvents lbl1000en As Label
    Friend WithEvents txt2000枚数 As TextBox
    Friend WithEvents txt2000en As TextBox
    Friend WithEvents lbl2000en As Label
    Friend WithEvents txt5000枚数 As TextBox
    Friend WithEvents txt5000en As TextBox
    Friend WithEvents lbl5000en As Label
    Friend WithEvents txt10000枚数 As TextBox
    Friend WithEvents txt10000en As TextBox
    Friend WithEvents lbl10000en As Label
    Friend WithEvents btnEnd As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn0 As Button
End Class
