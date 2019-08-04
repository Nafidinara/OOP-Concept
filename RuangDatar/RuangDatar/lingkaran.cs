using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuangDatar
{
    class lingkaran
    {
        private double r;
        private double luas;
        private double phi = 3.14; 

        public double setR(){
            Console.Write("masukkan jari jari : ");
            r = Convert.ToInt32(Console.ReadLine());
            return r;
        }

        public double getPhi()
        {
            phi = double.Parse(Console.ReadLine());
            return phi;
        }

        public double setLuas()
        {
            luas = phi * r * r;
            Console.WriteLine("maka luas adalah " + luas);
            return luas;
        }
    }
}
