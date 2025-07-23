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

namespace WindowsForms
{
	public partial class MainForm : Form
	{
		ColorDialog cdBackColor;
		ColorDialog cdForeColor;

		public MainForm()
		{
			InitializeComponent();
			ShowControls(cmShowControls.Checked);
			cdBackColor = new ColorDialog();
			cdForeColor = new ColorDialog();
		}

		void ShowControls(bool visible)
		{
			cbShowDate.Visible = visible;
			cbShowWeekDay.Visible = visible;
			btnHideControls.Visible = visible;
			this.ShowInTaskbar = visible;
			this.TransparencyKey = visible ? Color.Empty : this.BackColor;
			this.FormBorderStyle = visible ? FormBorderStyle.FixedDialog : FormBorderStyle.None;
			this.labelCurrentTime.BackColor = visible ? this.BackColor : Color.DeepSkyBlue;
		}

		void ShowConsole(bool visible)
		{
			//	bool console = visible ? AllocConsole() : FreeConsole();
			//if(console)Console.WriteLine(console);
			if (visible)
				AllocConsole();
			else
				FreeConsole();
		}


		private void timer_Tick(object sender, EventArgs e)
		{
			labelCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
			if (cbShowDate.Checked)
				labelCurrentTime.Text += $"\n{DateTime.Now.ToString("yyyy.MM.dd")}";

			if (cbShowWeekDay.Checked)
				labelCurrentTime.Text += $"\n{DateTime.Now.DayOfWeek}";
			notifyIcon.Text = labelCurrentTime.Text;
			if (cmDebugConsole.Checked)
				Console.WriteLine(notifyIcon.Text);
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
			cdBackColor.ShowDialog();// метод ShowDialog всегда открывает модальное окно.
									 //	if (cdBackColor.ShowDialog() == DialogResult.OK)
			labelCurrentTime.BackColor = cdBackColor.Color;

		}

		private void cmForeColor_Click(object sender, EventArgs e)
		{
			cdForeColor.ShowDialog();
			labelCurrentTime.ForeColor = cdForeColor.Color;
		}
	}
}
