<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm819日付時刻変更
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
        Me.btn反映 = New System.Windows.Forms.Button()
        Me.btnキャンセル = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'btn反映
        '
        Me.btn反映.Location = New System.Drawing.Point(316, 278)
        Me.btn反映.Name = "btn反映"
        Me.btn反映.Size = New System.Drawing.Size(139, 50)
        Me.btn反映.TabIndex = 0
        Me.btn反映.Text = "反映"
        Me.btn反映.UseVisualStyleBackColor = True
        '
        'btnキャンセル
        '
        Me.btnキャンセル.Location = New System.Drawing.Point(461, 278)
        Me.btnキャンセル.Name = "btnキャンセル"
        Me.btnキャンセル.Size = New System.Drawing.Size(139, 50)
        Me.btnキャンセル.TabIndex = 1
        Me.btnキャンセル.Text = "キャンセル"
        Me.btnキャンセル.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(73, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(490, 63)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "①　変更したい箇所(年/月/日/時/分)をタッチ又はクリック" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "②　△▽をタッチ又はクリックし、日付/時刻を変更" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "③　反映ボタンをタッチ又はクリック"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker1.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.DateTimePicker1.Font = New System.Drawing.Font("MS UI Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(77, 63)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(486, 34)
        Me.DateTimePicker1.TabIndex = 6
        '
        'frm819日付時刻変更
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 340)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnキャンセル)
        Me.Controls.Add(Me.btn反映)
        Me.Name = "frm819日付時刻変更"
        Me.Text = "日付時刻変更"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn反映 As Button
    Friend WithEvents btnキャンセル As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
