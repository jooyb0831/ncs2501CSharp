// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Solution sol = new Solution();
        int num1 = 1;
        int num2 = 3;
        float temp = (float) num1/num2;
        float x = temp * 1000;
        int ans = (int)x;
        Console.WriteLine(ans);
    }

}