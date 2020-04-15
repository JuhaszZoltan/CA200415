using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA200415
{
    class Kutya
    {
        private static Random rnd = new Random();
        public static string[] nevek =  {"Bodri", "Buksi", "Koldász", "Imontep", "Sátán" };

        private string _nev;
        private DateTime _szul;
        private float _suly;
        private bool _el = true;

        public string Nev
        {
            get { return _nev; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("mindenképpen el kell nevezned a kutyát!");
                }
                if (value.Length > 30)
                {
                    throw new Exception("túl hosszú név!");
                }
                _nev = value;
            }
        }
        public DateTime Szul
        {
            get { return _szul; }
            set
            {
                if (DateTime.Now.Year - value.Year > 12)
                {
                    throw new Exception("túl öreg kutya!");
                }
                if (value > DateTime.Now)
                {
                    throw new Exception("nem lehet időutazó kutya");
                }
                _szul = value;
            }
        }
        public float Suly
        {
            get { return _suly; }
            private set
            {
                if (_suly != 0 && value > _suly * 1.01F)
                {
                    throw new Exception("ekkora kutya nem tud egyszerre ennyit hízni!");
                }
                if (value < 1.5F)
                {
                    throw new Exception("túl alacsony súly");
                }
                if (value > 50)
                {
                    throw new Exception("túl magas súly!");
                }
                
                _suly = value;
            }
        }
        public int Eletkor
        {
            get
            {
                return DateTime.Now.Year - _szul.Year;
            }
        }
        public void Eszik(float mennyiseg)
        {
            Suly += mennyiseg;
        }
        public void Elpusztul()
        {
            _el = false;
        }
        public ZombiKutya Feltamad()
        {
            if (_el)
            {
                throw new Exception("Élő kutya nem tud feltámadni!");
            }

            return new ZombiKutya("néhai " + Nev);
        }
        public void Ugat()
        {
            Console.WriteLine($"{Nev} mondja: Vau-vau!");
        }

        public Kutya()
        {
            Nev = nevek[rnd.Next(nevek.Length)];
            Szul = DateTime.Now.AddDays(-rnd.Next(12 * 365));
            Suly = rnd.Next(150, 5000) / 100F;
        }

        public Kutya(string nev, string szul, float suly)
        {
            Nev = nev;
            Szul = DateTime.Parse(szul);
            Suly = suly;
        }
    }
}
