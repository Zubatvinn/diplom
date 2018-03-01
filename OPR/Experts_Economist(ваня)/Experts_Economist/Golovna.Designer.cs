namespace Experts_Economist
{
    partial class Golovna
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
            this.RozrahTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.ResultTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.RedaktTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RozrahTSM,
            this.ResultTSM,
            this.RedaktTSM});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(906, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // RozrahTSM
            // 
            this.RozrahTSM.Name = "RozrahTSM";
            this.RozrahTSM.Size = new System.Drawing.Size(82, 20);
            this.RozrahTSM.Text = "Розрахунок";
            this.RozrahTSM.Click += new System.EventHandler(this.RozrahTSM_Click);
            // 
            // ResultTSM
            // 
            this.ResultTSM.Name = "ResultTSM";
            this.ResultTSM.Size = new System.Drawing.Size(136, 20);
            this.ResultTSM.Text = "Перегляд результатів";
            this.ResultTSM.Click += new System.EventHandler(this.ResultTSM_Click);
            // 
            // RedaktTSM
            // 
            this.RedaktTSM.Name = "RedaktTSM";
            this.RedaktTSM.Size = new System.Drawing.Size(117, 20);
            this.RedaktTSM.Text = "Редактор формул";
            this.RedaktTSM.Visible = false;
            this.RedaktTSM.Click += new System.EventHandler(this.RedaktTSM_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(782, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id експерта";
            // 
            // Golovna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Golovna";
            this.Text = "Головна";
            this.Load += new System.EventHandler(this.Golovna_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem RozrahTSM;
        private System.Windows.Forms.ToolStripMenuItem ResultTSM;
        private System.Windows.Forms.ToolStripMenuItem RedaktTSM;
        private System.Windows.Forms.Label label1;
    }
}