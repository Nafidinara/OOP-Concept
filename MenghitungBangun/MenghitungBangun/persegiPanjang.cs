using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenghitungBangun
{
    class persegiPanjang
    {
        public int panjang;
        public int lebar;
        public double luas;
        public double keliling;

        public void persegiPanjang2()
        {
            Console.Write("Masukkan panjang : ");
            panjang = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan lebar : ");
            lebar = Convert.ToInt32(Console.ReadLine());

            luas = panjang * lebar;
            keliling = 2 * (panjang + lebar);

            Console.Write("Luas Persegi Panjang Adalah : " + luas);
            Console.ReadLine();

            Console.Write("Keliling Persegi Panjang Adalah : " + keliling);
            Console.ReadLine();

        }
    }
}
