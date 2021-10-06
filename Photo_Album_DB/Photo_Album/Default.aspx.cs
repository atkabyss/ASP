using System;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    string UpFolder_URL = "Upload_data/"; //画像格納用フォルダ
    string UpFolder;
    string password = "1234"; //パスワード

    //DB接続文字列 Web.config内に記述あり
    string AlbumCString;

    SqlDataAdapter albumDA; //SQLデータアダプタ

    DataSet albumDS;    //データセット
    DataTable albumDT;    //テーブル
    DataRow row;        //行

    protected void Page_Load(object sender, EventArgs e)
    {
        // アップロードフォルダのパスを定義する
        UpFolder = Server.MapPath(UpFolder_URL);

        //DB接続文字列 Web.config内に記述あり
        AlbumCString = SqlDataSource1.ConnectionString;

        albumDA = new SqlDataAdapter("select * from Album", AlbumCString);
        albumDS = new DataSet();

        try
        {   // DBファイルを開く
            albumDA.Fill(albumDS, "Album");
            GridView1.DataBind();
        }
        catch (Exception er)
        {   // XMLファイルが無ければエラーメッセージを表示
            TextBox2.Text = er.Message;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {   //登録ボタン

    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        // データセットへの読み込み
        albumDS = new DataSet();    // データセットの定義

        if (TextBox3.Text != password)  // パスワードが正しいか確認する
        {
            TextBox2.Text = "パスワードが違います。";
            return;
        }

        if (FileUpload1.HasFile)    //FileUpload にファイルが格納されている場合
        {
            if (FileUpload1.PostedFile.ContentLength > 500000)   //500KB 以上の画像は保存せずに終了する
            {
                TextBox2.Text = "ファイルが大きすぎます。";
                return;
            }

            // 画像ファイルのアップロード用フォルダパス
            string ImageFile = UpFolder + FileUpload1.FileName;

            FileUpload1.SaveAs(ImageFile); //ファイルの保存

            try
            {   // DBファイルを開く
                albumDA.Fill(albumDS, "Album");
                albumDT = albumDS.Tables["Album"];
            }
            catch (Exception er)
            {   // XMLファイルが無ければ新たにDataTableを作る
                TextBox2.Text = er.Message;
                albumDT = albumDS.Tables.Add("Album");
                albumDT.Columns.Add("日時");
                albumDT.Columns.Add("写真");
                albumDT.Columns.Add("コメント");
            }

            // 新しい行をテーブルに追加する
            row = albumDT.NewRow();
            row["日時"] = DateTime.Today.ToString("yyyy年MM月dd日(ddd)") + "<br />" + DateTime.Now.ToString("tthh時mm分ss秒");
            row["写真"] = UpFolder_URL + FileUpload1.FileName;
            row["コメント"] = TextBox1.Text;

            albumDT.Rows.Add(row);

            // データをデータベースファイルに書き出す
            new SqlCommandBuilder(albumDA);     // insert用コマンド自動作成
            albumDA.Update(albumDS, "Album");   //DBの更新

            // GridViewの表示を更新する
            GridView1.DataBind();

            // エラー表示を更新する
            TextBox2.Text = "登録が完了しました。";
        }
        else
        {
            // 画像ファイルが無い状態で登録ボタンが押された
            TextBox2.Text = "ファイルを指定してください。";
        }
    }
}
