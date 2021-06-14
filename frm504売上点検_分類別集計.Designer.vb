<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm504売上点検_分類別集計
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
        Me.grp入力項目.Controls.Add(Me.btn終了)
        Me.grp入力項目.Controls.Add(Me.btn印刷)
        Me.grp入力項目.Controls.Add(Me.btn集計)
        Me.grp入力項目.Location = New System.Drawing.Point(11, 11)
        Me.grp入力項目.Name = "grp入力項目"
        Me.grp入力項目.Size = New System.Drawing.Size(985, 72)
        Me.grp入力項目.TabIndex = 22
        Me.grp入力項目.TabStop = False
        '
        'frm504売上点検_分類別集計
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.grp検索項目)
        Me.Controls.Add(Me.grp入力項目)
        Me.Name = "frm504売上点検_分類別集計"
        Me.Text = "売上点検_分類別集計"
        CType(Me.grp検索項目, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp入力項目.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grp検索項目 As DataGridView
    Friend WithEvents btn終了 As Button
    Friend WithEvents btn印刷 As Button
    Friend WithEvents btn集計 As Button
    Friend WithEvents grp入力項目 As GroupBox
End Class
