using System;

namespace C__1
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Write("a: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("b: ");
                int b = int.Parse(Console.ReadLine());  

                var sonuc = a / b;

                Console.WriteLine("{0} / {1} = {2}",a,b,sonuc);
        }
    }
}
