// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

//인터널:같은 어셈블리에서만 접근 가능.
internal class Program
{
    private static void Main(string[] args)
    {
        int[] intArray = new int[]{1,2,3,4,5};
        Solution sol = new Solution();
        string str = "Happy birthday!";
        //Console.WriteLine(sol.solution0121(intArray));
        Sample sam = new Sample();
        //sam.StringBuilderSample();
        Util util = new Util();
        Util.PrintIntArray(sol.solution0121(intArray));
        //Console.WriteLine();

        CSVar obj = new CSVar(); // var obj = new CSVar();
        //obj.Method1();
        
    }

}