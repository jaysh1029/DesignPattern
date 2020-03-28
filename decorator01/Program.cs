using System;

namespace decorator01
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            d1.SetComponent(c);
            d2.SetComponent(d1);
            d2.Operation();
            
            Person xc = new Person("小菜");
            Console.WriteLine("\n第一种装扮：");

            Sneakers pqx = new Sneakers();
            BigTrouser kk = new BigTrouser();
            TShirts dtx = new TShirts();

            pqx.Decorate(xc);
            kk.Decorate(pqx);
            dtx.Decorate(kk);
            dtx.Show();

            Console.WriteLine("\n第二种装扮：");
            LeatherShoes px = new LeatherShoes();
            Tie ld = new Tie();
            Suit xz = new Suit();

            px.Decorate(xc);
            ld.Decorate(px);
            xz.Decorate(ld);
            xz.Show();

            Console.WriteLine("\n第三种装扮：");

            Sneakers pqx2 = new  Sneakers();
            LeatherShoes px2 = new LeatherShoes();            
            BigTrouser kk2 = new BigTrouser();
            Tie ld2 = new Tie();
            pqx2.Decorate(xc);
            px2.Decorate(pqx);
            kk2.Decorate(px2);
            ld2.Decorate(kk2);
            ld.Show();


        }
    }
}
