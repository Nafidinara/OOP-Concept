using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuangDatar
{
    class bola
    {
        private double phi = 3.14;
        private double r;
        private double luas;

        public double getPhi()
        {
            return phi;
        }

        public double setR()
        {
            Console.Write("Masukkan jari jari : ");
            r = Double.Parse(Console.ReadLine());
            return r;
        }

        public double setLuas()
        {
            luas = 4 / 3 * phi * r * r;
            Console.WriteLine("Maka luasnya adalah : " + luas);
            return luas;
        }
    }
}
