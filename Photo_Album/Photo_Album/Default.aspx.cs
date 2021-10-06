using System;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    string UpFolder_URL = "Upload_data/"; //画像格納用フォルダ
    string UpFolder;
    string DBFile;
    string password = "1234"; //パスワード

    DataSet albumDS;    //データセット
    DataTable albumDT;    //テーブル
    DataRow row;        //行

    protected void Page_Load(object sender, EventArgs e)
    {
        // データベースファイルのパスを定義する
        UpFolder = Server.MapPath(UpFolder_URL);
        DBFile = Server.MapPath("albumDB.xml");

        albumDS = new DataSet(); // データセットの定義

        try
        {   // XMLファイルを開く
            albumDS.ReadXml(DBFile);
            GridView1.DataSource = albumDS;
            GridView1.DataBind();
        }
        catch (Exception er)
        {   // XMLファイルが無ければエラーメッセージを表示
            TextBox2.Text = er.Message;
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //この処理を↓に移動
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        albumDS = new DataSet(); // データセットの定義

        if (TextBox3.Text != password)
        {   // パスワードが正しいか確認する
            TextBox2.Text = "パスワードが違います。";
            return;
        }

        if (FileUpload1.HasFile)
        {   //FileUpload にファイルが格納されている場合
            if (FileUpload1.PostedFile.ContentLength > 500000)
            {    // 約 500KB 以上の画像は保存せずに終了する
                TextBox2.Text = "ファイルが大きすぎます。";
                return;
            }

            // 画像ファイルのアップロード用フォルダパス
            string ImageFile = UpFolder + FileUpload1.FileName;

            FileUpload1.SaveAs(ImageFile); //ファイルの保存

            try
            {   // XMLファイルを開く
                albumDS.ReadXml(DBFile);
                albumDT = albumDS.Tables["データ項目"];
            }
            catch (Exception er)
            {   // XMLファイルが無ければ新たにDataTableを作る
                TextBox2.Text = er.Message;
                albumDT = albumDS.Tables.Add("データ項目");
                albumDT.Columns.Add("日時");
                albumDT.Columns.Add("写真");
                albumDT.Columns.Add("コメント");
            }

            // 新しい行をテーブルに追加する
            row = albumDT.NewRow();
            row["日時"] = DateTime.Today.ToString("yyyy年MM月dd日(ddd)")
                              + "<br />"
                              + DateTime.Now.ToString("tthh時mm分ss秒");
            row["写真"] = UpFolder_URL + FileUpload1.FileName;
            row["コメント"] = TextBox1.Text;

            albumDT.Rows.Add(row);

            // GridViewの表示を更新する
            GridView1.DataSource = albumDT;
            GridView1.DataBind();

            // データをデータベースファイルに書き出す
            albumDS.WriteXml(DBFile);

            // エラー表示をクリアする
            TextBox2.Text = "登録が完了しました。";
        }
        else
        {
            // 画像ファイルが無い状態で登録ボタンが押された
            TextBox2.Text = "ファイルを指定してください。";
        }
    }
}

