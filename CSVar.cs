public class CSVar
{
    //필드(클래스 내에서 공통적으로 사용되는 전역 변수)
    int globalvar;
    const int MAX = 1024;

    //Readonly필드
    readonly int Max; //Readonly는 필드에서만 가능함.
    public CSVar()
    {
        Max =  1;
    }
    public void Method1()
    {
        int localVar;
        localVar = 10;

        Console.WriteLine(MAX); //상수는 컴파일 시에 주소값이 아닌 해당 값 그 자체로 들어감. 
                                //변수를 안 쓰는 효과.메모리는 잡아먹지만 속도는 빠름
        Console.WriteLine(globalvar);
        Console.WriteLine(localVar);

    }
}