using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_lab_2.Utils
{
    class Calc_Record
    {
        //система счисления
        public int p { get; set; }

        //точность
        public int c { get; set; }

        //первое число
        public string number1 { get; set; }

        //второе число
        public string number2 { get; set; }

        //первая функция
        public Calc_Processor.Function function1 { get; set; }

        //вторая функция
        public Calc_Processor.Function function2 { get; set; }

        //операция
        public Calc_Processor.Operation operation { get; set; }

        //результат
        public string result { get; set; }

        //конструктор создания новой записи
        public Calc_Record(int p, int c, string number1, string number2, Calc_Processor.Function function1, Calc_Processor.Function function2, Calc_Processor.Operation operation, string result)
        {
            this.p = p;
            this.c = c;
            this.number1 = number1;
            this.number2 = number2;
            this.function1 = function1;
            this.function2 = function2;
            this.operation = operation;
            this.result = result;
        }


        //переопределение метода для удобной интерпретации записи
        public override string ToString()
        {
            if (operation == Calc_Processor.Operation.None)
            {
                return String.Format("{0}{1}({2}) => {3}({2})\t <{4}>", number1, Extensions.GetFunction(function1), p, result, c);
            }

            return String.Format("{0}{1}({2}) {3} {4}{5}({2}) => {6}({2}) <{7}>", number1, Extensions.GetFunction(function1), p, Extensions.GetOperand(operation), number2, Extensions.GetFunction(function2), result, c);
        }
    }
}
