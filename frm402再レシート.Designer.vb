<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm402再レシート
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
        Me.lbl発行したい云々 = New System.Windows.Forms.Label()
        Me.btn食券再発行 = New System.Windows.Forms.Button()
        Me.btn印刷 = New System.Windows.Forms.Button()
        Me.btn閉じる = New System.Windows.Forms.Button()
        Me.dgv一覧 = New System.Windows.Forms.DataGridView()
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl発行したい云々
        '
        Me.lbl発行したい云々.AutoSize = True
        Me.lbl発行したい云々.Font = New System.Drawing.Font("MS UI Gothic", 11.0!)
        Me.lbl発行したい云々.Location = New System.Drawing.Point(45, 46)
        Me.lbl発行したい云々.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl発行したい云々.Name = "lbl発行したい云々"
        Me.lbl発行したい云々.Size = New System.Drawing.Size(682, 22)
        Me.lbl発行したい云々.TabIndex = 0
        Me.lbl発行したい云々.Text = "※発行を行いたい会計を下記リストより選択し、印刷ボタンを押下して下さい。"
        '
        'btn食券再発行
        '
        Me.btn食券再発行.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
        Me.btn食券再発行.Location = New System.Drawing.Point(1223, 30)
        Me.btn食券再発行.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn食券再発行.Name = "btn食券再発行"
        Me.btn食券再発行.Size = New System.Drawing.Size(133, 60)
        Me.btn食券再発行.TabIndex = 1
        Me.btn食券再発行.Text = "食券再発行"
        Me.btn食券再発行.UseVisualStyleBackColor = True
        '
        'btn印刷
        '
        Me.btn印刷.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
        Me.btn印刷.Location = New System.Drawing.Point(1358, 30)
        Me.btn印刷.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn印刷.Name = "btn印刷"
        Me.btn印刷.Size = New System.Drawing.Size(133, 60)
        Me.btn印刷.TabIndex = 2
        Me.btn印刷.Text = "印刷"
        Me.btn印刷.UseVisualStyleBackColor = True
        '
        'btn閉じる
        '
        Me.btn閉じる.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
        Me.btn閉じる.Location = New System.Drawing.Point(1493, 30)
        Me.btn閉じる.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn閉じる.Name = "btn閉じる"
        Me.btn閉じる.Size = New System.Drawing.Size(133, 60)
        Me.btn閉じる.TabIndex = 3
        Me.btn閉じる.Text = "閉じる"
        Me.btn閉じる.UseVisualStyleBackColor = True
        '
        'dgv一覧
        '
        Me.dgv一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv一覧.Location = New System.Drawing.Point(83, 98)
        Me.dgv一覧.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dgv一覧.Name = "dgv一覧"
        Me.dgv一覧.RowHeadersWidth = 62
        Me.dgv一覧.RowTemplate.Height = 21
        Me.dgv一覧.Size = New System.Drawing.Size(1553, 564)
        Me.dgv一覧.TabIndex = 6
        '
        'frm402再レシート
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1680, 1050)
        Me.Controls.Add(Me.dgv一覧)
        Me.Controls.Add(Me.btn閉じる)
        Me.Controls.Add(Me.btn印刷)
        Me.Controls.Add(Me.btn食券再発行)
        Me.Controls.Add(Me.lbl発行したい云々)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frm402再レシート"
        Me.Text = "再レシート"
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl発行したい云々 As Label
    Friend WithEvents btn食券再発行 As Button
    Friend WithEvents btn印刷 As Button
    Friend WithEvents btn閉じる As Button
    Friend WithEvents dgv一覧 As DataGridView
End Class
