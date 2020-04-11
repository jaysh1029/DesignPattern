using System;

namespace easyFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                直觉地用计算机能够理解的逻辑来描述和表达待解决的问题及具体的求解过程
                缺点：只能满足当前需求，不易维护，不易扩展，不易复用
            */
            //FirstFactory.Calculate();

            /*
                将业务逻辑与界面分离，达到复用的目的
                其他比如 web、PDA、手机等系统都可以使用封装的方法(业务逻辑)
                但不能灵活地修改和扩展
            */
           // SecondFactory.Calculate();

           /*
                面对可能变化的算法，利用继承和多态，进一步分离了算法，这样增加了可扩展性、可维护性，可复用性
                利用多态，由一个简单工厂方法来对接前端具体算法需求，做到了简单灵活 以不变应万变
           */
            ThirdFactory.Calculate();

        }
    }
}
