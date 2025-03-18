using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections;
using System.Security.Cryptography;
using System.Buffers;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;


class Solution
{
    /// <summary>
    /// 7의 개수
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public int Solution0318(int[] array)
    {
        int answer = 0;
        StringBuilder sb = new StringBuilder();
        foreach (var item in array)
        {
            sb.Append(item);
        }
        string str = sb.ToString();

        //foreach 사용
        foreach(var item in str)
        {
            if(item == '7')
            {
                answer ++;
            }
        }

        //Regex사용 8.0
        //answer = Regex.Count(str,"7");
        /*
        str = Regex.Replace(str, "[1-6890]","" );
        answer = str.Length;
        */
        return answer;
    }

    /// <summary>
    /// 잘라서 배열로 저장하기
    /// </summary>
    /// <param name="my_str"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public string[] Solution0317(string my_str, int n)
    {
        int len = 0; // len = (my_str.Length -1 ) / n+1
        if (my_str.Length % n == 0)
        {
            len = my_str.Length / n;
        }
        else
        {
            len = (my_str.Length / n) + 1;
        }
        string[] answer = new string[len];

        int idx = 0, cnt = 0;

        foreach (var item in my_str)
        {
            answer[idx] += item;
            cnt++;
            if (cnt == n)
            {
                idx++;
                cnt = 0;
            }
        }
        /*
        int idx = 0
        for (int i = 0; i < my_str.Length; i++)
        {
            if (i != 0 && i % n == 0)
            {
                idx++;
            }
            answer[idx] += my_str[i];
        }
        */
        return answer;

    }

    /// <summary>
    /// 한 번만 등장한 문자
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public string Solution0314(string s)
    {
        string answer = string.Empty;

        for (char c = 'a'; c <= 'z'; c++)
        {
            if (s.Split(c).Length == 2)
            {
                answer += c;
            }
        }
        return answer;
        /*
        string answer = "";

        Dictionary<char, int> dic = new Dictionary<char, int>();

        foreach (var item in s)
        {
            if (dic.ContainsKey(item))
            {
                dic[item]++;
            }
            else
            {
                dic.Add(item, 1);
            }
        }

        List<char> list = new List<char>();
        foreach (var item in dic)
        {
            if (item.Value == 1)
            {
                list.Add(item.Key);
            }
        }
        list.Sort();
        foreach (var item in list)
        {
            answer += item;
        }
        return answer;
        */
    }


    /// <summary>
    /// 숨어있는 숫자의 덧셈2
    /// </summary>
    /// <param name="my_string"></param>
    /// <returns></returns>
    public int Solution03131(string my_string)
    {
        int answer = 0;
        string tmp = "0";
        foreach (var item in my_string)
        {
            if (item >= '0' && item <= '9')
            {
                tmp += item;
            }
            else
            {
                answer += int.Parse(tmp);
                tmp = "0";
            }
        }
        answer += int.Parse(tmp);
        return answer;
        /*
        bool isNumber = false;
        int val = 0;
        foreach(var item in my_string)
        {
            if (item >= '1' && item <= '9')
            {
                if (isNumber)
                {
                    val = val * 10 + item - '0';
                }
                else
                {
                    val = item - '0';
                    isNumber = true;
                }
            }
            else
            {
                isNumber = false;
                answer += val;
                val = 0;
            }

        }
        */
    }
    
    /// <summary>
    /// 숨어있는 숫자의 덧셈1
    /// </summary>
    /// <param name="my_string"></param>
    /// <returns></returns>
    public int Solution0313(string my_string)
    {
        int answer = 0;
        foreach(char item in my_string)
        {
            if (item >= '1' && item <= '9')
            {
                answer += (int)item - '0';
            }
        }
        return answer;
    }
    /// <summary>
    /// 진료순서 정하기
    /// </summary>
    /// <param name="emergency"></param>
    /// <returns></returns>
    public int[] Solution0312(int[] emergency)
    {
        int[] answer = new int[emergency.Length];
        List<int> list = new List<int>(emergency);
        list.Sort();
        list.Reverse();

        for (int i = 0; i < list.Count; i++)
        {
            answer[i] = list.IndexOf(emergency[i]) + 1;
        }

        return answer;
    }

    /// <summary>
    /// 중복된 문자 제거
    /// </summary>
    /// <param name="my_string"></param>
    /// <returns></returns>
    public string Solution0311(string my_string)
    {
        string answer = "";

        foreach(var item in my_string)
        {
            if(!answer.Contains(item))
            {
                answer += item;
            }
        }
        return answer;

#region HashSet활용
        /*
        HashSet<char> set = new HashSet<char>();
        foreach(var item in my_string)
        {
            if(set.Add(item))
            {
                answer += item;
            }
        }
        */
#endregion
        
    }


    /// <summary>
    /// 피자 나눠먹기2
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Solution0310(int n)
    {
        int answer = 0;
        do
        {
            answer++;
        } while (answer * 6 % n != 0);
        return answer;
#region OtherSolutions        
        /*
        int answer = 1;
        for (int i = answer; i <= 6 * answer; i++)
        {
            if ((answer * 6) % n == 0)
            {
                break;
            }
            answer++;
        }
        */
        /*
        int answer = 1;
        while (answer * 6 % n !=0)
        {
            answer ++;
        }
        return answer;
        */
#endregion
    }

    /// <summary>
    /// 정수 부분
    /// </summary>
    /// <param name="flo"></param>
    /// <returns></returns>
    public int Solution03071(double flo)
    {
        //return (int)flo;

        //복잡한 방법
        string str = flo.ToString();
        string[] strarr = str.Split(".");
        return int.Parse(strarr[0]); //Convert.ToInt32(strarr[0]);
    }


    /// <summary>
    /// 2차원 배열 대각선 순회하기
    /// </summary>
    /// <param name="board"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int Solution0307 (int[,] board, int k)
    {
        int answer = 0;
        int len1 = board.GetLength(0);
        int len2 = board.GetLength(1);

        for (int i = 0; i < len1; i++)
        {
            for (int j = 0; j < len2; j++)
            {
                if (i + j <= k)
                {
                    answer += board[i, j];
                }
            }
        }
        return answer;
    }

    /// <summary>
    /// 할 일 목록
    /// </summary>
    /// <param name="todo_list"></param>
    /// <param name="finished"></param>
    /// <returns></returns>
    public string[] Solution0306 (string[] todo_list, bool[] finished)
    {
        int len = 0;
        foreach(var item in finished)
        {
            if(!item) len++;
        }
        string[] answer = new string[len];
        int cnt = 0;
        for(int i = 0; i<finished.Length; i++)
        {
            if(!finished[i])
            {
                answer[cnt] = todo_list[i];
                cnt++;
            }
        }
        return answer;

        /*
        List<string> answer = new List<string>();
        for(int i = 0; i < finished.Length; i++)
        {
            if(!finished[i])
            {
                answer.Add(todo_list[i]);
            }
        }
        return answer.ToArray();
        */
        /*
        Dictionary<string, bool> dic = new Dictionary<string, bool>();
        List<string> answer = new List<string>();
        for (int i = 0; i < finished.Length; i++)
        {
            dic.Add(todo_list[i], finished[i]);
        }

        foreach (var item in dic)
        {
            if (item.Value == false)
            {
                answer.Add(item.Key);
            }
        }
        return answer.ToArray();
        */
    }

    /// <summary>
    /// 인덱스 바꾸기
    /// </summary>
    /// <param name="my_string"></param>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public string Solution0305(string my_string, int num1, int num2)
    {
        string ans = "";
        char char1 = my_string[num1];
        char char2 = my_string[num2];
        for(int i = 0; i < my_string.Length; i++)
        {
            if(i == num1)
            {
                ans += char2;
            }
            else if(i==num2)
            {
                ans += char1;
            }
            else
            {
            ans += my_string[i];
            }
        }
        return ans;
        /*
        string answer = "";
        
        List<char>my_char = new List<char>();
        foreach(var item in my_string)
        {
            my_char.Add(item);
        }
        char temp = my_char[num1];
        my_char[num1] = my_char[num2];
        my_char[num2] = temp;
        
        for(int i=0; i<my_char.Count; i++)
        {
            answer+=my_char[i];
        }
        return answer;
        */
    }

    /// <summary>
    /// 외계행성의 나이
    /// </summary>
    /// <param name="age"></param>
    /// <returns></returns>
    public string Solution0304(int age)
    {
        string answer = string.Empty;
        while(age>0)
        {
            int val = age % 10;
            char chr = Convert.ToChar(val + 'a');
            answer = chr + answer;
            age /= 10;
        }
        return answer;
    }
    /// <summary>
    /// 가장 큰 수 찾기
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public int[] Solution02281(int[] array)
    {
        int[] answer = new int[2];
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for(int i = 0; i < array.Length; i++)
        {
            dic.Add(array[i], i);
        }

        List<int> list = array.ToList();
        list.Sort();
        int maxNum = list[list.Count-1];
        int index = dic[maxNum];
        answer[0] = maxNum;
        answer[1] = index;
        return answer;
        /*
        int maxNum = array.Max();
        int index = Array.IndexOf(array, maxNum);
        int[] answer = [maxNum, index];
        return answer;
        */
    }

    /// <summary>
    /// 가까운 1 찾기
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="idx"></param>
    /// <returns></returns>
    public int Solution0228(int[] arr, int idx)
    {
        int ans = -1;

        for(int i = idx; i<arr.Length; i++)
        {
            if(arr[i] == 1)
            {
                ans = i;
                break;
            }
        }
        return ans;
    }

    /// <summary>
    /// 369게임
    /// </summary>
    /// <param name="order"></param>
    /// <returns></returns>
    public int Solution0227(int order)
    {
        int answer = 0;
        string str = order.ToString();
        foreach (var item in str)
        {
            if (item.Equals('3') || item.Equals('6') || item.Equals('9'))
            {
                answer++;
            }
        }
        return answer;
    }

    /// <summary>
    /// 간단한 식 계산하기
    /// </summary>
    /// <param name="binomial"></param>
    /// <returns></returns>
    public int Solution0226(string binomial)
    {
        string[] temp = binomial.Split(" ");
        int a = int.Parse(temp[0]);
        int b = int.Parse(temp[2]);
        string op = temp[1];

        switch(op)
        {
            case "+":
                return a + b;
            case "-":
                return a - b;
            case "*":
                return a * b;
            default:
                return 0;
        }
    }
    /// <summary>
    /// 약수 구하기
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int[] Solution0224(int n)
    {
        List<int> temp = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                temp.Add(i);
            }
        }
        return temp.ToArray();
    }

    /// <summary>
    /// 9로 나눈 나머지
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public int Solution0221(string number)
    {
        int answer = 0;
        foreach(var item in number)
        {
            //item의 정수값 더해줌
            answer += (item - '0'); //0(아스키코드값)으로부터 얼만큼 떨어져 있는지를 더하면 됨.
        }
        return answer % 9;
        /*
        int answer = 0;
        foreach (var item in number)
        {
            answer += int.Parse(item.ToString());
        }
        return answer % 9;
        */
    }

    /// <summary>
    /// 삼각형의 완성조건2
    /// </summary>
    /// <param name="sides"></param>
    /// <returns></returns>
    public int Solution02201(int[] sides)
    {
        int answer = 0;
        int maxSide = sides.Max();
        int minSide = sides.Min();

        for(int i = 1; i <= maxSide; i++)
        {
            if(maxSide < i + minSide)
            {
                answer ++;
            }
        }

        for (int i = maxSide + 1; i < maxSide + minSide; i++)
        {
            answer ++;
        }

        return answer;
    }
    /// <summary>
    /// 삼각형의 완성조건1
    /// </summary>
    /// <param name="sides"></param>
    /// <returns></returns>
    public int Solution0220(int[] sides)
    {
        Array.Sort(sides);
        if(sides[2] < sides[0] + sides[1])
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }
    /// <summary>
    /// 최댓값 만들기2
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public int Solution02191(int[] numbers)
    {
        int answer = int.MinValue;
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (answer < numbers[i] * numbers[j])
                {
                    answer = numbers[i] * numbers[j];
                }
            }
        }
        return answer;
    }

    /// <summary>
    /// 최댓값 만들기 1
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public int Solution0219(int[] numbers)
    {
        int answer = 0;
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for(int j = i+1; j<numbers.Length; j++)
            {
                if(answer<numbers[i] * numbers[j])
                {
                    answer = numbers[i] * numbers[j];
                }
            }
        }
        return answer;

        /*
        Array.Sort(numbers);
        int len = numbers.Length;
        return numbers[len-1] * numbers[len-2];
        */
    }
    /// <summary>
    /// 5명씩
    /// </summary>
    /// <param name="names"></param>
    /// <returns></returns>
    public string[] Solution0218(string[] names)
    {
        List<string> nameList = new List<string>();
        for (int i = 0; i < names.Length; i++)
        {
            if (i % 5 == 0)
            {
                nameList.Add(names[i]);
            }
            else
            {
                continue;
            }
        }
        return nameList.ToArray();
    }

    /// <summary>
    /// 콜라츠 수열 만들기
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int[] Solution0217(int n)
    {
        List<int> numList = new List<int>();
        numList.Add(n);

        while (n != 1)
        {
            if (n % 2 == 0)
            {
                n /= 2;
            }
            else
            {
                n = 3 * n + 1;
            }
            //n = (n % 2 == 0) ? (n / 2) : (3 * n + 1);
            numList.Add(n);
        }
        return numList.ToArray();
    }
    /// <summary>
    /// 세균 증식
    /// </summary>
    /// <param name="n"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    public int Solution0214(int n, int t)
    {
        //return n * (int) Math.Pow(2,t);
        return n<<t;
        /*
        for (int i = 0; i < t; i++)
        {
            n *= 2;
        }
        return n;*/
    }

    /// <summary>
    /// 배열의 원소만큼 추가하기
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public int[] Solution0213(int[] arr)
    {
        var listX = new List<int>();

        foreach (var item in arr)
        {
            for (int i = 0; i < item; i++)
            {
                listX.Add(item);
            }
        }
        return listX.ToArray();
    }

    public int Solution012121(int a, int b)
    {
        int answer = 0;
        switch (a % 2)
        {
            case 1:
                {
                    switch (b % 2)
                    {
                        case 1:
                            answer = a * a + b * b;
                            break;

                        case 0:
                            answer = 2 * (a + b);
                            break;
                    }
                    break;
                }
            case 0:
                {
                    switch (b % 2)
                    {
                        case 1:
                            answer = 2 * (a + b);
                            break;

                        case 0:
                            answer = Math.Abs(a - b);
                            break;
                    }
                    break;

                }

        }
        return answer;
    }
    /// <summary>
    /// 뒤에서 5등 위로
    /// </summary>
    /// <param name="num_list"></param>
    /// <returns></returns>
    public int[] Solution0212(int[] num_list)
    {
        //List<int> list = num_list.ToList();
        var list = new List<int>(num_list);
        list.Sort();
        for (int i = 0; i < 5; i++)
        {
            list.RemoveAt(0);
        }
        /*
        int cnt = 0;
        while(cnt<5)
        {
            list.RemoveAt(0);
            cnt++;
        }
        */
        return list.ToArray();
    }

    /// <summary>
    /// 짝수는 싫어요
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int[] Solution02111(int n)
    {
        var oddList = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 != 0)
            {
                oddList.Add(i);
            }
        }
        return oddList.ToArray();
    }

    /// <summary>
    /// 0 떼기
    /// </summary>
    /// <param name="n_str"></param>
    /// <returns></returns>
    public string Solution0211(string n_str)
    {
        /*
        string answer = "";
        for(int i = 0; i<n_str.Length; i++)
        {
            if(n_str[i]!='0')
            {
                answer = n_str.Substring(i);
                break;
            }
        }
        return answer;

        bool zero = true;
        while(zero)
        {
            //현재 맨 앞에 문자가 0인지 판별
            if(n_str[0].CompareTo('0') == 0) //Compare : 두 값의 차이가 얼마인지 알려줌.
            {
                n_str = n_str.Substring(1);
            }
            else
            {
                zero = false;
            }
        }
        */
        //Convert.ToInt32(n_str).ToString();
        return int.Parse(n_str).ToString();
    }
    /// <summary>
    /// 자릿수 더하기
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Solution02101(int n)
    {
        int answer = 0;
        string str = n.ToString();
        foreach (var item in str)
        {
            answer += (item - '0');
        }
        return answer;
        /*
        while(n > 0)
        {
            answer += n % 10;
            n /= 10;
        }
        */
    }
    /// <summary>
    /// 주사위 개수
    /// </summary>
    /// <param name="box"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Solution0210(int[] box, int n)
    {
        int answer = 1;
        foreach (var item in box)
        {
            answer *= item / n;
        }
        return answer;

        //return (box[0] / n) * (box[1] / n) * (box[2] / n);
    }

    /// <summary>
    /// 짝수 홀수의 합
    /// </summary>
    public int Solution0207(int[] num_list)
    {

        int evenSum = 0;
        int oddSum = 0;

        for (int i = 0; i < num_list.Length; i++)
        {
            if (i % 2 == 0)
            {
                evenSum += num_list[i];
            }
            else
            {
                oddSum += num_list[i];
            }

        }

        bool isEven = true;
        foreach (var item in num_list)
        {
            if (isEven)
            {
                evenSum += item;
            }
            else
            {
                oddSum += item;
            }
            isEven = !isEven;
        }
        return Math.Max(evenSum, oddSum);
    }

    /// <summary>
    /// 카운트 업
    /// </summary>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <returns></returns>
    public int[] Solution0206(int start, int end)
    {
        int len = end - start + 1;
        int[] answer = new int[len];
        for (int i = 0; i < len; i++)
        {
            answer[i] = start + i;
        }
        return answer;
    }

    /// <summary>
    /// 두 수의 연산값 비교하기
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int Solution0205(int a, int b)
    {
        /*
        StringBuilder str = new StringBuilder();
        str.Append($"{a}");
        str.Append($"{b}");
        string temp = ""+a+b;
        */
        int val1 = int.Parse($"{a}{b}");
        int val2 = 2 * a * b;

        return Math.Max(val1, val2);
        //return (val1 >= val2) ? val1 : val2;

    }

    /// <summary>
    /// 수 조작하기 2
    /// </summary>
    /// <param name="numLog"></param>
    /// <returns></returns>
    public string Solution02042(int[] numLog)
    {
        StringBuilder answer = new StringBuilder();
        for (int i = 0; i < numLog.Length - 1; i++)
        {
            int minus = numLog[i + 1] - numLog[i];
            switch (minus)
            {
                case 1:
                    answer.Append('w');
                    break;
                case -1:
                    answer.Append('s');
                    break;
                case 10:
                    answer.Append('d');
                    break;
                case -10:
                    answer.Append('a');
                    break;
                default:
                    break;
            }
        }
        return answer.ToString();
    }

    /// <summary>
    /// 수 조작하기1
    /// </summary>
    /// <param name="n"></param>
    /// <param name="control"></param>
    /// <returns></returns>
    public int Solution0204(int n, string control)
    {
        foreach (var item in control)
        {
            switch (item)
            {
                case 'w':
                    n++;
                    break;
                case 's':
                    n--;
                    break;
                case 'd':
                    n += 10;
                    break;
                case 'a':
                    n -= 10;
                    break;
                default:
                    break;
            }
        }
        return n;
    }

    /// <summary>
    /// 첫 번째로 나오는 음수
    /// </summary>
    /// <param name="num_list"></param>
    /// <returns></returns>
    public int Solution0203(int[] num_list)
    {
        for (int i = 0; i < num_list.Length; i++)
        {
            if (num_list[i] < 0)
            {
                return i;
            }
        }
        return -1;
    }

    /// <summary>
    /// 피자 나눠먹기1
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Solution01312(int n)
    {
        int answer = 0;
        //온전한 피자 한 판으로 먹을 수 있는 사람 수
        int piz = n / 7;

        //나머지 피자 조각 먹는 사람 수
        int res = ((n % 7) == 0) ? 0 : 1;

        answer = piz + res;
        return answer;
    }

    /// <summary>
    /// 배열 뒤집기
    /// </summary>
    /// <param name="num_list"></param>
    /// <returns></returns>
    public int[] Solution0131(int[] num_list)
    {
        int len = num_list.Length;
        int[] answer = new int[len];
        for (int i = 0; i < len; i++)
        {
            answer[i] = num_list[len - i - 1];
        }
        // Array.Reverse(num_list);
        return answer;
    }

    /// <summary>
    /// 모음제거
    /// </summary>
    /// <param name="my_string"></param>
    /// <returns></returns>
    public string Solution01272(string my_string)
    {
        return my_string.Replace("a", "").Replace("e", "").Replace("i", "")
                        .Replace("o", "").Replace("u", "");
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

        for (int i = 0; i < len; i++)
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
        char[] charArray = my_string.ToCharArray();
        Array.Reverse(charArray, s, e - s + 1);
        return new string(charArray);

    }

    /// <summary>
    /// 문자열 뒤집기 1
    /// </summary>
    /// <param name="my_string"></param>
    /// <returns></returns>
    public string Solution0124(string my_string)
    {
        string answer = "";
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
        foreach (var item in my_string)
        {
            sb.Insert(0, item);
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
        return new int[] { money / COFFEE_PRICE, money % COFFEE_PRICE };
    }

    /// <summary>
    /// 배열의 유사도
    /// </summary>
    /// <param name="s1"></param>
    /// <param name="s2"></param>
    /// <returns></returns>
    public int Solution0122(string[] s1, string[] s2)
    {
        int answer = 0;
        foreach (var item in s1)
        {
            foreach (var item1 in s2)
            {
                if (item.Equals(item1))
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
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] *= 2;
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
        while (slice * answer < n)
        {
            answer++;
        }
        return answer;
    }

    public int[] Solution01172(int[] num_list)
    {
        int[] answer = new int[2];
        foreach (var item in num_list)
        {
            if (item % 2 == 0)
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
        foreach (var item in array)
        {
            if (height < item)
            {
                answer++;
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
        int len = num2 - num1 + 1;
        int[] answer = new int[len];
        for (int i = 0; i < len; i++)
        {
            answer[i] = numbers[num1 + i];
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
    public double Solution0115(int[] numbers)
    {

        double answer = 0;
        foreach (var item in numbers)
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
        int ser = n / 10;
        sum = n * 12000 + k * 2000 - ser * 2000;
        string answer = sum.ToString("#,###") + "원";
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
        for (int i = 0; i <= n; i++)
        {
            if (i % 2 == 0)
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
        int answer = 2022 - age + 1;
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
        int answer = num1 % num2;
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
        return num1 - num2;
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
        answer = num1 * num2;
        return answer;
    }
}