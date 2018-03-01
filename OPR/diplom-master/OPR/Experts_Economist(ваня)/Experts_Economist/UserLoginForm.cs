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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        public int userId = 0;
        DBManager db = new DBManager();

        private void loginBtn_Click(object sender, EventArgs e)
        {

            string login = "'" + loginTB.Text + "'";
            string pass = "'" + passTB.Text + "'";

            var user = db.GetRows("user", "*", "user_name=" + login +
                " AND password=" + pass);

            if (user.Count > 0)
            {
              //  MessageBox.Show("Вхід. Id експерту " + user[0][2].ToString());
                userId = (Int32.Parse(user[0][2].ToString()));
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Помилка, перевірте правильність вводу");
                DialogResult = DialogResult.None;
            }
        }
    }
}
