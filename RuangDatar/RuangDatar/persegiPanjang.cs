using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuangDatar
{
    class persegiPanjang
    {
        private double panjang;
        private double lebar;
        private double luas;

        public double getPanjang()
        {
            Console.Write("masukkan panjang : ");
            panjang = Double.Parse(Console.ReadLine());
            return panjang;
        }

        public double getLebar()
        {
            Console.Write("masukkan lebar : ");
            lebar = Double.Parse(Console.ReadLine());
            return lebar;
        }

        public double getLuas()
        {
            luas = panjang * lebar;
            Console.WriteLine("Maka luas adalah : "+luas );
            return luas;
        }
    }
}
