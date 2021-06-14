<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm404領収書印刷
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
        Me.btn印刷 = New System.Windows.Forms.Button()
        Me.btn閉じる = New System.Windows.Forms.Button()
        Me.lbl発行 = New System.Windows.Forms.Label()
        Me.dgv一覧 = New System.Windows.Forms.DataGridView()
        Me.col日付 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col時刻 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colレシートNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col区分 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col点数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col金額 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col客層 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col担当 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn印刷
        '
        Me.btn印刷.Location = New System.Drawing.Point(1293, 46)
        Me.btn印刷.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn印刷.Name = "btn印刷"
        Me.btn印刷.Size = New System.Drawing.Size(163, 64)
        Me.btn印刷.TabIndex = 0
        Me.btn印刷.Text = "印刷"
        Me.btn印刷.UseVisualStyleBackColor = True
        '
        'btn閉じる
        '
        Me.btn閉じる.Location = New System.Drawing.Point(1467, 46)
        Me.btn閉じる.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn閉じる.Name = "btn閉じる"
        Me.btn閉じる.Size = New System.Drawing.Size(163, 64)
        Me.btn閉じる.TabIndex = 1
        Me.btn閉じる.Text = "閉じる"
        Me.btn閉じる.UseVisualStyleBackColor = True
        '
        'lbl発行
        '
        Me.lbl発行.AutoSize = True
        Me.lbl発行.Location = New System.Drawing.Point(27, 69)
        Me.lbl発行.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl発行.Name = "lbl発行"
        Me.lbl発行.Size = New System.Drawing.Size(558, 18)
        Me.lbl発行.TabIndex = 2
        Me.lbl発行.Text = "※発行を行いたい会計を下記リストより選択し、印刷ボタンを押下して下さい。"
        '
        'dgv一覧
        '
        Me.dgv一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv一覧.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col日付, Me.col時刻, Me.colレシートNO, Me.col区分, Me.col点数, Me.col金額, Me.col客層, Me.col担当})
        Me.dgv一覧.Location = New System.Drawing.Point(20, 128)
        Me.dgv一覧.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dgv一覧.Name = "dgv一覧"
        Me.dgv一覧.RowHeadersWidth = 62
        Me.dgv一覧.RowTemplate.Height = 21
        Me.dgv一覧.Size = New System.Drawing.Size(1610, 948)
        Me.dgv一覧.TabIndex = 3
        '
        'col日付
        '
        Me.col日付.DataPropertyName = "日付"
        Me.col日付.HeaderText = "日付"
        Me.col日付.MinimumWidth = 8
        Me.col日付.Name = "col日付"
        Me.col日付.Width = 80
        '
        'col時刻
        '
        Me.col時刻.DataPropertyName = "時刻"
        Me.col時刻.HeaderText = "時刻"
        Me.col時刻.MinimumWidth = 8
        Me.col時刻.Name = "col時刻"
        Me.col時刻.Width = 80
        '
        'colレシートNO
        '
        Me.colレシートNO.DataPropertyName = "レシートNO"
        Me.colレシートNO.HeaderText = "レシートNO"
        Me.colレシートNO.MinimumWidth = 8
        Me.colレシートNO.Name = "colレシートNO"
        Me.colレシートNO.Width = 80
        '
        'col区分
        '
        Me.col区分.DataPropertyName = "区分"
        Me.col区分.HeaderText = "区分"
        Me.col区分.MinimumWidth = 8
        Me.col区分.Name = "col区分"
        Me.col区分.Width = 70
        '
        'col点数
        '
        Me.col点数.DataPropertyName = "点数"
        Me.col点数.HeaderText = "点数"
        Me.col点数.MinimumWidth = 8
        Me.col点数.Name = "col点数"
        Me.col点数.Width = 70
        '
        'col金額
        '
        Me.col金額.DataPropertyName = "金額"
        Me.col金額.HeaderText = "金額"
        Me.col金額.MinimumWidth = 8
        Me.col金額.Name = "col金額"
        Me.col金額.Width = 140
        '
        'col客層
        '
        Me.col客層.DataPropertyName = "客層"
        Me.col客層.HeaderText = "客層"
        Me.col客層.MinimumWidth = 8
        Me.col客層.Name = "col客層"
        Me.col客層.Width = 201
        '
        'col担当
        '
        Me.col担当.DataPropertyName = "担当"
        Me.col担当.HeaderText = "担当"
        Me.col担当.MinimumWidth = 8
        Me.col担当.Name = "col担当"
        Me.col担当.Width = 201
        '
        'frm404領収書印刷
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1680, 1050)
        Me.Controls.Add(Me.dgv一覧)
        Me.Controls.Add(Me.lbl発行)
        Me.Controls.Add(Me.btn閉じる)
        Me.Controls.Add(Me.btn印刷)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frm404領収書印刷"
        Me.Text = "領収書印刷"
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn印刷 As Button
    Friend WithEvents btn閉じる As Button
    Friend WithEvents lbl発行 As Label
    Friend WithEvents dgv一覧 As DataGridView
    Friend WithEvents col日付 As DataGridViewTextBoxColumn
    Friend WithEvents col時刻 As DataGridViewTextBoxColumn
    Friend WithEvents colレシートNO As DataGridViewTextBoxColumn
    Friend WithEvents col区分 As DataGridViewTextBoxColumn
    Friend WithEvents col点数 As DataGridViewTextBoxColumn
    Friend WithEvents col金額 As DataGridViewTextBoxColumn
    Friend WithEvents col客層 As DataGridViewTextBoxColumn
    Friend WithEvents col担当 As DataGridViewTextBoxColumn
End Class
