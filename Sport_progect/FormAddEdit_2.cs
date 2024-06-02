using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sport_progect
{
    public partial class FormAddEdit_2 : Form
    {
        public FormAddEdit_2()
        {
            InitializeComponent();
        }

        //Добавить и изменить информацию спортсмена
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text != "ДОБАВИТЬ")
            {
                if (Box_Fname.Text == "" && Box_Lname.Text == "" && Box_Dname.Text == "")
                {
                    MessageBox.Show("Проверте написание ФИО!", "Ошибка!");
                    return;
                }
                else
                {
                    try
                    {
                        BD bd = new BD();
                        int index = dataGridView1.CurrentRow.Index;
                        string kyrs = dataGridView1.Rows[index].Cells[1].Value.ToString();
                        bd.OpenCon();
                        MySqlCommand com = new MySqlCommand("UPDATE `спортсмен` " +
                            "SET `Имя` = '" + Box_Fname + "', `Фамилия` = '" + Box_Lname.Text + "', `Отчесво` = '" + Box_Dname.Text + "', `Отделение` = '" + kyrs + "', `Курс` = '" + Box_kyrs.Text + "' WHERE `спортсмен`.`idСпортсмен` = " + Box_id.Text, bd.getCon());
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
            }
            else
            {
                if (Box_Fname.Text == "" && Box_Lname.Text == "" && Box_Dname.Text == "")
                {
                    MessageBox.Show("Проверте написание ФИО!", "Ошибка!");
                    return;
                }
                else
                {
                    try
                    {
                        BD bd = new BD();
                        bd.OpenCon();
                        int index = dataGridView1.CurrentRow.Index;
                        string kyrs = dataGridView1.Rows[index].Cells[1].Value.ToString();
                        MySqlCommand com = new MySqlCommand("INSERT INTO `спортсмен` (`Имя`, `Фамилия`, `Отчесво`, `Отделение`, `Курс`) VALUES ('" + Box_Fname.Text + "', '" + Box_Lname.Text + "', '" + Box_Dname.Text + "', '" + kyrs + "', '" + Box_kyrs.Text + "')", bd.getCon());
                        /*MessageBox.Show(com.CommandText.ToString());*/
                        com.ExecuteNonQuery();
                        bd.CloseCon();
                        this.Hide();
                        MessageBox.Show("Запись успешно добавлена");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        this.Hide();
                    }
                }
            }
        }

        //Обновить список отделения
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BD bd = new BD();
            bd.OpenCon();
            MySqlDataAdapter adap = new MySqlDataAdapter("SELECT * FROM `отделения`", bd.getCon());
            DataTable DATA = new DataTable();
            adap.Fill(DATA);
            dataGridView1.DataSource = DATA;
            bd.CloseCon();
        }

        //Добавить отделение
        private void button4_Click(object sender, EventArgs e)
        {
            Add_new form = new Add_new();
            form.DB.Text = "отделения";
            form.Show();
        }

        //Удаление информации в отделения
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
                    MySqlCommand com = new MySqlCommand("DELETE FROM `отделения` WHERE `отделения`.`idОтделения` = '" + id + "'", bd.getCon());
                    com.ExecuteNonQuery();
                    bd.CloseCon();
                    MessageBox.Show("Элемент удалён!");
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Сброс всех значений
        private void button2_Click(object sender, EventArgs e)
        {
            Box_Fname.Text = "";
            Box_Lname.Text = "";
            Box_Dname.Text = "";
            Box_kyrs.Text = "";
        }
    }
}