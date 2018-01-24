using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Experts_Economist
{
    public partial class Golovna : Form
    {
       
        public int id; //переменная для хранения id експерта

        public Golovna(int usID) //класс формы, input - id експерта
        {
            this.id = usID;
            InitializeComponent();
            label1.Text += " "+ this.id;
        }

        //событие нажатия на кнопку Розрахунок - запуск формы Rozrah в главном окне(Mdi)
        private void RozrahTSM_Click(object sender, EventArgs e)
        {
            Rozrah RozrahMDIChild = new Rozrah();
            RozrahMDIChild.MdiParent = this;
            RozrahMDIChild.Show();
        }
        //событие нажатия на кнопку Перегляд результатів - запуск формы Result в главном окне(Mdi)
        private void ResultTSM_Click(object sender, EventArgs e)
        {
            Result ResultMDIChild = new Result();
            ResultMDIChild.MdiParent = this;
            ResultMDIChild.Show();
        }
        //событие нажатия на кнопку Редактор формул - запуск формы Redakt в главном окне(Mdi)
        private void RedaktTSM_Click(object sender, EventArgs e)
        {
            Redakt RedaktMDIChild = new Redakt();
            RedaktMDIChild.MdiParent = this;
            RedaktMDIChild.Show();
        }
    }
}
