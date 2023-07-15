using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nem;

            Console.WriteLine("Nem Oranını Giriniz:");
            nem = Convert.ToInt32(Console.ReadLine());

            if (nem < 0 || nem > 100)//Hata Kontrolü
            {
                Console.WriteLine("Hatalı Giriş");
                Console.ReadKey();
                return;
            }

            //nem 0-100
            
            
            if(nem <= 20)
            {

                Console.WriteLine("Çok Kuru");
            }

            else if (nem <= 40)
            {
                Console.WriteLine("Kuru");
            }

            else if (nem <= 60)
            {
                Console.WriteLine("Biraz Kuru");
            }

            else if ( nem <= 80)
            {
                Console.WriteLine("Biraz Nemli");
            }
            else 
            {
                Console.WriteLine("Nemli");
            }
           Console.ReadKey();
        
        }


    }
}
