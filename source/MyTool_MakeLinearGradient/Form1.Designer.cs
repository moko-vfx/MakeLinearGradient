namespace MyTool_MakeLinearGradient
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox_g1 = new System.Windows.Forms.PictureBox();
			this.pictureBox_g2 = new System.Windows.Forms.PictureBox();
			this.pictureBox_g3 = new System.Windows.Forms.PictureBox();
			this.pictureBox_g4 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_g1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_g2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_g3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_g4)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("メイリオ", 10F);
			this.label1.Location = new System.Drawing.Point(17, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(290, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "▼クリックでグラデーション画像を作成する";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.button1.Location = new System.Drawing.Point(178, 34);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(53, 32);
			this.button1.TabIndex = 1;
			this.button1.Text = "保存";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(208)))), ((int)(((byte)(92)))));
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(34, 76);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(256, 256);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox_g1
			// 
			this.pictureBox_g1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox_g1.Location = new System.Drawing.Point(34, 35);
			this.pictureBox_g1.Name = "pictureBox_g1";
			this.pictureBox_g1.Size = new System.Drawing.Size(30, 30);
			this.pictureBox_g1.TabIndex = 12;
			this.pictureBox_g1.TabStop = false;
			this.pictureBox_g1.Click += new System.EventHandler(this.pictureBox_g1_Click);
			// 
			// pictureBox_g2
			// 
			this.pictureBox_g2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox_g2.Location = new System.Drawing.Point(70, 35);
			this.pictureBox_g2.Name = "pictureBox_g2";
			this.pictureBox_g2.Size = new System.Drawing.Size(30, 30);
			this.pictureBox_g2.TabIndex = 12;
			this.pictureBox_g2.TabStop = false;
			this.pictureBox_g2.Click += new System.EventHandler(this.pictureBox_g2_Click);
			// 
			// pictureBox_g3
			// 
			this.pictureBox_g3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox_g3.Location = new System.Drawing.Point(106, 35);
			this.pictureBox_g3.Name = "pictureBox_g3";
			this.pictureBox_g3.Size = new System.Drawing.Size(30, 30);
			this.pictureBox_g3.TabIndex = 12;
			this.pictureBox_g3.TabStop = false;
			this.pictureBox_g3.Click += new System.EventHandler(this.pictureBox_g3_Click);
			// 
			// pictureBox_g4
			// 
			this.pictureBox_g4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox_g4.Location = new System.Drawing.Point(142, 35);
			this.pictureBox_g4.Name = "pictureBox_g4";
			this.pictureBox_g4.Size = new System.Drawing.Size(30, 30);
			this.pictureBox_g4.TabIndex = 12;
			this.pictureBox_g4.TabStop = false;
			this.pictureBox_g4.Click += new System.EventHandler(this.pictureBox_g4_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 342);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(324, 16);
			this.panel1.TabIndex = 3;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.button2.Location = new System.Drawing.Point(237, 35);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(53, 32);
			this.button2.TabIndex = 2;
			this.button2.Text = "Help";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(324, 358);
			this.Controls.Add(this.pictureBox_g4);
			this.Controls.Add(this.pictureBox_g2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox_g3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox_g1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "Make Linear Gradient 256";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_g1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_g2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_g3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_g4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox_g1;
		private System.Windows.Forms.PictureBox pictureBox_g2;
		private System.Windows.Forms.PictureBox pictureBox_g3;
		private System.Windows.Forms.PictureBox pictureBox_g4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button button2;
	}
}

