using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuangDatar
{
    class bangunDatar
    {
        public void bangundatar1()
        {
        Pilihan:
            Console.WriteLine("Rumus Untuk menghitung Luas");
            Console.WriteLine("1.Persegi");
            Console.WriteLine("2.Persegi Panjang");
            Console.WriteLine("3.Lingkaran");
            Console.Write("Pilihlah Salah Satu Bangun Datar Di atas : ");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:

                    persegi persegi2 = new persegi();
                    persegi2.setSisi();
                    persegi2.setLuas();
                    Console.ReadLine();

                    break;

                case 2:
                    persegiPanjang persegipanjang2 = new persegiPanjang();
                    persegipanjang2.getPanjang();
                    persegipanjang2.getLebar();
                    persegipanjang2.getLuas();
                    Console.ReadLine();

                    break;


                case 3:
                    lingkaran lingkaran2 = new lingkaran();
                    lingkaran2.setR();
                    lingkaran2.setLuas();
                    Console.ReadLine();

                    break;

                default: Console.WriteLine("masukkan angka yang tertera!");
                    Console.ReadLine();
                    goto Pilihan;
            }
        }
    }
}
