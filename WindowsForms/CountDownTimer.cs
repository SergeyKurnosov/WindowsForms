using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
	public partial class CountDownTimer : Form
	{
		DateTime terget;
		int index;
		bool defSound = true;
		List<SoundPlayer> soundPlayers = new List<SoundPlayer>();
		public CountDownTimer()
		{
			InitializeComponent();
		}
		public CountDownTimer(List<SoundPlayer> soundPlayers)
		{
			InitializeComponent();
			this.soundPlayers = soundPlayers;
		}
		public void setDefSound(bool defSound)
		{
			this.defSound = defSound;
		}
		public void setIndex(int index)
		{
			this.index = index;
		}


		void timer1_Tick(object sender, EventArgs e)
		{
			var remaing = terget - DateTime.Now;

			if(remaing <= TimeSpan.Zero)
			{
				timer1.Stop();
				UpdateLabel("Время истекло!");
				if (defSound)
					Console.Beep(1000, 3000);
				else
				{
					var stopwatch = Stopwatch.StartNew();
					while (stopwatch.ElapsedMilliseconds < 3000)
						soundPlayers[index].PlaySync();
				}
				return;
			}
			string time = string.Format("{0:D2}:{1:D2}:{2:D2}",
				remaing.Hours + remaing.Days * 24,
				remaing.Minutes,
				remaing.Seconds);
			UpdateLabel($"Оставшееся время: {time}");
		}

	    void btStartTimer_Click(object sender, EventArgs e)
		{
			if (dtp1.Value > DateTime.Now)
				terget = dtp1.Value;

			timer1.Start();
		}

		void UpdateLabel(string text)
		{
			if (lbTimer.InvokeRequired)
			{
				lbTimer.Invoke(new Action(() => lbTimer.Text = text));
			}
			else
			{
				lbTimer.Text = text;
			}
		}
	}
}
