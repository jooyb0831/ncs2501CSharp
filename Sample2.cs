class Sample2
{
    public void FormatString()
    {
        int a = 12345678;
        double b = 12.345678;

        Console.WriteLine($"통화 (C) . . . : {a:C}");
        Console.WriteLine($"10진법 (D) . . : {a:D}");
        Console.WriteLine($"지수 표기법 (E): {b:E}");
        Console.WriteLine($"고정 소수점 (F): {b:F}");
        Console.WriteLine($"일반 (G) . . . : {a:G}");
        Console.WriteLine($"숫자 (N) . . . : {a:N}");
        Console.WriteLine($"16진법 (X) . . : {a:X}");
        Console.WriteLine($"백분율 (P) . . : {b:P}");

        int c = 1234;
        Console.WriteLine($"0 자리 표시 . . . . : {c:00000}");
        Console.WriteLine($"10진수 자리 표시 . . : {c:#####}");
        Console.WriteLine($"소수점(.) . . . . . : {b:0.00000}");
        Console.WriteLine($"천 단위 자릿수 표시(,) : {a:0,0}");
        Console.WriteLine($"백분율 자리 표시 (%) . : {b:0%}");
        Console.WriteLine($"지수 표기법 (e) . . . .: {b:0.000e+0}");
    }

    public void Operation()
    {
        //증감연산자
        //++a : a의 값을 1 증가하고 a를 출력
        //a++ : a의 값을 출력한 뒤 1 증가

        int a=3, b=5;
        Console.WriteLine(a++ +b);
        Console.WriteLine(a++ + --b);
        Console.WriteLine(++a + a++);
    }

    public void BitOperation()
    {
        //비트 연산자
        // & : 두 피연산자에 대응되는 비트에 논리곱(AND)
        // | : 두 피연산자에 대응되는 비트에 논리합(OR)을 수행
        // ^ : 두 피연산자에 대응되는 비트에 배타적 논리합 (XOR)을 수행 //두 비트가 같으면 0, 다르면 1

        int a = 13, b = 10;

        Console.WriteLine(a & b);
        Console.WriteLine(a | b);
        Console.WriteLine(a ^ b);

        //시프트 연산자 : 빠르다.
        // << -> 2씩 곱함
        // >> -> 2씩 나눔
        int c = 616;
        Console.WriteLine(c << 4); 
        Console.WriteLine(c >> 4);
    }

}