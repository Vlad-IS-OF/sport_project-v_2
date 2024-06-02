using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sport_progect
{
    public partial class Otchet : Form
    {


        public Otchet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*var date_in = dateTimePicker1.Value.ToShortDateString();
            var date_out = dateTimePicker2.Value.ToShortDateString();*/
            var date_in = dateTimePicker1.Value;
            var date_out = dateTimePicker2.Value;
            if (SaveF.ShowDialog() == DialogResult.Cancel)
                return;

            try
            {// получаем выбранный файл
                string filename = SaveF.FileName;
                // сохраняем текст в файл
                string text_out = "Отчёт за период: "+date_in.ToString("dd.MM.yyyy")+" по "+date_out.ToString("dd.MM.yyyy") +"\n\nСписок мероприятий:\n";
                BD bd = new BD();
                bd.OpenCon();
                MySqlDataAdapter adap = new MySqlDataAdapter("SELECT `Название_мероприятия`,`Описание`,(SELECT `Название вида спорта` FROM `вид спорта` WHERE `вид спорта`.`idВид спорта` = `мероприятие`.`idВид спорта`) as 'Вид спорта',`Дата проведения`,`Дата окончания` FROM `мероприятие` WHERE `Дата проведения` BETWEEN '" + date_in.ToString("yyyy.MM.dd") + "' AND '" + date_out.ToString("yyyy.MM.dd") + "'", bd.getCon());
                DataTable DATA = new DataTable();
                adap.Fill(DATA);
                bd.CloseCon();
                for(int i = 0; i < DATA.Rows.Count; i++)
                {
                    text_out += "Название: " + DATA.Rows[i]["Название_мероприятия"] + "; Описание: " + DATA.Rows[i]["Описание"] + "; Вид спорта: "+ DATA.Rows[i]["Вид спорта"] + "; Дата проведения: " + DATA.Rows[i]["Дата проведения"].ToString() + "; Дата окончания: " + DATA.Rows[i]["Дата окончания"].ToString() + "\n";
                }
                text_out += "\n\nОтчёт создан: " + DateTime.Now.ToShortDateString();
                System.IO.File.WriteAllText(filename, text_out);
                MessageBox.Show("Файл сохранен");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
