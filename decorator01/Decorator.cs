using System;

namespace decorator01
{


    /// <summary>
    /// 定义一个对象接口，可以给这些对象动态地添加职责
    /// </summary>
    public abstract class Component
    {
        public abstract void Operation();
    }


    /// <summary>
    /// 定义了一个具体的对象，也可以给这个对象添加一些职责
    /// </summary>
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("具体的操作对象！");
        }
    }

    /// <summary>
    /// 装饰抽象类，继承了Component，从外类来扩展Component类的功能，
    /// 但对于Component类来说，是无需知道Decorator的存在的
    /// </summary>
    public abstract class Decorator : Component
    {
        protected Component component;

        public void SetComponent(Component component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }

    /// <summary>
    /// 具体的装饰对象，起到给Component添加职责的功能
    /// </summary>
    public class ConcreteDecoratorA : Decorator
    {
        private string addedState;

        public override void Operation()
        {
            base.Operation();
            addedState = "New State";
            Console.WriteLine("装饰对象A独有的特点：" + addedState);
            Console.WriteLine("具体装饰对象A的操作");
        }
    }

    /// <summary>
    /// 具体的装饰对象，起到给Component添加职责的功能
    /// </summary>
    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("具体装饰对象B的操作");
        }

        private void AddedBehavior()
        {
            Console.WriteLine("DecoratorB的独有方法！");
        }
    }




}