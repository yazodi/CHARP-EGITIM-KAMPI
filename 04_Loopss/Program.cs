using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loopss
{

  internal class Program
   {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //Döngüler. 
            //1+2+3+4+5+6+
            //3+3=6+4=10+5=15+6=21 her defasında bir önceki sayının üstüne katarak toplama işlemi gerçekleştirir.
            // temiz kodlamayı övüyor senden sonraki yazılımcı için okunabilir olmalı.
            // 4 temel döngü var
            //For(x;y;z)
            //x: Başlangıç değerini tutar start veriyordur
            //y: bitiş  

            // z: artış:azalış increase - decrease

            // i eşit 1; i kücük eşit 5 olana kadar i++ bir bir artır.
            //  int i;
            //// for(i = 1; i <=10 i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}
            //// Console.WriteLine("C# Eğitim Kampı"); yerine Console.WriteLine(i); yazdırırsan
            // i değişkeni atanan 1'dir 1'i 10 sayisina eşit olana kadar artırarak yazdırır.
            // i +=3) i'yi 3cer arttir 50'ye kadar
            //for(int i = 3; i <= 50; i += 3)
            //{
            //    Console.Write(i);
            //}


            // Döngünün başlangıç ve bitiş değerleri kullanıcıdan alınabilir.


            //Console.Write("Lütfen ekrana kaçkere yazılmasnı istediğiniz sayıyı giriniz:");

            //int finishValue = int.Parse(Console.ReadLine());


            //for (int i = 1;i<= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");

            //}
            //   Console.WriteLine("Lütfen adınızı giriniz.");
            //////string adi = Console.ReadLine();
            //////Console.WriteLine("Lütfen soyadınızı giriniz");
            //////string soyAdi = Console.ReadLine();
            //////Console.WriteLine(adi, soyAdi);



            //https-//www.bytehide.com/blog/console-writeline-csharp
            //Console.WriteLine() When you want output on separate lines. ayrı satırda
            // Console.Write() aWhen continuous output on the same line is required. aynı satırda




            #endregion


            #region For Döngüsü ile Karar Yapıları
            // 

            // i den gelen modu i'nin 5'e bölümünden kalan değer 0'sa bana i'yi yazdır.
            // for(int i = 1; i <= 100; i++)
            //{
            //     if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //üstüne tek tek alarak topluyor.
            // i başlangıcta 1 total value 0 topla 1 eder tekrar başa dönüyor 
            // i bir bir artıyor 10'a ulaşana kadar 1 2 3 4 ....10 <= olana kadar toplam değer de o sürecte sırasıyla toplanıyor.
            // i 1 totalVolue 0
            // i 2 oldu  ( i her döngü başında bir bir artıyor (i++) cünkü kural olarak)
            // i 2 totalvalue 1 idi sonuc 3 oldu
            // i 3 arttı totalvalue 3 idi  sonuc 6 oldu
            // i 4 arttı total value 6 idi sonuc 6+4 =10 oldu
            // i 5 arttı total value 10 idi 10+5 = 15 oldu
            // i 6 arttı total value 15 idi 15+6 = 21 oldu
            // i 7 arttı total value 21 idi 21+7 = 28 oldu
            // i 8 arttı total value 28 idi 28+8 = 36 oldu
            // i 9 arttı total value 36 idi 36+9 = 45 oldu
            // i 10 arttı total value 45 idi 45+10 = 55 oldu.
            // sonuc 55 .
            // i eşit 1'dir. bu i 'yi bir birer artırarak 10 kez döndür  
            // fakat  bu işlem içerisinde her adimda  totalvalue += i;  toplayarak ilerle şartım budur.

            //int totalvalue = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    totalvalue += i;

            //  }
            //Console.WriteLine(totalvalue);


            // i < 20 20den kücükse artir ama 20 olmaz < kücük ve eşit = 20 de alirdi
            //  if (i % 2 == 0) eğer i'nin 2'ye bölümden kalanı sıfırsa0'sa
            //  totalValue += i; totalValue değerinin üzerine i'yi ekle
            //  Console.WriteLine(totalValue); totalvalue göster.
            //  Console.WriteLine(i); her defasında i'yi yazdır dememizin sebebi; ikiye bölünen tam sayıları görcez.
            //int totalValue = 0;
            //for (int i =1; i< 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);

            //    }
            //}
            //Console.WriteLine("-----");
            //Console.WriteLine(totalValue);


            //- 1 ile 50 arasında 7'ye tam bölünen kaçtane sayı olduğunu bulalım.
            //  i eşit 1 'den başlasın, i kücük eşit 50 olana kadar bir bir artsın ++.
            // i'nin 7 ye bölümünden kalan 0'sa  tani i TAM bölünüyorsa count'değişkenini 1 artır.
            //int count = 0;
            //for(int i=1; i <= 50; i++ )
            //{
            //    if(i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);


            // 1-2-4-8-16....
            //  24 saatin sonunda kaçtane bakteri olur

            //int bacterium = 1;
            //for(int i = 1; i <= 24;  i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".Saat Sonunda: " + bacterium);
            //}



            #endregion


            #region While Döngüsü şart sağlandığı müddetçe anlamını taşır.
            //artırma işlemleri işlemin olduğu yerde yapılır
            //While(Şart)
            //{
            //işlemler
            //}


            //int i = 1;
            //// i kücük eşit 10 olduğu müddetce i 10dan kücük veya eşit olduğu müddetce şart kısmı
            //// Consola merhaba düny yazdır i++ bir bir artırarak 10'a eşit olana kadar yazdir.
            //while(i <= 10)
            //{
            //    Console.WriteLine("Merhaba Dünya");
            //    i++;
            //}


            // 1 ile 3'e tam bölünen sayıları bulalım karar yapılarıyla
            //int i = 1;
            //while (i <=10)
            //{
            //     if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            // 1 ile 10 sayılarının toplamı

            //int i = 1;
            //int toplama = 0;

            //while (i <= 10)
            //{
            //    toplama += i;
            //    i++;
            //}


            //Console.WriteLine(toplama);

            #endregion

            #region Örnek Sınav Sorusu

            // KLAVYEDEN GİRİLEN 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

            //456

            //Console.Write("Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundred;
            //int sum;
            //// sum = toplama demek
            //// birler onlar yüzler basamağını ayırmamız gerekiyor.

            //// sayının %10'a bölümünden kalan
            //ones = number % 10;
            //// sayının 100'e bölümü
            //hundred = number / 100; //4.56 --> 4
            //// sayı 100'e bölümünden kalanı.
            //tens = (number % 100) /10;
            //#endregion

            //Console.WriteLine(ones+ "-" + tens + "-" + hundred);

            //sum = ones + tens + hundred;

            //Console.WriteLine(sum);
            
            Console.Read();



        }






    }





}














