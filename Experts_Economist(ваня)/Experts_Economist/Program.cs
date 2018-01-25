using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Experts_Economist
{
    static class Program
    {

        static int userId;//переменная для хранения id пользователя, передается на главную вкладку при удачном входе
        static UserLoginForm a;// переменная для первой формы - формы входа
        static Golovna b;// переменная для формы которая будет вызываться при удачном входе - главной формы

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.SetCompatibleTextRenderingDefault(false);

            a = new UserLoginForm();// инициализация формы входа
            a.LoginHandler += Callback; 

            Application.EnableVisualStyles();

            Application.Run(a); 
            b = new Golovna(userId);
            Application.Run(b);
        }


        static void Callback(int id)
        {
            userId = id;
        }

    }
}
