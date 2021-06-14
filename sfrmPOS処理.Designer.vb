<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sfrmPOS処理
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sfrmPOS処理))
        Me.grb登録ステータス = New System.Windows.Forms.GroupBox()
        Me.btn精算 = New System.Windows.Forms.Button()
        Me.rdo登録 = New System.Windows.Forms.RadioButton()
        Me.rdo練習 = New System.Windows.Forms.RadioButton()
        Me.rdo点検 = New System.Windows.Forms.RadioButton()
        Me.rdo訂正 = New System.Windows.Forms.RadioButton()
        Me.btn終了 = New System.Windows.Forms.Button()
        Me.rdo管理 = New System.Windows.Forms.RadioButton()
        Me.grb登録ステータス.SuspendLayout()
        Me.SuspendLayout()
        '
        'grb登録ステータス
        '
        Me.grb登録ステータス.Controls.Add(Me.rdo管理)
        Me.grb登録ステータス.Controls.Add(Me.btn精算)
        Me.grb登録ステータス.Controls.Add(Me.rdo登録)
        Me.grb登録ステータス.Controls.Add(Me.rdo練習)
        Me.grb登録ステータス.Controls.Add(Me.rdo点検)
        Me.grb登録ステータス.Controls.Add(Me.rdo訂正)
        Me.grb登録ステータス.Controls.Add(Me.btn終了)
        Me.grb登録ステータス.Location = New System.Drawing.Point(10, 5)
        Me.grb登録ステータス.Name = "grb登録ステータス"
        Me.grb登録ステータス.Size = New System.Drawing.Size(506, 82)
        Me.grb登録ステータス.TabIndex = 0
        Me.grb登録ステータス.TabStop = False
        '
        'btn精算
        '
        Me.btn精算.BackgroundImage = CType(resources.GetObject("btn精算.BackgroundImage"), System.Drawing.Image)
        Me.btn精算.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn精算.FlatAppearance.BorderSize = 0
        Me.btn精算.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn精算.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn精算.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn精算.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn精算.Location = New System.Drawing.Point(216, 9)
        Me.btn精算.Name = "btn精算"
        Me.btn精算.Size = New System.Drawing.Size(70, 60)
        Me.btn精算.TabIndex = 178
        Me.btn精算.Text = "精算"
        Me.btn精算.UseVisualStyleBackColor = False
        '
        'rdo登録
        '
        Me.rdo登録.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdo登録.BackgroundImage = CType(resources.GetObject("rdo登録.BackgroundImage"), System.Drawing.Image)
        Me.rdo登録.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rdo登録.FlatAppearance.BorderSize = 0
        Me.rdo登録.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.rdo登録.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.rdo登録.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.rdo登録.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdo登録.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdo登録.Location = New System.Drawing.Point(6, 9)
        Me.rdo登録.Name = "rdo登録"
        Me.rdo登録.Size = New System.Drawing.Size(70, 60)
        Me.rdo登録.TabIndex = 0
        Me.rdo登録.Text = "登録"
        Me.rdo登録.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdo登録.UseVisualStyleBackColor = True
        '
        'rdo練習
        '
        Me.rdo練習.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdo練習.BackgroundImage = CType(resources.GetObject("rdo練習.BackgroundImage"), System.Drawing.Image)
        Me.rdo練習.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rdo練習.FlatAppearance.BorderSize = 0
        Me.rdo練習.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.rdo練習.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.rdo練習.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.rdo練習.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdo練習.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdo練習.Location = New System.Drawing.Point(356, 9)
        Me.rdo練習.Name = "rdo練習"
        Me.rdo練習.Size = New System.Drawing.Size(70, 60)
        Me.rdo練習.TabIndex = 3
        Me.rdo練習.Text = "練習"
        Me.rdo練習.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdo練習.UseVisualStyleBackColor = True
        '
        'rdo点検
        '
        Me.rdo点検.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdo点検.BackgroundImage = CType(resources.GetObject("rdo点検.BackgroundImage"), System.Drawing.Image)
        Me.rdo点検.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rdo点検.FlatAppearance.BorderSize = 0
        Me.rdo点検.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.rdo点検.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.rdo点検.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.rdo点検.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdo点検.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdo点検.Location = New System.Drawing.Point(146, 9)
        Me.rdo点検.Name = "rdo点検"
        Me.rdo点検.Size = New System.Drawing.Size(70, 60)
        Me.rdo点検.TabIndex = 2
        Me.rdo点検.Text = "点検"
        Me.rdo点検.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdo点検.UseVisualStyleBackColor = True
        '
        'rdo訂正
        '
        Me.rdo訂正.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdo訂正.BackgroundImage = CType(resources.GetObject("rdo訂正.BackgroundImage"), System.Drawing.Image)
        Me.rdo訂正.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rdo訂正.FlatAppearance.BorderSize = 0
        Me.rdo訂正.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.rdo訂正.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.rdo訂正.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.rdo訂正.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdo訂正.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdo訂正.Location = New System.Drawing.Point(76, 9)
        Me.rdo訂正.Name = "rdo訂正"
        Me.rdo訂正.Size = New System.Drawing.Size(70, 60)
        Me.rdo訂正.TabIndex = 1
        Me.rdo訂正.Text = "訂正"
        Me.rdo訂正.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdo訂正.UseVisualStyleBackColor = True
        '
        'btn終了
        '
        Me.btn終了.BackgroundImage = CType(resources.GetObject("btn終了.BackgroundImage"), System.Drawing.Image)
        Me.btn終了.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn終了.FlatAppearance.BorderSize = 0
        Me.btn終了.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn終了.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn終了.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn終了.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn終了.Location = New System.Drawing.Point(426, 9)
        Me.btn終了.Name = "btn終了"
        Me.btn終了.Size = New System.Drawing.Size(70, 60)
        Me.btn終了.TabIndex = 4
        Me.btn終了.Text = "終了"
        Me.btn終了.UseVisualStyleBackColor = False
        '
        'rdo管理
        '
        Me.rdo管理.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdo管理.BackgroundImage = CType(resources.GetObject("rdo管理.BackgroundImage"), System.Drawing.Image)
        Me.rdo管理.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rdo管理.FlatAppearance.BorderSize = 0
        Me.rdo管理.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.rdo管理.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.rdo管理.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.rdo管理.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdo管理.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdo管理.Location = New System.Drawing.Point(286, 9)
        Me.rdo管理.Name = "rdo管理"
        Me.rdo管理.Size = New System.Drawing.Size(70, 60)
        Me.rdo管理.TabIndex = 179
        Me.rdo管理.Text = "管理"
        Me.rdo管理.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdo管理.UseVisualStyleBackColor = True
        '
        'sfrmPOS処理
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 93)
        Me.ControlBox = False
        Me.Controls.Add(Me.grb登録ステータス)
        Me.Name = "sfrmPOS処理"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "POS処理"
        Me.grb登録ステータス.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grb登録ステータス As System.Windows.Forms.GroupBox
    Friend WithEvents btn終了 As System.Windows.Forms.Button
    Friend WithEvents rdo練習 As System.Windows.Forms.RadioButton
    Friend WithEvents rdo点検 As System.Windows.Forms.RadioButton
    Friend WithEvents rdo訂正 As System.Windows.Forms.RadioButton
    Friend WithEvents rdo登録 As System.Windows.Forms.RadioButton
    Friend WithEvents btn精算 As System.Windows.Forms.Button
    Friend WithEvents rdo管理 As RadioButton
End Class
