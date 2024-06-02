using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport_progect
{
    public partial class FormAddEdit_1 : Form
    {
        public FormAddEdit_1()
        {
            InitializeComponent();
        }

        //Добавить изменить информацию мероприятия
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            if (button1.Text != "ДОБАВИТЬ")
            {
                
                try
                {
                    if (Box_name.Text == "")
                    {
                        MessageBox.Show("Введите название мероприятия!", "Ошибка!");
                        return;
                    }
                    BD bd = new BD();
                    int index = dataGridView1.CurrentRow.Index;
                    string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    bd.OpenCon();
                    MySqlCommand com = new MySqlCommand("UPDATE `мероприятие` SET `Название_мероприятия` = '" + Box_name.Text + "', " +
                        "`Описание` = '" + BoxAbout.Text + "', `idВид спорта` = '" + id.ToString() + "',`Дата проведения` = '" + dateTime_DO.Value.ToString("yyyy.MM.dd") + "', " +
                        "`Дата окончания` = '" + dateTime_ELSE.Value.ToString("yyyy.MM.dd") + "' WHERE `мероприятие`.`idМероприятие` = " + Box_id.Text, bd.getCon());
                    /*MessageBox.Show(com.CommandText.ToString());*/
                    com.ExecuteNonQuery();
                    bd.CloseCon();
                    MessageBox.Show("Запись успешно изменина");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    this.Hide();
                }
            }
            else
            {
                try
                {
                    if (Box_name.Text == "")
                    {
                        MessageBox.Show("Введите название мероприятия!", "Ошибка!");
                        return;
                    }
                    else
                    {
                        BD bd = new BD();
                        bd.OpenCon();
                        int index = dataGridView1.CurrentRow.Index;
                        string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                        MySqlCommand com = new MySqlCommand("INSERT INTO `мероприятие` (`Название_мероприятия`, `Описание`, `idВид спорта`, `Дата проведения`, `Дата окончания`) " +
                            "VALUES('" + Box_name.Text.ToString() + "', '" + BoxAbout.Text.ToString() + "', '" + id.ToString() + "', '" + dateTime_DO.Value.ToString("yyyy.MM.dd") + "', '" + dateTime_ELSE.Value.ToString("yyyy.MM.dd") + "')", bd.getCon());
                        /*MessageBox.Show(com.CommandText.ToString());*/
                        com.ExecuteNonQuery();
                        bd.CloseCon();
                        this.Hide();
                        MessageBox.Show("Запись успешно добавлена");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    this.Hide();
                }
            }

        }

        //Сброс всех значений
        private void button2_Click(object sender, EventArgs e)
        {
            Box_name.Text = "";
            dateTime_DO.Value = DateTime.Now;
            dateTime_ELSE.Value = DateTime.Now;
            BoxAbout.Text = "";
        }

        //Добавить информацию вида спорта
        private void button4_Click(object sender, EventArgs e)
        {
            Add_new form = new Add_new();
            form.DB.Text = "вид спорта";
            form.Show();
        }

        //Удолить информациб видов спорта
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удолить запись?", "Внимание!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                try
                {
                    BD bd = new BD();
                    bd.OpenCon();
                    int index = dataGridView1.CurrentRow.Index;
                    string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    MySqlCommand com = new MySqlCommand("DELETE FROM `вид спорта` WHERE `вид спорта`.`idВид спорта` = '" + id + "'", bd.getCon());
                    com.ExecuteNonQuery();
                    bd.CloseCon();
                    MessageBox.Show("Элемент удалён!");
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Обновить список видов спорта
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                BD bd = new BD();
                bd.OpenCon();
                MySqlDataAdapter adap = new MySqlDataAdapter("SELECT * FROM `вид спорта`", bd.getCon());
                DataTable DATA = new DataTable();
                adap.Fill(DATA);
                dataGridView1.DataSource = DATA;
                bd.CloseCon();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
