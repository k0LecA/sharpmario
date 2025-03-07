using MarioOrPlatformer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarioOrPlatformer
{
	public partial class GameFinalLevel : Form
	{
		bool goleft = false;
		bool goright = false;
		bool jumping = false;
		bool finished = false;

		int jumpSpeed = 10;
		int force = 8;
		int score = 0;
		int coincount = 0;
		int mushroomcount = 0;
		int livecount = 3;

		int tempInfo = 0;

		SoundPlayer coin = new SoundPlayer(@"c:\Users\User\Desktop\coin.wav");
		SoundPlayer loselife = new SoundPlayer(@"c:\Users\User\Desktop\loselife.wav");
		SoundPlayer powerup = new SoundPlayer(@"c:\Users\User\Desktop\powerup.wav");
		SoundPlayer pipe = new SoundPlayer(@"c:\Users\User\Desktop\pipe.wav");
		SoundPlayer gameover = new SoundPlayer(@"c:\Users\User\Desktop\gamover.wav");
		SoundPlayer jump = new SoundPlayer(@"c:\Users\User\Desktop\jump.wav");

		public GameFinalLevel()
		{
			InitializeComponent();
		}

		#region keyPressing
		private void keyisdown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Left)
			{
				goleft = true;
				tempInfo = 1; //looking left
			}
			if (e.KeyCode == Keys.Right)
			{
				goright = true;
				tempInfo = 2; //running right
			}
			if (e.KeyCode == Keys.Space && !jumping)
			{
				//jump.Play();
				jumping = true;
			}
		}

		private void keyisup(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Left)
			{
				goleft = false;
				tempInfo = 1; //looking left
			}
			if (e.KeyCode == Keys.Right)
			{
				goright = false;
				tempInfo = 2; //looking right
			}
			if (jumping)
			{
				jumping = false;
			}
		}
		#endregion

		LifeCounter lifeCounter = new LifeCounter();
		private void timer1_Tick(object sender, EventArgs e)
		{
			label2.Text = "Lives:" + lifeCounter.Livecount;

			if (lifeCounter.Dead())
			{
				gameOver.Visible = true;
				label3.Visible = true;
			}

			#region playerMovement

			player.Top += jumpSpeed;

			if (jumping && force < 0)
			{
				jumping = false;
			}

			if (goleft)
			{
				player.Left -= 5;
			}

			if (goright)
			{
				player.Left += 5;
			}

			if (jumping)
			{
				jumpSpeed = -12;
				force -= 1;

				if (tempInfo == 1)
					player.Image = Resources.jumpinReverse;
				if (tempInfo == 2)
					player.Image = Resources.jumpin;
			}
			else
			{
				jumpSpeed = 12;
			}
			#endregion

			#region interaction

			foreach (Control x in this.Controls)
			{
				if (x is PictureBox && x.Tag == "platform")
				{
					if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
					{
						if (tempInfo == 1)
							player.Image = Resources.stillReverse;
						if (tempInfo == 2)
							player.Image = Resources.still;
						force = 8;
						player.Top = x.Top - player.Height;
					}
				}
				if (x is PictureBox && x.Tag == "coin")
				{
					if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
					{
						//coin.Play();

						this.Controls.Remove(x);
						score++;
						coincount++;
						label1.Text = "Coins: " + coincount;
					}
				}

				if (x is PictureBox && x.Tag == "mushroom")
				{
					if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
					{
						//powerup.Play();

						this.Controls.Remove(x);
						score++;
						player.Size = new System.Drawing.Size(64, 64);
					}
				}
				if (x is PictureBox && x.Tag == "trigger")
				{
					if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
					{
						//loselife.Play();

						lifeCounter.Died();
						Point pl = player.Location;
						pl.X = 10;
						pl.Y = 100;
						player.Location = pl;
					}
				}
				if (x is PictureBox && x.Tag == "flag")
				{
					if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
					{
						//
						//pipe.Play();

						player.Image = Resources.jumpinReverse;
						score = coincount + mushroomcount * 2;
						
						Point pl = player.Location;

						//setting player location to flag location
						pl.X = flag.Location.X + 12;
						pl.Y = flag.Location.Y;

						player.Location = pl;

						timer1.Stop();
						timer2.Start();
						finished = true;
					}
				}
			}
			#endregion

		}

		private void timerFlag_Tick(object sender, EventArgs e)
		{
			jumpSpeed = 8;
			player.Top += jumpSpeed;

			Point pl = player.Location;
			pl.Y += 15;
			if (player.Location.Y >= flag.Location.Y + flag.Height - player.Height)
			{
				timer2.Stop();
				MessageBox.Show("Level Finished! Your score: " + score);

				LevelSelector lvlSel = new LevelSelector();
				lvlSel.Show();
				lvlSel.EnableButton();
				this.Hide();

			}
		}

		private void GameFinalLevel_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == Convert.ToChar(Keys.Enter))
			{
				Form lvlSel = new LevelSelector();
				lvlSel.Show();
				this.Hide();
			}
		}
	}
}
