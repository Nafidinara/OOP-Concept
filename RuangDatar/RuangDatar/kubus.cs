using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuangDatar
{
    class kubus
    {
        private double luas;
        private double sisi;

        public double setSisi()
        {
            Console.Write("masukkan sisi : ");
            sisi = Double.Parse(Console.ReadLine());
            return sisi;
        }
        public double setLuas()
        {
            luas = 6 * sisi; 
            Console.Write("Maka luasnya adalah : "+luas);
            luas = Double.Parse(Console.ReadLine());
            return luas;
        }
    }
}
