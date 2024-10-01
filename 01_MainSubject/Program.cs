using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            #endregion

            #region StringDeğişkenler

            //string name;
            //name = "Murat";
            //Console.Write(name);

            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail,district,city;

            customerName = "Ali";
            customerSurname = "Çınar";
            customerPhone = "+90 500 400 30 20";
            customerEmail = "deneme@gmail.com";
            district = "Kadıköy";
            city = "İstanbul";

            Console.WriteLine("**** Rezervasyon Kartı ****");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: "+customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
            customerName = "Ayşegül";
            customerSurname = "Kaya";
            customerPhone = "+90 400 300 80 10";
            customerEmail = "test@gmail.com";
            district = "Sapanca";
            city = "Sakarya";
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            #endregion


            #region Int Değişkenler


            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger Fiyatı: " + hamburgerPrice + " TL");
            Console.WriteLine("-----Pizza Fiyatı: " + pizzaPrice + " TL");
            Console.WriteLine("-----Kola Fiyatı: " + cokePrice + " TL");
            Console.WriteLine("-----Limonata Fiyatı: " + lemonadePrice + " TL");
            Console.WriteLine("-----Kızartma Fiyatı: " + friesPrice + " TL");
            Console.WriteLine("-----Su Fiyatı: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Kullanıcı Ödenecek Tutar ****");
            int hamburgerCount = 3;
            int cokeCount = 3;
            int waterCount = 3;
            int friesCount = 1;
            int pizzaCount = 1;
            int lemonadeCount = 1;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            totalCokePrice = cokePrice * cokeCount;
            totalWaterPrice = waterPrice * waterCount;
            totalFriesPrice = friesPrice * friesCount;
            totalPizzaPrice = pizzaPrice * pizzaCount;
            totalLemonadePrice = lemonadePrice * lemonadeCount;

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Hamburger Fiyatı: "+totalHamburgerPrice+" TL");
            Console.WriteLine("Pizza Fiyatı: "+totalPizzaPrice+" TL");
            Console.WriteLine("Kızartma Fiyatı: "+totalFriesPrice+" TL");
            Console.WriteLine("Kola Fiyatı: "+totalCokePrice+" TL");
            Console.WriteLine("Limonata Fiyatı: "+totalLemonadePrice+" TL");
            Console.WriteLine("Su Fiyatı: "+totalWaterPrice+" TL");
            Console.WriteLine();

            int totalPrice;

            totalPrice = totalHamburgerPrice + totalCokePrice + totalFriesPrice + totalLemonadePrice  + totalPizzaPrice + totalWaterPrice;

            Console.WriteLine("Ödenecek Toplam Tutatar: "+totalPrice+" TL");
            #endregion




            Console.Read();
        }
    }
}
