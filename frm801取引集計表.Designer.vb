<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm801取引集計表
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
        Me.grp入力項目 = New System.Windows.Forms.GroupBox()
        Me.Dtp終 = New System.Windows.Forms.DateTimePicker()
        Me.Dtp日付始 = New System.Windows.Forms.DateTimePicker()
        Me.lbl集計区分 = New System.Windows.Forms.Label()
        Me.cmb出力順昇降 = New System.Windows.Forms.ComboBox()
        Me.lbl出力順 = New System.Windows.Forms.Label()
        Me.cmb出力順項目 = New System.Windows.Forms.ComboBox()
        Me.lbl部門 = New System.Windows.Forms.Label()
        Me.lbl担当者 = New System.Windows.Forms.Label()
        Me.lbl波線 = New System.Windows.Forms.Label()
        Me.cmb計上日付 = New System.Windows.Forms.ComboBox()
        Me.cmb集計区分 = New System.Windows.Forms.ComboBox()
        Me.cmb担当者 = New System.Windows.Forms.ComboBox()
        Me.cmb部門 = New System.Windows.Forms.ComboBox()
        Me.btn集計 = New System.Windows.Forms.Button()
        Me.btnレシート印刷 = New System.Windows.Forms.Button()
        Me.btnエクスポート = New System.Windows.Forms.Button()
        Me.btn終了 = New System.Windows.Forms.Button()
        Me.Dgv検索項目 = New System.Windows.Forms.DataGridView()
        Me.grp入力項目.SuspendLayout()
        CType(Me.Dgv検索項目, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp入力項目
        '
        Me.grp入力項目.Controls.Add(Me.Dtp終)
        Me.grp入力項目.Controls.Add(Me.Dtp日付始)
        Me.grp入力項目.Controls.Add(Me.lbl集計区分)
        Me.grp入力項目.Controls.Add(Me.cmb出力順昇降)
        Me.grp入力項目.Controls.Add(Me.lbl出力順)
        Me.grp入力項目.Controls.Add(Me.cmb出力順項目)
        Me.grp入力項目.Controls.Add(Me.lbl部門)
        Me.grp入力項目.Controls.Add(Me.lbl担当者)
        Me.grp入力項目.Controls.Add(Me.lbl波線)
        Me.grp入力項目.Controls.Add(Me.cmb計上日付)
        Me.grp入力項目.Controls.Add(Me.cmb集計区分)
        Me.grp入力項目.Controls.Add(Me.cmb担当者)
        Me.grp入力項目.Controls.Add(Me.cmb部門)
        Me.grp入力項目.Location = New System.Drawing.Point(10, 10)
        Me.grp入力項目.Name = "grp入力項目"
        Me.grp入力項目.Size = New System.Drawing.Size(630, 88)
        Me.grp入力項目.TabIndex = 16
        Me.grp入力項目.TabStop = False
        '
        'Dtp終
        '
        Me.Dtp終.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp終.Location = New System.Drawing.Point(513, 9)
        Me.Dtp終.Name = "Dtp終"
        Me.Dtp終.Size = New System.Drawing.Size(104, 19)
        Me.Dtp終.TabIndex = 22
        '
        'Dtp日付始
        '
        Me.Dtp日付始.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp日付始.Location = New System.Drawing.Point(380, 11)
        Me.Dtp日付始.Name = "Dtp日付始"
        Me.Dtp日付始.Size = New System.Drawing.Size(104, 19)
        Me.Dtp日付始.TabIndex = 21
        '
        'lbl集計区分
        '
        Me.lbl集計区分.AutoSize = True
        Me.lbl集計区分.Location = New System.Drawing.Point(7, 16)
        Me.lbl集計区分.Name = "lbl集計区分"
        Me.lbl集計区分.Size = New System.Drawing.Size(53, 12)
        Me.lbl集計区分.TabIndex = 3
        Me.lbl集計区分.Text = "集計区分"
        '
        'cmb出力順昇降
        '
        Me.cmb出力順昇降.FormattingEnabled = True
        Me.cmb出力順昇降.Items.AddRange(New Object() {"昇順"})
        Me.cmb出力順昇降.Location = New System.Drawing.Point(370, 59)
        Me.cmb出力順昇降.Name = "cmb出力順昇降"
        Me.cmb出力順昇降.Size = New System.Drawing.Size(255, 20)
        Me.cmb出力順昇降.TabIndex = 15
        Me.cmb出力順昇降.Text = "昇順"
        '
        'lbl出力順
        '
        Me.lbl出力順.BackColor = System.Drawing.Color.Green
        Me.lbl出力順.ForeColor = System.Drawing.Color.White
        Me.lbl出力順.Location = New System.Drawing.Point(304, 39)
        Me.lbl出力順.Name = "lbl出力順"
        Me.lbl出力順.Size = New System.Drawing.Size(60, 40)
        Me.lbl出力順.TabIndex = 4
        Me.lbl出力順.Text = "出 力 順"
        Me.lbl出力順.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb出力順項目
        '
        Me.cmb出力順項目.FormattingEnabled = True
        Me.cmb出力順項目.Location = New System.Drawing.Point(370, 36)
        Me.cmb出力順項目.Name = "cmb出力順項目"
        Me.cmb出力順項目.Size = New System.Drawing.Size(255, 20)
        Me.cmb出力順項目.TabIndex = 14
        Me.cmb出力順項目.Text = "コード"
        '
        'lbl部門
        '
        Me.lbl部門.BackColor = System.Drawing.Color.Green
        Me.lbl部門.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl部門.ForeColor = System.Drawing.Color.White
        Me.lbl部門.Location = New System.Drawing.Point(24, 59)
        Me.lbl部門.Name = "lbl部門"
        Me.lbl部門.Size = New System.Drawing.Size(51, 20)
        Me.lbl部門.TabIndex = 5
        Me.lbl部門.Text = "部 門"
        Me.lbl部門.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl担当者
        '
        Me.lbl担当者.AutoSize = True
        Me.lbl担当者.Location = New System.Drawing.Point(7, 39)
        Me.lbl担当者.Name = "lbl担当者"
        Me.lbl担当者.Size = New System.Drawing.Size(41, 12)
        Me.lbl担当者.TabIndex = 6
        Me.lbl担当者.Text = "担当者"
        '
        'lbl波線
        '
        Me.lbl波線.AutoSize = True
        Me.lbl波線.Location = New System.Drawing.Point(490, 16)
        Me.lbl波線.Name = "lbl波線"
        Me.lbl波線.Size = New System.Drawing.Size(17, 12)
        Me.lbl波線.TabIndex = 7
        Me.lbl波線.Text = "～"
        '
        'cmb計上日付
        '
        Me.cmb計上日付.FormattingEnabled = True
        Me.cmb計上日付.Items.AddRange(New Object() {"計上日付"})
        Me.cmb計上日付.Location = New System.Drawing.Point(295, 13)
        Me.cmb計上日付.Name = "cmb計上日付"
        Me.cmb計上日付.Size = New System.Drawing.Size(75, 20)
        Me.cmb計上日付.TabIndex = 11
        Me.cmb計上日付.Text = "計上日付"
        '
        'cmb集計区分
        '
        Me.cmb集計区分.FormattingEnabled = True
        Me.cmb集計区分.Location = New System.Drawing.Point(81, 13)
        Me.cmb集計区分.Name = "cmb集計区分"
        Me.cmb集計区分.Size = New System.Drawing.Size(206, 20)
        Me.cmb集計区分.TabIndex = 8
        Me.cmb集計区分.Text = " 集計区分を選択してください"
        '
        'cmb担当者
        '
        Me.cmb担当者.FormattingEnabled = True
        Me.cmb担当者.Location = New System.Drawing.Point(81, 36)
        Me.cmb担当者.Name = "cmb担当者"
        Me.cmb担当者.Size = New System.Drawing.Size(206, 20)
        Me.cmb担当者.TabIndex = 10
        Me.cmb担当者.Text = "全て"
        '
        'cmb部門
        '
        Me.cmb部門.FormattingEnabled = True
        Me.cmb部門.Location = New System.Drawing.Point(81, 59)
        Me.cmb部門.Name = "cmb部門"
        Me.cmb部門.Size = New System.Drawing.Size(206, 20)
        Me.cmb部門.TabIndex = 9
        Me.cmb部門.Text = "全て"
        '
        'btn集計
        '
        Me.btn集計.Location = New System.Drawing.Point(649, 14)
        Me.btn集計.Name = "btn集計"
        Me.btn集計.Size = New System.Drawing.Size(86, 32)
        Me.btn集計.TabIndex = 17
        Me.btn集計.Text = "集計"
        Me.btn集計.UseVisualStyleBackColor = True
        '
        'btnレシート印刷
        '
        Me.btnレシート印刷.Location = New System.Drawing.Point(736, 14)
        Me.btnレシート印刷.Name = "btnレシート印刷"
        Me.btnレシート印刷.Size = New System.Drawing.Size(86, 32)
        Me.btnレシート印刷.TabIndex = 18
        Me.btnレシート印刷.Text = "ﾚｼｰﾄ印刷"
        Me.btnレシート印刷.UseVisualStyleBackColor = True
        '
        'btnエクスポート
        '
        Me.btnエクスポート.Location = New System.Drawing.Point(823, 14)
        Me.btnエクスポート.Name = "btnエクスポート"
        Me.btnエクスポート.Size = New System.Drawing.Size(86, 32)
        Me.btnエクスポート.TabIndex = 19
        Me.btnエクスポート.Text = "ｴｸｽﾎﾟｰﾄ"
        Me.btnエクスポート.UseVisualStyleBackColor = True
        '
        'btn終了
        '
        Me.btn終了.Location = New System.Drawing.Point(910, 14)
        Me.btn終了.Name = "btn終了"
        Me.btn終了.Size = New System.Drawing.Size(86, 32)
        Me.btn終了.TabIndex = 20
        Me.btn終了.Text = "終了(C)"
        Me.btn終了.UseVisualStyleBackColor = True
        '
        'Dgv検索項目
        '
        Me.Dgv検索項目.AllowUserToAddRows = False
        Me.Dgv検索項目.AllowUserToDeleteRows = False
        Me.Dgv検索項目.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv検索項目.Location = New System.Drawing.Point(19, 104)
        Me.Dgv検索項目.Name = "Dgv検索項目"
        Me.Dgv検索項目.ReadOnly = True
        Me.Dgv検索項目.RowHeadersWidth = 51
        Me.Dgv検索項目.RowTemplate.Height = 21
        Me.Dgv検索項目.Size = New System.Drawing.Size(968, 575)
        Me.Dgv検索項目.TabIndex = 21
        '
        'frm801取引集計表
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.Dgv検索項目)
        Me.Controls.Add(Me.btn終了)
        Me.Controls.Add(Me.btnエクスポート)
        Me.Controls.Add(Me.btnレシート印刷)
        Me.Controls.Add(Me.btn集計)
        Me.Controls.Add(Me.grp入力項目)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm801取引集計表"
        Me.Text = "frm取引集計表"
        Me.grp入力項目.ResumeLayout(False)
        Me.grp入力項目.PerformLayout()
        CType(Me.Dgv検索項目, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grp入力項目 As GroupBox
    Friend WithEvents lbl集計区分 As Label
    Friend WithEvents cmb出力順昇降 As ComboBox
    Friend WithEvents lbl出力順 As Label
    Friend WithEvents cmb出力順項目 As ComboBox
    Friend WithEvents lbl部門 As Label
    Friend WithEvents lbl担当者 As Label
    Friend WithEvents lbl波線 As Label
    Friend WithEvents cmb計上日付 As ComboBox
    Friend WithEvents cmb集計区分 As ComboBox
    Friend WithEvents cmb担当者 As ComboBox
    Friend WithEvents cmb部門 As ComboBox
    Friend WithEvents btn集計 As Button
    Friend WithEvents btnレシート印刷 As Button
    Friend WithEvents btnエクスポート As Button
    Friend WithEvents btn終了 As Button
    Friend WithEvents Dtp終 As DateTimePicker
    Friend WithEvents Dtp日付始 As DateTimePicker
    Friend WithEvents Dgv検索項目 As DataGridView
End Class
