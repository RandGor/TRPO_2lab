using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_lab_2.Utils
{
    class Calc_Control
    {
        //основание системы сч.
        private int pIn = 10;

        //точность
        public int acuracy = 10;

        //объект редактор
        private Calc_Editor editor = new Calc_Editor();

        //объект процессор
        private Calc_Processor processor = new Calc_Processor();

        //объект память
        private Calc_Memory memory = new Calc_Memory();

        //объект история
        private Calc_History history = new Calc_History();

        //флаг фокуса на левом поле
        private bool leftFocus = true;

        private Calc_Processor.Operation nextOperation = Calc_Processor.Operation.None;

        //рассчитать результат
        public string Calculate()
        {
            CommitDigit();

            Calc_Record record = new Calc_Record(
                processor.Lop_Res.b,
                acuracy,
                Calc_Conver_10_p.Do(processor.Lop_Res.a, processor.Lop_Res.b, processor.Lop_Res.c),
                Calc_Conver_10_p.Do(processor.Rop.a, processor.Rop.b, processor.Rop.c),
                processor.function1,
                processor.function2,
                processor.operation,
                ""
            );


            processor.FunctionRun();

            processor.OperationRun();

            leftFocus = true;
            editor.number = Calc_Conver_10_p.Do(processor.Lop_Res.a, processor.Lop_Res.b, processor.Lop_Res.c);
            record.result = editor.number;

            history.AddRecord(record);

            processor.operation = nextOperation;

            if (processor.operation != Calc_Processor.Operation.None) { 
                processor.function1 = Calc_Processor.Function.None;
                processor.function2 = Calc_Processor.Function.None;
            }

            return processor.Lop_Res.a.ToString();
        }

        //Установка операции
        public void SetOperation(Calc_Processor.Operation operation)
        {
            editor.operation = Extensions.GetOperand(operation);

            nextOperation = operation;

            if (!leftFocus)
                return;

            processor.operation = operation;


        }

        //Установка функции
        public void SetFunction(Calc_Processor.Function function)
        {
            if (leftFocus)
                processor.function1 = function;
            else
                processor.function2 = function;

            editor.function = Extensions.GetFunction(function);
        }

        //удалить правый символ левой части
        public void Bs()
        {
            if(editor.operation.Length > 0)
                leftFocus = true;

            editor.Bs();
        }

        //добавить разделитель
        public void AddDelim()
        {
            editor.AddDelim();
        }

        //приписать цифру к числу справа
        public void AddDigit(char v)
        {

            if (!leftFocus && editor.operation.Length != 0)
            {
                Calculate();
                leftFocus = false;
                editor.Clear();
            }
            if (editor.operation.Length != 0)
            {
                CommitDigit();
                editor.Clear();
            }


            if (Extensions.IfCharOnBase(v, pIn))
                editor.AddDigit(v);
        }

        public void CommitDigit()
        {
            Calc_Number target = leftFocus ? processor.Lop_Res : processor.Rop;

            target.a = Calc_Conver_p_10.Do(editor.number, pIn, acuracy);
            target.b = pIn;
            target.c = acuracy;

            editor.operation = "";
            editor.function = "";

            leftFocus = false;
        }

        //передача входного числа
        public string GetNumber()
        {
            return editor.number + editor.function + editor.operation;
        }


        //очистить поля
        public void Clear()
        {
            leftFocus = true;
            processor.Reset();
            editor.Clear();
        }

        //установить новую СС
        public void SetPIn(int value)
        {
            pIn = value;

            editor.number = Calc_Conver_10_p.Do(processor.Lop_Res.a, pIn, processor.Lop_Res.c);
        }

        //вернуть СС
        public int GetPIn()
        {
            return pIn;
        }

        public void SaveMem()
        {
            CommitDigit();
            memory.isEmpty = false;
            memory.number = processor.Lop_Res;

            editor.function = Extensions.GetFunction(memory.function);
        }
        public void PlusMem()
        {
            if (memory.isEmpty)
                return;
            CommitDigit();
            memory.number = memory.number.Sum(processor.Lop_Res);
        }
        
        public void ReadMem()
        {
            if (memory.isEmpty)
                return;

            SetFunction(memory.function);

            if (leftFocus)
                processor.Lop_Res = memory.number;
            else
                processor.Rop = memory.number;

            editor.number = Calc_Conver_10_p.Do(memory.number.a, memory.number.b, memory.number.c);
        }

        public void ClearMem()
        {
            memory.isEmpty = true;
        }
        public bool IsMemEmpty()
        {
            return memory.isEmpty;
        }


        //передача списка истории
        public List<Calc_Record> GetHistory()
        {
            return history.GetRecords();
        }

        //загрузить результат из истории
        public void LoadHistory(int index)
        {
        }

        //очистить историю
        internal void ClearHistory()
        {
            history.Clear();
        }
    }
}
