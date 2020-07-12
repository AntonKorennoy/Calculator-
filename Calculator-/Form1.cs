using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_
{
    public partial class Form1 : Form
    {
        Calc C;
        public Form1()
        {
            InitializeComponent();

            C = new Calc();
            textBox1.Text = "0";
            
          
        }

   
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            Correct();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            Correct();
        }
        
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            Correct();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            Correct();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            Correct();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            Correct();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            Correct();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            Correct();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            Correct();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            Correct();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";

            C.ClearA();
            
        }

        //Проверка на нажатие каких-либо кнопок из операций
        private bool CanPress()
        {
            if (!button1.Enabled)
                return false;

            if (!button2.Enabled)
                return false;

            if (!button3.Enabled)
                return false;

            if (!button4.Enabled)
                return false;

            if (!button18.Enabled)
                return false;

            if (!button19.Enabled)
                return false;

            return true;
        }


        //удаляем лишний ноль впереди числа
        private void Correct()
        {
            

            // слева ноль, а после него НЕ запятая, тогда ноль можно удалить
            if (textBox1.Text[0] == '0' && (textBox1.Text.IndexOf(",") != 1))
                textBox1.Text = textBox1.Text.Remove(0, 1);

            //аналогично предыдущему, только для отрицательного числа
            if (textBox1.Text[0] == '-')
                if (textBox1.Text[1] == '0' && (textBox1.Text.IndexOf(",") != 2))
                    textBox1.Text = textBox1.Text.Remove(1, 1);
            if (textBox1.Text[0] == '0') {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
            }
        }




        private void FreeButtons()
        {
            
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;


        }

        private void button16_Click(object sender, EventArgs e)
        {
           
            if (!button1.Enabled)
                textBox1.Text = C.Sum(Convert.ToDouble(textBox1.Text)).ToString("0.000");

            if (!button2.Enabled)
                textBox1.Text = C.Subtraction(Convert.ToDouble(textBox1.Text)).ToString("0.000");
 
            if (!button3.Enabled)
                textBox1.Text = C.Multiplication(Convert.ToDouble(textBox1.Text)).ToString("0.000");

            if (!button4.Enabled)
                textBox1.Text = C.Division(Convert.ToDouble(textBox1.Text)).ToString("0.000");

            

            C.ClearA();
            FreeButtons();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.IndexOf(",") == -1) && (textBox1.Text.IndexOf("∞") == -1))
                textBox1.Text += ",";

        }

        //кнопка сложения
        private void button1_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.PutA(Convert.ToDouble(textBox1.Text));

                button1.Enabled = false;

                textBox1.Text = "0";
            }
        }

        //кнопка вычитания
        private void button2_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.PutA(Convert.ToDouble(textBox1.Text));

                button2.Enabled = false;

                textBox1.Text = "0";
            }
        }

        //кнопка умножения
        private void button3_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.PutA(Convert.ToDouble(textBox1.Text));

                button3.Enabled = false;

                textBox1.Text = "0";
            }
        }

        //кнопка деления
        private void button4_Click(object sender, EventArgs e)
        {

            if (CanPress())
            {
                C.PutA(Convert.ToDouble(textBox1.Text));

                button4.Enabled = false;

                textBox1.Text = "0";
            }

        }

        // кнопка перевода из градусов в радианы
        private void button18_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.PutA(Convert.ToDouble(textBox1.Text));

                
                
                    textBox1.Text = C.Rad(Convert.ToDouble(textBox1.Text)).ToString("0.00");
            }
        }

        // кнопка изменеия знака
        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[0] == '-')
                textBox1.Text = textBox1.Text.Remove(0, 1);
            else
                textBox1.Text = "-" + textBox1.Text;
        }
    }
}
