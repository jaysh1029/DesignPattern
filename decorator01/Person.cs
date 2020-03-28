using System;

namespace decorator01
{

    /// <summary>
    /// 人类
    /// </summary>
    public class Person
    {
        public Person() { }

        private string name;
        public Person(string name)
        {
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("装扮的{0}", name);
        }
    }

    /// <summary>
    /// 服饰类(父类)
    /// </summary>
    public class Finery : Person
    {
        protected Person component;
        public void Decorate(Person component)
        {
            this.component = component;
        }
        public override void Show()
        {
            if (component != null)
            {
                component.Show();
            }
        }
    }

    public class TShirts:Finery{
        public override void Show(){
            Console.Write("大T恤 ");
            base.Show();
        }
    }

    public class BigTrouser:Finery{
        public override void Show(){
            Console.Write("垮裤 ");
            base.Show();
        }
    }

    public class Suit:Finery{
        public override void Show(){
            Console.Write("西装 ");
            base.Show();
        }
    }

    public class Tie:Finery{
        public override void Show(){
            Console.Write("领带 ");
            base.Show();
        }
    }

    public class Sneakers:Finery{
        public override void Show(){
            Console.Write("破球鞋 ");
            base.Show();
        }
    }

    public class LeatherShoes:Finery{
        public override void Show(){
            Console.Write("皮鞋 ");
            base.Show();
        }
    }

}