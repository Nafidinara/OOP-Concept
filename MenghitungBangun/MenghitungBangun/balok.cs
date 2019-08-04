using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenghitungBangun
{
    class balok
    {
        public int panjang;
        public int lebar;
        public int tinggi;
        public double luas;
        public double volume;

        public void balok2()
        {
            Console.Write("Masukkan panjang balok : ");
            panjang = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan lebar balok : ");
            lebar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan tinggi balok : ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            double luas = (2*panjang*lebar)+(2*panjang*tinggi)+(2*lebar*tinggi);
            double volume = panjang*lebar*tinggi;

            Console.Write("Maka Luas balok = " + luas);
            Console.ReadLine();
            Console.Write("Maka Volume balok = " + volume);
            Console.ReadLine();
        }
    }
}
