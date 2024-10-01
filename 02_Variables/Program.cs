using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;

            //number = 4.85;
            //Console.WriteLine(number);

            Console.WriteLine("***** Fiyat Listesi *****");
            Console.WriteLine();
            
            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 45;
            potatoPrice =9.74;
            tomatoPrice = 6.88;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("---- Elma Birim Fiyatı:"+applePrice +"₺");
            Console.WriteLine("---- Portakal Birim Fiyatı:"+orangePrice +"₺");
            Console.WriteLine("---- Çilek Birim Fiyatı:"+strawberryPrice +"₺");
            Console.WriteLine("---- Patates Birim Fiyatı:"+potatoPrice +"₺");
            Console.WriteLine("---- Domates Birim Fiyatı:"+tomatoPrice +"₺");

            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            appleGram = 1.245;
            orangeGram = 2.650;
            strawberryGram = 0.750;
            potatoGram = 4.859;
            tomatoGram = 3.745;

            Console.WriteLine();
            Console.WriteLine();

            
            double appleTotalPrice,orangeTotalPrice,strawberryTotalPrice,potatoTotalPrice,tomatoTotalPrice;

            appleTotalPrice = applePrice * appleGram;
            orangeTotalPrice = orangePrice * orangeGram;
            strawberryTotalPrice=strawberryPrice * strawberryGram;
            potatoTotalPrice=potatoPrice * potatoGram;
            tomatoTotalPrice=tomatoPrice * tomatoGram;

            Console.WriteLine("Alınan Ürün:Elma - "+"Birim Fiyat: "+applePrice+" - Gramaj: "+appleGram+" - Toplam Tutar: "+appleTotalPrice);
            Console.WriteLine("Alınan Ürün:Portakal - "+"Birim Fiyat: "+orangePrice+" - Gramaj: "+orangeGram+" - Toplam Tutar: "+orangeTotalPrice);
            Console.WriteLine("Alınan Ürün:Çilek - "+"Birim Fiyat: "+strawberryPrice+" - Gramaj: "+strawberryGram+" - Toplam Tutar: "+strawberryTotalPrice);
            Console.WriteLine("Alınan Ürün:Patates - "+"Birim Fiyat: "+potatoPrice+" - Gramaj: "+potatoGram+" - Toplam Tutar: "+potatoTotalPrice);
            Console.WriteLine("Alınan Ürün:Domates - "+"Birim Fiyat: "+tomatoPrice+" - Gramaj: "+tomatoGram+" - Toplam Tutar: "+tomatoTotalPrice);

            Console.WriteLine();
            Console.WriteLine();

            double shoppingTotalPrice=appleTotalPrice+orangeTotalPrice+strawberryTotalPrice+potatoTotalPrice+tomatoTotalPrice;

            Console.WriteLine("Toplam Alışveriş Tutarı: " + shoppingTotalPrice + " ₺");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();
            #endregion

            #region Char Değişkenler

            char symbol;

            symbol = 'a';

            Console.WriteLine(symbol);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();

            #endregion

            #region Klavyeden Veri Girişleri

            Console.WriteLine("****** CSharp Hava Yolları Yolcu Bilgisi ******");

            Console.WriteLine();

            string passangerName, passangerSurname, passangerDistrict, passangerCity, passangerAge, passangerIdentityNumber;
            Console.Write("Yolcu Adı: ");
            passangerName = Console.ReadLine();
            Console.Write("Yolcu Soyadı: ");
            passangerSurname = Console.ReadLine();

            Console.Write("İlçe Bilgisi: ");
            passangerDistrict = Console.ReadLine();

            Console.Write("Şehir Bilgisi: ");
            passangerCity = Console.ReadLine();

            Console.Write("Yolcu Yaş: ");
            passangerAge = Console.ReadLine();

            Console.Write("Yolcu TC Kimlik No: ");
            passangerIdentityNumber = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Yolcu TC Kimlik No: " + passangerIdentityNumber + " - " + "Yolcu Ad Soyad: " + passangerName + passangerSurname + " - " + "Yaş: " + passangerAge + " - " + "İlçe Şehir Bilgisi: " + passangerDistrict + "/" + passangerCity);

            Console.WriteLine();
            Console.WriteLine();

            #endregion


            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler
            int shoePrice, computerPrice, chairPrice, tvPrice;
            shoePrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;

            int shoeCount, computerCount, chairCount, tvCount;

            Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz: ");
            shoeCount=int.Parse(Console.ReadLine());

            Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz: ");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen Aldığınız Televizyon Sayısını Giriniz: ");
            tvCount = int.Parse(Console.ReadLine());

            int totalPrice=shoeCount*shoePrice+computerCount*computerPrice+chairCount*chairPrice+tvCount*tvPrice;

            Console.WriteLine();
            Console.WriteLine("Toplam Ödemeniz Gereken Tutar: "+totalPrice+" ₺");

            #endregion


            #region Klavyeden Ondalıklı Sayı İşlemleri
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
            double exam1, exam2, exam3, result;

            Console.Write("Lütfen 1. sınav notunu giriniz");
            exam1 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen 2. sınav notunu giriniz");
            exam2 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen 3. sınav notunu giriniz");
            exam3 = int.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;

            Console.WriteLine();

            Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion


            #region Klavyeden Karakter Girişler

            char gender;

            Console.Write("Lütfen Cinsiyet seçiniz");
            gender=char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz cinsiyet: "+gender);

            #endregion

            Console.Read();
        }
    }
}
