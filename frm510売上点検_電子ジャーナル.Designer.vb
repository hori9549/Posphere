<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm510売上点検_電子ジャーナル
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
        Me.btn終了 = New System.Windows.Forms.Button()
        Me.btn印刷 = New System.Windows.Forms.Button()
        Me.btn集計 = New System.Windows.Forms.Button()
        Me.grp入力項目 = New System.Windows.Forms.GroupBox()
        Me.lbl部門 = New System.Windows.Forms.Label()
        Me.grp電子ジャーナル = New System.Windows.Forms.GroupBox()
        Me.cmb表示内容 = New System.Windows.Forms.ComboBox()
        Me.gupジャーナル = New System.Windows.Forms.GroupBox()
        Me.btn検索 = New System.Windows.Forms.Button()
        Me.txtJANCD = New System.Windows.Forms.TextBox()
        Me.lblJANCD = New System.Windows.Forms.Label()
        Me.txt分 = New System.Windows.Forms.TextBox()
        Me.txt時 = New System.Windows.Forms.TextBox()
        Me.lbl以降 = New System.Windows.Forms.Label()
        Me.lbl分 = New System.Windows.Forms.Label()
        Me.lbl時 = New System.Windows.Forms.Label()
        Me.lbl時間 = New System.Windows.Forms.Label()
        Me.lbl表示内容 = New System.Windows.Forms.Label()
        Me.but表示 = New System.Windows.Forms.Button()
        Me.lst表示内容 = New System.Windows.Forms.ListBox()
        Me.grp入力項目.SuspendLayout()
        Me.grp電子ジャーナル.SuspendLayout()
        Me.gupジャーナル.SuspendLayout()
        Me.SuspendLayout()
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
        Me.grp入力項目.Controls.Add(Me.btn終了)
        Me.grp入力項目.Controls.Add(Me.btn印刷)
        Me.grp入力項目.Controls.Add(Me.btn集計)
        Me.grp入力項目.Controls.Add(Me.lbl部門)
        Me.grp入力項目.Location = New System.Drawing.Point(11, 11)
        Me.grp入力項目.Name = "grp入力項目"
        Me.grp入力項目.Size = New System.Drawing.Size(985, 72)
        Me.grp入力項目.TabIndex = 22
        Me.grp入力項目.TabStop = False
        '
        'lbl部門
        '
        Me.lbl部門.AutoSize = True
        Me.lbl部門.Location = New System.Drawing.Point(187, 59)
        Me.lbl部門.Name = "lbl部門"
        Me.lbl部門.Size = New System.Drawing.Size(0, 12)
        Me.lbl部門.TabIndex = 5
        '
        'grp電子ジャーナル
        '
        Me.grp電子ジャーナル.Controls.Add(Me.cmb表示内容)
        Me.grp電子ジャーナル.Controls.Add(Me.gupジャーナル)
        Me.grp電子ジャーナル.Controls.Add(Me.lbl表示内容)
        Me.grp電子ジャーナル.Controls.Add(Me.but表示)
        Me.grp電子ジャーナル.Controls.Add(Me.lst表示内容)
        Me.grp電子ジャーナル.Location = New System.Drawing.Point(11, 89)
        Me.grp電子ジャーナル.Name = "grp電子ジャーナル"
        Me.grp電子ジャーナル.Size = New System.Drawing.Size(695, 628)
        Me.grp電子ジャーナル.TabIndex = 28
        Me.grp電子ジャーナル.TabStop = False
        '
        'cmb表示内容
        '
        Me.cmb表示内容.FormattingEnabled = True
        Me.cmb表示内容.Location = New System.Drawing.Point(82, 29)
        Me.cmb表示内容.Name = "cmb表示内容"
        Me.cmb表示内容.Size = New System.Drawing.Size(145, 20)
        Me.cmb表示内容.TabIndex = 1
        Me.cmb表示内容.Text = "全て"
        '
        'gupジャーナル
        '
        Me.gupジャーナル.Controls.Add(Me.btn検索)
        Me.gupジャーナル.Controls.Add(Me.txtJANCD)
        Me.gupジャーナル.Controls.Add(Me.lblJANCD)
        Me.gupジャーナル.Controls.Add(Me.txt分)
        Me.gupジャーナル.Controls.Add(Me.txt時)
        Me.gupジャーナル.Controls.Add(Me.lbl以降)
        Me.gupジャーナル.Controls.Add(Me.lbl分)
        Me.gupジャーナル.Controls.Add(Me.lbl時)
        Me.gupジャーナル.Controls.Add(Me.lbl時間)
        Me.gupジャーナル.Location = New System.Drawing.Point(432, 16)
        Me.gupジャーナル.Name = "gupジャーナル"
        Me.gupジャーナル.Size = New System.Drawing.Size(241, 160)
        Me.gupジャーナル.TabIndex = 4
        Me.gupジャーナル.TabStop = False
        Me.gupジャーナル.Text = "ジャーナル内検索"
        '
        'btn検索
        '
        Me.btn検索.Location = New System.Drawing.Point(143, 102)
        Me.btn検索.Name = "btn検索"
        Me.btn検索.Size = New System.Drawing.Size(90, 46)
        Me.btn検索.TabIndex = 5
        Me.btn検索.Text = "検索"
        Me.btn検索.UseVisualStyleBackColor = True
        '
        'txtJANCD
        '
        Me.txtJANCD.Location = New System.Drawing.Point(64, 64)
        Me.txtJANCD.Name = "txtJANCD"
        Me.txtJANCD.Size = New System.Drawing.Size(130, 19)
        Me.txtJANCD.TabIndex = 11
        '
        'lblJANCD
        '
        Me.lblJANCD.AutoSize = True
        Me.lblJANCD.Location = New System.Drawing.Point(12, 67)
        Me.lblJANCD.Name = "lblJANCD"
        Me.lblJANCD.Size = New System.Drawing.Size(44, 12)
        Me.lblJANCD.TabIndex = 10
        Me.lblJANCD.Text = "JANCD"
        '
        'txt分
        '
        Me.txt分.Location = New System.Drawing.Point(120, 29)
        Me.txt分.Name = "txt分"
        Me.txt分.Size = New System.Drawing.Size(32, 19)
        Me.txt分.TabIndex = 9
        '
        'txt時
        '
        Me.txt時.Location = New System.Drawing.Point(64, 29)
        Me.txt時.Name = "txt時"
        Me.txt時.Size = New System.Drawing.Size(32, 19)
        Me.txt時.TabIndex = 5
        '
        'lbl以降
        '
        Me.lbl以降.AutoSize = True
        Me.lbl以降.Location = New System.Drawing.Point(189, 32)
        Me.lbl以降.Name = "lbl以降"
        Me.lbl以降.Size = New System.Drawing.Size(29, 12)
        Me.lbl以降.TabIndex = 8
        Me.lbl以降.Text = "以降"
        '
        'lbl分
        '
        Me.lbl分.AutoSize = True
        Me.lbl分.Location = New System.Drawing.Point(156, 32)
        Me.lbl分.Name = "lbl分"
        Me.lbl分.Size = New System.Drawing.Size(17, 12)
        Me.lbl分.TabIndex = 7
        Me.lbl分.Text = "分"
        '
        'lbl時
        '
        Me.lbl時.AutoSize = True
        Me.lbl時.Location = New System.Drawing.Point(100, 32)
        Me.lbl時.Name = "lbl時"
        Me.lbl時.Size = New System.Drawing.Size(17, 12)
        Me.lbl時.TabIndex = 6
        Me.lbl時.Text = "時"
        '
        'lbl時間
        '
        Me.lbl時間.AutoSize = True
        Me.lbl時間.Location = New System.Drawing.Point(19, 33)
        Me.lbl時間.Name = "lbl時間"
        Me.lbl時間.Size = New System.Drawing.Size(29, 12)
        Me.lbl時間.TabIndex = 5
        Me.lbl時間.Text = "時間"
        '
        'lbl表示内容
        '
        Me.lbl表示内容.AutoSize = True
        Me.lbl表示内容.Location = New System.Drawing.Point(18, 33)
        Me.lbl表示内容.Name = "lbl表示内容"
        Me.lbl表示内容.Size = New System.Drawing.Size(69, 12)
        Me.lbl表示内容.TabIndex = 0
        Me.lbl表示内容.Text = "　表示内容　"
        '
        'but表示
        '
        Me.but表示.Location = New System.Drawing.Point(336, 15)
        Me.but表示.Name = "but表示"
        Me.but表示.Size = New System.Drawing.Size(90, 46)
        Me.but表示.TabIndex = 3
        Me.but表示.Text = "表示(H)"
        Me.but表示.UseVisualStyleBackColor = True
        '
        'lst表示内容
        '
        Me.lst表示内容.FormattingEnabled = True
        Me.lst表示内容.ItemHeight = 12
        Me.lst表示内容.Location = New System.Drawing.Point(20, 64)
        Me.lst表示内容.Name = "lst表示内容"
        Me.lst表示内容.Size = New System.Drawing.Size(406, 544)
        Me.lst表示内容.TabIndex = 2
        '
        'frm510売上点検_電子ジャーナル
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.grp電子ジャーナル)
        Me.Controls.Add(Me.grp入力項目)
        Me.Name = "frm510売上点検_電子ジャーナル"
        Me.Text = "売上点検_電子ジャーナル"
        Me.grp入力項目.ResumeLayout(False)
        Me.grp入力項目.PerformLayout()
        Me.grp電子ジャーナル.ResumeLayout(False)
        Me.grp電子ジャーナル.PerformLayout()
        Me.gupジャーナル.ResumeLayout(False)
        Me.gupジャーナル.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn終了 As Button
    Friend WithEvents btn印刷 As Button
    Friend WithEvents btn集計 As Button
    Friend WithEvents grp入力項目 As GroupBox
    Friend WithEvents lbl部門 As Label
    Friend WithEvents grp電子ジャーナル As GroupBox
    Friend WithEvents cmb表示内容 As ComboBox
    Friend WithEvents gupジャーナル As GroupBox
    Friend WithEvents btn検索 As Button
    Friend WithEvents txtJANCD As TextBox
    Friend WithEvents lblJANCD As Label
    Friend WithEvents txt分 As TextBox
    Friend WithEvents txt時 As TextBox
    Friend WithEvents lbl以降 As Label
    Friend WithEvents lbl分 As Label
    Friend WithEvents lbl時 As Label
    Friend WithEvents lbl時間 As Label
    Friend WithEvents lbl表示内容 As Label
    Friend WithEvents but表示 As Button
    Friend WithEvents lst表示内容 As ListBox
End Class
