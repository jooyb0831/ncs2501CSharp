public class Parent
{
    public int num;
    public Parent()
    {
        Console.WriteLine("부모 클래스의 생성자가 호출되었습니다.");
    }
}

class Child : Parent
{
    int num;
    public Child(int num)
    {
        this.num = num;
        Console.WriteLine($"Child num : {this.num}");
        Console.WriteLine($"Parent num ; {base.num}");
        Console.WriteLine("자식 클래스의 생성자가 호출되었습니다.");
    }

    private string name = "John";
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (value.Length < 5)
            {
                name = value;
            }
        }
    }
}

class Inheritance
{

}