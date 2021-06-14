<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm817マスタ反映
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
        Me.btn実行 = New System.Windows.Forms.Button()
        Me.btnキャンセル = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt更新日時 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt最上部 = New System.Windows.Forms.TextBox()
        Me.chb1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn実行
        '
        Me.btn実行.Location = New System.Drawing.Point(252, 48)
        Me.btn実行.Name = "btn実行"
        Me.btn実行.Size = New System.Drawing.Size(75, 30)
        Me.btn実行.TabIndex = 0
        Me.btn実行.Text = "実行"
        Me.btn実行.UseVisualStyleBackColor = True
        '
        'btnキャンセル
        '
        Me.btnキャンセル.Location = New System.Drawing.Point(325, 48)
        Me.btnキャンセル.Name = "btnキャンセル"
        Me.btnキャンセル.Size = New System.Drawing.Size(75, 30)
        Me.btnキャンセル.TabIndex = 1
        Me.btnキャンセル.Text = "キャンセル"
        Me.btnキャンセル.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.BackgroundImageTiled = True
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(27, 153)
        Me.ListView1.MaximumSize = New System.Drawing.Size(421, 291)
        Me.ListView1.MinimumSize = New System.Drawing.Size(421, 291)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(421, 291)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(27, 128)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(421, 19)
        Me.txt1.TabIndex = 4
        '
        'txt更新日時
        '
        Me.txt更新日時.Location = New System.Drawing.Point(27, 103)
        Me.txt更新日時.Name = "txt更新日時"
        Me.txt更新日時.Size = New System.Drawing.Size(421, 19)
        Me.txt更新日時.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt最上部)
        Me.GroupBox1.Controls.Add(Me.btnキャンセル)
        Me.GroupBox1.Controls.Add(Me.btn実行)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(421, 89)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'txt最上部
        '
        Me.txt最上部.Font = New System.Drawing.Font("MS UI Gothic", 15.0!)
        Me.txt最上部.Location = New System.Drawing.Point(0, 0)
        Me.txt最上部.Multiline = True
        Me.txt最上部.Name = "txt最上部"
        Me.txt最上部.Size = New System.Drawing.Size(421, 25)
        Me.txt最上部.TabIndex = 2
        Me.txt最上部.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chb1
        '
        Me.chb1.AutoSize = True
        Me.chb1.Location = New System.Drawing.Point(38, 169)
        Me.chb1.Name = "chb1"
        Me.chb1.Size = New System.Drawing.Size(15, 14)
        Me.chb1.TabIndex = 7
        Me.chb1.UseVisualStyleBackColor = True
        '
        'frm817マスタ反映
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 464)
        Me.Controls.Add(Me.chb1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt更新日時)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "frm817マスタ反映"
        Me.Text = "frmマスタ反映"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn実行 As Button
    Friend WithEvents btnキャンセル As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt更新日時 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt最上部 As TextBox
    Friend WithEvents chb1 As CheckBox
End Class
