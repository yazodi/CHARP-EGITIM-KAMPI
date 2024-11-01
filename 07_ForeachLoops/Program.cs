using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region WriteLine --- Write farkı açıklaması
            //1 / Console.Write() ile imleç içeriğin sonunda kalacaktır.
            //    İçeriği konsolunuzda görüntüler ve imleci orada tutar(çıktının sonunda yanıp söner).
            //    2 / Console.WriteLine() ile — içerik konsol ekranına çıktı olarak
            //    verildikten sonra, imleç bir sonraki / yeni satırın başına taşınır ve orada bekler.

            #endregion

            #region Console.ReadLine Nedir
            // 1-) Mevcut metin dosyasını açar ve standart girişi klavyeden bu dosyaya yönlendirir.

            //2-) ReadLine() Yöntemi. Bu yöntem, standart giriş akışından bir sonraki karakter satırını okumak için kullanılır.
            // Konsol sınıfının (Sistem Ad Alanı) altındadır.

            #endregion

            #region float double nedir.
            // float = kesirli sayısal değerler için kullanılır. 
            // double = çok sayıda ondalık basamak içeren reel sayılar için kullanılır.
            #endregion

            #region Foreach Döngüsü


            //Foreach(1;2;3;4)

            //1:Değişken Türü
            //2:Değişken adı
            //3:In
            //4:Liste, Koleksiyon, Dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşoba" };

            //foreach(string x in cities)
            //{
            //    Console.WriteLine(x);

            //}


            //int[] numbers = { 45, 78, 985, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}




            // ikiye bölümden kalanı gösteriyor
            //int[] numbers = { 45, 78, 985, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //  foreach (int number in numbers)
            //  {
            //      if (number % 2 == 0 )
            //      {
            //          Console.WriteLine(number);
            //      }
            //  }
            //------------------------------------------
            // döngü içerisinde bir dizinin içinde yer alan sayıların toplamı

            //int[] numbers = { 45, 78, 985, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //int total = 0;


            //foreach(int i in numbers)
            //{
            //    total += i;
            //}

            //Console.WriteLine(total);

            //--------------------------------------------



            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //// listenin içerisinde ki öğelere ulaşmak için foreach kullandık. Böyle de kullanılabiliyor.
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            // bir kelimeyi harflerine ayıran ifade^yi yazalim

            //string word = "Merhaba";

            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}
            // Word isminde ki değişkeni char'a göre parçalar her bir harfini c'ye atayip alt alta yazar.










            //Console.Read();




            #endregion


             #region Örnek Sınav Sistemi Notlu


            // klavyeden öğrenci sayısı, isimleri, sınav notları, ortalamaları

            // değişken, döngü ,dizi kullanıcaz



            Console.Write("**** C# Eğitim Kampı Sınav Uygulaması *****"); //yazı yazıldı imlec yanında kaldı
            Console.WriteLine(); //boşluk
            Console.WriteLine();  //boşluk
            Console.WriteLine();  //boşluk
            Console.WriteLine(); //boşluk

            //Sınıftaki Öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("----------------------------"); // ---- içerik girdi imlec aşşağı iner fakat sıradaki ni yazdırır
            Console.Write("Sınıfınızda Kaç Öğrenci Var: "); // sıradakini yazdı yani bunu sonra imlec yana aldı.
            int studentCount = int.Parse(Console.ReadLine());  // int tam sayı tanımlama - StudentCount öğrenci hesaplaması. = atadık int.Pase tam sayı pars et (console.ReadLİne) karakter satırını oku dedik.
            Console.WriteLine("----------------------------");



            //Öğrenci isimlerini ve not ortalamalarını saklayacak diziler.

            //string bir izi oluşturuyoruz strint[] 
            // StudentNames (Öğrenci İsimleri) atadık  
            // studentCount Öğrenci Notları/hesapları*
            // string dizisine studentNames - studentCount adında iki dizi oluşturduk


            //Burda diyoruz ki StudentNames! sen boyutunu StudentCount'tan alacaksın.
            // student count'a kaç girersek o kadar öğrenci bilgisi tutuyor olacağız.

            string[] studentNames = new string[studentCount];
            //studentExamAvg -- Ortalama demek
            //double = çok sayıda ondalık basamak içeren reel sayılar için kullanılır.
            double[] studentExamAvg = new double[studentCount];
            // studentExamAvg - Öğrenci Ortalaması - sende boyutunu sstudent counttan al.
            // Student count'a kaç girersek o kadar öğrenci ortalaması tutacağuız



            //int i eşit 0'a i(0) kücük studentCount'tan bir bir artır (koşul)
             for(int i = 0; i < studentCount; i++)
            { //her öğrenci için, notları toplamamız gerekiyor.
                //i eşittir 0'dan başlasin i kücüktür studetcount olana kadar bir bir artsın.

                          //i+1'inci öğrencinin ismini giriniz.
                Console.Write($"{i + 1}. Öğrencinin İsmini giriniz :  ");
                studentNames[i] = Console.ReadLine();
                //studentin' i'ninci değerinin  console.ReadLine'dan gelen değer.
                double totalExamResult = 0;
                // toplam sınav notları başlangıcta 0 olsun.

                //array klasöründe region= Kullanıcıdan Değer Alma kısmında $ acıklaması var ordan bakarsın.
                // consoleWrite içindeki $ işareti hakkında : cift tırnak içerisinde parametresel ifadeler kullanmak için kullanılan semboldür
                // cift tırnağın bütünlüğünü bozmamak için kullanıyoruz { }


                //----her öğrenci için 3 sınav notu girişi.

                for(int j = 0; j < 3; j++)
                {
                    // konsol yazdır dolar sembolu parametre cağırıyoruz süslü parantezle de kapatıp tırnağı bozmuyoruz
                    //konsole yazdır.
                    //studenNames'i'nnci değeri adlı j + 1'inci sınav değerini giriz
                    // kısacası öğrenci isminin i'ninci değeri j' 1'inde de de sınav notunu gir dedik.
                    Console.Write($"{studentNames[i]}  adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
                    // double value tanımladık. double parse et consola readline et dedik.
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; // notları topluyoruz.

                }
                // birinci öğrenci içinstudentExamAvg i'ninci değeri -- toplam değerden 3'e bölümden gelen sonuc 
                studentExamAvg[i] = totalExamResult / 3;
            }

             // Öğrencilerin ortalaması ve geçip kalma durumları
             for (int i = 0; i < studentCount; i++)
            {

                Console.WriteLine($"{studentNames[i]}  adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                //öğrencilerin ortalaması ve geçip kalma durumları

                if (studentExamAvg[i] >= 50)
                    // ortalamanın sonucu i 50'den büyükse  öğrenci dersi geçti
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");

                }
                else // değilse kaldı.
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı ");
                }
                Console.WriteLine("--------------------------");
            }


             //101 modülü sytax
             //201 hacker rank algoritma soruları
             //301 sql sonra method
             //401 c# sql beraber kullanımı
             // farklı bir veri tabanıyla çalışma
             //tasarım deseni
             //api temeli anlatılcak.










            Console.Read();






            #endregion

            #region Örnek Sınav Sistemi kodlu


            
            //Console.Write("**** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine(); 
            //Console.WriteLine();  
            //Console.WriteLine();  
            //Console.WriteLine();

            ////Sınıftaki Öğrenci sayısını kullanıcıdan alma
            //Console.WriteLine("----------------------------");
            //Console.Write("Sınıfınızda Kaç Öğrenci Var: "); 
            //int studentCount = int.Parse(Console.ReadLine()); 
            //Console.WriteLine("----------------------------");



            ////Öğrenci isimlerini ve not ortalamalarını saklayacak diziler.


            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];
   
      
            // for(int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. Öğrencinin İsmini giriniz :  ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;



            //    //her öğrenci için 3 sınav notu girişi.

            //    for (int j = 0; j <3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz :  }");
            //            double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value; //notları topluyoruz.

            //    }
            //    studentExamAvg[i] = totalExamResult / 3;

            //}

            // //Sınav Ortalamaları 
            // for( int i = 0; i < studentCount; i++ )
            //{
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

            //    // Öğrencilerin ortalaması ve geçip kalma durumları.
            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");

            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
            //    }
            //}





            #endregion
        }
    }
}
