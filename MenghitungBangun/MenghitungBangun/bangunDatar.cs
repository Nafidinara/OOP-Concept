using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenghitungBangun
{
    class bangunDatar
    {
        public void bangundatar()
        {
        Pilihan:
            Console.WriteLine("Rumus Untuk Menghitung Keliling dan luas Bangun Datar");
            Console.WriteLine("1.Persegi panjang");
            Console.WriteLine("2.Segitiga sama sisi");
            Console.WriteLine("3.Trapesium sama sisi");
            Console.WriteLine("4.Lingkaran");
            Console.Write("Pilihlah Salah Satu Bangun Datar Di atas : ");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:

                    persegiPanjang persegipanjang = new persegiPanjang();
                    persegipanjang.persegiPanjang2();
                    Console.ReadLine();

                    break;

                case 2:
                    segitiga segitiga1 = new segitiga();
                    segitiga1.segitiga2();
                    Console.ReadLine();

                    break;


                case 3:
                    trapesium trapesium1 = new trapesium();
                    trapesium1.trapesium2();
                    Console.ReadLine();

                    break;

                case 4:
                    lingkaran lingkaran1 = new lingkaran();
                    lingkaran1.lingkaran2();
                    Console.ReadLine();

                    break;

                default: Console.WriteLine("masukkan angka yang tertera!");
                    Console.ReadLine();
                    goto Pilihan;
            }

        }
    }
}
