using System;
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

            //Değişken Türü [] DiziAdı=new DeğişkenTürü[Eleman Sayısı]

            //string[] colors = new string[4];
            //colors[0]= "kırmızı";
            //colors[1]= "mavi";
            //colors[2]= "yeşil";
            //colors[3]= "sarı";
            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0]= "Milano";
            //cities[1]= "Lyon";
            //cities[2]= "Budapeşte";
            //cities[3]= "Üsküp";
            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 1;
            //numbers[1] = 24;
            //numbers[2] = 33;
            //numbers[3] = 42;
            //numbers[7] = 467;
            //Console.WriteLine(numbers[5]); //bu elemana değer ataması yapılmadığı için default 0 atanır.

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara" };
            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme
            //string[] colors = { "sarı", "kırmızı", "beyaz", "yeşil", "turuncu" };
            //for(int i=0;i<colors.Length; i++) 
            //{ 
            //    Console.WriteLine(colors[i]); 
            //}
            #endregion

            #region Diziler Karışık Örnekler(for-if-mod)

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for( int i = 0; i < numbers.Length;i++ )
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++) 
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 100 };
            //int maxNumber = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] persons ={"ali","ahmet","ayşe","buse","beyza","cem"};
            //Console.WriteLine(persons.Length);

            #endregion

            #region Dizi Metotları

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers); //küçükten büyüğe doğru sıralar
            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers); //listeyi sondan başa doğru çevirir
            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //string[] customers = { "ali", "buse", "ayşe", "uğur", "erkan", "ertan" };
            //int index = Array.IndexOf(customers, "uğur"); //elemanın kaçıncı sırada olduğunu verir
            //Console.WriteLine(index);

            //int[] numbers = { 45, 85, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin en büyük elemanı: " +numbers.Max() + " Dizinin en küçük elemanı: " +numbers.Min());
            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++) 
            //{ 
            //    Console.Write($"Lütfen {i+1}.Şehri giriniz: "); //$ satırdaki {i+1} için kullanılır
            //    cities[i]=Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("----------------------");
            //for (int i = 0; i < cities.Length; i++) 
            //{
            //    Console.WriteLine(cities[i]);
            //}

            #endregion

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++) 
            //{ 
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);


            //int[] numbers = { 21, 43, 45, 68, 34, 22, 879, 456 };
            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("--------------------------");
            //Console.WriteLine();
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();
            //for(int i = 0; i < numbers.Length; i++) 
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            Console.Read();
        }
    }
}
