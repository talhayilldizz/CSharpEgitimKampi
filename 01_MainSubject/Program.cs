using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKmutları
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
            //Console.WriteLine(name);

            //string customerName, customerMail, customerPhone;
            //customerName = "Ali";
            //customerMail = "asb@mail.com";
            //customerPhone = "003421231212";
            //Console.WriteLine(customerName+" "+customerMail+" "+customerPhone);
            //Console.Read();
            #endregion

            #region IntDegiskenler
            //int number;
            //number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;
            Console.WriteLine("**** Yemek Fiyatları ****");
            Console.WriteLine();
            Console.WriteLine("----Hamburger: " + hamburgerPrice);
            Console.WriteLine("----Kola: " + cokePrice);
            Console.WriteLine("----Su: " + waterPrice);
            Console.WriteLine("----Kızartma: " + friesPrice);
            Console.WriteLine("----Pizza: " + pizzaPrice);
            Console.WriteLine("----Limonata: " + lemonadePrice);
            Console.Read();
            Console.WriteLine();
            Console.WriteLine("**** Yemek Fiyatları ****");
            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totelPrice = 0;

            hamburgerCount = 3;
            cokeCount=3;
            waterCount=3;
            friesCount=1;
            pizzaCount=0;
            lemonadeCount=0;

            totelPrice = (hamburgerCount * hamburgerPrice)
                + (cokeCount * cokePrice)
                + (waterCount * waterPrice)
                + (friesCount * friesPrice)
                + (pizzaCount * pizzaPrice)
                + (lemonadeCount * lemonadePrice);

            Console.WriteLine("Toplam Hesap: " + totelPrice);
            #endregion

        }
    }
}
