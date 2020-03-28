using System;
namespace factorymode
{
    public class Operation
    {
        private double _numberA = 0;
        private double _numberB = 0;

        public double NumberA
        {
            get { return _numberA; }
            set { _numberA = value; }
        }

        public double NumberB
        {
            get { return _numberB; }
            set { _numberB = value; }
        }
        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }

    public class OperationAdd : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA + NumberB;
            return result;
        }
    }

    public class OperationSub : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA - NumberB;
            return result;
        }
    }

    public class OperationMul : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA * NumberB;
            return result;
        }
    }

    public class OperationDiv : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumberB == 0)
            {
                throw new Exception("除数不能为0.");
            }
            result = NumberA / NumberB;
            return result;
        }
    }

    public class OperationFacotry
    {
        public static Operation createOperate(string operate)
        {
            Operation oper = null;

            switch (operate)
            {
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OperationSub();
                    break;
                case "*":
                    oper = new OperationMul();
                    break;
                case "/":
                    oper = new OperationDiv();
                    break;

            }
            return oper;
        }
    }


    interface IFactory{
        Operation CreateOperation();
    }
    public class AddFactory:IFactory{
        public Operation CreateOperation(){
            return new OperationAdd();
        }
    }

    public class SubFactory:IFactory{
        public Operation CreateOperation(){
            return new OperationSub();
        }
    }

    public class MulFactory :IFactory{
        public Operation CreateOperation(){
            return new OperationMul();
        }
    }

    public class DivFactory:IFactory{
        public Operation CreateOperation(){
            return new OperationDiv();
        }
    }

    public class OperationPower:Operation{
        public override double GetResult(){
            return Math.Pow(NumberA,NumberB);
        }
    }

    public class PowerFactory:IFactory{
        public Operation CreateOperation(){
            return new OperationPower();
        }
    }


}