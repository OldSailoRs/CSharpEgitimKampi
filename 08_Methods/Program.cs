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
            #region Void Metotlar

            //bir yapıyı metot yapan sonuna açılan parantezdir ().
            //geriye değer döndürmeyen metotlar.
            //Void --> GERİYE DEĞER DÖNDERMEYEN METOTLAR

            //void CustomerList()
            //{
            //    Console.WriteLine("Bahadır Değirmenci");
            //    Console.WriteLine("Serra Değirmenci");
            //    Console.WriteLine("Merve Değirmenci");

            //}

            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y=2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();
            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Bahadır DEĞİRMENCİ");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}

            //CustomerCard("Bahadır","Değirmenci");
            //CustomerCard("Serra","Değirmenci");
            //#endregion
            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Bahadır DEĞİRMENCİ";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Bahadır";
            //    string surName = "Değirmenci";

            //    return name+ " " + surName;
            //}


            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo="Ülke: "+ countryName + " - Başkent: "+ capital+"- Bayrak Rengi: "+flagColor;
            //    return cardInfo;

            //}
            //string x,y,z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x=Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y=Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z=Console.ReadLine();

            //Console.WriteLine (CountryCard(x,y,z));
            #endregion

            #region Geriye Değer Döndüren INT Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result=number1+number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(54, 101));
            //Console.WriteLine(Sum(65, 152));
            //Console.WriteLine(Sum(44, 896));
            #endregion

            #region Örnek Uygulama

            string ExamResult (string student,int exam1,int exam2,int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student+  " isimli Öğrenci Sınavı Geçti" + " Ortalama: "+ result;                           
                }
                else
                {
                    return student+  " isimli Öğrenci Sınavı Geçemedi" + " Ortalama: "+ result;
                }
                
            }
            Console.WriteLine(ExamResult("Bahadır", 25, 68, 99));
            Console.WriteLine(ExamResult("Serra", 56, 78, 100));
            Console.WriteLine(ExamResult("Mehmet", 25, 35, 40));

            #endregion

            Console.Read();

        }
    }
}
