using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using Microsoft.Win32;
using System.Media;
using System.Diagnostics;

namespace WindowsForms
{
	public partial class MainForm : Form
	{
		ChooseFont chooseFont;
		CountDownTimer countDownTimer;
		ColorDialog cdBackColor;
		ColorDialog cdForeColor;
		DateTimePicker dtSelect;
		List<Alarm> ListAlarms;
		List<SoundPlayer> soundPlayers;
		bool defSound = true;
		int indexSound = 0;
		AlarmsTypes typeSelectAlarm;

		public MainForm()
		{
			InitializeComponent();
			ShowControls(cmShowControls.Checked);
			ShowConsole(cmDebugConsole.Checked = true);
			chooseFont = new ChooseFont();
			
			cdBackColor = new ColorDialog();
			cdForeColor = new ColorDialog();
			ListAlarms = new List<Alarm>();
			soundPlayers = new List<SoundPlayer>();
			this.Location = new Point
				(
				Screen.PrimaryScreen.Bounds.Width - this.Width,
				100
				);
			chooseFont.StartPosition = FormStartPosition.Manual;
			chooseFont.Location = new Point
				(
				this.Location.X - chooseFont.Width,
				100
				);
			LoadSettings();
			LoadSounds();
			LoadAlarm();
			countDownTimer = new CountDownTimer(soundPlayers);
			addListAlarmsToCM();
		}

		void ShowControls(bool visible)
		{
			cbShowDate.Visible = visible;
			cbShowWeekDay.Visible = visible;
			btnHideControls.Visible = visible;
			this.ShowInTaskbar = visible;
			this.TransparencyKey = visible ? Color.Empty : this.BackColor;
			this.FormBorderStyle = visible ? FormBorderStyle.FixedToolWindow : FormBorderStyle.None;
			this.labelCurrentTime.BackColor = visible ? this.BackColor : Color.DeepSkyBlue;
		}

		void addListAlarmsToCM()
		{


			if (ListAlarms.Count > 0)
			{
				for (int i = 0; i < ListAlarms.Count; i++)
					cmAlarms.Items.Add(new ToolStripMenuItem(ListAlarms[i].ToString()));
			}



		}

		void LoadSounds()
		{
			soundPlayers.Add(new SoundPlayer("D:/ProjectHW/WindowsForms/WindowsForms/Sounds/pornhub-intro-zastavka-dlya-video.wav"));
			soundPlayers.Add(new SoundPlayer("D:/ProjectHW/WindowsForms/WindowsForms/Sounds/korotkaya-melodiya-na-bubentsah-29025.wav"));
			soundPlayers.Add(new SoundPlayer("D:/ProjectHW/WindowsForms/WindowsForms/Sounds/jutkii-smeh-odinochnyii-korotkii-melodichnyii-mujskoi.wav"));
			soundPlayers.Add(new SoundPlayer("D:/ProjectHW/WindowsForms/WindowsForms/Sounds/protyajnyiy-zvuk-i-korotkaya-melodiya.wav"));
			soundPlayers.Add(new SoundPlayer("D:/ProjectHW/WindowsForms/WindowsForms/Sounds/otkryitie-korotkoy-melodii-v-ritme-nazvaniya-animatsii-fonovogo-zvuka-42693.wav"));
		}

		string SubStractDates(string content)
		{
			content = content.Split(' ')[0];
			string time = content.Split(';')[0];
			string date = content.Split(';')[1];
			AlarmsTypes type = (AlarmsTypes)Enum.Parse(typeof(AlarmsTypes), content.Split(';')[2]);

			DateTime timeAlarm = new DateTime();
			DateTime timeNow = DateTime.Now;
			if (type == AlarmsTypes.Time)
			{
				timeAlarm = new DateTime
				(
					 Convert.ToInt32(timeNow.Year),
					 Convert.ToInt32(timeNow.Month),
					Convert.ToInt32(timeNow.Day),
					 Convert.ToInt32(time.Split(':')[0]),
					 Convert.ToInt32(time.Split(':')[1]),
					Convert.ToInt32(time.Split(':')[2])
				);
			}
			else if (type == AlarmsTypes.DateTime)
			{
				timeAlarm = new DateTime
					(
					Convert.ToInt32(date.Split('.')[0]),
					Convert.ToInt32(date.Split('.')[1]),
					Convert.ToInt32(date.Split('.')[2]),
					Convert.ToInt32(time.Split(':')[0]),
					Convert.ToInt32(time.Split(':')[1]),
					Convert.ToInt32(time.Split(':')[2])
					);
			}
			TimeSpan remainder = timeAlarm - timeNow;
			StringBuilder result = new StringBuilder();
			result.Append($" Остаток : дней :{remainder.Days} ;");
			result.Append($"часов :{remainder.Hours} ;");
			result.Append($"минут :{remainder.Minutes} ;");
			result.Append($"секунд :{remainder.Seconds} .");

			return content + result.ToString();
		}

		bool AlarmBeep(string content)
		{
			content = content.Split(' ')[0];
			string time = content.Split(';')[0];
			string date = content.Split(';')[1];
			AlarmsTypes type = (AlarmsTypes)Enum.Parse(typeof(AlarmsTypes), content.Split(';')[2]);

			DateTime timeAlarm = new DateTime();
			DateTime timeNow = DateTime.Now;
			if (type == AlarmsTypes.Time)
			{
				timeAlarm = new DateTime
				(
					 Convert.ToInt32(timeNow.Year),
					 Convert.ToInt32(timeNow.Month),
					Convert.ToInt32(timeNow.Day),
					 Convert.ToInt32(time.Split(':')[0]),
					 Convert.ToInt32(time.Split(':')[1]),
					Convert.ToInt32(time.Split(':')[2])
				);
			}
			else if (type == AlarmsTypes.DateTime)
			{
				timeAlarm = new DateTime
					(
					Convert.ToInt32(date.Split('.')[0]),
					Convert.ToInt32(date.Split('.')[1]),
					Convert.ToInt32(date.Split('.')[2]),
					Convert.ToInt32(time.Split(':')[0]),
					Convert.ToInt32(time.Split(':')[1]),
					Convert.ToInt32(time.Split(':')[2])
					);
			}

			if (timeAlarm <= timeNow)
			{
				if (defSound)
					Console.Beep(1000, 3000);
				else
				{
					var stopwatch = Stopwatch.StartNew();
					while (stopwatch.ElapsedMilliseconds < 3000)
						soundPlayers[indexSound].PlaySync();
				}

				MessageBox.Show(
				"Время вышло , будильник сработал",
				"Будильник",
				 MessageBoxButtons.OK,
				 MessageBoxIcon.Information,
				 MessageBoxDefaultButton.Button1,
				 MessageBoxOptions.DefaultDesktopOnly);
				return true;
			}
			else return false;

		}

		void ShowConsole(bool visible)
		{
			if (visible)
				AllocConsole();
			else
				FreeConsole();
		}

		void SaveAlarm()
		{
			StreamWriter alarms = new StreamWriter("Alarms.ini");
			if (ListAlarms.Count == 0) return;

			for (int i = 0; i < ListAlarms.Count; i++)
			{
				alarms.WriteLine(ListAlarms[i].ToString());
			}
			alarms.Close();
		}

		void LoadAlarm()
		{
			StreamReader alarms = new StreamReader("Alarms.ini");
			string content;
			do
			{
				content = alarms.ReadLine();
				if (content != null)
					ListAlarms.Add(new Alarm(content));
			} while (content != null);
			alarms.Close();
		}

		void SaveSettings()
		{
			StreamWriter settings = new StreamWriter("Settings.ini");
			settings.WriteLine($"{this.Location.X}x{this.Location.Y}");
			settings.WriteLine(cmTopmost.Checked);
			settings.WriteLine(cmShowControls.Checked);
			settings.WriteLine(cmDebugConsole.Checked);
			settings.WriteLine(cmShowDate.Checked);
			settings.WriteLine(cmShowWeekDay.Checked);
			settings.WriteLine(cmLoadOnWindowsStartUp.Checked);
			settings.WriteLine(cdBackColor.Color.ToArgb());
			settings.WriteLine(cdForeColor.Color.ToArgb());
			settings.WriteLine(chooseFont.Filename);
			settings.Close();
		}

		void LoadSettings()
		{
			StreamReader settings = new StreamReader("Settings.ini");

			string location = settings.ReadLine();
			this.Location = new Point
				(
				Convert.ToInt32(location.Split('x').First()),
				Convert.ToInt32(location.Split('x').Last())
				);
			cmTopmost.Checked = bool.Parse(settings.ReadLine());
			cmShowControls.Checked = bool.Parse(settings.ReadLine());
			cmDebugConsole.Checked = bool.Parse(settings.ReadLine());
			cmShowDate.Checked = bool.Parse(settings.ReadLine());
			cmShowWeekDay.Checked = bool.Parse(settings.ReadLine());
			cmLoadOnWindowsStartUp.Checked = bool.Parse(settings.ReadLine());
			cdBackColor.Color = labelCurrentTime.BackColor = Color.FromArgb(Convert.ToInt32(settings.ReadLine()));
			cdForeColor.Color = labelCurrentTime.ForeColor = Color.FromArgb(Convert.ToInt32(settings.ReadLine()));
			string font_name = settings.ReadLine();
			chooseFont = new ChooseFont(this, font_name, 32);
			labelCurrentTime.Font = chooseFont.Font;
			settings.Close();
		}


		private void timer_Tick(object sender, EventArgs e)
		{
			labelCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
			if (cbShowDate.Checked)
				labelCurrentTime.Text += $"\n{DateTime.Now.ToString("yyyy.MM.dd")}";

			if (cbShowWeekDay.Checked)
				labelCurrentTime.Text += $"\n{DateTime.Now.DayOfWeek}";
			notifyIcon.Text = labelCurrentTime.Text;

			if (cmAlarms.Items.Count > 0)
			{
				ToolStripMenuItem forDelete = new ToolStripMenuItem();
				SortedDictionary<bool, int> infoForDeleteFromList = new SortedDictionary<bool, int>();
				infoForDeleteFromList.Add(false, 0);
				foreach (ToolStripItem item in cmAlarms.Items)
				{

					if (item is ToolStripMenuItem i)
					{
						if (i.Text != "Добавить новый будильник")
						{
							i.Text = SubStractDates(i.Text).ToString();
							if (AlarmBeep(i.Text))
							{
								forDelete = i;
								infoForDeleteFromList.Add(true, cmAlarms.Items.IndexOf(item));
							}
						}
					}
				}
				if (infoForDeleteFromList.ContainsKey(true))
				{

					ListAlarms.RemoveAt(infoForDeleteFromList[true] - 3);
				}
				cmAlarms.Items.Remove(forDelete);
				infoForDeleteFromList.Clear();
			}
		}



		private void btnHideControls_Click(object sender, EventArgs e)
		{
			ShowControls(cmShowControls.Checked = false);
		}

		private void labelCurrentTime_DoubleClick(object sender, EventArgs e)
		{
			ShowControls(cmShowControls.Checked = true);
		}

		private void cmClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cmTopmost_CheckedChanged(object sender, EventArgs e)
		{
			this.TopMost = cmTopmost.Checked;
		}

		private void cmShowControls_CheckedChanged(object sender, EventArgs e)
		{
			ShowControls(cmShowControls.Checked);
		}
		////////////////////////////////////////////////////////

		[DllImport("kernel32.dll")]
		public static extern bool AllocConsole();
		[DllImport("kernel32.dll")]
		public static extern bool FreeConsole();

		/// /////////////////////////////////////////////////////


		private void cmDebugConsole_CheckedChanged(object sender, EventArgs e)
		{
			ShowConsole(cmDebugConsole.Checked);
		}

		private void notifyIcon_DoubleClick(object sender, EventArgs e)
		{
			if (this.TopMost) return;
			this.TopMost = true;
			this.TopMost = false;
		}

		private void cmShowDate_CheckedChanged(object sender, EventArgs e)
		{
			cbShowDate.Checked = cmShowDate.Checked;
		}

		private void cmShowWeekDay_CheckedChanged(object sender, EventArgs e)
		{
			cbShowWeekDay.Checked = cmShowWeekDay.Checked;
		}

		private void cmBackColor_Click(object sender, EventArgs e)
		{
			cdBackColor.ShowDialog();
			labelCurrentTime.BackColor = cdBackColor.Color;
		}

		private void cmForeColor_Click(object sender, EventArgs e)
		{
			cdForeColor.ShowDialog();
			labelCurrentTime.ForeColor = cdForeColor.Color;
		}

		private void cmFont_Click(object sender, EventArgs e)
		{
			chooseFont.Location = new Point
		   (
			this.Location.X - chooseFont.Width,
			this.Location.Y
			);
			chooseFont.ShowDialog();
			labelCurrentTime.Font = chooseFont.Font;
		}

		private void cmLoadOnWindowsStartUp_CheckedChanged(object sender, EventArgs e)
		{
			string key_name = "Clock_PD_411";
			RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
			if (cmLoadOnWindowsStartUp.Checked) key.SetValue(key_name, Application.ExecutablePath); 
			else key.DeleteValue(key_name, false);
			key.Dispose();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveSettings();
			SaveAlarm();
		}

		private void btnAlarms_Click(object sender, EventArgs e)
		{
			Point btnLocation = btnAlarms.PointToScreen(Point.Empty);
			Point menuLocation = new Point(btnLocation.X, btnLocation.Y + btnAlarms.Height);

			cmAlarms.Show(menuLocation);
		}

		private void cmNewAlarm_Click(object sender, EventArgs e)
		{
			dtpDateTime.Visible = false;
			dtpTime.Visible = false;
			Alarm newAlarm = new Alarm();

			if (typeSelectAlarm == AlarmsTypes.Time)
				newAlarm = new Alarm(dtpTime.Value.ToString("HH:mm:ss"), "", AlarmsTypes.Time);
			else if (typeSelectAlarm == AlarmsTypes.DateTime)
				newAlarm = new Alarm(dtpDateTime.Value.ToString("HH:mm:ss"), dtpDateTime.Value.ToString("yyyy.MM.dd"), AlarmsTypes.DateTime);

			ListAlarms.Add(newAlarm);
			cmAlarms.Items.Add(new ToolStripMenuItem(newAlarm.ToString()));
		}

		private void cmOnlyTime_Click(object sender, EventArgs e)
		{
			dtpTime.Visible = true;
			typeSelectAlarm = AlarmsTypes.Time;
		}

		private void cmOnlyDateTime_Click(object sender, EventArgs e)
		{
			dtpDateTime.Visible = true;
			typeSelectAlarm = AlarmsTypes.DateTime;
		}

		private void rbsound6_CheckedChanged(object sender, EventArgs e)
		{
			defSound = true;
			countDownTimer.setDefSound(defSound);
		}

		private void rbsound1_CheckedChanged(object sender, EventArgs e)
		{
			indexSound = 0;
			defSound = false;
			countDownTimer.setDefSound(defSound);
			countDownTimer.setIndex(indexSound);
		}

		private void rbsound2_CheckedChanged(object sender, EventArgs e)
		{
			indexSound = 1;
			defSound = false;
			countDownTimer.setDefSound(defSound);
			countDownTimer.setIndex(indexSound);
		}

		private void rbsound3_CheckedChanged(object sender, EventArgs e)
		{
			indexSound = 2;
			defSound = false;
			countDownTimer.setDefSound(defSound);
			countDownTimer.setIndex(indexSound);
		}

		private void rbsound4_CheckedChanged(object sender, EventArgs e)
		{
			indexSound = 3;
			defSound = false;
			countDownTimer.setDefSound(defSound);
			countDownTimer.setIndex(indexSound);
		}

		private void rbsound5_CheckedChanged(object sender, EventArgs e)
		{
			indexSound = 4;
			defSound = false;
			countDownTimer.setDefSound(defSound);
			countDownTimer.setIndex(indexSound);
		}

		private void btnTimer_Click(object sender, EventArgs e)
		{
			countDownTimer.Show();
		}
	}
}
