class Sample
{
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