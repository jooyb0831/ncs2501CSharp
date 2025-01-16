// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] intArray = new int[]{1,2,3,4,5};
        Solution sol = new Solution();
        string str = "Happy birthday!";
        //Console.WriteLine(sol.solution01162(intArray,0,2));
        Sample sam = new Sample();
        //Util util = new Util();
        Util.PrintIntArray(sol.solution01162(intArray,1,3));
        //sam.Queue_Stack()
        
    }

}