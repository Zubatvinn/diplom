using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Collections;

namespace Experts_Economist
{
    public partial class Rozrah : Form
    {
        DBManager db = new DBManager();
        Calculations calc = new Calculations();

        public Rozrah()
        {
            InitializeComponent();

            formulasDGV.AllowUserToAddRows = false;
        }
        //функция для забивания данных в список формул, и номера расчета 
        private void get_values()
        {
            //очищаем списки формул и список id формул
            formulasLB.Items.Clear();
            formulas_idLB.Items.Clear();

            //создаем переменную для записи в неё имён формулы, в цикле записываем имена формулы в список
            var obj = db.GetRows("formulas", "name_of_formula", "");
            string item = "";//вспомогательная переменная для хранения имён
            for (int i = 0; i < obj.Count; i++)
            {
                for (int j = 0; j < obj[i].Count; j++)
                {
                    item += obj[i][j];
                }
                formulasLB.Items.Add(item);
                item = "";
            }


            //создаем переменную для записи в неё id формулы, в цикле записываем id формулы в список
            var obj1 = db.GetRows("formulas", "id_of_formula", "");
            item = "";//вспомогательная переменная для хранения id
            for (int i = 0; i < obj1.Count; i++)
            {
                for (int j = 0; j < obj1[i].Count; j++)
                {
                    item += obj1[i][j];
                }
                formulas_idLB.Items.Add(item);
                item = "";
            }

            //находим максимальный номер расчётов и записываем в ячейку с номером расчетов это чисо + 1, если расчетов нет, ставим номер расчетов 1
            var obj0 = db.GetRows("calculations_result", "Max(calculation_number)", "");
            try
            {
                rozrah_numbTB.Text = (Convert.ToInt32(obj0[0][0]) + 1).ToString();
            }
            catch { rozrah_numbTB.Text = "1"; }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //вызываем при первом открытии формы функцию refresh, которая обновляет элементы со списками, таблицу, номер расчета
            refresh();
        }

        // при событии Изменение индекса в списке формулы, то есть при выборе формулы чисти таблицу справа и заносим в неё список параметров для дальнейшего подсчета
        private void formulasLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.formulasDGV.Rows.Clear();//очищаем таблицу
            formulas_idLB.SelectedIndex = formulasLB.SelectedIndex;//ставим выбранное id в соответствии с выбранной формулой
            string idf = formulas_idLB.SelectedItem.ToString();//переменная для хранения id выбранной формулы
            var obj = db.GetRows("formula_compound", "id_of_parameter", "id_of_formula = " + idf);//переменная для хранения списка параментров привязанных к данной формуле
            var obj1 = new List<List<Object>>();//переменная для хранения имени параметра и единиц измерения
            for (int i = 0; i < obj.Count; i++)//в цикле записываем в таблицу имена параметров,пустое поле для ввода значения параметра и единици измерения
            {
                obj1 = db.GetRows("formula_parameters", "name_of_parameter, measurement_of_parameter", "id_of_parameter = " + obj[i][0].ToString());
                this.formulasDGV.Rows.Add(obj1[0][0].ToString(), "0", obj1[0][1].ToString());
            }
            help = true;//вспомогательная переменная для проверки наличия строки Result с результатом исчисления 
        }

        public bool help = true;//если true - ещё не посчитали, false - посчитали 

        //событие нажатия на кнопку Зберегти значення та порахувати, смотрит id  формулы и считает по определенным образом, потом записывает в БД значения формулы и параметров если формула ещё не была расчитана в данной серии расчётов
        private void Save_values_Click(object sender, EventArgs e)
        {
            if (help == false)// проверяем есть ли строка с результатом, если есть - удаляем и сбрасываем переменную
            {
                formulasDGV.Rows.RemoveAt(formulasDGV.Rows.Count - 1);
                help = true;
            }

            int idf = Convert.ToInt32(formulas_idLB.SelectedItem);//переменная для хранения id формулы
            switch (idf)//свитч для подсчета формул, общий вид - несколько параметров беруться из ячеек таблицы и потом передаются в функцию подсчета класс Calculation, потом добавляем в таблицу строку с результатом 
            {
                case 1:
                    double a = Convert.ToDouble(formulasDGV.Rows[0].Cells[1].Value);
                    double b = Convert.ToDouble(formulasDGV.Rows[1].Cells[1].Value);
                    double c = Convert.ToDouble(formulasDGV.Rows[2].Cells[1].Value);
                    this.formulasDGV.Rows.Add("Result", calc.Q_t(a, b, c), "");
                    break; 
                case 2: break;
                case 3: break;
                case 4: break;
                case 5: break;
                case 6: break;
                case 7: break;
                case 8:
                    break;
                case 9:
                     a = Convert.ToDouble(formulasDGV.Rows[0].Cells[1].Value);
                     b = Convert.ToDouble(formulasDGV.Rows[1].Cells[1].Value);
                     c = Convert.ToDouble(formulasDGV.Rows[2].Cells[1].Value);
                    double d = Convert.ToDouble(formulasDGV.Rows[3].Cells[1].Value);
                    this.formulasDGV.Rows.Add("Result", calc.Kp(a, b, c, d), "");
                    break;
                case 10:
                    a = Convert.ToDouble(formulasDGV.Rows[0].Cells[1].Value);
                    b = Convert.ToDouble(formulasDGV.Rows[1].Cells[1].Value);
                    c = Convert.ToDouble(formulasDGV.Rows[2].Cells[1].Value);
                    this.formulasDGV.Rows.Add("Result", calc.ChGPp(a, b, c), "");
                    break;
            }

            //проверка введён ли корректный номер расчётной серии
            if (rozrah_numbTB.Text == "" && rozrah_numbTB.Text == "0")
            {
                var obj2 = db.GetRows("calculations_result", "Max(calculation_number)", "");
                if (obj2.Count == 1)
                    rozrah_numbTB.Text = "1";
                else
                    rozrah_numbTB.Text = (Convert.ToInt32(obj2[0][0]) + 1).ToString();
            }
            
            //создаём переменные для хранения номера расчётной серии, времени расчёта, id формулы и результата и записываем это всё в БД
            DateTime localDate = DateTime.Now;
            string[] fields3 = { "calculation_number", "date_of_calculation", "id_of_formula", "result" };
            string[] values3 = { rozrah_numbTB.Text, "'" + localDate.ToString("yyyy-MM-dd HH:mm:ss") + "'", idf.ToString(), formulasDGV.Rows[formulasDGV.Rows.Count - 1].Cells[1].Value.ToString() };
            try
            {
                db.InsertToBD("calculations_result", fields3, values3);
            }
            catch (MySqlException eboi)// ловим эксепшн mysql если идёт дупликация ключа
            {
                MessageBox.Show("Ця формула вже була розрахована у данній серії \nЗмінити ці значення ви можете у вкладці 'Перегляд результатів' ");
                return;
            }
            // по аналогии с функцие записи результатов формулы записываем значения параметров в БД
            var obj = db.GetRows("formula_compound", "id_of_parameter", "id_of_formula = " + idf);
            string[] fields2 = { "calculation_number", "id_of_parameter", "parameter_value" };
            string[] values2 = { rozrah_numbTB.Text, "", "" };
            for (int i = 0; i < obj.Count; i++)
            {
                values2[1] = obj[i][0].ToString();
                values2[2] = formulasDGV.Rows[i].Cells[1].Value.ToString();
                db.InsertToBD("parameters_value", fields2, values2);
                //  MessageBox.Show();
            }
            help = false;
        }

        private void refresh()// обновляем элементы формы
        {
            formulasLB.Items.Clear();
            formulas_idLB.Items.Clear();
            get_values();
            formulasLB.SelectedIndex = 0;
        }

        //событие ведения мышки по списку формул, при наведении на формулу показываем подсказку из БД по формуле
        private void formulasLB_MouseMove(object sender, MouseEventArgs e)
        {
            string strTip = "";//переменная для хранения сообщения подсказки 

            //смотрим на каком месте указатель, считываем id формулы и делаем запрос в БД для изъятия подсказки 
            int nIdx = formulasLB.IndexFromPoint(e.Location);
            if ((nIdx >= 0) && (nIdx < formulasLB.Items.Count))
            {
                string idf = formulas_idLB.Items[nIdx].ToString();
                var obj2 = db.GetRows("formulas", "description_of_formula", "id_of_formula = " + idf);
                strTip = obj2[0][0].ToString();
            }
            toolTip1.SetToolTip(formulasLB, strTip);
        }

        //событие нажатия клавиши в окне серии расчётов, проверяем на правильность, разрешаем вводить только цифры и только 1 точку
        private void rozrah_numbTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        //та же самая проверка только для второй колонке таблицы - колонки значений компонентов
        private void Column2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        //событие редактирования ячейки, через него вызываем событие нажатия кнопки для 2 колонки(проверка)
        private void formulasDGV_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column2_KeyPress);
            if (formulasDGV.CurrentCell.ColumnIndex == 1) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column2_KeyPress);
                }
            }
        }

        //при изменении номера расчётов обновляем таблицу и загружаем для первой формулы параметры
        private void rozrah_numbTB_TextChanged(object sender, EventArgs e)
        {
            this.formulasDGV.Rows.Clear();
            string idf = "1";
            if (formulas_idLB.SelectedItem != null)
                idf = formulas_idLB.SelectedItem.ToString();
            var obj = db.GetRows("formula_compound", "id_of_parameter", "id_of_formula = " + idf);
            var obj1 = new List<List<Object>>();
            for (int i = 0; i < obj.Count; i++)
            {
                obj1 = db.GetRows("formula_parameters", "name_of_parameter, measurement_of_parameter", "id_of_parameter = " + obj[i][0].ToString());
                this.formulasDGV.Rows.Add(obj1[0][0].ToString(), "0", obj1[0][1].ToString());
            }
            help = true;
        }
    }
}
