using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuangDatar
{
    class persegi
    {
        private int sisi;
        private int luas;

        public int setSisi(){
            Console.Write("masukkan sisi : ");
            sisi = Convert.ToInt32(Console.ReadLine());
            return sisi;
        }

        public int setLuas()
        {
            luas = sisi * sisi;
            Console.WriteLine("maka luas adalah " + luas);
            return luas;
        }
    }
}
