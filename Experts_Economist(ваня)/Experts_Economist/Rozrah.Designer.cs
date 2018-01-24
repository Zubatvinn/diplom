namespace Experts_Economist
{
    partial class Rozrah
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.formulasLB = new System.Windows.Forms.ListBox();
            this.formulasDGV = new System.Windows.Forms.DataGridView();
            this.Param_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param_measure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Save_values = new System.Windows.Forms.Button();
            this.formulas_idLB = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.rozrah_numbTB = new System.Windows.Forms.TextBox();
            this.number_of_calcL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.formulasDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // formulasLB
            // 
            this.formulasLB.FormattingEnabled = true;
            this.formulasLB.Location = new System.Drawing.Point(12, 28);
            this.formulasLB.Name = "formulasLB";
            this.formulasLB.Size = new System.Drawing.Size(202, 225);
            this.formulasLB.TabIndex = 1;
            this.formulasLB.SelectedIndexChanged += new System.EventHandler(this.formulasLB_SelectedIndexChanged);
            this.formulasLB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formulasLB_MouseMove);
            // 
            // formulasDGV
            // 
            this.formulasDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.formulasDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Param_name,
            this.Param_value,
            this.Param_measure});
            this.formulasDGV.Location = new System.Drawing.Point(372, 25);
            this.formulasDGV.Name = "formulasDGV";
            this.formulasDGV.Size = new System.Drawing.Size(344, 238);
            this.formulasDGV.TabIndex = 2;
            this.formulasDGV.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.formulasDGV_EditingControlShowing);
            // 
            // Param_name
            // 
            this.Param_name.HeaderText = "Назва парамерту";
            this.Param_name.Name = "Param_name";
            this.Param_name.ReadOnly = true;
            // 
            // Param_value
            // 
            this.Param_value.HeaderText = "Значення";
            this.Param_value.Name = "Param_value";
            // 
            // Param_measure
            // 
            this.Param_measure.HeaderText = "Одиниця вимірювання";
            this.Param_measure.Name = "Param_measure";
            this.Param_measure.ReadOnly = true;
            // 
            // Save_values
            // 
            this.Save_values.Location = new System.Drawing.Point(372, 269);
            this.Save_values.Name = "Save_values";
            this.Save_values.Size = new System.Drawing.Size(94, 35);
            this.Save_values.TabIndex = 3;
            this.Save_values.Text = "Порахувати та зберегти";
            this.Save_values.UseVisualStyleBackColor = true;
            this.Save_values.Click += new System.EventHandler(this.Save_values_Click);
            // 
            // formulas_idLB
            // 
            this.formulas_idLB.FormattingEnabled = true;
            this.formulas_idLB.Location = new System.Drawing.Point(220, 28);
            this.formulas_idLB.Name = "formulas_idLB";
            this.formulas_idLB.Size = new System.Drawing.Size(27, 225);
            this.formulas_idLB.TabIndex = 10;
            this.formulas_idLB.Visible = false;
            // 
            // rozrah_numbTB
            // 
            this.rozrah_numbTB.Location = new System.Drawing.Point(266, 25);
            this.rozrah_numbTB.Name = "rozrah_numbTB";
            this.rozrah_numbTB.Size = new System.Drawing.Size(100, 20);
            this.rozrah_numbTB.TabIndex = 13;
            this.rozrah_numbTB.TextChanged += new System.EventHandler(this.rozrah_numbTB_TextChanged);
            this.rozrah_numbTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rozrah_numbTB_KeyPress);
            // 
            // number_of_calcL
            // 
            this.number_of_calcL.AutoSize = true;
            this.number_of_calcL.Location = new System.Drawing.Point(263, 9);
            this.number_of_calcL.Name = "number_of_calcL";
            this.number_of_calcL.Size = new System.Drawing.Size(111, 13);
            this.number_of_calcL.TabIndex = 14;
            this.number_of_calcL.Text = "Серія розрахунків №";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Список формул";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Список параметрів даної формули";
            // 
            // Rozrah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 328);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.number_of_calcL);
            this.Controls.Add(this.rozrah_numbTB);
            this.Controls.Add(this.Save_values);
            this.Controls.Add(this.formulasDGV);
            this.Controls.Add(this.formulasLB);
            this.Controls.Add(this.formulas_idLB);
            this.Name = "Rozrah";
            this.Text = "Економіст_розрахунки";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.formulasDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox formulasLB;
        private System.Windows.Forms.DataGridView formulasDGV;
        private System.Windows.Forms.Button Save_values;
        private System.Windows.Forms.DataGridViewTextBoxColumn Param_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Param_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Param_measure;
        private System.Windows.Forms.ListBox formulas_idLB;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox rozrah_numbTB;
        private System.Windows.Forms.Label number_of_calcL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

