using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForreachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Forreach döngüsü

            //string[] cities = { "Milano", "Roma", "Barcelona", "Ankara", "Londra", "budaştepe" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 78, 98, 200, 500, 1293, 7456, 10982,33,41,12 };

            //foreach (int number in numbers)
            //{
            //    if (number %2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}


            //int[] numbers = { 45, 78, 98, 200, 500, 1293, 7456, 10982, 33, 41, 12 };
            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);


            //List<int> list = new List<int>()
            //{
            //    1, 2, 3, 4, 5, 6, 7,10
            //};

            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //string word = "merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}



            #endregion

            #region örnek sınav sistemi uygulaması

            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması ******");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("-----------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------");

            //öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentName = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];


            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentName[i] = Console.ReadLine();

                double totalExamResult = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentName[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double values = double.Parse(Console.ReadLine());
                    totalExamResult += values;
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;

            }

            for (int i = 0;i < studentCount;i++)
            {
                Console.WriteLine($"{studentName[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                if (studentExamAvg[i]>=50)
                {
                    Console.WriteLine($"{studentName[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentName[i]} adlı öğrenci dersten kaldı");
                }

                Console.WriteLine("------------------------------");
            }

            #endregion



            Console.Read();
        }
    }
}
