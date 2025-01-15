using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;

class Solution
{
    /// <summary>
    /// 배열의 평균값
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public double solution0115 (int[] numbers)
    {
        
        double answer = 0;
        foreach(var item in numbers)
        {
            answer += (double)item;
        }
        answer /= numbers.Length;
        return answer;
        
        //계산하는 것 중 하나가 double 유형이면 double로 됨.
        /*
        for(int i =0; i<numbers.Length; i++)
        {
            answer+=numbers[i];
        }
        */

        //return numbers.Average();
        
    }

    /// <summary>
    /// 양꼬치 문제
    /// </summary>
    /// <param name="n"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public string solution01142(int n, int k)
    {
        int sum = 0;
        int ser = n/10;
        sum = n*12000+k*2000-ser*2000;
        string answer = sum.ToString("#,###")+"원";
        return answer;
    }
    /// <summary>
    /// 짝수의 합
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int solution0114(int n)
    {
        int answer = 0;
        for(int i =0; i<=n; i++)
        {
            if(i%2==0)
            {
                answer += i;
            }
        }
        return answer;
    }
    /// <summary>
    /// 숫자 비교하기
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int solution0113(int num1, int num2)
    {
        int answer = (num1 == num2) ? 1 : -1;
        return answer;
    }

    /// <summary>
    /// 태어난 연도 출력(나이)
    /// </summary>
    /// <param name="age">2022년의 나이</param>
    /// <returns>출생연도</returns>
    public int solution011002(int age)
    {
        int answer = 2022-age+1;
        return answer;
    }

    /// <summary>
    /// 나머지구하기
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int solution0110(int num1, int num2)
    {
        int answer = num1%num2;
        return answer;
    }

    /// <summary>
    /// 두 수의 차
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int solution0109(int num1, int num2)
    {
        return num1-num2;
    }

    /// <summary>
    /// 두 수의 곱
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int solution0108(int num1, int num2)
    {
        int answer = 0;
        answer = num1*num2;
        return answer;
    }
}