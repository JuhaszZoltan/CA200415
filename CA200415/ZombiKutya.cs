using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA200415
{
    class ZombiKutya
    {
        public string Nev { get; set; }
        public void Ugyat()
        {
            Console.WriteLine($"{Nev} mondja: Grrrr!");
        }
        public ZombiKutya(string nev)
        {
            Nev = nev + " a zombi!";
        }
    }
}
