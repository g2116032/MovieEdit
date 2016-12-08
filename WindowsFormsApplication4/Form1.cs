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
            axWindowsMediaPlayer2.uiMode = "full";
            axWindowsMediaPlayer2.stretchToFit = true;
        }

        private void axWindowsMediaPlayer3_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer3.uiMode = "full";
            axWindowsMediaPlayer3.stretchToFit = true;
        }

        private void axWindowsMediaPlayer4_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer4.uiMode = "full";
            axWindowsMediaPlayer4.stretchToFit = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == 1)
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

                double sec = axWindowsMediaPlayer2.Ctlcontrols.currentPosition;
                int SEC = (int)sec;
                string car = SEC.ToString();
                this.label1.Text = car;
                FilePath = fbd.SelectedPath;
                WriteCsv(SEC, 1, FilePath);
            }
            else if (flag == 0)
            {
                double sec = axWindowsMediaPlayer2.Ctlcontrols.currentPosition;
                int SEC = (int)sec;
                string car = SEC.ToString();
                this.label1.Text = car;
                WriteCsv(SEC, 1, FilePath);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag == 1)
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

                double sec = axWindowsMediaPlayer3.Ctlcontrols.currentPosition;
                int SEC = (int)sec;
                string car = SEC.ToString();
                this.label2.Text = car;
                string str = "movie2";
                WriteCsv(SEC, 2, fbd.SelectedPath);
            }
            else if (flag == 0)
            {
                double sec = axWindowsMediaPlayer3.Ctlcontrols.currentPosition;
                int SEC = (int)sec;
                string car = SEC.ToString();
                this.label2.Text = car;
                WriteCsv(SEC, 2, FilePath);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (flag == 1)
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

                double sec = axWindowsMediaPlayer4.Ctlcontrols.currentPosition;
                int SEC = (int)sec;
                string car = SEC.ToString();
                this.label3.Text = car;
                string str = "movie3";
                WriteCsv(SEC, 3, fbd.SelectedPath);
            }
            else if (flag == 0)
            {
                double sec = axWindowsMediaPlayer4.Ctlcontrols.currentPosition;
                int SEC = (int)sec;
                string car = SEC.ToString();
                this.label3.Text = car;
                WriteCsv(SEC, 3, FilePath);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                textBox2.Text = openFileDialog1.FileName;
                string fileName = this.openFileDialog1.FileName;
                axWindowsMediaPlayer2.uiMode = "none";
                //渡されたファイルURLを読み込み
                axWindowsMediaPlayer2.URL = fileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog2.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                textBox3.Text = openFileDialog1.FileName;
                string fileName = this.openFileDialog2.FileName;
                axWindowsMediaPlayer3.uiMode = "none";
                //渡されたファイルURLを読み込み
                axWindowsMediaPlayer3.URL = fileName;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog3.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                textBox4.Text = openFileDialog1.FileName;
                string fileName = this.openFileDialog3.FileName;
                axWindowsMediaPlayer4.uiMode = "none";
                //渡されたファイルURLを読み込み
                axWindowsMediaPlayer4.URL = fileName;
            }
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

        private void textBox2_TextChanged(object sender, EventArgs e)
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
    }
}
