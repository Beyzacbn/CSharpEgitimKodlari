using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else  


            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru ");
            //}
            //else 
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}

            //string capital, country;
            //Console.WriteLine("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.WriteLine("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if(capital=="ankara" & country== "türkiye")  // büyük-küçük harf duyarlı
            //{
            //    Console.Write("veriler doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("hatalı bilgi");
            //}


            //int number;
            //Console.Write("Sayıyı giriniz: ");
            //number= int.Parse(Console.ReadLine()); //console default olarak string alır
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else 
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}



            //ilk değer ataması yapılmalı yoksa null olur hata verir ya da else seçeneği eklenmeli
            //(result'ı yazdırmadan hata aldık ilk değer ekledik)

            //int exam1, exam2, exam3, average;
            //string result= "Hata!";

            //Console.Write("Sınav1: ");
            //exam1=int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.Write("Sınavların ortalaması : " + average);

            //if (average > 0 & average <=50) 
            //{
            //    result = " Sonuç vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = " Sonuç orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = " Sonuç iyi";
            //}
            //if (average > 84 )
            //{
            //    result = " Sonuç çok iyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.WriteLine("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if(city =="adana" | city = "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}


            //Console.Write("Lütfen kullanıcı adı giriniz: ");
            //string userName = Console.ReadLine();
            //if(userName != "admin")
            //{
            //    Console.Write("Kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.Write("Hoş geldiniz");
            //}




            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);


            //Console.WriteLine("Lütfen 1.sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2.sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1%number2;
            //Console.Write("1.sayının 2.sayıya bölümünden kalan: " + result);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number= int.Parse(Console.ReadLine());

            //if(number%2 == 0)
            //{
            //    Console.WriteLine("Sayı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir");
            //}



            #endregion

            #region Char Değişkenler ile Karar Yapıları

            //char team;
            //Console.WriteLine("Lütfen takım sembolünü giriniz: ");
            //team=char.Parse(Console.ReadLine());

            //if(team== 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}

            //if(team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}

            //if(team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}

            //else
            //{
            //    Console.Write("Böyle bir takım bulunmamaktadır.");
            //}
            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("***** C# Eğiti Kampı Restorant *****");
            //Console.WriteLine();
            //Console.WriteLine("---------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("---------------");

            //string menuItem;
            //Console.WriteLine("Detayını görmek istediğiniz menüyü seçiniz:");
            //menuItem= Console.ReadLine();

            //if (menuItem == "1") //1 string olarak aldık
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Ana Yemekler-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //}

            //if (menuItem == "2") 
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Çorbalar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Ezogelin");
            //    Console.WriteLine("2-Mercimek ");
            //    Console.WriteLine("3-Tarhana ");

            //}

            //if (menuItem == "3") 
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Pizzalar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Margarita");
            //    Console.WriteLine("2-Karışık ");

            //}

            //if (menuItem == "4") 
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----İçecekler-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Su");
            //    Console.WriteLine("2-Çay ");
            //    Console.WriteLine("3-Kola ");
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Tatlılar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Sütlaç");
            //    Console.WriteLine("2-Baklava ");
            //    Console.WriteLine("3-Pasta ");
            //}
            #endregion

            #region Switch Case
            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı veri girişi"); break;
            //}
            #endregion

            #region Switch Case Hesap Makinesi

            int number1, number2, result;
            char symbol;
            Console.Write("1.sayıyı giriniz: ");
            number1=int.Parse(Console.ReadLine());

            Console.Write("2.sayıyı giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz: ");
            symbol=char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result=number1 + number2;
                    Console.WriteLine("Toplam: " +result);
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
