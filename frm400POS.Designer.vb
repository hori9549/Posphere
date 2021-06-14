<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm400POS
    'Inherits System.Windows.Forms.Form
    Inherits frmベース

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm400POS))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn分類4 = New System.Windows.Forms.Button()
        Me.dgv明細 = New System.Windows.Forms.DataGridView()
        Me.colNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colJAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col区分 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col取引名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col数量 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col単価 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col金額 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col消費税率 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col消費税 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button50 = New System.Windows.Forms.Button()
        Me.txt客層1 = New System.Windows.Forms.TextBox()
        Me.txt客層2 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.txt人数 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.btn両替 = New System.Windows.Forms.Button()
        Me.btn値引 = New System.Windows.Forms.Button()
        Me.btn担当 = New System.Windows.Forms.Button()
        Me.btn領収 = New System.Windows.Forms.Button()
        Me.btn品目1 = New System.Windows.Forms.Button()
        Me.btn品目36 = New System.Windows.Forms.Button()
        Me.btn品目35 = New System.Windows.Forms.Button()
        Me.btn品目34 = New System.Windows.Forms.Button()
        Me.btn品目33 = New System.Windows.Forms.Button()
        Me.btn品目32 = New System.Windows.Forms.Button()
        Me.btn品目31 = New System.Windows.Forms.Button()
        Me.btn品目30 = New System.Windows.Forms.Button()
        Me.btn品目29 = New System.Windows.Forms.Button()
        Me.btn品目28 = New System.Windows.Forms.Button()
        Me.btn品目27 = New System.Windows.Forms.Button()
        Me.btn品目26 = New System.Windows.Forms.Button()
        Me.btn品目25 = New System.Windows.Forms.Button()
        Me.btn品目24 = New System.Windows.Forms.Button()
        Me.btn品目23 = New System.Windows.Forms.Button()
        Me.btn品目22 = New System.Windows.Forms.Button()
        Me.btn品目21 = New System.Windows.Forms.Button()
        Me.btn品目20 = New System.Windows.Forms.Button()
        Me.btn品目19 = New System.Windows.Forms.Button()
        Me.btn品目18 = New System.Windows.Forms.Button()
        Me.btn品目17 = New System.Windows.Forms.Button()
        Me.btn品目16 = New System.Windows.Forms.Button()
        Me.btn品目15 = New System.Windows.Forms.Button()
        Me.btn品目14 = New System.Windows.Forms.Button()
        Me.btn品目13 = New System.Windows.Forms.Button()
        Me.btn品目12 = New System.Windows.Forms.Button()
        Me.btn品目11 = New System.Windows.Forms.Button()
        Me.btn品目10 = New System.Windows.Forms.Button()
        Me.btn品目9 = New System.Windows.Forms.Button()
        Me.btn品目8 = New System.Windows.Forms.Button()
        Me.btn品目7 = New System.Windows.Forms.Button()
        Me.btn品目6 = New System.Windows.Forms.Button()
        Me.btn品目5 = New System.Windows.Forms.Button()
        Me.btn品目4 = New System.Windows.Forms.Button()
        Me.btn品目3 = New System.Windows.Forms.Button()
        Me.btn品目2 = New System.Windows.Forms.Button()
        Me.btnN = New System.Windows.Forms.Button()
        Me.btnNN = New System.Windows.Forms.Button()
        Me.btnBB = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.btn分類1 = New System.Windows.Forms.Button()
        Me.btn分類2 = New System.Windows.Forms.Button()
        Me.btn分類3 = New System.Windows.Forms.Button()
        Me.Button64 = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssl時間 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssl担当者1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssl担当者2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslOES = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.btn割込 = New System.Windows.Forms.Button()
        Me.btn登録ステータス = New System.Windows.Forms.Button()
        Me.btn返品 = New System.Windows.Forms.Button()
        Me.btn指定取消 = New System.Windows.Forms.Button()
        Me.btn一括取消 = New System.Windows.Forms.Button()
        Me.btnJAN = New System.Windows.Forms.Button()
        Me.btnS = New System.Windows.Forms.Button()
        Me.btnF1 = New System.Windows.Forms.Button()
        Me.btnF2 = New System.Windows.Forms.Button()
        Me.btnF3 = New System.Windows.Forms.Button()
        Me.btnF4 = New System.Windows.Forms.Button()
        Me.btnF5 = New System.Windows.Forms.Button()
        Me.btnM1 = New System.Windows.Forms.Button()
        Me.btnM2 = New System.Windows.Forms.Button()
        Me.btnM3 = New System.Windows.Forms.Button()
        Me.btnM4 = New System.Windows.Forms.Button()
        Me.btnM5 = New System.Windows.Forms.Button()
        Me.btnメニュー = New System.Windows.Forms.Button()
        Me.txtステータス = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btn個 = New System.Windows.Forms.Button()
        Me.btn小計 = New System.Windows.Forms.Button()
        Me.btn単価変更 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn00 = New System.Windows.Forms.Button()
        Me.btn000 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.txt入力 = New System.Windows.Forms.TextBox()
        Me.btn下 = New System.Windows.Forms.Button()
        Me.btn上 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button36 = New System.Windows.Forms.Button()
        Me.Button37 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgv明細, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn分類4
        '
        Me.btn分類4.BackgroundImage = CType(resources.GetObject("btn分類4.BackgroundImage"), System.Drawing.Image)
        Me.btn分類4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn分類4.FlatAppearance.BorderSize = 0
        Me.btn分類4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn分類4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn分類4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn分類4.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn分類4.Location = New System.Drawing.Point(442, 321)
        Me.btn分類4.Name = "btn分類4"
        Me.btn分類4.Size = New System.Drawing.Size(110, 60)
        Me.btn分類4.TabIndex = 49
        Me.btn分類4.Text = "分類4"
        Me.btn分類4.UseVisualStyleBackColor = False
        '
        'dgv明細
        '
        Me.dgv明細.AllowUserToAddRows = False
        Me.dgv明細.AllowUserToDeleteRows = False
        Me.dgv明細.AllowUserToResizeColumns = False
        Me.dgv明細.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv明細.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv明細.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv明細.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNo, Me.colJAN, Me.col区分, Me.col取引名, Me.col数量, Me.col単価, Me.col金額, Me.col消費税率, Me.col消費税})
        Me.dgv明細.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgv明細.Location = New System.Drawing.Point(2, 2)
        Me.dgv明細.Name = "dgv明細"
        Me.dgv明細.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("MS UI Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv明細.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgv明細.RowHeadersVisible = False
        DataGridViewCellStyle9.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.dgv明細.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgv明細.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("メイリオ", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.dgv明細.RowTemplate.Height = 40
        Me.dgv明細.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv明細.Size = New System.Drawing.Size(657, 315)
        Me.dgv明細.TabIndex = 53
        '
        'colNo
        '
        Me.colNo.DataPropertyName = "No"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colNo.DefaultCellStyle = DataGridViewCellStyle2
        Me.colNo.HeaderText = "No"
        Me.colNo.Name = "colNo"
        Me.colNo.ReadOnly = True
        Me.colNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colNo.Width = 40
        '
        'colJAN
        '
        Me.colJAN.DataPropertyName = "JAN"
        Me.colJAN.HeaderText = "JAN"
        Me.colJAN.Name = "colJAN"
        Me.colJAN.ReadOnly = True
        Me.colJAN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colJAN.Visible = False
        '
        'col区分
        '
        Me.col区分.DataPropertyName = "区分"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col区分.DefaultCellStyle = DataGridViewCellStyle3
        Me.col区分.HeaderText = "区分"
        Me.col区分.Name = "col区分"
        Me.col区分.ReadOnly = True
        Me.col区分.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.col区分.Width = 70
        '
        'col取引名
        '
        Me.col取引名.DataPropertyName = "取引名"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col取引名.DefaultCellStyle = DataGridViewCellStyle4
        Me.col取引名.HeaderText = "取引名"
        Me.col取引名.Name = "col取引名"
        Me.col取引名.ReadOnly = True
        Me.col取引名.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.col取引名.Width = 200
        '
        'col数量
        '
        Me.col数量.DataPropertyName = "数量"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "#,0"
        Me.col数量.DefaultCellStyle = DataGridViewCellStyle5
        Me.col数量.HeaderText = "数量"
        Me.col数量.Name = "col数量"
        Me.col数量.ReadOnly = True
        Me.col数量.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.col数量.Width = 80
        '
        'col単価
        '
        Me.col単価.DataPropertyName = "単価"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "#,0"
        Me.col単価.DefaultCellStyle = DataGridViewCellStyle6
        Me.col単価.HeaderText = "単価"
        Me.col単価.Name = "col単価"
        Me.col単価.ReadOnly = True
        Me.col単価.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.col単価.Width = 90
        '
        'col金額
        '
        Me.col金額.DataPropertyName = "金額"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "#,0"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.col金額.DefaultCellStyle = DataGridViewCellStyle7
        Me.col金額.HeaderText = "金額"
        Me.col金額.Name = "col金額"
        Me.col金額.ReadOnly = True
        Me.col金額.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.col金額.Width = 130
        '
        'col消費税率
        '
        Me.col消費税率.DataPropertyName = "消費税率"
        Me.col消費税率.HeaderText = "消費税率"
        Me.col消費税率.Name = "col消費税率"
        Me.col消費税率.ReadOnly = True
        Me.col消費税率.Visible = False
        '
        'col消費税
        '
        Me.col消費税.DataPropertyName = "消費税"
        Me.col消費税.HeaderText = "消費税"
        Me.col消費税.Name = "col消費税"
        Me.col消費税.ReadOnly = True
        Me.col消費税.Visible = False
        '
        'Button50
        '
        Me.Button50.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button50.Font = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button50.Location = New System.Drawing.Point(138, 60)
        Me.Button50.Name = "Button50"
        Me.Button50.Size = New System.Drawing.Size(60, 50)
        Me.Button50.TabIndex = 61
        Me.Button50.Tag = "T"
        Me.Button50.Text = "ﾃｰﾌﾞﾙ"
        Me.Button50.UseVisualStyleBackColor = False
        Me.Button50.Visible = False
        '
        'txt客層1
        '
        Me.txt客層1.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt客層1.Location = New System.Drawing.Point(12, 12)
        Me.txt客層1.Name = "txt客層1"
        Me.txt客層1.Size = New System.Drawing.Size(120, 25)
        Me.txt客層1.TabIndex = 62
        Me.txt客層1.Text = "客層1"
        Me.txt客層1.Visible = False
        '
        'txt客層2
        '
        Me.txt客層2.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt客層2.Location = New System.Drawing.Point(12, 36)
        Me.txt客層2.Name = "txt客層2"
        Me.txt客層2.Size = New System.Drawing.Size(120, 25)
        Me.txt客層2.TabIndex = 64
        Me.txt客層2.Text = "客層2"
        Me.txt客層2.Visible = False
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox7.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox7.ForeColor = System.Drawing.Color.White
        Me.TextBox7.Location = New System.Drawing.Point(199, 13)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(88, 25)
        Me.TextBox7.TabIndex = 68
        Me.TextBox7.Text = "利用人数"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox7.Visible = False
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox8.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox8.ForeColor = System.Drawing.Color.White
        Me.TextBox8.Location = New System.Drawing.Point(199, 60)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(88, 25)
        Me.TextBox8.TabIndex = 69
        Me.TextBox8.Text = "テーブル"
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox8.Visible = False
        '
        'txt人数
        '
        Me.txt人数.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt人数.Location = New System.Drawing.Point(199, 37)
        Me.txt人数.Name = "txt人数"
        Me.txt人数.Size = New System.Drawing.Size(88, 25)
        Me.txt人数.TabIndex = 70
        Me.txt人数.Text = "人数"
        Me.txt人数.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt人数.Visible = False
        '
        'TextBox14
        '
        Me.TextBox14.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox14.Location = New System.Drawing.Point(199, 84)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(88, 25)
        Me.TextBox14.TabIndex = 73
        Me.TextBox14.Visible = False
        '
        'btn両替
        '
        Me.btn両替.BackgroundImage = CType(resources.GetObject("btn両替.BackgroundImage"), System.Drawing.Image)
        Me.btn両替.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn両替.FlatAppearance.BorderSize = 0
        Me.btn両替.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn両替.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn両替.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn両替.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn両替.Location = New System.Drawing.Point(737, 261)
        Me.btn両替.Name = "btn両替"
        Me.btn両替.Size = New System.Drawing.Size(70, 60)
        Me.btn両替.TabIndex = 175
        Me.btn両替.Text = "両替"
        Me.btn両替.UseVisualStyleBackColor = False
        '
        'btn値引
        '
        Me.btn値引.BackgroundImage = CType(resources.GetObject("btn値引.BackgroundImage"), System.Drawing.Image)
        Me.btn値引.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn値引.FlatAppearance.BorderSize = 0
        Me.btn値引.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn値引.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn値引.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn値引.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn値引.Location = New System.Drawing.Point(667, 200)
        Me.btn値引.Name = "btn値引"
        Me.btn値引.Size = New System.Drawing.Size(70, 60)
        Me.btn値引.TabIndex = 174
        Me.btn値引.Text = "値引"
        Me.btn値引.UseVisualStyleBackColor = False
        '
        'btn担当
        '
        Me.btn担当.BackgroundImage = CType(resources.GetObject("btn担当.BackgroundImage"), System.Drawing.Image)
        Me.btn担当.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn担当.FlatAppearance.BorderSize = 0
        Me.btn担当.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn担当.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn担当.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn担当.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn担当.Location = New System.Drawing.Point(877, 6)
        Me.btn担当.Name = "btn担当"
        Me.btn担当.Size = New System.Drawing.Size(70, 60)
        Me.btn担当.TabIndex = 178
        Me.btn担当.Text = "担当"
        Me.btn担当.UseVisualStyleBackColor = False
        '
        'btn領収
        '
        Me.btn領収.BackgroundImage = CType(resources.GetObject("btn領収.BackgroundImage"), System.Drawing.Image)
        Me.btn領収.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn領収.FlatAppearance.BorderSize = 0
        Me.btn領収.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn領収.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn領収.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn領収.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn領収.Location = New System.Drawing.Point(667, 261)
        Me.btn領収.Name = "btn領収"
        Me.btn領収.Size = New System.Drawing.Size(70, 60)
        Me.btn領収.TabIndex = 176
        Me.btn領収.Text = "領収"
        Me.btn領収.UseVisualStyleBackColor = False
        '
        'btn品目1
        '
        Me.btn品目1.BackgroundImage = CType(resources.GetObject("btn品目1.BackgroundImage"), System.Drawing.Image)
        Me.btn品目1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目1.FlatAppearance.BorderSize = 0
        Me.btn品目1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目1.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目1.Image = CType(resources.GetObject("btn品目1.Image"), System.Drawing.Image)
        Me.btn品目1.Location = New System.Drawing.Point(2, 382)
        Me.btn品目1.Name = "btn品目1"
        Me.btn品目1.Size = New System.Drawing.Size(110, 60)
        Me.btn品目1.TabIndex = 59
        Me.btn品目1.Tag = "1"
        Me.btn品目1.Text = "商品1あああ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1000"
        Me.btn品目1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目1.UseVisualStyleBackColor = False
        '
        'btn品目36
        '
        Me.btn品目36.BackgroundImage = CType(resources.GetObject("btn品目36.BackgroundImage"), System.Drawing.Image)
        Me.btn品目36.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目36.FlatAppearance.BorderSize = 0
        Me.btn品目36.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目36.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目36.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目36.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目36.Location = New System.Drawing.Point(551, 682)
        Me.btn品目36.Name = "btn品目36"
        Me.btn品目36.Size = New System.Drawing.Size(110, 60)
        Me.btn品目36.TabIndex = 94
        Me.btn品目36.Text = "商品" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1000"
        Me.btn品目36.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目36.UseVisualStyleBackColor = False
        '
        'btn品目35
        '
        Me.btn品目35.BackgroundImage = CType(resources.GetObject("btn品目35.BackgroundImage"), System.Drawing.Image)
        Me.btn品目35.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目35.FlatAppearance.BorderSize = 0
        Me.btn品目35.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目35.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目35.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目35.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目35.Location = New System.Drawing.Point(441, 682)
        Me.btn品目35.Name = "btn品目35"
        Me.btn品目35.Size = New System.Drawing.Size(110, 60)
        Me.btn品目35.TabIndex = 93
        Me.btn品目35.Text = "商品" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1000"
        Me.btn品目35.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目35.UseVisualStyleBackColor = False
        '
        'btn品目34
        '
        Me.btn品目34.BackgroundImage = CType(resources.GetObject("btn品目34.BackgroundImage"), System.Drawing.Image)
        Me.btn品目34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目34.FlatAppearance.BorderSize = 0
        Me.btn品目34.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目34.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目34.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目34.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目34.Location = New System.Drawing.Point(331, 682)
        Me.btn品目34.Name = "btn品目34"
        Me.btn品目34.Size = New System.Drawing.Size(110, 60)
        Me.btn品目34.TabIndex = 92
        Me.btn品目34.Text = "商品" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1000"
        Me.btn品目34.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目34.UseVisualStyleBackColor = False
        '
        'btn品目33
        '
        Me.btn品目33.BackgroundImage = CType(resources.GetObject("btn品目33.BackgroundImage"), System.Drawing.Image)
        Me.btn品目33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目33.FlatAppearance.BorderSize = 0
        Me.btn品目33.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目33.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目33.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目33.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目33.Location = New System.Drawing.Point(221, 682)
        Me.btn品目33.Name = "btn品目33"
        Me.btn品目33.Size = New System.Drawing.Size(110, 60)
        Me.btn品目33.TabIndex = 91
        Me.btn品目33.Text = "商品" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1000"
        Me.btn品目33.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目33.UseVisualStyleBackColor = False
        '
        'btn品目32
        '
        Me.btn品目32.BackgroundImage = CType(resources.GetObject("btn品目32.BackgroundImage"), System.Drawing.Image)
        Me.btn品目32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目32.FlatAppearance.BorderSize = 0
        Me.btn品目32.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目32.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目32.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目32.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目32.Location = New System.Drawing.Point(111, 682)
        Me.btn品目32.Name = "btn品目32"
        Me.btn品目32.Size = New System.Drawing.Size(110, 60)
        Me.btn品目32.TabIndex = 90
        Me.btn品目32.Text = "商品" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1000"
        Me.btn品目32.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目32.UseVisualStyleBackColor = False
        '
        'btn品目31
        '
        Me.btn品目31.BackgroundImage = CType(resources.GetObject("btn品目31.BackgroundImage"), System.Drawing.Image)
        Me.btn品目31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目31.FlatAppearance.BorderSize = 0
        Me.btn品目31.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目31.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目31.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目31.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目31.Location = New System.Drawing.Point(1, 682)
        Me.btn品目31.Name = "btn品目31"
        Me.btn品目31.Size = New System.Drawing.Size(110, 60)
        Me.btn品目31.TabIndex = 89
        Me.btn品目31.Text = "商品" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1000"
        Me.btn品目31.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目31.UseVisualStyleBackColor = False
        '
        'btn品目30
        '
        Me.btn品目30.BackgroundImage = CType(resources.GetObject("btn品目30.BackgroundImage"), System.Drawing.Image)
        Me.btn品目30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目30.FlatAppearance.BorderSize = 0
        Me.btn品目30.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目30.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目30.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目30.Location = New System.Drawing.Point(551, 622)
        Me.btn品目30.Name = "btn品目30"
        Me.btn品目30.Size = New System.Drawing.Size(110, 60)
        Me.btn品目30.TabIndex = 88
        Me.btn品目30.Text = "商品" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1000"
        Me.btn品目30.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目30.UseVisualStyleBackColor = False
        '
        'btn品目29
        '
        Me.btn品目29.BackgroundImage = CType(resources.GetObject("btn品目29.BackgroundImage"), System.Drawing.Image)
        Me.btn品目29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目29.FlatAppearance.BorderSize = 0
        Me.btn品目29.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目29.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目29.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目29.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目29.Location = New System.Drawing.Point(441, 622)
        Me.btn品目29.Name = "btn品目29"
        Me.btn品目29.Size = New System.Drawing.Size(110, 60)
        Me.btn品目29.TabIndex = 87
        Me.btn品目29.Text = "商品" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1000"
        Me.btn品目29.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目29.UseVisualStyleBackColor = False
        '
        'btn品目28
        '
        Me.btn品目28.BackgroundImage = CType(resources.GetObject("btn品目28.BackgroundImage"), System.Drawing.Image)
        Me.btn品目28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目28.FlatAppearance.BorderSize = 0
        Me.btn品目28.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目28.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目28.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目28.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目28.Location = New System.Drawing.Point(331, 622)
        Me.btn品目28.Name = "btn品目28"
        Me.btn品目28.Size = New System.Drawing.Size(110, 60)
        Me.btn品目28.TabIndex = 86
        Me.btn品目28.Text = "商品" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1000"
        Me.btn品目28.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目28.UseVisualStyleBackColor = False
        '
        'btn品目27
        '
        Me.btn品目27.BackgroundImage = CType(resources.GetObject("btn品目27.BackgroundImage"), System.Drawing.Image)
        Me.btn品目27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目27.FlatAppearance.BorderSize = 0
        Me.btn品目27.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目27.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目27.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目27.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目27.Location = New System.Drawing.Point(221, 622)
        Me.btn品目27.Name = "btn品目27"
        Me.btn品目27.Size = New System.Drawing.Size(110, 60)
        Me.btn品目27.TabIndex = 85
        Me.btn品目27.Text = "商品" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1000"
        Me.btn品目27.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目27.UseVisualStyleBackColor = False
        '
        'btn品目26
        '
        Me.btn品目26.BackgroundImage = CType(resources.GetObject("btn品目26.BackgroundImage"), System.Drawing.Image)
        Me.btn品目26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目26.FlatAppearance.BorderSize = 0
        Me.btn品目26.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目26.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目26.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目26.Location = New System.Drawing.Point(111, 622)
        Me.btn品目26.Name = "btn品目26"
        Me.btn品目26.Size = New System.Drawing.Size(110, 60)
        Me.btn品目26.TabIndex = 84
        Me.btn品目26.Text = "商品" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1000"
        Me.btn品目26.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目26.UseVisualStyleBackColor = False
        '
        'btn品目25
        '
        Me.btn品目25.BackgroundImage = CType(resources.GetObject("btn品目25.BackgroundImage"), System.Drawing.Image)
        Me.btn品目25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目25.FlatAppearance.BorderSize = 0
        Me.btn品目25.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目25.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目25.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目25.Location = New System.Drawing.Point(1, 622)
        Me.btn品目25.Name = "btn品目25"
        Me.btn品目25.Size = New System.Drawing.Size(110, 60)
        Me.btn品目25.TabIndex = 83
        Me.btn品目25.Text = "商品" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1000"
        Me.btn品目25.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目25.UseVisualStyleBackColor = False
        '
        'btn品目24
        '
        Me.btn品目24.BackgroundImage = CType(resources.GetObject("btn品目24.BackgroundImage"), System.Drawing.Image)
        Me.btn品目24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目24.FlatAppearance.BorderSize = 0
        Me.btn品目24.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目24.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目24.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目24.Location = New System.Drawing.Point(551, 562)
        Me.btn品目24.Name = "btn品目24"
        Me.btn品目24.Size = New System.Drawing.Size(110, 60)
        Me.btn品目24.TabIndex = 82
        Me.btn品目24.Text = "商品" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1000"
        Me.btn品目24.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目24.UseVisualStyleBackColor = False
        '
        'btn品目23
        '
        Me.btn品目23.BackgroundImage = CType(resources.GetObject("btn品目23.BackgroundImage"), System.Drawing.Image)
        Me.btn品目23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目23.FlatAppearance.BorderSize = 0
        Me.btn品目23.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目23.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目23.Location = New System.Drawing.Point(441, 562)
        Me.btn品目23.Name = "btn品目23"
        Me.btn品目23.Size = New System.Drawing.Size(110, 60)
        Me.btn品目23.TabIndex = 81
        Me.btn品目23.Text = "商品" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1000"
        Me.btn品目23.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目23.UseVisualStyleBackColor = False
        '
        'btn品目22
        '
        Me.btn品目22.BackgroundImage = CType(resources.GetObject("btn品目22.BackgroundImage"), System.Drawing.Image)
        Me.btn品目22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目22.FlatAppearance.BorderSize = 0
        Me.btn品目22.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目22.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目22.Location = New System.Drawing.Point(331, 562)
        Me.btn品目22.Name = "btn品目22"
        Me.btn品目22.Size = New System.Drawing.Size(110, 60)
        Me.btn品目22.TabIndex = 80
        Me.btn品目22.Text = "商品" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1000"
        Me.btn品目22.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目22.UseVisualStyleBackColor = False
        '
        'btn品目21
        '
        Me.btn品目21.BackgroundImage = CType(resources.GetObject("btn品目21.BackgroundImage"), System.Drawing.Image)
        Me.btn品目21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目21.FlatAppearance.BorderSize = 0
        Me.btn品目21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目21.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目21.Location = New System.Drawing.Point(221, 562)
        Me.btn品目21.Name = "btn品目21"
        Me.btn品目21.Size = New System.Drawing.Size(110, 60)
        Me.btn品目21.TabIndex = 79
        Me.btn品目21.Text = "商品" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1000"
        Me.btn品目21.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目21.UseVisualStyleBackColor = False
        '
        'btn品目20
        '
        Me.btn品目20.BackgroundImage = CType(resources.GetObject("btn品目20.BackgroundImage"), System.Drawing.Image)
        Me.btn品目20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目20.FlatAppearance.BorderSize = 0
        Me.btn品目20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目20.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目20.Location = New System.Drawing.Point(111, 562)
        Me.btn品目20.Name = "btn品目20"
        Me.btn品目20.Size = New System.Drawing.Size(110, 60)
        Me.btn品目20.TabIndex = 78
        Me.btn品目20.Text = "商品" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1000"
        Me.btn品目20.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目20.UseVisualStyleBackColor = False
        '
        'btn品目19
        '
        Me.btn品目19.BackgroundImage = CType(resources.GetObject("btn品目19.BackgroundImage"), System.Drawing.Image)
        Me.btn品目19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目19.FlatAppearance.BorderSize = 0
        Me.btn品目19.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目19.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目19.Location = New System.Drawing.Point(1, 562)
        Me.btn品目19.Name = "btn品目19"
        Me.btn品目19.Size = New System.Drawing.Size(110, 60)
        Me.btn品目19.TabIndex = 77
        Me.btn品目19.Text = "商品" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1000"
        Me.btn品目19.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目19.UseVisualStyleBackColor = False
        '
        'btn品目18
        '
        Me.btn品目18.BackgroundImage = CType(resources.GetObject("btn品目18.BackgroundImage"), System.Drawing.Image)
        Me.btn品目18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目18.FlatAppearance.BorderSize = 0
        Me.btn品目18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目18.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目18.Location = New System.Drawing.Point(551, 502)
        Me.btn品目18.Name = "btn品目18"
        Me.btn品目18.Size = New System.Drawing.Size(110, 60)
        Me.btn品目18.TabIndex = 76
        Me.btn品目18.Text = "商品" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1000"
        Me.btn品目18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目18.UseVisualStyleBackColor = False
        '
        'btn品目17
        '
        Me.btn品目17.BackgroundImage = CType(resources.GetObject("btn品目17.BackgroundImage"), System.Drawing.Image)
        Me.btn品目17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目17.FlatAppearance.BorderSize = 0
        Me.btn品目17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目17.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目17.Location = New System.Drawing.Point(441, 502)
        Me.btn品目17.Name = "btn品目17"
        Me.btn品目17.Size = New System.Drawing.Size(110, 60)
        Me.btn品目17.TabIndex = 75
        Me.btn品目17.Text = "商品" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1000"
        Me.btn品目17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目17.UseVisualStyleBackColor = False
        '
        'btn品目16
        '
        Me.btn品目16.BackgroundImage = CType(resources.GetObject("btn品目16.BackgroundImage"), System.Drawing.Image)
        Me.btn品目16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目16.FlatAppearance.BorderSize = 0
        Me.btn品目16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目16.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目16.Location = New System.Drawing.Point(331, 502)
        Me.btn品目16.Name = "btn品目16"
        Me.btn品目16.Size = New System.Drawing.Size(110, 60)
        Me.btn品目16.TabIndex = 74
        Me.btn品目16.Text = "商品" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1000"
        Me.btn品目16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目16.UseVisualStyleBackColor = False
        '
        'btn品目15
        '
        Me.btn品目15.BackgroundImage = CType(resources.GetObject("btn品目15.BackgroundImage"), System.Drawing.Image)
        Me.btn品目15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目15.FlatAppearance.BorderSize = 0
        Me.btn品目15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目15.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目15.Location = New System.Drawing.Point(221, 502)
        Me.btn品目15.Name = "btn品目15"
        Me.btn品目15.Size = New System.Drawing.Size(110, 60)
        Me.btn品目15.TabIndex = 73
        Me.btn品目15.Text = "商品" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1000"
        Me.btn品目15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目15.UseVisualStyleBackColor = False
        '
        'btn品目14
        '
        Me.btn品目14.BackgroundImage = CType(resources.GetObject("btn品目14.BackgroundImage"), System.Drawing.Image)
        Me.btn品目14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目14.FlatAppearance.BorderSize = 0
        Me.btn品目14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目14.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目14.Location = New System.Drawing.Point(111, 502)
        Me.btn品目14.Name = "btn品目14"
        Me.btn品目14.Size = New System.Drawing.Size(110, 60)
        Me.btn品目14.TabIndex = 72
        Me.btn品目14.Text = "商品" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1000"
        Me.btn品目14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目14.UseVisualStyleBackColor = False
        '
        'btn品目13
        '
        Me.btn品目13.BackgroundImage = CType(resources.GetObject("btn品目13.BackgroundImage"), System.Drawing.Image)
        Me.btn品目13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目13.FlatAppearance.BorderSize = 0
        Me.btn品目13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目13.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目13.Location = New System.Drawing.Point(1, 502)
        Me.btn品目13.Name = "btn品目13"
        Me.btn品目13.Size = New System.Drawing.Size(110, 60)
        Me.btn品目13.TabIndex = 71
        Me.btn品目13.Text = "商品" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1000"
        Me.btn品目13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目13.UseVisualStyleBackColor = False
        '
        'btn品目12
        '
        Me.btn品目12.BackgroundImage = CType(resources.GetObject("btn品目12.BackgroundImage"), System.Drawing.Image)
        Me.btn品目12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目12.FlatAppearance.BorderSize = 0
        Me.btn品目12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目12.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目12.Location = New System.Drawing.Point(552, 442)
        Me.btn品目12.Name = "btn品目12"
        Me.btn品目12.Size = New System.Drawing.Size(110, 60)
        Me.btn品目12.TabIndex = 70
        Me.btn品目12.Text = "商品" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1000"
        Me.btn品目12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目12.UseVisualStyleBackColor = False
        '
        'btn品目11
        '
        Me.btn品目11.BackgroundImage = CType(resources.GetObject("btn品目11.BackgroundImage"), System.Drawing.Image)
        Me.btn品目11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目11.FlatAppearance.BorderSize = 0
        Me.btn品目11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目11.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目11.Location = New System.Drawing.Point(442, 442)
        Me.btn品目11.Name = "btn品目11"
        Me.btn品目11.Size = New System.Drawing.Size(110, 60)
        Me.btn品目11.TabIndex = 69
        Me.btn品目11.Text = "商品" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1000"
        Me.btn品目11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目11.UseVisualStyleBackColor = False
        '
        'btn品目10
        '
        Me.btn品目10.BackgroundImage = CType(resources.GetObject("btn品目10.BackgroundImage"), System.Drawing.Image)
        Me.btn品目10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目10.FlatAppearance.BorderSize = 0
        Me.btn品目10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目10.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目10.Location = New System.Drawing.Point(332, 442)
        Me.btn品目10.Name = "btn品目10"
        Me.btn品目10.Size = New System.Drawing.Size(110, 60)
        Me.btn品目10.TabIndex = 68
        Me.btn品目10.Text = "商品" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1000"
        Me.btn品目10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目10.UseVisualStyleBackColor = False
        '
        'btn品目9
        '
        Me.btn品目9.BackgroundImage = CType(resources.GetObject("btn品目9.BackgroundImage"), System.Drawing.Image)
        Me.btn品目9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目9.FlatAppearance.BorderSize = 0
        Me.btn品目9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目9.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目9.Location = New System.Drawing.Point(222, 442)
        Me.btn品目9.Name = "btn品目9"
        Me.btn品目9.Size = New System.Drawing.Size(110, 60)
        Me.btn品目9.TabIndex = 67
        Me.btn品目9.Text = "商品" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1000"
        Me.btn品目9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目9.UseVisualStyleBackColor = False
        '
        'btn品目8
        '
        Me.btn品目8.BackgroundImage = CType(resources.GetObject("btn品目8.BackgroundImage"), System.Drawing.Image)
        Me.btn品目8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目8.FlatAppearance.BorderSize = 0
        Me.btn品目8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目8.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目8.Location = New System.Drawing.Point(112, 442)
        Me.btn品目8.Name = "btn品目8"
        Me.btn品目8.Size = New System.Drawing.Size(110, 60)
        Me.btn品目8.TabIndex = 66
        Me.btn品目8.Text = "商品" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1000"
        Me.btn品目8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目8.UseVisualStyleBackColor = False
        '
        'btn品目7
        '
        Me.btn品目7.BackgroundImage = CType(resources.GetObject("btn品目7.BackgroundImage"), System.Drawing.Image)
        Me.btn品目7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目7.FlatAppearance.BorderSize = 0
        Me.btn品目7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目7.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目7.Location = New System.Drawing.Point(2, 442)
        Me.btn品目7.Name = "btn品目7"
        Me.btn品目7.Size = New System.Drawing.Size(110, 60)
        Me.btn品目7.TabIndex = 65
        Me.btn品目7.Text = "商品" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1000"
        Me.btn品目7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目7.UseVisualStyleBackColor = False
        '
        'btn品目6
        '
        Me.btn品目6.BackgroundImage = CType(resources.GetObject("btn品目6.BackgroundImage"), System.Drawing.Image)
        Me.btn品目6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目6.FlatAppearance.BorderSize = 0
        Me.btn品目6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目6.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目6.Location = New System.Drawing.Point(552, 382)
        Me.btn品目6.Name = "btn品目6"
        Me.btn品目6.Size = New System.Drawing.Size(110, 60)
        Me.btn品目6.TabIndex = 64
        Me.btn品目6.Tag = "6"
        Me.btn品目6.Text = "商品6" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "150"
        Me.btn品目6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目6.UseVisualStyleBackColor = False
        '
        'btn品目5
        '
        Me.btn品目5.BackgroundImage = CType(resources.GetObject("btn品目5.BackgroundImage"), System.Drawing.Image)
        Me.btn品目5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目5.FlatAppearance.BorderSize = 0
        Me.btn品目5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目5.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目5.Location = New System.Drawing.Point(442, 382)
        Me.btn品目5.Name = "btn品目5"
        Me.btn品目5.Size = New System.Drawing.Size(110, 60)
        Me.btn品目5.TabIndex = 63
        Me.btn品目5.Tag = "5"
        Me.btn品目5.Text = "商品5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2000"
        Me.btn品目5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目5.UseVisualStyleBackColor = False
        '
        'btn品目4
        '
        Me.btn品目4.BackgroundImage = CType(resources.GetObject("btn品目4.BackgroundImage"), System.Drawing.Image)
        Me.btn品目4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目4.FlatAppearance.BorderSize = 0
        Me.btn品目4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目4.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目4.Location = New System.Drawing.Point(332, 382)
        Me.btn品目4.Name = "btn品目4"
        Me.btn品目4.Size = New System.Drawing.Size(110, 60)
        Me.btn品目4.TabIndex = 62
        Me.btn品目4.Tag = "4"
        Me.btn品目4.Text = "商品4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "500"
        Me.btn品目4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目4.UseVisualStyleBackColor = False
        '
        'btn品目3
        '
        Me.btn品目3.BackgroundImage = CType(resources.GetObject("btn品目3.BackgroundImage"), System.Drawing.Image)
        Me.btn品目3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目3.FlatAppearance.BorderSize = 0
        Me.btn品目3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目3.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目3.Location = New System.Drawing.Point(222, 382)
        Me.btn品目3.Name = "btn品目3"
        Me.btn品目3.Size = New System.Drawing.Size(110, 60)
        Me.btn品目3.TabIndex = 61
        Me.btn品目3.Tag = "3"
        Me.btn品目3.Text = "商品3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "400"
        Me.btn品目3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目3.UseVisualStyleBackColor = False
        '
        'btn品目2
        '
        Me.btn品目2.BackgroundImage = CType(resources.GetObject("btn品目2.BackgroundImage"), System.Drawing.Image)
        Me.btn品目2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn品目2.FlatAppearance.BorderSize = 0
        Me.btn品目2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn品目2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn品目2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn品目2.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn品目2.Location = New System.Drawing.Point(112, 382)
        Me.btn品目2.Name = "btn品目2"
        Me.btn品目2.Size = New System.Drawing.Size(110, 60)
        Me.btn品目2.TabIndex = 60
        Me.btn品目2.Tag = "2"
        Me.btn品目2.Text = "商品2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "200"
        Me.btn品目2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn品目2.UseVisualStyleBackColor = False
        '
        'btnN
        '
        Me.btnN.BackgroundImage = CType(resources.GetObject("btnN.BackgroundImage"), System.Drawing.Image)
        Me.btnN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnN.FlatAppearance.BorderSize = 0
        Me.btnN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnN.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnN.Location = New System.Drawing.Point(552, 321)
        Me.btnN.Name = "btnN"
        Me.btnN.Size = New System.Drawing.Size(55, 60)
        Me.btnN.TabIndex = 58
        Me.btnN.Text = "＞"
        Me.btnN.UseVisualStyleBackColor = False
        '
        'btnNN
        '
        Me.btnNN.BackgroundImage = CType(resources.GetObject("btnNN.BackgroundImage"), System.Drawing.Image)
        Me.btnNN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNN.FlatAppearance.BorderSize = 0
        Me.btnNN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNN.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnNN.Location = New System.Drawing.Point(607, 321)
        Me.btnNN.Name = "btnNN"
        Me.btnNN.Size = New System.Drawing.Size(55, 60)
        Me.btnNN.TabIndex = 57
        Me.btnNN.Text = "＞＞"
        Me.btnNN.UseVisualStyleBackColor = False
        '
        'btnBB
        '
        Me.btnBB.BackgroundImage = CType(resources.GetObject("btnBB.BackgroundImage"), System.Drawing.Image)
        Me.btnBB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBB.FlatAppearance.BorderSize = 0
        Me.btnBB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBB.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnBB.Location = New System.Drawing.Point(2, 321)
        Me.btnBB.Name = "btnBB"
        Me.btnBB.Size = New System.Drawing.Size(55, 60)
        Me.btnBB.TabIndex = 56
        Me.btnBB.Text = "＜＜"
        Me.btnBB.UseVisualStyleBackColor = False
        '
        'btnB
        '
        Me.btnB.BackgroundImage = CType(resources.GetObject("btnB.BackgroundImage"), System.Drawing.Image)
        Me.btnB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnB.FlatAppearance.BorderSize = 0
        Me.btnB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnB.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnB.Location = New System.Drawing.Point(57, 321)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(55, 60)
        Me.btnB.TabIndex = 55
        Me.btnB.Text = "＜"
        Me.btnB.UseVisualStyleBackColor = False
        '
        'btn分類1
        '
        Me.btn分類1.BackgroundImage = CType(resources.GetObject("btn分類1.BackgroundImage"), System.Drawing.Image)
        Me.btn分類1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn分類1.FlatAppearance.BorderSize = 0
        Me.btn分類1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn分類1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn分類1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn分類1.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn分類1.Location = New System.Drawing.Point(112, 321)
        Me.btn分類1.Name = "btn分類1"
        Me.btn分類1.Size = New System.Drawing.Size(110, 60)
        Me.btn分類1.TabIndex = 54
        Me.btn分類1.Text = "分類1"
        Me.btn分類1.UseVisualStyleBackColor = False
        '
        'btn分類2
        '
        Me.btn分類2.BackgroundImage = CType(resources.GetObject("btn分類2.BackgroundImage"), System.Drawing.Image)
        Me.btn分類2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn分類2.FlatAppearance.BorderSize = 0
        Me.btn分類2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn分類2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn分類2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn分類2.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn分類2.Location = New System.Drawing.Point(222, 321)
        Me.btn分類2.Name = "btn分類2"
        Me.btn分類2.Size = New System.Drawing.Size(110, 60)
        Me.btn分類2.TabIndex = 53
        Me.btn分類2.Text = "分類2"
        Me.btn分類2.UseVisualStyleBackColor = False
        '
        'btn分類3
        '
        Me.btn分類3.BackgroundImage = CType(resources.GetObject("btn分類3.BackgroundImage"), System.Drawing.Image)
        Me.btn分類3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn分類3.FlatAppearance.BorderSize = 0
        Me.btn分類3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn分類3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn分類3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn分類3.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn分類3.Location = New System.Drawing.Point(332, 321)
        Me.btn分類3.Name = "btn分類3"
        Me.btn分類3.Size = New System.Drawing.Size(110, 60)
        Me.btn分類3.TabIndex = 52
        Me.btn分類3.Text = "分類3"
        Me.btn分類3.UseVisualStyleBackColor = False
        '
        'Button64
        '
        Me.Button64.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button64.Font = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button64.Location = New System.Drawing.Point(138, 12)
        Me.Button64.Name = "Button64"
        Me.Button64.Size = New System.Drawing.Size(60, 50)
        Me.Button64.TabIndex = 168
        Me.Button64.Tag = "C"
        Me.Button64.Text = "人数"
        Me.Button64.UseVisualStyleBackColor = False
        Me.Button64.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssl時間, Me.tssl担当者1, Me.tssl担当者2, Me.tsslOES, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 746)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1024, 22)
        Me.StatusStrip1.TabIndex = 162
        Me.StatusStrip1.Text = "sts情報"
        '
        'tssl時間
        '
        Me.tssl時間.Name = "tssl時間"
        Me.tssl時間.Size = New System.Drawing.Size(31, 17)
        Me.tssl時間.Text = "時間"
        '
        'tssl担当者1
        '
        Me.tssl担当者1.Name = "tssl担当者1"
        Me.tssl担当者1.Size = New System.Drawing.Size(412, 17)
        Me.tssl担当者1.Spring = True
        Me.tssl担当者1.Text = "担当者1"
        '
        'tssl担当者2
        '
        Me.tssl担当者2.Name = "tssl担当者2"
        Me.tssl担当者2.Size = New System.Drawing.Size(412, 17)
        Me.tssl担当者2.Spring = True
        Me.tssl担当者2.Text = "担当者2"
        '
        'tsslOES
        '
        Me.tsslOES.Name = "tsslOES"
        Me.tsslOES.Size = New System.Drawing.Size(52, 17)
        Me.tsslOES.Text = "OES正常"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'btn割込
        '
        Me.btn割込.BackgroundImage = CType(resources.GetObject("btn割込.BackgroundImage"), System.Drawing.Image)
        Me.btn割込.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn割込.FlatAppearance.BorderSize = 0
        Me.btn割込.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn割込.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn割込.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn割込.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn割込.Location = New System.Drawing.Point(806, 6)
        Me.btn割込.Name = "btn割込"
        Me.btn割込.Size = New System.Drawing.Size(70, 60)
        Me.btn割込.TabIndex = 183
        Me.btn割込.Text = "割込"
        Me.btn割込.UseVisualStyleBackColor = False
        '
        'btn登録ステータス
        '
        Me.btn登録ステータス.BackgroundImage = CType(resources.GetObject("btn登録ステータス.BackgroundImage"), System.Drawing.Image)
        Me.btn登録ステータス.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn登録ステータス.FlatAppearance.BorderSize = 0
        Me.btn登録ステータス.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn登録ステータス.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn登録ステータス.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn登録ステータス.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn登録ステータス.Location = New System.Drawing.Point(947, 6)
        Me.btn登録ステータス.Name = "btn登録ステータス"
        Me.btn登録ステータス.Size = New System.Drawing.Size(70, 60)
        Me.btn登録ステータス.TabIndex = 190
        Me.btn登録ステータス.Text = "登録"
        Me.btn登録ステータス.UseVisualStyleBackColor = False
        '
        'btn返品
        '
        Me.btn返品.BackgroundImage = CType(resources.GetObject("btn返品.BackgroundImage"), System.Drawing.Image)
        Me.btn返品.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn返品.FlatAppearance.BorderSize = 0
        Me.btn返品.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn返品.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn返品.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn返品.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn返品.Location = New System.Drawing.Point(737, 200)
        Me.btn返品.Name = "btn返品"
        Me.btn返品.Size = New System.Drawing.Size(70, 60)
        Me.btn返品.TabIndex = 163
        Me.btn返品.Text = "返品"
        Me.btn返品.UseVisualStyleBackColor = False
        '
        'btn指定取消
        '
        Me.btn指定取消.BackgroundImage = CType(resources.GetObject("btn指定取消.BackgroundImage"), System.Drawing.Image)
        Me.btn指定取消.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn指定取消.FlatAppearance.BorderSize = 0
        Me.btn指定取消.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn指定取消.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn指定取消.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn指定取消.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn指定取消.Location = New System.Drawing.Point(807, 200)
        Me.btn指定取消.Name = "btn指定取消"
        Me.btn指定取消.Size = New System.Drawing.Size(70, 60)
        Me.btn指定取消.TabIndex = 171
        Me.btn指定取消.Text = "指定" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "取消"
        Me.btn指定取消.UseVisualStyleBackColor = False
        '
        'btn一括取消
        '
        Me.btn一括取消.BackgroundImage = CType(resources.GetObject("btn一括取消.BackgroundImage"), System.Drawing.Image)
        Me.btn一括取消.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn一括取消.FlatAppearance.BorderSize = 0
        Me.btn一括取消.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn一括取消.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn一括取消.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn一括取消.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn一括取消.Location = New System.Drawing.Point(877, 200)
        Me.btn一括取消.Name = "btn一括取消"
        Me.btn一括取消.Size = New System.Drawing.Size(70, 60)
        Me.btn一括取消.TabIndex = 172
        Me.btn一括取消.Text = "一括" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "取消"
        Me.btn一括取消.UseVisualStyleBackColor = False
        '
        'btnJAN
        '
        Me.btnJAN.BackgroundImage = CType(resources.GetObject("btnJAN.BackgroundImage"), System.Drawing.Image)
        Me.btnJAN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnJAN.FlatAppearance.BorderSize = 0
        Me.btnJAN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnJAN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnJAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJAN.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnJAN.Location = New System.Drawing.Point(737, 321)
        Me.btnJAN.Name = "btnJAN"
        Me.btnJAN.Size = New System.Drawing.Size(70, 60)
        Me.btnJAN.TabIndex = 176
        Me.btnJAN.Text = "JAN"
        Me.btnJAN.UseVisualStyleBackColor = False
        '
        'btnS
        '
        Me.btnS.BackgroundImage = CType(resources.GetObject("btnS.BackgroundImage"), System.Drawing.Image)
        Me.btnS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnS.FlatAppearance.BorderSize = 0
        Me.btnS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnS.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnS.Location = New System.Drawing.Point(667, 321)
        Me.btnS.Name = "btnS"
        Me.btnS.Size = New System.Drawing.Size(70, 60)
        Me.btnS.TabIndex = 177
        Me.btnS.Text = "#"
        Me.btnS.UseVisualStyleBackColor = False
        '
        'btnF1
        '
        Me.btnF1.BackgroundImage = CType(resources.GetObject("btnF1.BackgroundImage"), System.Drawing.Image)
        Me.btnF1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnF1.FlatAppearance.BorderSize = 0
        Me.btnF1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnF1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnF1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnF1.Font = New System.Drawing.Font("メイリオ", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnF1.Location = New System.Drawing.Point(667, 131)
        Me.btnF1.Name = "btnF1"
        Me.btnF1.Size = New System.Drawing.Size(70, 60)
        Me.btnF1.TabIndex = 180
        Me.btnF1.Text = "01"
        Me.btnF1.UseVisualStyleBackColor = False
        '
        'btnF2
        '
        Me.btnF2.BackgroundImage = CType(resources.GetObject("btnF2.BackgroundImage"), System.Drawing.Image)
        Me.btnF2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnF2.FlatAppearance.BorderSize = 0
        Me.btnF2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnF2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnF2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnF2.Font = New System.Drawing.Font("メイリオ", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnF2.Location = New System.Drawing.Point(737, 131)
        Me.btnF2.Name = "btnF2"
        Me.btnF2.Size = New System.Drawing.Size(70, 60)
        Me.btnF2.TabIndex = 181
        Me.btnF2.Text = "02"
        Me.btnF2.UseVisualStyleBackColor = False
        '
        'btnF3
        '
        Me.btnF3.BackgroundImage = CType(resources.GetObject("btnF3.BackgroundImage"), System.Drawing.Image)
        Me.btnF3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnF3.FlatAppearance.BorderSize = 0
        Me.btnF3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnF3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnF3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnF3.Font = New System.Drawing.Font("メイリオ", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnF3.Location = New System.Drawing.Point(807, 131)
        Me.btnF3.Name = "btnF3"
        Me.btnF3.Size = New System.Drawing.Size(70, 60)
        Me.btnF3.TabIndex = 182
        Me.btnF3.Text = "03"
        Me.btnF3.UseVisualStyleBackColor = False
        '
        'btnF4
        '
        Me.btnF4.BackgroundImage = CType(resources.GetObject("btnF4.BackgroundImage"), System.Drawing.Image)
        Me.btnF4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnF4.FlatAppearance.BorderSize = 0
        Me.btnF4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnF4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnF4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnF4.Font = New System.Drawing.Font("メイリオ", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnF4.Location = New System.Drawing.Point(877, 131)
        Me.btnF4.Name = "btnF4"
        Me.btnF4.Size = New System.Drawing.Size(70, 60)
        Me.btnF4.TabIndex = 183
        Me.btnF4.Text = "04"
        Me.btnF4.UseVisualStyleBackColor = False
        '
        'btnF5
        '
        Me.btnF5.BackgroundImage = CType(resources.GetObject("btnF5.BackgroundImage"), System.Drawing.Image)
        Me.btnF5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnF5.FlatAppearance.BorderSize = 0
        Me.btnF5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnF5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnF5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnF5.Font = New System.Drawing.Font("メイリオ", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnF5.Location = New System.Drawing.Point(947, 131)
        Me.btnF5.Name = "btnF5"
        Me.btnF5.Size = New System.Drawing.Size(70, 60)
        Me.btnF5.TabIndex = 184
        Me.btnF5.Text = "05"
        Me.btnF5.UseVisualStyleBackColor = False
        '
        'btnM1
        '
        Me.btnM1.BackgroundImage = CType(resources.GetObject("btnM1.BackgroundImage"), System.Drawing.Image)
        Me.btnM1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnM1.FlatAppearance.BorderSize = 0
        Me.btnM1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnM1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnM1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnM1.Font = New System.Drawing.Font("メイリオ", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnM1.Location = New System.Drawing.Point(667, 71)
        Me.btnM1.Name = "btnM1"
        Me.btnM1.Size = New System.Drawing.Size(70, 60)
        Me.btnM1.TabIndex = 185
        Me.btnM1.Text = "01"
        Me.btnM1.UseVisualStyleBackColor = False
        '
        'btnM2
        '
        Me.btnM2.BackgroundImage = CType(resources.GetObject("btnM2.BackgroundImage"), System.Drawing.Image)
        Me.btnM2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnM2.FlatAppearance.BorderSize = 0
        Me.btnM2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnM2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnM2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnM2.Font = New System.Drawing.Font("メイリオ", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnM2.Location = New System.Drawing.Point(737, 71)
        Me.btnM2.Name = "btnM2"
        Me.btnM2.Size = New System.Drawing.Size(70, 60)
        Me.btnM2.TabIndex = 186
        Me.btnM2.Text = "02"
        Me.btnM2.UseVisualStyleBackColor = False
        '
        'btnM3
        '
        Me.btnM3.BackgroundImage = CType(resources.GetObject("btnM3.BackgroundImage"), System.Drawing.Image)
        Me.btnM3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnM3.FlatAppearance.BorderSize = 0
        Me.btnM3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnM3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnM3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnM3.Font = New System.Drawing.Font("メイリオ", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnM3.Location = New System.Drawing.Point(807, 71)
        Me.btnM3.Name = "btnM3"
        Me.btnM3.Size = New System.Drawing.Size(70, 60)
        Me.btnM3.TabIndex = 187
        Me.btnM3.Text = "03"
        Me.btnM3.UseVisualStyleBackColor = False
        '
        'btnM4
        '
        Me.btnM4.BackgroundImage = CType(resources.GetObject("btnM4.BackgroundImage"), System.Drawing.Image)
        Me.btnM4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnM4.FlatAppearance.BorderSize = 0
        Me.btnM4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnM4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnM4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnM4.Font = New System.Drawing.Font("メイリオ", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnM4.Location = New System.Drawing.Point(877, 71)
        Me.btnM4.Name = "btnM4"
        Me.btnM4.Size = New System.Drawing.Size(70, 60)
        Me.btnM4.TabIndex = 188
        Me.btnM4.Text = "04"
        Me.btnM4.UseVisualStyleBackColor = False
        '
        'btnM5
        '
        Me.btnM5.BackgroundImage = CType(resources.GetObject("btnM5.BackgroundImage"), System.Drawing.Image)
        Me.btnM5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnM5.FlatAppearance.BorderSize = 0
        Me.btnM5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnM5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnM5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnM5.Font = New System.Drawing.Font("メイリオ", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnM5.Location = New System.Drawing.Point(947, 71)
        Me.btnM5.Name = "btnM5"
        Me.btnM5.Size = New System.Drawing.Size(70, 60)
        Me.btnM5.TabIndex = 189
        Me.btnM5.Text = "05"
        Me.btnM5.UseVisualStyleBackColor = False
        '
        'btnメニュー
        '
        Me.btnメニュー.BackgroundImage = CType(resources.GetObject("btnメニュー.BackgroundImage"), System.Drawing.Image)
        Me.btnメニュー.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnメニュー.FlatAppearance.BorderSize = 0
        Me.btnメニュー.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnメニュー.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnメニュー.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnメニュー.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnメニュー.Location = New System.Drawing.Point(668, 6)
        Me.btnメニュー.Name = "btnメニュー"
        Me.btnメニュー.Size = New System.Drawing.Size(70, 60)
        Me.btnメニュー.TabIndex = 191
        Me.btnメニュー.Text = "ﾒﾆｭｰ"
        Me.btnメニュー.UseVisualStyleBackColor = False
        '
        'txtステータス
        '
        Me.txtステータス.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtステータス.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtステータス.Font = New System.Drawing.Font("MS UI Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtステータス.ForeColor = System.Drawing.Color.Red
        Me.txtステータス.Location = New System.Drawing.Point(667, 674)
        Me.txtステータス.MaxLength = 10
        Me.txtステータス.Name = "txtステータス"
        Me.txtステータス.Size = New System.Drawing.Size(350, 34)
        Me.txtステータス.TabIndex = 183
        Me.txtステータス.Text = "マスタ更新があります"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("MS UI Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Red
        Me.TextBox1.Location = New System.Drawing.Point(667, 709)
        Me.TextBox1.MaxLength = 10
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(350, 34)
        Me.TextBox1.TabIndex = 193
        Me.TextBox1.Text = "通信状況"
        '
        'btnC
        '
        Me.btnC.BackgroundImage = CType(resources.GetObject("btnC.BackgroundImage"), System.Drawing.Image)
        Me.btnC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnC.FlatAppearance.BorderSize = 0
        Me.btnC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnC.Font = New System.Drawing.Font("メイリオ", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnC.Location = New System.Drawing.Point(666, 553)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(70, 120)
        Me.btnC.TabIndex = 209
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = False
        '
        'btn個
        '
        Me.btn個.BackgroundImage = CType(resources.GetObject("btn個.BackgroundImage"), System.Drawing.Image)
        Me.btn個.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn個.FlatAppearance.BorderSize = 0
        Me.btn個.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn個.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn個.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn個.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn個.Location = New System.Drawing.Point(666, 493)
        Me.btn個.Name = "btn個"
        Me.btn個.Size = New System.Drawing.Size(70, 60)
        Me.btn個.TabIndex = 208
        Me.btn個.Text = "個"
        Me.btn個.UseVisualStyleBackColor = False
        '
        'btn小計
        '
        Me.btn小計.BackgroundImage = CType(resources.GetObject("btn小計.BackgroundImage"), System.Drawing.Image)
        Me.btn小計.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn小計.FlatAppearance.BorderSize = 0
        Me.btn小計.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn小計.Font = New System.Drawing.Font("メイリオ", 21.75!, System.Drawing.FontStyle.Bold)
        Me.btn小計.Location = New System.Drawing.Point(946, 433)
        Me.btn小計.Name = "btn小計"
        Me.btn小計.Size = New System.Drawing.Size(70, 240)
        Me.btn小計.TabIndex = 210
        Me.btn小計.Text = "小計"
        Me.btn小計.UseVisualStyleBackColor = False
        '
        'btn単価変更
        '
        Me.btn単価変更.BackgroundImage = CType(resources.GetObject("btn単価変更.BackgroundImage"), System.Drawing.Image)
        Me.btn単価変更.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn単価変更.FlatAppearance.BorderSize = 0
        Me.btn単価変更.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn単価変更.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn単価変更.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn単価変更.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn単価変更.Location = New System.Drawing.Point(666, 433)
        Me.btn単価変更.Name = "btn単価変更"
        Me.btn単価変更.Size = New System.Drawing.Size(70, 60)
        Me.btn単価変更.TabIndex = 207
        Me.btn単価変更.Text = "単価" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "変更"
        Me.btn単価変更.UseVisualStyleBackColor = False
        '
        'btn0
        '
        Me.btn0.BackgroundImage = CType(resources.GetObject("btn0.BackgroundImage"), System.Drawing.Image)
        Me.btn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn0.FlatAppearance.BorderSize = 0
        Me.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn0.Font = New System.Drawing.Font("メイリオ", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btn0.ForeColor = System.Drawing.Color.White
        Me.btn0.Location = New System.Drawing.Point(736, 613)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(70, 60)
        Me.btn0.TabIndex = 206
        Me.btn0.Tag = "0"
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = False
        '
        'btn00
        '
        Me.btn00.BackgroundImage = CType(resources.GetObject("btn00.BackgroundImage"), System.Drawing.Image)
        Me.btn00.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn00.FlatAppearance.BorderSize = 0
        Me.btn00.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn00.Font = New System.Drawing.Font("メイリオ", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn00.ForeColor = System.Drawing.Color.White
        Me.btn00.Location = New System.Drawing.Point(806, 613)
        Me.btn00.Name = "btn00"
        Me.btn00.Size = New System.Drawing.Size(70, 60)
        Me.btn00.TabIndex = 205
        Me.btn00.Tag = "00"
        Me.btn00.Text = "00"
        Me.btn00.UseVisualStyleBackColor = False
        '
        'btn000
        '
        Me.btn000.BackgroundImage = CType(resources.GetObject("btn000.BackgroundImage"), System.Drawing.Image)
        Me.btn000.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn000.FlatAppearance.BorderSize = 0
        Me.btn000.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn000.Font = New System.Drawing.Font("メイリオ", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn000.ForeColor = System.Drawing.Color.White
        Me.btn000.Location = New System.Drawing.Point(876, 613)
        Me.btn000.Name = "btn000"
        Me.btn000.Size = New System.Drawing.Size(70, 60)
        Me.btn000.TabIndex = 204
        Me.btn000.Tag = "000"
        Me.btn000.Text = "000"
        Me.btn000.UseVisualStyleBackColor = False
        '
        'btn1
        '
        Me.btn1.BackgroundImage = CType(resources.GetObject("btn1.BackgroundImage"), System.Drawing.Image)
        Me.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn1.FlatAppearance.BorderSize = 0
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1.Font = New System.Drawing.Font("メイリオ", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btn1.ForeColor = System.Drawing.Color.White
        Me.btn1.Location = New System.Drawing.Point(736, 553)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(70, 60)
        Me.btn1.TabIndex = 203
        Me.btn1.Tag = "1"
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackgroundImage = CType(resources.GetObject("btn2.BackgroundImage"), System.Drawing.Image)
        Me.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn2.FlatAppearance.BorderSize = 0
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2.Font = New System.Drawing.Font("メイリオ", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btn2.ForeColor = System.Drawing.Color.White
        Me.btn2.Location = New System.Drawing.Point(806, 553)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(70, 60)
        Me.btn2.TabIndex = 202
        Me.btn2.Tag = "2"
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackgroundImage = CType(resources.GetObject("btn3.BackgroundImage"), System.Drawing.Image)
        Me.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn3.FlatAppearance.BorderSize = 0
        Me.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn3.Font = New System.Drawing.Font("メイリオ", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btn3.ForeColor = System.Drawing.Color.White
        Me.btn3.Location = New System.Drawing.Point(876, 553)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(70, 60)
        Me.btn3.TabIndex = 201
        Me.btn3.Tag = "3"
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.BackgroundImage = CType(resources.GetObject("btn4.BackgroundImage"), System.Drawing.Image)
        Me.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn4.FlatAppearance.BorderSize = 0
        Me.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn4.Font = New System.Drawing.Font("メイリオ", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btn4.ForeColor = System.Drawing.Color.White
        Me.btn4.Location = New System.Drawing.Point(736, 493)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(70, 60)
        Me.btn4.TabIndex = 200
        Me.btn4.Tag = "4"
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btn5
        '
        Me.btn5.BackgroundImage = CType(resources.GetObject("btn5.BackgroundImage"), System.Drawing.Image)
        Me.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn5.FlatAppearance.BorderSize = 0
        Me.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn5.Font = New System.Drawing.Font("メイリオ", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btn5.ForeColor = System.Drawing.Color.White
        Me.btn5.Location = New System.Drawing.Point(806, 493)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(70, 60)
        Me.btn5.TabIndex = 199
        Me.btn5.Tag = "5"
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = False
        '
        'btn6
        '
        Me.btn6.BackgroundImage = CType(resources.GetObject("btn6.BackgroundImage"), System.Drawing.Image)
        Me.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn6.FlatAppearance.BorderSize = 0
        Me.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn6.Font = New System.Drawing.Font("メイリオ", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btn6.ForeColor = System.Drawing.Color.White
        Me.btn6.Location = New System.Drawing.Point(876, 493)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(70, 60)
        Me.btn6.TabIndex = 198
        Me.btn6.Tag = "6"
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = False
        '
        'btn7
        '
        Me.btn7.BackgroundImage = CType(resources.GetObject("btn7.BackgroundImage"), System.Drawing.Image)
        Me.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn7.FlatAppearance.BorderSize = 0
        Me.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn7.Font = New System.Drawing.Font("メイリオ", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btn7.ForeColor = System.Drawing.Color.White
        Me.btn7.Location = New System.Drawing.Point(736, 433)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(70, 60)
        Me.btn7.TabIndex = 197
        Me.btn7.Tag = "7"
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = False
        '
        'btn8
        '
        Me.btn8.BackgroundImage = CType(resources.GetObject("btn8.BackgroundImage"), System.Drawing.Image)
        Me.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn8.FlatAppearance.BorderSize = 0
        Me.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn8.Font = New System.Drawing.Font("メイリオ", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btn8.ForeColor = System.Drawing.Color.White
        Me.btn8.Location = New System.Drawing.Point(806, 433)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(70, 60)
        Me.btn8.TabIndex = 196
        Me.btn8.Tag = "8"
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = False
        '
        'btn9
        '
        Me.btn9.BackgroundImage = CType(resources.GetObject("btn9.BackgroundImage"), System.Drawing.Image)
        Me.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn9.FlatAppearance.BorderSize = 0
        Me.btn9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn9.Font = New System.Drawing.Font("メイリオ", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btn9.ForeColor = System.Drawing.Color.White
        Me.btn9.Location = New System.Drawing.Point(876, 433)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(70, 60)
        Me.btn9.TabIndex = 194
        Me.btn9.Tag = "9"
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = False
        '
        'txt入力
        '
        Me.txt入力.BackColor = System.Drawing.Color.Black
        Me.txt入力.Font = New System.Drawing.Font("MS UI Gothic", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt入力.ForeColor = System.Drawing.Color.Lime
        Me.txt入力.Location = New System.Drawing.Point(667, 382)
        Me.txt入力.MaxLength = 20
        Me.txt入力.Name = "txt入力"
        Me.txt入力.Size = New System.Drawing.Size(350, 50)
        Me.txt入力.TabIndex = 0
        Me.txt入力.Text = "0"
        Me.txt入力.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn下
        '
        Me.btn下.Location = New System.Drawing.Point(615, 159)
        Me.btn下.Name = "btn下"
        Me.btn下.Size = New System.Drawing.Size(47, 158)
        Me.btn下.TabIndex = 283
        Me.btn下.Text = "▽"
        Me.btn下.UseVisualStyleBackColor = True
        '
        'btn上
        '
        Me.btn上.Location = New System.Drawing.Point(615, 2)
        Me.btn上.Name = "btn上"
        Me.btn上.Size = New System.Drawing.Size(47, 158)
        Me.btn上.TabIndex = 282
        Me.btn上.Text = "△"
        Me.btn上.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.Location = New System.Drawing.Point(807, 261)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 60)
        Me.Button1.TabIndex = 284
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button2.Location = New System.Drawing.Point(947, 200)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 60)
        Me.Button2.TabIndex = 286
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button3.Location = New System.Drawing.Point(807, 321)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(70, 60)
        Me.Button3.TabIndex = 287
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button4.Location = New System.Drawing.Point(877, 321)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(70, 60)
        Me.Button4.TabIndex = 288
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button5.Location = New System.Drawing.Point(947, 321)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(70, 60)
        Me.Button5.TabIndex = 289
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button36
        '
        Me.Button36.BackgroundImage = CType(resources.GetObject("Button36.BackgroundImage"), System.Drawing.Image)
        Me.Button36.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button36.FlatAppearance.BorderSize = 0
        Me.Button36.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button36.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button36.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button36.Location = New System.Drawing.Point(877, 261)
        Me.Button36.Name = "Button36"
        Me.Button36.Size = New System.Drawing.Size(70, 60)
        Me.Button36.TabIndex = 290
        Me.Button36.UseVisualStyleBackColor = False
        '
        'Button37
        '
        Me.Button37.BackgroundImage = CType(resources.GetObject("Button37.BackgroundImage"), System.Drawing.Image)
        Me.Button37.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button37.FlatAppearance.BorderSize = 0
        Me.Button37.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button37.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button37.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button37.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button37.Location = New System.Drawing.Point(947, 261)
        Me.Button37.Name = "Button37"
        Me.Button37.Size = New System.Drawing.Size(70, 60)
        Me.Button37.TabIndex = 291
        Me.Button37.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(664, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(357, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 292
        Me.PictureBox1.TabStop = False
        '
        'frm400POS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.btn登録ステータス)
        Me.Controls.Add(Me.btn品目1)
        Me.Controls.Add(Me.btnメニュー)
        Me.Controls.Add(Me.btn担当)
        Me.Controls.Add(Me.Button37)
        Me.Controls.Add(Me.btn割込)
        Me.Controls.Add(Me.btn品目36)
        Me.Controls.Add(Me.Button36)
        Me.Controls.Add(Me.btn品目35)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btn品目34)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btn品目33)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn品目32)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn品目31)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn品目30)
        Me.Controls.Add(Me.btn下)
        Me.Controls.Add(Me.btn品目29)
        Me.Controls.Add(Me.btn上)
        Me.Controls.Add(Me.btn品目28)
        Me.Controls.Add(Me.dgv明細)
        Me.Controls.Add(Me.btn品目27)
        Me.Controls.Add(Me.Button64)
        Me.Controls.Add(Me.btn品目26)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.btn品目25)
        Me.Controls.Add(Me.txt客層1)
        Me.Controls.Add(Me.btn品目24)
        Me.Controls.Add(Me.txt客層2)
        Me.Controls.Add(Me.btn品目23)
        Me.Controls.Add(Me.btn個)
        Me.Controls.Add(Me.btn品目22)
        Me.Controls.Add(Me.Button50)
        Me.Controls.Add(Me.btn品目21)
        Me.Controls.Add(Me.btn小計)
        Me.Controls.Add(Me.btn品目20)
        Me.Controls.Add(Me.txt人数)
        Me.Controls.Add(Me.btn品目19)
        Me.Controls.Add(Me.btn単価変更)
        Me.Controls.Add(Me.btn品目18)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.btn品目17)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn品目16)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.btn品目15)
        Me.Controls.Add(Me.btn00)
        Me.Controls.Add(Me.btn品目14)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.btn品目13)
        Me.Controls.Add(Me.btn000)
        Me.Controls.Add(Me.btn品目12)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn品目11)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn品目10)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn品目9)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn品目8)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn品目7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn品目6)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn品目5)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn品目4)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn品目3)
        Me.Controls.Add(Me.txt入力)
        Me.Controls.Add(Me.btn品目2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnN)
        Me.Controls.Add(Me.txtステータス)
        Me.Controls.Add(Me.btnNN)
        Me.Controls.Add(Me.btnM5)
        Me.Controls.Add(Me.btnBB)
        Me.Controls.Add(Me.btnB)
        Me.Controls.Add(Me.btn値引)
        Me.Controls.Add(Me.btn分類1)
        Me.Controls.Add(Me.btnM4)
        Me.Controls.Add(Me.btn分類2)
        Me.Controls.Add(Me.btn両替)
        Me.Controls.Add(Me.btn分類3)
        Me.Controls.Add(Me.btnM3)
        Me.Controls.Add(Me.btn分類4)
        Me.Controls.Add(Me.btnM2)
        Me.Controls.Add(Me.btnM1)
        Me.Controls.Add(Me.btnF5)
        Me.Controls.Add(Me.btn領収)
        Me.Controls.Add(Me.btnF4)
        Me.Controls.Add(Me.btnF3)
        Me.Controls.Add(Me.btnF2)
        Me.Controls.Add(Me.btnF1)
        Me.Controls.Add(Me.btnS)
        Me.Controls.Add(Me.btnJAN)
        Me.Controls.Add(Me.btn一括取消)
        Me.Controls.Add(Me.btn指定取消)
        Me.Controls.Add(Me.btn返品)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "frm400POS"
        Me.Text = "POS"
        CType(Me.dgv明細, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn分類4 As System.Windows.Forms.Button
    Friend WithEvents dgv明細 As System.Windows.Forms.DataGridView
    Friend WithEvents Button50 As System.Windows.Forms.Button
    Friend WithEvents txt客層1 As System.Windows.Forms.TextBox
    Friend WithEvents txt客層2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents txt人数 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tssl担当者1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssl担当者2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents tssl時間 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslOES As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Button64 As System.Windows.Forms.Button
    Friend WithEvents btn返品 As Button
    Friend WithEvents btn指定取消 As Button
    Friend WithEvents btn一括取消 As Button
    Friend WithEvents btn分類3 As Button
    Friend WithEvents btn分類1 As Button
    Friend WithEvents btn分類2 As Button
    Friend WithEvents btnN As Button
    Friend WithEvents btnNN As Button
    Friend WithEvents btnBB As Button
    Friend WithEvents btnB As Button
    Friend WithEvents btn品目1 As Button
    Friend WithEvents btn品目36 As System.Windows.Forms.Button
    Friend WithEvents btn品目35 As System.Windows.Forms.Button
    Friend WithEvents btn品目34 As System.Windows.Forms.Button
    Friend WithEvents btn品目33 As System.Windows.Forms.Button
    Friend WithEvents btn品目32 As System.Windows.Forms.Button
    Friend WithEvents btn品目31 As System.Windows.Forms.Button
    Friend WithEvents btn品目30 As System.Windows.Forms.Button
    Friend WithEvents btn品目29 As System.Windows.Forms.Button
    Friend WithEvents btn品目28 As System.Windows.Forms.Button
    Friend WithEvents btn品目27 As System.Windows.Forms.Button
    Friend WithEvents btn品目26 As System.Windows.Forms.Button
    Friend WithEvents btn品目25 As System.Windows.Forms.Button
    Friend WithEvents btn品目24 As System.Windows.Forms.Button
    Friend WithEvents btn品目23 As System.Windows.Forms.Button
    Friend WithEvents btn品目22 As System.Windows.Forms.Button
    Friend WithEvents btn品目21 As System.Windows.Forms.Button
    Friend WithEvents btn品目20 As System.Windows.Forms.Button
    Friend WithEvents btn品目19 As System.Windows.Forms.Button
    Friend WithEvents btn品目18 As System.Windows.Forms.Button
    Friend WithEvents btn品目17 As System.Windows.Forms.Button
    Friend WithEvents btn品目16 As System.Windows.Forms.Button
    Friend WithEvents btn品目15 As System.Windows.Forms.Button
    Friend WithEvents btn品目14 As System.Windows.Forms.Button
    Friend WithEvents btn品目13 As System.Windows.Forms.Button
    Friend WithEvents btn品目12 As System.Windows.Forms.Button
    Friend WithEvents btn品目11 As System.Windows.Forms.Button
    Friend WithEvents btn品目10 As System.Windows.Forms.Button
    Friend WithEvents btn品目9 As System.Windows.Forms.Button
    Friend WithEvents btn品目8 As System.Windows.Forms.Button
    Friend WithEvents btn品目7 As System.Windows.Forms.Button
    Friend WithEvents btn品目6 As System.Windows.Forms.Button
    Friend WithEvents btn品目5 As System.Windows.Forms.Button
    Friend WithEvents btn品目4 As System.Windows.Forms.Button
    Friend WithEvents btn品目3 As System.Windows.Forms.Button
    Friend WithEvents btn品目2 As System.Windows.Forms.Button
    Friend WithEvents btn値引 As System.Windows.Forms.Button
    Friend WithEvents btn両替 As System.Windows.Forms.Button
    Friend WithEvents btn領収 As System.Windows.Forms.Button
    Friend WithEvents btn担当 As System.Windows.Forms.Button
    Friend WithEvents btnJAN As System.Windows.Forms.Button
    Friend WithEvents btnS As System.Windows.Forms.Button
    Friend WithEvents btnF1 As System.Windows.Forms.Button
    Friend WithEvents btnF2 As System.Windows.Forms.Button
    Friend WithEvents btnF3 As System.Windows.Forms.Button
    Friend WithEvents btnF4 As System.Windows.Forms.Button
    Friend WithEvents btnF5 As System.Windows.Forms.Button
    Friend WithEvents btnM1 As System.Windows.Forms.Button
    Friend WithEvents btnM2 As System.Windows.Forms.Button
    Friend WithEvents btnM3 As System.Windows.Forms.Button
    Friend WithEvents btnM4 As System.Windows.Forms.Button
    Friend WithEvents btnM5 As System.Windows.Forms.Button
    Friend WithEvents btn登録ステータス As System.Windows.Forms.Button
    Friend WithEvents btn割込 As System.Windows.Forms.Button
    Friend WithEvents btnメニュー As System.Windows.Forms.Button
    Friend WithEvents txtステータス As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnC As System.Windows.Forms.Button
    Friend WithEvents btn個 As System.Windows.Forms.Button
    Friend WithEvents btn小計 As System.Windows.Forms.Button
    Friend WithEvents btn単価変更 As System.Windows.Forms.Button
    Friend WithEvents btn0 As System.Windows.Forms.Button
    Friend WithEvents btn00 As System.Windows.Forms.Button
    Friend WithEvents btn000 As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents txt入力 As System.Windows.Forms.TextBox
    Friend WithEvents btn下 As System.Windows.Forms.Button
    Friend WithEvents btn上 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button36 As System.Windows.Forms.Button
    Friend WithEvents Button37 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents colNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colJAN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col区分 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col取引名 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col数量 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col単価 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col金額 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col消費税率 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col消費税 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
