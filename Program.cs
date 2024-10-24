using System;

namespace Jammal3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int giris = 0;
            Console.WriteLine("Hesap Makinesine Hoş Geldiniz! Çıkmak için e/E");
            
            while (true)
            {
                giris++;
                if (giris>1){Console.WriteLine("Tekrar işlem yapmak istiyorsanız giriniz.");}
                
                int sonuc = 0;
                Console.WriteLine("1. Sayıyı giriniz.");
                String inputa =Console.ReadLine();
                int a = Convert.ToInt32(inputa);
                if (inputa== "e"||inputa=="E"){break;}
            
                Console.WriteLine("2. Sayıyı giriniz.");
                String inputb =Console.ReadLine();
                int b = Convert.ToInt32(inputb);
                if (inputb== "e"||inputa=="E") {break;}
            
                Console.WriteLine("Yapmak istediğiniz işlemi giriniz.");
                String islem = Console.ReadLine();
                if (islem== "e"||inputa=="E") {break;}
            
                switch (islem)
                {
                    case "+":
                        sonuc = a + b;
                        Console.WriteLine("İşlem sonucu: "+ sonuc);
                        break;
                    case "-":
                        sonuc = a - b;
                        Console.WriteLine("İşlem sonucu: "+ sonuc);
                        break;
                    case "*":
                        sonuc = a * b;
                        Console.WriteLine("İşlem sonucu: "+ sonuc);
                        break;
                    case "/":
                        sonuc = a / b;
                        Console.WriteLine("İşlem sonucu: "+ sonuc);
                        break;
                    default:
                        Console.WriteLine("düzgün bir şey gir");
                        break;
                }
            }  
        }
    }
}