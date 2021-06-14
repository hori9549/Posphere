' @(s)
'   DB接続クラス
'
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class clsDB
    'コネクション取得
    Private pConection As SqlConnection
    Public ReadOnly Property Conection() As SqlConnection
        Get
            Return pConection
        End Get

    End Property

    'トランザクション取得
    Private pSQLTransaction As SqlTransaction
    Public ReadOnly Property Transaction() As SqlTransaction
        Get
            Return pSQLTransaction
        End Get

    End Property

    'インスタンス作成
    '[App.config]ファイルより、接続文字列を取得する。
    Public Sub New()
        pConection = New SqlConnection(ConfigurationManager.AppSettings("ConnectionString"))

        Call pConection.Open()
        pSQLTransaction = Nothing

    End Sub

    'コマンド作成
    Public Function getsqlComand(ByVal getSQL As String) As SqlCommand
        Dim mySQLCommand As New SqlCommand(getSQL, pConection)

        If Not (pSQLTransaction Is Nothing) Then
            mySQLCommand.Transaction = pSQLTransaction
        End If

        Return mySQLCommand
    End Function

    'トランザクション開始処理
    Public Sub BeginTransaction()
        If Not (pSQLTransaction Is Nothing) Then
            Call pSQLTransaction.Rollback()
            Call pSQLTransaction.Dispose()
        End If

        pSQLTransaction = pConection.BeginTransaction()

    End Sub

    'ロールバック処理
    Public Sub Rollback()
        Call pSQLTransaction.Rollback()
        pSQLTransaction = Nothing

    End Sub

    'コミット処理
    Public Sub Commit()
        Call pSQLTransaction.Commit()
        pSQLTransaction = Nothing

    End Sub

    'クローズ処理
    Public Sub Close()
        Try
            ''コミットまたはロールバックされていないデータが来たときは、ロールバックを行う。
            If Not (pSQLTransaction Is Nothing) Then
                pSQLTransaction.Rollback()
            End If
            Call pConection.Close()
        Catch ex As Exception

        Finally
            If Not (pSQLTransaction Is Nothing) Then
                pSQLTransaction = Nothing
            End If

        End Try
    End Sub

End Class
