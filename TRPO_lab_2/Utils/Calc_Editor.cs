using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_lab_2.Utils
{
    class Calc_Editor
    {
        // поле для хранения редактируемого числа
        public string number = "0";

        // поле для хранения операции
        public string operation = "";

        // поле для хранения функции
        public string function = "";

        // добавить символ
        public string AddDigit(char ch)
        {
            if (Extensions.isEndsWithPower(number))
                return number;

            if (ch == '0')
            {
                if (number == "0")
                    return number;

                number += ch;
                return number;
            }
            else
            {
                if (ch == 46 || ch == 44 || (ch >= 48 && ch <= 57) || (ch >= 65 && ch <= 70))
                {
                    if (number == "0")
                        number = ch.ToString();
                    else number += ch;

                    return number;
                }
            }

            return number;
        }

        // добавить разделитель
        public string AddDelim()
        {
            if (operation.Length != 0)
                return number;

            int lastOperatorIndex = 0;

            for (int i = 0; i < number.Length; i++)
                if (Extensions.IsOperand(number[i]))
                    lastOperatorIndex = i;
                       
            
            if (lastOperatorIndex == number.Length - 1 && number.Length > 1)
                return number;

            for (int i = lastOperatorIndex; i < number.Length; i++)
                if (number[i] == Extensions.delim[0])
                    return number;
            
            if(Extensions.isEndsWithPower(number))
                return number;


            number += Extensions.delim[0];
            return number;
        }

        public string AddText(string s)
        {
            if (Extensions.IsOperand(number[number.Length - 1]) && (Extensions.IsOperand(s[0]) || Extensions.IsPower(s)))
                return number;

            number += s;
            return number;
        }

        // удалить символ справа
        public string Bs()
        {
            if (operation.Length > 0)
            {
                operation = "";
                return number;
            }
            if (function.Length > 0)
            {
                function = "";
                return number;
            }
            /*if (Extensions.isEndsWithPower(number))
            {
                number = number.Substring(0, number.LastIndexOf('^'));
                return number;
            }*/

            number = number.Substring(0, number.Length - 1);

            if (number == "") number = "0";

            return number;
        }

        // очистить редактируемое число
        public string Clear()
        {
            number = "0";
            operation = "";
            function = "";

            return number;
        }
    }
}
