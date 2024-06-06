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
    public partial class FormAddEdit_4 : Form
    {
        public FormAddEdit_4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Box_id.Text == "" || Box_Fname.Text == "")
                {
                    MessageBox.Show("Поле ФИО не заполнено!\nВыберите участника из списка!", "Ошибка");
                    return;
                }
                BD bd = new BD();
                bd.OpenCon();
                MySqlCommand com = new MySqlCommand("call спортивные_мерпориятия_v2.Add_new_refery('" + Box_id.Text + "')", bd.getCon());
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

        private void button2_Click(object sender, EventArgs e)
        {
            Box_Fname.Text = "";
        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            int index = dataGridView2.CurrentRow.Index;
            Box_id.Text = dataGridView2.Rows[index].Cells[0].Value.ToString();
            this.Box_Fname.Text = dataGridView2.Rows[index].Cells[1].Value.ToString();
        }
    }
}
