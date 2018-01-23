namespace oprForm
{
	partial class LookEventsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.eventListGrid = new System.Windows.Forms.DataGridView();
            this.Resource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.eventsLB = new System.Windows.Forms.ListBox();
            this.eventDescLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.approveBtn = new System.Windows.Forms.Button();
            this.disaproveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dmApprLbl = new System.Windows.Forms.Label();
            this.lawyerApprLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Resource List";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // eventListGrid
            // 
            this.eventListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Resource,
            this.Description,
            this.Value});
            this.eventListGrid.Location = new System.Drawing.Point(195, 51);
            this.eventListGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eventListGrid.Name = "eventListGrid";
            this.eventListGrid.Size = new System.Drawing.Size(452, 406);
            this.eventListGrid.TabIndex = 10;
            this.eventListGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventListGrid_CellContentClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Event List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // eventsLB
            // 
            this.eventsLB.FormattingEnabled = true;
            this.eventsLB.ItemHeight = 20;
            this.eventsLB.Location = new System.Drawing.Point(20, 51);
            this.eventsLB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eventsLB.Name = "eventsLB";
            this.eventsLB.Size = new System.Drawing.Size(164, 404);
            this.eventsLB.TabIndex = 8;
            this.eventsLB.SelectedIndexChanged += new System.EventHandler(this.eventsLB_SelectedIndexChanged);
            // 
            // eventDescLabel
            // 
            this.eventDescLabel.AutoSize = true;
            this.eventDescLabel.Location = new System.Drawing.Point(239, 468);
            this.eventDescLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eventDescLabel.Name = "eventDescLabel";
            this.eventDescLabel.Size = new System.Drawing.Size(0, 20);
            this.eventDescLabel.TabIndex = 12;
            this.eventDescLabel.Click += new System.EventHandler(this.eventDescLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 468);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Опис";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // approveBtn
            // 
            this.approveBtn.Location = new System.Drawing.Point(554, 465);
            this.approveBtn.Name = "approveBtn";
            this.approveBtn.Size = new System.Drawing.Size(93, 38);
            this.approveBtn.TabIndex = 14;
            this.approveBtn.Text = "Approve";
            this.approveBtn.UseVisualStyleBackColor = true;
            this.approveBtn.Click += new System.EventHandler(this.approveBtn_Click);
            // 
            // disaproveBtn
            // 
            this.disaproveBtn.Location = new System.Drawing.Point(533, 512);
            this.disaproveBtn.Name = "disaproveBtn";
            this.disaproveBtn.Size = new System.Drawing.Size(114, 38);
            this.disaproveBtn.TabIndex = 15;
            this.disaproveBtn.Text = "Disapprove";
            this.disaproveBtn.UseVisualStyleBackColor = true;
            this.disaproveBtn.Click += new System.EventHandler(this.disaproveBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 502);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Пiдтверждення аналiтика";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 533);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Пiдтверждення юриста";
            // 
            // dmApprLbl
            // 
            this.dmApprLbl.AutoSize = true;
            this.dmApprLbl.Location = new System.Drawing.Point(239, 502);
            this.dmApprLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dmApprLbl.Name = "dmApprLbl";
            this.dmApprLbl.Size = new System.Drawing.Size(0, 20);
            this.dmApprLbl.TabIndex = 18;
            // 
            // lawyerApprLbl
            // 
            this.lawyerApprLbl.AutoSize = true;
            this.lawyerApprLbl.Location = new System.Drawing.Point(239, 533);
            this.lawyerApprLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lawyerApprLbl.Name = "lawyerApprLbl";
            this.lawyerApprLbl.Size = new System.Drawing.Size(0, 20);
            this.lawyerApprLbl.TabIndex = 19;
            // 
            // LookEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 562);
            this.Controls.Add(this.lawyerApprLbl);
            this.Controls.Add(this.dmApprLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.disaproveBtn);
            this.Controls.Add(this.approveBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eventDescLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eventListGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventsLB);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LookEventsForm";
            this.Text = "LookEventsForm";
            this.Load += new System.EventHandler(this.LookEventsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventListGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView eventListGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn Resource;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;
		private System.Windows.Forms.DataGridViewTextBoxColumn Value;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox eventsLB;
		private System.Windows.Forms.Label eventDescLabel;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button approveBtn;
        private System.Windows.Forms.Button disaproveBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dmApprLbl;
        private System.Windows.Forms.Label lawyerApprLbl;
    }
}