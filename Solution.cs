using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Text;


class Solution
{

    /// <summary>
    /// 모음제거
    /// </summary>
    /// <param name="my_string"></param>
    /// <returns></returns>
    public string Solution01272(string my_string)
    {
        return my_string.Replace("a","").Replace("e","").Replace("i","")
                        .Replace("o","").Replace("u","");
    }

    /// <summary>
    /// 배열 원소의 길이
    /// </summary>
    /// <param name="strList"></param>
    /// <returns></returns>
    public int[] Solution0127(string[] strList)
    {
        int len = strList.Length;
        int[] answer = new int[len];

        for(int i = 0; i<len; i++)
        {
            answer[i] = strList[i].Length;
        }
        return answer;
    }
    /// <summary>
    /// 문자열 뒤집기 2
    /// </summary>
    /// <param name="my_string"></param>
    /// <param name="s"></param>
    /// <param name="e"></param>
    /// <returns></returns>
    public string Solution01242(string my_string, int s, int e)
    {
       char [] charArray = my_string.ToCharArray();
       Array.Reverse(charArray,s,e-s+1);
       return new string(charArray);

    }

    /// <summary>
    /// 문자열 뒤집기 1
    /// </summary>
    /// <param name="my_string"></param>
    /// <returns></returns>
    public string Solution0124(string my_string)
    {
        string answer ="";
        /*
        for(int i = my_string.Length-1; i>=0; i--)
        {
            answer += my_string[i];
        }

        for(int i = 0; i<my_string.Length; i++)
        {
            answer = my_string[i] + answer;
        }

        foreach(var item in my_string)
        {
            answer = item + answer;
        }
        */
        StringBuilder sb = new StringBuilder();
        foreach(var item in my_string)
        {
            sb.Insert(0,item);
        }
        answer = sb.ToString();
        return answer;
    }
    /// <summary>
    /// 아이스 아메리카노
    /// </summary>
    /// <param name="money"></param>
    /// <returns></returns>
    public int[] Solution0123(int money)
    {
        const int COFFEE_PRICE = 5500;
        return new int[]{money / COFFEE_PRICE, money % COFFEE_PRICE};
    }
    
    /// <summary>
    /// 배열의 유사도
    /// </summary>
    /// <param name="s1"></param>
    /// <param name="s2"></param>
    /// <returns></returns>
    public int Solution0122(string[] s1, string[]s2)
    {
        int answer = 0;
        foreach(var item in s1)
        {
            foreach(var item1 in s2)
            {
                if(item.Equals(item1))
                {
                    answer++;
                }
            }
        }
        /*
        for(int i =0; i<s1.Length; i++)
        {
            for(int j = 0; j<s2.Length; j++)
            {
                if(s1[i].Equals(s2[j]))
                {
                    answer ++;
                }
            }
        }
        */
        return answer;
    }


    /// <summary>
    /// 배열 두배 만들기
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public int[] Solution0121(int[] numbers)
    {
        for(int i = 0; i<numbers.Length; i++)
        {
            numbers[i]*=2;
        }
        return numbers;
    }
    /// <summary>
    /// 피자 나눠먹기3
    /// </summary>
    /// <param name="slice"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Solution0120(int slice, int n)
    {
        int answer = 0;
        /*
        if(n%slice == 0)
        {
            answer = n/slice;
        }
        else
        {
            answer = (n/slice)+1;
        }
        */

        /*for
        for(int i =1; i<=n; i+=slice)
        {  
            answer ++;
        }
        */

        //while
        while(slice * answer <n)
        {
            answer ++;
        }
        return answer;
    }

    public int[] Solution01172(int[] num_list)
    {
        int[] answer = new int[2];
        foreach(var item in num_list)
        {
            if(item%2==0)
            {
                answer[0]++;
            }
            else
            {
                answer[1]++;
            }
        }
        return answer;
    }
    
    /// <summary>
    /// 머쓱이보다 키 큰 사람
    /// </summary>
    /// <param name="array"></param>
    /// <param name="height"></param>
    /// <returns></returns>
    public int Solution0117(int[] array, int height)
    {
        int answer = 0;
        foreach(var item in array)
        {
            if(height<item)
            {
                answer ++;
            }
        }
        /*
        for(int i = 0; i<array.Length; i++)
        {
            if(array[i]>height)
            {
                answer++;
            }
        }
        */
        return answer;
    }

    /// <summary>
    /// 배열 자르기
    /// </summary>
    /// <param name="numbers"></param>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int[] Solution01162(int[] numbers, int num1, int num2)
    {   
        int len = num2-num1+1;
        int[] answer = new int[len];
        for(int i = 0; i<len; i++)
        {
            answer[i] = numbers[num1+i];
        }
        return answer;
    }

    /// <summary>
    /// 편지
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public int Solution0116(string message)
    {
        return message.Length * 2;
    }


    /// <summary>
    /// 배열의 평균값
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public double Solution0115 (int[] numbers)
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
    public string Solution01142(int n, int k)
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
    public int Solution0114(int n)
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
    public int Solution0113(int num1, int num2)
    {
        int answer = (num1 == num2) ? 1 : -1;
        return answer;
    }

    /// <summary>
    /// 태어난 연도 출력(나이)
    /// </summary>
    /// <param name="age">2022년의 나이</param>
    /// <returns>출생연도</returns>
    public int Solution011002(int age)
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
    public int Solution0110(int num1, int num2)
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
    public int Solution0109(int num1, int num2)
    {
        return num1-num2;
    }

    /// <summary>
    /// 두 수의 곱
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int Solution0108(int num1, int num2)
    {
        int answer = 0;
        answer = num1*num2;
        return answer;
    }
}