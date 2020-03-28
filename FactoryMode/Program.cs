using System;

namespace factorymode
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation oper = OperationFacotry.createOperate("+");
            oper.NumberA  = 1;
            oper.NumberB = 2;
            double result = oper.GetResult();
            Console.WriteLine("{0} + {1} = {2}",oper.NumberA,oper.NumberB,result);

            IFactory operFactory = new PowerFactory();
            Operation  oper2 = operFactory.CreateOperation();
            oper2.NumberA =3;
            oper2.NumberB = 6;
            result  = oper2.GetResult();
            Console.WriteLine("{0}的{1}次方 = {2}",oper2.NumberA,oper2.NumberB,result);


            LeiFeng leifeng = SimpleFactory.CreateLeiFeng("学雷锋的大学生");
            leifeng.Sweep();
            leifeng.Wash();
            leifeng.BuyRice();
            Console.WriteLine("工厂方法雷锋：");
            ILeiFengFactory leifengFactory = new UndergraduateFactory();
            LeiFeng lf = leifengFactory.CreateLeiFeng();
            lf.Sweep();
            lf.Wash();
            lf.BuyRice();


        }
    }
}
