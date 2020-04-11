using System;
namespace easyFactory{

/// <summary>
/// 计算器算法工厂，用来对接前端的算法，根据需要来创建相应的实例。
/// 这里利用了面向对象的多态特性，前端只需面对一个Operation，具体的子类根据需要来实例化
/// </summary>
public class OperationFactory{

   public static Operation CreateOperate(string operate){
       Operation oper = null;

       switch(operate){
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

}