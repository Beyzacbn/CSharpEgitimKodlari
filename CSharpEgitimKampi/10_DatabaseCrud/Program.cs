using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crud--> Create-Read-Update-Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            #region Kategori ekleme işlemi

            //Console.WriteLine("---------------");
            //Console.Write("Eklemek İstediğiniz Kategori Adı : ");
            //string categoryName= Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-7L0UFKL; initial catalog= EgitimKampiDb ; integrated security=true ");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into tblCategory (CategoryName) values (@p1)",connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori başarıyla eklendi.");

            #endregion

            #region Ürün ekleme işlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürünün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source = DESKTOP-7L0UFKL; initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct(ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)",connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Ürün eklemesi başarılı!!");

            #endregion

            #region Ürün listeleme işlemi


            //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-7L0UFKL;initial Catalog =EgitimKampiDb;integrated security =true ");

            //connection.Open();
            //SqlCommand command = new SqlCommand("select * from TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command); // köprü
            //DataTable dataTable = new DataTable(); // verileri belleğe alır.
            //adapter.Fill(dataTable);


            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString()+" ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();
            #endregion

            #region Ürün silme işlemi

            //Console.WriteLine("Silinecek ürünün id : ");
            //int productId=int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-7L0UFKL;initial catalog =EgitimKampiDb;integrated security =true ");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete from TblProduct where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Silme işlemi yapıldı");

            #endregion

            #region Ürün güncelleme işlemi

            Console.WriteLine("Güncellenecek ürün id: ");
            int productId = int.Parse(Console.ReadLine());

            Console.WriteLine("Güncellenecek ürün adı: ");
            string productName= Console.ReadLine();

            Console.WriteLine("Güncellenecek ürün fiyatı: ");
            decimal productPrice= decimal.Parse(Console.ReadLine());


            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-7L0UFKL ; initial catalog =EgitimKampiDb; integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Update TblProduct set ProductName=@productName,ProductPrice=@productPrice where ProductId=@productId",connection);
            command.Parameters.AddWithValue("@ProductName", productName);
            command.Parameters.AddWithValue("@ProductPrice",productPrice);
            command.Parameters.AddWithValue("ProductId", productId);
            command.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine("Güncelleme başarılı!");



            #endregion









            Console.Read();

        }
    }
}
