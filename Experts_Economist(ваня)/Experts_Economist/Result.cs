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
    public partial class Result : Form
    {  //используем библиотеки работы с БД и формулами 
        DBManager db = new DBManager();
        Calculations calc = new Calculations();

        public Result()
        {
            InitializeComponent();
            //функция для забивания данных в таблицу с формулами и параметрами, их значениями и номера расчётов
            get_values();
        }

        //функция для забивания данных в таблицу с формулами и параметрами, их значениями и номера расчётов
        private void get_values()
        {
            calc_numbCB.Items.Clear();//очищаем список расчётов
            //создаём переменную для хранения списка номеров расчётов и забиваем её в список расчётов
            var obj0 = db.GetRows("calculations_result group by calculation_number", "calculation_number", "");
            for (int i = 0; i < obj0.Count; i++)
                calc_numbCB.Items.Add(Convert.ToInt32(obj0[i][0]).ToString());
            if (calc_numbCB.Items.Count > 0)
                calc_numbCB.SelectedIndex = 0;
            //функция заполнения таблицы формулами и их параметрами 
            get_grid();
        }

        //функция заполнения таблицы формулами и их параметрами 
        private void get_grid()
        {
            try
            {
                DGV.Rows.Clear();//очищаем таблицу 

                string idc = calc_numbCB.SelectedItem.ToString();//переменная для хранения id расчёта 
                var iof_res = db.GetRows("calculations_result", "id_of_formula,result", "calculation_number = " + idc);//переменная для хранения id формулы и результата
                var nof = new List<List<Object>>();//список имён формулы
                var nop = new List<List<Object>>();//список имён параметра
                var pv = new List<List<Object>>();//список значений параметра
                //в циклах находим расчитанные формулы и их значение, потом находим параметры связанные с этими формулами и записываем их имена и значения 
                for (int i = 0; i < iof_res.Count; i++)
                {
                    nof = db.GetRows("formulas", "name_of_formula", "id_of_formula = " + iof_res[i][0].ToString());
                    //добавляем в таблицу формулу и значения и подписываем, в скрытой ячейке указываем что это формула 
                    this.DGV.Rows.Add("Формула " + nof[0][0].ToString(), iof_res[i][1].ToString(), iof_res[i][0].ToString(), "id_of_formula");

                    var iop = db.GetRows("formula_compound", "id_of_parameter", "id_of_formula = " + iof_res[i][0].ToString());
                    for (int j = 0; j < iop.Count; j++)
                    {
                        pv = db.GetRows("parameters_value", "parameter_value", "calculation_number = " + idc + " AND id_of_parameter = " + iop[j][0].ToString());

                        nop = db.GetRows("formula_parameters", "name_of_parameter", "id_of_parameter = " + iop[j][0].ToString());
                        //добавляем в таблицу параметр и значения и подписываем, в скрытой ячейке указываем что это параметр
                        this.DGV.Rows.Add("Параметр " + nop[0][0].ToString(), pv[0][0].ToString(), iop[j][0].ToString(), "id_of_parameter");
                    }
                }
                //для всех формул выделяем жирным шрифтом
                for (int i = 0; i < DGV.Rows.Count; i++)
                {
                    if (DGV.Rows[i].Cells[3].Value.ToString() == "id_of_formula")
                    {
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.Font = new Font(DGV.Font, FontStyle.Bold);
                        DGV.Rows[i].DefaultCellStyle = style;
                    }
                }
            }//ex.ToString()
            catch (Exception ex)
            { }
        }


        //вызов формы для работы с графиками при нажатии на соответствующую кнопку 
        private void grafik_Click(object sender, EventArgs e)
        {

        }

        //проверка ввода номера серии расчётов
        private void calc_numbCB_KeyPress(object sender, KeyPressEventArgs e)
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

        //при выборе номера расчётов обновляет таблицу 
        private void calc_numbCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            get_grid();
        }

        //приверка правильности ввода в 2 колонке таблицы, событие открытия режима редактироваия колонки вызывает событие нажатия на клавиши Column2_KeyPress
        private void DGV_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column2_KeyPress);

            if (DGV.CurrentCell.ColumnIndex == 1) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column2_KeyPress);
                }
            }
        }
        //событие нажатия клавиши в окне серии расчётов, проверяем на правильность, разрешаем вводить только цифры и только 1 точку

        private void Column2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (!DGV.Rows[DGV.CurrentCell.RowIndex].Cells[3].Value.ToString().Equals("id_of_formula")))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1) && (DGV.Rows[DGV.CurrentCell.RowIndex].Cells[3].Value.ToString() != "id_of_formula"))
            {
                e.Handled = true;
            }
        }

        //событие отжатия клавиши, проверяем что пользователь нажал кнопку delete на строке содержащей формулу и если это так то удаляем расчитанные значения формулы и соотвествующие расчитанные параметры
        private void DGV_KeyUp(object sender, KeyEventArgs e)
        {//проверка
            if (e.KeyCode == Keys.Delete && DGV.Rows[DGV.CurrentCell.RowIndex].Cells[3].Value.ToString() == "id_of_formula")
            {//переменная для хранения id формулы и номера расчёта
                string idf = DGV.Rows[DGV.CurrentCell.RowIndex].Cells[2].Value.ToString();
                string idc = calc_numbCB.SelectedItem.ToString();
                //переменные для удаления, первая - поля, вторая - значения
                string[] fields2 = { "calculation_number ", "id_of_formula" };
                string[] values2 = { idc, idf };
                //удаляем из БД значения по формуле 
                db.DeleteFromDB("calculations_result", fields2, values2);

                //id параметра 
                var iop = db.GetRows("formula_compound", "id_of_parameter", "id_of_formula = " + idf);
                for (int i = 0; i < iop.Count; i++) //в цикле удаляем значения параметров по формуле
                {
                    string[] fields2_1 = { "calculation_number ", "id_of_parameter" };
                    string[] values2_1 = { idc, iop[i][0].ToString() };
                    db.DeleteFromDB("parameters_value", fields2_1, values2_1);
                }
                //обновляем таблицу и список расчётов
                get_values();
            }
        }

        //при изменении значений параметров пересчитываем формулу и обновляем БД
        private void DGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {//выполняем в другом потоке асинхронно
            this.BeginInvoke(new MethodInvoker(() =>
            {//переменная для хранения id параметра
                string idc = DGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (DGV.Rows[e.RowIndex].Cells[3].Value.ToString() == "id_of_parameter")//проверяем что меняем параметр 
                {//переменные для хранения полей изменения и параметров
                    string[] fields2 = { "id_of_parameter", "parameter_value" };
                    string[] values2 = { idc + " AND calculation_number = " + calc_numbCB.Text, DGV.Rows[e.RowIndex].Cells[1].Value.ToString() };
                    db.UpdateRecord("parameters_value", fields2, values2);//обновляем значения параметров
                    //считваем текущий индекс и идём к началу списка пока не найдём строку, в которой записана формула
                    for (int i = e.RowIndex; i >= 0; i--)
                    {//переменная для хранения id формулы
                        string idf = DGV.Rows[i].Cells[2].Value.ToString();
                        if (DGV.Rows[i].Cells[3].Value.ToString() == "id_of_formula")//нашли формулу
                        {
                            switch (Convert.ToInt32(idf))
                            {//свитч для подсчёта значения формулы, общий вид - записываем значения параметров в переменные, передаём их в функции класса Calculations, пересчитываем, обновляем БД
                                case 1:
                                    {
                                        double a = Convert.ToDouble(DGV.Rows[i + 1].Cells[1].Value);
                                        double b = Convert.ToDouble(DGV.Rows[i + 2].Cells[1].Value);
                                        double c = Convert.ToDouble(DGV.Rows[i + 3].Cells[1].Value);
                                        string[] fields2_1 = { "id_of_formula", "result" };
                                        string[] values2_1 = { idf + " AND calculation_number = " + calc_numbCB.Text, calc.Q_t(a, b, c).ToString() };
                                        db.UpdateRecord("calculations_result", fields2_1, values2_1);
                                        break;
                                    }
                                case 2: break;
                                case 3: break;
                                case 4: break;
                                case 5: break;
                                case 6: break;
                                case 7: break;
                                case 8:
                                    {
                                        break;
                                    }
                                case 9:
                                    {
                                        double a = Convert.ToDouble(DGV.Rows[i + 1].Cells[1].Value);
                                        double b = Convert.ToDouble(DGV.Rows[i + 2].Cells[1].Value);
                                        double c = Convert.ToDouble(DGV.Rows[i + 3].Cells[1].Value);
                                        double d = Convert.ToDouble(DGV.Rows[i + 4].Cells[1].Value);
                                        string[] fields2_1 = { "id_of_formula", "result" };
                                        string[] values2_1 = { idf + " AND calculation_number = " + calc_numbCB.Text, calc.Kp(a, b, c, d).ToString() };
                                        db.UpdateRecord("calculations_result", fields2_1, values2_1);
                                        break;
                                    }
                                case 10:
                                    {
                                        double a = Convert.ToDouble(DGV.Rows[i + 1].Cells[1].Value);
                                        double b = Convert.ToDouble(DGV.Rows[i + 2].Cells[1].Value);
                                        double c = Convert.ToDouble(DGV.Rows[i + 3].Cells[1].Value);
                                        string[] fields2_1 = { "id_of_formula", "result" };
                                        string[] values2_1 = { idf + " AND calculation_number = " + calc_numbCB.Text, calc.ChGPp(a, b, c).ToString() };
                                        db.UpdateRecord("calculations_result", fields2_1, values2_1);
                                        break;
                                    }
                            }
                            break;
                        }
                    }
                }
                //обновляем Таблицу
                get_grid();
            }));
        }

    }
}
