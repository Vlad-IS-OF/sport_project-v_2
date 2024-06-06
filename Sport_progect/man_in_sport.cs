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
            MySqlDataAdapter adap = new MySqlDataAdapter("call GET_Sportman_in_ivent('"+Id_sport.Text+"')", bd.getCon());
            return adap;
        }
        private MySqlDataAdapter not_sport_man()
        {
            BD bd = new BD();
            MySqlDataAdapter adap = new MySqlDataAdapter("call GET_Sportman_not_in_ivent('"+Id_sport.Text+"')", bd.getCon());
            return adap;
        }
        private MySqlDataAdapter sport_refery()
        {
            BD bd = new BD();
            MySqlDataAdapter adap = new MySqlDataAdapter("call GET_Refery_in_ivent('" + Id_sport.Text + "')", bd.getCon());
            return adap;
        }
        private MySqlDataAdapter not_sport_refery()
        {
            BD bd = new BD();
            MySqlDataAdapter adap = new MySqlDataAdapter("call GET_Refery_not_in_ivent('" + Id_sport.Text + "')", bd.getCon());
            return adap;
        }

        //обновление таблицы участников
        private void updat1(MySqlDataAdapter adp)
        {
            BD bd = new BD();
            bd.OpenCon();
            DataTable DATA = new DataTable();
            adp.Fill(DATA);
            DGV_man.DataSource = DATA;
            bd.CloseCon();
        }

        //обновление таблицы спортсменов
        private void updat2(MySqlDataAdapter adp)
        {
            BD bd = new BD();
            bd.OpenCon();
            DataTable DATA = new DataTable();
            adp.Fill(DATA);
            DGV_not_man.DataSource = DATA;
            bd.CloseCon();
        }
        //обновление таблицы жюри
        private void updat3(MySqlDataAdapter adp)
        {
            BD bd = new BD();
            bd.OpenCon();
            DataTable DATA = new DataTable();
            adp.Fill(DATA);
            DGV_ref.DataSource = DATA;
            bd.CloseCon();
        }
        //обновление таблицы жюри
        private void updat4(MySqlDataAdapter adp)
        {
            BD bd = new BD();
            bd.OpenCon();
            DataTable DATA = new DataTable();
            adp.Fill(DATA);
            DGV_not_ref.DataSource = DATA;
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
                updat2(not_sport_man());
                updat3(sport_refery());
                updat4(not_sport_refery());
                bd.CloseCon();
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
                updat2(not_sport_man());
                return;
            }
            BD bd = new BD();
            string a = find.Text.ToString();
            MySqlDataAdapter adap = new MySqlDataAdapter("call FIND_Sportman_not_in_ivent('"+Id_sport.Text+"','"+a+"')", bd.getCon());
            updat2(adap);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int index_man = DGV_not_man.CurrentRow.Index;
                string ID_man = (string)DGV_not_man.Rows[index_man].Cells[0].Value.ToString();
                BD bd = new BD();
                bd.OpenCon();
                MySqlCommand com = new MySqlCommand(
                    "INSERT INTO `спортсмены в мероприятии`(idМероприятия,idУчастника) VALUES ('"+Id_sport.Text+"','"+ID_man+"')", bd.getCon());
                com.ExecuteNonQuery();
                updat1(sport_man());
                updat2(not_sport_man());
                bd.CloseCon();
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
                int index = DGV_man.CurrentRow.Index;
                string Id_man = DGV_man.Rows[index].Cells[0].Value.ToString();
                MySqlCommand com = new MySqlCommand("DELETE FROM `спортсмены в мероприятии` WHERE `спортсмены в мероприятии`.`idМероприятия` = " + Id_sport.Text + " AND `спортсмены в мероприятии`.`idУчастника` = " + Id_man, bd.getCon());
                com.ExecuteNonQuery();
                updat1(sport_man());
                updat2(not_sport_man());
                bd.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(find_ref.Text))
            {
                BD db = new BD();
                updat4(not_sport_refery());
                return;
            }
            BD bd = new BD();
            string a = find_ref.Text.ToString();
            MySqlDataAdapter adap = new MySqlDataAdapter("call FIND_refery_not_in_ivent('" + Id_sport.Text + "','" + a + "')", bd.getCon());
            updat4(adap);
        }

        private void ADD_ref_Click(object sender, EventArgs e)
        {
            try
            {
                int index = DGV_not_ref.CurrentRow.Index;
                string ID_ref = (string)DGV_not_ref.Rows[index].Cells[0].Value.ToString();
                BD bd = new BD();
                bd.OpenCon();
                MySqlCommand com = new MySqlCommand(
                    "INSERT INTO `список жюри` (idМероприятия,idУчастника) VALUES ('" + Id_sport.Text + "','" + ID_ref + "')", bd.getCon());
                com.ExecuteNonQuery();
                updat3(sport_refery());
                updat4(not_sport_refery());
                bd.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Del_ref_Click(object sender, EventArgs e)
        {
            try
            {
                BD bd = new BD();
                bd.OpenCon();
                int index = DGV_ref.CurrentRow.Index;
                string Id_ref = DGV_ref.Rows[index].Cells[0].Value.ToString();
                MySqlCommand com = new MySqlCommand("DELETE FROM `список жюри` WHERE `список жюри`.`idМероприятия` = " + Id_sport.Text + " AND `список жюри`.`idУчастника` = " + Id_ref, bd.getCon());
                com.ExecuteNonQuery();
                updat3(sport_refery());
                updat4(not_sport_refery());
                bd.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
