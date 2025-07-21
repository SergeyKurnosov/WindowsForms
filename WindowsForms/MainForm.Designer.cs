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
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.cbShowDate = new System.Windows.Forms.CheckBox();
			this.cbShowWeekDay = new System.Windows.Forms.CheckBox();
			this.btnHideControls = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelCurrentTime
			// 
			this.labelCurrentTime.AutoSize = true;
			this.labelCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelCurrentTime.Location = new System.Drawing.Point(12, 9);
			this.labelCurrentTime.Name = "labelCurrentTime";
			this.labelCurrentTime.Size = new System.Drawing.Size(252, 51);
			this.labelCurrentTime.TabIndex = 0;
			this.labelCurrentTime.Text = "currentTime";
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
			this.btnHideControls.Size = new System.Drawing.Size(202, 75);
			this.btnHideControls.TabIndex = 3;
			this.btnHideControls.Text = "Скрыть элементы управления";
			this.btnHideControls.UseVisualStyleBackColor = true;
			this.btnHideControls.Click += new System.EventHandler(this.btnHideControls_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(379, 450);
			this.Controls.Add(this.btnHideControls);
			this.Controls.Add(this.cbShowWeekDay);
			this.Controls.Add(this.cbShowDate);
			this.Controls.Add(this.labelCurrentTime);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Clock";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelCurrentTime;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.CheckBox cbShowDate;
		private System.Windows.Forms.CheckBox cbShowWeekDay;
		private System.Windows.Forms.Button btnHideControls;
	}
}

