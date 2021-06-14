<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm802ジャーナル照会
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
        Me.lbl部門 = New System.Windows.Forms.Label()
        Me.lbl明細区分 = New System.Windows.Forms.Label()
        Me.lbl登録区分 = New System.Windows.Forms.Label()
        Me.cmb担当者 = New System.Windows.Forms.ComboBox()
        Me.cmb部門 = New System.Windows.Forms.ComboBox()
        Me.cmb明細区分 = New System.Windows.Forms.ComboBox()
        Me.cmb登録区分 = New System.Windows.Forms.ComboBox()
        Me.lbl担当者 = New System.Windows.Forms.Label()
        Me.cmb計上日付 = New System.Windows.Forms.ComboBox()
        Me.lbl波線 = New System.Windows.Forms.Label()
        Me.btn過去分レシート再発行 = New System.Windows.Forms.Button()
        Me.btn抽出 = New System.Windows.Forms.Button()
        Me.btnレシート印刷 = New System.Windows.Forms.Button()
        Me.btn終了 = New System.Windows.Forms.Button()
        Me.btnエクスポート = New System.Windows.Forms.Button()
        Me.lbl注意書き = New System.Windows.Forms.Label()
        Me.dgvジャーナル照会 = New System.Windows.Forms.DataGridView()
        Me.Col端末CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col取引日時 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colレシートNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col区分 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col取引名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col数量 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col単価 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col金額 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col担当者名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col客層名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grbジャーナル照会_画像部分 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgvジャーナル照会, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbジャーナル照会_画像部分.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl部門
        '
        Me.lbl部門.Location = New System.Drawing.Point(12, 38)
        Me.lbl部門.Name = "lbl部門"
        Me.lbl部門.Size = New System.Drawing.Size(53, 15)
        Me.lbl部門.TabIndex = 1
        Me.lbl部門.Text = "部    門"
        Me.lbl部門.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl明細区分
        '
        Me.lbl明細区分.Location = New System.Drawing.Point(12, 84)
        Me.lbl明細区分.Name = "lbl明細区分"
        Me.lbl明細区分.Size = New System.Drawing.Size(53, 17)
        Me.lbl明細区分.TabIndex = 3
        Me.lbl明細区分.Text = "明細区分"
        Me.lbl明細区分.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl登録区分
        '
        Me.lbl登録区分.Location = New System.Drawing.Point(12, 61)
        Me.lbl登録区分.Name = "lbl登録区分"
        Me.lbl登録区分.Size = New System.Drawing.Size(53, 20)
        Me.lbl登録区分.TabIndex = 2
        Me.lbl登録区分.Text = "登録区分"
        Me.lbl登録区分.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb担当者
        '
        Me.cmb担当者.FormattingEnabled = True
        Me.cmb担当者.Location = New System.Drawing.Point(71, 13)
        Me.cmb担当者.Name = "cmb担当者"
        Me.cmb担当者.Size = New System.Drawing.Size(121, 20)
        Me.cmb担当者.TabIndex = 4
        Me.cmb担当者.Text = "全て"
        '
        'cmb部門
        '
        Me.cmb部門.FormattingEnabled = True
        Me.cmb部門.Location = New System.Drawing.Point(71, 35)
        Me.cmb部門.Name = "cmb部門"
        Me.cmb部門.Size = New System.Drawing.Size(121, 20)
        Me.cmb部門.TabIndex = 5
        Me.cmb部門.Text = "全て"
        '
        'cmb明細区分
        '
        Me.cmb明細区分.FormattingEnabled = True
        Me.cmb明細区分.Location = New System.Drawing.Point(71, 81)
        Me.cmb明細区分.Name = "cmb明細区分"
        Me.cmb明細区分.Size = New System.Drawing.Size(121, 20)
        Me.cmb明細区分.TabIndex = 8
        Me.cmb明細区分.Text = "全て"
        '
        'cmb登録区分
        '
        Me.cmb登録区分.FormattingEnabled = True
        Me.cmb登録区分.Location = New System.Drawing.Point(71, 58)
        Me.cmb登録区分.Name = "cmb登録区分"
        Me.cmb登録区分.Size = New System.Drawing.Size(121, 20)
        Me.cmb登録区分.TabIndex = 7
        Me.cmb登録区分.Text = "全て"
        '
        'lbl担当者
        '
        Me.lbl担当者.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl担当者.Location = New System.Drawing.Point(12, 13)
        Me.lbl担当者.Name = "lbl担当者"
        Me.lbl担当者.Size = New System.Drawing.Size(53, 20)
        Me.lbl担当者.TabIndex = 0
        Me.lbl担当者.Text = "担当者"
        Me.lbl担当者.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb計上日付
        '
        Me.cmb計上日付.FormattingEnabled = True
        Me.cmb計上日付.Location = New System.Drawing.Point(198, 13)
        Me.cmb計上日付.Name = "cmb計上日付"
        Me.cmb計上日付.Size = New System.Drawing.Size(79, 20)
        Me.cmb計上日付.TabIndex = 9
        Me.cmb計上日付.Text = "計上日付"
        '
        'lbl波線
        '
        Me.lbl波線.AutoSize = True
        Me.lbl波線.Location = New System.Drawing.Point(413, 16)
        Me.lbl波線.Name = "lbl波線"
        Me.lbl波線.Size = New System.Drawing.Size(17, 12)
        Me.lbl波線.TabIndex = 12
        Me.lbl波線.Text = "～"
        '
        'btn過去分レシート再発行
        '
        Me.btn過去分レシート再発行.Location = New System.Drawing.Point(207, 53)
        Me.btn過去分レシート再発行.Name = "btn過去分レシート再発行"
        Me.btn過去分レシート再発行.Size = New System.Drawing.Size(333, 37)
        Me.btn過去分レシート再発行.TabIndex = 13
        Me.btn過去分レシート再発行.Text = "過去分レシート再発行"
        Me.btn過去分レシート再発行.UseVisualStyleBackColor = True
        '
        'btn抽出
        '
        Me.btn抽出.Location = New System.Drawing.Point(631, 25)
        Me.btn抽出.Name = "btn抽出"
        Me.btn抽出.Size = New System.Drawing.Size(64, 20)
        Me.btn抽出.TabIndex = 14
        Me.btn抽出.Text = "抽出"
        Me.btn抽出.UseVisualStyleBackColor = True
        '
        'btnレシート印刷
        '
        Me.btnレシート印刷.Location = New System.Drawing.Point(701, 24)
        Me.btnレシート印刷.Name = "btnレシート印刷"
        Me.btnレシート印刷.Size = New System.Drawing.Size(76, 20)
        Me.btnレシート印刷.TabIndex = 15
        Me.btnレシート印刷.Text = "レシート印刷"
        Me.btnレシート印刷.UseVisualStyleBackColor = True
        '
        'btn終了
        '
        Me.btn終了.Location = New System.Drawing.Point(867, 25)
        Me.btn終了.Name = "btn終了"
        Me.btn終了.Size = New System.Drawing.Size(64, 20)
        Me.btn終了.TabIndex = 17
        Me.btn終了.Text = "終了(Ｃ）"
        Me.btn終了.UseVisualStyleBackColor = True
        '
        'btnエクスポート
        '
        Me.btnエクスポート.Location = New System.Drawing.Point(788, 24)
        Me.btnエクスポート.Name = "btnエクスポート"
        Me.btnエクスポート.Size = New System.Drawing.Size(64, 20)
        Me.btnエクスポート.TabIndex = 16
        Me.btnエクスポート.Text = "エクスポート"
        Me.btnエクスポート.UseVisualStyleBackColor = True
        '
        'lbl注意書き
        '
        Me.lbl注意書き.AutoSize = True
        Me.lbl注意書き.Location = New System.Drawing.Point(629, 96)
        Me.lbl注意書き.Name = "lbl注意書き"
        Me.lbl注意書き.Size = New System.Drawing.Size(279, 24)
        Me.lbl注意書き.TabIndex = 18
        Me.lbl注意書き.Text = "※レシートへ印刷する場合、部門、登録区分・」明細区分" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "は全ての指定で印刷されます。"
        '
        'dgvジャーナル照会
        '
        Me.dgvジャーナル照会.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvジャーナル照会.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col端末CD, Me.col取引日時, Me.colレシートNO, Me.col区分, Me.colNo, Me.Col取引名, Me.Col数量, Me.Col単価, Me.Col金額, Me.Col担当者名, Me.Col客層名})
        Me.dgvジャーナル照会.Location = New System.Drawing.Point(12, 139)
        Me.dgvジャーナル照会.Name = "dgvジャーナル照会"
        Me.dgvジャーナル照会.RowTemplate.Height = 21
        Me.dgvジャーナル照会.Size = New System.Drawing.Size(981, 212)
        Me.dgvジャーナル照会.TabIndex = 19
        '
        'Col端末CD
        '
        Me.Col端末CD.DataPropertyName = "端末CD"
        Me.Col端末CD.HeaderText = "端末CD"
        Me.Col端末CD.Name = "Col端末CD"
        Me.Col端末CD.Width = 70
        '
        'col取引日時
        '
        Me.col取引日時.DataPropertyName = "取引日時"
        Me.col取引日時.HeaderText = "取引日時"
        Me.col取引日時.Name = "col取引日時"
        '
        'colレシートNO
        '
        Me.colレシートNO.DataPropertyName = "レシートNO"
        Me.colレシートNO.HeaderText = "レシートNO"
        Me.colレシートNO.Name = "colレシートNO"
        Me.colレシートNO.Width = 50
        '
        'col区分
        '
        Me.col区分.DataPropertyName = "区分"
        Me.col区分.HeaderText = "区分"
        Me.col区分.Name = "col区分"
        Me.col区分.Width = 60
        '
        'colNo
        '
        Me.colNo.DataPropertyName = "No"
        Me.colNo.HeaderText = "No."
        Me.colNo.Name = "colNo"
        Me.colNo.Width = 50
        '
        'Col取引名
        '
        Me.Col取引名.DataPropertyName = "取引名"
        Me.Col取引名.HeaderText = "取引名"
        Me.Col取引名.Name = "Col取引名"
        '
        'Col数量
        '
        Me.Col数量.DataPropertyName = "数量"
        Me.Col数量.HeaderText = "数量"
        Me.Col数量.Name = "Col数量"
        '
        'Col単価
        '
        Me.Col単価.DataPropertyName = "単価"
        Me.Col単価.HeaderText = "単価"
        Me.Col単価.Name = "Col単価"
        '
        'Col金額
        '
        Me.Col金額.DataPropertyName = "金額"
        Me.Col金額.HeaderText = "金額"
        Me.Col金額.Name = "Col金額"
        '
        'Col担当者名
        '
        Me.Col担当者名.DataPropertyName = "担当者名"
        Me.Col担当者名.HeaderText = "担当者名"
        Me.Col担当者名.Name = "Col担当者名"
        '
        'Col客層名
        '
        Me.Col客層名.DataPropertyName = "客層名"
        Me.Col客層名.HeaderText = "客層名"
        Me.Col客層名.Name = "Col客層名"
        '
        'grbジャーナル照会_画像部分
        '
        Me.grbジャーナル照会_画像部分.Controls.Add(Me.DateTimePicker1)
        Me.grbジャーナル照会_画像部分.Controls.Add(Me.DateTimePicker2)
        Me.grbジャーナル照会_画像部分.Controls.Add(Me.btn過去分レシート再発行)
        Me.grbジャーナル照会_画像部分.Controls.Add(Me.lbl波線)
        Me.grbジャーナル照会_画像部分.Controls.Add(Me.cmb計上日付)
        Me.grbジャーナル照会_画像部分.Controls.Add(Me.cmb明細区分)
        Me.grbジャーナル照会_画像部分.Controls.Add(Me.cmb登録区分)
        Me.grbジャーナル照会_画像部分.Controls.Add(Me.cmb部門)
        Me.grbジャーナル照会_画像部分.Controls.Add(Me.cmb担当者)
        Me.grbジャーナル照会_画像部分.Controls.Add(Me.lbl明細区分)
        Me.grbジャーナル照会_画像部分.Controls.Add(Me.lbl登録区分)
        Me.grbジャーナル照会_画像部分.Controls.Add(Me.lbl部門)
        Me.grbジャーナル照会_画像部分.Controls.Add(Me.lbl担当者)
        Me.grbジャーナル照会_画像部分.Location = New System.Drawing.Point(41, 20)
        Me.grbジャーナル照会_画像部分.Name = "grbジャーナル照会_画像部分"
        Me.grbジャーナル照会_画像部分.Size = New System.Drawing.Size(569, 113)
        Me.grbジャーナル照会_画像部分.TabIndex = 20
        Me.grbジャーナル照会_画像部分.TabStop = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(433, 13)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(124, 19)
        Me.DateTimePicker2.TabIndex = 141
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(283, 13)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(124, 19)
        Me.DateTimePicker1.TabIndex = 140
        '
        'frm802ジャーナル照会
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.grbジャーナル照会_画像部分)
        Me.Controls.Add(Me.dgvジャーナル照会)
        Me.Controls.Add(Me.lbl注意書き)
        Me.Controls.Add(Me.btn終了)
        Me.Controls.Add(Me.btnエクスポート)
        Me.Controls.Add(Me.btnレシート印刷)
        Me.Controls.Add(Me.btn抽出)
        Me.Name = "frm802ジャーナル照会"
        Me.Text = "ジャーナル照会"
        CType(Me.dgvジャーナル照会, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbジャーナル照会_画像部分.ResumeLayout(False)
        Me.grbジャーナル照会_画像部分.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl部門 As Label
    Friend WithEvents lbl明細区分 As Label
    Friend WithEvents lbl登録区分 As Label
    Friend WithEvents cmb担当者 As ComboBox
    Friend WithEvents cmb明細区分 As ComboBox
    Friend WithEvents cmb登録区分 As ComboBox
    Friend WithEvents lbl担当者 As Label
    Friend WithEvents cmb計上日付 As ComboBox
    Friend WithEvents lbl波線 As Label
    Friend WithEvents btn過去分レシート再発行 As Button
    Friend WithEvents btn抽出 As Button
    Friend WithEvents btnレシート印刷 As Button
    Friend WithEvents btn終了 As Button
    Friend WithEvents btnエクスポート As Button
    Friend WithEvents lbl注意書き As Label
    Friend WithEvents dgvジャーナル照会 As DataGridView
    Friend WithEvents grbジャーナル照会_画像部分 As GroupBox
    Friend WithEvents Col端末CD As DataGridViewTextBoxColumn
    Friend WithEvents col取引日時 As DataGridViewTextBoxColumn
    Friend WithEvents colレシートNO As DataGridViewTextBoxColumn
    Friend WithEvents col区分 As DataGridViewTextBoxColumn
    Friend WithEvents colNo As DataGridViewTextBoxColumn
    Friend WithEvents Col取引名 As DataGridViewTextBoxColumn
    Friend WithEvents Col数量 As DataGridViewTextBoxColumn
    Friend WithEvents Col単価 As DataGridViewTextBoxColumn
    Friend WithEvents Col金額 As DataGridViewTextBoxColumn
    Friend WithEvents Col担当者名 As DataGridViewTextBoxColumn
    Friend WithEvents Col客層名 As DataGridViewTextBoxColumn
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents cmb部門 As ComboBox
End Class
