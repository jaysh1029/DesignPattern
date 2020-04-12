using System;
namespace easyFactory
{
    /// <summary>
    /// 工厂方法的客户端应用
    /// </summary>
    public class FourthClient
    {
        public static void Calculate(){
            IFactory operFactory = new AddFactory();            
            Operation oper = operFactory.CreateOperation();
            oper.NumberA = 1;
            oper.NumberB =2;
            double result = oper.GetResult();
            Console.WriteLine("{0} + {1} = {2}",oper.NumberA,oper.NumberB,result);
        }
        
    }
}