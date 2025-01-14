using System.Diagnostics;
using System.Globalization;

class Sample
{
    public void Array()
    {
        #region 배열
        //1차원 배열
        //배열 크기 변환 가능하나 권장하지 않음(기존 크기의 배열 버리고 새로운 크기의 배열 새로 생성하기 때문)
        string[] players = new string[10];
        int[] intArray = new int[100];
        int[] abc = new int[3] { 1, 2, 3 }; //이 버전을 권장
        int[] abc3 = [1, 2, 3]; //버전에 따라 에러날 수 있음
        int[] abc2 = { 1, 2, 3 };

        char[] charArray = new char[7];

        string[] Regions = { "서울", "경기", "부산" };

        //2차원 배열
        string[,] Depts1 = new string[2, 2];
        Console.WriteLine($"Depts1.Length : {Depts1.Length}");
        int[,] intArray2 = new int[3, 2] { { 1, 3 }, { 1, 2 }, { 0, 1 } };
        string[,] Depts2 = { { "김과장", "경리부" }, { "이과장", "총무부" } };
        Console.WriteLine($"intArray2.Length : {intArray2.Length}");

        //3차원 배열
        string[,,] Cubes = new string[,,] { { }, { }, { } };
        int[,,] intArray3 = new int[2, 3, 4];
        Console.WriteLine("intArray.Length:"+intArray3.Length);

        //다차원 배열에서 각 차원별 배열 요소 크기가 동일한 Rectangular 배열은 [,]로 표현.
        //가변 배열 : [][]와 같이 각 차원마다 괄호를 별도로 사용
        //정수의 배열을 배열로 만든 것 : 2차원 배열과 동일한 구조. 그러나 차원별 배열 크기가 동일하다면 2차원 배열[,]권장.
        int[][] ii = new int[2][];

        //차원별 배열 크기가 다를 경우에 사용.
        int[][] A = new int[3][];
        A[0] = new int[2];
        A[1] = new int[3] { 1, 2, 3 };
        A[2] = new int[4] { 1, 2, 3, 4 };

        A[0][0] = 1;
        A[0][1] = 2;

        int[][] i1 = new int[2][];
        int[][] ii2 = new int[3][];
        ii2[0] = new int[2] { 1, 2 };
        ii2[1] = new int[2] { 2, 3 };

        #endregion

        int sum = 0;
        int[] scores = new int[]{80,78,60,90,100};
        for(int i =0; i<scores.Length; i++)
        {
            /*
            sum+=scores[i];
            sum -= scores[i];
            sum *= scores[i];
            sum /= scores[i];
            */
            sum += scores[i];
        }
        
        Console.WriteLine("sum : "+sum);
        int[] ss = new int[100];
        ss[0] = 90;
        int val = scores[0];

       
    }

    public void RandomSum()
    {
        //Random
        int[] nums = new int[10];
        int sum = 0;

        Random rand = new Random();
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = rand.Next() % 100;
            Console.WriteLine($"nums[{i}]:{nums[i]}");
        }
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        Console.WriteLine(sum);
    }

    void DataType()
    {
        //Bool
        bool b = true;

        //Numeric
        short sh = -32768;
        int i = 2147483647;
        long l = 1234L;
        float f = 123.45f;
        double d1 = 123.45;
        double d2 = 123.45d;
        decimal d = 123.45m;

        //char/string
        char c = 'a';
        string s = "hello";

        if (s[1] == 'e')
        {
            b = true;
        }
        else
        {
            b = false;
        }

        //dateTime;
        DateTime dt = new DateTime(2025, 01, 13, 10, 20, 0);

        //max, min
        int i2 = 0;
        if(i2>int.MaxValue)
        {
            
        }

        //기억해야 하는 데이터 타입
        bool boolean = false;
        int i3 = 0;
        float f3 = 1.2f;
        char c1 = 'a';
        string str = "HelloWorld";



    }
}