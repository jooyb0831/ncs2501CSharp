using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MySystem
{
    //static class를 정의
    public static class ExClass
    {
        //static 확장매서드를 정의. 첫 번째 파라미터는 어떤 클래스가 사용할지만 지정
        public static string ToChangeCase(this String str)
        { //this String : 실제 파라미터는 아님.
            StringBuilder sb = new StringBuilder();
            foreach (var ch in str)
            {
                if (ch >= 'A' && ch <= 'Z')
                {
                    sb.Append((char)('a' + ch - 'A'));
                }
                else if (ch >= 'a' && ch <= 'z')
                {
                    sb.Append((char)('A' + ch - 'a'));
                }
                else
                {
                    sb.Append(ch);
                }
            }
            return sb.ToString();
        }

        //이 확장매서드는 파라미터 ch가필요함
        public static bool Found(this String str, char ch)
        {
            int position = str.IndexOf(ch);
            return position >= 0; //비교한 결과(bool값) return(0보다 큰 값일때)
        }
    }
    class MySort
    {
        //델리게이트 CompareDelegate 선언
        public delegate int CompareDelegate(int i1, int i2);

        public static void Sort(int[] arr, CompareDelegate comp)
        {
            if (arr.Length < 2)
            {
                return;
            }
            Console.WriteLine($"함수 Prototype : {comp.Method}");

            int ret;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    ret = comp(arr[i], arr[j]);
                    if (ret == 1)
                    {
                        //교환
                        int tmp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = tmp;
                    }
                }
            }
            Util.PrintArray<int>(arr);

        }

        public void Run()
        {
            int[] a = { 5, 53, 3, 7, 1 };

            //올림차순으로 소트
            CompareDelegate compDelgate = AscendingCompare;
            Sort(a, compDelgate);

            //내림차순으로 소트
            compDelgate = DescendingComapre;
            Sort(a, compDelgate);
        }


        //CompareDelegate와 동일한 Prototype
        int AscendingCompare(int i1, int i2)
        {
            if (i1 == i2)
            {
                return 0;
            }
            return (i2 - i1) > 0 ? 1 : -1;
        }

        //CompareDelegate와 동일한 Prototype
        int DescendingComapre(int i1, int i2)
        {
            if (i1 == i2)
            {
                return 0;
            }
            return (i1 - i2) > 0 ? 1 : -1;
        }
    }
}