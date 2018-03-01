using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserLoginForm
{
	static class Program
	{
		

        static int userId;
        static UserLoginForm a;
        static Form2 b;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
		static void Main()
		{

            Application.SetCompatibleTextRenderingDefault(false);
            a = new UserLoginForm();
            a.LoginHandler += Callback;
			Application.EnableVisualStyles();
			Application.Run(a);
            b = new Form2(userId);
            Application.Run(b);
           
		}

        static void Callback(int id)
        {
            userId = id;
        }

	}
}
