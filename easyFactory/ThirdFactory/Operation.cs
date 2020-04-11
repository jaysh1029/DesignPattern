using System;
namespace easyFactory{

/// <summary>
/// 定义一个算法基类 这样每次增加或修改算法只用独立增加或修改就行了，
/// 这就增加了灵活性，方便扩展，维护，复用，
/// 但前端界面并不知道要是用哪个算法，这就需要一个简单工厂来帮助前端自动创建需要的算法实例，
/// 如果需要增加算法，只管增加新类，继承自基类即可，实现自己的算法，在工厂类中增加相应的前端对接即可
/// 如果需要修改某一个算法，单独去修改就行了，增加或修改都不会影响其他算法
/// </summary>
public class Operation{
    public double NumberA{get;set;}
    public double NumberB{get;set;}

    public virtual double GetResult(){
        double result = 0;
        return result;
    }
    
}


}