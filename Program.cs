using System;
using System.Linq;

namespace lab6._2
{
    public class Program
    {

        public static int Sum(int[] Arr)
        {
            return Arr.Min() + Arr.Max();
        }
        public static void Main(string[] args)
        {
            int count;
            Random random = new Random();

            Console.Write("Enter count of elements = ");
            count = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[count];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);

                Console.Write(array[i] + "\t");
            }

            Console.WriteLine();
            Console.WriteLine("Result = " + Sum(array));

        }
    }
}
    


