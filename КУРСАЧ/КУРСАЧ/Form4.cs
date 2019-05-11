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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public static string connectString = (@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Anthonian\Desktop\Project\КУРСАЧ\КУРСАЧ\bin\Debug\Sport_Shop.mdb");
        private OleDbConnection myConnection;
        private void Спортивные_товарыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.спортивные_товарыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sport_ShopDataSet);

        }

        private void Спортивные_товарыBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.спортивные_товарыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sport_ShopDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_ShopDataSet.Тип_товара". При необходимости она может быть перемещена или удалена.
            this.тип_товараTableAdapter.Fill(this.sport_ShopDataSet.Тип_товара);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_ShopDataSet.ТаблицаСтоимость". При необходимости она может быть перемещена или удалена.
            this.таблицаСтоимостьTableAdapter.Fill(this.sport_ShopDataSet.ТаблицаСтоимость);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sport_ShopDataSet.Спортивные_товары". При необходимости она может быть перемещена или удалена.
            this.спортивные_товарыTableAdapter.Fill(this.sport_ShopDataSet.Спортивные_товары);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           Form5 fr5 = new Form5();
           fr5.Show();
           this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox1.Text);
            int b;
            b =Convert.ToInt32(стоимостьTextBox.Text);
            

            int c;
             c = a * b;
            textBox2.Text = Convert.ToString(c);
           

            
        }
    }
}
