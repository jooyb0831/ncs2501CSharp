public partial class Class2
{
    public void Run()
    {
        DoThis();
    }

    //조건1 : private only
    //조건2 : void return only
    private partial void DoThis();
}

public partial class Class2
{
    private partial void DoThis()
    {
        Console.WriteLine(DateTime.Now);
    }
}


partial class Class1
{
    public void Get()
    {

    }
}

partial class Class1()
{
    public void Put()
    {

    }
}

partial struct Struct1
{
    public string Name;
    public Struct1(int id, string name)
    {
        this.ID = id;
        this.Name = name;
    }
}

partial interface IDoable
{
    void Do();
}

public class DoClass : IDoable
{
    public string Name {get;set;}

    public void Do()
    {

    }
}
class NsSample
{
    public void Something()
    {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        sb.Append("this is");
        System.Console.WriteLine();
    }
}