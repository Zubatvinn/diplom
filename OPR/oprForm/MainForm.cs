using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oprForm
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void eventToolStripMenuItem_Click(object sender, EventArgs e)
		{
			PlannedEventsForm child = new PlannedEventsForm();
			child.MdiParent = this;
			child.Show();
		}

		private void переглядЗаходiвToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LookEventsForm child = new LookEventsForm();
			child.MdiParent = this;
			child.Show();
		}

        private void переглядПроблемToolStripMenuItem_Click(object sender, EventArgs e)
        {
			var child = new IssuesForm();
			child.MdiParent = this;
			child.Show();
        }
    }
}
