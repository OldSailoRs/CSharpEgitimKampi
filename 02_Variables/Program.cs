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
            #region Double Değişkenler

            // double ondalıklı gösterim için kullanılır.

            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberyPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberyPrice = 45;
            //potatoPrice =9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı:" + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı:" + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı:" + strawberyPrice + " TL");
            //Console.WriteLine("---- Patetes Birim Fiyatı:" + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı:" + tomatoPrice + " TL");

            //double appleGram, orangeGram, strawGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice=appleGram * applePrice;
            //double orangeTotalPrice=orangeGram * orangePrice;
            //double strawTotalPrice = strawberyPrice * strawGram;
            //double potatoTotalPrice=potatoGram * potatoPrice;
            //double tomatoTotalPrice=tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma-" + " Birim Fiyat:" + applePrice+" -Gramaj:"+ appleGram +" -Toplam Tutar:" + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal -" + " Birim Fiyat:" + orangePrice+" -Gramaj:"+ orangeGram +" -Toplam Tutar:" + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek-" + " Birim Fiyat:" + strawberyPrice+" -Gramaj:"+ strawGram +" -Toplam Tutar:" + strawTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates-" + " Birim Fiyat:" + potatoPrice+" -Gramaj:"+ potatoGram +" -Toplam Tutar:" + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates-" + " Birim Fiyat:" + tomatoPrice+" -Gramaj:"+ tomatoGram +" -Toplam Tutar:" + tomatoTotalPrice);

            //double shoppingTotalPrice=appleTotalPrice+orangeTotalPrice+strawTotalPrice+potatoTotalPrice+tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar:" + shoppingTotalPrice + " TL");

            #endregion

            #region Char Değişkenler

            //Char Değişkenler tek tırnak içinde gösterilir '' 

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);
            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName =Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname =Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict =Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity =Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge =Console.ReadLine();

            //Console.Write("Yolcu TC :");
            //passengerIdentityNumber =Console.ReadLine();



            //Console.WriteLine();

            //Console.WriteLine("--------------------------");
            //Console.WriteLine("Yolcu: "+ passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge + " " + passengerIdentityNumber);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //C# Programlama dili başlangıçta değişken olarak girilen verileri strig olarak görür bu sebepten dolayı sayı değişkenlerine dönüşüm uygulamak gerekir.

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine()); // PARSE dönüştürme için için kullanılan komuttur.

            //Console.Write("Lütfen Aldığınız Bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice=shoesCount*shoesPrice + computerCount*computerPrice+chairCount*chairPrice+tvCount*tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: "+ totalPrice + " TL");

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1.nci Sınav Notunu Giriniz: ");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.nci Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.nci Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender =char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);


            #endregion

            Console.Read();

        }
    }
}
