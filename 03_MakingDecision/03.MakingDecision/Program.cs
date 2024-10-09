using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ctrl K + D kodları düzenliyor
namespace _03.MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If
            // if eğer password eşit eşitse abcd'ye cümle bitmedi
            //Console.Write("Lütfen Şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");

            //}


            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if(capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("veriler doğrulandı");
            //}
            //else
            //{
            //    Console.Write("hatalı bilgi");
            //}


            //int number;
            //Console.Write("Sayıyı Giriniz:  ");
            //number = int.Parse(Console.ReadLine());
            //// klavyeden okunan değere dönüşüm uyguladım.
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Hatalı");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "HATA!";

            //Console.Write("Sınav1: ");
            //exam1.int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2.int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //((uint)exam3).Parse(Console.ReadLine());

            //avarage = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması:   " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if (average > 70 & average <= 84)

            //{
            //    result = "Sonuç iyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç Çok iyi";
            //}

            //Console.WriteLine(result);



            //string city;
            //Console.Write("Lütfen Şehir Girişi yapınız");
            //city = Console.ReadLine();

            //if(city =="adama" | city=="ankara" | city=="bursa" | city== "trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir bulunamadı");
            //}



            //Console.Write("Lütfen kullanıcı adınızı giriniz: ");
            //string username = Console.ReadLine();

            //if (username != "admin") ;

            //{
            //    Console.Write("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.Write("Hoşgeldiniz");
            //}




            #endregion else

            #region Mod işlemleri iki sayının birbirine bölümünden kalanı

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1.sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write(" 1.Sayının 2.sayıya bölümünden kalan: " + result);

            // if else bağlama

            // bir sayının tek mi cift mi olduğunu bulalım.

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //// eğer numberin 2'ye kalanı eşit eşit se 0'a
            //if (number %2 ==0)
            //{
            //    Console.Write("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayı tektir");
            //}

            #endregion


            #region Char Değişkenler ile karar yapıları
            //char team;
            //Console.Write("lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());
            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}









            #endregion



            #region Örnek Proje Uygulaması
            //Console.WriteLine("***** C# Eğitim Kampı Restoran ***");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine();



            ////string menuItem;
            ////Console.Write("Detayını görmek istediğiniz menü seçimi:  ");
            ////menuItem = Console.ReadLine();

            ////if (menuItem == "1")
            ////{
            ////    Console.WriteLine();
            ////    Console.WriteLine("----------- Ana Yemekler -------");
            ////    Console.WriteLine();
            ////    Console.WriteLine("1- Köri Soslu Tavuk ");
            ////    Console.WriteLine("2- Kızartma Tabağı ");
            ////    Console.WriteLine("3- Fasulye Pilav ");
            ////    Console.WriteLine("4- Fırında Somon ");
            ////    Console.WriteLine("5- Patlıcan Musakka ");




            ////    Console.WriteLine();



            ////}

            ////if (menuItem == "2")
            ////{
            ////    Console.WriteLine();
            ////    Console.WriteLine("----------- Çorbalar -------");
            ////    Console.WriteLine();
            ////    Console.WriteLine("1- Mercimek Çorbası ");
            ////    Console.WriteLine("2- Ezogelin Çorba ");
            ////    Console.WriteLine("----------- Çorbalar -------");
            ////    Console.WriteLine();



            ////    Console.WriteLine();



            ////}

            ////if (menuItem == "3")
            ////{
            ////    Console.WriteLine();
            ////    Console.WriteLine("----------- Pizzalar -------");
            ////    Console.WriteLine();
            ////    Console.WriteLine("1- Akdeniz Pizza ");
            ////    Console.WriteLine("2- Margaritha Pizza ");
            ////    Console.WriteLine("3- Tavuklu Pizza ");
            ////    Console.WriteLine("----------- Pizzalar -------");
            ////    Console.WriteLine();



            ////    Console.WriteLine();



            ////}

            ////if (menuItem == "4")
            ////{
            ////    Console.WriteLine();
            ////    Console.WriteLine("----------- İçecekler -------");
            ////    Console.WriteLine();
            ////    Console.WriteLine("1- KOLA");
            ////    Console.WriteLine("2- Ayran ");
            ////    Console.WriteLine("2- Su ");
            ////    Console.WriteLine("----------- İçecekler -------");
            ////    Console.WriteLine();



            ////    Console.WriteLine();



            ////}

            ////if (menuItem == "5")
            ////{
            ////    Console.WriteLine();
            ////    Console.WriteLine("----------- Tatlılar -------");
            ////    Console.WriteLine();
            ////    Console.WriteLine("1- Triliçe");
            ////    Console.WriteLine("2- Kazandibi ");
            ////    Console.WriteLine("2- Sütlaç ");
            ////    Console.WriteLine("----------- Tatlılar -------");
            ////    Console.WriteLine();



            ////    Console.WriteLine();



            ////}

            #endregion


            #region Switch Case
            // Switch kod bloğumuzun anahtar kısmı.
            // Case ise bu anahtarın durumları.
            // klavyeden gelen sayıya göre yılın aylarını veren uygulama
            // break bitirdim demek oluyor.
            //            Console.Write("Lütfen Ay Girişi Yapınız:  ");

            //            int monthNumber = int.Parse(Console.ReadLine());

            //            switch (monthNumber)
            //            {
            //                case 1: Console.Write("Ocak");break;
            //                case 2: Console.Write("Şubat"); break;
            //                case 3: Console.Write("Mart"); break;
            //                case 4: Console.Write("Nisan"); break;
            //                case 5: Console.Write("Mayıs"); break;
            //                case 6: Console.Write("Haziran"); break;
            //                case 7: Console.Write("Temmuz"); break;
            //                case 8: Console.Write("Ağustos"); break;
            //                case 9: Console.Write("Eylül"); break;
            //                case 10: Console.Write("Ekim"); break;
            //                case 11: Console.Write("Kasım"); break;
            //                case 12: Console.Write("Aralık"); break;
            //                default: Console.Write("Hatalı veri girişi");break;
            //// bu 12 sayısı dişinda farklı veri girilirse hatalı diyecek koddur.              



            //            }

            #endregion


            #region Switch Case Hesap Makinesi


            int number1, number2, result;
            char symbol;

            Console.Write("1.Sayıyı giriniz: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("2.Sayıyı giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen yapmak istediğiniz işlemi giriniz:  ");
            symbol = char.Parse(Console.ReadLine());



            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Toplam: " + result);
                    break;


                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Fark: " + result);
                    break;


                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpım: " + result);
                    break;


                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Bölüm: " + result);
                    break;
            }

            #endregion




            Console.Read();




        }
    }
}



















