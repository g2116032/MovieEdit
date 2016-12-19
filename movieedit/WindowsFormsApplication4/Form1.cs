using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{

    public partial class Form1 : Form
    {
        int flag = 1;
        string FilePath;
        string FolderPath;
        public Form1()
        {
            InitializeComponent();
        }

        private static void WriteCsv(int second, int select, string place)
        {
            try
            {
                // appendをtrueにすると，既存のファイルに追記
                //         falseにすると，ファイルを新規作成する
                var append = true;
                // 出力用のファイルを開く
                using (var sw = new System.IO.StreamWriter(place + "\\test.csv", append))
                {
                    if (select == 1)
                    {
                        sw.WriteLine("{0}, {1}, {2},", second, " ", " ");
                    }
                    else if (select == 2)
                    {
                        sw.WriteLine("{0}, {1}, {2},", "", second, "");
                    }
                    else if (select == 3)
                    {
                        sw.WriteLine("{0}, {1}, {2},", "", "", second);
                    }
                }
            }
            catch (System.Exception e)
            {
                // ファイルを開くのに失敗したときエラーメッセージを表示
                System.Console.WriteLine(e.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer2_Enter(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer3_Enter(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer4_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            double sec = axWindowsMediaPlayer2.Ctlcontrols.currentPosition;
            int SEC = (int)sec;
            string car = SEC.ToString();
            this.label1.Text = car;

            WriteCsv(SEC, 1, FolderPath);

            
Bitmap bmp = new Bitmap(283, 211);
using (Graphics g = Graphics.FromImage(bmp))
{
g.CopyFromScreen(new Point(261, 30), new Point(0, 0), bmp.Size);
}

this.pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
this.pictureBox1.Image = bmp;


            /*Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width,Screen.PrimaryScreen.Bounds.Height);
            //Graphicsの作成
            Graphics g = Graphics.FromImage(bmp);
            //画面全体をコピーする
            g.CopyFromScreen(new Point(100, 100), new Point(200, 200), bmp.Size);
            //解放
            g.Dispose();

            //表示
            pictureBox1.Image = bmp;*/

        }

        private void button2_Click(object sender, EventArgs e)
        {

            double sec = axWindowsMediaPlayer3.Ctlcontrols.currentPosition;
            int SEC = (int)sec;
            string car = SEC.ToString();
            this.label2.Text = car;


            WriteCsv(SEC, 2, FolderPath);

            Bitmap bmp = new Bitmap(283, 211);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(new Point(573, 30), new Point(0, 0), bmp.Size);
            }

            this.pictureBox2.SizeMode = PictureBoxSizeMode.Normal;
            this.pictureBox2.Image = bmp;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            double sec = axWindowsMediaPlayer4.Ctlcontrols.currentPosition;
            int SEC = (int)sec;
            string car = SEC.ToString();
            this.label3.Text = car;



            WriteCsv(SEC, 3, FolderPath);
            Bitmap bmp = new Bitmap(283, 211);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(new Point(887, 30), new Point(0, 0), bmp.Size);
            }

            this.pictureBox3.SizeMode = PictureBoxSizeMode.Normal;
            this.pictureBox3.Image = bmp;

        }


        private void button4_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialogクラスのインスタンスを作成
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            //上部に表示する説明テキストを指定する
            fbd.Description = "フォルダを指定してください。";
            //ルートフォルダを指定する
            //デフォルトでDesktop
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            //最初に選択するフォルダを指定する
            //RootFolder以下にあるフォルダである必要がある
            fbd.SelectedPath = @"C:\Windows";
            //ユーザーが新しいフォルダを作成できるようにする
            //デフォルトでTrue
            fbd.ShowNewFolderButton = true;

            //ダイアログを表示する
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                flag = 0;
            }
            FolderPath = fbd.SelectedPath;
            textBox2.Text = fbd.SelectedPath;



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        int flag2 = 0;

        private void button7_Click(object sender, EventArgs e)
        {
            if (flag2 == 0)
            {

                string movie1, movie2, movie3;
                movie1 = FolderPath + "Top.mp4";
                movie2 = FolderPath + "Organizer.mp4";
                movie3 = FolderPath + "Participant.mp4";

                axWindowsMediaPlayer2.URL = movie1;
                axWindowsMediaPlayer2.uiMode = "full";
                axWindowsMediaPlayer2.stretchToFit = true;

                axWindowsMediaPlayer3.URL = movie2;
                axWindowsMediaPlayer3.uiMode = "full";
                axWindowsMediaPlayer3.stretchToFit = true;

                axWindowsMediaPlayer4.URL = movie3;
                axWindowsMediaPlayer4.uiMode = "full";
                axWindowsMediaPlayer4.stretchToFit = true;


                axWindowsMediaPlayer2.Ctlcontrols.play();
                axWindowsMediaPlayer3.Ctlcontrols.play();
                axWindowsMediaPlayer4.Ctlcontrols.play();
            }
            else if (flag2 == 1)
            {
                axWindowsMediaPlayer2.Ctlcontrols.play();
                axWindowsMediaPlayer3.Ctlcontrols.play();
                axWindowsMediaPlayer4.Ctlcontrols.play();
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.pause();
            axWindowsMediaPlayer3.Ctlcontrols.pause();
            axWindowsMediaPlayer4.Ctlcontrols.pause();
        }



        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog3_FileOk(object sender, CancelEventArgs e)
        {

        }



        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog2_HelpRequest(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog3_HelpRequest(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }



        private void button9_Click(object sender, EventArgs e)
        {
            /*Bitmap bmp = new Bitmap(200, 200);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(new Point(0, 0), new Point(0, 0), bmp.Size);
            }

            this.pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            this.pictureBox1.Image = bmp;*/

            //using System.Drawing;
            //using System.Windows.Forms;

            //画面全体のイメージをクリップボードにコピー
            //SendKeys.SendWait("^{PRTSC}");
            //次のようにすると、アクティブなウィンドウのイメージをコピー
            SendKeys.SendWait("%{PRTSC}");
            //SendKeys.SendWait("{PRTSC}");

            //DoEventsを呼び出したほうがよい場合があるらしい
            //Application.DoEvents();

            //クリップボードにあるデータの取得
            IDataObject d = Clipboard.GetDataObject();
            //クリップボードにデータがあったか確認
            if (d != null)
            {
                //ビットマップデータ形式に関連付けられているデータを取得
                Image img = (Image)d.GetData(DataFormats.Bitmap);
                if (img != null)
                {
                    //データが取得できたときはPictureBoxに表示する
                    pictureBox1.Image = img;

                    //画面のイメージデータは大きいため、
                    //用がなくなればクリップボードから削除した方がいいかもしれない
                    Clipboard.SetDataObject(new DataObject());
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



    }
}
