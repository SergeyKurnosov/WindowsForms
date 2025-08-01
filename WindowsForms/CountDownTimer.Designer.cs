namespace WindowsForms
{
	partial class CountDownTimer
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
			this.dtp1 = new System.Windows.Forms.DateTimePicker();
			this.btStartTimer = new System.Windows.Forms.Button();
			this.lbTimer = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// dtp1
			// 
			this.dtp1.CustomFormat = "dd.MM.yyyy HH:mm:ss";
			this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp1.Location = new System.Drawing.Point(12, 12);
			this.dtp1.Name = "dtp1";
			this.dtp1.Size = new System.Drawing.Size(200, 20);
			this.dtp1.TabIndex = 0;
			// 
			// btStartTimer
			// 
			this.btStartTimer.Location = new System.Drawing.Point(12, 38);
			this.btStartTimer.Name = "btStartTimer";
			this.btStartTimer.Size = new System.Drawing.Size(136, 37);
			this.btStartTimer.TabIndex = 1;
			this.btStartTimer.Text = "Запустить таймер";
			this.btStartTimer.UseVisualStyleBackColor = true;
			this.btStartTimer.Click += new System.EventHandler(this.btStartTimer_Click);
			// 
			// lbTimer
			// 
			this.lbTimer.AutoSize = true;
			this.lbTimer.Location = new System.Drawing.Point(13, 91);
			this.lbTimer.Name = "lbTimer";
			this.lbTimer.Size = new System.Drawing.Size(135, 13);
			this.lbTimer.TabIndex = 2;
			this.lbTimer.Text = "Оставшееся время: --:--:--";
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// CountDownTimer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(220, 131);
			this.Controls.Add(this.lbTimer);
			this.Controls.Add(this.btStartTimer);
			this.Controls.Add(this.dtp1);
			this.Name = "CountDownTimer";
			this.Text = "CountDownTimer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dtp1;
		private System.Windows.Forms.Button btStartTimer;
		private System.Windows.Forms.Label lbTimer;
		private System.Windows.Forms.Timer timer1;
	}
}