using System;
namespace factorymode
{

    public class LeiFeng
    {
        public void Sweep()
        {
            Console.WriteLine("扫地");
        }

        public void Wash()
        {
            Console.WriteLine("洗衣");
        }
        public void BuyRice()
        {
            Console.WriteLine("买米");
        }
    }

    public class Undergraduate : LeiFeng { }
    public class Volunteer : LeiFeng { }

    public class SimpleFactory
    {
        public static LeiFeng CreateLeiFeng(string type)
        {
            LeiFeng result = null;
            switch (type)
            {
                case "学雷锋的大学生":
                    result = new Undergraduate();
                    break;
                case "社区志愿者":
                    result = new Volunteer();
                    break;
            }

            return result;
        }
    }


    interface ILeiFengFactory{
        LeiFeng CreateLeiFeng();
    }

    public class UndergraduateFactory:ILeiFengFactory{
        public LeiFeng CreateLeiFeng(){
            return new Undergraduate();
        }
    }

    public class VolunteerFactory:ILeiFengFactory{
        public LeiFeng  CreateLeiFeng(){
            return new Volunteer();
        }
    }



}