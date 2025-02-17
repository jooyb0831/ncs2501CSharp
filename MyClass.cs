class MyClass
{
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