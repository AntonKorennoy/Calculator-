using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_
{
    public class Calc : IntCalc
    {
        double a = 0;
        
        public void PutA(double a)
        {
            this.a = a;
        }


        public void ClearA()//Очистка поля ввожа
        {
            a = 0;
        }

        public double Multiplication(double b)//умножение
        {
            return a * b;
        }


        public double Division(double b)//деление
        {
            return a / b;
        }

        public double Sum(double b)// сумма
        {
            return a + b;
        }

        public double Subtraction(double b) //вычитание
        {
            return a - b;
        } 

        public double Rad(double b)//перевод в радианы
        {
            return b=a * Math.PI / 180;
        }
    }
}
