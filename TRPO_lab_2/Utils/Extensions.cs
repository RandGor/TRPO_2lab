using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_lab_2.Utils
{
    class Extensions
    {

        // разделитель целой и дробной частей
        public const string delim = ",";

        public const double EPS = 1e-10;

        // главные символы операндов
        public const string plus = "+";
        public const string minus = "—";
        public const string mul = "X";
        public const string divide = "/";

        // если символ является числом
        public static bool IsDigit(char c)
        {
            return c >= '0' && c <= '9';
        }

        // если символ является буквой
        public static bool IsLetter(char c)
        {
            return c >= 'A' && c <= 'F';
        }

        // если символ является операндом
        public static bool IsOperand(char c)
        {
            return (c == divide[0] || c == mul[0] || c == minus[0] || c == plus[0]);
        }

        // получение операнда
        public static Calc_Processor.Operation GetOperand(char c)
        {

            switch (c.ToString())
            {
                case plus:
                    return Calc_Processor.Operation.Add;
                case minus:
                    return Calc_Processor.Operation.Sub;
                case mul:
                    return Calc_Processor.Operation.Mul;
                case divide:
                    return Calc_Processor.Operation.Dvd;
            }
            return Calc_Processor.Operation.None;
        }

        // получение операнда
        public static string GetOperand(Calc_Processor.Operation c)
        {

            switch (c)
            {
                case Calc_Processor.Operation.Add:
                    return plus;
                case Calc_Processor.Operation.Sub:
                    return minus;
                case Calc_Processor.Operation.Mul:
                    return mul;
                case Calc_Processor.Operation.Dvd:
                    return divide;
            }
            return "";
        }

        // получение функции
        public static Calc_Processor.Function GetFunction(string s)
        {
            if (s.Equals("1/x"))
                return Calc_Processor.Function.Rev;
            if (s.Equals("x^2"))
                return Calc_Processor.Function.Sqrt;

            return Calc_Processor.Function.None;
        }

        // получение функции
        public static string GetFunction(Calc_Processor.Function s)
        {
            if (s == Calc_Processor.Function.Rev)
                return "^-1";

            if (s == Calc_Processor.Function.Sqrt)
                return "^2";

            return "";
        }

        // если символ является операндом
        public static bool IsPower(string s)
        {
            return s.Equals("^-1") || s.Equals("^2");
        }

        // если символ является буквой или числом
        public static bool IsDigitOrLetter(char c)
        {
            return IsDigit(c) || IsLetter(c);
        }

        // взятие абсолютной величины символа
        public static int GetCharValue(char c)
        {
            if (c >= '0' && c <= '9')
                return c - '0';

            return c - 'A' + 10;
        }

        // преобразование целого в символ
        public static char GetCharValue(int i)
        {
            if (i >= 0 && i <= 9)
                return (char)(i + '0');

            return (char)(i - 10 + 'A');
        }

        // преобразование целого в символ
        public static bool IfCharOnBase(char c, int p)
        {
            return GetCharValue(c) < p;
        }

        public static bool isEndsWithPower(string number)
        {
            int lastPowerIndex = 0;

            for (int i = 0; i < number.Length; i++)
                if (number[i] == '^')
                    lastPowerIndex = i;

            string lastPower = number.Substring(lastPowerIndex);

            return IsPower(lastPower);
        }

        // поиск минимальной системы счисления для заданного числа
        public static int GetMinBase(string buff)
        {
            string t = buff.Replace("^2", "").Replace("^-1", "").Replace(plus, "").Replace(minus, "").Replace(mul, "").Replace(divide, "").Replace(delim, "");
            int max = 1;

            foreach (char c in t)
            {
                int next = GetCharValue(c);
                
                if (next > max)
                    max = next;
            }

            return max + 1;
        }

        // удалить все символы в t, не удовлетворяющие системе p, обрезать нули слева
        public static string ClampByBase(string t, int p)
        {
            string output = "";

            // поиск максимальной базы числа
            foreach(char c in t)
            {
                if (!IfCharOnBase(c, p))
                    continue;

                output += c;
            }

            // обрезка всех нулей слева
            int zeroCount = 0;

            for (int i = 0; i < output.Length; i++)
            {
                if (output[i] == '0')
                    zeroCount++;

                if (output[i] == delim[0] || output[i] != '0')
                    break;
            }

            if (zeroCount > 1)
                output = output.Substring(zeroCount - 1);

            // удаление самого левого нуля, если число не дробное
            if (output.Length > 1 && output[0] == '0' && output[1] != delim[0])
                output = output.Substring(1);

            // если осталась пустая строка - приводить к нулю
            if (output.Length == 0)
                output = "0";

            return output;
        }
    }
}
