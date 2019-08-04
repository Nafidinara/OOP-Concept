using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuangDatar
{
    class bangunRuang
    {
        public void bangunruang1()
        {
        Pilihan:
            Console.WriteLine("Rumus Untuk menghitung Luas");
            Console.WriteLine("1.Kubus");
            Console.WriteLine("2.Balok");
            Console.WriteLine("3.Bola");
            Console.Write("Pilihlah Salah Satu Bangun Ruang Di atas : ");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:

                    kubus kubus2 = new kubus();
                    kubus2.setSisi();
                    kubus2.setLuas();
                    Console.ReadLine();

                    break;

                case 2:
                    balok balok2 = new balok();
                    balok2.setPanjang();
                    balok2.setLebar();
                    balok2.setTinggi();
                    balok2.setLuas();
                    Console.ReadLine();

                    break;


                case 3:
                    bola bola2 = new bola();
                    bola2.setR();
                    bola2.setLuas();
                    Console.ReadLine();

                    break;

                default: Console.WriteLine("masukkan angka yang tertera!");
                    Console.ReadLine();
                    goto Pilihan;
            }
        }
    }
}
