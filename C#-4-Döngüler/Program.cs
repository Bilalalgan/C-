using System;

namespace C__1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bankamatik (Bakiye, Para Yatırma, Para Çekme, Çıkış)

            int deger = 0;
            int bakiye = 0;

            while(!(deger==4)){
                Console.WriteLine("Hoş Geldiniz Sn. Bilal Algan");
                Console.WriteLine("Bakiye Görüntülemek(1), Para Yatir(2), Para Çek(3), Cikis(4)");
                deger = int.Parse(Console.ReadLine());

                if(deger == 1){
                    Console.WriteLine("Bakiyeniz: "+bakiye);
                }

                else if(deger == 2){
                    Console.Write("Eklemek İstediginiz Miktari Giriniz: ");
                    int miktar = int.Parse(Console.ReadLine());
                    bakiye += miktar;
                }

                else if (deger == 3){
                    Console.Write("Çekmek İstediginiz Miktari Giriniz: ");
                    int miktar = int.Parse(Console.ReadLine());
                    if(miktar > bakiye){
                        Console.WriteLine("Yetersiz Miktar, Ana Menüye Dönüyorsunuz..");
                        continue;
                    }
                    bakiye -= miktar;
                }
                else if(deger == 4){
                    Console.WriteLine("Uygulamadan Çikildi...");
                    break;
                }
                else{
                    Console.WriteLine("Hatali Tuşlama, Ana Menüye Dönüyorsunuz...");
                }
            }
        }   
    }
}
