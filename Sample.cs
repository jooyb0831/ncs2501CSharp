using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Loader;
using System.Security.Cryptography.X509Certificates;
using System.Text;

class Sample
{

    static bool verbose = false;
    static bool continueOnError = false;
    static bool logging = false;
    
    public void DoWhileSample()
    {
        int i = 100;
        do
        {
            Console.Write($" {i}");
            i++;
        }while(i<10); // 한 번은 무조건 찍힘.

        Console.WriteLine();
        i=100;
        Console.Write("while");

        while(i<10)
        {
            Console.Write($" {i}");
            i++;
        }
        Console.WriteLine();
    
    }

    const int MAXLOOP=10;
    public void LoopSample()
    {
        for(int i = 10; i>0; i--)
        {
            Console.Write($"Loop:{i} ");
        }
        Console.WriteLine();
        int x = MAXLOOP;
        while(x>0)
        {
            Console.Write($"While:{x} ");
            x--;
        }
        Console.WriteLine();
        string[] array = new string[]{"AB","CD","EF"};

        foreach(string s in array)
        {
            //Console.WriteLine(s);
        }

        string[,,] arr = new string[,,]{
            {{"1","2"}, {"11","22"}},
            {{"3","4"}, {"33","44"}}
        };
        for(int i = 0; i<arr.GetLength(0); i++)
        {
            for(int j = 0; j<arr.GetLength(1); j++)
            {
                for(int k=0; k<arr.GetLength(2); k++)
                {
                    Console.Write($"{arr[i,j,k]}, ");
                }
            }
        }
        Console.WriteLine();
        foreach(var item in arr)
        {
            Console.Write($"{item}, ");
        }

    }
    public void SwitchStatement(string[] args)
    {
        string category = "딸기";
        int price = 100;
        
        switch (category)
        {
            case "사과":
                price = 1000;
                break;

            case "딸기":
            case "키위":
                price = 1100;
                break;

            case "포도":
                price = 900;
                break;

            default:
                price = 0;
                break;
        }
        
        /*
        if (category.Equals("사과"))
        {
            price = 1000;
        }
        else if (category.Equals("딸기"))
        {
            price = 1100;
        }
        else if (category.Equals("포도"))
        {
            price = 900;
        }
        else
        {
            price = 0;
        }*/
        //Console.WriteLine($"Price : {price}");

       if(args.Length!=1)
       {
            Console.WriteLine("Usage : MyApp.exe option");
            return;
       }

       string option = args[0];
       switch(option.ToLower())
       {
        case "/v":
        case "/verbose":
            verbose = true;
            break;
        case "/c" :
            continueOnError = true;
            break;
        case "/l" :
            logging = true;
            break;
        default :
         Console.WriteLine($"Unknown argument {option}");
         break;
       }

    }

    public void Operator()
    {
        //산술 연산자(+, -, *, /, %)
        int a = (1+2-1) * (4/2) % 3;

        //할당 연산자 (=, +=, -=, *=, /=, %=)
        int b = 100;
        int sum = 0 ;
        sum += b;
        a%=2;

        //증감 연산자(++, --)
        int i = 1;
        //증감 연산자를 앞에 붙이느냐 뒤에 붙이느냐에 따라 차이 존재. 
        i++; //마지막에 계산함
        ++i; //제일 먼저 계산됨

        int c = 0; bool d = false;
        //논리 연산자(&&and, ||or, !not_false)
        if((a>1&&b<0) || c==1 ||!d) a = 1;

        //비교 연산자(<,>,==,!=,>=,<=)

        //비트 연산자(&and |or ^xor)

        // 0&0(0) 1&0 (0) 
        // 1|0(1) 0|0(0)
        // 0^0 (0) 1^0(1) 1^1(0)

        byte a1 = 0b_0000_0111;; //7
        byte b2 = (byte)((a1&3)|4);
        Console.WriteLine($"byte b1 : {b2}");

        //Shift 연산자
        //>>,<< 비트를 이동.
        int j = 2;
        j = j<<5; // i의 값을 왼쪽으로 5비트 이동.(이진수상에서 숫자를 옆으로)
        Console.WriteLine($"2 after left shift 5 :{j}");
        //shift 연산자는 왼쪽으로 갈 때<<는 *2, 오른쪽>>으로 갈 때에는 /2의 성질.

        //조건 연산자(?, ??)
        int val = (a>b)? a:b;

        //??연산자 : Null-coalescing operator.
        //왼쪽 피연산자의 값이 NULL인 경우 ??뒤의 피연산자의 값을 리턴하고, 아니면 그냥 ??앞의 피연산자 값을 맅ㄴ
        //NULL 데이터가 허용되는 경우에만 사용가능. int는 안 되지만 Nullable<int>는 가능
        int? i2 = null;
        int x = i2 ?? 0;

        string s = null;
        string s2 = s?? string.Empty;
        //풀어쓰면
        if(s == null)
        {
            s2 = string.Empty;
        }
        else
        {
            s2 = s;
        }


    }
    enum City
    {
        Seoul,
        Dajeon,
        Busan = 0, //지정하면 그 값 기준으로 다음값 설정됨.
        Jeju= 10

    }

    [Flags]
    enum Border
    {
        None = 0,
        Top = 1,
        Right = 2,
        Bottom = 4,
        Left = 8
        //값을 다르게 주면 비트 연산이 안됨.
    }
    public void EnumSample()
    {
        //비트연산
        Border b = Border.Top | Border.Bottom;

        if((b&Border.Top)!=0)
    {
        if(b.HasFlag(Border.Bottom)) //HasFlag()이용 플래그 체크
        {
            Console.WriteLine(b.ToString()); //(int)b = 13.
        }
    }
        City myCity; // 이넘의 기본값(처음값)이 들어감.
        myCity = City.Busan;

        int cityValue = (int)myCity;

        if(myCity.Equals(City.Seoul))
        {
            Console.WriteLine("Welcome to Seoul");
        }
    }

    public void StringBuilderSample()
    {
        //StringBuilder : 문자열 갱신가능한 클래스 - 일반 string은 새로 생성하고 집어넣음(변수로 선언해두어도)
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i<26 ; i++)
        {
            sb.Append((char)('A'+i)); //Append-Add i를 스트링으로 바꿔서 넣고
            sb.Append(System.Environment.NewLine); // 줄바꿈 기호
        }   
        string s = sb.ToString();
        Console.WriteLine(s);
    }

    public void StringSample()
    {
        string s1 = "C#";
        string s2 = "Programmming";
        //char c1 = 'a';
        //char c2 = 'b';

        string s3 = s1+" "+s2;
        //Console.WriteLine("string: {0}", s3);

        string s3substring = s3.Substring(1, 5);
        Console.WriteLine("Substring: {0}", s3substring); // 표준 숫자 형식 문자열 보기.
        Console.WriteLine($"Substring: {s3substring}");

    
        string s = "C# Studies";
        
        for(int i = 0; i<s.Length; i++)
        {
            Console.WriteLine("{0}: {1}", i, s[i]);
            Console.WriteLine($"{i} : {s[i]}");
        }
    
        string str = "Hello";
        char[] charArray = str.ToCharArray();
        for(int i = 0; i<charArray.Length; i++)
        {
            Console.WriteLine(charArray[i]);
        }

        char[] charArray2 = {'A','B','C','D'};
        s = new string(charArray2);
        Console.WriteLine(s);

        //문자연산
        char c1 = 'A';
        char c2 = (char)(c1 +3); //아스키 코드에서의 값에다 더해줌.
        Console.WriteLine(c2);
    }

    public void Dictionary()
    
    {
        //키-Value의 자료형을 정하고 쓸 수 있는 구조의 자료구조

        Dictionary<int, string> emp = new Dictionary<int, string>();
        emp.Add(1001, "Jane");
        emp.Add(1002, "Tom");
        emp.Add(1003, "Cindy");
        if(emp.ContainsKey(1004))
        {
            Console.WriteLine(emp[1004]);

        }
    
        string name = emp[1003];
        Console.WriteLine(name);
        int a = emp.Count;


        //Concurrent Dictinoary

        //var = 바로 지정해야 에러 안남. 아래처럼 쓸 수 있음.
        var chr = new List<char>();
        var dic = new Dictionary<int, string>();

    }

    public void Hash_Table()
    {
        //키-값. 해시테이블에서 키값은 하나.
        
        Hashtable hash = new Hashtable();
        hash.Add("irina","Irina SP");
        hash.Add("tom", "Tom Cr");
        hash.Add(3, "ans");
        if(hash.Contains("tom"))
        {
            Console.WriteLine(hash["tom"]);
        }

    }

    public void Deck()
    {
        //Deck(데크) : 양쪽 끝에서 삽입과 삭제가 모두가능한 자료구조 -> LinkedList 등과 비슷함.
        //LinkedList는 각각의 자료가 메모리 어디에 존재할 지 모름, 헤드-테일이 있기 때문에 메모리 상에서 순서에 맞게 연결되어있지는 않음.
        //데크는 메모리 상에서도 연결되어 있다는 점이 차이점
        //많이 쓰이지는 않음
    }


    public void Queue_Stack()
    {
        //Queue : 선입선출

        Queue<int> intQue = new Queue<int>();
        intQue.Enqueue(123);
        intQue.Enqueue(130);
        intQue.Enqueue(150);

        int next = intQue.Dequeue();
        Console.WriteLine($"intQue.Count : {intQue.Count}");
        Console.WriteLine(intQue.Peek());
        Console.WriteLine(next);
        next = intQue.Dequeue();
        Console.WriteLine(next);

        //ConcurrentStack : Enqueue와 Dequeue가 동시에 일어나서(멀티스레딩) 발생할 오류를 방지
        //Dequeue()대신 TryDequeue()로 사용

        //Stack : 후입선출
        Stack<float> fStack = new Stack<float>();
        fStack.Push(10.5f);
        fStack.Push(3.54f);
        fStack.Push(4.22f);

        float val = fStack.Pop();
        Console.WriteLine(val);

    }

    public void List()
    {
        List<int> intList = new List<int>();
        List<float> floatList = new List<float>();
        List<char> charList = new List<char>();
        List<string> strList = new List<string>();
        List<bool> boolList = new List<bool>();

        intList.Add(0);
        intList.Add(1);
        intList.Remove(0);
        int value = intList.Count;
        Console.WriteLine(value);

        // Linked List - 연결 리스트-
        LinkedList<string> list = new LinkedList<string>();
        list.AddLast("Apple");
        list.AddLast("Banana");
        list.AddLast("Lemon");

        //LinkedList의 node
        LinkedListNode<string> node = list.Find("Banana");
        LinkedListNode<string> newNode = new LinkedListNode<string>("Grape");
        list.AddAfter(node, newNode);
        list.ToList<string>().ForEach(p => Console.WriteLine(p));

    }

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