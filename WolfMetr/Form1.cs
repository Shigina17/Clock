using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mimimimetr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

       
        private void butResults_Click(object sender, EventArgs e)
        { 
            Form2 form = new Form2();
            Hide();
            form.ShowDialog();
            Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public static void test()
        {
            Random rnd = new Random();
            pictureBox1.Image = img[rnd.Next(0, 16)];
            pictureBox2.Image = @".\..\..\Resources\" + img[rnd.Next(0, 16)];// и т.д
            List<string> pathToImg = new List<string>() { "1.jpg", "2.jpg", "3.jpg", "4.jpg", "5.jpg",
            "6.png", "7.png", "8.png", "9.png", "10.png", "11.png", "12.png", "13.png", "14.png", "15.png", "16.png" };

            int firstImg = rnd.Next(1, pathToImg.Count + 1);
            int secondImage = firstImg;
            while (secondImage == firstImg)
            {
                secondImage = Math.Random(1, pathToImg.Count + 1);
            }

            Random image = new Random();
            string path = @"C:\Users\User\source\repos\IndividualTask\Mimimimetr\Resources\1.jpg";
            pictureBox1.Image = image.Next(1, 16);
            pictureBox1.Image = new Bitmap(path + label1.Text + ".jpg");


            int[] ar = new int[5];
            Random rnd = new Random();
            // заполнение массива
            int k = 0;
            int x;
            for (int i = 0; k < 5; i++)
            {
                x = rnd.Next(36) + 1;
                if (k == 0)    //добавление 1-го элемента массива
                {
                    ar[k] = x;
                    k = k + 1;
                }
                else  //добавление остальных элементов массива
                {
                    int m = 0;
                    for (int j = 0; j < k; j++)  // проверка совпадений
                    {
                        if (ar[j] == x) m = m + 1; // счетчик совпадений
                    }
                    if (m == 0) // добавление нового элемента при отсутствии совпадений
                    {
                        ar[k] = x;
                        k = k + 1;
                    }
                }
            }
            // вывод массива
            string str = ar[0].ToString();
            for (int i = 1; i < 5; i++)
            {
                str += ", " + ar[i];
            }
            label1.Text = str;
            // сортировка массива
            int temp;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 1; j > i; j--)
                {
                    if (ar[j] < ar[j - 1])
                    {
                        temp = ar[j];
                        ar[j] = ar[j - 1];
                        ar[j - 1] = temp;
                    }
                }
            }
            // вывод отсортированного массива
            string str1 = ar[0].ToString();
            for (int i = 1; i < 5; i++)
            {
                str1 += ", " + ar[i];
            }
            label1.Text = str1;
        }

    }
}
