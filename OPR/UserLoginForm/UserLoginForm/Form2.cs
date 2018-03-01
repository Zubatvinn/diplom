using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserLoginForm
{
    public partial class Form2 : Form
    {
        public int id;
        public Form2(int usID)
        {
            this.id = usID;
            InitializeComponent();
            this.textBox1.Text = this.id.ToString();
            label1.Text = this.id.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Refresh();
            label1.Text = this.id.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
