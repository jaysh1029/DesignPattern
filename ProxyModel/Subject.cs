using System;

namespace ProxyModel
{

    public abstract class Subject
    {
        public abstract void Request();
    }

    public class RealSubject:Subject{

        public override void Request(){
            Console.WriteLine("真实的请求");
        }
    }

    public class Proxy:Subject{
        RealSubject realSubject;
        public override void Request(){
            if(realSubject ==null){
                realSubject = new RealSubject();
            }
            Console.WriteLine("通过代理来实现真实的请求：");
            realSubject.Request();
        }
    }


}