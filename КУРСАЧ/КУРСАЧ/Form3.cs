using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
namespace КУРСАЧ
{
    public partial class Form3 : Form
    {
        SqlDataAdapter rb;
        SqlCommandBuilder db;
        DataTable rs;
        public static string connectString = (@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Anthonian\Desktop\Project\КУРСАЧ\КУРСАЧ\bin\Debug\Sport_Shop.mdb");
        private OleDbConnection myConnection;
        public Form3()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void КлиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sport_ShopDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_ShopDataSet.Ид_клиента". При необходимости она может быть перемещена или удалена.
            this.ид_клиентаTableAdapter.Fill(this.sport_ShopDataSet.Ид_клиента);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_ShopDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.sport_ShopDataSet.Клиенты);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

           using (OleDbConnection conn = new OleDbConnection(connectString)) //connString - строка подключения
           {
               string commText = "insert into Ид_клиента (ID_клиента, Логин, Пароль) values (?, ?, ?)"; //в таблице Table1 3 поля: field1, field2, field3
               OleDbCommand comm = new OleDbCommand(commText, conn);
              
              comm.Parameters.AddWithValue("@ID_клиента", textBox1.Text); //добавляем первый параметр со значением из textBox1.Text
               comm.Parameters.AddWithValue("@Логин", textBox2.Text);
               comm.Parameters.AddWithValue("@Пароль", textBox3.Text);
               conn.Open();
               try
               {
                    comm.ExecuteNonQuery();
                    
                }
               catch
               {
                    MessageBox.Show("Добавить не удалось!");
                }
              
           }
            using (OleDbConnection connt = new OleDbConnection(connectString))
            { 

                string commtText = "insert into Клиенты (ФИО,Адресс,Телефон,№карты,Код_клиента) values ( ?, ?, ?, ?, ?)"; //в таблице Table1 3 поля: field1, field2, field3
                OleDbCommand commt = new OleDbCommand(commtText, connt);
                commt.Parameters.AddWithValue("@Код_клиента", textBox4.Text);
                commt.Parameters.AddWithValue("@ФИО", textBox5.Text);
                commt.Parameters.AddWithValue("@Адресс", textBox6.Text);
                commt.Parameters.AddWithValue("@Телефон", textBox7.Text);
                commt.Parameters.AddWithValue("@№карты", textBox8.Text);
              
                connt.Open();
                try
                {
                    commt.ExecuteNonQuery();

               }
                catch
                {
                   MessageBox.Show("Добавить не удалось, Извените!");
                }
            }
        }
    }
}
