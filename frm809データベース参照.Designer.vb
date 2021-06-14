<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm809データベース参照
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
        Me.lblテーブル = New System.Windows.Forms.Label()
        Me.cmbDPOS管理 = New System.Windows.Forms.ComboBox()
        Me.btn終了 = New System.Windows.Forms.Button()
        Me.btnエクスポート = New System.Windows.Forms.Button()
        Me.btn条件クリア = New System.Windows.Forms.Button()
        Me.bun抽出 = New System.Windows.Forms.Button()
        Me.lbl検索条件 = New System.Windows.Forms.Label()
        Me.cmb条件１ = New System.Windows.Forms.ComboBox()
        Me.cmb条件１記号 = New System.Windows.Forms.ComboBox()
        Me.txt条件１値 = New System.Windows.Forms.TextBox()
        Me.txt条件２値 = New System.Windows.Forms.TextBox()
        Me.cmb条件２記号 = New System.Windows.Forms.ComboBox()
        Me.cmb条件２ = New System.Windows.Forms.ComboBox()
        Me.txt条件４値 = New System.Windows.Forms.TextBox()
        Me.cmb条件４記号 = New System.Windows.Forms.ComboBox()
        Me.cmb条件４ = New System.Windows.Forms.ComboBox()
        Me.txt条件３値 = New System.Windows.Forms.TextBox()
        Me.cmb条件３記号 = New System.Windows.Forms.ComboBox()
        Me.cmb条件３ = New System.Windows.Forms.ComboBox()
        Me.txt条件６値 = New System.Windows.Forms.TextBox()
        Me.cmb条件６記号 = New System.Windows.Forms.ComboBox()
        Me.cmb条件６ = New System.Windows.Forms.ComboBox()
        Me.txt条件５値 = New System.Windows.Forms.TextBox()
        Me.cmb条件５記号 = New System.Windows.Forms.ComboBox()
        Me.cmb条件５ = New System.Windows.Forms.ComboBox()
        Me.txt条件８値 = New System.Windows.Forms.TextBox()
        Me.cmb条件８記号 = New System.Windows.Forms.ComboBox()
        Me.cmb条件８ = New System.Windows.Forms.ComboBox()
        Me.txt条件７値 = New System.Windows.Forms.TextBox()
        Me.cmb条件７記号 = New System.Windows.Forms.ComboBox()
        Me.cmb条件７ = New System.Windows.Forms.ComboBox()
        Me.dgvデータベース参照 = New System.Windows.Forms.DataGridView()
        CType(Me.dgvデータベース参照, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblテーブル
        '
        Me.lblテーブル.AutoSize = True
        Me.lblテーブル.Location = New System.Drawing.Point(33, 42)
        Me.lblテーブル.Name = "lblテーブル"
        Me.lblテーブル.Size = New System.Drawing.Size(43, 12)
        Me.lblテーブル.TabIndex = 0
        Me.lblテーブル.Text = "テーブル"
        '
        'cmbDPOS管理
        '
        Me.cmbDPOS管理.FormattingEnabled = True
        Me.cmbDPOS管理.Location = New System.Drawing.Point(82, 39)
        Me.cmbDPOS管理.Name = "cmbDPOS管理"
        Me.cmbDPOS管理.Size = New System.Drawing.Size(311, 20)
        Me.cmbDPOS管理.TabIndex = 1
        Me.cmbDPOS管理.Text = "DPOS管理"
        '
        'btn終了
        '
        Me.btn終了.Location = New System.Drawing.Point(896, 17)
        Me.btn終了.Name = "btn終了"
        Me.btn終了.Size = New System.Drawing.Size(88, 42)
        Me.btn終了.TabIndex = 28
        Me.btn終了.Text = "終了"
        Me.btn終了.UseVisualStyleBackColor = True
        '
        'btnエクスポート
        '
        Me.btnエクスポート.Location = New System.Drawing.Point(729, 17)
        Me.btnエクスポート.Name = "btnエクスポート"
        Me.btnエクスポート.Size = New System.Drawing.Size(88, 42)
        Me.btnエクスポート.TabIndex = 27
        Me.btnエクスポート.Text = "エクスポート"
        Me.btnエクスポート.UseVisualStyleBackColor = True
        '
        'btn条件クリア
        '
        Me.btn条件クリア.Location = New System.Drawing.Point(813, 17)
        Me.btn条件クリア.Name = "btn条件クリア"
        Me.btn条件クリア.Size = New System.Drawing.Size(88, 42)
        Me.btn条件クリア.TabIndex = 26
        Me.btn条件クリア.Text = "条件クリア"
        Me.btn条件クリア.UseVisualStyleBackColor = True
        '
        'bun抽出
        '
        Me.bun抽出.Location = New System.Drawing.Point(645, 17)
        Me.bun抽出.Name = "bun抽出"
        Me.bun抽出.Size = New System.Drawing.Size(88, 42)
        Me.bun抽出.TabIndex = 29
        Me.bun抽出.Text = "抽出"
        Me.bun抽出.UseVisualStyleBackColor = True
        '
        'lbl検索条件
        '
        Me.lbl検索条件.AutoSize = True
        Me.lbl検索条件.Location = New System.Drawing.Point(27, 86)
        Me.lbl検索条件.Name = "lbl検索条件"
        Me.lbl検索条件.Size = New System.Drawing.Size(53, 12)
        Me.lbl検索条件.TabIndex = 30
        Me.lbl検索条件.Text = "検索条件"
        '
        'cmb条件１
        '
        Me.cmb条件１.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb条件１.FormattingEnabled = True
        Me.cmb条件１.Location = New System.Drawing.Point(83, 83)
        Me.cmb条件１.Name = "cmb条件１"
        Me.cmb条件１.Size = New System.Drawing.Size(247, 20)
        Me.cmb条件１.TabIndex = 31
        '
        'cmb条件１記号
        '
        Me.cmb条件１記号.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb条件１記号.FormattingEnabled = True
        Me.cmb条件１記号.Items.AddRange(New Object() {"", "=", "<", ">", "<=", ">=", "!=", "Like"})
        Me.cmb条件１記号.Location = New System.Drawing.Point(336, 83)
        Me.cmb条件１記号.Name = "cmb条件１記号"
        Me.cmb条件１記号.Size = New System.Drawing.Size(75, 20)
        Me.cmb条件１記号.TabIndex = 32
        '
        'txt条件１値
        '
        Me.txt条件１値.Location = New System.Drawing.Point(417, 83)
        Me.txt条件１値.Name = "txt条件１値"
        Me.txt条件１値.Size = New System.Drawing.Size(111, 19)
        Me.txt条件１値.TabIndex = 33
        '
        'txt条件２値
        '
        Me.txt条件２値.Location = New System.Drawing.Point(868, 83)
        Me.txt条件２値.Name = "txt条件２値"
        Me.txt条件２値.Size = New System.Drawing.Size(111, 19)
        Me.txt条件２値.TabIndex = 36
        '
        'cmb条件２記号
        '
        Me.cmb条件２記号.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb条件２記号.FormattingEnabled = True
        Me.cmb条件２記号.Items.AddRange(New Object() {"", "=", "<", ">", "<=", ">=", "!=", "Like"})
        Me.cmb条件２記号.Location = New System.Drawing.Point(787, 83)
        Me.cmb条件２記号.Name = "cmb条件２記号"
        Me.cmb条件２記号.Size = New System.Drawing.Size(75, 20)
        Me.cmb条件２記号.TabIndex = 35
        '
        'cmb条件２
        '
        Me.cmb条件２.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb条件２.FormattingEnabled = True
        Me.cmb条件２.Location = New System.Drawing.Point(534, 83)
        Me.cmb条件２.Name = "cmb条件２"
        Me.cmb条件２.Size = New System.Drawing.Size(247, 20)
        Me.cmb条件２.TabIndex = 34
        '
        'txt条件４値
        '
        Me.txt条件４値.Location = New System.Drawing.Point(868, 109)
        Me.txt条件４値.Name = "txt条件４値"
        Me.txt条件４値.Size = New System.Drawing.Size(111, 19)
        Me.txt条件４値.TabIndex = 42
        '
        'cmb条件４記号
        '
        Me.cmb条件４記号.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb条件４記号.FormattingEnabled = True
        Me.cmb条件４記号.Items.AddRange(New Object() {"", "=", "<", ">", "<=", ">=", "!=", "Like"})
        Me.cmb条件４記号.Location = New System.Drawing.Point(787, 109)
        Me.cmb条件４記号.Name = "cmb条件４記号"
        Me.cmb条件４記号.Size = New System.Drawing.Size(75, 20)
        Me.cmb条件４記号.TabIndex = 41
        '
        'cmb条件４
        '
        Me.cmb条件４.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb条件４.FormattingEnabled = True
        Me.cmb条件４.Location = New System.Drawing.Point(534, 109)
        Me.cmb条件４.Name = "cmb条件４"
        Me.cmb条件４.Size = New System.Drawing.Size(247, 20)
        Me.cmb条件４.TabIndex = 40
        '
        'txt条件３値
        '
        Me.txt条件３値.Location = New System.Drawing.Point(417, 109)
        Me.txt条件３値.Name = "txt条件３値"
        Me.txt条件３値.Size = New System.Drawing.Size(111, 19)
        Me.txt条件３値.TabIndex = 39
        '
        'cmb条件３記号
        '
        Me.cmb条件３記号.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb条件３記号.FormattingEnabled = True
        Me.cmb条件３記号.Items.AddRange(New Object() {"", "=", "<", ">", "<=", ">=", "!=", "Like"})
        Me.cmb条件３記号.Location = New System.Drawing.Point(336, 109)
        Me.cmb条件３記号.Name = "cmb条件３記号"
        Me.cmb条件３記号.Size = New System.Drawing.Size(75, 20)
        Me.cmb条件３記号.TabIndex = 38
        '
        'cmb条件３
        '
        Me.cmb条件３.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb条件３.FormattingEnabled = True
        Me.cmb条件３.Location = New System.Drawing.Point(83, 109)
        Me.cmb条件３.Name = "cmb条件３"
        Me.cmb条件３.Size = New System.Drawing.Size(247, 20)
        Me.cmb条件３.TabIndex = 37
        '
        'txt条件６値
        '
        Me.txt条件６値.Location = New System.Drawing.Point(868, 135)
        Me.txt条件６値.Name = "txt条件６値"
        Me.txt条件６値.Size = New System.Drawing.Size(111, 19)
        Me.txt条件６値.TabIndex = 48
        '
        'cmb条件６記号
        '
        Me.cmb条件６記号.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb条件６記号.FormattingEnabled = True
        Me.cmb条件６記号.Items.AddRange(New Object() {"", "=", "<", ">", "<=", ">=", "!=", "Like"})
        Me.cmb条件６記号.Location = New System.Drawing.Point(787, 135)
        Me.cmb条件６記号.Name = "cmb条件６記号"
        Me.cmb条件６記号.Size = New System.Drawing.Size(75, 20)
        Me.cmb条件６記号.TabIndex = 47
        '
        'cmb条件６
        '
        Me.cmb条件６.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb条件６.FormattingEnabled = True
        Me.cmb条件６.Location = New System.Drawing.Point(534, 135)
        Me.cmb条件６.Name = "cmb条件６"
        Me.cmb条件６.Size = New System.Drawing.Size(247, 20)
        Me.cmb条件６.TabIndex = 46
        '
        'txt条件５値
        '
        Me.txt条件５値.Location = New System.Drawing.Point(417, 135)
        Me.txt条件５値.Name = "txt条件５値"
        Me.txt条件５値.Size = New System.Drawing.Size(111, 19)
        Me.txt条件５値.TabIndex = 45
        '
        'cmb条件５記号
        '
        Me.cmb条件５記号.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb条件５記号.FormattingEnabled = True
        Me.cmb条件５記号.Items.AddRange(New Object() {"", "=", "<", ">", "<=", ">=", "!=", "Like"})
        Me.cmb条件５記号.Location = New System.Drawing.Point(336, 135)
        Me.cmb条件５記号.Name = "cmb条件５記号"
        Me.cmb条件５記号.Size = New System.Drawing.Size(75, 20)
        Me.cmb条件５記号.TabIndex = 44
        '
        'cmb条件５
        '
        Me.cmb条件５.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb条件５.FormattingEnabled = True
        Me.cmb条件５.Location = New System.Drawing.Point(83, 135)
        Me.cmb条件５.Name = "cmb条件５"
        Me.cmb条件５.Size = New System.Drawing.Size(247, 20)
        Me.cmb条件５.TabIndex = 43
        '
        'txt条件８値
        '
        Me.txt条件８値.Location = New System.Drawing.Point(868, 161)
        Me.txt条件８値.Name = "txt条件８値"
        Me.txt条件８値.Size = New System.Drawing.Size(111, 19)
        Me.txt条件８値.TabIndex = 54
        '
        'cmb条件８記号
        '
        Me.cmb条件８記号.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb条件８記号.FormattingEnabled = True
        Me.cmb条件８記号.Items.AddRange(New Object() {"", "=", "<", ">", "<=", ">=", "!=", "Like"})
        Me.cmb条件８記号.Location = New System.Drawing.Point(787, 161)
        Me.cmb条件８記号.Name = "cmb条件８記号"
        Me.cmb条件８記号.Size = New System.Drawing.Size(75, 20)
        Me.cmb条件８記号.TabIndex = 53
        '
        'cmb条件８
        '
        Me.cmb条件８.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb条件８.FormattingEnabled = True
        Me.cmb条件８.Location = New System.Drawing.Point(534, 161)
        Me.cmb条件８.Name = "cmb条件８"
        Me.cmb条件８.Size = New System.Drawing.Size(247, 20)
        Me.cmb条件８.TabIndex = 52
        '
        'txt条件７値
        '
        Me.txt条件７値.Location = New System.Drawing.Point(417, 161)
        Me.txt条件７値.Name = "txt条件７値"
        Me.txt条件７値.Size = New System.Drawing.Size(111, 19)
        Me.txt条件７値.TabIndex = 51
        '
        'cmb条件７記号
        '
        Me.cmb条件７記号.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb条件７記号.FormattingEnabled = True
        Me.cmb条件７記号.Items.AddRange(New Object() {"", "=", "<", ">", "<=", ">=", "!=", "Like"})
        Me.cmb条件７記号.Location = New System.Drawing.Point(336, 161)
        Me.cmb条件７記号.Name = "cmb条件７記号"
        Me.cmb条件７記号.Size = New System.Drawing.Size(75, 20)
        Me.cmb条件７記号.TabIndex = 50
        '
        'cmb条件７
        '
        Me.cmb条件７.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb条件７.FormattingEnabled = True
        Me.cmb条件７.Location = New System.Drawing.Point(83, 161)
        Me.cmb条件７.Name = "cmb条件７"
        Me.cmb条件７.Size = New System.Drawing.Size(247, 20)
        Me.cmb条件７.TabIndex = 49
        '
        'dgvデータベース参照
        '
        Me.dgvデータベース参照.AllowUserToAddRows = False
        Me.dgvデータベース参照.AllowUserToDeleteRows = False
        Me.dgvデータベース参照.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvデータベース参照.Location = New System.Drawing.Point(3, 193)
        Me.dgvデータベース参照.Name = "dgvデータベース参照"
        Me.dgvデータベース参照.ReadOnly = True
        Me.dgvデータベース参照.RowTemplate.Height = 21
        Me.dgvデータベース参照.Size = New System.Drawing.Size(981, 524)
        Me.dgvデータベース参照.TabIndex = 55
        '
        'frm106データベース参照
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.dgvデータベース参照)
        Me.Controls.Add(Me.txt条件８値)
        Me.Controls.Add(Me.cmb条件８記号)
        Me.Controls.Add(Me.cmb条件８)
        Me.Controls.Add(Me.txt条件７値)
        Me.Controls.Add(Me.cmb条件７記号)
        Me.Controls.Add(Me.cmb条件７)
        Me.Controls.Add(Me.txt条件６値)
        Me.Controls.Add(Me.cmb条件６記号)
        Me.Controls.Add(Me.cmb条件６)
        Me.Controls.Add(Me.txt条件５値)
        Me.Controls.Add(Me.cmb条件５記号)
        Me.Controls.Add(Me.cmb条件５)
        Me.Controls.Add(Me.txt条件４値)
        Me.Controls.Add(Me.cmb条件４記号)
        Me.Controls.Add(Me.cmb条件４)
        Me.Controls.Add(Me.txt条件３値)
        Me.Controls.Add(Me.cmb条件３記号)
        Me.Controls.Add(Me.cmb条件３)
        Me.Controls.Add(Me.txt条件２値)
        Me.Controls.Add(Me.cmb条件２記号)
        Me.Controls.Add(Me.cmb条件２)
        Me.Controls.Add(Me.txt条件１値)
        Me.Controls.Add(Me.cmb条件１記号)
        Me.Controls.Add(Me.cmb条件１)
        Me.Controls.Add(Me.lbl検索条件)
        Me.Controls.Add(Me.bun抽出)
        Me.Controls.Add(Me.btn終了)
        Me.Controls.Add(Me.btnエクスポート)
        Me.Controls.Add(Me.btn条件クリア)
        Me.Controls.Add(Me.cmbDPOS管理)
        Me.Controls.Add(Me.lblテーブル)
        Me.Name = "frm106データベース参照"
        Me.Text = "データベース参照"
        CType(Me.dgvデータベース参照, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblテーブル As Label
    Friend WithEvents cmbDPOS管理 As ComboBox
    Friend WithEvents btn終了 As Button
    Friend WithEvents btnエクスポート As Button
    Friend WithEvents btn条件クリア As Button
    Friend WithEvents bun抽出 As Button
    Friend WithEvents lbl検索条件 As Label
    Friend WithEvents cmb条件１ As ComboBox
    Friend WithEvents cmb条件１記号 As ComboBox
    Friend WithEvents txt条件１値 As TextBox
    Friend WithEvents txt条件２値 As TextBox
    Friend WithEvents cmb条件２記号 As ComboBox
    Friend WithEvents cmb条件２ As ComboBox
    Friend WithEvents txt条件４値 As TextBox
    Friend WithEvents cmb条件４記号 As ComboBox
    Friend WithEvents cmb条件４ As ComboBox
    Friend WithEvents txt条件３値 As TextBox
    Friend WithEvents cmb条件３記号 As ComboBox
    Friend WithEvents cmb条件３ As ComboBox
    Friend WithEvents txt条件６値 As TextBox
    Friend WithEvents cmb条件６記号 As ComboBox
    Friend WithEvents cmb条件６ As ComboBox
    Friend WithEvents txt条件５値 As TextBox
    Friend WithEvents cmb条件５記号 As ComboBox
    Friend WithEvents cmb条件５ As ComboBox
    Friend WithEvents txt条件８値 As TextBox
    Friend WithEvents cmb条件８記号 As ComboBox
    Friend WithEvents cmb条件８ As ComboBox
    Friend WithEvents txt条件７値 As TextBox
    Friend WithEvents cmb条件７記号 As ComboBox
    Friend WithEvents cmb条件７ As ComboBox
    Friend WithEvents dgvデータベース参照 As DataGridView
End Class
