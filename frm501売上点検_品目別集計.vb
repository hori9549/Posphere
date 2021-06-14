
''20200228漆谷　集計ボタンの挙動を追加-------------------------------
''20200229漆谷　集計結果出力処理を別フォームとして切り分け-------------------------------
''20200306漆谷　データベースの更新に伴い検索結果のSELECT文にJOINを追加-------------------------------
''20200307漆谷　SELECT文に検索条件を指定した際にWHERE句を追加-------------------------------

Imports System.Data
Imports System.Data.SqlClient

Public Class frm501売上点検_品目別集計

    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Private Sub frm500売上点検_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable
        Dim strTemp As String '検索条件の「部門コンボボックス」に登録する文字列を生成する際に使う作業用変数

        'デフォルトの”全て”を「部門コンボボックス」に登録する
        cmb部門.Items.Add("全て")

        'データベースから取得したいデータ群をSQLで検索
        msSQL = "SELECT * "
        msSQL += "FROM M部門"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成

        'SQLで検索したデータ群のレコードを、1レコードずつ取り出す
        For nRowCounter As Integer = 0 To myTable.Rows.Count - 1
            strTemp = "" '次に「部門コンボボックス」に登録する文字列　を　クリア（初期化：長さ０の文字列）する

            '取り出したレコードのフィールドを1つずつ取得する場合は以下の処理で取り出せるよ
            'For nColumuCounter As Integer = 0 To myTable.Columns.Count - 1
            '    strTemp += myTable.Rows(nRowCounter).Item(nColumuCounter).ToString()
            'Next

            '「部門コンボボックス」に登録する文字列データの生成
            strTemp += myTable.Rows(nRowCounter).Item("部門CD").ToString()
            strTemp += ":"
            strTemp += myTable.Rows(nRowCounter).Item("部門名").ToString()

            '生成した文字列を「部門コンボボックス」に登録する
            cmb部門.Items.Add(strTemp)

        Next

        Call cDB.Close()

    End Sub

    Private Sub btn集計_Click(sender As Object, e As EventArgs) Handles btn集計.Click

        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        Dim strSelectTable As String

        grp検索項目.DataSource = Nothing

        'データベースから取得したいデータ群をSQLで検索
        msSQL = "SELECT master.部門CD, master.JANCD1, master.商品CD, master.品目名, cun_peoples.取引回数, num_peoples.取引人数, counter.数量, money.金額 ,discount.値引・割引 ,tra_amount.取引金額"
        msSQL += " From M品目 As master"
        msSQL += " INNER Join(select 商品CD, SUM(人数) As 取引回数  from Dレジ取引_未精算 where 明細区分 = '100' and 機能CD = '0' and 数量 <> 0 group by 商品CD)"
        msSQL += " AS cun_peoples ON master.商品CD = cun_peoples.商品CD"
        ''品目別集計結果に空白列「取引人数」を出力するカラうちSQL
        msSQL += " INNER Join(select 商品CD, Left(商品CD, 0) As 取引人数 from Dレジ取引_未精算 where 明細区分 = '100' and 機能CD = '0' and 数量 <> 0 group by 商品CD)"
        msSQL += " AS num_peoples ON master.商品CD = num_peoples.商品CD"
        msSQL += " INNER Join(select 商品CD, SUM(数量) As 数量 from Dレジ取引_未精算 where 明細区分 = '100' and 機能CD = '0' and 数量 <> 0 group by 商品CD)"
        msSQL += " AS counter ON master.商品CD = counter.商品CD"
        msSQL += " INNER Join(select 商品CD, FORMAT( SUM(数量 * 単価), '#,###') As 金額 from Dレジ取引_未精算 where 明細区分 = '100' and 機能CD = '0' and 数量 <> 0 group by 商品CD)"
        msSQL += " AS money ON master.商品CD = money.商品CD"
        msSQL += " INNER Join(select 商品CD, FORMAT( sum(バンドル値引金額) + sum(単品値引金額) + sum(明細値引金額) + sum(小計値引金額) + sum(クーポン値引金額), '#,###') As 値引・割引 from Dレジ取引_未精算 group by 商品CD )"
        msSQL += " AS discount ON master.商品CD = discount.商品CD"
        msSQL += " INNER Join(select 商品CD, FORMAT( sum(金額), '#,###') As 取引金額 from Dレジ取引_未精算 group by 商品CD)"
        msSQL += " AS tra_amount ON master.商品CD = tra_amount.商品CD"


        '検索条件が指定されている場合はSQL文にWHERE句を追記
        If cmb部門.Text <> "全て" Or txt指定JANコード.Text <> "" Then

            msSQL += " AND"

            If cmb部門.Text <> "全て" Then
                msSQL += " master.部門CD like '%" + cmb部門.Text.Substring(0, 4) + "%'"
            End If

            '検索条件が両方指定されている場合はANDを追記
            If cmb部門.Text <> "全て" And txt指定JANコード.Text <> "" Then
                msSQL += " AND "
            End If

            If txt指定JANコード.Text <> "" Then
                msSQL += " master.JANCD1 like '%" + txt指定JANコード.Text + "%'"
            End If

        End If

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成

        grp検索項目.DataSource = myTable

        Call cDB.Close()

        '印刷ボタンをアクティブに変更
        btn印刷.Enabled = True

    End Sub

    Private Sub btn印刷_Click(sender As Object, e As EventArgs) Handles btn印刷.Click

        '印刷機能を追加


    End Sub

    Private Sub btn終了_Click(sender As Object, e As EventArgs) Handles btn終了.Click

        Call Me.Close()

    End Sub

End Class