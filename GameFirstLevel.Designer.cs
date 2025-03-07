namespace MarioOrPlatformer
{
	partial class Game
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timerTube = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.tube = new System.Windows.Forms.PictureBox();
			this.player = new System.Windows.Forms.PictureBox();
			this.pictureBox18 = new System.Windows.Forms.PictureBox();
			this.pictureBox17 = new System.Windows.Forms.PictureBox();
			this.pictureBox16 = new System.Windows.Forms.PictureBox();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox19 = new System.Windows.Forms.PictureBox();
			this.gameOver = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tube)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gameOver)).BeginInit();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 20;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// timerTube
			// 
			this.timerTube.Tick += new System.EventHandler(this.timerTube_Tick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(14, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 32);
			this.label1.TabIndex = 12;
			this.label1.Text = "Coins:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
			this.label2.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(150, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 32);
			this.label2.TabIndex = 12;
			this.label2.Text = "Lives:";
			// 
			// pictureBox14
			// 
			this.pictureBox14.Location = new System.Drawing.Point(276, 460);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(173, 20);
			this.pictureBox14.TabIndex = 14;
			this.pictureBox14.TabStop = false;
			this.pictureBox14.Tag = "trigger";
			// 
			// tube
			// 
			this.tube.BackColor = System.Drawing.Color.CornflowerBlue;
			this.tube.Image = global::MarioOrPlatformer.Properties.Resources.tube;
			this.tube.Location = new System.Drawing.Point(750, 172);
			this.tube.Name = "tube";
			this.tube.Size = new System.Drawing.Size(53, 58);
			this.tube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.tube.TabIndex = 13;
			this.tube.TabStop = false;
			this.tube.Tag = "tube";
			// 
			// player
			// 
			this.player.BackColor = System.Drawing.Color.CornflowerBlue;
			this.player.Image = global::MarioOrPlatformer.Properties.Resources.still;
			this.player.Location = new System.Drawing.Point(40, 340);
			this.player.Name = "player";
			this.player.Size = new System.Drawing.Size(29, 50);
			this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.player.TabIndex = 11;
			this.player.TabStop = false;
			// 
			// pictureBox18
			// 
			this.pictureBox18.Image = global::MarioOrPlatformer.Properties.Resources.coin;
			this.pictureBox18.Location = new System.Drawing.Point(577, 128);
			this.pictureBox18.Name = "pictureBox18";
			this.pictureBox18.Size = new System.Drawing.Size(16, 28);
			this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox18.TabIndex = 10;
			this.pictureBox18.TabStop = false;
			this.pictureBox18.Tag = "coin";
			// 
			// pictureBox17
			// 
			this.pictureBox17.Image = global::MarioOrPlatformer.Properties.Resources.coin;
			this.pictureBox17.Location = new System.Drawing.Point(55, 77);
			this.pictureBox17.Name = "pictureBox17";
			this.pictureBox17.Size = new System.Drawing.Size(16, 28);
			this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox17.TabIndex = 10;
			this.pictureBox17.TabStop = false;
			this.pictureBox17.Tag = "coin";
			// 
			// pictureBox16
			// 
			this.pictureBox16.Image = global::MarioOrPlatformer.Properties.Resources.coin;
			this.pictureBox16.Location = new System.Drawing.Point(187, 166);
			this.pictureBox16.Name = "pictureBox16";
			this.pictureBox16.Size = new System.Drawing.Size(16, 28);
			this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox16.TabIndex = 10;
			this.pictureBox16.TabStop = false;
			this.pictureBox16.Tag = "coin";
			// 
			// pictureBox15
			// 
			this.pictureBox15.Image = global::MarioOrPlatformer.Properties.Resources.coin;
			this.pictureBox15.Location = new System.Drawing.Point(33, 77);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(16, 28);
			this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox15.TabIndex = 10;
			this.pictureBox15.TabStop = false;
			this.pictureBox15.Tag = "coin";
			// 
			// pictureBox12
			// 
			this.pictureBox12.Image = global::MarioOrPlatformer.Properties.Resources.platform;
			this.pictureBox12.Location = new System.Drawing.Point(552, 162);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(64, 32);
			this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox12.TabIndex = 8;
			this.pictureBox12.TabStop = false;
			this.pictureBox12.Tag = "platform";
			// 
			// pictureBox13
			// 
			this.pictureBox13.Image = global::MarioOrPlatformer.Properties.Resources.platform;
			this.pictureBox13.Location = new System.Drawing.Point(775, 229);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(64, 32);
			this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox13.TabIndex = 8;
			this.pictureBox13.TabStop = false;
			this.pictureBox13.Tag = "platform";
			// 
			// pictureBox10
			// 
			this.pictureBox10.Image = global::MarioOrPlatformer.Properties.Resources.platform;
			this.pictureBox10.Location = new System.Drawing.Point(714, 229);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(64, 32);
			this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox10.TabIndex = 8;
			this.pictureBox10.TabStop = false;
			this.pictureBox10.Tag = "platform";
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = global::MarioOrPlatformer.Properties.Resources.platform;
			this.pictureBox8.Location = new System.Drawing.Point(635, 294);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(64, 32);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox8.TabIndex = 8;
			this.pictureBox8.TabStop = false;
			this.pictureBox8.Tag = "platform";
			// 
			// pictureBox11
			// 
			this.pictureBox11.Image = global::MarioOrPlatformer.Properties.Resources.platform;
			this.pictureBox11.Location = new System.Drawing.Point(22, 111);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(64, 32);
			this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox11.TabIndex = 8;
			this.pictureBox11.TabStop = false;
			this.pictureBox11.Tag = "platform";
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = global::MarioOrPlatformer.Properties.Resources.platform;
			this.pictureBox7.Location = new System.Drawing.Point(552, 346);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(64, 32);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox7.TabIndex = 8;
			this.pictureBox7.TabStop = false;
			this.pictureBox7.Tag = "platform";
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = global::MarioOrPlatformer.Properties.Resources.platform;
			this.pictureBox6.Location = new System.Drawing.Point(162, 208);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(64, 32);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox6.TabIndex = 8;
			this.pictureBox6.TabStop = false;
			this.pictureBox6.Tag = "platform";
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = global::MarioOrPlatformer.Properties.Resources.platform;
			this.pictureBox5.Location = new System.Drawing.Point(22, 269);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(64, 32);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox5.TabIndex = 8;
			this.pictureBox5.TabStop = false;
			this.pictureBox5.Tag = "platform";
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::MarioOrPlatformer.Properties.Resources.platform;
			this.pictureBox4.Location = new System.Drawing.Point(162, 330);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(64, 32);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox4.TabIndex = 8;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Tag = "platform";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::MarioOrPlatformer.Properties.Resources.platform;
			this.pictureBox2.Location = new System.Drawing.Point(331, 208);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(64, 32);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 8;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Tag = "platform";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::MarioOrPlatformer.Properties.Resources.platformground;
			this.pictureBox3.Location = new System.Drawing.Point(455, 415);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(900, 96);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox3.TabIndex = 7;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Tag = "platform";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::MarioOrPlatformer.Properties.Resources.platformground;
			this.pictureBox1.Location = new System.Drawing.Point(-630, 415);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(900, 96);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Tag = "platform";
			// 
			// pictureBox9
			// 
			this.pictureBox9.Image = global::MarioOrPlatformer.Properties.Resources.levelBackground;
			this.pictureBox9.Location = new System.Drawing.Point(-3, -4);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(806, 458);
			this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox9.TabIndex = 6;
			this.pictureBox9.TabStop = false;
			// 
			// pictureBox19
			// 
			this.pictureBox19.BackColor = System.Drawing.Color.CornflowerBlue;
			this.pictureBox19.Image = global::MarioOrPlatformer.Properties.Resources.mushroom;
			this.pictureBox19.Location = new System.Drawing.Point(33, 208);
			this.pictureBox19.Name = "pictureBox19";
			this.pictureBox19.Size = new System.Drawing.Size(49, 50);
			this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox19.TabIndex = 16;
			this.pictureBox19.TabStop = false;
			this.pictureBox19.Tag = "mushroom";
			// 
			// gameOver
			// 
			this.gameOver.Image = global::MarioOrPlatformer.Properties.Resources.gameover;
			this.gameOver.Location = new System.Drawing.Point(-3, -14);
			this.gameOver.Name = "gameOver";
			this.gameOver.Size = new System.Drawing.Size(806, 468);
			this.gameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.gameOver.TabIndex = 17;
			this.gameOver.TabStop = false;
			this.gameOver.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Black;
			this.label3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label3.Location = new System.Drawing.Point(28, 387);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(260, 25);
			this.label3.TabIndex = 19;
			this.label3.Text = "Press \"Enter\" to continue";
			this.label3.Visible = false;
			// 
			// Game
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(794, 441);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.gameOver);
			this.Controls.Add(this.pictureBox19);
			this.Controls.Add(this.pictureBox14);
			this.Controls.Add(this.tube);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.player);
			this.Controls.Add(this.pictureBox18);
			this.Controls.Add(this.pictureBox17);
			this.Controls.Add(this.pictureBox16);
			this.Controls.Add(this.pictureBox15);
			this.Controls.Add(this.pictureBox12);
			this.Controls.Add(this.pictureBox13);
			this.Controls.Add(this.pictureBox10);
			this.Controls.Add(this.pictureBox8);
			this.Controls.Add(this.pictureBox11);
			this.Controls.Add(this.pictureBox7);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox9);
			this.MaximumSize = new System.Drawing.Size(810, 480);
			this.MinimumSize = new System.Drawing.Size(810, 480);
			this.Name = "Game";
			this.Text = "Game";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Game_KeyPress);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tube)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gameOver)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timerTube;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.PictureBox pictureBox13;
		private System.Windows.Forms.PictureBox pictureBox15;
		private System.Windows.Forms.PictureBox pictureBox16;
		private System.Windows.Forms.PictureBox pictureBox17;
		private System.Windows.Forms.PictureBox pictureBox18;
		private System.Windows.Forms.PictureBox player;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox tube;
		private System.Windows.Forms.PictureBox pictureBox14;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox19;
		private System.Windows.Forms.PictureBox gameOver;
		private System.Windows.Forms.Label label3;
	}
}