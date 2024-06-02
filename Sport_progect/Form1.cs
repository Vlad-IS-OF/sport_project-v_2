﻿using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Sport_progect
{
    public partial class Form1 : Form
    {
        bool rename = false;

        //Функция быстрого запроса
        private MySqlDataAdapter sport()
        {
            BD bd = new BD();
            bd.OpenCon();
            MySqlDataAdapter adap = new MySqlDataAdapter("SELECT " +
                "`idМероприятие` AS 'id', `Название_мероприятия` AS 'Название', `Описание`, " +
                "( SELECT `Название вида спорта` FROM `вид спорта` WHERE `вид спорта`.`idВид спорта` = `мероприятие`.`idВид спорта` ) " +
                "AS 'Вид спорта', `Дата проведения`, `Дата окончания` FROM `мероприятие`", bd.getCon());
            return adap;
        }

        //Функция быстрого запроса
        private MySqlDataAdapter man()
        {
            BD bd = new BD();
            bd.OpenCon();
            MySqlDataAdapter adap = new MySqlDataAdapter("SELECT * FROM `спортсмен`", bd.getCon());
            return adap;
        }

        //Функция обновления таблицы 
        public void Update(MySqlDataAdapter adp)
        {
            BD bd = new BD();
            bd.OpenCon();
            DataTable DATA = new DataTable();
            adp.Fill(DATA);
            Table_sport.DataSource = DATA;
            bd.CloseCon();
        }


        public Form1()
        {
            InitializeComponent();
        }

        //Завершение работы программы
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Добавить информацию о мероприятии
        private void button1_Click(object sender, EventArgs e)
        {
            BD bd = new BD();
            FormAddEdit_1 form = new FormAddEdit_1();
            MySqlDataAdapter adap = new MySqlDataAdapter("SELECT * FROM `вид спорта`", bd.getCon());
            DataTable DATA = new DataTable();
            adap.Fill(DATA);
            form.dataGridView1.DataSource = DATA;
            bd.CloseCon();
            form.Show();
        }

        //Изменение информации о мероприятии
        private void button2_Click(object sender, EventArgs e)
        {
            BD bd = new BD();
            bd.OpenCon();
            FormAddEdit_1 form = new FormAddEdit_1();
            form.button1.Text = "Изменить";
            int index = Table_sport.CurrentRow.Index;
            form.Box_id.Text = Table_sport.Rows[index].Cells[0].Value.ToString();
            form.Box_name.Text = (string)Table_sport.Rows[index].Cells[1].Value;
            form.BoxAbout.Text = (string)Table_sport.Rows[index].Cells[2].Value;
            form.dateTime_DO.Value = (System.DateTime)Table_sport.Rows[index].Cells[4].Value;
            form.dateTime_ELSE.Value = (System.DateTime)Table_sport.Rows[index].Cells[5].Value;
            MySqlDataAdapter adap = new MySqlDataAdapter("SELECT * FROM `вид спорта`", bd.getCon());
            DataTable DATA = new DataTable();
            adap.Fill(DATA);
            form.dataGridView1.DataSource = DATA;
            bd.CloseCon();
            form.Show();
        }

        //Вывод начальной информации
        private void Form1_Load(object sender, EventArgs e)
        {
            if (acces.Text == "2") {
                Insert_sport.Visible = Update_sport.Visible = Delete_sport.Visible = false;
                otchet.Visible = false;

            }
            BD bd = new BD();
            try
            {
                bd.OpenCon();
                Update(sport());
                bd.CloseCon();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            finally
            {
                bd.CloseCon();
            }
        }

        //Разлогиниться
        private void label3_Click(object sender, EventArgs e)
        {
            login form = new login();
            this.Close();
            form.Show();
        }

        //Изменить информацию спортсменов
        private void l_sport_man_Click(object sender, EventArgs e)
        {
            
            p_sport.Visible = false;
            l_sport.Enabled = true;
            p_man.Visible = true;
            l_sport_man.Enabled = false;
            l_sport_all.Visible = false;
            Insert_sport.Visible = Update_sport.Visible = Delete_sport.Visible = false;
            Insert_man.Visible = Update_man.Visible = Delete_man.Visible = true;
            if (acces.Text == "2")
            {
                Insert_man.Visible = Update_man.Visible = Delete_man.Visible = false;
            }
            BD bd = new BD();
            Update(man());
            bd.CloseCon();
        }

        //Сменить информацию мероприятия
        private void l_sport_Click(object sender, EventArgs e)
        {
            p_man.Visible = false;
            l_sport.Enabled = false;
            p_sport.Visible = true;
            l_sport_man.Enabled = true;
            l_sport_all.Visible = true;
            l_sport_all.Text = "См. Участников";
            rename = false;
            Insert_sport.Visible = Update_sport.Visible = Delete_sport.Visible = true;
            Insert_man.Visible = Update_man.Visible = Delete_man.Visible = false;
            if (acces.Text == "2")
            {
                Insert_sport.Visible = Update_sport.Visible = Delete_sport.Visible = false;
            }
            BD bd = new BD();
            bd.OpenCon();
            Update(sport());
            bd.CloseCon();

        }

        //Удалить информацию мероприятия
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удолить запись?", "Внимание!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                int index = Table_sport.CurrentRow.Index;
                string id = Table_sport.Rows[index].Cells[0].Value.ToString();
                //MessageBox.Show(id); //проверка id
                BD bd = new BD();
                bd.OpenCon();
                MySqlCommand com = new MySqlCommand("DELETE FROM `мероприятие` WHERE `мероприятие`.`idМероприятие` = "+ id, bd.getCon());
                com.ExecuteNonQuery();
                Update(sport());
                bd.CloseCon();
            }
        }

        //Обновление списка БД
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BD bd = new BD();
            if (l_sport.Enabled == false/* && l_sport_all.Text == "См.Участников"*/)
            {
                bd.OpenCon();
                Update(sport());
                bd.CloseCon();
            }
            else if(l_sport_man.Enabled == false)
            {
                bd.OpenCon();
                Update(man());
                bd.CloseCon();
            }
            /*else if(l_sport_all.Text == "См.Мероприятия")
            {
                bd.OpenCon();
                int index = Table_sport.CurrentRow.Index;
                string id = (string)Table_sport.Rows[index].Cells[0].Value.ToString();
                MySqlCommand com = new MySqlCommand("SELECT `Мероприятие_idМероприятие` as 'idМероприятия',(SELECT `спортсмен`.`Имя` FROM `спортсмен` WHERE `спортсмен`.`idСпортсмен` = `Спортсмен_idСпортсмен`) as 'Имя спортсмена', (SELECT `спортсмен`.`Фамилия` FROM `спортсмен` WHERE `спортсмен`.`idСпортсмен` = `Спортсмен_idСпортсмен`) as 'Фамилия спортсмена' FROM `спортсмен участвуюшие в мероприятие` WHERE `Мероприятие_idМероприятие` = @IdS", bd.getCon());
                com.Parameters.Add("@IdS", MySqlDbType.VarChar).Value = id;
                MySqlDataAdapter adap = new MySqlDataAdapter();
                adap.SelectCommand = com;
                Update(adap);
                bd.CloseCon();
            }*/
        }

        //Показать список участников мероприятия
        private void l_sport_all_Click(object sender, EventArgs e)
        { 
            if(Table_sport.Rows.Count == 0)
            {
                MessageBox.Show("Записей мероприятий отсутствуют!");
                return;
            }
            man_in_sport form = new man_in_sport();
            form.Id_sport.Text = (string)Table_sport.Rows[Table_sport.CurrentRow.Index].Cells[0].Value.ToString();
            if (acces.Text == "2")
            {
                form.button1.Visible = form.button2.Visible = false;
            }
                form.Show();
        }

        //Добавитьь информацию спортсменов
        private void Insert_man_Click(object sender, EventArgs e)
        {
            BD bd = new BD();
            FormAddEdit_2 form = new FormAddEdit_2();
            MySqlDataAdapter adap = new MySqlDataAdapter("SELECT * FROM `отделения`", bd.getCon());
            DataTable DATA = new DataTable();
            adap.Fill(DATA);
            form.dataGridView1.DataSource = DATA;
            bd.CloseCon();
            form.Show();
        }

        //Обновить информацию спортсмена 
        private void Update_man_Click(object sender, EventArgs e)
        {
            BD bd = new BD();
            bd.OpenCon();
            FormAddEdit_2 form = new FormAddEdit_2();
            form.button1.Text = "Изменить";
            int index = Table_sport.CurrentRow.Index;
            form.Box_id.Text = Table_sport.Rows[index].Cells[0].Value.ToString();
            form.Box_Fname.Text = (string)Table_sport.Rows[index].Cells[1].Value;
            form.Box_Lname.Text = (string)Table_sport.Rows[index].Cells[2].Value;
            form.Box_Dname.Text = (string)Table_sport.Rows[index].Cells[3].Value;
            form.Box_kyrs.Text = (string)Table_sport.Rows[index].Cells[5].Value;
            MySqlDataAdapter adap = new MySqlDataAdapter("SELECT * FROM `отделения`", bd.getCon());
            DataTable DATA = new DataTable();
            adap.Fill(DATA);
            form.dataGridView1.DataSource = DATA;
            bd.CloseCon();
            form.Show();
        }

        //Удалить информацию спортсмена
        private void Delete_man_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удолить запись?", "Внимание!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                int index = Table_sport.CurrentRow.Index;
                string id = Table_sport.Rows[index].Cells[0].Value.ToString();
                //MessageBox.Show(id); //проверка id
                BD bd = new BD();
                bd.OpenCon();
                MySqlCommand com = new MySqlCommand("DELETE FROM `спортсмен` WHERE `спортсмен`.`idСпортсмен` =" + id, bd.getCon());
                com.ExecuteNonQuery();
                Update(man());
                bd.CloseCon();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (acces.Text == "0")
            {
                ADM form = new ADM();
                form.Show();
                return;
            }
            else
            {
                if (MessageBox.Show("Хотите сменить пароль?", "Внимание!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    return;
                }
                else
                {
                    New_pass form = new New_pass();
                    form.ID_pas.Text = idUr.Text;
                    form.Show();
                }
            }
        }

        //Пасхалка :)
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://rea.perm.ru");
        }

        //Вывод отчёта за период
        private void button4_Click(object sender, EventArgs e)
        {
            Otchet form = new Otchet();
            form.Show();
            return;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Minimized) { 
                this.Hide();
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
    }
}
