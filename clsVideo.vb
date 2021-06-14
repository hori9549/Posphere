Imports AForge.Video
Imports AForge.Video.DirectShow

Public Class clsVideo
    Private _videoSource As VideoCaptureDevice = Nothing

    Private proカメラ画像 As Image
    Public Property カメラ画像() As Image
        Get
            Return proカメラ画像
        End Get

        Set(ByVal value As Image)
            proカメラ画像 = value
        End Set
    End Property


    Public Sub New()
        'ビデオ入力デバイスのみ取得
        Dim videoDevices = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        If videoDevices.Count = 0 Then                        'ビデオデバイスが無い
            Return
        End If

        Dim MonikerString = videoDevices(0).MonikerString     '最初のビデオデバイスを使用

        _videoSource = New VideoCaptureDevice(MonikerString)
        AddHandler _videoSource.NewFrame, AddressOf Me.カメラ起動
        _videoSource.Start()
    End Sub

    'ビデオデバイス取得画像表示
    Private Sub カメラ起動(sender As Object, eventArgs As NewFrameEventArgs)
        proカメラ画像 = DirectCast(eventArgs.Frame.Clone(), Bitmap)

    End Sub

    Private Sub カメラ停止(sender As Object, eventArgs As NewFrameEventArgs)
        If _videoSource Is Nothing Then
            Return
        End If

        If _videoSource.IsRunning Then
            _videoSource.SignalToStop()     'ビデオデバイスの停止
            _videoSource.WaitForStop()      '完全に停止するまで待つ
            _videoSource = Nothing
        End If

    End Sub

    Public Sub 画像撮影(setID As Integer)
        Dim sPath As String = "D:\ガンズシステム\ソフト\写真\"
        Dim objBtm As Bitmap
        Dim lngW As Long
        Dim lngH As Long

        sPath += setID & ".png"
        Try
            objBtm = New Bitmap(proカメラ画像)
            lngW = objBtm.Width * 0.2
            lngH = objBtm.Height * 0.2

            Dim objBtm2 As New Bitmap(objBtm, lngW, lngH)
            objBtm2.Save(sPath, Imaging.ImageFormat.Png)
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class
