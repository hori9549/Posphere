<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm804会計集計表_エクスポート
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
        Me.btn出力 = New System.Windows.Forms.Button()
        Me.gbx上 = New System.Windows.Forms.GroupBox()
        Me.btnキャンセル = New System.Windows.Forms.Button()
        Me.lbl出力する = New System.Windows.Forms.Label()
        Me.lbl出力可能 = New System.Windows.Forms.Label()
        Me.dgv出力する = New System.Windows.Forms.DataGridView()
        Me.dgv出力可能 = New System.Windows.Forms.DataGridView()
        Me.btn全右へ = New System.Windows.Forms.Button()
        Me.btn全左へ = New System.Windows.Forms.Button()
        Me.btn単左へ = New System.Windows.Forms.Button()
        Me.btn単右へ = New System.Windows.Forms.Button()
        Me.gbx上.SuspendLayout()
        CType(Me.dgv出力する, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv出力可能, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn出力
        '
        Me.btn出力.Location = New System.Drawing.Point(745, 18)
        Me.btn出力.Name = "btn出力"
        Me.btn出力.Size = New System.Drawing.Size(115, 49)
        Me.btn出力.TabIndex = 0
        Me.btn出力.Text = "出力（O）"
        Me.btn出力.UseVisualStyleBackColor = True
        '
        'gbx上
        '
        Me.gbx上.Controls.Add(Me.btnキャンセル)
        Me.gbx上.Controls.Add(Me.btn出力)
        Me.gbx上.Location = New System.Drawing.Point(12, 27)
        Me.gbx上.Name = "gbx上"
        Me.gbx上.Size = New System.Drawing.Size(984, 78)
        Me.gbx上.TabIndex = 17
        Me.gbx上.TabStop = False
        '
        'btnキャンセル
        '
        Me.btnキャンセル.Location = New System.Drawing.Point(860, 18)
        Me.btnキャンセル.Name = "btnキャンセル"
        Me.btnキャンセル.Size = New System.Drawing.Size(115, 49)
        Me.btnキャンセル.TabIndex = 1
        Me.btnキャンセル.Text = "キャンセル（C）"
        Me.btnキャンセル.UseVisualStyleBackColor = True
        '
        'lbl出力する
        '
        Me.lbl出力する.AutoSize = True
        Me.lbl出力する.Font = New System.Drawing.Font("MS UI Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl出力する.Location = New System.Drawing.Point(708, 146)
        Me.lbl出力する.Name = "lbl出力する"
        Me.lbl出力する.Size = New System.Drawing.Size(164, 27)
        Me.lbl出力する.TabIndex = 26
        Me.lbl出力する.Text = "出力する項目"
        '
        'lbl出力可能
        '
        Me.lbl出力可能.AutoSize = True
        Me.lbl出力可能.Font = New System.Drawing.Font("MS UI Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl出力可能.Location = New System.Drawing.Point(121, 146)
        Me.lbl出力可能.Name = "lbl出力可能"
        Me.lbl出力可能.Size = New System.Drawing.Size(197, 27)
        Me.lbl出力可能.TabIndex = 25
        Me.lbl出力可能.Text = "出力可能な項目"
        '
        'dgv出力する
        '
        Me.dgv出力する.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv出力する.Location = New System.Drawing.Point(560, 193)
        Me.dgv出力する.Name = "dgv出力する"
        Me.dgv出力する.RowTemplate.Height = 21
        Me.dgv出力する.Size = New System.Drawing.Size(436, 508)
        Me.dgv出力する.TabIndex = 24
        '
        'dgv出力可能
        '
        Me.dgv出力可能.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv出力可能.Location = New System.Drawing.Point(12, 193)
        Me.dgv出力可能.Name = "dgv出力可能"
        Me.dgv出力可能.RowTemplate.Height = 21
        Me.dgv出力可能.Size = New System.Drawing.Size(436, 508)
        Me.dgv出力可能.TabIndex = 23
        '
        'btn全右へ
        '
        Me.btn全右へ.Location = New System.Drawing.Point(451, 245)
        Me.btn全右へ.Name = "btn全右へ"
        Me.btn全右へ.Size = New System.Drawing.Size(106, 46)
        Me.btn全右へ.TabIndex = 22
        Me.btn全右へ.Text = ">>"
        Me.btn全右へ.UseVisualStyleBackColor = True
        '
        'btn全左へ
        '
        Me.btn全左へ.Location = New System.Drawing.Point(451, 375)
        Me.btn全左へ.Name = "btn全左へ"
        Me.btn全左へ.Size = New System.Drawing.Size(106, 46)
        Me.btn全左へ.TabIndex = 21
        Me.btn全左へ.Text = "<<"
        Me.btn全左へ.UseVisualStyleBackColor = True
        '
        'btn単左へ
        '
        Me.btn単左へ.Location = New System.Drawing.Point(451, 323)
        Me.btn単左へ.Name = "btn単左へ"
        Me.btn単左へ.Size = New System.Drawing.Size(106, 46)
        Me.btn単左へ.TabIndex = 20
        Me.btn単左へ.Text = "＜"
        Me.btn単左へ.UseVisualStyleBackColor = True
        '
        'btn単右へ
        '
        Me.btn単右へ.Location = New System.Drawing.Point(451, 193)
        Me.btn単右へ.Name = "btn単右へ"
        Me.btn単右へ.Size = New System.Drawing.Size(106, 46)
        Me.btn単右へ.TabIndex = 18
        Me.btn単右へ.Text = "＞"
        Me.btn単右へ.UseVisualStyleBackColor = True
        '
        'frm804会計集計表_エクスポート
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.gbx上)
        Me.Controls.Add(Me.lbl出力する)
        Me.Controls.Add(Me.lbl出力可能)
        Me.Controls.Add(Me.dgv出力する)
        Me.Controls.Add(Me.dgv出力可能)
        Me.Controls.Add(Me.btn全右へ)
        Me.Controls.Add(Me.btn全左へ)
        Me.Controls.Add(Me.btn単左へ)
        Me.Controls.Add(Me.btn単右へ)
        Me.Name = "frm804会計集計表_エクスポート"
        Me.Text = "frm804会計集計表_エクスポート"
        Me.gbx上.ResumeLayout(False)
        CType(Me.dgv出力する, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv出力可能, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn出力 As Button
    Friend WithEvents gbx上 As GroupBox
    Friend WithEvents btnキャンセル As Button
    Friend WithEvents lbl出力する As Label
    Friend WithEvents lbl出力可能 As Label
    Friend WithEvents dgv出力する As DataGridView
    Friend WithEvents dgv出力可能 As DataGridView
    Friend WithEvents btn全右へ As Button
    Friend WithEvents btn全左へ As Button
    Friend WithEvents btn単左へ As Button
    Friend WithEvents btn単右へ As Button
End Class
