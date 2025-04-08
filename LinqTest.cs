using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

//Linq : Language-Integrated Query 의심하거나 모르는 점을 물음. 데이터 질의
//from : Linq에 반드시 들어감. 모든 쿼리식이 from절로 시작.
//from 범위 변수 in 데이터 원본
// 범위변수는 반복 변수와는 달리 실제로 데이터 저장하지 않음.

//where : 필터와 같은 역할을 하며 데이터 원본으로부터 순차적 요소를 가져오고
//그 요소가 범위 변수에 들어가게 되면 변수를 조건식을 통해 걸러내는 역할을 함.
//만약 조건식이 거짓이면 요소를 반환하지 않으며 참이면 요소를 반환함.
// where절을 여러개 사용 가능

//orderby : 데이터의 정렬 수행. 오름차순/내림차순. 기본은 오름차순. descending-> 내림차순

//select : 최종적인 결과를 뽑아내는 이 최총적인 결과는 앞에 있는 모든 절과 select 절을 거쳐서 나옴. 
//linq 쿼리식은 from으로 시작했으면 select절 또는 group절로 끝나야만 함.

//group : 분류 기준에 따라 분류하여 그룹화하여 그룹 개체를 반환함. group절을 이용하여 데이터 분류
//group A by into C
// 추가적으로 쿼리작업을 하려면 into 키워드가 필요하지만 그렇지 않은 경우에는 into와 그룹 변수를 쓰지 않아도 됨.
class LinqTest
{
    public void Test()
    {
        var intList = new List<int>();
        int[] numbers = { 1, 3, 4, 6, 5, 9, 8, 12, 15, 18, 17, 11, 22 };

        //쿼리 구문
        var data = from num in numbers
                   where num % 2 == 0
                   orderby num
                   select num;

        //매서드 구문
        var data2 = numbers.Where(num => num % 2 == 0).OrderBy(n => n);

        foreach (var i in data)
        {
            Console.Write($"{i}, ");
        }

        /*
        foreach (int num in numbers)
        {
            if (num % 2 == 0)
            {
                intList.Add(num);
            }
        }
        intList.Sort();

        foreach (int num in intList)
        {
            Console.Write($"{num}, ");
        }
        */

        
    }


    public void Test2()
    {
        char[] chars = "str12i3!@$1ng".ToCharArray();
        var data = from vchar in chars
                   where vchar >= 97 && 122 >= vchar
                   select vchar;
        foreach (char i in data)
        {
            Console.Write($"{i}");
        }
    }


    public void Test3()
    {
        List<Students> stList = new List<Students>
        {
            new Students() {Name = "김철수", Average = 78.5f},
            new Students() {Name = "김영희", Average = 91.2f},
            new Students() {Name = "홍길동", Average = 77.3f},
            new Students() {Name = "김길수", Average = 80.8f},
        };

        var queryStudents = from student in stList
                            orderby student.Average
                            group student by student.Average < 80.0;
        
        foreach(var stGroup in queryStudents)
        {
            Console.WriteLine(stGroup.Key?"평균 80점 미만 : " : "평균 80점 이상 : ");
            foreach(var student in stGroup)
            {
                Console.WriteLine($"{student.Name} : {student.Average}점");
            }
        }

        //listStudnet의 요소를 group절의 분류 기준을 통해 분류하여 그룹화시킴

    }

    public void Test4()
    {
        List<Students> stList = new List<Students>
        {
            new Students() {Name = "김철수", Average = 78.5f},
            new Students() {Name = "김영희", Average = 91.2f},
            new Students() {Name = "홍길동", Average = 77.3f},
            new Students() {Name = "김길수", Average = 80.8f},
            new Students() {Name = "김영순", Average = 54.2f},
            new Students() {Name = "김상수", Average = 90.8f},
            new Students() {Name = "이한수", Average = 61.4f},   
        };

        var queryStudents = from student in stList
                            group student by (int)student.Average / 10 into g
                            orderby g.Key
                            select g;
        
        foreach(var stGroup in queryStudents)
        {
            int temp = stGroup.Key * 10;
            Console.WriteLine($"{temp}점과 {temp+10}점의 사이 : ");

            foreach(var student in stGroup)
            {
                Console.WriteLine($"\t{student.Name} : {student.Average}점");
            }
        }
                            
    }
}



class Students
{
    public string Name;
    public float Average;
}

