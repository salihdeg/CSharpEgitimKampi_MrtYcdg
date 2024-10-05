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
            //Console.Write("Hello World");
            //Console.WriteLine("Hello 2");
            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Soğuk Başlangıçlar");
            //Console.WriteLine("4- Salatalar");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("6- İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region String Değişkenler
            //String
            //Değişkenin_türü değişken_adı;

            //string name;
            //name = "viciante";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Salih";
            //customerSurname = "Değirmenci";
            //customerPhone = "+90 541 923 1234";
            //customerEmail = "info@salihdeg.dev";
            //district = "Beyoğlu";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email Adresi:"+ customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("---------------------------------------");

            //Console.WriteLine();

            //customerName = "Kadir Ali";
            //customerSurname = "Demiröz";
            //customerPhone = "+90 531 717 1010";
            //customerEmail = "ali@gmail.com";
            //district = "Çan";
            //city = "Çanakkale";

            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email Adresi:" + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("---------------------------------------");


            #endregion

            #region Int Değişkenler

            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 250;
            int cokePrice = 20;
            int waterPrice = 5;
            int friesPrice = 30;
            int pizzaPrice = 200;
            int lemonadePrice = 15;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("----- Hamburger Fiyatı: " + hamburgerPrice + " TL");
            Console.WriteLine("----- Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("----- Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("----- Kızartma: " + friesPrice + " TL");
            Console.WriteLine("----- Su: " + waterPrice + " TL");
            Console.WriteLine("----- Kola: " + cokePrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();

            int hamburgerCount;
            int cookCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totallemonadePrice;

            hamburgerCount = 3;
            cookCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cookCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totallemonadePrice = lemonadeCount * lemonadePrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;


            Console.WriteLine("-------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totallemonadePrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " Tl");

            Console.WriteLine();
            int totalprice = totalCokePrice + totalWaterPrice + totallemonadePrice + totalHamburgerPrice + totalFriesPrice + totalPizzaPrice;
            Console.WriteLine("Yoplam Ödenecek Tutar: " + totalprice + " TL");
            #endregion

            Console.Read();
        }
    }
}


// Yorum satirlari