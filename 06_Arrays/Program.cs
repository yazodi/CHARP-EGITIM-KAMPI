using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            // 2 4 6 8 çift sayı dizisi
            // sarı, kırmızı,mavi,turuncu,beyaz renkler dizisi
            // adana, ankara , istanbul, bursa şehir dizisi 
            // DeğişkenTürü [] DiziAdı = new DeğişkenTürü[ElemanSayısı]

            // BU DİZİ 4 elemandan oluşacak
            //string[] colors = new string[4];
            //// 0 1 2 3 4 5 6 0'dan saymaya başlar.
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);
            //// sonuc beyaz'dır.


            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[5]);
            //sonuc hatalı dizi de 5ci eleman yoktur. sınırı dışındadır. istek.

            // illede 10 boyutunda dedik diye 10'cu elamanı doldurmamıza tanımlamamıza gerek yok

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;
            //Console.WriteLine(numbers[5]);

            // 10'cu elemanı cağırsaydik consol da 0' yazısını gördük 10'un içini doldurmasakta vardır ama sonuc 0 gösterir deffault olarak.

            //string[] cities = { "prag", "Roma", "Atina", "Ankara", "Bursa" };

            //Console.WriteLine(cities[2]);



            #endregion


            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = {"Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe{};

            // for (int i = 0; i <colors.Length; i++)
            //{
            //Console.WriteLine(colors[i]);

            //  i <colors.Length; yerine i <= colors.Length; diyemeyiz hata verir.

            // yani abim dizi uzunluğunda kücük eşit demek yasak kücük yapacağız daima <


            //int[] numbers = { 4, 85, 96, 74, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for(int i=0; i<numbers.Length; i++)
            //{
            //    // NUMBERS'sin i değeri mod 3 eşit eşit 0'a
            //    //yani naumbers'ın i li dizi değerinin 3'e kalanı 0'sa o i'ye karşılık gelendeğeri consola yazdır.
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            // burda değişken tanımlama döngü karar yapısı ve dizi hepsi tek bir örnekte gösterilmiş oldu.
            // char dizisindde de dizi oluşturabilirsiniz

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '_' };

            //    for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}


            // dizideki en büyük elemanı bulan sayıyı yapalım.

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 10 };

            // başlangıcta 0 ıncı index(47) değerini büyük olduğunu kabul ettik.
            //int maxNumber = myArray[0];


            // eğer arrayin i'nin ci elemanı büyükse benim oluşturmuş olduğum değişkinin değerinden,
            // ozaman benim oluşturmuş olduğum değişkene array'in i'ninci elemanını ata işlemler bitince maxnumber bana yazdır.
            //for(int i=0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);



            // dizi methodları var biri length 'di

            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length); 
            // length dizinin uzunluğunu bize verdi = 6


            // sort methodu  "Sıralamaya yarıyor"

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);
            //for(int i = 0; i< numbers.Length[i];

            // reverse methodu tam tersi yapıyor. tersten sıralıyor 35,22, 10 şeklinde

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers);
            //for (int i = 0;i < numbers.Length; i ++)
            //    {
            //    Console.WriteLine(numbers[i]);
            //}



            #endregion


            #region Dizi Metotlar

            // İndex.of metodu dizi içinde aranan değerin index sırasını döndürüyor.

            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);


            // max min methodları istediğimiz sonucu direkt olarak en büyük en kücük bulabiliriz.

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max() + "Dizinin en kücük elemanı:" + numbers.Min());





            #endregion


            #region Kullanıcıdan Değer Alma

            // consoleçwrite içindeki $ işareti hakkında : cift tırnak içerisinde parametresel ifadeler kullanmak için kullanılan semboldür
            // cift tırnağın bütünlüğünü bozmamak için kullanıyoruz { }




            //string[] cities = new string[5];

            //for(int i=0; i<cities.Length; i++)
            //{
            //    Console.Write($"lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();

            //}

            //// yukarı daki kodda kullanıcıdan alıyoruz.

            //Console.WriteLine();
            //Console.WriteLine("-----------------");

            //for(int i=0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            // tam sayısı dizisi oluşturup tam sayıların toplamını yapalım.

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for(int i=0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);



            //-----

            // dizilerin içindeki sayıları tek - çift olarak ayrı listeleyelim.

            //int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };

            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    // sayıların 2ye bölümünden kalanı 0 ise doğal olarak çift sayı olur.
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("---------");
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    // sayıların 2ye bölümünden kalanı 1 ise doğal olarak tek sayı olur.
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}






            #endregion




            Console.Read();
        }
    }
}
