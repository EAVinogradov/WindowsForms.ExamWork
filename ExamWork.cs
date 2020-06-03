using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAVinogradov.CSWindowsForms.ExamWork
{
    public partial class ExamWork : Form
    {
        public ExamWork()
        {
            InitializeComponent();
        }
        string s;
        int firstDig;
        int secondDig;
        int summa;
        int summaSquare;
        int count;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            s = textBox1.Text;
            firstDig = Convert.ToInt32(s);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            s = textBox2.Text;
            secondDig = Convert.ToInt32(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            summa = firstDig + secondDig;
            textBox3.Text = Convert.ToString(summa);
            summaSquare = firstDig * firstDig + secondDig * secondDig;
            textBox4.Text = Convert.ToString(summaSquare);
            if (firstDig > secondDig)
            {
                textBox5.Text = Convert.ToString(firstDig);
            }
            else
            {
                textBox5.Text = Convert.ToString(secondDig);
            }
            do
            {
                summa++;
                count++;
            }
            while (summa < summaSquare);
            textBox6.Text = Convert.ToString(count);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Данное поле должно содержать цифры");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Данное поле должно содержать цифры");
            }
        }

    }
}
