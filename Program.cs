// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Reflection.Metadata;
using MySystem;

//인터널:같은 어셈블리에서만 접근 가능.
internal class Program
{
    private static void Main(string[] args)
    {
        int[] intArray = new int[]{1,2,3,4,5};
        string []s1 = new string[]{"a","b","c"};
        string []s2 = new string[]{"com","b","d","p","c"};
        string []temp = new string[]{"nami", "ahri", "jayce", "garen", "ivern", "vex", "jinx"};
        Solution sol = new Solution();
        string str = "Happy birthday!";
        //Console.WriteLine(sol.solution0123(5500));
        Sample sam = new Sample();
        Util util = new Util();
        MySort sort = new MySort();
        sort.Run();
        string changed = str.ToChangeCase(); 
        bool check = str.Found('x');
        
        Console.WriteLine($"{changed}, {check}");

        /*

        CSVar obj = new CSVar(); // var obj = new CSVar();
        obj.Method1();

        
        MyCustomer myc = new MyCustomer(55);

        //필드를 퍼블릭으로 하면 위험.
        myc.YearMoney = 77;
        myc.PrintYearMoney();

        Console.WriteLine($"{myc.Temp}");

        Program p = new Program();
        int val = 100;
        sam.Calculator(100);

        //ref 사용. 초기화 필요
        int x = 1;
        double y = 1.0;
        double ret = GetData(ref x, ref y);

        //out 사용, 초기화 불필요
        int c, d;
        bool bret = GetData (10,20,out c, out d);
        */

       
    }

    private static void ClassTest()
    {
        Animal anima = new Animal();
        anima.Age = 30;
        anima.Name = "anim";

        Dog dog = new Dog();
        dog.Age = 3;
        dog.Name = "puppy";
        dog.HowOld();
        dog.SetSize(1.5f);

        Bird bird = new Bird();
        bird.Age = 4;
        bird.Name = "eagle";
        bird.Fly();

        ChildA cha = new ChildA();
        cha.GetFirst();
        cha.GetNext();

        NewSpecies np = new NewSpecies();
        np.SetSize(1.5f);
        
    }
    /*
    private static void IndexerSample()
    {
        //인덱서
        MyClass cls = new MyClass();
        cls.SetName("KIM");
        cls[1] = 1024;
        int i = cls[1];
        int ii = cls["KIM"];
        cls["LEE"] = 3;
    }
    */

    static double GetData(ref int a, ref double b)
    {
        return ++a * ++b;
    }

    static bool GetData(int a, int b, out int c, out int d)
    {
        c = a+b;
        d = a - b;
        return true;
    }

}