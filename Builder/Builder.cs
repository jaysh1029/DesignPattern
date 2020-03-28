using System;
using System.Drawing;

namespace Builder
{

    /// <summary>
    /// 抽象的建造人的类
    /// </summary>
    public abstract class PersonBuilder
    {
        protected Graphics g;
        protected Pen p;

        public PersonBuilder(Graphics g, Pen p)
        {
            this.g = g;
            this.p = p;
        }

        public abstract void BuildHead();
        public abstract void BuildBody();

        public abstract void BuildArmLeft();

        public abstract void BuildArmRight();

        public abstract void BuildLegLeft();

        public abstract void BuildLegRight();

    }


    /// <summary>
    /// 建造瘦人子类  它必须实现抽象类的所有方法，这样就不会遗忘建造步骤了
    /// </summary>
    public class PersonThinBuilder : PersonBuilder
    {
        public PersonThinBuilder(Graphics g, Pen p) : base(g, p)
        {

        }

        public override void BuildHead(){
            g.DrawEllipse(p,50,20,30,30);
        }

        public override void BuildBody(){
            g.DrawRectangle(p,60,50,10,50);
        }

        public override void BuildArmLeft(){
            g.DrawLine(p,60,50,40,100);
        }

        public override void BuildArmRight(){
            g.DrawLine(p,70,50,90,100);
        }

        public override void BuildLegLeft(){
            g.DrawLine(p,60,100,45,150);
        }

        public override void BuildLegRight(){
            g.DrawLine(p,70,100,85,150);
        }

    }

    /// <summary>
    /// 建造胖人子类  它必须实现抽象类的所有方法，这样就不会遗忘建造步骤了
    /// </summary>
    public class PersonFatBuilder:PersonBuilder{
        public PersonFatBuilder(Graphics g, Pen p) : base(g, p)
        {

        }

        public override void BuildHead(){
            g.DrawEllipse(p,50,20,30,30);
        }

        public override void BuildBody(){
            g.DrawRectangle(p,45,50,40,50);
        }

        public override void BuildArmLeft(){
            g.DrawLine(p,50,50,30,100);
        }

        public override void BuildArmRight(){
            g.DrawLine(p,80,50,100,100);
        }

        public override void BuildLegLeft(){
            g.DrawLine(p,60,100,45,150);
        }

        public override void BuildLegRight(){
            g.DrawLine(p,70,100,85,150);
        }
    }

    /// <summary>
    /// 建造对象的指挥者
    /// </summary>
    public class PersonDirector{
        private PersonBuilder pb;

        /// <summary>
        /// 用户告诉指挥者，我需要什么样的小人
        /// </summary>
        /// <param name="pb"></param>
        public PersonDirector(PersonBuilder pb){
            this.pb= pb;
        }
        public void CreatePerson(){
            pb.BuildHead();
            pb.BuildBody();
            pb.BuildArmLeft();
            pb.BuildArmRight();
            pb.BuildLegLeft();
            pb.BuildLegRight();
        }
    }

}