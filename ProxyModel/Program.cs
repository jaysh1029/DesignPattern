using System;

namespace ProxyModel
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolGirl jiaojiao  = new SchoolGirl();
            jiaojiao.Name = "娇娇";
            ProxyPursuit daili = new ProxyPursuit(jiaojiao);
            daili.GiveDolls();
            daili.GiveFlowers();
            daili.GiveChocolate();
            
            Proxy proxy =new Proxy();
            proxy.Request();


        }
    }

   
}
