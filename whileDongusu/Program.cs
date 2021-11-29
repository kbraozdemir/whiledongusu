using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            //1'den başlayarak konsoldan girilen sayıya kadar, sayı dahil, ortalama hesaplayıp konsola yazdıran program
            Console.Write("Lütfen bir sayı girin: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac<=sayi)
            {
                toplam += sayac;
                sayac ++;
            }

            Console.WriteLine(toplam / sayi);

            //"a"dan "z" ye kadar bütün harfleri konsola yazdıralım.
            char character = 'a';
            while (character<'z')
            {
                Console.Write(character);
                character++;
            }

            Console.WriteLine("******* foreach *******");
            string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
            Console.ReadLine();
        }
    }
}
