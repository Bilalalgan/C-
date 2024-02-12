using System;

namespace C__1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = {"Ahmet","Çınar","Ada","Yiğit","Sena"};

             isimler[0] = "Ali";

            int[] numaralar = new int[5];

            numaralar[0] = 100;
            numaralar[1] = 102;
            numaralar[2] = 103;
            numaralar[3] = 104;
            numaralar[4] = 105;

            Console.WriteLine($"öğrenci adı: {isimler[0]} ve numara: {numaralar[0]}");
            Console.WriteLine($"öğrenci adı: {isimler[1]} ve numara: {numaralar[1]}");
            Console.WriteLine($"öğrenci adı: {isimler[2]} ve numara: {numaralar[2]}");
            Console.WriteLine($"öğrenci adı: {isimler[3]} ve numara: {numaralar[3]}");
            Console.WriteLine($"öğrenci adı: {isimler[4]} ve numara: {numaralar[4]}");
        }
    }
}
