using System;
namespace ProxyModel{
interface IGiveGift
{
    void GiveDolls();
    void GiveFlowers();
    void GiveChocolate();
}

public class SchoolGirl{
    private string name;

    public string Name{
        get{return name;}
        set{name =value;}
    }
}

public class Pursuit:IGiveGift{
    
    SchoolGirl mm;
    public Pursuit(SchoolGirl mm){
        this.mm = mm;
    }

    public void GiveDolls(){
        Console.WriteLine(mm.Name+" 送你洋娃娃");
    }

    public void GiveFlowers(){
        Console.WriteLine(mm.Name + " 送你鲜花");
    }

    public void GiveChocolate(){
        Console.WriteLine(mm.Name + " 送你巧克力");
    }
}

public class ProxyPursuit:IGiveGift{
    Pursuit gg;

    public ProxyPursuit(SchoolGirl mm){
        gg = new Pursuit(mm);
    }

    public void GiveDolls(){
        gg.GiveDolls();
    }

    public void GiveFlowers(){
        gg.GiveFlowers();
    }

    public void GiveChocolate(){
        gg.GiveChocolate();
    }
}


}

