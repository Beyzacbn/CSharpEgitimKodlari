using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("selam"); // imleci alt satıra gönderir

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("Çorbalar");
            //Console.WriteLine("Ana Yemekler");
            //Console.WriteLine("Soğuk Başlangıçlar");
            //Console.WriteLine("Tatlılar");
            //Console.WriteLine("İçecekler");
            //Console.WriteLine();

            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region String Değişkenler 

            ////string name;
            ////name= "Beyza";
            ////Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail,district,city;

            //customerName = "Ali";
            //customerSurname = "ÇINAR";
            //customerPhone = "+90 500 400 30 40";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------");
            //Console.WriteLine("Müşteri:" + customerName +" "+ customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email Adresi:" + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("-------------------------");
            //Console.WriteLine();
            //customerName = "Ayşegül";
            //customerSurname = "Beyaz";
            //customerPhone = "+90 500 567 34 40";
            //customerEmail = "deneme2@gmail.com";
            //district = "Kartal";
            //city = "İstanbul";

            //Console.WriteLine();
            //Console.WriteLine("-------------------------");
            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email Adresi:" + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("-------------------------");


            #endregion

            #region int Değişkenler

            
            //int number = 49;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int pizzaPrice = 200;
            int friesPrice = 50;
            int lemonadePrice = 45;
            int waterPrice = 10;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine("-----Hamburger Fiyatı:" + hamburgerPrice + "TL");
            Console.WriteLine("-----Kola Fiyatı:" + cokePrice + "TL");
            Console.WriteLine("-----Pizza Fiyatı:" + pizzaPrice + "TL");
            Console.WriteLine("-----Kızartma Fiyatı:" + friesPrice + "TL");
            Console.WriteLine("-----Su Fiyatı:" + waterPrice + "TL");
            Console.WriteLine("-----Limonata Fiyatı:" + lemonadePrice + "TL");

            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int pizzaCount;
            int waterCount;
            int friesCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalPizzaPrice;
            int totalFriesPrice;
            int totalLemonadePrice;
            int totalWaterPrice;

            hamburgerCount = 3;
            cokeCount = 2;
            pizzaCount=1;   
            waterCount = 2;
            friesCount = 3;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;         
            totalFriesPrice = friesCount * friesPrice;
            totalWaterPrice = waterCount * waterPrice;
            totalPizzaPrice= pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("-----------------------");
            Console.WriteLine("Hamburger tutarı : " +totalHamburgerPrice + "TL");
            Console.WriteLine("Kola tutarı : " +totalCokePrice + "TL");
            Console.WriteLine("Pizza tutarı : " +totalPizzaPrice + "TL");
            Console.WriteLine("Su tutarı : " +totalWaterPrice + "TL");
            Console.WriteLine("Kızartma tutarı : " +totalFriesPrice + "TL");
            Console.WriteLine("Limonata tutarı : " +totalLemonadePrice + "TL");

            Console.WriteLine();
            int totalPrice = totalHamburgerPrice + totalFriesPrice + totalCokePrice + totalLemonadePrice + totalPizzaPrice + totalWaterPrice;

            Console.WriteLine("Toplam ödenecek tutar: " + totalPrice + "TL");



            #endregion

            Console.Read();

        }
    }
}
