using System;

namespace ededvemassiv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array : ");
            string n = Console.ReadLine();
            int neded = int.Parse(n);
            int[] arr = new int[neded];
            int i;
            Console.Write(" Enter the elements of an array: \n");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} : ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
                Console.WriteLine("Given number");
                string m = Console.ReadLine();
                int meded = int.Parse(m);
                Numberandarray(arr, meded);
            static void Numberandarray(int[] arr, int meded)
            {
                int newnum=0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == meded)
                    {
                        newnum=1;
                        Console.WriteLine("Given number is in the array");
                        break;
                    }
                }
                    if (newnum == 0)
                    {
                    Console.WriteLine("Given number isn't in the array");
                    }
            }
        }
    }
}

