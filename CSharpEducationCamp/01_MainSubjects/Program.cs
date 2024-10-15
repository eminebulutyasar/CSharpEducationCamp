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
            #region YazdırmaKomutları
            //Console.WriteLine("Hello World");
            //Console.Write("Hi");

            //Console.WriteLine("***** Food Categories *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Soups");
            //Console.WriteLine("2-Main Foods");
            //Console.WriteLine("3-Salads");
            //Console.WriteLine("4-Deserts");
            //Console.WriteLine();
            //Console.WriteLine("***** Food Categories *****");
            #endregion

            #region String Değişkenler

            //String
            //Değişken_Türü Değişken_adı;
            //string name;
            //name = "Emine";
            //Console.WriteLine(name);
            //string customerName;  //camelCase
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;
            //customerName = "Emine";
            //customerSurname = "Yaşar";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Çankaya";
            //city = "Ankara";
            //Console.WriteLine("*****Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("Müşteri: " + customerName + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: "+ customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);

            #endregion

            #region Int Değişkenler

            //int
            //int number = 24;
            //Console.WriteLine(number);
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;
            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("Pizza : " + pizzaPrice + " TL");
            Console.WriteLine("Kola: " + cokePrice + " TL");
            Console.WriteLine("Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("Kızartma: " + friesPrice + " TL");
            Console.WriteLine("Su: " + waterPrice + " TL");
            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;
            int totalHamburgerPrice = 0;
            hamburgerCount = 3;
            
            totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            Console.WriteLine( "Hamburger Tutarı: " +totalHamburgerPrice+ " TL");



            #endregion

            Console.Read();
        }
    }
}


//
