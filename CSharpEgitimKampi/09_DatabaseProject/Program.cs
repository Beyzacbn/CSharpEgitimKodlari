using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net

            Console.WriteLine("***** C# VERİTABANLI ÜRÜN-KATEGORİ BİLGİLENDİRME SİSTEMİ *****");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            string tableNumber = Console.ReadLine();
            Console.WriteLine("-----------------------------------");

            SqlConnection connection = new SqlConnection("Data Source = DESKTOP-7L0UFKL;initial Catalog =EgitimKampiDb;integrated security =true ");

            connection.Open();
            SqlCommand command = new SqlCommand("select * from TblCategory",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command); //sql c# arası köprü
            DataTable dataTable = new DataTable(); // verileri belleğe alır.
            adapter.Fill(dataTable);
            connection.Close();

            foreach(DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }


            Console.Read();

        }
    }
}
