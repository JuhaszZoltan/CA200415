using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CA200415
{
    class Program
    {
        static void Main()
        {
            List<Kutya> kutyak = new List<Kutya>();

            for (int i = 0; i < 10; i++)
            {
                kutyak.Add(new Kutya());
            }

            /*
            foreach (var k in kutyak)
            {
                Console.WriteLine(
                    "{0, -8} {1} {2, 0:00.00}",
                    k.Nev,
                    k.Szul.ToString("yyyy-MM-dd"),
                    k.Suly);
            }
            */
            Console.WriteLine($"{kutyak[0].Nev} súlya jelenleg: {kutyak[0].Suly}");

            Console.Write("mennyi kaját adsz neki? ");
            float m = float.Parse(Console.ReadLine());
            try
            {
                kutyak[0].Eszik(m);
                kutyak[0].Ugat();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            var k = new Kutya("Belphegor", "2015-07-04", 20.4F);

            //k.Elpusztul();

            //var z = k.Feltamad();

            Console.WriteLine($"{k.Nev} életkora: {k.Eletkor}");

            //z.Ugyat();

            


            foreach (var n in Kutya.nevek)
            {
                Console.WriteLine(n);
            }

            Console.ReadKey();
        }
    }
}
