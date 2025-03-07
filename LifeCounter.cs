using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioOrPlatformer
{
	public class LifeCounter
	{
		int[] lives = new int[3] { 1, 1, 1 };
		int livecount = 2;

		bool dead = false;
		public int Livecount { get { return livecount+1; } set { livecount = value; } }

		public void Died()
		{
			int counter = 0;
			lives[livecount] = 0;
			livecount--;
			for (int i = 0; i < 3; i++)
			{
				if (lives[i] == 0)
					counter++;
			}
			if (counter == 3)
			{
				dead = true;	
			}
		}
		public bool Dead()
		{
			if (dead)
				return true;
			else
				return false;
		}
	}
}
