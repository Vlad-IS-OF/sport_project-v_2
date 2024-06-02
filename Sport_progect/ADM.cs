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
using System.Security.Cryptography;

namespace Sport_progect
{
    public partial class ADM : Form
    {
        private void Update(MySqlDataAdapter adp)
        {
            BD bd = new BD();
            bd.OpenCon();
            DataTable DATA = new DataTable();
            adp.Fill(DATA);
            Table_users.DataSource = DATA;
            bd.CloseCon();
        }
        private string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }
        public ADM()
        {
            InitializeComponent();
        }

        private void Table_users_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = Table_users.CurrentRow.Index;
            Box_login.Text = Table_users.Rows[index].Cells[1].Value.ToString();
            Box_password.Text = Table_users.Rows[index].Cells[2].Value.ToString();
        }

        private void ADM_Load(object sender, EventArgs e)
        {
            try
            {
                BD bd = new BD();
                MySqlDataAdapter adap = new MySqlDataAdapter("SELECT `пользователь`.`idПользователь`, `пользователь`.`Login`, `пользователь`.`Password` FROM `пользователь`", bd.getCon());
                DataTable DATA = new DataTable();
                adap.Fill(DATA);
                Table_users.DataSource = DATA;
                bd.CloseCon();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Сброс пароля
        private void button2_Click(object sender, EventArgs e)
        {
            BD bd = new BD();
            bd.OpenCon();
            MySqlCommand com = new MySqlCommand("UPDATE `пользователь` SET `Password` = '"+GetHash(Box_password.Text)+ "', `RePas` = 1 WHERE `пользователь`.`Login` = '" + Box_login.Text+"'", bd.getCon());
            com.ExecuteNonQuery();
            bd.CloseCon();
            MySqlDataAdapter adap = new MySqlDataAdapter("SELECT `пользователь`.`idПользователь`, `пользователь`.`Login`, `пользователь`.`Password` FROM `пользователь`", bd.getCon());
            Update(adap);
        }

        private void Find_TextChanged(object sender, EventArgs e)
        {
            BD bd = new BD();
            bd.OpenCon();
            if (String.IsNullOrEmpty(Find.Text))
            {
                MySqlDataAdapter adp = new MySqlDataAdapter("SELECT `пользователь`.`idПользователь`, `пользователь`.`Login`, `пользователь`.`Password` FROM `пользователь`", bd.getCon());
                Update(adp);
                bd.CloseCon();
                return;
            }
            MySqlDataAdapter adap = new MySqlDataAdapter("SELECT `пользователь`.`idПользователь`, `пользователь`.`Login`, `пользователь`.`Password` FROM `пользователь` WHERE `пользователь`.`idПользователь` LIKE '%" + Find.Text + "%' OR `пользователь`.`Login` LIKE '%" + Find.Text + "%'", bd.getCon());
            Update(adap);
            bd.CloseCon();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Otchet form = new Otchet();
            form.Show();
            this.Close();
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BD bd = new BD();
            string log = Box_login.Text;
            string pas = Box_password.Text;
            string acc = Box_access.SelectedIndex.ToString();
            if (String.IsNullOrEmpty(log))
            {
                MessageBox.Show("Заполните поле логин");
                return;
            }
            if (String.IsNullOrEmpty(pas))
            {
                MessageBox.Show("Заполните поле пароль");
                return;
            }
            if (acc == "-1")
            {
                MessageBox.Show("Выберите уровень доступа пользователя!","Внимание!!");
                return;
            }
            try
            {
                bd.OpenCon();
                MySqlCommand com = new MySqlCommand("INSERT INTO `пользователь` (`Login`, `Password`, `Root`, `RePas`) VALUES ('" + log + "', '" + GetHash(pas) + "', '" + acc + "', '1')", bd.getCon());
                com.ExecuteNonQuery();
                MySqlDataAdapter adap = new MySqlDataAdapter("SELECT `пользователь`.`idПользователь`, `пользователь`.`Login`, `пользователь`.`Password` FROM `пользователь`", bd.getCon());
                Update(adap);
                bd.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = Table_users.CurrentRow.Index;
            string log = Table_users.Rows[index].Cells[1].Value.ToString();
            if (MessageBox.Show("Вы действительно хотите удолить запись ["+log+"]?", "Внимание!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                BD bd = new BD();
                bd.OpenCon();
                string id = Table_users.Rows[index].Cells[0].Value.ToString();
                MySqlCommand com = new MySqlCommand("DELETE FROM `пользователь` WHERE `пользователь`.`idПользователь` = "+id, bd.getCon());
                com.ExecuteNonQuery();
                MySqlDataAdapter adap = new MySqlDataAdapter("SELECT `пользователь`.`idПользователь`, `пользователь`.`Login`, `пользователь`.`Password` FROM `пользователь`", bd.getCon());
                Update(adap);
                bd.CloseCon();
                MessageBox.Show("Элемент удалён!");
            }
            //DELETE FROM `пользователь` WHERE `пользователь`.`idПользователь` = 2
        }
    }
}
