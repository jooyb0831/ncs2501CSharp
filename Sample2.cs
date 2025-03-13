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

}