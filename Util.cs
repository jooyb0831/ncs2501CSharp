class Util
{
    /// <summary>
    /// 정수 배열의 내용을 출력
    /// </summary>
    /// <param name="intArray">출력할 배열</param>
    public static void PrintIntArray(int[] intArray)
    {
        Console.Write("{");
        for (int i = 0; i < intArray.Length; i++)
        {
            if (i!=0)
            {
                Console.Write(", ");
            }
            Console.Write(intArray[i]);
        }
        Console.WriteLine("}");
    }
}