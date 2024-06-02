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
    public partial class New_pass : Form
    {
        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }
        public New_pass()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ваш пароль остался без изменения. Доступ к вашей учётной записи могут получить другие пользователи.","Внимание");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.ToString() != textBox2.Text.ToString())
            {
                MessageBox.Show("Пароли не совпадают!","Внимание!");
                return;
            }
            if(textBox1.Text.Length < 5)
            {
                MessageBox.Show("Пароль не удовлетворяет минимальным требованиям длинны.(Мин. 5 символов)", "Внимание!");
                return;
            }
            try
            {
                BD bd = new BD();
                bd.OpenCon();
                MySqlCommand com = new MySqlCommand("UPDATE `пользователь` SET `Password` = '" + GetHash(textBox1.Text) + "', `RePas` = '2' WHERE `пользователь`.`idПользователь` = " + ID_pas.Text, bd.getCon());
                com.ExecuteNonQuery();
                bd.CloseCon();
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
