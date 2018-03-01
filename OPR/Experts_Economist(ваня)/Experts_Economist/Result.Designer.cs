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
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_of_formula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_of_calcL = new System.Windows.Forms.Label();
            this.calc_numbCB = new System.Windows.Forms.ComboBox();
            this.desc_of_seriesTB = new System.Windows.Forms.RichTextBox();
            this.name_of_seriesTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.change_desc = new System.Windows.Forms.Button();
            this.issueL = new System.Windows.Forms.Label();
            this.issueTB = new System.Windows.Forms.ComboBox();
            this.Panel_redakt = new System.Windows.Forms.Button();
            this.Delete_desc = new System.Windows.Forms.Button();
            this.Mass_delete = new System.Windows.Forms.Button();
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
            this.Column4,
            this.index,
            this.measure,
            this.id_of_formula});
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
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 99.631F;
            this.Column2.HeaderText = "Значення";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // index
            // 
            this.index.HeaderText = "index";
            this.index.Name = "index";
            this.index.Visible = false;
            // 
            // measure
            // 
            this.measure.HeaderText = "Одиниці вимірювання";
            this.measure.Name = "measure";
            this.measure.ReadOnly = true;
            this.measure.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // id_of_formula
            // 
            this.id_of_formula.HeaderText = "idf";
            this.id_of_formula.Name = "id_of_formula";
            this.id_of_formula.Visible = false;
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
            this.calc_numbCB.TextChanged += new System.EventHandler(this.calc_numbCB_TextChanged);
            this.calc_numbCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calc_numbCB_KeyPress);
            // 
            // desc_of_seriesTB
            // 
            this.desc_of_seriesTB.Location = new System.Drawing.Point(415, 71);
            this.desc_of_seriesTB.Name = "desc_of_seriesTB";
            this.desc_of_seriesTB.ReadOnly = true;
            this.desc_of_seriesTB.Size = new System.Drawing.Size(253, 78);
            this.desc_of_seriesTB.TabIndex = 26;
            this.desc_of_seriesTB.Text = "";
            // 
            // name_of_seriesTB
            // 
            this.name_of_seriesTB.Location = new System.Drawing.Point(150, 25);
            this.name_of_seriesTB.Name = "name_of_seriesTB";
            this.name_of_seriesTB.ReadOnly = true;
            this.name_of_seriesTB.Size = new System.Drawing.Size(141, 20);
            this.name_of_seriesTB.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Опис серії";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Назва серії";
            // 
            // change_desc
            // 
            this.change_desc.Location = new System.Drawing.Point(415, 155);
            this.change_desc.Name = "change_desc";
            this.change_desc.Size = new System.Drawing.Size(105, 40);
            this.change_desc.TabIndex = 27;
            this.change_desc.Text = "Змінити назву та опис";
            this.change_desc.UseVisualStyleBackColor = true;
            this.change_desc.Click += new System.EventHandler(this.button1_Click);
            // 
            // issueL
            // 
            this.issueL.AutoSize = true;
            this.issueL.Location = new System.Drawing.Point(294, 9);
            this.issueL.Name = "issueL";
            this.issueL.Size = new System.Drawing.Size(59, 13);
            this.issueL.TabIndex = 29;
            this.issueL.Text = "Проблема";
            // 
            // issueTB
            // 
            this.issueTB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.issueTB.Enabled = false;
            this.issueTB.FormattingEnabled = true;
            this.issueTB.Location = new System.Drawing.Point(297, 24);
            this.issueTB.Name = "issueTB";
            this.issueTB.Size = new System.Drawing.Size(371, 21);
            this.issueTB.TabIndex = 28;
            // 
            // Panel_redakt
            // 
            this.Panel_redakt.Location = new System.Drawing.Point(12, 396);
            this.Panel_redakt.Name = "Panel_redakt";
            this.Panel_redakt.Size = new System.Drawing.Size(111, 38);
            this.Panel_redakt.TabIndex = 30;
            this.Panel_redakt.Text = "Редактування вкл/викл";
            this.Panel_redakt.UseVisualStyleBackColor = true;
            this.Panel_redakt.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Delete_desc
            // 
            this.Delete_desc.Location = new System.Drawing.Point(526, 155);
            this.Delete_desc.Name = "Delete_desc";
            this.Delete_desc.Size = new System.Drawing.Size(89, 40);
            this.Delete_desc.TabIndex = 31;
            this.Delete_desc.Text = "Видалити опис серії";
            this.Delete_desc.UseVisualStyleBackColor = true;
            this.Delete_desc.Click += new System.EventHandler(this.Delete_desc_Click);
            // 
            // Mass_delete
            // 
            this.Mass_delete.Location = new System.Drawing.Point(129, 396);
            this.Mass_delete.Name = "Mass_delete";
            this.Mass_delete.Size = new System.Drawing.Size(83, 38);
            this.Mass_delete.TabIndex = 32;
            this.Mass_delete.Text = "Видалити всю серію";
            this.Mass_delete.UseVisualStyleBackColor = true;
            this.Mass_delete.Click += new System.EventHandler(this.Mass_delete_Click);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 510);
            this.Controls.Add(this.Mass_delete);
            this.Controls.Add(this.Delete_desc);
            this.Controls.Add(this.Panel_redakt);
            this.Controls.Add(this.issueL);
            this.Controls.Add(this.issueTB);
            this.Controls.Add(this.change_desc);
            this.Controls.Add(this.desc_of_seriesTB);
            this.Controls.Add(this.name_of_seriesTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.RichTextBox desc_of_seriesTB;
        private System.Windows.Forms.TextBox name_of_seriesTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button change_desc;
        private System.Windows.Forms.Label issueL;
        private System.Windows.Forms.ComboBox issueTB;
        private System.Windows.Forms.Button Panel_redakt;
        private System.Windows.Forms.Button Delete_desc;
        private System.Windows.Forms.Button Mass_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn measure;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_of_formula;
    }
}