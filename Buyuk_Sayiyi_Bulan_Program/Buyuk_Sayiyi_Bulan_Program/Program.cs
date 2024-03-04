using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buyuk_Sayiyi_Bulan_Program
{
    class Program
    {
        static void Main(string[] args)
        {

//--------------------------------------------------------------------------------------------------
//                              Değişkenler Tanımlanır.
//--------------------------------------------------------------------------------------------------
            int Sayi1, Sayi2, Sayi3;
//--------------------------------------------------------------------------------------------------
//                           Kullanıcıdan Bilgiler Alınır
//--------------------------------------------------------------------------------------------------
            Console.Write("Birinci Sayıyı Giriniz : "); Sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("İkinci Sayıyı Giriniz : "); Sayi2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Üçüncü Sayıyı Giriniz : "); Sayi3 = Convert.ToInt16(Console.ReadLine());

//--------------------------------------------------------------------------------------------------
//                 İşlemler Yapılır Ve Ekrana Yazdırma İşlemi Yapılır
//--------------------------------------------------------------------------------------------------

            if (Sayi1 > Sayi2 && Sayi1 > Sayi3)
                Console.WriteLine("\nEn Büyük Sayı : {0}", Sayi1);


            else if (Sayi2 > Sayi1 && Sayi2 > Sayi3)
                Console.WriteLine("\nEn Büyük Sayı : {0}", Sayi2);


            else if (Sayi3 > Sayi1 && Sayi3 > Sayi2)
                Console.WriteLine("\nEn Büyük Sayı : {0}", Sayi3);

            else
                Console.WriteLine("\n\n\nTüm Sayılar Eşittir.");
//--------------------------------------------------------------------------------------------------
//                            Program Sonlandırılır...
//--------------------------------------------------------------------------------------------------            
            Console.WriteLine("\n\n\nProgram Sonlandı Bir Tuşa Basın...");
            Console.ReadLine();
        }
    }
}
