using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritmatik_Ortalama_diziler_ile_
{
    class Program
    {
        static void Main(string[] args)
        {

//--------------------------------------------------------------------------------------------------
//                           Değişkenler Tanımlanır
//--------------------------------------------------------------------------------------------------
            
            int n, Toplam=0;
            double AritmatikOrtalama;
//--------------------------------------------------------------------------------------------------
//                           Kullanıcıdan Bilgiler Alınır
//--------------------------------------------------------------------------------------------------

          Console.Write("Klavyeden n adet sayı Giriniz\nn = ");    n = Convert.ToInt16(Console.ReadLine());

//--------------------------------------------------------------------------------------------------
//                   Dizi Tanımlanır Ve Gerekli İşlemler Yapılır
//--------------------------------------------------------------------------------------------------

            int[] B = new int[n];

            Console.WriteLine("{0} Adet Dizi Elemanını Giriniz", n);

                for(int i = 0 ; i<n ; ++i )
                 {
                
                     Console.Write("[{0}] = ", i + 1);    

                     B[i] = Convert.ToInt16(Console.ReadLine());

                     Toplam += B[i];
                                         
                 }

                AritmatikOrtalama = (double)Toplam / n;
//--------------------------------------------------------------------------------------------------
//                          Ekrana Yazdırma İşlemi Yapılır
//--------------------------------------------------------------------------------------------------

            Console.WriteLine("\nGirilen Sayıların Toplamı = {0}", Toplam);
            Console.WriteLine("-------------------------------");

            Console.WriteLine("\nGirilen Sayıların Artimatik Ortalama Değeri = {0:#.###}", AritmatikOrtalama);
            Console.WriteLine("---------------------------------------------------------");

//--------------------------------------------------------------------------------------------------
//                          Program Sonlandırılır...
//--------------------------------------------------------------------------------------------------
            Console.Write("\n\n\nProgram Sonlandı. Çıkmak İçin Bir Tuşa Basınız ...");
            Console.ReadLine();
        }
    }
}
