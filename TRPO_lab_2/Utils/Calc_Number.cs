using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_lab_2.Utils
{
    class Calc_Number
    {
        //значение числа в 10й СС
        public double a { get; set; }

        //основание системы
        public int b { get; set; }

        //точность вычислений
        public int c { get; set; }

        public Calc_Number() { }

        public Calc_Number(double number, int basement, int accuracy)
        {
            a = number;
            b = basement;
            c = accuracy;
        }

        public void SetValue(double newA)
        {
            a = newA;
        }

        public void SetBasement(int newB)
        {
            b = newB;
        }

        public void SetPrecision(int newC)
        {
            c = newC;
        }

        public Calc_Number Copy()
        {
            Calc_Number n = new Calc_Number(a, b, c);
            return n;
        }

        public Calc_Number Sum(Calc_Number Num2)
        {
            if (b != Num2.b) throw new Exception("С.C. не совпадают");
            Calc_Number Num3 = new Calc_Number(Math.Round(a + Num2.a, c), b, c);
            return Num3;
        }

        public Calc_Number Substract(Calc_Number Num2)
        {
            if (b != Num2.b) throw new Exception("С.C. не совпадают");
            Calc_Number Num3 = new Calc_Number(Math.Round(a - Num2.a, c), b, c);
            return Num3;
        }

        public Calc_Number Multiply(Calc_Number Num2)
        {
            if (b != Num2.b) throw new Exception("С.C. не совпадают");
            Calc_Number Num3 = new Calc_Number(Math.Round(a * Num2.a, c), b, c);
            return Num3;
        }

        public Calc_Number Devide(Calc_Number Num2)
        {
            if (b != Num2.b) throw new Exception("С.C. не совпадают");
            if (Num2.a == 0) throw new Exception("Деление на ноль");
            Calc_Number Num3 = new Calc_Number(Math.Round(a / Num2.a, c), b, c);
            return Num3;
        }

        public Calc_Number Inverse()
        {
            if (a == 0) throw new Exception("Деление на ноль");
            Calc_Number Num3 = new Calc_Number(Math.Round(1 / a, c), b, c);
            return Num3;
        }

        public Calc_Number Squared()
        {
            Calc_Number Num3 = new Calc_Number(Math.Round(Math.Pow(a, 2), c), b, c);
            return Num3;
        }
    }
}
