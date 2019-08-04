using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenghitungBangun
{
    class bangunRuang
    {
        public void bangunruang()
        {
        Pilihan:
            Console.WriteLine("Rumus Untuk Menghitung volume dan luas Bangun Ruang");
            Console.WriteLine("1.Kubus");
            Console.WriteLine("2.balok");
            Console.Write("Pilihlah Salah Satu Bangun Ruang Di atas : ");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:

                    kubus kubus1 = new kubus();
                    kubus1.kubus2();
                    Console.ReadLine();

                    break;

                case 2:
                    balok balok1 = new balok();
                    balok1.balok2();
                    Console.ReadLine();

                    break;

                default: Console.WriteLine("masukkan angka yang tertera!");
                    Console.ReadLine();
                    goto Pilihan;
            }
        }
    }
}
