using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartaskaIgra
{
    class Program
    {
        static void Main(string[] args)
        {
            int karte, bodovi = 0;
            while (bodovi < 31)
            {
                Console.Write("Upisite broj karte:");
                karte = Convert.ToInt32(Console.ReadLine());
                bodovi += karte;
            }
            if (bodovi == 31)
            {
                Console.WriteLine("Pobjedili ste!");
            } else
            {
                Console.WriteLine("Izgubili ste!");
            }
        }
    }
}
