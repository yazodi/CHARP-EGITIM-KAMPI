using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Metotlar.

            // Parse Console.Write() - Console.WriteLine() vs hazır methodlardı
            // kendi methodlarımızı oluşturacaz.

            // bir kodun metot olup olmadığıını anlamak için () diye bakıyoruz
            // ()
            // yukardaki mainde bir method mouse üzerine tuttuğumuzda mor kutu görürüz method demek


            //Medhodlar ikiye ayrılır. 
            //Geriye Değer Döndürmeyen  metotlar
            //Customer * Listele , ekle, ssil, güncelle
            // ekliyorsun listenin son halini görüyorsun siliyorsun son halini görüyorsun
            // void 

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("AYSE Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");



            //}



            //CustomerList();

            // özellikle geriye değer döndürmeyen metotlar, belli işlemleri tekrardan kurtarmak için programlamada yeri önemlidir.



            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();











            #endregion


            #region Geriye Değer Döndürmeyen Paremetreli Metotlar.


            //void WriteMethod(string customerNAME)

            //{
            //    Console.WriteLine(customerNAME);
            //}

            //WriteMethod("Mehmet Yıldırım");
            //----




            //müşterinin adını soy adını alıyoruz
            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);

            //}

            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşegül", "Kaya");




            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar.

            //void yazdığımız için geriye değer döndürmüyor.
            //yerine int koysaydik döndürürdü

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(4, 5, 6);







            #endregion


            #region Geriye Değer Döndüren Metotlar.

            //voidtten farklı olarak, değişken koleksiyon dizi döndürebiliyoruz
            //artık boyut olarak tanımlanmıyor.
            // bir değişken ya da sınıf türüyle tanımlanması gerekiyor.


            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}


            //CustomerName();



            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surName = "Kaya";

            //    return name + " " + surName;
            //}

            //Console.WriteLine(StudentCard());







            #endregion


            #region Geriye Değer Döndüren String Parametreli Metotlar.


            //  string CountryCard(string countryName, string capital, string flagColor)

            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;

            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz:  ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz:  ");
            //z = Console.ReadLine();


            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı - Beyaz"));



            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));




            #endregion

            #region Örnek uygulama
            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{

            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " isimli öğrenci sınavı geçti " + "Ortalama: " + result;

            //    }
            //    else
            //    {
            //        return student + " isimli Öğrenci sınavı geçemedi " + "Ortalama: " + result ;



            //    }




            //}

            //Console.WriteLine(ExamResult("Ali", 25, 41, 55));

            //Console.WriteLine(ExamResult("Ayşe", 36, 88, 33));




            #endregion



            Console.Read();

        }

    }
  }

