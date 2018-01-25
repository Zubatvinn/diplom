namespace Experts_Economist
{
    partial class Result
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
            this.grafik = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_of_calcL = new System.Windows.Forms.Label();
            this.calc_numbCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // grafik
            // 
            this.grafik.Location = new System.Drawing.Point(600, 216);
            this.grafik.Name = "grafik";
            this.grafik.Size = new System.Drawing.Size(105, 40);
            this.grafik.TabIndex = 0;
            this.grafik.Text = "Показати на графіках";
            this.grafik.UseVisualStyleBackColor = true;
            this.grafik.Click += new System.EventHandler(this.grafik_Click);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToResizeColumns = false;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DGV.Location = new System.Drawing.Point(12, 52);
            this.DGV.MultiSelect = false;
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(384, 338);
            this.DGV.TabIndex = 1;
            this.DGV.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellEndEdit);
            this.DGV.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DGV_EditingControlShowing);
            this.DGV.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DGV_KeyUp);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 100.369F;
            this.Column1.HeaderText = "Формула";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 99.631F;
            this.Column2.HeaderText = "Значення";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "id";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "name";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // number_of_calcL
            // 
            this.number_of_calcL.AutoSize = true;
            this.number_of_calcL.Location = new System.Drawing.Point(12, 9);
            this.number_of_calcL.Name = "number_of_calcL";
            this.number_of_calcL.Size = new System.Drawing.Size(111, 13);
            this.number_of_calcL.TabIndex = 16;
            this.number_of_calcL.Text = "Серія розрахунків №";
            // 
            // calc_numbCB
            // 
            this.calc_numbCB.FormattingEnabled = true;
            this.calc_numbCB.Location = new System.Drawing.Point(12, 25);
            this.calc_numbCB.Name = "calc_numbCB";
            this.calc_numbCB.Size = new System.Drawing.Size(121, 21);
            this.calc_numbCB.TabIndex = 17;
            this.calc_numbCB.SelectedIndexChanged += new System.EventHandler(this.calc_numbCB_SelectedIndexChanged);
            this.calc_numbCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calc_numbCB_KeyPress);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 510);
            this.Controls.Add(this.calc_numbCB);
            this.Controls.Add(this.number_of_calcL);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.grafik);
            this.Name = "Result";
            this.Text = "Перегляд результатів";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button grafik;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Label number_of_calcL;
        private System.Windows.Forms.ComboBox calc_numbCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}