//튜플
//튜플 : 매서드로부터 복수개의 값 리턴 가능.
//괄호 안에 여러 리턴타입들을 순서대로 나열. 
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Intrinsics.X86;

class TupleTest
{
    
    (int count, int sum, double average) Calcualte(List<int> data) // 튜플 리턴타입
    {
        int cnt = 0, sum = 0;
        double avg = 0;

        foreach(var i in data)
        {
            cnt ++;
            sum += i;
        }
        avg = sum / cnt;

        return (cnt, sum, avg); // 튜플 리터럴
    }

    public void Run()
    {
        var list = new List<int>{1,2,3,4,5};
        var r = Calcualte(list); // 튜플 결과
        //우선 var형으로 받고, r.count, r.sum, r.average 이렇게 받음.
        Console.WriteLine($"{r.count}, {r.sum}, {r.average}");
        
        //명칭 없이 타입만 지정했을 경우 Item으로 받음.
        Console.WriteLine($"{r.Item1}, {r.Item2}, {r.Item3}"); 

        (int cnt, int sum, double avg) = Calcualte(list);//이런식으로도 가능
        (cnt, sum, avg) = Calcualte(list);
    }

    void TestT()
    {
        //UNITY에서 튜플
        (int, float) piTuple = (1, 3.14f);
        int x = piTuple.Item1;
        float y = piTuple.Item2;

        (int num, float pi) tp2 = (2, 3.14f);
        int a = tp2.num;
        float p = tp2.pi;

        var myVar3 = (3, 0.01f);
        int b = myVar3.Item1;
        float vf = myVar3.Item2;
    }

    public (int sum, int sub) Calc(int a, int b)
    {
        return (a + b, a - b);
    }

    //튜플 형태를 담는 리스트를 쓸 수 있다.
    void Test2()
    {
        List<(int id, string str)> list = new List<(int id, string str)>();
        list.Add((1, "no.1"));
        list.Add((2, "no.2"));

        foreach (var item in list)
        {
            if (item.id == 2)
            {
                Console.WriteLine(item.str);
            }
        }
    }

}