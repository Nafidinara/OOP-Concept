using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuangDatar
{
    class setget
    {
        private int sisi = 5;
        private int luas;
        private int keliling;

        //setter : hanya bisa menampilkan
        //getter : bisa memodifikasi isinya

        public int getsisi()
        {
            return sisi;
        }

        //tambah parameter untk setter
        public int setsisi(int x)
        {
            sisi += x;
            return sisi;
        }
    }
}
