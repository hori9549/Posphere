Public Class frmベース
    ''元のカラーを保存しておく変数
    Private Shared BeforeBackColor As Color '元のカラー

  ''エンタータブ処理
    Protected Overrides Function ProcessDialogKey(ByVal keyData As Keys) As Boolean
        Dim getControl As Control = Me.ActiveControl

        ''ボタンだったらタブにしない
        'Select Case getControl.GetType.Name
        '    Case "ComboBox", "RadioButton" ''"TextBox"
        '        'Returnキーが押されているか調べる
        '        'AltかCtrlキーが押されている時は、本来の動作をさせる
        '        If ((keyData And Keys.KeyCode) = Keys.Return) AndAlso _
        '            ((keyData And (Keys.Alt Or Keys.Control)) = Keys.None) Then
        '            'Tabキーを押した時と同じ動作をさせる
        '            'Shiftキーが押されている時は、逆順にする
        '            Me.ProcessTabKey((keyData And Keys.Shift) <> Keys.Shift)
        '            '本来の処理はさせない
        '            Return True
        '        End If
        '        Return MyBase.ProcessDialogKey(keyData)

        '    Case "DateTimePicker"
        '        If ((keyData And Keys.KeyCode) = Keys.Return) AndAlso _
        '            ((keyData And (Keys.Alt Or Keys.Control)) = Keys.None) Then
        '            'Tabキーを押した時と同じ動作をさせる
        '            'Shiftキーが押されている時は、逆順にする
        '            Me.ProcessTabKey((keyData And Keys.Shift) <> Keys.Shift)
        '            '本来の処理はさせない
        '            Return True

        '            'Me.ProcessKey()
        '        End If
        '        Return MyBase.ProcessDialogKey(keyData)

        '    Case Else

        'End Select
        Return MyBase.ProcessDialogKey(keyData)
    End Function

    Protected Overrides Sub OnEnter(e As EventArgs)
        Dim getControl As Control = Me.ActiveControl

        Call PlaySound_Button()
    End Sub

    Private Sub Template_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColorChg(sender)
    End Sub

  ''イベント埋め込み
    Public Shared Sub BackColorChg(ByVal sender As System.Object)
        'コントロールをループで取得する
        For Each c As Control In sender.Controls
            'テキストボックス、ボタン、リストボックス、コンボボックスだったらイベント埋め込み 
            If c.GetType Is GetType(System.Windows.Forms.TextBox) Or _
                c.GetType Is GetType(System.Windows.Forms.Button) Or _
                c.GetType Is GetType(System.Windows.Forms.ListBox) Or _
                c.GetType Is GetType(System.Windows.Forms.ComboBox) Then

                AddHandler c.Enter, AddressOf TextBox_GotFocus
                AddHandler c.Leave, AddressOf TextBox_LostFocus
                AddHandler c.Click, AddressOf TextBox_Click
            ElseIf c.GetType Is GetType(System.Windows.Forms.GroupBox) Or _
                c.GetType Is GetType(System.Windows.Forms.TabControl) Or _
                c.GetType Is GetType(System.Windows.Forms.TabPage) Then
                Call BackColorChg(c)
            End If
        Next
    End Sub

    ''クリックのイベント
    Public Shared Sub TextBox_Click(sender As Object, e As EventArgs)
        'If BeforeSenderName.Equals(sender.name) Then Return
        Dim cn As Control = sender
        'BeforeBackColor = cn.BackColor  '元のカラーを退避
        'sender.BackColor = Color.LightPink      'カラー変更

        Call PlaySound_Button()
    End Sub

    ''フォーカス取得時のイベント
    Public Shared Sub TextBox_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If BeforeSenderName.Equals(sender.name) Then Return
        Dim cn As Control = sender
        'BeforeBackColor = cn.BackColor  '元のカラーを退避
        'sender.BackColor = Color.LightPink      'カラー変更

        'Call PlaySound_Button()
    End Sub

    ''フォーカス移動後のイベント
    Public Shared Sub TextBox_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Not BeforeSenderName.Equals(sender.name) Then Return
        'sender.BackColor = BeforeBackColor  '元のカラーに戻す。
        If sender.GetType Is GetType(System.Windows.Forms.Button) Then
            'sender.UseVisualStyleBackColor = True
        End If

    End Sub

End Class