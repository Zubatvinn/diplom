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

        public Golovna(int expertId) //класс формы, input - id експерта
        {
            id = expertId;
            InitializeComponent();
        }
        Rozrah RozrahMDIChild;
        Result ResultMDIChild;
        Redakt RedaktMDIChild;

        private void Golovna_Load(object sender, EventArgs e)
        {
            //UserLogin fu = new UserLogin();
            //if (fu.ShowDialog() == DialogResult.OK)
            //{
            //    this.id = fu.userId;
            label1.Text += " " + this.id;
            //}
            //else
            //    Close();
            if (id == 0)
                RedaktTSM.Visible = true;
        }


        //событие нажатия на кнопку Розрахунок - запуск формы Rozrah в главном окне(Mdi)
        private void RozrahTSM_Click(object sender, EventArgs e)
        {
            if (RozrahMDIChild == null)
            {
                RozrahMDIChild = new Rozrah();
                RozrahMDIChild.id_of_exp = id;
                RozrahMDIChild.MdiParent = this;
                RozrahMDIChild.Show();
                RozrahMDIChild.FormClosed += RozrahMDIChild_FormClosed;
            }
            RozrahMDIChild.BringToFront();
        }

        private void RozrahMDIChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            RozrahMDIChild.Dispose();
            RozrahMDIChild = null;
        }

        //событие нажатия на кнопку Перегляд результатів - запуск формы Result в главном окне(Mdi)
        private void ResultTSM_Click(object sender, EventArgs e)
        {
            if (ResultMDIChild == null)
            {
                ResultMDIChild = new Result();
                ResultMDIChild.id_of_exp = id;
                ResultMDIChild.MdiParent = this;
                ResultMDIChild.Show();
                ResultMDIChild.FormClosed += ResultMDIChild_FormClosed;
            }
            ResultMDIChild.BringToFront();
        }

        private void ResultMDIChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ResultMDIChild.Dispose();
            ResultMDIChild = null;
        }

        //событие нажатия на кнопку Редактор формул - запуск формы Redakt в главном окне(Mdi)
        private void RedaktTSM_Click(object sender, EventArgs e)
        {
            if (RedaktMDIChild == null)
            {
                RedaktMDIChild = new Redakt();
                RedaktMDIChild.id_of_exp = id;
                RedaktMDIChild.MdiParent = this;
                RedaktMDIChild.Show();
                RedaktMDIChild.FormClosed += RedaktMDIChild_FormClosed;
            }
            RedaktMDIChild.BringToFront();
        }

        private void RedaktMDIChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            RedaktMDIChild.Dispose();
            RedaktMDIChild = null;
        }

    }
}
