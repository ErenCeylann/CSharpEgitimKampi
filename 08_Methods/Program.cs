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
            #region Metotlar

            //void customerList()
            //{
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Kaan Yıldız");
            //    Console.WriteLine("Elif Yıldız");
            //    Console.WriteLine("Mehmet Yıldız");

            //}
            //customerList();


            //void sum()
            //{
            //    int x = 1;
            //    int y=2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //sum();




            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar

            //void writeMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //writeMethod("Mehmet Yıldırım");


            //void customerCard(string name,string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name+" " + surName);
            //}

            //customerCard("Mehmet", "Yıldırım");
            //customerCard("Ahmet", "Yıldırım");

            #endregion


            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void sum(int number1,int number2,int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //sum(10,20,30);
            #endregion


            #region Geriye Değer Döndüren Metotlar


            //string customerName()
            //{
            //    return "Buse Yıldız";
            //}
            //customerName();

            //string studentCard()
            //{
            //    string name = "Ali";
            //    string surName = "Kaya";

            //    return name+" " + surName;
            //}
            //Console.WriteLine(studentCard());

            #endregion

            #region Geriye Değer Döndüren string Parametreli Metotlar

            //string countryCard(string countryName,string capital,string flagColor)
            //{
            //    string cardInfo = "Ülke:" + countryName + "-" + "Başkent:"+capital + "-" + "Bayrak Rengi:" + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x=Console.ReadLine();
            //Console.Write("Başkenti Giriniz: ");
            //y=Console.ReadLine();
            //Console.Write("Bayrak Rengini Giriniz");
            //z=Console.ReadLine();
            //Console.WriteLine(countryCard(x, y, z));
            //Console.WriteLine(countryCard("Türkiye","Ankara","Kırmızı-Beyaz"));
            #endregion


            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int sum(int number1,int number2)
            //{
            //    int result=number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(sum(33,40));
            //Console.WriteLine(sum(77,60));
            //Console.WriteLine(sum(92,23));
            //Console.WriteLine(sum(51,59));

            #endregion

            #region Örnek Uygulama
            
            string ExamResult(string student,int exam1,int exam2,int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result>=50)
                {
                    return student+ " isimli Öğrenci Başarılı"+" Ortalama: "+result;
                }
                else
                {
                    return student+ " isimli Öğrenci Başarısız"+" Ortalama: "+result;
                }
            }

            Console.WriteLine(ExamResult("Ali", 53, 56, 95));
            Console.WriteLine(ExamResult("Mehmet", 22, 26, 15));
            #endregion
            Console.Read();
        }
    }
}
