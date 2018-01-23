namespace oprForm
{
	partial class PlannedEventsForm
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
            this.eventsLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.eventListGrid = new System.Windows.Forms.DataGridView();
            this.Resource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descTB = new System.Windows.Forms.TextBox();
            this.evNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // eventsLB
            // 
            this.eventsLB.FormattingEnabled = true;
            this.eventsLB.ItemHeight = 20;
            this.eventsLB.Location = new System.Drawing.Point(18, 55);
            this.eventsLB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eventsLB.Name = "eventsLB";
            this.eventsLB.Size = new System.Drawing.Size(164, 404);
            this.eventsLB.TabIndex = 0;
            this.eventsLB.SelectedIndexChanged += new System.EventHandler(this.eventsLB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Шаблони заходiв";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(24, 471);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(160, 35);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // eventListGrid
            // 
            this.eventListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Resource,
            this.Description,
            this.Value});
            this.eventListGrid.Location = new System.Drawing.Point(194, 55);
            this.eventListGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eventListGrid.Name = "eventListGrid";
            this.eventListGrid.Size = new System.Drawing.Size(452, 406);
            this.eventListGrid.TabIndex = 4;
            this.eventListGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.commitValue);
            // 
            // Resource
            // 
            this.Resource.HeaderText = "Resource";
            this.Resource.Name = "Resource";
            this.Resource.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            // 
            // descTB
            // 
            this.descTB.Location = new System.Drawing.Point(352, 471);
            this.descTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descTB.Name = "descTB";
            this.descTB.Size = new System.Drawing.Size(290, 26);
            this.descTB.TabIndex = 5;
            this.descTB.Text = "Description";
            // 
            // evNameTB
            // 
            this.evNameTB.Location = new System.Drawing.Point(194, 471);
            this.evNameTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.evNameTB.Name = "evNameTB";
            this.evNameTB.Size = new System.Drawing.Size(148, 26);
            this.evNameTB.TabIndex = 6;
            this.evNameTB.Text = "Event Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Список ресурсiв";
            // 
            // PlannedEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 525);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.evNameTB);
            this.Controls.Add(this.descTB);
            this.Controls.Add(this.eventListGrid);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventsLB);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PlannedEventsForm";
            this.Text = "PlannedEventsForm";
            this.Load += new System.EventHandler(this.PlannedEventsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventListGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox eventsLB;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button addBtn;
		private System.Windows.Forms.DataGridView eventListGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn Resource;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;
		private System.Windows.Forms.DataGridViewTextBoxColumn Value;
		private System.Windows.Forms.TextBox descTB;
		private System.Windows.Forms.TextBox evNameTB;
		private System.Windows.Forms.Label label2;
	}
}