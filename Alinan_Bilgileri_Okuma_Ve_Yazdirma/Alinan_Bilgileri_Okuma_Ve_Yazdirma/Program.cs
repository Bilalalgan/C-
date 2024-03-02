using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alinan_Bilgileri_Okuma_Ve_Yazdirma
{
    class Program
    {
        static void Main(string[] args)
        {
//-------------------------------------------------------------------------------            
//                                 -Değişkenlerimiz-
//-------------------------------------------------------------------------------
            string Ad;
            string Soyad;
            char Cinsiyet;
            string Memleket;
            int Boy;
            double Kilo;
//--------------------------------------------------------------------------------
//                     Kişisel bilgileri kullanıcıdan alıyoruz.
//--------------------------------------------------------------------------------
            Console.Write("Adınızı Giriniz : "); Ad = Console.ReadLine();
            Console.Write("Soyadınızı Giriniz : "); Soyad = Console.ReadLine();
            Console.Write("Cinsiyetinizi Giriniz ( E / K ) : "); Cinsiyet = Convert.ToChar(Console.ReadLine());
            Console.Write("Memleketinizi Giriniz : "); Memleket = Console.ReadLine();
            Console.Write("Boyunuzu Giriniz (cm) : "); Boy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kilonuzu Giriniz (kg) : "); Kilo = Convert.ToDouble(Console.ReadLine());
//--------------------------------------------------------------------------------
//                       Girilen Bilgileri Ekrana Yazdırma
//--------------------------------------------------------------------------------
            Console.WriteLine("\n-------------------------------------------------------------------------------------");
            Console.WriteLine("                             KİŞİSEL BİLGİLERİNİZ");
            Console.WriteLine("-------------------------------------------------------------------------------------\n");
            Console.WriteLine("Ad Soyad : {0} {1}    Memleketi : {2}", Ad, Soyad, Memleket);
            Console.WriteLine("Cinsiyet : {0}      Boy : {1} cm    Kilo : {2} kg", Cinsiyet, Boy, Kilo);
//--------------------------------------------------------------------------------
//                               Program Sonlanır
//--------------------------------------------------------------------------------
            Console.Write("\n\n\nProgram Sonlandı Çıkmak İçin Bir Tuşa Basınız...");
            Console.ReadLine();
        }
    }
}
