using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Variables
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;
            //Console.WriteLine("---- Elma Birim Fiyatı:" + applePrice + "₺");
            //Console.WriteLine("---- Portakal Birim Fiyatı:" + orangePrice + "₺");
            //Console.WriteLine("---- Çilek Birim Fiyatı:" + strawberryPrice + "₺");
            //Console.WriteLine("---- Patates Birim Fiyatı:" + potatoPrice + "₺");
            //Console.WriteLine("---- Domates Birim Fiyatı:" + tomatoPrice + "₺");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice= applePrice * appleGram;
            //double orangeTotalPrice= orangeGram * orangePrice;
            //double strawberryTotalPrice= strawberryPrice * strawberryGram;
            //double potatoTotalPrice= potatoPrice * potatoGram;
            //double tomatoTotalPrice= tomatoGram * tomatoPrice;


            //Console.WriteLine("Alınan Ürün: Elma -"+ "Birim Fiyat: "+applePrice + "- Gramaj: "+appleGram+ " - Toplam Tutar: "+ appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal -"+ "Birim Fiyat: "+orangePrice + "- Gramaj: "+orangeGram+ " - Toplam Tutar: "+ orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek -"+ "Birim Fiyat: "+strawberryPrice + "- Gramaj: "+strawberryGram+ " - Toplam Tutar: "+ strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates -"+ "Birim Fiyat: "+potatoPrice + "- Gramaj: "+potatoGram+ " - Toplam Tutar: "+ potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domataes -"+ "Birim Fiyat: "+tomatoPrice + "- Gramaj: "+tomatoGram+ " - Toplam Tutar: "+ tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine("Ödenecek Toplam Tutar:" + shoppingTotalPrice + "₺");

            #endregion


            #region Char Variables
            //ABCDEFGH
            //DEF....
            //TOPLANTI SAAT 20:00'DE
            //" ' char formatı tek tırnaktır
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion


            #region  Klavyeden Veri Girişleri

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");

            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();
            //Console.WriteLine();

            //Console.WriteLine("-----------------------");
            //Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurname+ " "+ passengerDistrict + "/"+ passengerCity + " "+ passengerAge + " "+ passengerIdentityNumber);

            //Console.Write();
            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümleri

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;
            //int shoeCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen aldığıbız ayakkabı sayısını giriniz: ");
            //shoeCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığıbız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığıbız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığıbız TV sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());
            //int totalPrice = shoePrice * shoeCount + computerCount * computerPrice + chairCount * chairPrice + tvPrice * tvCount;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemen Gereken Tutar: " + totalPrice);




            #endregion


            #region Klavyeden Ondelıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;
            //Console.Write("1. sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("2. sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("3. sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result =(exam2+exam1 + exam3)/3;
            //Console.WriteLine(result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender=char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz cinsiyet" + gender);


            #endregion

            Console.ReadLine();
        }
    }
}
