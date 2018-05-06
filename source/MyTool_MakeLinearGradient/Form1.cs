using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTool_MakeLinearGradient
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		//4つのグラデーションサンプルを作成
		private void Form1_Load(object sender, EventArgs e)
		{
			//描画先とするImageオブジェクトを作成する
			Bitmap canvas1 = new Bitmap(pictureBox_g1.Width, pictureBox_g1.Height);
			//ImageオブジェクトのGraphicsオブジェクトを作成する
			using (Graphics g = Graphics.FromImage(canvas1))
			{
				//縦に白から黒へのグラデーションのブラシを作成
				using (LinearGradientBrush gb = new LinearGradientBrush(
							g.VisibleClipBounds,
							Color.White,
							Color.Black,
							LinearGradientMode.Vertical))
				{
					//四角を描く
					g.FillRectangle(gb, g.VisibleClipBounds);

					//PictureBox1に表示する
					pictureBox_g1.Image = canvas1;
				}
			}

			//描画先とするImageオブジェクトを作成する
			Bitmap canvas2 = new Bitmap(pictureBox_g1.Width, pictureBox_g1.Height);
			//ImageオブジェクトのGraphicsオブジェクトを作成する
			using (Graphics g = Graphics.FromImage(canvas2))
			{
				//縦に黒から白へのグラデーションのブラシを作成
				using (LinearGradientBrush gb = new LinearGradientBrush(
							g.VisibleClipBounds,
							Color.Black,
							Color.White,
							LinearGradientMode.Vertical))
				{
					//四角を描く
					g.FillRectangle(gb, g.VisibleClipBounds);

					//PictureBox1に表示する
					pictureBox_g2.Image = canvas2;
				}
			}

			//描画先とするImageオブジェクトを作成する
			Bitmap canvas3 = new Bitmap(pictureBox_g1.Width, pictureBox_g1.Height);
			//ImageオブジェクトのGraphicsオブジェクトを作成する
			using (Graphics g = Graphics.FromImage(canvas3))
			{
				//横に白から黒へのグラデーションのブラシを作成
				using (LinearGradientBrush gb = new LinearGradientBrush(
							g.VisibleClipBounds,
							Color.White,
							Color.Black,
							LinearGradientMode.Horizontal))
				{
					//四角を描く
					g.FillRectangle(gb, g.VisibleClipBounds);

					//PictureBox1に表示する
					pictureBox_g3.Image = canvas3;
				}
			}

			//描画先とするImageオブジェクトを作成する
			Bitmap canvas4 = new Bitmap(pictureBox_g1.Width, pictureBox_g1.Height);
			//ImageオブジェクトのGraphicsオブジェクトを作成する
			using (Graphics g = Graphics.FromImage(canvas4))
			{
				//横に黒から白へのグラデーションのブラシを作成
				using (LinearGradientBrush gb = new LinearGradientBrush(
							g.VisibleClipBounds,
							Color.Black,
							Color.White,
							LinearGradientMode.Horizontal))
				{
					//四角を描く
					g.FillRectangle(gb, g.VisibleClipBounds);

					//PictureBox1に表示する
					pictureBox_g4.Image = canvas4;
				}
			}
		}

		//256x256サイズのImageオブジェクトを作成
		Bitmap img = new Bitmap(256, 256);

		private void pictureBox_g1_Click(object sender, EventArgs e)
		{
			//ImageオブジェクトのGraphicsオブジェクトを作成
			using (Graphics g = Graphics.FromImage(img))
			{
				for (int i = 0; i < 256; i++)
				{
					// 色は黒で幅1pxのペン
					using (Pen p = new Pen(Color.FromArgb(255, i, i, i), 1))
					{
						//グラデーションを描画
						g.DrawLine(p, 0, i, 255, i);
					}
				}

				//作成した画像を表示する
				pictureBox1.Image = img;
			}
		}

		private void pictureBox_g2_Click(object sender, EventArgs e)
		{
			//ImageオブジェクトのGraphicsオブジェクトを作成
			using (Graphics g = Graphics.FromImage(img))
			{
				for (int i = 0; i < 256; i++)
				{
					// 色は黒で幅1pxのペン
					using (Pen p = new Pen(Color.FromArgb(255, i, i, i), 1))
					{
						//グラデーションを描画
						g.DrawLine(p, 0, 255 - i, 255, 255 - i);
					}
				}

				//作成した画像を表示する
				pictureBox1.Image = img;
			}
		}

		private void pictureBox_g3_Click(object sender, EventArgs e)
		{
			//ImageオブジェクトのGraphicsオブジェクトを作成
			using (Graphics g = Graphics.FromImage(img))
			{
				for (int i = 0; i < 256; i++)
				{
					// 色は黒で幅1pxのペン
					using (Pen p = new Pen(Color.FromArgb(255, i, i, i), 1))
					{
						//グラデーションを描画
						g.DrawLine(p, i, 0, i, 255);
					}
				}

				//作成した画像を表示する
				pictureBox1.Image = img;
			}
		}

		private void pictureBox_g4_Click(object sender, EventArgs e)
		{
			//ImageオブジェクトのGraphicsオブジェクトを作成
			using (Graphics g = Graphics.FromImage(img))
			{
				for (int i = 0; i < 256; i++)
				{
					// 色は黒で幅1pxのペン
					using (Pen p = new Pen(Color.FromArgb(255, i, i, i), 1))
					{
						//グラデーションを描画
						g.DrawLine(p, 255 - i, 0, 255 - i, 255);
					}
				}

				//作成した画像を表示する
				pictureBox1.Image = img;
			}
		}

		//グラデーション画像を作成して保存する
		private void button1_Click(object sender, EventArgs e)
		{
			//PixtureBoxが空じゃなければ実行
			if (pictureBox1 != null)
			{
				//作成した画像をデスクトップに保存

				// フィルターの設定
				saveFileDialog1.Filter = "BMP形式|*.bmp";
				// ファイル保存ダイアログを表示
				saveFileDialog1.ShowDialog();
				// フォーマット指定
				img.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
			}
			else
			{
				MessageBox.Show("保存する前にグラデーションを作成してください");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show(
				"1 ピクセルごとに色の値が 1 ずつ増えていく\r\n" +
				"256ｘ256 の綺麗なリニアグラデーションを作成します"
				);
		}
	}

}
