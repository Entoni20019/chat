using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace КУРСАЧ
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Anthonian\Desktop\Project\КУРСАЧ\КУРСАЧ\bin\Debug\Sport_Shop.mdb");
            OleDbDataAdapter ada = new OleDbDataAdapter("SELECT COUNT(*) From Ид_клиента where Логин = '" + textBox1.Text + "'and Пароль = '" + textBox2.Text + "'", con);

            DataTable dt = new DataTable();
            ada.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Hide();
                Form4 frm4 = new Form4();
                frm4.Show();

            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль!!!");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
