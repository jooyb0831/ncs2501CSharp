// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] intArray = new int[]{149,180,192,170};
        Solution sol = new Solution();
        string str = "Happy birthday!";
        Console.WriteLine(sol.solution0117(intArray, 167));
        Sample sam = new Sample();
        //Util util = new Util();
        // Util.PrintIntArray(sol.solution01162(intArray,1,3));
        //sam.Dictionary();
        
    }

}