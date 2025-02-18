//Base Class
using System.Drawing;

public class Animal
{
    public string Name{ get; set; }
    public int Age{ get; set; }
    protected float size = 10.2f;
    public void ShowSize()
    {
        Console.WriteLine($"{Name} size is {size}");
    }
    public void SetSize(float size)
    {
        this.size = size;
        Console.WriteLine($"{Name}size : {size}");
    }
}

//Child Class

public class Dog : Animal
{
    
    public void HowOld()
    {
        base.size = 5f; //그냥 size써도 상관 없는 것 같음.
        Console.WriteLine($"BaseSize : {base.size}");
        Console.WriteLine($"나이 : {this.Age}");
        Console.WriteLine(size);
    }

    public new void ShowSize() // 이미 부모 객체에 똑같은 이름의 매서드가 있으면 new를 붙여야 함
    {

    }
}

public class Bird : Animal
{
    public void Fly()
    {
        Console.WriteLine($"{this.Name}가 날다");
    }
}

public class NewSpecies : Dog
{

}

public abstract class PureBase()
{
    public abstract int GetFirst();
    public abstract int GetNext();
}

public class ChildA : PureBase
{
    private int num = 1;
    public override int GetFirst()
    {
        return num;
    }

    public override int GetNext()
    {
        return num++;
    }
}

public class MyBase
{
    public void Test(object obj)
    {
        //as 연산자
        MyBase a = obj as MyBase; //있으면 넘겨주고 없으면 null값을 받는다.

        //is 연산자
        bool ok = obj is MyBase; //true;

        //Explicit casting
        MyBase b = (MyBase)obj;
    }

    


    

}