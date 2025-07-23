using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace WindowsForms
{
	public partial class MainForm : Form
	{
		PrivateFontCollection fontCollection = new PrivateFontCollection();
		string[] fileNames = {
		"D:/ProjectHW/WindowsForms/WindowsForms/FONTS/lastfunk-street.colr_.ttf" ,
		"D:/ProjectHW/WindowsForms/WindowsForms/FONTS/YujiHentaiganaAkebono-Regular.ttf",
		"D:/ProjectHW/WindowsForms/WindowsForms/FONTS/Quantico-Bold.ttf",
		"D:/ProjectHW/WindowsForms/WindowsForms/FONTS/PinyonScript-Regular.ttf"};
		string[] fileimages ={
		"D:/ProjectHW/WindowsForms/WindowsForms/BACKIMAGE/fonstola.ru_138046.jpg",
		"D:/ProjectHW/WindowsForms/WindowsForms/BACKIMAGE/spongeBob.jpeg",
		"D:/ProjectHW/WindowsForms/WindowsForms/BACKIMAGE/Без названия.jpeg",
		"none"};
		int indexForChoiceImage = 3;


		public MainForm()
		{
			InitializeComponent();
			loadFontsFromFilesToCollection(fontCollection, fileNames);
			ShowControls(cmShowControls.Checked = true);

		}

		void ShowControls(bool visible)
		{
			RadioButton[] rbFonts = new RadioButton[] { rb1, rb2, rb3, rb4, rb5 };
			RadioButton[] rbColors = new RadioButton[] { rbColor1, rbColor2, rbColor3, rbColor4, rbColor5 };
			RadioButton[] rbImages = new RadioButton[] { rbImg1, rbImg2, rbImg3, rbImg4 };

			cbShowDate.Visible = visible;
			cbShowWeekDay.Visible = visible;
			btnHideControls.Visible = visible;
			cmShowControls.Checked = visible;
			for (int i = 0; i < rbFonts.Length; i++)
			{
				rbFonts[i].Visible = visible;
				rbFonts[i].BackColor = visible ? Color.Transparent : Color.White;
			}
			for (int i = 0; i < rbColors.Length; i++)
			{
				rbColors[i].Visible = visible;
				rbColors[i].BackColor = visible ? Color.Transparent : Color.White;
			}


			for (int i = 0; i < rbImages.Length; i++)
			{
				rbImages[i].Visible = visible;

			}
			rbImages[rbImages.Length - 1].BackColor = visible ? Color.Transparent : Color.White;

			this.ShowInTaskbar = visible;
			this.TransparencyKey = visible ? Color.Empty : this.BackColor;
			this.FormBorderStyle = visible ? FormBorderStyle.FixedDialog : FormBorderStyle.None;
			//	this.labelCurrentTime.BackColor = visible ? this.BackColor : Color.DeepSkyBlue;
		    this.labelCurrentTime.BackColor = visible ? this.BackColor : Color.Transparent;
			this.labelCurrentTime.Image = visible ? null : this.BackgroundImage;
			this.cbShowDate.Image = visible ? null : this.BackgroundImage;
			this.cbShowWeekDay.Image = visible ? null : this.BackgroundImage;
			this.btnHideControls.Image = visible ? null : this.BackgroundImage;
			this.rbImg4.Image = visible ? null : this.BackgroundImage;
			if (visible)
				setImageBackground(fileimages[indexForChoiceImage]);
			else
				this.BackgroundImage = null;

		}

		void ShowConsole(bool visible)
		{
			if (visible)
				AllocConsole();
			else
				FreeConsole();
		}

		void loadFontsFromFilesToCollection(PrivateFontCollection fontCollection, string[] fileNames)
		{

			for (int i = 0; i < fileNames.Length; i++)
			{
				fontCollection.AddFontFile(fileNames[i]);
			}

			rb1.Font = new Font(fontCollection.Families[0], this.rb1.Font.Size);
			rb2.Font = new Font(fontCollection.Families[1], this.rb2.Font.Size);
			rb3.Font = new Font(fontCollection.Families[2], this.rb3.Font.Size);
			rb4.Font = new Font(fontCollection.Families[3], this.rb4.Font.Size);
		}

		void setFont(FontFamily newFont)
		{
			this.labelCurrentTime.Font = new Font(newFont, this.labelCurrentTime.Font.Size);
			this.cbShowDate.Font = new Font(newFont, this.cbShowDate.Font.Size);
			this.cbShowWeekDay.Font = new Font(newFont, this.cbShowWeekDay.Font.Size);
			this.btnHideControls.Font = new Font(newFont, this.btnHideControls.Font.Size);
		}

		void setColorText(Color newColor)
		{
			this.labelCurrentTime.ForeColor = newColor;
			this.cbShowDate.ForeColor = newColor;
			this.cbShowWeekDay.ForeColor = newColor;
			this.btnHideControls.ForeColor = newColor;

			this.rb1.ForeColor = this.rb2.ForeColor = this.rb3.ForeColor = this.rb4.ForeColor = newColor;
		}

		void setImageBackground(string pathImage)
		{
			if (pathImage == "none")
			{
				this.BackgroundImage = this.btnHideControls.BackgroundImage = null;
			}
			else
			{
				this.BackgroundImage = Image.FromFile(pathImage);
				this.BackgroundImageLayout = ImageLayout.Stretch;

				this.labelCurrentTime.BackColor = Color.Transparent;
				this.cbShowDate.BackColor = Color.Transparent;
				this.cbShowWeekDay.BackColor = Color.Transparent;
				this.btnHideControls.BackgroundImage = Image.FromFile(pathImage);

				for (int i = 0; i < pathImage.Length; i++)
				{

				}
			}



		}


		///////////////////////////////////////////////////////////////////////////////////////////

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
			cmShowControls.Checked = false;
			ShowControls(cmShowControls.Checked);
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

		////////////////////////////////////////////////////////


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

		private void MainForm_Load(object sender, EventArgs e)
		{
			int screenWidth = Screen.PrimaryScreen.WorkingArea.Width,
				screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

			this.Location = cmShowControls.Checked ?
				new System.Drawing.Point(screenWidth - this.Size.Width, 0) :
				new System.Drawing.Point(screenWidth - this.labelCurrentTime.Size.Width + this.labelCurrentTime.Location.X, 0 - this.labelCurrentTime.Location.Y);



			//		this.BackgroundImage = Image.FromFile("D:/ProjectHW/WindowsForms/WindowsForms/BACKIMAGE/fonstola.ru_138046.jpg");
			//		this.BackgroundImageLayout = ImageLayout.Stretch;

			//		labelCurrentTime.BackColor = Color.Transparent;

		}

		private void rb1_CheckedChanged(object sender, EventArgs e)
		{
			FontFamily newFont = fontCollection.Families[0];
			setFont(newFont);
		}

		private void rb2_CheckedChanged(object sender, EventArgs e)
		{
			FontFamily newFont = fontCollection.Families[1];
			setFont(newFont);
		}

		private void rb3_CheckedChanged(object sender, EventArgs e)
		{
			FontFamily newFont = fontCollection.Families[2];
			setFont(newFont);
		}

		private void rb4_CheckedChanged(object sender, EventArgs e)
		{
			FontFamily newFont = fontCollection.Families[3];
			setFont(newFont);
		}

		private void rb5_CheckedChanged(object sender, EventArgs e)
		{
			this.labelCurrentTime.Font = new Font("Microsoft Sans Serif", this.labelCurrentTime.Font.Size);
			this.cbShowDate.Font = new Font("Microsoft Sans Serif", this.cbShowDate.Font.Size);
			this.cbShowWeekDay.Font = new Font("Microsoft Sans Serif", this.cbShowWeekDay.Font.Size);
			this.btnHideControls.Font = new Font("Microsoft Sans Serif", this.btnHideControls.Font.Size);
		}

		private void rbColor1_CheckedChanged(object sender, EventArgs e)
		{
			Color newColor = Color.Red;
			setColorText(newColor);
		}

		private void rbColor2_CheckedChanged(object sender, EventArgs e)
		{
			Color newColor = Color.Orange;
			setColorText(newColor);
		}

		private void rbColor3_CheckedChanged(object sender, EventArgs e)
		{
			Color newColor = Color.SeaGreen;
			setColorText(newColor);
		}

		private void rbColor4_CheckedChanged(object sender, EventArgs e)
		{
			Color newColor = Color.HotPink;
			setColorText(newColor);
		}

		private void rbColor5_CheckedChanged(object sender, EventArgs e)
		{
			Color newColor = Color.Black;
			setColorText(newColor);
		}

		private void rbImg1_CheckedChanged(object sender, EventArgs e)
		{
			indexForChoiceImage = 0;
			setImageBackground(fileimages[indexForChoiceImage]);
		}

		private void rbImg2_CheckedChanged(object sender, EventArgs e)
		{
			indexForChoiceImage = 1;
			setImageBackground(fileimages[indexForChoiceImage]);
		}

		private void rbImg3_CheckedChanged(object sender, EventArgs e)
		{
			indexForChoiceImage = 2;
			setImageBackground(fileimages[indexForChoiceImage]);
		}

		private void rbImg4_CheckedChanged(object sender, EventArgs e)
		{
			indexForChoiceImage = 3;
			setImageBackground(fileimages[indexForChoiceImage]);
		}

		private void cmShowControls_Click(object sender, EventArgs e)
		{

		}
	}
}
