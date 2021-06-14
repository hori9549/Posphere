'2019_11_30_Koichi_Shimazu'
'20200629漆谷　SQL文を発行するしてコンボボックスを埋める機能を追加-------------------------------

Imports System.Data
Imports System.Data.SqlClient
Public Class frm600精算処理
    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    ''入力対象のテキストボックスを指定-------------------------------
    Private ctlTarget As TextBox

    Private Sub frm会計集計表vb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ctlTarget = txt10000枚数

        Dim int金額計算用 As Integer = 0

        ''釣銭準備金（「金額」項目で「表示名」項目が「釣銭準備金」の合計）-------------------------------
        Call 検索結果表示("COUNT(金額) AS 釣備件数", "Dレジ取引_未精算", "表示名 = '釣銭準備金'", "釣備件数", txt釣銭準備金_件数)
        Call 検索結果表示("SUM(金額) AS 釣備合計", "Dレジ取引_未精算", "表示名 = '釣銭準備金'", "釣備合計", txt釣銭準備金_金額)

        ''現金預かり（「金額」項目で「表示名」項目が「お預り」の合計）-------------------------------
        Call 検索結果表示("COUNT(金額) AS 現預件数", "Dレジ取引_未精算", "表示名 = 'お預り'", "現預件数", txt現金預かり_件数)
        Call 検索結果表示("SUM(金額) AS 現預金額", "Dレジ取引_未精算", "表示名 = 'お預り'", "現預金額", txt現金預かり_金額)

        ''釣銭支払い（「金額」項目で「表示名」項目が「お釣り」の合計）-------------------------------
        Call 検索結果表示("COUNT(金額) AS 釣支件数", "Dレジ取引_未精算", "表示名 = 'お釣り'", "釣支件数", txt釣銭支払い_件数)
        Call 検索結果表示("SUM(金額) AS 釣支金額", "Dレジ取引_未精算", "表示名 = 'お釣り'", "釣支金額", txt釣銭支払い_金額)

        ''★集計内容が不明-------------------------------
        Call 検索結果表示("COUNT(金額) AS 入金件数", "Dレジ取引_未精算", "表示名 = '入金'", "入金件数", txt入金_件数)
        Call 検索結果表示("SUM(金額) AS 入金金額", "Dレジ取引_未精算", "表示名 = '入金'", "入金金額", txt入金_金額)

        ''釣銭回収（「金額」項目で「明細区分」項目が「902」かつ「機能CD」項目が「451」の合計）-------------------------------
        Call 検索結果表示("COUNT(金額) AS 釣回件数", "Dレジ取引_未精算", "明細区分 = '902' AND 機能CD = '451'", "釣回件数", txt釣銭回収_件数)
        Call 検索結果表示("SUM(金額) AS 釣回金額", "Dレジ取引_未精算", "明細区分 = '902' AND 機能CD = '451'", "釣回金額", txt釣銭回収_金額)

        ''★集計内容が不明-------------------------------
        Call 検索結果表示("COUNT(金額) AS 出金件数", "Dレジ取引_未精算", "表示名 = '　'", "出金件数", txt出金_件数)
        Call 検索結果表示("SUM(金額) AS 出金金額", "Dレジ取引_未精算", "表示名 = '　'", "出金金額", txt出金_金額)

        ''★(計算方法が不明。「現金外」での売り上げの扱いは？)txt現金有り高（レジ内の現金＝「釣銭準備金」+「現金預かり」-「釣銭支払い」+「入金」-「釣銭回収」-「出金」）の合計-------------------------------
        If txt釣銭準備金_金額.Text <> "" Then int金額計算用 = Integer.Parse(txt釣銭準備金_金額.Text, Globalization.NumberStyles.Any)
        If txt現金預かり_金額.Text <> "" Then int金額計算用 = int金額計算用 + Integer.Parse(txt現金預かり_金額.Text, Globalization.NumberStyles.Any)
        If txt釣銭支払い_金額.Text <> "" Then int金額計算用 = int金額計算用 - Integer.Parse(txt釣銭支払い_金額.Text, Globalization.NumberStyles.Any)
        If txt入金_金額.Text <> "" Then int金額計算用 = int金額計算用 + Integer.Parse(txt入金_金額.Text, Globalization.NumberStyles.Any)
        If txt釣銭回収_金額.Text <> "" Then int金額計算用 = int金額計算用 - Integer.Parse(txt釣銭回収_金額.Text, Globalization.NumberStyles.Any)
        If txt出金_金額.Text <> "" Then int金額計算用 = int金額計算用 - Integer.Parse(txt出金_金額.Text, Globalization.NumberStyles.Any)
        txt現金有り高.Text = int金額計算用.ToString("#,0")

        ''★集計内容が不明-------------------------------
        Call 検索結果表示("COUNT(金額) AS 現計件数", "Dレジ取引_未精算", "表示名 = '　'", "現計件数", txt現計_件数)
        Call 検索結果表示("SUM(金額) AS 現計金額", "Dレジ取引_未精算", "表示名 = '　'", "現計金額", txt現計_金額)

        ''★集計内容が不明-------------------------------
        Call 検索結果表示("COUNT(金額) AS 信１件数", "Dレジ取引_未精算", "表示名 = '　'", "信１件数", txt信計1_件数)
        Call 検索結果表示("SUM(金額) AS 信１金額", "Dレジ取引_未精算", "表示名 = '　'", "信１金額", txt信計1_金額)

        ''★集計内容が不明-------------------------------
        Call 検索結果表示("COUNT(金額) AS 信２件数", "Dレジ取引_未精算", "表示名 = '　'", "信２件数", txt信計2_件数)
        Call 検索結果表示("SUM(金額) AS 信２金額", "Dレジ取引_未精算", "表示名 = '　'", "信２金額", txt信計2_金額)

        ''★集計内容が不明-------------------------------
        Call 検索結果表示("COUNT(金額) AS 信３件数", "Dレジ取引_未精算", "表示名 = '　'", "信３件数", txt信計3_件数)
        Call 検索結果表示("SUM(金額) AS 信３金額", "Dレジ取引_未精算", "表示名 = '　'", "信３金額", txt信計3_金額)

        ''★集計内容が不明-------------------------------
        Call 検索結果表示("COUNT(金額) AS 信４件数", "Dレジ取引_未精算", "表示名 = '　'", "信４件数", txt信計4_件数)
        Call 検索結果表示("SUM(金額) AS 信４金額", "Dレジ取引_未精算", "表示名 = '　'", "信４金額", txt信計4_金額)

        ''★集計内容が不明-------------------------------
        Call 検索結果表示("COUNT(金額) AS 計有件数", "Dレジ取引_未精算", "表示名 = '　'", "計有件数", txtII計釣有_件数)
        Call 検索結果表示("SUM(金額) AS 計有金額", "Dレジ取引_未精算", "表示名 = '　'", "計有金額", txtII計釣有_金額)

        ''★集計内容が不明-------------------------------
        Call 検索結果表示("COUNT(金額) AS 計無件数", "Dレジ取引_未精算", "表示名 = '　'", "計無件数", txtII計釣無_件数)
        Call 検索結果表示("SUM(金額) AS 計無金額", "Dレジ取引_未精算", "表示名 = '　'", "計無金額", txtII計釣無_金額)

        ''★集計内容が不明-------------------------------
        Call 検索結果表示("COUNT(金額) AS 計ク件数", "Dレジ取引_未精算", "表示名 = '　'", "計ク件数", txtII計クーポン_件数)
        Call 検索結果表示("SUM(金額) AS 計ク金額", "Dレジ取引_未精算", "表示名 = '　'", "計ク金額", txtII計クーポン_金額)

        ''★集計内容が不明-------------------------------
        Call 検索結果表示("COUNT(金額) AS 貸計件数", "Dレジ取引_未精算", "表示名 = '　'", "貸計件数", txt貸計_件数)
        Call 検索結果表示("SUM(金額) AS 貸計金額", "Dレジ取引_未精算", "表示名 = '　'", "貸計金額", txt貸計_金額)

        ''現金外計（「金額」項目で「明細区分」項目が「750（クレジット等）」の合計）-------------------------------
        Call 検索結果表示("SUM(金額) AS 現金外計", "Dレジ取引_未精算", "明細区分 = '750'", "現金外計", txt現金外計)

        ''過不足金（「現金有り高」をマイナスにして「現金外計」と金種表の総額を足す）-------------------------------
        int金額計算用 = 0
        If txt現金有り高.Text <> "" Then int金額計算用 = Integer.Parse(txt現金有り高.Text, Globalization.NumberStyles.Any)
        If txt現金有り高.Text <> "" Then int金額計算用 = 0 - int金額計算用
        If txt現金外計.Text <> "" Then int金額計算用 = int金額計算用 + Integer.Parse(txt現金外計.Text, Globalization.NumberStyles.Any)
        If txt金種表.Text <> "" Then int金額計算用 = int金額計算用 + Integer.Parse(txt金種表.Text, Globalization.NumberStyles.Any)
        txt過不足金.Text = int金額計算用.ToString("#,0")

        ''★純売上額（「金額」項目で「明細区分」項目が「600」の合計）の集計（集計方法が不明）-------------------------------
        Call 検索結果表示("SUM(金額) AS 純売上額", "Dレジ取引_未精算", "明細区分 = '600'", "純売上額", txt純売上額)

        ''★雑収入（「金額」項目で「明細区分」項目が「600」の合計）の集計（集計方法が不明）-------------------------------
        Call 検索結果表示("SUM(金額) AS 雑収入", "Dレジ取引_未精算", "明細区分 = '600'", "雑収入", txt雑収入)

        ''8％10％と軽減税率の集計を分ける-------------------------------
        ''内消費税（「金額」項目で「明細区分」項目が「999」かつ「課税区分」項目が「3」か、「明細区分」項目が「999」かつ「課税区分」項目が「5」の合計）の集計-------------------------------
        Call 検索結果表示("SUM(金額) AS 内消費税", "Dレジ取引_未精算", "明細区分 = '999' AND 課税区分 = '3' OR 明細区分 = '999' AND 課税区分 = '5'", "内消費税", txt内消費税)

        ''内軽減消費税（「金額」項目で「明細区分」項目が「999」かつ「課税区分」項目が「7」の合計）の集計-------------------------------
        Call 検索結果表示("SUM(金額) AS 内減費税", "Dレジ取引_未精算", "明細区分 = '999' AND 課税区分 = '7'", "内減費税", txt内軽減消費税)

        ''外消費税（「金額」項目で「明細区分」項目が「999」かつ「課税区分」項目が「4」か、「明細区分」項目が「999」かつ「課税区分」項目が「6」の合計）の集計-------------------------------
        Call 検索結果表示("SUM(金額) AS 外消費税", "Dレジ取引_未精算", "明細区分 = '999' AND 課税区分 = '4' OR 明細区分 = '999' AND 課税区分 = '6'", "外消費税", txt外消費税)

        ''外軽減消費税（「金額」項目で「明細区分」項目が「999」かつ「課税区分」項目が「8」の合計）の集計-------------------------------
        Call 検索結果表示("SUM(金額) AS 外減費税", "Dレジ取引_未精算", "明細区分 = '999' AND 課税区分 = '8'", "外減費税", txt外軽減消費税)

        ''★税抜売上の集計(たぶん純売上額から税金分を抜いた額。雑収入は考慮しない？)-------------------------------
        int金額計算用 = Integer.Parse(txt純売上額.Text, Globalization.NumberStyles.Any)
        If txt内消費税.Text <> "" Then int金額計算用 = int金額計算用 - Integer.Parse(txt内消費税.Text, Globalization.NumberStyles.Any)
        If txt内軽減消費税.Text <> "" Then int金額計算用 = int金額計算用 - Integer.Parse(txt内軽減消費税.Text, Globalization.NumberStyles.Any)
        If txt外消費税.Text <> "" Then int金額計算用 = int金額計算用 - Integer.Parse(txt外消費税.Text, Globalization.NumberStyles.Any)
        If txt外軽減消費税.Text <> "" Then int金額計算用 = int金額計算用 - Integer.Parse(txt外軽減消費税.Text, Globalization.NumberStyles.Any)
        txt税抜売上額.Text = int金額計算用.ToString("#,0")

        ''★訂正（「金額」項目で「登録区分」項目が「訂正」かつ「明細区分」項目が「600」の合計）集計方法が不明-------------------------------
        Call 検索結果表示("COUNT(金額) AS 訂正件数", "Dレジ取引_未精算", "登録区分 = '訂正' AND 明細区分 = '600'", "訂正件数", txt訂正_件数)
        Call 検索結果表示("SUM(金額) AS 訂正金額", "Dレジ取引_未精算", "登録区分 = '訂正' AND 明細区分 = '600'", "訂正金額", txt訂正_金額)

        ''★返品（「金額」項目で「明細区分」項目が「200」の合計）集計方法が不明-------------------------------
        Call 検索結果表示("COUNT(金額) AS 返品件数", "Dレジ取引_未精算", "明細区分 = '200'", "返品件数", txt返品_件数)
        Call 検索結果表示("SUM(金額) AS 返品金額", "Dレジ取引_未精算", "明細区分 = '200'", "返品金額", txt返品_金額)

        ''★明細値引（「明細値引金額」項目で「明細区分」項目が「600」の合計）値引きと割引の集計方法の違いが不明-------------------------------
        Call 検索結果表示("COUNT(明細値引金額) AS 明細値引件数", "Dレジ取引_未精算", "明細区分 = '600'", "明細値引件数", txt明細値引_件数)
        Call 検索結果表示("SUM(明細値引金額) AS 明細値引金額", "Dレジ取引_未精算", "明細区分 = '600'", "明細値引金額", txt明細値引_金額)

        ''★明細割引（「？？？」項目で「明細区分」項目が「600」の合計）値引きと割引の集計方法の違いが不明-------------------------------
        Call 検索結果表示("COUNT(金額) AS 明細割引件数", "Dレジ取引_未精算", "明細区分 = '0'", "明細割引件数", txt明細割引_件数)
        Call 検索結果表示("SUM(金額) AS 明細割引金額", "Dレジ取引_未精算", "明細区分 = '0'", "明細割引金額", txt明細割引_金額)

        ''★小計値引（「小計値引金額」項目で「明細区分」項目が「600」の合計）値引きと割引の集計方法の違いが不明-------------------------------
        Call 検索結果表示("COUNT(小計値引金額) AS 小計値引件数", "Dレジ取引_未精算", "明細区分 = '600'", "小計値引件数", txt小計値引_件数)
        Call 検索結果表示("SUM(小計値引金額) AS 小計値引金額", "Dレジ取引_未精算", "明細区分 = '600'", "小計値引金額", txt小計値引_金額)

        ''★小計割引（「？？？」項目で「明細区分」項目が「600」の合計）値引きと割引の集計方法の違いが不明-------------------------------
        Call 検索結果表示("COUNT(金額) AS 小計割引件数", "Dレジ取引_未精算", "明細区分 = '0'", "小計割引件数", txt小計割引_件数)
        Call 検索結果表示("SUM(金額) AS 小計割引金額", "Dレジ取引_未精算", "明細区分 = '0'", "小計割引金額", txt小計割引_金額)

        ''★単品値引（「単品値引金額」項目で「明細区分」項目が「600」の合計）値引きと割引の集計方法の違いが不明-------------------------------
        Call 検索結果表示("COUNT(単品値引金額) AS 単品値引件数", "Dレジ取引_未精算", "明細区分 = '600'", "単品値引件数", txt単品値引_件数)
        Call 検索結果表示("SUM(単品値引金額) AS 単品値引金額", "Dレジ取引_未精算", "明細区分 = '600'", "単品値引金額", txt単品値引_金額)

        ''★ハンドル値引（「バンドル値引金額」項目で「明細区分」項目が「600」の合計）値引きと割引の集計方法の違いが不明-------------------------------
        Call 検索結果表示("COUNT(バンドル値引金額) AS ハン値引件数", "Dレジ取引_未精算", "明細区分 = '600'", "ハン値引件数", txtハンドル値引_件数)
        Call 検索結果表示("SUM(バンドル値引金額) AS ハン値引金額", "Dレジ取引_未精算", "明細区分 = '600'", "ハン値引金額", txtハンドル値引_金額)

        ''★クーポン値引（「クーポン値引金額」項目で「明細区分」項目が「600」の合計）値引きと割引の集計方法の違いが不明-------------------------------
        Call 検索結果表示("COUNT(クーポン値引金額) AS クー値引件数", "Dレジ取引_未精算", "明細区分 = '600'", "クー値引件数", txtクーポン値引_件数)
        Call 検索結果表示("SUM(クーポン値引金額) AS クー値引金額", "Dレジ取引_未精算", "明細区分 = '600'", "クー値引金額", txtクーポン値引_金額)

        ''★総売上額（「金額」項目で「明細区分」項目が「600」の合計）の集計（集計方法が不明）-------------------------------
        Call 検索結果表示("SUM(金額) AS 総売上額", "Dレジ取引_未精算", "明細区分 = '600'", "総売上額", txt総売上額)

        ''クーポン発行（「金額」項目で「明細区分」項目が「910（クーポン発行）」の合計）-------------------------------
        Call 検索結果表示("COUNT(金額) AS クー発行件数", "Dレジ取引_未精算", "明細区分 = '910'", "クー発行件数", txtクーポン発行_件数)
        Call 検索結果表示("SUM(金額) AS クー発行金額", "Dレジ取引_未精算", "明細区分 = '910'", "クー発行金額", txtクーポン発行_金額)

        ''領収書発行（「金額」項目で「明細区分」項目が「998（領収書発行）」かつ「機能CD」が「800」の合計）-------------------------------
        Call 検索結果表示("COUNT(金額) AS 領収発行件数", "Dレジ取引_未精算", "明細区分 = '998' AND 機能CD = '800'", "領収発行件数", txt領収書発行_件数)
        Call 検索結果表示("SUM(金額) AS 領収発行金額", "Dレジ取引_未精算", "明細区分 = '998' AND 機能CD = '800'", "領収発行金額", txt領収書発行_金額)

        ''両替（「金額」項目で「明細区分」項目が「997（両替）」」かつ「機能CD」項目が「801」の合計）-------------------------------
        Call 検索結果表示("COUNT(金額) AS 両替件数", "Dレジ取引_未精算", "明細区分 = '997' AND 機能CD = '801'", "両替件数", txt両替_件数)
        Call 検索結果表示("SUM(金額) AS 両替金額", "Dレジ取引_未精算", "明細区分 = '997' AND 機能CD = '801'", "両替金額", txt両替_金額)

        ''★取引回数の集計方法が不明-------------------------------
        Call 検索結果表示("COUNT(金額) AS 取引回数件数", "Dレジ取引_未精算", "明細区分 = '600'", "取引回数件数", txt取引回数_件数)
        Call 検索結果表示("SUM(金額) AS 取引回数金額", "Dレジ取引_未精算", "明細区分 = '600'", "取引回数金額", txt取引回数_金額)

        ''取引人数（「人数」項目で「明細区分」が「600」の合計）の合計-------------------------------
        Call 検索結果表示("SUM(人数) AS 取引人数件数", "Dレジ取引_未精算", "明細区分 = '600'", "取引人数件数", txt取引人数_件数)
        Call 検索結果表示("SUM(金額) AS 取引人数金額", "Dレジ取引_未精算", "明細区分 = '600'", "取引人数金額", txt取引人数_金額)

        ''★一括と指定の区分が不明-------------------------------
        Call 検索結果表示("COUNT(金額) AS 登一取消件数", "Dレジ取引_未精算", "明細区分 = '0'", "登一取消件数", txt登録一括取消_件数)
        Call 検索結果表示("SUM(金額) AS 登一取消金額", "Dレジ取引_未精算", "明細区分 = '0'", "登一取消金額", txt登録一括取消_金額)
        Call 検索結果表示("COUNT(金額) AS 訂一取消件数", "Dレジ取引_未精算", "明細区分 = '0'", "訂一取消件数", txt訂正一括取消_件数)
        Call 検索結果表示("SUM(金額) AS 訂一取消金額", "Dレジ取引_未精算", "明細区分 = '0'", "訂一取消金額", txt訂正一括取消_金額)
        Call 検索結果表示("COUNT(金額) AS 登指取消件数", "Dレジ取引_未精算", "明細区分 = '0'", "登指取消件数", txt登録指定取消_件数)
        Call 検索結果表示("SUM(金額) AS 登指取消金額", "Dレジ取引_未精算", "明細区分 = '0'", "登指取消金額", txt登録指定取消_金額)
        Call 検索結果表示("COUNT(金額) AS 訂指取消件数", "Dレジ取引_未精算", "明細区分 = '0'", "訂指取消件数", txt訂正指定取消_件数)
        Call 検索結果表示("SUM(金額) AS 訂指取消金額", "Dレジ取引_未精算", "明細区分 = '0'", "訂指取消金額", txt訂正指定取消_金額)

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles _
        btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click

        ctlTarget.Text += sender.Text

    End Sub

    Private Sub txt10000枚数_Enter(sender As Object, e As EventArgs) Handles _
    txt10000枚数.Enter, txt5000枚数.Enter, txt2000枚数.Enter, txt1000枚数.Enter, txt500枚数.Enter, txt100枚数.Enter, txt50枚数.Enter, txt10枚数.Enter, txt5枚数.Enter, txt1枚数.Enter

        ctlTarget = sender

    End Sub

    Private Sub txt10000枚数_TextChanged(sender As Object, e As EventArgs) Handles txt10000枚数.TextChanged

        Call 金種表出力(txt10000en, txt10000枚数, 10000)

    End Sub

    Private Sub txt5000枚数_TextChanged(sender As Object, e As EventArgs) Handles txt5000枚数.TextChanged

        Call 金種表出力(txt5000en, txt5000枚数, 5000)

    End Sub

    Private Sub txt2000枚数_TextChanged(sender As Object, e As EventArgs) Handles txt2000枚数.TextChanged

        Call 金種表出力(txt2000en, txt2000枚数, 2000)

    End Sub

    Private Sub txt1000枚数_TextChanged(sender As Object, e As EventArgs) Handles txt1000枚数.TextChanged

        Call 金種表出力(txt1000en, txt1000枚数, 1000)

    End Sub

    Private Sub txt500枚数_TextChanged(sender As Object, e As EventArgs) Handles txt500枚数.TextChanged

        Call 金種表出力(txt500en, txt500枚数, 500)

    End Sub

    Private Sub txt100枚数_TextChanged(sender As Object, e As EventArgs) Handles txt100枚数.TextChanged

        Call 金種表出力(txt100en, txt100枚数, 100)

    End Sub

    Private Sub txt50枚数_TextChanged(sender As Object, e As EventArgs) Handles txt50枚数.TextChanged

        Call 金種表出力(txt50en, txt50枚数, 50)

    End Sub

    Private Sub txt10枚数_TextChanged(sender As Object, e As EventArgs) Handles txt10枚数.TextChanged

        Call 金種表出力(txt10en, txt10枚数, 10)

    End Sub

    Private Sub txt5枚数_TextChanged(sender As Object, e As EventArgs) Handles txt5枚数.TextChanged

        Call 金種表出力(txt5en, txt5枚数, 5)

    End Sub

    Private Sub txt1枚数_TextChanged(sender As Object, e As EventArgs) Handles txt1枚数.TextChanged

        Call 金種表出力(txt1en, txt1枚数, 1)

    End Sub

    Private Sub 金種表出力(金種 As TextBox, 枚数 As TextBox, 倍率 As Integer)
        Dim int小計 As Integer
        Dim int合計 As Integer

        If Integer.Parse(金種.Text, Globalization.NumberStyles.Any) > 9999999 Then

            枚数.Text = ""
            金種.Text = "0"

        Else
            If 枚数.Text <> "" Then
                int小計 = Integer.Parse(枚数.Text)
                int小計 = int小計 * 倍率
                金種.Text = int小計.ToString("#,0")
            Else
                '',クリアした場合は金額に「０」を挿入-------------------------------
                金種.Text = "0"
            End If
        End If

        '',枚数が変わったら、金額の総計を挿入。-------------------------------

        int合計 = 0

        int合計 += Integer.Parse(txt10000en.Text, Globalization.NumberStyles.Any)
        int合計 += Integer.Parse(txt5000en.Text, Globalization.NumberStyles.Any)
        int合計 += Integer.Parse(txt2000en.Text, Globalization.NumberStyles.Any)
        int合計 += Integer.Parse(txt1000en.Text, Globalization.NumberStyles.Any)
        int合計 += Integer.Parse(txt500en.Text, Globalization.NumberStyles.Any)
        int合計 += Integer.Parse(txt100en.Text, Globalization.NumberStyles.Any)
        int合計 += Integer.Parse(txt50en.Text, Globalization.NumberStyles.Any)
        int合計 += Integer.Parse(txt10en.Text, Globalization.NumberStyles.Any)
        int合計 += Integer.Parse(txt5en.Text, Globalization.NumberStyles.Any)
        int合計 += Integer.Parse(txt1en.Text, Globalization.NumberStyles.Any)

        txt金種表.Text = int合計.ToString("#,0")

    End Sub

    Private Sub 検索結果表示(項目名 As String, テーブル名 As String, 条件式 As String, 入力内容 As String, 入力先 As TextBox)

        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        Dim strTemp As String
        Dim dblTemp As Double

        'データベースから取得したいデータ群をSQLで検索
        msSQL = "SELECT " + 項目名
        msSQL += " FROM "
        msSQL += テーブル名
        msSQL += " WHERE "
        msSQL += 条件式

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成


        'SQLで検索したデータ群のレコードを、1レコードずつ取り出す
        For nRowCounter As Integer = 0 To myTable.Rows.Count - 1
            strTemp = "" '次に「部門コンボボックス」に登録する文字列　を　クリア（初期化：長さ０の文字列）する

            '「部門コンボボックス」に登録する文字列データの生成
            strTemp += myTable.Rows(nRowCounter).Item(入力内容).ToString


            If 項目名.Substring(0, 3) = "SUM" Then

                If strTemp <> "" Then
                    dblTemp = Double.Parse(strTemp)
                    strTemp = dblTemp.ToString("#,0")
                End If

            End If

            '生成した文字列を「部門コンボボックス」に登録する
            入力先.Text = strTemp

        Next

        Call cDB.Close()

    End Sub

    Private Sub txt金種表_TextChanged(sender As Object, e As EventArgs) Handles txt金種表.TextChanged

        Dim int過不足金 As Integer = 0

        If txt過不足金.Text <> "" Then

            int過不足金 = Integer.Parse(txt現金有り高.Text, Globalization.NumberStyles.Any)
            int過不足金 = 0 - int過不足金
            int過不足金 = int過不足金 + Integer.Parse(txt金種表.Text, Globalization.NumberStyles.Any)
            txt過不足金.Text = int過不足金.ToString("#,0")

        End If

    End Sub

    Private Sub btn終了_Click(sender As Object, e As EventArgs) Handles btn終了.Click
        Call Me.Close()
    End Sub

    Private Sub btn清算開始_Click(sender As Object, e As EventArgs) Handles btn清算開始.Click

        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        Dim strTemp As String
        Dim dblTemp As Double

        'データベースから取得したいデータ群をSQLで検索
        msSQL = "INSERT  INTO Dレジ取引 ("
        msSQL += " 取引日付,"
        msSQL += " 取引時刻,"
        msSQL += " レシートNO,"
        msSQL += " 行NO,"
        msSQL += " 登録区分,"
        msSQL += " 明細区分,"
        msSQL += " 機能CD,"
        msSQL += " JANCD,"
        msSQL += " 読込JANCD1,"
        msSQL += " 読込JANCD2,"
        msSQL += " 商品CD,"
        msSQL += " 部門CD,"
        msSQL += " 表示名,"
        msSQL += " 品目名,"
        msSQL += " 部門名,"
        msSQL += " 数量,"
        msSQL += " 単価,"
        msSQL += " 金額,"
        msSQL += " 課税区分,"
        msSQL += " 税率,"
        msSQL += " 内外区分,"
        msSQL += " 割引値増,"
        msSQL += " 値引率,"
        msSQL += " 奉仕料区分,"
        msSQL += " 担当者CD,"
        msSQL += " 担当者名,"
        msSQL += " 係CD,"
        msSQL += " 係名,"
        msSQL += " オーダー日時,"
        msSQL += " テーブルNO,"
        msSQL += " 伝票NO,"
        msSQL += " 客層CD,"
        msSQL += " 客層名,"
        msSQL += " 客層CD2,"
        msSQL += " 客層名2,"
        msSQL += " 人数,"
        msSQL += " 分類CD,"
        msSQL += " 分類名,"
        msSQL += " 取引分類CD,"
        msSQL += " 取引CD,"
        msSQL += " クーポン券負担区分,"
        msSQL += " 企画CD,"
        msSQL += " 企画区分,"
        msSQL += " 売変区分,"
        msSQL += " バンドルNO,"
        msSQL += " バンドル行NO,"
        msSQL += " バンドル区分,"
        msSQL += " バンドル値引金額,"
        msSQL += " 単品値引金額,"
        msSQL += " 明細値引金額,"
        msSQL += " 小計値引金額,"
        msSQL += " クーポン値引金額,"
        msSQL += " 商品単価,"
        msSQL += " 金券つり,"
        msSQL += " 金券つり滞留,"
        msSQL += " INFOX業務種別,"
        msSQL += " INFOXKID,"
        msSQL += " INFOXカード会社,"
        msSQL += " INFOX伝票NO,"
        msSQL += " INFOX訂正伝票NO,"
        msSQL += " INFOXCOM,"
        msSQL += " 訂正レシートNO,"
        msSQL += " 精算日付,"
        msSQL += " 精算時刻,"
        msSQL += " 精算NO,"
        msSQL += " 計上日付,"
        msSQL += " 端末CD,"
        msSQL += " 軽減税率区分,"
        msSQL += " TO区分"
        msSQL += " )"

        msSQL += " VALUES               (値1, 値2, 値3・・・)"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        'データベースから取得したいデータ群をSQLで検索
        msSQL = "DELETE FROM Dレジ取引_未精算 "
        msSQL += " WHERE 0 = 0 "

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

    End Sub
End Class