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
            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("---------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen Getirmek İstediğiniz Tablo Numarasını Giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("---------------------------");

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-V48PTFS\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");

            connection.Open();
            SqlCommand command = new SqlCommand("select * from Category",connection);
            SqlDataAdapter adapter =new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach(DataRow row in dt.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.WriteLine(item.ToString());
                }
            }

            connection.Close();

            Console.Read();
        }
    }
}
