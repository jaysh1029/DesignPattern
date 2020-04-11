using System;

namespace easyFactory
{
    /// <summary>
    /// 第一版计算器程序，面向过程编程，
    /// 界面与业务耦合度较高 不易扩展，不易维护，不易复用
    /// </summary>
    public class FirstFactory
    {

        
        public static void Calculate()
        {
            try
            {
                Console.WriteLine("请输入数字A:");
                string strNumberA = Console.ReadLine();
                Console.Write("请选择运算符号(+、-、*、/)：");
                string strOperate = Console.ReadLine();
                Console.Write("请输入数字B:");
                string strNumberB = Console.ReadLine();
                string strResult = "";
                switch (strOperate)
                {
                    case "+":
                        strResult = Convert.ToString(Convert.ToDouble(strNumberA) + Convert.ToDouble(strNumberB));
                        break;

                    case "-":
                        strResult = Convert.ToString(Convert.ToDouble(strNumberA) - Convert.ToDouble(strNumberB));
                        break;

                    case "*":
                        strResult = Convert.ToString(Convert.ToDouble(strNumberA) * Convert.ToDouble(strNumberB));
                        break;
                    case "/":
                        if (strNumberB != "0")
                        {
                            strResult = Convert.ToString(Convert.ToDouble(strNumberA) / Convert.ToDouble(strNumberB));
                        }
                        else
                        {
                            strResult = "除数不能为0！";
                        }

                        break;
                }
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