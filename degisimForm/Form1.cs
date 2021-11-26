using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degisimForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte b1 = 125;
            int d   = b1;
            MessageBox.Show(d.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double d1 = 12.5;
            int i = (int)d1;
            MessageBox.Show($"Senin ilk halin {d1}, Dönüşümden Sonraki halin {i} ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = "1234";
            int s2 = Convert.ToInt32(s);
            MessageBox.Show(s2.ToString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime date = Convert.ToDateTime("12/12/2012");
            MessageBox.Show(date.ToLongDateString()+"\n"+ date.ToShortDateString()+"\n"+date.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sayi3 = "5";
            MessageBox.Show( "" + int.Parse(sayi3) );

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sayi4 = "4";
            bool bl = Int32.TryParse(sayi4,out int sonuc);
            MessageBox.Show(sonuc.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
