using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void metotlar
            //    //Geriye değer döndürmeyen metotlar - void
            //    //customer-> Listele,ekle,sil,güncelle

            //    void CustomerList()
            //{
            //        Console.WriteLine("Ali Yıldız");
            //        Console.WriteLine("Ayşe Yıldız");
            //        Console.WriteLine("Fatma Kara");
            //        Console.WriteLine("Ali Güneş");
            //}
            //    CustomerList();
            //    CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();
            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Beyza NEMLİ");

            //void CustomerCard(string name,string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}

            //CustomerCard("Beyza", "NEMLİ");
            //CustomerCard("Uğur", "NEMLİ");


            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1,int number2,int number3)
            //{
            //    int result=number1+number2+number3;
            //    Console.WriteLine("Toplam: " +result);
            //}
            //Sum(3, 4, 5);


            #endregion

            #region  Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();  // bu şekilde çağrıldığında Buse yıldız ismi geri döndürülür ama ekranda çıktı olmaz.


            //string StudentCard()
            //{
            //    string studentName = "Ali";
            //    string studentSurName = "Kaya";
            //    return studentName +" " +studentSurName;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital,string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x= Console.ReadLine();
            //Console.Write("Başkenti giriniz: ");
            //y= Console.ReadLine();
            //Console.Write("Bayrak Rengini giriniz: ");
            //z= Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine("Türkiye", "Ankara", "Kırmızı-Beyaz");

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1,int number2)
            //{
            //    int result=number1+number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(34, 56));
            //Console.WriteLine(Sum(67, 78));
            //Console.WriteLine(Sum(56,23));
            //Console.WriteLine(Sum(23, 56));


            #endregion

            #region Örnek Uygulama

            string ExamResult(string studentName, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return studentName + " isimli öğrenci sınavı geçti " + "Ortalama: " + result;
                }
                else
                {
                    return studentName + " isimli öğrenci başarısız oldu " + "Ortalama: " + result;
                }

            }
            Console.WriteLine(ExamResult("Ali", 34, 23, 78));
            Console.WriteLine(ExamResult("Beyza", 46, 76, 87));
            #endregion


            Console.Read();
        }
        
    }
}
