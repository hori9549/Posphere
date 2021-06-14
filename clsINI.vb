Imports System.Runtime.InteropServices

Public Class clsINI
    '------------------------------------------------------------
    '指定のINIファイルから文字列を取得する
    <DllImport("KERNEL32.DLL", CharSet:=CharSet.Auto)>
    Public Shared Function GetPrivateProfileString(ByVal lpAppName As String,
                                                   ByVal lpKeyName As String,
                                                   ByVal lpDefault As String,
                                                   ByVal lpReturnedString As System.Text.StringBuilder,
                                                   ByVal nSize As Integer,
                                                   ByVal lpFileName As String) As Integer
    End Function
    '指定のINIファイルの指定のキーの文字列を変更する
    <DllImport("KERNEL32.DLL")>
    Public Shared Function WritePrivateProfileString(ByVal lpAppName As String,
                                                     ByVal lpKeyName As String,
                                                     ByVal lpString As String,
                                                     ByVal lpFileName As String) As Integer
    End Function
    '指定のINIファイルから整数値を取得する
    <DllImport("KERNEL32.DLL", CharSet:=CharSet.Auto)>
    Public Shared Function GetPrivateProfileInt(ByVal lpAppName As String,
                                                   ByVal lpKeyName As String,
                                                   ByVal nDefault As Integer,
                                                   ByVal lpFileName As String) As Integer
    End Function
    '指定のINIファイルの指定のキーの整数値を変更する
    <DllImport("KERNEL32.DLL")>
    Public Shared Function WritePrivateProfileInt(ByVal lpAppName As String,
                                                     ByVal lpKeyName As String,
                                                     ByVal nDefault As Integer,
                                                     ByVal lpFileName As String) As Integer
    End Function
    '-----------------------------------------------------------------------
    Private iniFileName As String

    Sub New(ByVal strIniFile As String)
        '１）INI ファイルの格納フォルダPathおよびINIファイルのファイル名を取得する-
        '   　※INI ファイルをプログラム実行ファイルと同じフォルダーに置く
        Dim MyPath As String                    '戻り値(文字列)を受け取るバッファーを準備

        MyPath = Application.StartupPath        'ルートディレクトリかの判断
        If MyPath.EndsWith("\") = False Then
            MyPath &= "\"
        End If

        Me.iniFileName = MyPath & strIniFile
    End Sub

    Public Function GetProfileString(ByVal strAppName As String,
                                     ByVal strKeyName As String,
                                     ByVal strDefault As String) As String
        Try
            '----------------------------------------------------------------------
            '文字列の値を取得する場合
            Dim strBuffer As New System.Text.StringBuilder
            strBuffer.Capacity = 256   'バッファーのサイズを指定
            Dim ret As Integer
            '----------------------------------------------------------------------

            '読み込み
            ret = GetPrivateProfileString(strAppName,
                                            strKeyName,
                                            strDefault,
                                            strBuffer,
                                            strBuffer.Capacity,
                                            iniFileName)
            Return strBuffer.ToString
        Catch ex As Exception
            Return strDefault
        End Try
    End Function

    Public Function WriteProfileString(ByVal strAppName As String,
                                        ByVal strKeyName As String,
                                        ByVal strSet As String) As Boolean
        Try
            '書き込み
            Dim ret As Integer = WritePrivateProfileString(strAppName,
                                                            strKeyName,
                                                            strSet,
                                                            iniFileName)
            If ret > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function GetProfileInt(ByVal strAppName As String,
                                    ByVal strKeyName As String,
                                    ByVal nDefault As Integer) As Integer
        Try
            'INIファイルよりキーの値を読み込み(整数値を取得する場合)
            Dim ret As Integer = GetPrivateProfileInt(strAppName,
                                                        strKeyName,
                                                        nDefault,
                                                        iniFileName)
            Return ret
        Catch ex As Exception
            Return nDefault
        End Try
    End Function

    Public Function WriteProfileInt(ByVal strAppName As String,
                                    ByVal strKeyName As String,
                                    ByVal nSet As Integer) As Boolean
        Try
            '書き込み
            Dim ret As Integer = WritePrivateProfileInt(strAppName,
                                                        strKeyName,
                                                        nSet,
                                                        iniFileName)
            If ret > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
