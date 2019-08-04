using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenghitungBangun
{
    class trapesium
    {
        public const double setengah = 0.5;
        public int alas;
        public int atas;
        public int tinggi;
        public double luas;
        public double keliling;

        public void trapesium2()
        {
            Console.Write("Masukkan nilai sisi sejajar atas : ");
            atas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan nilai sisi sejajar bawah : ");
            alas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan nilai tinggi = ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            luas = setengah * (atas + alas) * tinggi;
            keliling = 2 * (atas - alas) + (atas + alas);

            Console.Write("Maka Luas Trapesium = " + luas);
            Console.ReadLine();
            Console.Write("Maka Keliling Trapesium = " + keliling);
            Console.ReadLine();

        }
    }
}
