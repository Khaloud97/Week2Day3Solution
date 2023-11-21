using System.Runtime.CompilerServices;

namespace Week2Day3
{
    class Program
    {

        static int SArr(int x, int y = 3, params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {   //sum of elements
                sum += arr[i];
            }
            return sum;
        }


        static int SumArray(int k, int h, out int mulNu, out int sumNu, params int[] arr)
        {
             sumNu = 0;
             mulNu = k * h;
            //bool flage = true;


            for (int i = 0; i < arr.Length; i++)
            {   //sum of elements
                sumNu += arr[i];
                //Console.WriteLine("sum of the number = " + sumNu);
            }
            return 0;

        }


        static void Main()
        {
            Console.WriteLine("Sum of first and second number Array ");

             int[] Numbers = { 1, 2, 3, 4, 5 };
             Console.WriteLine(SArr(1, 2, 3, 4, 5));
             Console.WriteLine(SumArray(1, 2, out int m , out int s, 3, 4, 5));
            Console.WriteLine($"Mult {m} , Sum {s}");
            //Console.WriteLine("With flage true :");
            //SumArray(1 ,2 ,3 ,4, pattern, flage);
        }
    }

}