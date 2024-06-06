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
    public partial class FormAddEdit_3 : Form
    {
        public FormAddEdit_3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Box_Fname.Text = Box_Lname.Text = Box_Dname.Text = "";
        }

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
                    {/*Обновить данные о участнике*/
                        BD bd = new BD();
                        bd.OpenCon();
                        MySqlCommand com = new MySqlCommand("UPDATE `участники_мероприятия` " +
                            "SET `Имя` = '" + Box_Fname.Text + "', `Фамилия` = '" + Box_Lname.Text + "', `Отчество` = '" + Box_Dname.Text + "' WHERE `участники_мероприятия`.`idУчастника` = " + Box_id.Text, bd.getCon());
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
                        MySqlCommand com = new MySqlCommand("call Add_new_people('" + Box_Fname.Text + "', '" + Box_Lname.Text + "', '" + Box_Dname.Text + "')", bd.getCon());
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
    }
}
