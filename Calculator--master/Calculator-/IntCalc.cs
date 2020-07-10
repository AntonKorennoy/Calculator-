using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_
{
    public interface IntCalc
    {
        void PutA(double a);


        void ClearA();

        double Multiplication(double b);// умножение

        double Division(double b);//деление
        
        double Sum(double b);//сумма

        double Subtraction(double b); //вычитание

        double Rad(double a);// перевод из градусов в радианы

    }
}
