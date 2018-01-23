namespace oprForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.переглядЗаходiвToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переглядПроблемToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переглядЗаходiвToolStripMenuItem,
            this.eventsToolStripMenuItem,
            this.statsToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.переглядПроблемToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(982, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // переглядЗаходiвToolStripMenuItem
            // 
            this.переглядЗаходiвToolStripMenuItem.Name = "переглядЗаходiвToolStripMenuItem";
            this.переглядЗаходiвToolStripMenuItem.Size = new System.Drawing.Size(166, 29);
            this.переглядЗаходiвToolStripMenuItem.Text = "Перегляд заходiв";
            this.переглядЗаходiвToolStripMenuItem.Click += new System.EventHandler(this.переглядЗаходiвToolStripMenuItem_Click);
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(137, 29);
            this.eventsToolStripMenuItem.Text = "Мероприятия";
            this.eventsToolStripMenuItem.Click += new System.EventHandler(this.eventToolStripMenuItem_Click);
            // 
            // statsToolStripMenuItem
            // 
            this.statsToolStripMenuItem.Name = "statsToolStripMenuItem";
            this.statsToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.statsToolStripMenuItem.Text = "Статистика";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.reportToolStripMenuItem.Text = "Отчеты";
            // 
            // переглядПроблемToolStripMenuItem
            // 
            this.переглядПроблемToolStripMenuItem.Name = "переглядПроблемToolStripMenuItem";
            this.переглядПроблемToolStripMenuItem.Size = new System.Drawing.Size(179, 29);
            this.переглядПроблемToolStripMenuItem.Text = "Перегляд проблем";
            this.переглядПроблемToolStripMenuItem.Click += new System.EventHandler(this.переглядПроблемToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 569);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem statsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem переглядЗаходiвToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переглядПроблемToolStripMenuItem;
    }
}

