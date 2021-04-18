using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_lab_2.Utils
{
    abstract class Calc_Conver_p_10
    {
        //Преобразовать цифру в число.
        public static double char_To_num(char ch)
        {
            switch (ch)
            {
                case '0':
                    return 0;
                case '1':
                    return 1;
                case '2':
                    return 2;
                case '3':
                    return 3;
                case '4':
                    return 4;
                case '5':
                    return 5;
                case '6':
                    return 6;
                case '7':
                    return 7;
                case '8':
                    return 8;
                case '9':
                    return 9;
                case 'A':
                    return 10;
                case 'B':
                    return 11;
                case 'C':
                    return 12;
                case 'D':
                    return 13;
                case 'E':
                    return 14;
                case 'F':
                    return 15;
                default:
                    throw new Exception("Недопустимый символ");


            }
        }



        // вычисляет количество цифр до запятой.
        private static int find_weight(string P_num)
        {
            int result = 0;
            foreach (char c in P_num)
            {
                if (c != Utils.Extensions.delim[0]) result++;
                else break;
            }
            return result;
        }



        //Преобразовать строку
        //в с.с. p в десятичное число с точностью с знаков.
        public static double Do(string P_num, int P, int c)
        {
            int sign = 1;

            if (P_num[0] == '-')
            {
                P_num = P_num.Substring(1);
                sign = -1;
            }

            double result = 0.0;

            int weight = find_weight(P_num) - 1;


            foreach (char ch in P_num)
            {
                if (ch != Utils.Extensions.delim[0])
                {
                    result += char_To_num(ch) * Math.Pow(P, weight);
                    weight--;
                }
            }
            result = Math.Round(result, c)*sign;
            return result;
        }

    }

}
