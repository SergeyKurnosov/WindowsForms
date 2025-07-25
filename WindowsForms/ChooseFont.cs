using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;

namespace WindowsForms
{
	public partial class ChooseFont : Form
	{
		public Font Font {  get; set; }

		public ChooseFont()
		{
			InitializeComponent();
			string[] fonts_ttf = GetFontListFromCurrentDirectoryByExtension("*.ttf");
			string[] fonts_otf = GetFontListFromCurrentDirectoryByExtension("*.otf");
			string[] all_fonts = fonts_ttf.Concat(fonts_otf).ToArray();
			Array.Sort(all_fonts, StringComparer.OrdinalIgnoreCase);

			comboBoxChooseFont.Items.AddRange(all_fonts);
			comboBoxChooseFont.SelectedIndex = 0; // Если из списка ничего не выбранно SelectedIndex = -1

		}

		string[] GetFontListFromCurrentDirectoryByExtension(string extension)
		{
			Console.WriteLine(Application.ExecutablePath);
			string execution_path = Path.GetDirectoryName(Application.ExecutablePath);
			Console.WriteLine(execution_path);
			Directory.SetCurrentDirectory($"{execution_path}\\..\\..\\Fonts");
			Console.WriteLine(Directory.GetCurrentDirectory());
			string[] fonts = Directory.GetFiles(Directory.GetCurrentDirectory(), extension);
			
			for (int i = 0; i < fonts.Length; i++)
			{
				fonts[i] = fonts[i].Split('\\').Last();
			}
			return fonts;
		}

		void SetFont(string filename, float size = 32)
		{
			PrivateFontCollection pfc = new PrivateFontCollection();
			pfc.AddFontFile(filename);
			lblExample.Font = new Font(pfc.Families[0], size);
		}



		private void ChooseFont_Load(object sender, EventArgs e){}

		private void comboBoxChooseFont_SelectedIndexChanged(object sender, EventArgs e)
		{
			SetFont((sender as ComboBox).SelectedItem.ToString());
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			Font = lblExample.Font;
		}

		private void nudFontSize_ValueChanged(object sender, EventArgs e)
		{
		//	lblExample.Font.Size = (float)(sender as NumericUpDown).Value;
		SetFont(comboBoxChooseFont.SelectedItem.ToString(), (float)nudFontSize.Value);
         
		}
	}
}
