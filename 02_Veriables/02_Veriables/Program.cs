using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //double number;

            //number = 4.85;


            //Console.WriteLine(number);


            #region Double Değişkenler

            //           Console.WriteLine("***** Fiyat Listesi ****");
            //           Console.WriteLine();

            //           double applePrice,orangePrice,strawberryPrice,potatoPrice,tomatoPrice;

            //           applePrice = 14.85;
            //           orangePrice = 20.95;
            //           strawberryPrice = 45;
            //           potatoPrice = 9.74;
            //           tomatoPrice = 6.88;

            //           Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " TL");
            //           Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //           Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //           Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + " TL");
            //           Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " TL");

            //           Console.WriteLine();
            //           Console.WriteLine();

            //           double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;



            //           appleGram = 1.245;
            //           orangeGram = 2.650;
            //           strawberryGram = 0.750;
            //           potatoGram = 4.859;
            //           tomatoGram = 3.745;

            //           double appleTotalPrice = appleGram * applePrice;
            //           double orangeTotalPrice = orangeGram * orangePrice;
            //           double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //           double potatoTotalPrice = potatoGram * potatoPrice;
            //           double tomatoTotalPrice = tomatoGram * tomatoPrice;


            //           Console.WriteLine("Alınan Ürünün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj " + appleGram + " -Toplam" + "tutar: " + appleTotalPrice);
            //           Console.WriteLine("Alınan Ürünün: Elma - " + "Birim Fiyat: " + orangePrice + " - Gramaj " + orangeGram + " -Toplam" + "tutar: " + orangeTotalPrice);
            //           Console.WriteLine("Alınan Ürünün: Elma - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj " + strawberryGram + " -Toplam" + "tutar: " + strawberryTotalPrice);
            //           Console.WriteLine("Alınan Ürünün: Elma - " + "Birim Fiyat: " + potatoPrice + " - Gramaj " + potatoGram +  " -Toplam" + "tutar: " + potatoTotalPrice);
            //           Console.WriteLine("Alınan Ürünün: Elma - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj " + tomatoGram + " -Toplam" + "tutar: " + tomatoTotalPrice);

            //           Console.WriteLine();
            //           Console.WriteLine();


            //               double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice +
            //potatoTotalPrice + tomatoTotalPrice;

            //           Console.WriteLine("Alışveriş Toplam Tutar:" + shoppingTotalPrice + " TL");


            #endregion


            #region Char Değişkenler

            //ABCDEFGH
            //DEF...
            // TOPLANTI SAAT 20.00'DE  tek tek karakterleri ele almak CHAR değişkeni.
            //' charlar tek tırnak ile tanımlanıyor.

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);





            #endregion


            #region Klavyeden Veri Girişleri String Değişkenler


            //Console.WriteLine("**** Charp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();


            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNum;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();


            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu Tc Kimlik No: ");
            //passengerIdentityNum = Console.ReadLine();

            //Console.WriteLine();





            //Console.WriteLine("------------------------");
            //Console.WriteLine("Yolcu: " + passengerName + "Soyadı: " + passengerSurname  + "İlçe bilgisi  " + passengerDistrict +
            //     "Şehir bilgisi: " + passengerCity + "Yolcu Yaş " +  passengerAge + "Tc Kimlik: " + passengerIdentityNum);


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //ABC12D

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız Bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());


            //Console.Write("Lütfen aldığınız Sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız Televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());


            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount
            //    * chairPrice + tvCount * tvPrice;


            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar:  " + totalPrice);



            #endregion


            #region Klaveden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.WriteLine("Lütfen 1.Sınav notunu giriniz :   ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 1.Sınav notunu giriniz :   ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 1.Sınav notunu giriniz :   ");
            //exam3 = double.Parse(Console.ReadLine());


            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result );







            #endregion

            #region Klavyeden Karakter Girişleri


            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet " + gender);





            #endregion





            Console.Read();



        }
    }
}
