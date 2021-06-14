<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm305EXE設定
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
        Me.btn左 = New System.Windows.Forms.Button()
        Me.btn参照 = New System.Windows.Forms.Button()
        Me.btn消去 = New System.Windows.Forms.Button()
        Me.btn閉じる = New System.Windows.Forms.Button()
        Me.lblトップ説明文 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn左
        '
        Me.btn左.Location = New System.Drawing.Point(115, 196)
        Me.btn左.Name = "btn左"
        Me.btn左.Size = New System.Drawing.Size(150, 70)
        Me.btn左.TabIndex = 0
        Me.btn左.UseVisualStyleBackColor = True
        '
        'btn参照
        '
        Me.btn参照.Location = New System.Drawing.Point(181, 294)
        Me.btn参照.Name = "btn参照"
        Me.btn参照.Size = New System.Drawing.Size(100, 56)
        Me.btn参照.TabIndex = 3
        Me.btn参照.Text = "参照"
        Me.btn参照.UseVisualStyleBackColor = True
        '
        'btn消去
        '
        Me.btn消去.Location = New System.Drawing.Point(280, 294)
        Me.btn消去.Name = "btn消去"
        Me.btn消去.Size = New System.Drawing.Size(100, 56)
        Me.btn消去.TabIndex = 4
        Me.btn消去.Text = "消去"
        Me.btn消去.UseVisualStyleBackColor = True
        '
        'btn閉じる
        '
        Me.btn閉じる.Location = New System.Drawing.Point(379, 294)
        Me.btn閉じる.Name = "btn閉じる"
        Me.btn閉じる.Size = New System.Drawing.Size(100, 56)
        Me.btn閉じる.TabIndex = 5
        Me.btn閉じる.Text = "閉じる"
        Me.btn閉じる.UseVisualStyleBackColor = True
        '
        'lblトップ説明文
        '
        Me.lblトップ説明文.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblトップ説明文.Location = New System.Drawing.Point(61, 69)
        Me.lblトップ説明文.Name = "lblトップ説明文"
        Me.lblトップ説明文.Size = New System.Drawing.Size(560, 104)
        Me.lblトップ説明文.TabIndex = 6
        Me.lblトップ説明文.Text = "任意のプログラムを起動するボタンの設定を行います。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　設定を行うボタンを選択して参照ボタンを押下して下さい。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　設定を取り消す場合は、ボタンを選択して消去" &
    "ボタンを押下して下さい。"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(265, 196)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 70)
        Me.Button1.TabIndex = 7
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(414, 196)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 70)
        Me.Button2.TabIndex = 8
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frm305EXE設定
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 411)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblトップ説明文)
        Me.Controls.Add(Me.btn閉じる)
        Me.Controls.Add(Me.btn消去)
        Me.Controls.Add(Me.btn参照)
        Me.Controls.Add(Me.btn左)
        Me.Name = "frm305EXE設定"
        Me.Text = "EXE設定"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn左 As Button
    Friend WithEvents btn参照 As Button
    Friend WithEvents btn消去 As Button
    Friend WithEvents btn閉じる As Button
    Friend WithEvents lblトップ説明文 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
