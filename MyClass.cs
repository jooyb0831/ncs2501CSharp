//Interface
public interface ICompareable //인터페이스 자체는 정의만 있고 구현부는 없음
{
   int CompareTo(object obj);
}

class MyClass : IComparable
{
    private int key;
    private int value;
    public int CompareTo(object? obj)
    {
        MyClass target = (MyClass)obj;
        return this.key.CompareTo(target.key);
    }

    private int val = 1;
    //인스턴스 매서드
    public int InstRun()
    {
        return val;
    }

    //정적 매서드
    public static int Run()
    {
        return 1;
    }
    //cf : 인터페이스 : 다중상속 가능. 내부에 매서드내용은 작성 불가. 상속받은 애에서 반드시 내용을 정의.
    private const int MAX = 10;
    private string name;

    //내부의 정수 배열 데이터
    private int[] data = new int[MAX];

    //인덱서 정의. int 파라미터 사용. 인덱서로 쓰려면 get-set이 있어야 함.
    public int this[int index]
    {
        get
        {
            if (index < 0 || index >= MAX)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                //정수배열로부터 값 리턴
                return data[index];
            }
        }
        set
        {
            if (!(index < 0 || index >= MAX))
            {
                //정수배열에 값 저장
                data[index] = value;
            }
        }
    }

    public void SetName(string strName)
    {
        name = strName;
    }



    public int this[string str]
    {
        get
        { 
            if(str.Equals(name))
            {
                return data[0];
            }
            else
            {
                throw new Exception();
            }
        }
        set
        {
            if(str.Equals(name))
            {
                data[0] = value;
            }
        }
    }
}

public class Client
{
    public void Test()
    {
        //인스턴스 매서드 호출
        MyClass myClass = new MyClass();
        int i = myClass.InstRun();

        //정적 메서드 호출
        int j = MyClass.Run();
    }
}

public static class MyUtility
{
    private static int ver;

    //static 생성자 (static은 public생성자 안됨)
    static MyUtility()
    {
        ver = 1;
    }

    public static string Convert(int i )
    {
        return i.ToString();
    }

    public static int ConvertBack(string s)
    {
        return int.Parse(s);
    }
}