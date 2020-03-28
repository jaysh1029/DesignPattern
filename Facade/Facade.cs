using System;
namespace facade{

    public class SubSystemOne{
        public void MethodOne(){
            Console.WriteLine("子系统方法一");
        }
    }

    public class SubSystemTwo{
        public void MethodTwo(){
            Console.WriteLine("子系统方法二");
        }
    }

    public class SubSystemThree{
        public void MethodThree(){
            Console.WriteLine("子系统方法三");
        }
    }

    public class SubSystemFour{
        public void MethodFour(){
            Console.WriteLine("子系统方法四");
        }
    }

    public class Facade{
        SubSystemOne one;
        SubSystemTwo two;

        SubSystemThree three;

        SubSystemFour four;

        public Facade(){
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
            four = new SubSystemFour();
        }

        public void MethodA(){
            Console.WriteLine("\n方法组A() ---- ");
            one .MethodOne();
            two.MethodTwo();
            four.MethodFour();
        }

        public void MethodB(){
            Console.WriteLine("\n方法组B() ---- ");
            two.MethodTwo();
            three.MethodThree();
        }
    }
}