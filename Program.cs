// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

//인터널:같은 어셈블리에서만 접근 가능.
internal class Program
{
    private static void Main(string[] args)
    {
        int[] intArray = new int[]{1,2,3,4,5};
        string []s1 = new string[]{"a","b","c"};
        string []s2 = new string[]{"com","b","d","p","c"};
        Solution sol = new Solution();
        string str = "Happy birthday!";
        Console.WriteLine(sol.solution0122(s1,s2));
        Sample sam = new Sample();
        //sam.EnumSample();
        Util util = new Util();
        //Util.PrintIntArray(sol.solution0121(intArray));
        //Console.WriteLine();

        CSVar obj = new CSVar(); // var obj = new CSVar();
        //obj.Method1();
        
    }

}