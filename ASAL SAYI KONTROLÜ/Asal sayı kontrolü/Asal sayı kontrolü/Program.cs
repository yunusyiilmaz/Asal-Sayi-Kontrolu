using System;

namespace Asal_sayı_kontrolü
{
    class Program
    {
        static void Main(string[] args)
        {

            int kontrol = 0;
            Console.Write("SAYI GİRİNİZ :");
            int sayı = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < sayı; i++)
            {
                if (sayı % i == 0)
                {
                    kontrol++;
                }
            }
            if (kontrol == 0)
            {
                Console.WriteLine("SAYI ASALDIR");
            }
            else
            {
                Console.WriteLine("SAYI ASAL DEĞİLDİR");
            }
            Console.ReadLine();



        }
    }
}
