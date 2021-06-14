Option Strict On
Imports System.Data.SqlClient
Public Class frm819日付時刻変更

    'Public Structure SystemTime
    '    Public wYear As Short
    '    Public wMonth As Short
    '    Public wDayOfWeek As Short
    '    Public wDay As Short
    '    Public wHour As Short
    '    Public wMinute As Short
    '    Public wSecond As Short
    '    Public wMiliseconds As Short
    'End Structure

    ''<DllImport("kernel32.dll")>
    'Public Shared Function SetLocalTime(
    '    ByRef sysTime As SystemTime) As Boolean
    'End Function

    '''' <summary>
    '''' 現在のシステム日時を設定する
    '''' </summary>
    '''' <param name="dt">設定する日時</param>
    'Public Shared Sub SetNowDateTime(ByVal dt As DateTime)
    '    'システム日時に設定する日時を指定する
    '    Dim sysTime As New SystemTime
    '    sysTime.wYear = dt.Year
    '    sysTime.wMonth = dt.Month
    '    sysTime.wDay = dt.Day
    '    sysTime.wHour = dt.Hour
    '    sysTime.wMinute = dt.Minute
    '    sysTime.wSecond = dt.Second
    '    sysTime.wMiliseconds = dt.Millisecond

    '    'システム日時を設定する
    '    SetLocalTime(sysTime)
    'End Sub
    Private Sub frm819日付時刻変更_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Using con As New SqlConnection
                Using cmd As New SqlCommand
                    ' 接続文字列の設定
                    con.ConnectionString =
                          "Data Source=.\SQLEXPRESS;" &
                          "Integrated Security=True;" &
                          "Connect Timeout=30;" &
                          "User Instance=True"
                    ' SqlCommand.Connectionプロパティの設定
                    cmd.Connection = con
                    ' DB接続
                    con.Open()
                    ' SQL文の設定
                    cmd.CommandText = "SELECT GETDATE()"
                    ' システム日付時刻をSqlCommand.ExecuteScalarで取得
                    Dim now As DateTime = CDate(cmd.ExecuteScalar())
                    ' システム日付時刻を編集してﾃﾞｲﾄﾀｲﾑﾋﾟｯｶｰに表示
                    'Me.DateTimePicker1.Text =
                    'now.ToString()
                    DateTimePicker1.Value = now

                End Using
            End Using
        Catch ex As Exception
            ' 例外が発生した時の処理
            MessageBox.Show("未精算のデータが存在します。精算後に実行して下さい！", "SpreadN管理",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        'DateTimePicker1.Value = Now
        'MessageBox.Show("未精算のデータが存在します。精算後に実行して下さい！", "SpreadN管理",
        '                MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn反映_Click(sender As Object, e As EventArgs) Handles btn反映.Click


    End Sub

    Private Sub btnキャンセル_Click(sender As Object, e As EventArgs) Handles btnキャンセル.Click
        Me.Close()
    End Sub
End Class