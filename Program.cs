// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(solution(27, 19));
    }

        public static int solution(int num1, int num2)
        {
        int answer = 0;
        answer = num1*num2;
        return answer;
    }
}