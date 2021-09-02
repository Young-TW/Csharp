using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Beep();
            int[] a = new int[5] {1,2,3,4,5};
            for(int i=0;i<5;i++){
                Console.WriteLine(a[i]);
            }
        }
    }
}
