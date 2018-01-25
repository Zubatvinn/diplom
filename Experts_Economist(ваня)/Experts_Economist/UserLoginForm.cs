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
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }


        DBManager db = new DBManager();


        public delegate void Login(int id);
        public event Login LoginHandler;

        private void loginBtn_Click(object sender, EventArgs e)
        {

            string login = "'" + loginTB.Text + "'";
            string pass = "'" + passTB.Text + "'";

            var user = db.GetRows("user", "*", "user_name=" + login +
                " AND password=" + pass);

            if (user.Count > 0)
            {
                MessageBox.Show("Вхід. Id експерту " + user[0][2].ToString());
                LoginHandler(Int32.Parse(user[0][2].ToString()));
                this.Close();
            }
            else
            {
                MessageBox.Show("Помилка, перевірте правильність вводу");
            }
        }
    }
}
