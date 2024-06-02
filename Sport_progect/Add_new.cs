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
    public partial class Add_new : Form
    {
        public Add_new()
        {
            InitializeComponent();
        }

        //Добавление информации о виде спорта/отделение
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DB.Text == "вид спорта")
                {
                    BD bd = new BD();
                    bd.OpenCon();
                    MySqlCommand com = new MySqlCommand("INSERT INTO `вид спорта` (`Название вида спорта`) VALUES ('" + Name.Text + "')", bd.getCon());
                    com.ExecuteNonQuery();
                    bd.CloseCon();
                    this.Close();
                }
                else
                {
                    BD bd = new BD();
                    bd.OpenCon();
                    MySqlCommand com = new MySqlCommand("INSERT INTO `отделения` (`Название отделения`) VALUES ('" + Name.Text + "')", bd.getCon());
                    com.ExecuteNonQuery();
                    bd.CloseCon();
                    this.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Отмена добавления
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
