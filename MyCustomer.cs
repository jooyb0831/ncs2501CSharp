public class MyCustomer
{
    //필드 : 보통 private으로 생성.
    private string name;
    private int age;

    private long yearMoney;

    //이벤트
    public event EventHandler NameChanged;

    //생성자(Constructor) : 여러개가능.원하는 방식으로 생성 가능.
    public MyCustomer()
    {
        Init(string.Empty, -1);
    }
    public MyCustomer(int val)
    {
        Init(string.Empty, val);
    }

    /// <summary>
    /// 초기화
    /// </summary>
    /// <param name="str">이름</param>
    /// <param name="val">나이</param>
    public void Init(string str, int val)
    {
        name = str;
        age = val;
    }

    // 속성 : 필드 중 외부 접근이 필요한 경우 public으로 공개하기 위해 씀.
    // get {다른 것에서부터 가져올 수 있는 방법;(외부에서 접근할 때 가져가는 애.)} set{값 세팅.value:프로퍼티를 사용할 때 들어오는 파라매터.}
    public string Name
    {
        get { return this.name; }
        set
        {
            if(this.name != value)
            {
                this.name = value;
                if(NameChanged != null)
                {
                    NameChanged(this, EventArgs.Empty);
                }
            }
        }
    }

    //age를 받는게 아니라 Age라는 변수처럼 사용하는 형태
    public int Age { get; set; }

    public long YearMoney
    {
        get{ return this.yearMoney; }

        set
        {
            if (value < 0)
            {
                Console.WriteLine("에러");

            }
            else
            {
                yearMoney = value;
            }
        }

    }

    public int Temp { get; } = 9;

    /*
    public void SetYearMoney(long val)
    {
        if(val<0)
        {
            Console.WriteLine("에러");
            
        }
        else
        {
            yearMoney = val;
        }
        
    }
    */


    //메서드
    public string GetCustomerData()
    {
        string data = $"Name: {Name}, (Age: {Age})";
        return data;
    }

    /// <summary>
    /// 연봉을 출력
    /// </summary>
    public void PrintYearMoney()
    {
        Console.WriteLine(yearMoney);

    }

}