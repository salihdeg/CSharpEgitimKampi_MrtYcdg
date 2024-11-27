using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    public class Program
    {
        static void Main(string[] args)
        {
            // CRUD -> Create, Read, Update, Delete
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EgitimKampiDb;Integrated Security=True;");

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("----------------------------------");
            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek istediğiniz kategori adı: ");
            //string categoryName = Console.ReadLine();

            //connection.Open();

            //SqlCommand instertCommand = new SqlCommand("INSERT INTO TblCategory (CategoryName) VALUES (@categoryName)", connection);

            //instertCommand.Parameters.AddWithValue("@categoryName", categoryName);
            //instertCommand.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi!");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Eklemek istediğiniz ürün adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Eklemek istediğiniz ürün fiyatı: ");
            //productPrice = Convert.ToDecimal(Console.ReadLine());
            ////Console.Write("Eklemek istediğiniz ürün durumu (Aktif ise 1, Pasif ise 0): ");
            ////productStatus = Convert.ToBoolean(Console.ReadLine());

            //connection.Open();

            //SqlCommand command = new SqlCommand("INSERT INTO TblProduct (ProductName, ProductPrice, ProductStatus) VALUES (@productName, @productPrice, @productStatus)", connection);

            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün başarıyla eklendi!");

            #endregion

            #region Ürün Listeleme İşlemi

            //connection.Open();

            //SqlCommand command = new SqlCommand("SELECT * FROM TblProduct", connection);

            //SqlDataAdapter adapter = new SqlDataAdapter(command);

            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}


            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek ürün id giriniz: ");
            //int productId = Convert.ToInt32(Console.ReadLine());

            //connection.Open();

            //SqlCommand command = new SqlCommand("DELETE FROM TblProduct WHERE ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Ürün başarıyla silindi!");

            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek ürün id giriniz: ");
            //int productId = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Güncellenecek ürün adı: ");
            //string productName = Console.ReadLine();
            //Console.Write("Güncellenecek ürün fiyatı: ");
            //decimal productPrice = Convert.ToDecimal(Console.ReadLine());

            //connection.Open();

            //SqlCommand command = new SqlCommand("UPDATE TblProduct SET ProductName = @productName, ProductPrice = @productPrice WHERE ProductId = @productId", connection);

            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Ürün başarıyla güncellendi!");

            #endregion

            Console.Read();
        }
    }
}
