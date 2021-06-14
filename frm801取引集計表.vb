'20191119漆谷
'20200515堀内
'20200717堀内
Imports System.CodeDom
Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader

Public Class frm801取引集計表
    '  Public frmBefor As Form
    ''データベース接続用-------------------------------
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter
    Dim 集計区分別OdrBy As String = ""
    Private Sub frm取引集計表_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '---------------------------------------------
        '担当者に登録する文字列を生成 & DTBLPosパターンの作成
        '---------------------------------------------
        Dim cDB As New clsDB
        Dim mSDA As New SqlDataAdapter

        cmb担当者.Items.Add("全て")
        DataSetToCMB("M担当", "担当者CD", "担当者名", cmb担当者)
        cmb部門.Items.Add("全て")
        DataSetToCMB("M部門", "部門CD", "部門名", cmb部門)

        '   cmb計上日付.Items.Add("計上日付")
        cmb計上日付.Items.Add("取引日付")
        cmb計上日付.Items.Add("精算日付")
        '計上日付始をデフォルトの初日に変更
        Dtp日付始.Text = Dtp日付始.Text.Substring(0, 4) + "/" &
                               Dtp日付始.Text.Substring(5, 2) + "/" & "01"

        cmb集計区分.Items.Add("品目別取引集計")
        cmb集計区分.Items.Add("部門別取引集計")
        cmb集計区分.Items.Add("客層別取引集計")
        cmb集計区分.Items.Add("分類別取引集計")
        cmb集計区分.Items.Add("現金外取引集計")
        cmb集計区分.Items.Add("時間帯別取引集計")
        cmb出力順項目.Items.Add("コード")
        cmb出力順項目.Items.Add("取引回数")
        cmb出力順項目.Items.Add("取引人数")
        cmb出力順項目.Items.Add("取引数量")
        cmb出力順項目.Items.Add("取引金額")
        cmb出力順項目.Items.Add("値引値増")
        cmb出力順昇降.Items.Add("降順")


    End Sub

    Private Sub btn集計_Click(sender As Object, e As EventArgs) Handles btn集計.Click
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        Dgv検索項目.DataSource = Nothing
        Select Case cmb集計区分.SelectedItem

            Case "品目別取引集計"

                cmb部門.Enabled = True
                cmb出力順項目.Enabled = True
                cmb出力順昇降.Enabled = True

                msSQL = " "
                msSQL += "SELECT  CASE  WHEN "
                msSQL += "GROUPING(a.品目名) = 1 THEN  '＊　取引合計　＊'"  ' -- 合計行の場合
                msSQL += "ELSE  MAX(a.品目名)"  '-- 通常行の場合
                msSQL += "END              As  項目名, "
                msSQL += " count(D.商品CD) As  取引回数 ,"
                msSQL += " ''              As  取引人数 ,"
                msSQL += "SUM(D.数量)      As  取引数量 , "
                msSQL += "isnull(nullif(Format(SUM(D.金額 - D.割引値増), '#,###'),''),'0')    As 金額,"

                msSQL += "Format(sum(バンドル値引金額) + sum(単品値引金額) "
                msSQL += " + sum(明細値引金額) + sum(小計値引金額) + sum(クーポン値引金額), '#,###') As 値引・割引,"
                msSQL += "ISNULL(NULLIF(Format(sum(D.金額),'#,###'),''),'0') As 取引金額 "
                msSQL += "From [M品目] As a inner Join Dレジ取引 As D "
                msSQL += "On a.[商品CD]=D.[商品CD] "

                GoTo 共通部分

                '----------------------　以下は共通部分　-----------------------
共通部分:
                '検索条件の追加があった場合のWHERE句
                msSQL += " where D.商品CD <> '' and D.明細区分 = '100' " 'and D.機能CD = '0' and D.数量 <> 0 and D.単価 <> 0) "

                If cmb部門.Text <> "全て" Then
                    msSQL += " and D.部門CD　= '" + cmb部門.Text.Substring(0, 4) + "'"
                End If

                '精算日付の追加があった
                Dim 集計日付始 As String
                Dim 集計日付終 As String
                集計日付始 = Dtp日付始.Text.Substring(0, 4) &
                               Dtp日付始.Text.Substring(5, 2) &
                               Dtp日付始.Text.Substring(8, 2)

                集計日付終 = Dtp終.Text.Substring(0, 4) &
                            Dtp終.Text.Substring(5, 2) &
                            Dtp終.Text.Substring(8, 2)

                If 集計日付始 > 集計日付終 Then
                    MsgBox("集計日付始は集計日付終よりも前の日付を指定してください")
                    Exit Sub
                Else
                    msSQL += " And " + cmb計上日付.SelectedItem.ToString + ">= '" + 集計日付始 + "'"
                    msSQL += " And " + cmb計上日付.SelectedItem.ToString + " <= '" + 集計日付終 + "'"
                End If

Next担当者:       '検索条件の追加があった場合のWHERE句
                If cmb担当者.Text <> "全て" Then

                    msSQL += " AND "
                    msSQL += " 担当者CD = '" + cmb担当者.Text.Substring(0, 3) + "'"
                End If
                '------------------------ここまで共通部分　　ここから それぞれの故郷に帰る　----------------------
                Select Case cmb集計区分.SelectedItem
                    Case "品目別取引集計"
                        GoTo 品目別取引集計_最後の条件SET
                    Case "時間帯別取引集計"
                        GoTo 時間帯別取引集計_最後の条件SET
                    Case "部門別取引集計"
                        GoTo 部門別取引集計_最後の条件SET
                    Case "客層別取引集計"
                        GoTo 客層別取引集計_最後の条件SET
                    Case "分類別取引集計"
                        GoTo 分類別取引集計_最後の条件SET
                    Case "現金外取引集計"
                        GoTo 現金外取引集計_最後の条件SET
                    Case Else
                        Exit Sub
                End Select

品目別取引集計_最後の条件SET:

                msSQL += " group by GROUPING SETS((a.品目名),()) "

                '出力順追加があった場合のWHERE句---FOR 時間帯別取引集計---
                If (cmb出力順項目.SelectedIndex <= 0) Or (cmb出力順項目.SelectedItem = "コード") Then
                    msSQL += " order by  GROUPING (a.品目名),a.[品目名] "
                Else
                    Select Case cmb出力順項目.SelectedItem
                        Case "取引回数"
                            msSQL += " order by  GROUPING (a.品目名), count(D.商品CD) "
                        Case "取引人数"
                            msSQL += " order by  GROUPING (a.品目名),sum(D.人数) "
                        Case "取引数量"
                            msSQL += " order by  GROUPING (a.品目名),sum(D.[数量]) "
                        Case "取引金額"
                            msSQL += " order by  GROUPING (a.品目名),sum(D.[金額]) "
                        Case "値引値増"
                            msSQL += " order by  GROUPING (a.品目名),
(sum(バンドル値引金額) + sum(単品値引金額)
                            + sum(明細値引金額) + sum(小計値引金額) + sum(クーポン値引金額)) "
                        Case Else
                            Exit Sub
                    End Select
                    ' 集計区分別OdrBy = cmb出力順項目.SelectedItem

                    '  msSQL += " count(D.商品CD) "
                    'msSQL += +集計区分別OdrBy
                End If
                If cmb出力順昇降.SelectedItem = "降順" Then
                    msSQL += " DESC"
                End If
共通部分_読込:
                mCommand = cDB.getsqlComand(msSQL)
                mSDA.SelectCommand = mCommand
                Call mSDA.Fill(myTable) ''データセット作成
                Dgv検索項目.DataSource = myTable

                For i = 1 To Dgv検索項目.Columns.Count - 1
                    Dgv検索項目.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Next
                '-------------ここまで　 共通部分_読込----------------------
                '-------------ここまで　品目別取引集計 ----------------------
                                '-------------DGVを表示して終わる　どこにも戻らない----------------------

            Case "客層別取引集計"
                '--客層別取引集計で選択できるのは’担当者 ’だけ
                cmb部門.Enabled = False
                cmb出力順昇降.Enabled = False
                cmb出力順項目.Enabled = False

                '出力順追加があった場合のWHERE句---FOR 時間帯別取引集計---
                If (cmb出力順項目.SelectedIndex <= 0) Or (cmb出力順項目.SelectedItem = "コード") Then
                    集計区分別OdrBy = " D.[客層名] "
                Else
                    集計区分別OdrBy = cmb出力順項目.SelectedItem
                End If
                msSQL = "SELECT CASE WHEN "
                msSQL += "GROUPING(a.客層名) = 1 THEN  '＊　取引合計　＊'"
                msSQL += "ELSE MAX(a.客層名)"
                msSQL += "END  as 項目名,"
                msSQL += "count(D.商品CD)　as　取引回数,"
                msSQL += " '' As 取引人数,"
                msSQL += "SUM(数量) As 数量 , "
                msSQL += "isnull(nullif(Format(SUM(D.金額 - D.割引値増), '#,###'),''),'0')    As 金額,"
                msSQL += "FORMAT( sum(バンドル値引金額) + sum(単品値引金額) "
                msSQL += "+ sum(明細値引金額) + sum(小計値引金額) + sum(クーポン値引金額), '#,###') As 値引・割引,"
                '  msSQL += "FORMAT( sum(金額), '#,###') As 取引金額 "
                msSQL += " ISNULL(NULLIF(Format(sum(D.金額),'#,###'),''),'0') As 取引金額 "
                msSQL += "From M客層 As a left Join Dレジ取引 As D "
                msSQL += "On a.[客層CD] = D.[客層CD] "

                '  GoTo 共通部分  ikanai
                '  <---------------------------------------
客層別取引集計_最後の条件SET:
                msSQL += " WHERE a.[客層CD]<11"
                msSQL += " group by a.[客層名] with ROLLUP  "     ' --小計行と合計行を出力
                msSQL += " order by "
                msSQL += " case when  a.客層名 is null  then '1'"
                msSQL += " else '0'+ a.客層名 END"

                If cmb出力順昇降.SelectedItem = "降順" Then
                    msSQL += " DESC"
                End If

                GoTo 共通部分_読込

                '-------------ここまで　客層別取引集計 ----------------------

            Case "部門別取引集計"     '$$$$$$$$$$$$$$$$$$$

                cmb部門.Enabled = True
                cmb出力順項目.Enabled = True
                cmb出力順昇降.Enabled = True

                msSQL = " "
                msSQL += "Select  CASE WHEN "
                msSQL += "GROUPING(a.[部門名]) = 1 THEN  '＊　取引合計　＊'"  ' -- 合計行の場合
                msSQL += "ELSE  MAX(a.[部門名])"  '-- 通常行の場合
                msSQL += "END              As  項目名, "
                msSQL += " count(D.商品CD) As  取引回数 ,"
                msSQL += " ''              As  取引人数 ,"
                msSQL += "SUM(D.数量)      As  取引数量 , "
                msSQL += "isnull(nullif(Format(SUM(D.金額 - D.割引値増), '#,###'),''),'0')    As 金額,"

                msSQL += "Format(sum(バンドル値引金額) + sum(単品値引金額) "
                msSQL += " + sum(明細値引金額) + sum(小計値引金額) + sum(クーポン値引金額), '#,###') As 値引・割引,"
                msSQL += "ISNULL(NULLIF(Format(sum(D.金額),'#,###'),''),'0') As 取引金額 "
                msSQL += "From [M部門] As a inner Join Dレジ取引 As D "
                msSQL += "On a.[部門CD]=D.[部門CD]"

                GoTo 共通部分

部門別取引集計_最後の条件SET:

                msSQL += "group by grouping sets((a.[部門名]),())"

                If (cmb出力順項目.SelectedIndex <= 0) Or (cmb出力順項目.SelectedItem = "コード") Then
                    msSQL += " order by  GROUPING (a.部門名),a.[部門名] "
                Else
                    Select Case cmb出力順項目.SelectedItem
                        Case "取引回数"
                            msSQL += " order by  GROUPING (a.部門名), count(D.商品CD) "
                        Case "取引人数"
                            msSQL += " order by  GROUPING (a.部門名),sum(D.人数) "
                        Case "取引数量"
                            msSQL += " order by  GROUPING (a.部門名),sum(D.[数量]) "
                        Case "取引金額"
                            msSQL += " order by  GROUPING (a.部門名),sum(D.[金額]) "
                        Case "値引値増"
                            msSQL += " order by  GROUPING (a.部門名),
(sum(バンドル値引金額) + sum(単品値引金額)
                            + sum(明細値引金額) + sum(小計値引金額) + sum(クーポン値引金額)) "
                        Case Else
                            Exit Sub
                    End Select


                End If

                If cmb出力順昇降.SelectedItem = "降順" Then
                    msSQL += " DESC"
                End If

                GoTo 共通部分_読込

                '-------------ここまで 部門別取引集計 ----------------

            Case "分類別取引集計"

                cmb部門.Enabled = True
                cmb出力順項目.Enabled = True
                cmb出力順昇降.Enabled = True

                '出力順追加があった場合のWHERE句---FOR 時間帯別取引集計---
                If (cmb出力順項目.SelectedIndex <= 0) Or (cmb出力順項目.SelectedItem = "コード") Then
                    集計区分別OdrBy = "  D.[分類名] "
                Else
                    集計区分別OdrBy = cmb出力順項目.SelectedItem

                End If


                msSQL = ""
                msSQL += "SELECT CASE WHEN "
                msSQL += "GROUPING(a.分類名)=1 then '＊　取引合計　＊'"
                msSQL += "ELSE MAX(a.分類名)"
                msSQL += "END AS  項目名,"
                msSQL += " count(D.商品CD)　As　取引回数,"
                msSQL += "'' As 取引人数,"
                msSQL += "SUM(D.数量) As 取引数量 , "
                msSQL += "isnull(nullif(Format(SUM(D.金額 - D.割引値増), '#,###'),''),'0')    As 金額,"
                msSQL += "FORMAT( sum(バンドル値引金額) + sum(単品値引金額)+ sum(明細値引金額) +"
                msSQL += "sum(小計値引金額) + sum(クーポン値引金額), '#,###') As 値引・割引,"
                ' msSQL += " FORMAT(sum(金額), '#,###') As 取引金額 "
                msSQL += " ISNULL(NULLIF(Format(sum(D.金額),'#,###'),''),'0') As 取引金額 "
                msSQL += "From [M分類] As a Left Join Dレジ取引 As D "
                msSQL += "On a.[分類CD]= D.[分類CD]"
                '-----------------------------------------------------
                '検索条件の追加があった場合のWHERE句　(kyoutsuu部分）
                '-----------------------------------------------------
                '部門の追加があった時等　
                GoTo 共通部分

分類別取引集計_最後の条件SET:
                msSQL += "group by GROUPING SETS((a.分類名),())"
                If (cmb出力順項目.SelectedIndex <= 0) Or (cmb出力順項目.SelectedItem = "コード") Then
                    msSQL += " order by  GROUPING (a.分類名),a.分類名 "
                Else
                    Select Case cmb出力順項目.SelectedItem
                        Case "取引回数"
                            msSQL += " order by  GROUPING (a.分類名), count(D.商品CD) "
                        Case "取引人数"
                            msSQL += " order by  GROUPING (a.分類名),sum(D.人数) "
                        Case "取引数量"
                            msSQL += " order by  GROUPING (a.分類名),sum(D.[数量]) "
                        Case "取引金額"
                            msSQL += " order by  GROUPING (a.分類名),sum(D.[金額]) "
                        Case "値引値増"
                            msSQL += " order by  GROUPING (a.分類名),
(sum(バンドル値引金額) + sum(単品値引金額)
                            + sum(明細値引金額) + sum(小計値引金額) + sum(クーポン値引金額)) "
                        Case Else
                            Exit Sub
                    End Select
                End If

                If cmb出力順昇降.SelectedItem = "降順" Then
                    msSQL += " DESC"
                End If

                'msSQL += "Group By  GROUPING SETS((a.[分類名]),()) "
                'msSQL += " order by GROUPING (a.分類名), "

                'msSQL += "a.[分類名] is null THEN '1' "
                'msSQL += "ELSE '0' + a.[分類名] END"

                'If cmb出力順昇降.SelectedItem = "降順" Then
                '    msSQL += " DESC"
                'End If

                GoTo 共通部分_読込

                '-------------ここまで　分類別取引集計 ----------------------

            Case "現金外取引集計"
                '--現金外取引集計で選択できるのは’担当者 ’だけ
                cmb部門.Enabled = False
                cmb出力順昇降.Enabled = False
                cmb出力順項目.Enabled = False

                '出力順追加があった場合のWHERE句---FOR 時間帯別取引集計---
                If (cmb出力順項目.SelectedIndex <= 0) Or (cmb出力順項目.SelectedItem = "コード") Then
                    集計区分別OdrBy = " a.取引分類CD "
                Else
                    集計区分別OdrBy = cmb出力順項目.SelectedItem

                End If
                msSQL = ""
                msSQL += "SELECT "
                msSQL += "CASE WHEN GROUPING(mb.取引分類CD) = 1 THEN  '合計' "  '  -- 合計行の場合
                msSQL += "ELSE MAX(mb.取引分類名) "
                msSQL += " END                                        as    取引分類,"

                msSQL += "CASE WHEN GROUPING(mb.取引分類CD) = 1 THEN  '※　取引合計　※' "  '-- 左も合計行の場合
                msSQL += "     WHEN GROUPING(m.[取引CD])    = 1 THEN  '※　小　　計　※'"　　'-- 小計行の場合
                msSQL += "                                      ELSE   MAX(m.取引名) "       ' -- 通常行の場合
                msSQL += "                                      END    as    取引名, "
                msSQL += " COUNT(D.商品CD)                             as    取引件数, "
                msSQL += "Format(SUM(D.金額), '#,###')                As    取引金額 "

                msSQL += "From M取引分類 As mb inner Join M取引 As m "
                msSQL += "On mb.[取引分類CD]=m.[取引分類CD]"
                msSQL += " left  join  Dレジ取引    as  D   on  m.取引CD      = D.取引CD"
                msSQL += " where D.金額<>0 "
                msSQL += " group by grouping sets "
                msSQL += " ( (mb.取引分類CD),(mb.取引分類CD,m.取引CD),() ) "
                msSQL += " ORDER BY "
                msSQL += " GROUPING(mb.取引分類CD),mb.取引分類CD, "
                msSQL += " GROUPING(m.取引CD),m.取引CD "

                '-----------------------------------------------------
                '検索条件の追加があった場合のWHERE句　(kyoutsuu部分）
                '-----------------------------------------------------


現金外取引集計_最後の条件SET:


                GoTo 共通部分_読込

            Case "時間帯別取引集計"
                '--時間帯別集計で選択できるのは’担当者 ’だけ
                cmb部門.Enabled = False
                cmb出力順昇降.Enabled = False
                cmb出力順項目.Enabled = False

                '出力順追加があった場合のWHERE句---FOR 時間帯別取引集計---
                If (cmb出力順項目.SelectedIndex <= 0) Or (cmb出力順項目.SelectedItem = "コード") Then
                    集計区分別OdrBy = " a.時間帯 "
                Else
                    集計区分別OdrBy = cmb出力順項目.SelectedItem

                End If
                msSQL = ""
                msSQL += "SELECT "
                msSQL += "CASE WHEN GROUPING(a.時間帯) = 1 THEN  '※　取引合計　※' "  '  -- 合計行の場合
                msSQL += "ELSE MAX(a.時間帯) "
                msSQL += " END                                        as    項目名,"

                'msSQL += "CASE WHEN GROUPING(mb.取引分類CD) = 1 THEN  '※　取引合計　※' "  '-- 左も合計行の場合
                'msSQL += "     WHEN GROUPING(m.[取引CD])    = 1 THEN  '※　小　　計　※'"　　'-- 小計行の場合
                'msSQL += "                                      ELSE   MAX(m.取引名) "       ' -- 通常行の場合
                'msSQL += "                                      END    as    取引名, "
                msSQL += " COUNT(D.商品CD)                             as    取引回数, "
                msSQL += "Format(SUM(D.金額), '#,###')                As    取引金額, "
                msSQL += "sum(人数) As 取引人数,"
                msSQL += "SUM(数量) As 取引数量 , "
                msSQL += "isnull(nullif(Format(SUM(D.金額 - D.割引値増), '#,###'),''),'0')    As 金額,"
                msSQL += "FORMAT( sum(バンドル値引金額) + sum(単品値引金額)+ sum(明細値引金額) +"
                msSQL += "sum(小計値引金額) + sum(クーポン値引金額), '#,###') As 値引・割引,"
                msSQL += " ISNULL(NULLIF(Format(sum(D.金額),'#,###'),''),'0') As 取引金額 "
                msSQL += "From M時間帯 As a inner Join Dレジ取引 As D "
                msSQL += "On a.時間帯CD=substring(D.取引時刻,1,2) "
                msSQL += " group by grouping sets "
                msSQL += " ( (a.時間帯),() ) "

                '  GoTo 共通部分

時間帯別取引集計_最後の条件SET:
                ' msSQL += "Group By a.時間帯 WITH ROLLUP"
                'msSQL += " order by " + 集計区分別OdrBy + ",金額 "
                'If cmb出力順昇降.SelectedItem = "降順" Then
                '    msSQL += " DESC"
                'End If

                GoTo 共通部分_読込

        End Select
        Call cDB.Close()
        '印刷ボタンをアクティブに変更
        btnレシート印刷.Enabled = True

    End Sub
    Private Sub Check精算日付(ByVal inst As String, ByRef Result As Boolean)

        If inst.Length = 8 Then
            Dim uintValue As UInteger = 0 ' 正数なので符号なしInt型

            If UInteger.TryParse(inst, uintValue) Then
                ' 正数である
                Result = True

            End If
        Else
            MsgBox("日付の入力に誤りがあります")
            Result = False

        End If
    End Sub
    Private Sub DataSetToCMB(ByVal テーブル名 As String,
                             ByVal コロン前 As String,
                             ByVal コロン後 As String,
                             ByVal 対象コンボボックス As ComboBox)
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable
        Dim strTemp As String

        'データベースから取得したいデータ群をSQLで検索
        msSQL = "SELECT * "
        msSQL += "FROM " + テーブル名
        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成

        'SQLで検索したデータ群のレコードを、1レコードずつ取り出す
        For nRowCounter As Integer = 0 To myTable.Rows.Count - 1
            strTemp = ""
            strTemp += myTable.Rows(nRowCounter).Item(コロン前).ToString()
            strTemp += ":"
            strTemp += myTable.Rows(nRowCounter).Item(コロン後).ToString()

            対象コンボボックス.Items.Add(strTemp)

        Next
        Call cDB.Close()
    End Sub

    Private Sub btn終了_Click(sender As Object, e As EventArgs) Handles btn終了.Click
        Me.Close()
    End Sub

End Class