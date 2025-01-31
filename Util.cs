using System.Collections.Generic;
using System.Diagnostics;

class Util
{
    /// <summary>
    /// 정수 배열의 내용을 출력
    /// </summary>
    /// <param name="intArray">출력할 배열</param>
    public static void PrintIntArray(int[] intArray)
    {
        Console.Write("{");
        for (int i = 0; i < intArray.Length; i++)
        {
            if (i!=0)
            {
                Console.Write(", ");
            }
            Console.Write(intArray[i]);
        }
        Console.WriteLine("}");
    }

    //Static으로 하면 따로 New로 생성하지 않고 써도 됨. 
    //Static의 경우에는 인스턴스화 할 수 없으며 클래스로 바로 접근해서 사용해야 함.
    /// <summary>
    /// 로또 만드는 함수
    /// </summary>
    public static void MakeLotto()
    {
        // 상수들
        const int MAX_NUMBER = 45;
        const int PICK_COUNT = 6;


        //뽑을 숫자(볼)를 담을 리스트
        var list = new List<int>();

        //C#에서는 랜덤을 사용하려면 미리 정의가 필요함.
        Random rand = new Random();

        int cnt = 0;
        //만족할 때까지
        while(cnt < PICK_COUNT)
        {
            //번호뽑기
            int pick = rand.Next(1,MAX_NUMBER+1);
            //비교하기
            if(!list.Contains(pick))
            {
                list.Add(pick);
                cnt++;
            }
        }

        //정렬
        list.Sort();

        //화면에 출력
        Console.Write("이번 주 로또 당첨 번호는 {");
        foreach(var item in list)
        {
            Console.Write($"{item}, ");
        }
        Console.WriteLine("} 입니다.");
    }
}