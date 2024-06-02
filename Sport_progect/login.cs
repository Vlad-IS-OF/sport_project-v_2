using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Sport_progect
{
    public partial class login : Form
    {
        int i = 0;
        public login()
        {
            InitializeComponent();
        }

        private string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

        //Залогинится
        private void button1_Click(object sender, EventArgs e)
        {
            string login = Log.Text;
            string pass = Pas.Text;

            /*var add = ConfigurationManager.AppSettings;*/


            try
            {
                BD bd = new BD();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand com = new MySqlCommand("SELECT * FROM `пользователи` WHERE `Login`= @uL and `Password` = @uP", bd.getCon());
                com.Parameters.Add("@ul", MySqlDbType.VarChar).Value = login;
                com.Parameters.Add("@uP", MySqlDbType.VarChar).Value = GetHash(pass);
                adapter.SelectCommand = com;
                adapter.Fill(table);
                if (!String.IsNullOrEmpty(login) && !String.IsNullOrEmpty(pass) && table.Rows.Count > 0)
                {
                    Form1 Form = new Form1();
                    Form.idUr.Text = table.Rows[0][0].ToString();
                    Form.acces.Text = table.Rows[0][3].ToString();
                    if(table.Rows[0][4].ToString() == "1")
                    {
                        MessageBox.Show("Вам необходимо сменить пароль!!", "Смена пароля");
                        New_pass form = new New_pass();
                        form.ID_pas.Text = table.Rows[0][0].ToString();
                        form.Show();
                    }
                    this.Hide();
                    Form.NameUser.Text = "Hello " + login + "!";
                    Form.Show();
                }
                else
                {
                    i++;
                    if (i > 3)
                    {
                        MessageBox.Show("Ваши попытки закончились!!!!\nПрограмма завершилась с ошибкой -1.", "Bue!");
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Логин или пароль ведён неверно!!", "Внимание у вас осталось: " + (4 - i) + " попытки");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание!");
            }
        }

        //Завершить работу приложения
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
