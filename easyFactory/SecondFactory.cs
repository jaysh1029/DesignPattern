using System;

namespace easyFactory
{

    /// <summary>
    /// 封装业务逻辑，与界面分离，达到复用目的，
    /// 其他比如 web、PDA、手机等系统都可以使用封装的方法(业务逻辑)，
    /// 但不能灵活地修改和扩展
    /// </summary>
    public class SecondFactory
    {

        /// <summary>
        /// 封装算法业务逻辑 与界面分离，
        /// 其他比如 web、PDA、手机等系统都可以使用封装的方法(业务逻辑)，
        /// 但不能灵活地修改和扩展，每次修改算法，都会影响其他算法，还有出错的可能，
        /// 每次增加或减少一个算法 其他算法也要重新编译
        /// </summary>
        /// <param name="numberA"></param>
        /// <param name="numberB"></param>
        /// <param name="operate"></param>
        /// <returns></returns>
        public static double GetResult(double numberA, double numberB, string operate)
        {
            double result = 0d;
            switch (operate)
            {
                case "+":
                    result = numberA + numberB;
                    break;

                case "-":
                    result = numberA - numberB;
                    break;

                case "*":
                    result = numberA - numberB;
                    break;

                case "/":
                    result = numberA / numberB;
                    break;
            }
            return result;
        }

        /// <summary>
        /// 前端界面逻辑
        /// </summary>
        public static void Calculate()
        {
            try
            {
                Console.Write("请输入数字A:");
                string strNumberA = Console.ReadLine();
                Console.Write("请选择运算符号(+、-、*、/)：");
                string strOperate = Console.ReadLine();
                Console.Write("请输入数字B:");
                string strNumberB = Console.ReadLine();
                string strResult = "";
                strResult = Convert.ToString(SecondFactory.GetResult(Convert.ToDouble(strNumberA), Convert.ToDouble(strNumberB), strOperate));
                Console.WriteLine("结果是：" + strResult);
                Console.ReadLine();
            }
            catch (System.Exception ex)
            {

                Console.WriteLine("您的输入有错：" + ex.Message);
            }
        }
    }
}