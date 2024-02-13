using System;

namespace C__1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Kullanicidan isim, yas, egitim bilgisi al. 
                //Ehliyet alma kosulu en az 18, egitim universite veya lise.

            Console.Write("İsim: ");
            string isim = Console.ReadLine();

            Console.Write("Yaş Giriniz: ");
            int yas = int.Parse(Console.ReadLine());

            Console.Write("Egitim Durumu: ");
            string egitim = Console.ReadLine();

            if((yas >= 18) && (egitim == "Universite") || (egitim == "Lise" )){
                
                Console.Write("Ehliyet Almaya Hak Kazandiniz.");
            }
            else{
                    Console.Write("Ehliyet Alamazsiniz");
            }

            
            //2. Girilen 3 sayıdan büyük olanı bulunuz.

            Console.Write("sayi1: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("sayi2: ");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.Write("sayi3: ");
            int sayi3 = int.Parse(Console.ReadLine());

            if((sayi1>sayi2) && (sayi1>sayi3)){
                Console.Write("Büyük sayi: sayi1");
            }
            else if((sayi2>sayi1) && (sayi2>sayi3)){
                Console.Write("Büyük sayi: sayi2");
            }
            else{
                Console.Write("Büyük sayi: sayi3");
            }

            //3. 2 tane yazılı notu al ortalamaya göre not ver.
                //(0-24: 0, 25-44: 1, 45-54: 2, 55-69: 3, 70-84: 4, 85-100:5)
            
            Console.Write("sayi1: ");
            int yazili1 = int.Parse(Console.ReadLine());

            Console.Write("sayi2: ");
            int yazili2 = int.Parse(Console.ReadLine());

            int ortalama = (yazili1 + yazili2)/2 ;

            if((ortalama > 0) && (24 > ortalama)){
                Console.Write("Not Ortalamaniz : 0");
            }
            else if((ortalama >= 25) && (44 >= ortalama)){
                Console.Write("Not Ortalamaniz : 1");
            }
            else if((ortalama >= 45) && (54 >= ortalama)){
                Console.Write("Not Ortalamaniz : 2");
            }
            else if((ortalama >= 55) && (69 >= ortalama)){
                Console.Write("Not Ortalamaniz : 3");
            }
            else if((ortalama >= 70) && (84 >= ortalama)){
                Console.Write("Not Ortalamaniz : 4");
            }
            else if((ortalama >= 85) && (100 >= ortalama)){
                Console.Write("Not Ortalamaniz : 5");
            }
            else{
                Console.Write("Yanlis Deger Girdiniz...");
            }

            // 4. Trafiğe cıkan aracın servic bakım zamanı hesaplama
                // 1. Bakım : 1 Yıl
                // 2. Bakım : 2 Yıl
                // 3. Bakım : 3 Yıl
                // Süre hesabı alınırken yıl,ay,gün bilgisine göre gün bazlı hesaplama.

            Console.Write("yil: ");
            int yil = int.Parse(Console.ReadLine());

            Console.Write("ay: ");
            int ay = int.Parse(Console.ReadLine());

            Console.Write("gün: ");
            int gun = int.Parse(Console.ReadLine());

            int toplamGun = (DateTime.Now - new DateTime(yil,ay,gun)).Days;

            if (toplamGun<=365)
                Console.WriteLine("1.servis");
            else if(toplamGun>365 && toplamGun<=365*2)
                Console.WriteLine("2.servis");
            else if(toplamGun>365*2 && toplamGun<=365*3)
                Console.WriteLine("3.servis");
            else
                Console.WriteLine("yanliş bilgi");


        }   
    }
}
