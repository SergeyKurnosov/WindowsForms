namespace WindowsForms
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.labelCurrentTime = new System.Windows.Forms.Label();
			this.cmMainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cmTopmost = new System.Windows.Forms.ToolStripMenuItem();
			this.cmShowControls = new System.Windows.Forms.ToolStripMenuItem();
			this.cmDebugConsole = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.cmShowDate = new System.Windows.Forms.ToolStripMenuItem();
			this.cmShowWeekDay = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.cmFont = new System.Windows.Forms.ToolStripMenuItem();
			this.cmBackColor = new System.Windows.Forms.ToolStripMenuItem();
			this.cmForeColor = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.cmClose = new System.Windows.Forms.ToolStripMenuItem();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.cbShowDate = new System.Windows.Forms.CheckBox();
			this.cbShowWeekDay = new System.Windows.Forms.CheckBox();
			this.btnHideControls = new System.Windows.Forms.Button();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.rb2 = new System.Windows.Forms.RadioButton();
			this.rb3 = new System.Windows.Forms.RadioButton();
			this.rb1 = new System.Windows.Forms.RadioButton();
			this.rb4 = new System.Windows.Forms.RadioButton();
			this.rb5 = new System.Windows.Forms.RadioButton();
			this.rbColor5 = new System.Windows.Forms.RadioButton();
			this.rbColor4 = new System.Windows.Forms.RadioButton();
			this.rbColor1 = new System.Windows.Forms.RadioButton();
			this.rbColor3 = new System.Windows.Forms.RadioButton();
			this.rbColor2 = new System.Windows.Forms.RadioButton();
			this.rbImg4 = new System.Windows.Forms.RadioButton();
			this.rbImg3 = new System.Windows.Forms.RadioButton();
			this.rbImg2 = new System.Windows.Forms.RadioButton();
			this.rbImg1 = new System.Windows.Forms.RadioButton();
			this.cmMainMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelCurrentTime
			// 
			this.labelCurrentTime.AutoSize = true;
			this.labelCurrentTime.BackColor = System.Drawing.SystemColors.Control;
			this.labelCurrentTime.ContextMenuStrip = this.cmMainMenu;
			this.labelCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelCurrentTime.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelCurrentTime.Location = new System.Drawing.Point(21, 9);
			this.labelCurrentTime.Name = "labelCurrentTime";
			this.labelCurrentTime.Size = new System.Drawing.Size(252, 51);
			this.labelCurrentTime.TabIndex = 0;
			this.labelCurrentTime.Text = "currentTime";
			this.labelCurrentTime.DoubleClick += new System.EventHandler(this.labelCurrentTime_DoubleClick);
			// 
			// cmMainMenu
			// 
			this.cmMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmTopmost,
            this.cmShowControls,
            this.cmDebugConsole,
            this.toolStripSeparator1,
            this.cmShowDate,
            this.cmShowWeekDay,
            this.toolStripSeparator2,
            this.cmFont,
            this.cmBackColor,
            this.cmForeColor,
            this.toolStripSeparator3,
            this.cmClose});
			this.cmMainMenu.Name = "cmMainMenu";
			this.cmMainMenu.Size = new System.Drawing.Size(169, 220);
			// 
			// cmTopmost
			// 
			this.cmTopmost.CheckOnClick = true;
			this.cmTopmost.Name = "cmTopmost";
			this.cmTopmost.Size = new System.Drawing.Size(168, 22);
			this.cmTopmost.Text = "Topmost";
			this.cmTopmost.CheckedChanged += new System.EventHandler(this.cmTopmost_CheckedChanged);
			// 
			// cmShowControls
			// 
			this.cmShowControls.CheckOnClick = true;
			this.cmShowControls.Name = "cmShowControls";
			this.cmShowControls.Size = new System.Drawing.Size(168, 22);
			this.cmShowControls.Text = "show controls";
			this.cmShowControls.CheckedChanged += new System.EventHandler(this.cmShowControls_CheckedChanged);
			this.cmShowControls.Click += new System.EventHandler(this.cmShowControls_Click);
			// 
			// cmDebugConsole
			// 
			this.cmDebugConsole.CheckOnClick = true;
			this.cmDebugConsole.Name = "cmDebugConsole";
			this.cmDebugConsole.Size = new System.Drawing.Size(168, 22);
			this.cmDebugConsole.Text = "console ";
			this.cmDebugConsole.CheckedChanged += new System.EventHandler(this.cmDebugConsole_CheckedChanged);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
			// 
			// cmShowDate
			// 
			this.cmShowDate.Name = "cmShowDate";
			this.cmShowDate.Size = new System.Drawing.Size(168, 22);
			this.cmShowDate.Text = "show date";
			// 
			// cmShowWeekDay
			// 
			this.cmShowWeekDay.Name = "cmShowWeekDay";
			this.cmShowWeekDay.Size = new System.Drawing.Size(168, 22);
			this.cmShowWeekDay.Text = "show week day";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(165, 6);
			// 
			// cmFont
			// 
			this.cmFont.Name = "cmFont";
			this.cmFont.Size = new System.Drawing.Size(168, 22);
			this.cmFont.Text = "font";
			// 
			// cmBackColor
			// 
			this.cmBackColor.Name = "cmBackColor";
			this.cmBackColor.Size = new System.Drawing.Size(168, 22);
			this.cmBackColor.Text = "background color";
			// 
			// cmForeColor
			// 
			this.cmForeColor.Name = "cmForeColor";
			this.cmForeColor.Size = new System.Drawing.Size(168, 22);
			this.cmForeColor.Text = "foreground color";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(165, 6);
			// 
			// cmClose
			// 
			this.cmClose.Name = "cmClose";
			this.cmClose.Size = new System.Drawing.Size(168, 22);
			this.cmClose.Text = "close";
			this.cmClose.Click += new System.EventHandler(this.cmClose_Click);
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// cbShowDate
			// 
			this.cbShowDate.AutoSize = true;
			this.cbShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbShowDate.Location = new System.Drawing.Point(21, 158);
			this.cbShowDate.Name = "cbShowDate";
			this.cbShowDate.Size = new System.Drawing.Size(193, 33);
			this.cbShowDate.TabIndex = 1;
			this.cbShowDate.Text = "Показать дату";
			this.cbShowDate.UseVisualStyleBackColor = true;
			// 
			// cbShowWeekDay
			// 
			this.cbShowWeekDay.AutoSize = true;
			this.cbShowWeekDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbShowWeekDay.Location = new System.Drawing.Point(21, 205);
			this.cbShowWeekDay.Name = "cbShowWeekDay";
			this.cbShowWeekDay.Size = new System.Drawing.Size(284, 33);
			this.cbShowWeekDay.TabIndex = 2;
			this.cbShowWeekDay.Text = "Показать день недели";
			this.cbShowWeekDay.UseVisualStyleBackColor = true;
			// 
			// btnHideControls
			// 
			this.btnHideControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnHideControls.Location = new System.Drawing.Point(21, 265);
			this.btnHideControls.Name = "btnHideControls";
			this.btnHideControls.Size = new System.Drawing.Size(202, 84);
			this.btnHideControls.TabIndex = 3;
			this.btnHideControls.Text = "Скрыть элементы управления";
			this.btnHideControls.UseVisualStyleBackColor = true;
			this.btnHideControls.Click += new System.EventHandler(this.btnHideControls_Click);
			// 
			// notifyIcon
			// 
			this.notifyIcon.ContextMenuStrip = this.cmMainMenu;
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "notifyIcon";
			this.notifyIcon.Visible = true;
			this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
			// 
			// rb2
			// 
			this.rb2.AutoSize = true;
			this.rb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rb2.Location = new System.Drawing.Point(389, 148);
			this.rb2.Name = "rb2";
			this.rb2.Size = new System.Drawing.Size(134, 20);
			this.rb2.TabIndex = 5;
			this.rb2.Text = "( 123 +-= abc абв ]";
			this.rb2.UseVisualStyleBackColor = true;
			this.rb2.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged);
			// 
			// rb3
			// 
			this.rb3.AutoSize = true;
			this.rb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rb3.Location = new System.Drawing.Point(389, 171);
			this.rb3.Name = "rb3";
			this.rb3.Size = new System.Drawing.Size(134, 20);
			this.rb3.TabIndex = 6;
			this.rb3.Text = "( 123 +-= abc абв ]";
			this.rb3.UseVisualStyleBackColor = true;
			this.rb3.CheckedChanged += new System.EventHandler(this.rb3_CheckedChanged);
			// 
			// rb1
			// 
			this.rb1.AutoSize = true;
			this.rb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rb1.Location = new System.Drawing.Point(389, 125);
			this.rb1.Name = "rb1";
			this.rb1.Size = new System.Drawing.Size(134, 20);
			this.rb1.TabIndex = 7;
			this.rb1.Text = "( 123 +-= abc абв ]";
			this.rb1.UseVisualStyleBackColor = true;
			this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
			// 
			// rb4
			// 
			this.rb4.AutoSize = true;
			this.rb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rb4.Location = new System.Drawing.Point(389, 194);
			this.rb4.Name = "rb4";
			this.rb4.Size = new System.Drawing.Size(134, 20);
			this.rb4.TabIndex = 8;
			this.rb4.Text = "( 123 +-= abc абв ]";
			this.rb4.UseVisualStyleBackColor = true;
			this.rb4.CheckedChanged += new System.EventHandler(this.rb4_CheckedChanged);
			// 
			// rb5
			// 
			this.rb5.AutoSize = true;
			this.rb5.Location = new System.Drawing.Point(389, 215);
			this.rb5.Name = "rb5";
			this.rb5.Size = new System.Drawing.Size(57, 17);
			this.rb5.TabIndex = 9;
			this.rb5.Text = "default";
			this.rb5.UseVisualStyleBackColor = true;
			this.rb5.CheckedChanged += new System.EventHandler(this.rb5_CheckedChanged);
			// 
			// rbColor5
			// 
			this.rbColor5.AutoSize = true;
			this.rbColor5.ForeColor = System.Drawing.Color.Black;
			this.rbColor5.Location = new System.Drawing.Point(389, 345);
			this.rbColor5.Name = "rbColor5";
			this.rbColor5.Size = new System.Drawing.Size(57, 17);
			this.rbColor5.TabIndex = 14;
			this.rbColor5.Text = "default";
			this.rbColor5.UseVisualStyleBackColor = true;
			this.rbColor5.CheckedChanged += new System.EventHandler(this.rbColor5_CheckedChanged);
			// 
			// rbColor4
			// 
			this.rbColor4.AutoSize = true;
			this.rbColor4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbColor4.ForeColor = System.Drawing.Color.HotPink;
			this.rbColor4.Location = new System.Drawing.Point(389, 324);
			this.rbColor4.Name = "rbColor4";
			this.rbColor4.Size = new System.Drawing.Size(134, 20);
			this.rbColor4.TabIndex = 13;
			this.rbColor4.Text = "( 123 +-= abc абв ]";
			this.rbColor4.UseVisualStyleBackColor = true;
			this.rbColor4.CheckedChanged += new System.EventHandler(this.rbColor4_CheckedChanged);
			// 
			// rbColor1
			// 
			this.rbColor1.AutoSize = true;
			this.rbColor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbColor1.ForeColor = System.Drawing.Color.Red;
			this.rbColor1.Location = new System.Drawing.Point(389, 255);
			this.rbColor1.Name = "rbColor1";
			this.rbColor1.Size = new System.Drawing.Size(134, 20);
			this.rbColor1.TabIndex = 12;
			this.rbColor1.Text = "( 123 +-= abc абв ]";
			this.rbColor1.UseVisualStyleBackColor = true;
			this.rbColor1.CheckedChanged += new System.EventHandler(this.rbColor1_CheckedChanged);
			// 
			// rbColor3
			// 
			this.rbColor3.AutoSize = true;
			this.rbColor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbColor3.ForeColor = System.Drawing.Color.SeaGreen;
			this.rbColor3.Location = new System.Drawing.Point(389, 301);
			this.rbColor3.Name = "rbColor3";
			this.rbColor3.Size = new System.Drawing.Size(134, 20);
			this.rbColor3.TabIndex = 11;
			this.rbColor3.Text = "( 123 +-= abc абв ]";
			this.rbColor3.UseVisualStyleBackColor = true;
			this.rbColor3.CheckedChanged += new System.EventHandler(this.rbColor3_CheckedChanged);
			// 
			// rbColor2
			// 
			this.rbColor2.AutoSize = true;
			this.rbColor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbColor2.ForeColor = System.Drawing.Color.Orange;
			this.rbColor2.Location = new System.Drawing.Point(389, 278);
			this.rbColor2.Name = "rbColor2";
			this.rbColor2.Size = new System.Drawing.Size(134, 20);
			this.rbColor2.TabIndex = 10;
			this.rbColor2.Text = "( 123 +-= abc абв ]";
			this.rbColor2.UseVisualStyleBackColor = true;
			this.rbColor2.CheckedChanged += new System.EventHandler(this.rbColor2_CheckedChanged);
			// 
			// rbImg4
			// 
			this.rbImg4.AutoSize = true;
			this.rbImg4.ForeColor = System.Drawing.Color.Black;
			this.rbImg4.Location = new System.Drawing.Point(389, 79);
			this.rbImg4.Name = "rbImg4";
			this.rbImg4.Size = new System.Drawing.Size(57, 17);
			this.rbImg4.TabIndex = 18;
			this.rbImg4.Text = "default";
			this.rbImg4.UseVisualStyleBackColor = true;
			this.rbImg4.CheckedChanged += new System.EventHandler(this.rbImg4_CheckedChanged);
			// 
			// rbImg3
			// 
			this.rbImg3.AutoSize = true;
			this.rbImg3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbImg3.BackgroundImage")));
			this.rbImg3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbImg3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.rbImg3.Location = new System.Drawing.Point(389, 58);
			this.rbImg3.Name = "rbImg3";
			this.rbImg3.Size = new System.Drawing.Size(51, 20);
			this.rbImg3.TabIndex = 17;
			this.rbImg3.Text = "lake";
			this.rbImg3.UseVisualStyleBackColor = true;
			this.rbImg3.CheckedChanged += new System.EventHandler(this.rbImg3_CheckedChanged);
			// 
			// rbImg2
			// 
			this.rbImg2.AutoSize = true;
			this.rbImg2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbImg2.BackgroundImage")));
			this.rbImg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbImg2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.rbImg2.Location = new System.Drawing.Point(389, 35);
			this.rbImg2.Name = "rbImg2";
			this.rbImg2.Size = new System.Drawing.Size(63, 20);
			this.rbImg2.TabIndex = 16;
			this.rbImg2.Text = "ocean";
			this.rbImg2.UseVisualStyleBackColor = true;
			this.rbImg2.CheckedChanged += new System.EventHandler(this.rbImg2_CheckedChanged);
			// 
			// rbImg1
			// 
			this.rbImg1.AutoSize = true;
			this.rbImg1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbImg1.BackgroundImage")));
			this.rbImg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbImg1.ForeColor = System.Drawing.SystemColors.Info;
			this.rbImg1.Location = new System.Drawing.Point(389, 12);
			this.rbImg1.Name = "rbImg1";
			this.rbImg1.Size = new System.Drawing.Size(54, 20);
			this.rbImg1.TabIndex = 19;
			this.rbImg1.Text = "stars";
			this.rbImg1.UseVisualStyleBackColor = true;
			this.rbImg1.CheckedChanged += new System.EventHandler(this.rbImg1_CheckedChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(616, 370);
			this.Controls.Add(this.rbImg1);
			this.Controls.Add(this.rbImg4);
			this.Controls.Add(this.rbImg3);
			this.Controls.Add(this.rbImg2);
			this.Controls.Add(this.rbColor5);
			this.Controls.Add(this.rbColor4);
			this.Controls.Add(this.rbColor1);
			this.Controls.Add(this.rbColor3);
			this.Controls.Add(this.rbColor2);
			this.Controls.Add(this.rb5);
			this.Controls.Add(this.rb4);
			this.Controls.Add(this.rb1);
			this.Controls.Add(this.rb3);
			this.Controls.Add(this.rb2);
			this.Controls.Add(this.btnHideControls);
			this.Controls.Add(this.cbShowWeekDay);
			this.Controls.Add(this.cbShowDate);
			this.Controls.Add(this.labelCurrentTime);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Clock";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.cmMainMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelCurrentTime;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.CheckBox cbShowDate;
		private System.Windows.Forms.CheckBox cbShowWeekDay;
		private System.Windows.Forms.Button btnHideControls;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ContextMenuStrip cmMainMenu;
		private System.Windows.Forms.ToolStripMenuItem cmTopmost;
		private System.Windows.Forms.ToolStripMenuItem cmShowControls;
		private System.Windows.Forms.ToolStripMenuItem cmDebugConsole;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem cmShowDate;
		private System.Windows.Forms.ToolStripMenuItem cmShowWeekDay;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem cmFont;
		private System.Windows.Forms.ToolStripMenuItem cmBackColor;
		private System.Windows.Forms.ToolStripMenuItem cmForeColor;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem cmClose;
		private System.Windows.Forms.RadioButton rb2;
		private System.Windows.Forms.RadioButton rb3;
		private System.Windows.Forms.RadioButton rb1;
		private System.Windows.Forms.RadioButton rb4;
		private System.Windows.Forms.RadioButton rb5;
		private System.Windows.Forms.RadioButton rbColor5;
		private System.Windows.Forms.RadioButton rbColor4;
		private System.Windows.Forms.RadioButton rbColor1;
		private System.Windows.Forms.RadioButton rbColor3;
		private System.Windows.Forms.RadioButton rbColor2;
		private System.Windows.Forms.RadioButton rbImg4;
		private System.Windows.Forms.RadioButton rbImg3;
		private System.Windows.Forms.RadioButton rbImg2;
		private System.Windows.Forms.RadioButton rbImg1;
	}
}

