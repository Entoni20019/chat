using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Drawing2D;
using System.IO;
using Microsoft.Win32;
namespace Paint_redactor
{
    public partial class Form1 : Form
    {
        

        Color color = Color.Black; 
        bool isPressed = false; //логическая переменная понадобиться для опеределения когда можно рисовать на panel
        Point CurrentPoint; //Текущая точка ресунка.
        Point PrevPoint; //Это начальная точка рисунка.
        Graphics g; //Создаем графический элемент.
        ColorDialog colorDialog = new ColorDialog(); //диалоговое окно для выбора цвета.
        
       
        public Form1()
        {
            InitializeComponent();
            label2.BackColor = Color.Black; //По умолчанию для пера задан черный цвет, поэтому мы зададим такой же фон для label2
            g = panel1.CreateGraphics(); //Создаем область для работы с графикой на элементе panel
        }
      
        private void Label2_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK) //Если окно закрылось с OK, то меняем цвет для пера и фона label2
            {
                color = colorDialog.Color; //меняем цвет для пера
                label2.BackColor = colorDialog.Color; //меняем цвет для Фона label2
            }
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isPressed = true;
            CurrentPoint = e.Location;
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed = false;
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(isPressed)
            {
                PrevPoint = CurrentPoint;
                CurrentPoint = e.Location;
                my_Pen();

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void my_Pen()
        {
            Pen pen = new Pen(color, (float)numericUpDown1.Value); //Создаем перо, задаем ему цвет и толщину.
            g.DrawLine(pen, CurrentPoint, PrevPoint); //Соединияем точки линиями
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            {
                
                
               color = Color.White; //меняем цвет для пера
                    
                
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK) //Если окно закрылось с OK, то меняем цвет для пера и фона label2
            {
               
                panel1.BackColor = colorDialog.Color; //меняем цвет для Фона label2
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {

           // panel1 = textBox1.Text;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void АвторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cоздатель приложения Anthony (2019)","Автор!");
        }

        private void СоздатьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.Create(@"C:\Users\Anthonian\Desktop\Project\paint\Paint redactor\Image\ppaint1.PNG");
        }

        private void ОткрытьСуществующийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG|*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

              //  panel1.= openFileDialog.FileName;

            }

        }
        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Рисунок .Png | *.Png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                int width, height;
                width = panel1.Width;
                height = panel1.Height;
                Bitmap bmp = new Bitmap(width, height);
                panel1.DrawToBitmap(bmp, panel1.ClientRectangle);
                bmp.Save(sfd.FileName);
            }
        }

        private void СохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}

