using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_While_DoWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //1. Kullanım
            int index = 1; // Değişken tanımlanır ve değer ataması yapılır
            while (index < 100) // Döngü içerisine koşul ile atanmış olur
            {
                listBox1.Items.Add(index.ToString()); // Koşul sağlandığında bu radaki alan çalışır
                index++;
            }


            listBox1.Items.Add("------------");

            //2. Kullanım
            int index2 = 1; // Değişken tanımlanır ve değer ataması yapılır
            do
            {
                listBox1.Items.Add(index2);// Koşul sağlandığında bu radaki alan çalışır
                index2++;
            } while (index2 < 100);// Döngü içerisine koşul ile atanmış olur
        }
    }
}
