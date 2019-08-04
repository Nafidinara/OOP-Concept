using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenghitungBangun
{
    class segitiga
    {
        public const double setengah = 0.5;
        public int alas;
        public int tinggi;
        public double keliling;
        public double luas;

        public void segitiga2()
        {
            Console.Write("Masukkan nilai alas = ");
            alas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan nilai tinggi = ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            luas = setengah * alas * tinggi;
            keliling = 3 * alas;

            Console.Write("Maka Luas Segitiga = " + luas);
            Console.ReadLine();
            Console.Write("Maka Keliling Segitiga = " + keliling);
            Console.ReadLine();

        }
    }
}
