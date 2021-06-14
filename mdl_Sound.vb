Module mdl_Sound
    Public Button As New System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath & "\Button.wav")

    ''WAVEファイルを再生する
    'Private Sub PlaySound(ByVal waveFile As String)
    '    '再生されているときは止める
    '    If Not (player Is Nothing) Then
    '        StopSound()
    '    End If

    '    '読み込む
    '    player = New System.Media.SoundPlayer(waveFile)
    '    '非同期再生する
    '    player.Play()

    '    '次のようにすると、ループ再生される
    '    'player.PlayLooping()

    '    '次のようにすると、最後まで再生し終えるまで待機する
    '    'player.PlaySync()
    'End Sub

    '
    '再生されている音を止める
    Private Sub StopSound()
        If Not (Button Is Nothing) Then
            Button.Stop()
            Button.Dispose()
            Button = Nothing
        End If
    End Sub

    Public Sub PlaySound_Button()
        '再生されているときは止める
        If Not (Button Is Nothing) Then
            StopSound()
        End If

        Button = New System.Media.SoundPlayer("PCREJI.wav")
        '非同期再生する
        Button.Play()

        '次のようにすると、ループ再生される
        'player.PlayLooping()

        '次のようにすると、最後まで再生し終えるまで待機する
        'player.PlaySync()
    End Sub
End Module
