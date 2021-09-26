using System;

namespace maxelement
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
              for(i=0; i<arr.Length; i++)  
              {  
	          Console.Write("{0} : ",i);
	          arr[i] = int.Parse(Console.ReadLine());  		
              } 
            Max(arr);
        }
        static void Max(int [] arr)
        {
            var max = 0;
            foreach (int item in arr)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            Console.WriteLine($"Max element of the array:");
            Console.WriteLine(max);
        }
    }
}
