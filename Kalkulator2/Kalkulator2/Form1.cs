using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int a = 0, b = 0;
        string text = "";

        //Кнопки
        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                a = 1;
                textBox1.Text = Convert.ToString(a);
            }
            else
                b = 1;
                textBox2.Text = Convert.ToString(b);
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                a = 2;
                textBox1.Text = Convert.ToString(a);
            }
            else
                b = 2;
                textBox2.Text = Convert.ToString(b);
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                a = 3;
                textBox1.Text = Convert.ToString(a);
            }
            else
                b = 3;
                textBox2.Text = Convert.ToString(b);
        }

        private void Button4_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                a = 4;
                textBox1.Text = Convert.ToString(a);
            }
            else
                b = 4;
                textBox2.Text = Convert.ToString(b);
        }

        private void Button5_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                a = 5;
                textBox1.Text = Convert.ToString(a);
            }
            else
                b = 5;
                textBox2.Text = Convert.ToString(b);
        }

        private void Button6_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                a = 6;
                textBox1.Text = Convert.ToString(a);
            }
            else
                b = 6;
            textBox2.Text = Convert.ToString(b);
        }

        private void Button7_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                a = 7;
                textBox1.Text = Convert.ToString(a);
            }
            else
                b = 7;
            textBox2.Text = Convert.ToString(b);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                a = 8;
                textBox1.Text = Convert.ToString(a);
            }
            else
                b = 8;
            textBox2.Text = Convert.ToString(b);

        }

        private void Button9_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                a = 9;
                textBox1.Text = Convert.ToString(a);
            }
            else
                b = 9;
            textBox2.Text = Convert.ToString(b);
        }

        private void Button0_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                a = 0;
                textBox1.Text = Convert.ToString(a);
            }
            else
                b = 0;
            textBox2.Text = Convert.ToString(b);
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(a + b);
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(a - b);
        }

        private void ButtonDelenie_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(a / b);
        }

        private void Multiple_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(a * b);
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;

        }
        //Кнопки


        //Окошки
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

      

        //Окошки

        //Равно
        private void Label1_Click(object sender, EventArgs e)
        {

        }

    }
}
