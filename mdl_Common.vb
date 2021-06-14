Imports System.Data
Imports System.Data.SqlClient

Imports AForge.Video
Imports AForge.Video.DirectShow

Module mdl_Common
    ''データベース接続用-------------------------------
    Public msSQL As String
    Public mCommand As SqlCommand
    Public mSDA As New SqlDataAdapter

    Public dtbl_POS_M課税区分 As New DataTable
    Public dtbl_POS_M品目 As New DataTable
    Public dtbl_POS_M分類 As New DataTable
    Public dtbl_POS_M頁 As New DataTable
    Public dtbl_POS_M品目ボタン設定 As New DataTable

    Public Sub POS_M課税区分取得()
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        msSQL = " SELECT * FROM M課税区分"
        msSQL += " ORDER BY 課税区分"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(dtbl_POS_M課税区分) ''データセット作成

        ''主キーとなる列名をセット
        Dim colColumn(0) As DataColumn
        colColumn(0) = dtbl_POS_M課税区分.Columns("課税区分")

        ''主キーにセット
        dtbl_POS_M課税区分.CaseSensitive = True ''大文字小文字比較
        dtbl_POS_M課税区分.PrimaryKey = colColumn

        Call cDB.Close()
    End Sub

    Public Function POS_M課税区分検索(ByVal set課税区分 As String) As DataRow
        Dim FindData(0) As String
        Dim FindTable As DataTable = dtbl_POS_M課税区分

        FindData(0) = set課税区分

        ''検索開始
        Return FindTable.Rows.Find(FindData)

    End Function


    Public Sub POS_M品目取得()
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        msSQL = " SELECT * FROM M品目"
        msSQL += " ORDER BY 商品CD"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(dtbl_POS_M品目) ''データセット作成

        Call cDB.Close()
    End Sub

    Public Sub POS_M分類取得()
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        msSQL = " SELECT * FROM M分類"
        msSQL += " ORDER BY 分類CD"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(dtbl_POS_M分類) ''データセット作成

        Call cDB.Close()
    End Sub

    Public Sub POS_M頁取得(setPOSパターン As Integer, setPOS区分 As Integer)
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        'msSQL = " SELECT * FROM POS_M頁"
        'msSQL += " WHERE POSパターン=" & setPOSパターン
        'msSQL += " AND POS区分=" & setPOS区分
        'msSQL += " ORDER BY POSパターン,POS区分"
        msSQL = " SELECT * FROM M頁"
        msSQL += " WHERE ID=1"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(dtbl_POS_M頁) ''データセット作成

        Call cDB.Close()
    End Sub

    Public Sub POS_M品目ボタン設定取得(setPOSパターン As Integer, setPOS区分 As Integer)
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        'msSQL = " SELECT * FROM POS_M品目ボタン設定"
        'msSQL += " WHERE POSパターン=" & setPOSパターン
        'msSQL += " AND POS区分=" & setPOS区分
        'msSQL += " ORDER BY POSパターン,POS区分,頁NO,ボタンNO"
        msSQL = " SELECT * FROM M品目ボタン設定"
        msSQL += " ORDER BY 頁NO,ボタンNO"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(dtbl_POS_M品目ボタン設定) ''データセット作成

        Call cDB.Close()
    End Sub


    Public Sub 商品頁表示(getフォーム As Form, set頁 As Integer)
        Dim getButton As Button

        For Each get行 As DataRow In dtbl_POS_M頁.Rows
            For i = 1 To 4
                getButton = getフォーム.Controls("btn分類" & i)
                getButton.Text = Replace(get行("表示名" & set頁 + i - 1), "・", vbCrLf)
                getButton.Tag = set頁 + i - 1
            Next

        Next

        Call 商品表示(getフォーム, set頁)
    End Sub

    Public Sub 商品表示(getフォーム As Form, set頁 As Integer)
        Dim getButton As Button
        Dim get頁商品() As DataRow
        Dim get商品() As DataRow
        'Dim get頁商品 As New DataView(dtbl_POS_M品目ボタン設定)
        'get頁商品.RowFilter = "頁NO=" & set頁

        For nボタンNO As Integer = 1 To 36
            getButton = getフォーム.Controls("btn品目" & nボタンNO)
            get頁商品 = 頁商品検索(set頁, nボタンNO)

            If get頁商品.Count = 0 Then
                getButton.Tag = ""
                getButton.Text = ""

            Else
                get商品 = 商品検索(get頁商品(0)("JANCD"))
                getButton.Tag = get商品(0)("JANCD")
                getButton.Text = get商品(0)("ボタン表示名1") & vbCrLf & get商品(0)("ボタン表示名2")


            End If


        Next


        'For Each get行 As DataRowView In get頁商品
        '    If get行("ボタンNO") <= 36 Then
        '        get商品 = 商品検索(get行("JANCD"))

        '        getButton = getフォーム.Controls("btn品目" & get行("ボタンNO"))
        '        getButton.Tag = get行("JANCD")
        '        getButton.Text = get商品("品目名")

        '    End If

        'Next

    End Sub

    ''データテーブル検索
    Public Function 頁商品検索(ByVal set頁 As Integer, setボタンNO As Integer) As DataRow()
        Dim get行 As DataRow()
        get行 = dtbl_POS_M品目ボタン設定.Select("頁NO =" & set頁 & " AND ボタンNO =" & setボタンNO)

        Return get行
    End Function

    ''データテーブル検索
    Public Function 商品検索(ByVal setJANCD As String) As DataRow()
        Dim get行 As DataRow()
        get行 = dtbl_POS_M品目.Select("JANCD ='" & setJANCD & "'")

        Return get行
    End Function
End Module
