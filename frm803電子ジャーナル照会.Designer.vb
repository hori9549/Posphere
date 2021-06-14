<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm803電子ジャーナル照会
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
        Me.grp1 = New System.Windows.Forms.GroupBox()
        Me.btn参照 = New System.Windows.Forms.Button()
        Me.txt端末 = New System.Windows.Forms.TextBox()
        Me.cmb日付１ = New System.Windows.Forms.ComboBox()
        Me.cmb日付２ = New System.Windows.Forms.ComboBox()
        Me.lst2 = New System.Windows.Forms.ListBox()
        Me.lst1 = New System.Windows.Forms.ListBox()
        Me.grpジャーナル内検索 = New System.Windows.Forms.GroupBox()
        Me.btn検索 = New System.Windows.Forms.Button()
        Me.txt分 = New System.Windows.Forms.TextBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.cmb日付3 = New System.Windows.Forms.ComboBox()
        Me.txt時 = New System.Windows.Forms.TextBox()
        Me.btnジャーナルファイル一覧 = New System.Windows.Forms.Button()
        Me.btn一覧で選択されたジャーナル = New System.Windows.Forms.Button()
        Me.btn抽出 = New System.Windows.Forms.Button()
        Me.btn印刷 = New System.Windows.Forms.Button()
        Me.btn終了 = New System.Windows.Forms.Button()
        Me.lbl精算日付 = New System.Windows.Forms.Label()
        Me.lblから = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl時間 = New System.Windows.Forms.Label()
        Me.lbl時文字 = New System.Windows.Forms.Label()
        Me.lbl分文字 = New System.Windows.Forms.Label()
        Me.lbl以降 = New System.Windows.Forms.Label()
        Me.lblJANCD = New System.Windows.Forms.Label()
        Me.grp1.SuspendLayout()
        Me.grpジャーナル内検索.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp1
        '
        Me.grp1.Controls.Add(Me.lblから)
        Me.grp1.Controls.Add(Me.lbl精算日付)
        Me.grp1.Controls.Add(Me.btn参照)
        Me.grp1.Controls.Add(Me.txt端末)
        Me.grp1.Controls.Add(Me.cmb日付１)
        Me.grp1.Controls.Add(Me.cmb日付２)
        Me.grp1.Location = New System.Drawing.Point(3, 12)
        Me.grp1.Name = "grp1"
        Me.grp1.Size = New System.Drawing.Size(694, 70)
        Me.grp1.TabIndex = 19
        Me.grp1.TabStop = False
        '
        'btn参照
        '
        Me.btn参照.Location = New System.Drawing.Point(4, 31)
        Me.btn参照.Margin = New System.Windows.Forms.Padding(2)
        Me.btn参照.Name = "btn参照"
        Me.btn参照.Size = New System.Drawing.Size(77, 23)
        Me.btn参照.TabIndex = 17
        Me.btn参照.Text = "参照"
        Me.btn参照.UseVisualStyleBackColor = True
        '
        'txt端末
        '
        Me.txt端末.Location = New System.Drawing.Point(84, 35)
        Me.txt端末.Margin = New System.Windows.Forms.Padding(2)
        Me.txt端末.Name = "txt端末"
        Me.txt端末.Size = New System.Drawing.Size(546, 19)
        Me.txt端末.TabIndex = 15
        Me.txt端末.Text = "d:\SpreadN_DJNL"
        '
        'cmb日付１
        '
        Me.cmb日付１.FormattingEnabled = True
        Me.cmb日付１.Location = New System.Drawing.Point(66, 10)
        Me.cmb日付１.Name = "cmb日付１"
        Me.cmb日付１.Size = New System.Drawing.Size(86, 20)
        Me.cmb日付１.TabIndex = 14
        Me.cmb日付１.Text = "2019/11/01"
        '
        'cmb日付２
        '
        Me.cmb日付２.FormattingEnabled = True
        Me.cmb日付２.Location = New System.Drawing.Point(181, 8)
        Me.cmb日付２.Name = "cmb日付２"
        Me.cmb日付２.Size = New System.Drawing.Size(81, 20)
        Me.cmb日付２.TabIndex = 15
        Me.cmb日付２.Text = "2019/11/04"
        '
        'lst2
        '
        Me.lst2.FormattingEnabled = True
        Me.lst2.ItemHeight = 12
        Me.lst2.Location = New System.Drawing.Point(393, 128)
        Me.lst2.Margin = New System.Windows.Forms.Padding(2)
        Me.lst2.Name = "lst2"
        Me.lst2.Size = New System.Drawing.Size(387, 592)
        Me.lst2.TabIndex = 18
        '
        'lst1
        '
        Me.lst1.FormattingEnabled = True
        Me.lst1.ItemHeight = 12
        Me.lst1.Location = New System.Drawing.Point(3, 128)
        Me.lst1.Margin = New System.Windows.Forms.Padding(2)
        Me.lst1.Name = "lst1"
        Me.lst1.Size = New System.Drawing.Size(387, 592)
        Me.lst1.TabIndex = 17
        '
        'grpジャーナル内検索
        '
        Me.grpジャーナル内検索.Controls.Add(Me.lblJANCD)
        Me.grpジャーナル内検索.Controls.Add(Me.lbl以降)
        Me.grpジャーナル内検索.Controls.Add(Me.lbl分文字)
        Me.grpジャーナル内検索.Controls.Add(Me.lbl時文字)
        Me.grpジャーナル内検索.Controls.Add(Me.lbl時間)
        Me.grpジャーナル内検索.Controls.Add(Me.Label1)
        Me.grpジャーナル内検索.Controls.Add(Me.btn検索)
        Me.grpジャーナル内検索.Controls.Add(Me.txt分)
        Me.grpジャーナル内検索.Controls.Add(Me.txt1)
        Me.grpジャーナル内検索.Controls.Add(Me.cmb日付3)
        Me.grpジャーナル内検索.Controls.Add(Me.txt時)
        Me.grpジャーナル内検索.Location = New System.Drawing.Point(786, 88)
        Me.grpジャーナル内検索.Name = "grpジャーナル内検索"
        Me.grpジャーナル内検索.Size = New System.Drawing.Size(219, 632)
        Me.grpジャーナル内検索.TabIndex = 22
        Me.grpジャーナル内検索.TabStop = False
        Me.grpジャーナル内検索.Text = "ジャーナル内検索"
        '
        'btn検索
        '
        Me.btn検索.Location = New System.Drawing.Point(143, 117)
        Me.btn検索.Name = "btn検索"
        Me.btn検索.Size = New System.Drawing.Size(68, 28)
        Me.btn検索.TabIndex = 23
        Me.btn検索.Text = "検索"
        Me.btn検索.UseVisualStyleBackColor = True
        '
        'txt分
        '
        Me.txt分.Location = New System.Drawing.Point(117, 52)
        Me.txt分.Margin = New System.Windows.Forms.Padding(2)
        Me.txt分.Name = "txt分"
        Me.txt分.Size = New System.Drawing.Size(19, 19)
        Me.txt分.TabIndex = 20
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(73, 78)
        Me.txt1.Margin = New System.Windows.Forms.Padding(2)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(113, 19)
        Me.txt1.TabIndex = 18
        '
        'cmb日付3
        '
        Me.cmb日付3.FormattingEnabled = True
        Me.cmb日付3.Location = New System.Drawing.Point(73, 21)
        Me.cmb日付3.Name = "cmb日付3"
        Me.cmb日付3.Size = New System.Drawing.Size(113, 20)
        Me.cmb日付3.TabIndex = 15
        Me.cmb日付3.Text = "2019/11/01"
        '
        'txt時
        '
        Me.txt時.Location = New System.Drawing.Point(73, 52)
        Me.txt時.Margin = New System.Windows.Forms.Padding(2)
        Me.txt時.Name = "txt時"
        Me.txt時.Size = New System.Drawing.Size(19, 19)
        Me.txt時.TabIndex = 1
        '
        'btnジャーナルファイル一覧
        '
        Me.btnジャーナルファイル一覧.Location = New System.Drawing.Point(3, 88)
        Me.btnジャーナルファイル一覧.Name = "btnジャーナルファイル一覧"
        Me.btnジャーナルファイル一覧.Size = New System.Drawing.Size(387, 35)
        Me.btnジャーナルファイル一覧.TabIndex = 23
        Me.btnジャーナルファイル一覧.Text = "ジャーナルファイル一覧"
        Me.btnジャーナルファイル一覧.UseVisualStyleBackColor = True
        '
        'btn一覧で選択されたジャーナル
        '
        Me.btn一覧で選択されたジャーナル.Location = New System.Drawing.Point(393, 88)
        Me.btn一覧で選択されたジャーナル.Name = "btn一覧で選択されたジャーナル"
        Me.btn一覧で選択されたジャーナル.Size = New System.Drawing.Size(387, 35)
        Me.btn一覧で選択されたジャーナル.TabIndex = 24
        Me.btn一覧で選択されたジャーナル.Text = "一覧で選択されたジャーナルの表示"
        Me.btn一覧で選択されたジャーナル.UseVisualStyleBackColor = True
        '
        'btn抽出
        '
        Me.btn抽出.Location = New System.Drawing.Point(713, 20)
        Me.btn抽出.Margin = New System.Windows.Forms.Padding(2)
        Me.btn抽出.Name = "btn抽出"
        Me.btn抽出.Size = New System.Drawing.Size(51, 22)
        Me.btn抽出.TabIndex = 24
        Me.btn抽出.Text = "抽出"
        Me.btn抽出.UseVisualStyleBackColor = True
        '
        'btn印刷
        '
        Me.btn印刷.Location = New System.Drawing.Point(870, 20)
        Me.btn印刷.Margin = New System.Windows.Forms.Padding(2)
        Me.btn印刷.Name = "btn印刷"
        Me.btn印刷.Size = New System.Drawing.Size(56, 22)
        Me.btn印刷.TabIndex = 25
        Me.btn印刷.Text = "印刷"
        Me.btn印刷.UseVisualStyleBackColor = True
        '
        'btn終了
        '
        Me.btn終了.Location = New System.Drawing.Point(947, 20)
        Me.btn終了.Margin = New System.Windows.Forms.Padding(2)
        Me.btn終了.Name = "btn終了"
        Me.btn終了.Size = New System.Drawing.Size(51, 22)
        Me.btn終了.TabIndex = 26
        Me.btn終了.Tag = ""
        Me.btn終了.Text = "終了(C)"
        Me.btn終了.UseVisualStyleBackColor = True
        '
        'lbl精算日付
        '
        Me.lbl精算日付.AutoSize = True
        Me.lbl精算日付.Location = New System.Drawing.Point(6, 13)
        Me.lbl精算日付.Name = "lbl精算日付"
        Me.lbl精算日付.Size = New System.Drawing.Size(53, 12)
        Me.lbl精算日付.TabIndex = 18
        Me.lbl精算日付.Text = "精算日付"
        '
        'lblから
        '
        Me.lblから.AutoSize = True
        Me.lblから.Location = New System.Drawing.Point(158, 15)
        Me.lblから.Name = "lblから"
        Me.lblから.Size = New System.Drawing.Size(17, 12)
        Me.lblから.TabIndex = 19
        Me.lblから.Text = "～"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "日付"
        '
        'lbl時間
        '
        Me.lbl時間.AutoSize = True
        Me.lbl時間.Location = New System.Drawing.Point(11, 55)
        Me.lbl時間.Name = "lbl時間"
        Me.lbl時間.Size = New System.Drawing.Size(29, 12)
        Me.lbl時間.TabIndex = 25
        Me.lbl時間.Text = "時間"
        '
        'lbl時文字
        '
        Me.lbl時文字.AutoSize = True
        Me.lbl時文字.Location = New System.Drawing.Point(95, 55)
        Me.lbl時文字.Name = "lbl時文字"
        Me.lbl時文字.Size = New System.Drawing.Size(17, 12)
        Me.lbl時文字.TabIndex = 26
        Me.lbl時文字.Text = "時"
        '
        'lbl分文字
        '
        Me.lbl分文字.AutoSize = True
        Me.lbl分文字.Location = New System.Drawing.Point(146, 55)
        Me.lbl分文字.Name = "lbl分文字"
        Me.lbl分文字.Size = New System.Drawing.Size(17, 12)
        Me.lbl分文字.TabIndex = 27
        Me.lbl分文字.Text = "分"
        '
        'lbl以降
        '
        Me.lbl以降.AutoSize = True
        Me.lbl以降.Location = New System.Drawing.Point(181, 55)
        Me.lbl以降.Name = "lbl以降"
        Me.lbl以降.Size = New System.Drawing.Size(29, 12)
        Me.lbl以降.TabIndex = 28
        Me.lbl以降.Text = "以降"
        '
        'lblJANCD
        '
        Me.lblJANCD.AutoSize = True
        Me.lblJANCD.Location = New System.Drawing.Point(11, 81)
        Me.lblJANCD.Name = "lblJANCD"
        Me.lblJANCD.Size = New System.Drawing.Size(44, 12)
        Me.lblJANCD.TabIndex = 29
        Me.lblJANCD.Text = "JANCD"
        '
        'frm電子ジャーナル照会
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.btn抽出)
        Me.Controls.Add(Me.btn印刷)
        Me.Controls.Add(Me.btn終了)
        Me.Controls.Add(Me.btn一覧で選択されたジャーナル)
        Me.Controls.Add(Me.btnジャーナルファイル一覧)
        Me.Controls.Add(Me.grpジャーナル内検索)
        Me.Controls.Add(Me.grp1)
        Me.Controls.Add(Me.lst2)
        Me.Controls.Add(Me.lst1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm電子ジャーナル照会"
        Me.Text = "電子ジャーナル照会"
        Me.grp1.ResumeLayout(False)
        Me.grp1.PerformLayout()
        Me.grpジャーナル内検索.ResumeLayout(False)
        Me.grpジャーナル内検索.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp1 As GroupBox
    Friend WithEvents txt端末 As TextBox
    Friend WithEvents cmb日付１ As ComboBox
    Friend WithEvents cmb日付２ As ComboBox
    Friend WithEvents lst2 As ListBox
    Friend WithEvents lst1 As ListBox
    Friend WithEvents btn参照 As Button
    Friend WithEvents grpジャーナル内検索 As GroupBox
    Friend WithEvents cmb日付3 As ComboBox
    Friend WithEvents txt時 As TextBox
    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt分 As TextBox
    Friend WithEvents btn検索 As Button
    Friend WithEvents btnジャーナルファイル一覧 As Button
    Friend WithEvents btn一覧で選択されたジャーナル As Button
    Friend WithEvents btn抽出 As Button
    Friend WithEvents btn印刷 As Button
    Friend WithEvents btn終了 As Button
    Friend WithEvents lblから As Label
    Friend WithEvents lbl精算日付 As Label
    Friend WithEvents lbl以降 As Label
    Friend WithEvents lbl分文字 As Label
    Friend WithEvents lbl時文字 As Label
    Friend WithEvents lbl時間 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblJANCD As Label
End Class
