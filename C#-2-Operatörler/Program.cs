using System;

namespace C__1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Girilen 2 sayıdan hangisi büyük ? 

            Console.Write("İlk Sayi: ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.Write("2. Sayi: ");
            int sayi2 = int.Parse(Console.ReadLine());

            string sonuc = sayi1 > sayi2 ? "İlk sayi buyuk": "İkinci sayi büyük";
            Console.Write(sonuc);


            //2. Parola ve email bilgisini isteyip doğruluğunu kontrol ediniz ?

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            string sonuc2 = (email == "bilalalgan@hotmail.com") && (password == "123456") ? "Doğru girdiniz": "Yanliş Girdiniz";
            Console.Write(sonuc2);


            //3. Girilen bir sayının pozitif çift sayı olup olmadığını kontrol ediniz.

            Console.Write("Sayi Giriniz: ");
            int sayi3 = int.Parse(Console.ReadLine());

            string sonuc3 = (sayi3 > 0) && (sayi3 % 2 == 0)? "Pozitif Çift Sayi": "Pozitif veya çift sayi değil." ;
            Console.Write(sonuc3);

            //4. Girilen 3 sayıyı büyüklük karşılaştır

            Console.Write("İlk Sayi: ");
            int sayi4 = int.Parse(Console.ReadLine());
            Console.Write("2. Sayi: ");
            int sayi5 = int.Parse(Console.ReadLine());
            Console.Write("3. Sayi: ");
            int sayi6 = int.Parse(Console.ReadLine());

            var durumsonucu = (sayi4 > sayi5) && (sayi4 > sayi6)?"En büyük 1.Sayi" :
                              (sayi5 > sayi4) && (sayi5 > sayi6)?"En büyük 2.Sayi" :
                              (sayi6 > sayi5) && (sayi6 > sayi4)?"En büyük 3.Sayi" :"Hatali Durum";

            Console.Write(durumsonucu);

            //5. Kullanıcıdan 2 vize (%60) ve final (%40) notunu alıp hesaplayın.
                //Eğer not 50 ve üstü ise geçti, değilse kaldı.
                //Ortalama 50 olsa bile final en az 50 olmalıdır.
                //Finalden 70 alındığında otrtalamanın önemi olmasın

            Console.Write("1. Vize: ");
            int vize1 = int.Parse(Console.ReadLine());
            Console.Write("2. Vize: ");
            int vize2 = int.Parse(Console.ReadLine());
            Console.Write("Final: ");
            int final = int.Parse(Console.ReadLine());

            int ortalama = ((vize1%100)*30) + ((vize2%100)*30) + ((final%100)*40);

            string durum = ((ortalama >= 50) && (final >= 50)) || (final >= 70)? "Öğrenci Geçti": "Öğrenci Kaldi" ; 

            Console.Write(durum);

            //6. Kişinin Ad, Kilo ve boy bilgilerinin alınıp kilo indekslerini hesaplayın.
                //Formül: (kilo/boy uzunluğu karesi) 
                //(0-18.4 Zayıf, 18.5-24.9 Normal, 25.0-29.9 Kilolu, 30.0-34.9 Şişman)

            Console.Write("Adiniz: ");
            string isim = Console.ReadLine();
            Console.Write("Kilonuz (KG): ");
            double kilo = double.Parse(Console.ReadLine());
            Console.Write("Boyunuz (M): ");
            double boy = double.Parse(Console.ReadLine());

            double kiloindex = (kilo) / (Math.Pow(boy,2));

            string durum1 =  ((18.4>kiloindex) && (kiloindex>0)) ?"Zayif" : "";
            string durum2 =  ((24.9>kiloindex) && (kiloindex>18.4)) ?"Normal" : "";
            string durum3 =  ((29.9>kiloindex) && (kiloindex>25.0)) ?"Kilolu" : "";
            string durum4 =  ((34.9>kiloindex) && (kiloindex>30.0)) ?"Şişman" : "";

            Console.Write(durum1);
            Console.Write(durum2);
            Console.Write(durum3);
            Console.Write(durum4);


        }
    }
}
