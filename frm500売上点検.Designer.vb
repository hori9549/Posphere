<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm500売上点検
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
        Me.grp入力項目 = New System.Windows.Forms.GroupBox()
        Me.btn終了 = New System.Windows.Forms.Button()
        Me.btn電子ジャーナル = New System.Windows.Forms.Button()
        Me.btnオーダーエントリー = New System.Windows.Forms.Button()
        Me.btnジャーナル = New System.Windows.Forms.Button()
        Me.btn会計集計 = New System.Windows.Forms.Button()
        Me.btn時間帯別集計 = New System.Windows.Forms.Button()
        Me.btn現金外集計 = New System.Windows.Forms.Button()
        Me.btn分類別集計 = New System.Windows.Forms.Button()
        Me.btn客層別集計 = New System.Windows.Forms.Button()
        Me.btn部門別集計 = New System.Windows.Forms.Button()
        Me.btn品目別集計 = New System.Windows.Forms.Button()
        Me.grp入力項目.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp入力項目
        '
        Me.grp入力項目.Controls.Add(Me.btn終了)
        Me.grp入力項目.Controls.Add(Me.btn電子ジャーナル)
        Me.grp入力項目.Controls.Add(Me.btnオーダーエントリー)
        Me.grp入力項目.Controls.Add(Me.btnジャーナル)
        Me.grp入力項目.Controls.Add(Me.btn会計集計)
        Me.grp入力項目.Controls.Add(Me.btn時間帯別集計)
        Me.grp入力項目.Controls.Add(Me.btn現金外集計)
        Me.grp入力項目.Controls.Add(Me.btn分類別集計)
        Me.grp入力項目.Controls.Add(Me.btn客層別集計)
        Me.grp入力項目.Controls.Add(Me.btn部門別集計)
        Me.grp入力項目.Controls.Add(Me.btn品目別集計)
        Me.grp入力項目.Location = New System.Drawing.Point(11, 11)
        Me.grp入力項目.Name = "grp入力項目"
        Me.grp入力項目.Size = New System.Drawing.Size(985, 118)
        Me.grp入力項目.TabIndex = 22
        Me.grp入力項目.TabStop = False
        '
        'btn終了
        '
        Me.btn終了.Location = New System.Drawing.Point(877, 71)
        Me.btn終了.Name = "btn終了"
        Me.btn終了.Size = New System.Drawing.Size(86, 32)
        Me.btn終了.TabIndex = 27
        Me.btn終了.Text = "終了"
        Me.btn終了.UseVisualStyleBackColor = True
        '
        'btn電子ジャーナル
        '
        Me.btn電子ジャーナル.Location = New System.Drawing.Point(877, 18)
        Me.btn電子ジャーナル.Name = "btn電子ジャーナル"
        Me.btn電子ジャーナル.Size = New System.Drawing.Size(86, 32)
        Me.btn電子ジャーナル.TabIndex = 37
        Me.btn電子ジャーナル.Text = "電子ｼﾞｬｰﾅﾙ"
        Me.btn電子ジャーナル.UseVisualStyleBackColor = True
        '
        'btnオーダーエントリー
        '
        Me.btnオーダーエントリー.Enabled = False
        Me.btnオーダーエントリー.Location = New System.Drawing.Point(782, 18)
        Me.btnオーダーエントリー.Name = "btnオーダーエントリー"
        Me.btnオーダーエントリー.Size = New System.Drawing.Size(86, 32)
        Me.btnオーダーエントリー.TabIndex = 36
        Me.btnオーダーエントリー.Text = "ｵｰﾀﾞｰｴﾝﾄﾘｰ"
        Me.btnオーダーエントリー.UseVisualStyleBackColor = True
        '
        'btnジャーナル
        '
        Me.btnジャーナル.Location = New System.Drawing.Point(687, 18)
        Me.btnジャーナル.Name = "btnジャーナル"
        Me.btnジャーナル.Size = New System.Drawing.Size(86, 32)
        Me.btnジャーナル.TabIndex = 35
        Me.btnジャーナル.Text = "ジャーナル"
        Me.btnジャーナル.UseVisualStyleBackColor = True
        '
        'btn会計集計
        '
        Me.btn会計集計.Location = New System.Drawing.Point(592, 18)
        Me.btn会計集計.Name = "btn会計集計"
        Me.btn会計集計.Size = New System.Drawing.Size(86, 32)
        Me.btn会計集計.TabIndex = 34
        Me.btn会計集計.Text = "会計集計"
        Me.btn会計集計.UseVisualStyleBackColor = True
        '
        'btn時間帯別集計
        '
        Me.btn時間帯別集計.Location = New System.Drawing.Point(497, 18)
        Me.btn時間帯別集計.Name = "btn時間帯別集計"
        Me.btn時間帯別集計.Size = New System.Drawing.Size(86, 32)
        Me.btn時間帯別集計.TabIndex = 33
        Me.btn時間帯別集計.Text = "時間帯別集計"
        Me.btn時間帯別集計.UseVisualStyleBackColor = True
        '
        'btn現金外集計
        '
        Me.btn現金外集計.Location = New System.Drawing.Point(402, 18)
        Me.btn現金外集計.Name = "btn現金外集計"
        Me.btn現金外集計.Size = New System.Drawing.Size(86, 32)
        Me.btn現金外集計.TabIndex = 32
        Me.btn現金外集計.Text = "現金外集計"
        Me.btn現金外集計.UseVisualStyleBackColor = True
        '
        'btn分類別集計
        '
        Me.btn分類別集計.Location = New System.Drawing.Point(307, 18)
        Me.btn分類別集計.Name = "btn分類別集計"
        Me.btn分類別集計.Size = New System.Drawing.Size(86, 32)
        Me.btn分類別集計.TabIndex = 31
        Me.btn分類別集計.Text = "分類別集計"
        Me.btn分類別集計.UseVisualStyleBackColor = True
        '
        'btn客層別集計
        '
        Me.btn客層別集計.Location = New System.Drawing.Point(212, 18)
        Me.btn客層別集計.Name = "btn客層別集計"
        Me.btn客層別集計.Size = New System.Drawing.Size(86, 32)
        Me.btn客層別集計.TabIndex = 30
        Me.btn客層別集計.Text = "客層別集計"
        Me.btn客層別集計.UseVisualStyleBackColor = True
        '
        'btn部門別集計
        '
        Me.btn部門別集計.Location = New System.Drawing.Point(117, 18)
        Me.btn部門別集計.Name = "btn部門別集計"
        Me.btn部門別集計.Size = New System.Drawing.Size(86, 32)
        Me.btn部門別集計.TabIndex = 29
        Me.btn部門別集計.Text = "部門別集計"
        Me.btn部門別集計.UseVisualStyleBackColor = True
        '
        'btn品目別集計
        '
        Me.btn品目別集計.Location = New System.Drawing.Point(22, 18)
        Me.btn品目別集計.Name = "btn品目別集計"
        Me.btn品目別集計.Size = New System.Drawing.Size(86, 32)
        Me.btn品目別集計.TabIndex = 28
        Me.btn品目別集計.Text = "品目別集計"
        Me.btn品目別集計.UseVisualStyleBackColor = True
        '
        'frm500売上点検
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.grp入力項目)
        Me.Name = "frm500売上点検"
        Me.Text = "売上点検"
        Me.grp入力項目.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp入力項目 As GroupBox
    Friend WithEvents btn電子ジャーナル As Button
    Friend WithEvents btnオーダーエントリー As Button
    Friend WithEvents btnジャーナル As Button
    Friend WithEvents btn会計集計 As Button
    Friend WithEvents btn時間帯別集計 As Button
    Friend WithEvents btn現金外集計 As Button
    Friend WithEvents btn分類別集計 As Button
    Friend WithEvents btn客層別集計 As Button
    Friend WithEvents btn部門別集計 As Button
    Friend WithEvents btn品目別集計 As Button
    Friend WithEvents btn終了 As Button
End Class
