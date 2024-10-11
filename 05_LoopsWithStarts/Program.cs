using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStarts
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region Alt alta 10 tane yıldız oluşturma


            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region yan yana 10 tane yıldız oluşturma


            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region Alt alta 10 tane yıldız oluşturma, her satırda 10 tane yıldız olsun.


            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}

            #endregion


            #region Dik üçgen

            // önce  i for'un içindeki for j döngüsünü yazdı
            // içteki şart sağlanınca write komutuyla iki kez j yazdırdı yani yıldız  yan yana
            // sonra en içteki j döngüsü bitince      Console.WriteLine();// alt satır. komutu calişti
            // bir satır assağı inti sonra en dıştaki i döngüsü çalıştı bu işlem 5 kez olana kadar
            // **
            // **
            // ** şeklinde 

            // j<=2 yerine j<=i yaptık  
            // for i 5 olana kadar devam edecektir. i içinde J' şartını barındırır
            // j i'ye şit olana kadar kendi şartını döndürür i'ye göre
            // i 1 den başlan peki j sende 1 misin. evet console write *
            // i bir bir arttığı için sonraki döngüde 2 olur
            // i 2 peki j sende iki olana kadar kendi şartını döndür
            // kendi şartı i eşit olana kadar birer birer * yazdırmaktır.
            // i 2dir j de 2 tane yıldızı döndürünce dışarı cikar console.writeline alt satıra geçirir
            // i 3 olur j de i 3 se benimde kendimi 3 kere döndürmem gerek diyip döner olunca tekrar alt satıra geç komutuna gider
            // for döngüsü i başa döner bu sefer 4 olur forun içinde ki for de kendini 4 olana kadar artırır böyle gider.

            //for (int i = 1; i <= 5; i++)
            //{
            //    for(int j=1; j<= i; j++)
            //    {
            //        Console.Write("*"); //aynı satır
            //    }
            //    Console.WriteLine();// alt satır.
            //}

            #endregion


            #region Ters Dik Üçgen

            //for (int i = 5; i >=1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }

            //   Console.WriteLine();
            //}


            #endregion



            #region Dik ve ters dik üçgen beraber

            //for(int i =1; i<=5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine(); 
            //}


            //for (int k = 4; k>= 1; k--)
            //{
            //    for(int m = 1; m<= k; m++)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();
            //}


            #endregion


            #region baklava dilimi.

            //üst kısım
            //int n = 5;

            //for (int i = 1; i <= n; i++)
            //{
            //    for(int j = n -1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }


            //for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //    Console.Write("*");
            //     }
            //Console.WriteLine();

            //}

            //// alt kısım

            //for (int i = n - 1; i>= 1; i--)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k =1; k<= 2* i -1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}







            #endregion


            #region Piramit

            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{   
            //    //boşluklar
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    // yıldızlar
            //    for (int k = 1; k <= 2*i -1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();


            //}




            #endregion

            #region Ters Piramit

            int n = 5;
            for (int i = n; i >= 1; i--)

            {
                for(int j = n -i; j> 0; j--)
                {
                    Console.Write(" ");

                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();




            }




            #endregion


            Console.Read();











        }
    }
}
