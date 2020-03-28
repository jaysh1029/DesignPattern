using System;
namespace prototype{

    public abstract class Prototype{
        private string id;
        public Prototype(string id){
            this.id = id;
        }
        public string Id{
            get{return id;}
        }
        public abstract Prototype Clone();
    }

    public class ConcretePrototype1:Prototype{
        public ConcretePrototype1(string id):base(id){

        }
        public override Prototype Clone(){
            return (Prototype)this.MemberwiseClone();
        }
    }

    public class WorkExperience:ICloneable{
        public string WorkDate{get;set;}

        public string Company{get;set;}

        public Object Clone(){
            return this.MemberwiseClone();
        }
    }

    public class Resume:ICloneable{
        private string name;
        private string sex;        
        private string age;

        private WorkExperience work;

        public Resume(string name){
            this.name = name;
            work = new WorkExperience();
        }

        private Resume(WorkExperience work){
            this.work = (WorkExperience)work.Clone();
        }

        public void SetPersonalInfo(string sex,string age){
            this.sex = sex;
            this.age  =age;
        }

        public void SetWorkExperience(string workDate,string company){
            work.WorkDate  = workDate;
            work.Company = company;
        }

        public void Display(){
            Console.WriteLine("{0} {1} {2}",name,sex,age);
            Console.WriteLine("工作经历：{0} {1}",work.WorkDate,work.Company);
            
        }

        public Object Clone(){
            
            /* 
            //第一种方法
            Resume obj = new Resume(this.work);
            obj.name = this.name;
            obj.age = this.age;
            obj.sex = this.sex; */

            //第二种方法：
            Resume  obj = (Resume)this.MemberwiseClone();
            obj.work = (WorkExperience)this.work.Clone();
            return obj;
        }
    }


}