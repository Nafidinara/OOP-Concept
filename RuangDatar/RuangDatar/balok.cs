using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuangDatar
{
    class balok
    {
        private double panjang;
        private double lebar;
        private double tinggi;
        private double luas;

        public double setPanjang()
        {
            Console.Write("masukkan nilai panjang : ");
            panjang = Double.Parse(Console.ReadLine());
            return panjang;
        }

        public double setLebar()
        {
            Console.Write("masukkan nilai lebar : ");
            lebar = Double.Parse(Console.ReadLine());
            return lebar;
        }

        public double setTinggi()
        {
            Console.Write("masukkan nilai tinggi : ");
            tinggi = Double.Parse(Console.ReadLine());
            return tinggi;
        }

        public double setLuas()
        {
            luas = (2 * panjang * lebar) + (2 * panjang * tinggi) + (2 * lebar * tinggi);
            Console.Write("Maka luasnya adalah : " + luas);
            return luas;
        }
    }
}
