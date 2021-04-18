using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_lab_2.Utils
{
    abstract class Calc_Conver_10_p
    {
        //Преобразовать целое в символ.
        public static char int_to_Char(long n)
        {
            switch (n)
            {
                case 0:
                    return '0';
                case 1:
                    return '1';
                case 2:
                    return '2';
                case 3:
                    return '3';
                case 4:
                    return '4';
                case 5:
                    return '5';
                case 6:
                    return '6';
                case 7:
                    return '7';
                case 8:
                    return '8';
                case 9:
                    return '9';
                case 10:
                    return 'A';
                case 11:
                    return 'B';
                case 12:
                    return 'C';
                case 13:
                    return 'D';
                case 14:
                    return 'E';
                case 15:
                    return 'F';
                default:
                    throw new Exception("Недопустимый остаток");


            }
        }



        //Преобразовать десятичное целое в с.с. с основанием р.
        public static string int_to_P(long n, int p)
        {
            String result = "";
            long temp = System.Math.Abs(n);
            Stack<char> stack = new Stack<char>();

            if (n < 0)
            {
                result = "-";
            }

            if (temp == 0)
            {
                result += '0';
            }

            while (temp != 0)
            {
                try
                {
                    stack.Push(int_to_Char(temp % p));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                temp /= p;


            }
            while (stack.Count != 0)
            {
                result += stack.Pop();
            }

            return result;
        }



        //Преобразовать десятичную дробь в с.с. с основанием р.
        public static string flt_to_P(double n, int p, int c)
        {
            double temp = System.Math.Abs(n);
            double mult;
            String result = "";
            if (temp == 0)
            {
                result += '0';
            }

            while (c != 0 && temp % 1 > Extensions.EPS)
            {
                mult = temp * p;
                mult = Math.Round(mult, 10);

                try
                {
                    result += int_to_Char((int)mult);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                temp = mult % 1;
                c--;
            }
            return result;
        }



        //Преобразовать десятичное действительное число
        //в с.с. с основанием р и точностью с знаков.
        public static string Do(double n, int p, int c)
        {
            String v1 = int_to_P((long)n, p);
            String v2 = flt_to_P(n % 1, p, c);
            return v1 + Extensions.delim + v2;

        }
    }
}
