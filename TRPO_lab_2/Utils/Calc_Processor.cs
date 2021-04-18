using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_lab_2.Utils
{
    class Calc_Processor
    {
        public enum Operation { None, Add, Sub, Mul, Dvd }
        public enum Function { None, Rev, Sqrt }

        public Operation operation;

        public Function function1;
        public Function function2;

        public Calc_Number Lop_Res;
        public Calc_Number Rop;

        public Calc_Processor()
        {
            Reset();
        }

        public void operationClean()
        {
            operation = Operation.None;
        }

        public void Reset()
        {
            operation = Operation.None;
            function1 = Function.None;
            function2 = Function.None;
            Lop_Res = new Calc_Number(0, 10, 1);
            Rop = new Calc_Number(0, 10, 1);
        }

        public void OperationRun()
        {
            switch (operation)
            {
                case Operation.None:
                    break;

                case Operation.Add:
                    Lop_Res = Lop_Res.Sum(Rop);
                    break;

                case Operation.Sub:
                    Lop_Res = Lop_Res.Substract(Rop);
                    break;

                case Operation.Mul:
                    Lop_Res = Lop_Res.Multiply(Rop);
                    break;

                case Operation.Dvd:
                    Lop_Res = Lop_Res.Devide(Rop);
                    break;
            }

        }

        public void FunctionRun()
        {
            switch (function1)
            {
                case Function.Sqrt:
                    Lop_Res = Lop_Res.Squared();
                    break;

                case Function.Rev:
                    Lop_Res = Lop_Res.Inverse();
                    break;
            }
            switch (function2)
            {
                case Function.Sqrt:
                    Rop = Rop.Squared();
                    break;

                case Function.Rev:
                    Rop = Rop.Inverse();
                    break;
            }
        }

        public Calc_Number GetLopCopy()
        {
            return Lop_Res.Copy();
        }

        public Calc_Number GetRopCopy()
        {
            return Rop.Copy();
        }

        public void SetLopCopy(Calc_Number E)
        {
            Lop_Res = E.Copy();
        }

        public void SetRopCopy(Calc_Number E)
        {
            Rop = E.Copy();
        }
    }
}
