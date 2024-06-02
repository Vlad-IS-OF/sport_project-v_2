using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sport_progect
{
    public partial class man_in_sport : Form
    {
        private MySqlDataAdapter sport_man()
        {
            BD bd = new BD();
            MySqlDataAdapter adap = new MySqlDataAdapter("SELECT `Мероприятие_idМероприятие` as 'idМероприятия',(SELECT `спортсмен`.`Имя` FROM `спортсмен` WHERE `спортсмен`.`idСпортсмен` = `Спортсмен_idСпортсмен`) as 'Имя спортсмена', (SELECT `спортсмен`.`Фамилия` FROM `спортсмен` WHERE `спортсмен`.`idСпортсмен` = `Спортсмен_idСпортсмен`) as 'Фамилия спортсмена' FROM `спортсмен участвуюшие в мероприятие` WHERE `Мероприятие_idМероприятие` = '" + Id_sport.Text + "'", bd.getCon());
            return adap;
        }

        //обновление таблицы участников
        private void updat1(MySqlDataAdapter adp)
        {
            BD bd = new BD();
            bd.OpenCon();
            DataTable DATA = new DataTable();
            adp.Fill(DATA);
            Table_man_sport.DataSource = DATA;
            bd.CloseCon();
        }

        //обновление таблицы спортсменов
        private void updat2(MySqlDataAdapter adp)
        {
            BD bd = new BD();
            bd.OpenCon();
            DataTable DATA = new DataTable();
            adp.Fill(DATA);
            Table_man.DataSource = DATA;
            bd.CloseCon();
        }
        public man_in_sport()
        {
            InitializeComponent();
        }

        private void man_in_sport_Load(object sender, EventArgs e)
        {
            try
            {
                BD bd = new BD();
                updat1(sport_man());
                MySqlDataAdapter adap = new MySqlDataAdapter("SELECT * FROM `спортсмен`", bd.getCon());
                updat2(adap);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Информация о участниках отсутствует!", "Внимание!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(find.Text))
            {
                BD db = new BD();
                MySqlDataAdapter adp = new MySqlDataAdapter("SELECT * FROM `спортсмен`", db.getCon());
                updat2(adp);
                return;
            }
            BD bd = new BD();
            string a = find.Text.ToString();
            MySqlDataAdapter adap = new MySqlDataAdapter("SELECT * FROM `спортсмен` WHERE `Имя` LIKE '" + a + "%' OR `Фамилия` LIKE '" + a + "%' OR`Отчесво` LIKE '" + a + "%' OR `Отделение` LIKE '" + a + "%' OR `Курс` LIKE '" + a + "%'", bd.getCon());
            updat2(adap);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int index_man = Table_man.CurrentRow.Index;
                string ID_man = (string)Table_man.Rows[index_man].Cells[0].Value.ToString();
                BD bd = new BD();
                bd.OpenCon();
                MySqlCommand com = new MySqlCommand(
                    "INSERT INTO `спортсмен участвуюшие в мероприятие` (`Спортсмен_idСпортсмен`, `Мероприятие_idМероприятие`) VALUES (" + ID_man + ", " + Id_sport.Text + ")", bd.getCon());
                com.ExecuteNonQuery();
                updat1(sport_man());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                BD bd = new BD();
                bd.OpenCon();
                int index = Table_man_sport.CurrentRow.Index;
                MessageBox.Show(index.ToString());
                string id;
                //SELECT `Мероприятие_idМероприятие` as 'idМероприятия',(SELECT `спортсмен`.`Имя` FROM `спортсмен` WHERE `спортсмен`.`idСпортсмен` = `Спортсмен_idСпортсмен`) as 'Имя спортсмена', (SELECT `спортсмен`.`Фамилия` FROM `спортсмен` WHERE `спортсмен`.`idСпортсмен` = `Спортсмен_idСпортсмен`) as 'Фамилия спортсмена' FROM `спортсмен участвуюшие в мероприятие` WHERE `Мероприятие_idМероприятие` = '" + Id_sport.Text + "'"
                MySqlDataAdapter adap = new MySqlDataAdapter("SELECT * FROM `спортсмен участвуюшие в мероприятие` WHERE `Мероприятие_idМероприятие` = '" + Id_sport.Text + "'", bd.getCon());
                DataTable DATA = new DataTable();
                adap.Fill(DATA);
                id = DATA.Rows[index][0].ToString();
                MessageBox.Show(id);
                MySqlCommand com = new MySqlCommand("DELETE FROM `спортсмен участвуюшие в мероприятие` WHERE `спортсмен участвуюшие в мероприятие`.`Спортсмен_idСпортсмен` = " + id + " AND `спортсмен участвуюшие в мероприятие`.`Мероприятие_idМероприятие` = " + Id_sport.Text, bd.getCon());
                MessageBox.Show(com.CommandText);
                com.ExecuteNonQuery();
                updat1(sport_man());
                bd.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
