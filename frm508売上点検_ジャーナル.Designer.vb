<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm508売上点検_ジャーナル
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
        Me.grp検索項目 = New System.Windows.Forms.DataGridView()
        Me.btn終了 = New System.Windows.Forms.Button()
        Me.btn印刷 = New System.Windows.Forms.Button()
        Me.btn集計 = New System.Windows.Forms.Button()
        Me.grp入力項目 = New System.Windows.Forms.GroupBox()
        Me.lbl注意書き = New System.Windows.Forms.Label()
        Me.txtレシートNO終端 = New System.Windows.Forms.TextBox()
        Me.lblレシートNO区間 = New System.Windows.Forms.Label()
        Me.lbl部門 = New System.Windows.Forms.Label()
        Me.cmb部門 = New System.Windows.Forms.ComboBox()
        Me.lbl明細区分 = New System.Windows.Forms.Label()
        Me.cmb明細区分 = New System.Windows.Forms.ComboBox()
        Me.lbl登録区分 = New System.Windows.Forms.Label()
        Me.cmb登録区分 = New System.Windows.Forms.ComboBox()
        Me.txtレシートNO先頭 = New System.Windows.Forms.TextBox()
        Me.lblレシートNO = New System.Windows.Forms.Label()
        Me.lbl担当者 = New System.Windows.Forms.Label()
        Me.cmb担当者 = New System.Windows.Forms.ComboBox()
        CType(Me.grp検索項目, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp入力項目.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp検索項目
        '
        Me.grp検索項目.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grp検索項目.Location = New System.Drawing.Point(11, 89)
        Me.grp検索項目.Name = "grp検索項目"
        Me.grp検索項目.RowHeadersWidth = 51
        Me.grp検索項目.RowTemplate.Height = 21
        Me.grp検索項目.Size = New System.Drawing.Size(986, 629)
        Me.grp検索項目.TabIndex = 27
        '
        'btn終了
        '
        Me.btn終了.Location = New System.Drawing.Point(893, 18)
        Me.btn終了.Name = "btn終了"
        Me.btn終了.Size = New System.Drawing.Size(86, 32)
        Me.btn終了.TabIndex = 26
        Me.btn終了.Text = "終了"
        Me.btn終了.UseVisualStyleBackColor = True
        '
        'btn印刷
        '
        Me.btn印刷.Enabled = False
        Me.btn印刷.Location = New System.Drawing.Point(808, 18)
        Me.btn印刷.Name = "btn印刷"
        Me.btn印刷.Size = New System.Drawing.Size(86, 32)
        Me.btn印刷.TabIndex = 24
        Me.btn印刷.Text = "印刷"
        Me.btn印刷.UseVisualStyleBackColor = True
        '
        'btn集計
        '
        Me.btn集計.Location = New System.Drawing.Point(723, 18)
        Me.btn集計.Name = "btn集計"
        Me.btn集計.Size = New System.Drawing.Size(86, 32)
        Me.btn集計.TabIndex = 23
        Me.btn集計.Text = "集計"
        Me.btn集計.UseVisualStyleBackColor = True
        '
        'grp入力項目
        '
        Me.grp入力項目.Controls.Add(Me.lbl注意書き)
        Me.grp入力項目.Controls.Add(Me.txtレシートNO終端)
        Me.grp入力項目.Controls.Add(Me.lblレシートNO区間)
        Me.grp入力項目.Controls.Add(Me.lbl部門)
        Me.grp入力項目.Controls.Add(Me.cmb部門)
        Me.grp入力項目.Controls.Add(Me.lbl明細区分)
        Me.grp入力項目.Controls.Add(Me.cmb明細区分)
        Me.grp入力項目.Controls.Add(Me.lbl登録区分)
        Me.grp入力項目.Controls.Add(Me.cmb登録区分)
        Me.grp入力項目.Controls.Add(Me.txtレシートNO先頭)
        Me.grp入力項目.Controls.Add(Me.lblレシートNO)
        Me.grp入力項目.Controls.Add(Me.lbl担当者)
        Me.grp入力項目.Controls.Add(Me.cmb担当者)
        Me.grp入力項目.Controls.Add(Me.btn終了)
        Me.grp入力項目.Controls.Add(Me.btn印刷)
        Me.grp入力項目.Controls.Add(Me.btn集計)
        Me.grp入力項目.Location = New System.Drawing.Point(11, 11)
        Me.grp入力項目.Name = "grp入力項目"
        Me.grp入力項目.Size = New System.Drawing.Size(985, 72)
        Me.grp入力項目.TabIndex = 22
        Me.grp入力項目.TabStop = False
        '
        'lbl注意書き
        '
        Me.lbl注意書き.AutoSize = True
        Me.lbl注意書き.ForeColor = System.Drawing.Color.Red
        Me.lbl注意書き.Location = New System.Drawing.Point(293, 47)
        Me.lbl注意書き.Name = "lbl注意書き"
        Me.lbl注意書き.Size = New System.Drawing.Size(424, 12)
        Me.lbl注意書き.TabIndex = 48
        Me.lbl注意書き.Text = "※レシートへ印刷する場合、部門・登録区分・明細区分はすべての指定で印刷されます。"
        '
        'txtレシートNO終端
        '
        Me.txtレシートNO終端.Location = New System.Drawing.Point(668, 19)
        Me.txtレシートNO終端.Name = "txtレシートNO終端"
        Me.txtレシートNO終端.Size = New System.Drawing.Size(49, 19)
        Me.txtレシートNO終端.TabIndex = 47
        Me.txtレシートNO終端.Text = "999999"
        '
        'lblレシートNO区間
        '
        Me.lblレシートNO区間.AutoSize = True
        Me.lblレシートNO区間.Location = New System.Drawing.Point(645, 22)
        Me.lblレシートNO区間.Name = "lblレシートNO区間"
        Me.lblレシートNO区間.Size = New System.Drawing.Size(17, 12)
        Me.lblレシートNO区間.TabIndex = 46
        Me.lblレシートNO区間.Text = "～"
        '
        'lbl部門
        '
        Me.lbl部門.AutoSize = True
        Me.lbl部門.Location = New System.Drawing.Point(7, 48)
        Me.lbl部門.Name = "lbl部門"
        Me.lbl部門.Size = New System.Drawing.Size(29, 12)
        Me.lbl部門.TabIndex = 44
        Me.lbl部門.Text = "部門"
        '
        'cmb部門
        '
        Me.cmb部門.FormattingEnabled = True
        Me.cmb部門.Location = New System.Drawing.Point(56, 44)
        Me.cmb部門.Name = "cmb部門"
        Me.cmb部門.Size = New System.Drawing.Size(148, 20)
        Me.cmb部門.TabIndex = 45
        Me.cmb部門.Text = "全て"
        '
        'lbl明細区分
        '
        Me.lbl明細区分.AutoSize = True
        Me.lbl明細区分.Location = New System.Drawing.Point(350, 22)
        Me.lbl明細区分.Name = "lbl明細区分"
        Me.lbl明細区分.Size = New System.Drawing.Size(53, 12)
        Me.lbl明細区分.TabIndex = 42
        Me.lbl明細区分.Text = "明細区分"
        '
        'cmb明細区分
        '
        Me.cmb明細区分.FormattingEnabled = True
        Me.cmb明細区分.Location = New System.Drawing.Point(409, 19)
        Me.cmb明細区分.Name = "cmb明細区分"
        Me.cmb明細区分.Size = New System.Drawing.Size(110, 20)
        Me.cmb明細区分.TabIndex = 43
        Me.cmb明細区分.Text = "全て"
        '
        'lbl登録区分
        '
        Me.lbl登録区分.AutoSize = True
        Me.lbl登録区分.Location = New System.Drawing.Point(224, 22)
        Me.lbl登録区分.Name = "lbl登録区分"
        Me.lbl登録区分.Size = New System.Drawing.Size(53, 12)
        Me.lbl登録区分.TabIndex = 40
        Me.lbl登録区分.Text = "登録区分"
        '
        'cmb登録区分
        '
        Me.cmb登録区分.FormattingEnabled = True
        Me.cmb登録区分.Location = New System.Drawing.Point(283, 19)
        Me.cmb登録区分.Name = "cmb登録区分"
        Me.cmb登録区分.Size = New System.Drawing.Size(52, 20)
        Me.cmb登録区分.TabIndex = 41
        Me.cmb登録区分.Text = "全て"
        '
        'txtレシートNO先頭
        '
        Me.txtレシートNO先頭.Location = New System.Drawing.Point(590, 19)
        Me.txtレシートNO先頭.Name = "txtレシートNO先頭"
        Me.txtレシートNO先頭.Size = New System.Drawing.Size(49, 19)
        Me.txtレシートNO先頭.TabIndex = 39
        Me.txtレシートNO先頭.Text = "000000"
        '
        'lblレシートNO
        '
        Me.lblレシートNO.AutoSize = True
        Me.lblレシートNO.Location = New System.Drawing.Point(535, 22)
        Me.lblレシートNO.Name = "lblレシートNO"
        Me.lblレシートNO.Size = New System.Drawing.Size(49, 12)
        Me.lblレシートNO.TabIndex = 36
        Me.lblレシートNO.Text = "ﾚｼｰﾄNo."
        '
        'lbl担当者
        '
        Me.lbl担当者.AutoSize = True
        Me.lbl担当者.Location = New System.Drawing.Point(7, 22)
        Me.lbl担当者.Name = "lbl担当者"
        Me.lbl担当者.Size = New System.Drawing.Size(41, 12)
        Me.lbl担当者.TabIndex = 37
        Me.lbl担当者.Text = "担当者"
        '
        'cmb担当者
        '
        Me.cmb担当者.FormattingEnabled = True
        Me.cmb担当者.Location = New System.Drawing.Point(56, 18)
        Me.cmb担当者.Name = "cmb担当者"
        Me.cmb担当者.Size = New System.Drawing.Size(148, 20)
        Me.cmb担当者.TabIndex = 38
        Me.cmb担当者.Text = "全て"
        '
        'frm508売上点検_ジャーナル
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.grp検索項目)
        Me.Controls.Add(Me.grp入力項目)
        Me.Name = "frm508売上点検_ジャーナル"
        Me.Text = "売上点検_ジャーナル"
        CType(Me.grp検索項目, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp入力項目.ResumeLayout(False)
        Me.grp入力項目.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grp検索項目 As DataGridView
    Friend WithEvents btn終了 As Button
    Friend WithEvents btn印刷 As Button
    Friend WithEvents btn集計 As Button
    Friend WithEvents grp入力項目 As GroupBox
    Friend WithEvents lbl注意書き As Label
    Friend WithEvents txtレシートNO終端 As TextBox
    Friend WithEvents lblレシートNO区間 As Label
    Friend WithEvents lbl部門 As Label
    Friend WithEvents cmb部門 As ComboBox
    Friend WithEvents lbl明細区分 As Label
    Friend WithEvents cmb明細区分 As ComboBox
    Friend WithEvents lbl登録区分 As Label
    Friend WithEvents cmb登録区分 As ComboBox
    Friend WithEvents txtレシートNO先頭 As TextBox
    Friend WithEvents lblレシートNO As Label
    Friend WithEvents lbl担当者 As Label
    Friend WithEvents cmb担当者 As ComboBox
End Class
