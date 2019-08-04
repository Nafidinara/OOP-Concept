using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenghitungBangun
{
    class kubus
    {
        public int sisi;
        public double luas;
        public int rusuk = 6;
        public double volume;

        public void kubus2()
        {
            Console.Write("Masukkan sisi kubus : ");
            sisi = Convert.ToInt32(Console.ReadLine());

            double luas = rusuk * sisi ;
            double volume = 3 * sisi;
            Console.Write("Maka Luas kubus = " + luas);
            Console.ReadLine();
            Console.Write("Maka Volume kubus = " + volume);
            Console.ReadLine();
        }
    }
}
