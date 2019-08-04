using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenghitungBangun
{
    class lingkaran
    {
        public int r;
        public const double phi = 3.14;
        public int luas;
        public int keliling;

        public void lingkaran2()
        {
            Console.Write("Masukkan jari jari lingkaran : ");
            r = Convert.ToInt32(Console.ReadLine());

            double luas = phi * r * r;
            double keliling = 2 * phi * r;
            Console.Write("Maka Luas lingkaran = " + luas);
            Console.ReadLine();
            Console.Write("Maka Keliling lingkaran = " + keliling);
            Console.ReadLine();
        }
    }
}
