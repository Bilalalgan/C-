using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basit_Dort_İslem
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sayi1, Sayi2, Toplam, Cıkarma, Carpma;
            double Bolme;

            Console.Write("Birinci Sayıyı Giriniz : ");
            Sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci Sayıyı (Sıfırdan Farklı Bir Şekilde) Giriniz : ");
            Sayi2 = Convert.ToInt32(Console.ReadLine());
            
            if(Sayi2 == 0)
            {
                Console.WriteLine("Hatalı Sayı Girişi\n\n Program Sonlandı Çıkmak İçin Bir Tuşa Basınız...");
                goto Bitis;
            }

            Toplam = Sayi1 + Sayi2;
            Cıkarma = Sayi1 + Sayi2;
            Carpma = Sayi1 * Sayi2;
            Bolme =(double) Sayi1 / Sayi2;
            Console.WriteLine("Toplama Sonucu : {0}  \nÇıkarma Sonucu : {1}  \nÇarpma Sonucu : {2}  \nBölme Sonucu : {3}", Toplam, Cıkarma, Carpma, Bolme);
            Bitis:
            Console.ReadLine();
            

        }
    }
}
