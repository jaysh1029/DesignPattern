using System;
namespace easyFactory{
    public class ThirdFactory{

        public static void Calculate(){
            Operation oper ;
            oper = OperationFactory.CreateOperate("+");
            oper.NumberA = 1;
            oper.NumberB =2;
            double result = oper.GetResult();
            Console.WriteLine("{0} + {1} = {2}",oper.NumberA,oper.NumberB,result);
        }
    }
}