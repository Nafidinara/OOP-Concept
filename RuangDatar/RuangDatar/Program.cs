﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuangDatar
{
    class Program
    {
        static void Main(string[] args)
        {
        Pilihan:
            Console.WriteLine("Pilih bangun datar atau bangun ruang! ");
            Console.WriteLine("1.Bangun Datar");
            Console.WriteLine("2.Bangun Ruang");
            Console.Write("Pilihlah Salah satu : ");
            int i = Convert.ToInt32(Console.ReadLine());

            //contoh panggil setter
            //setget setget1 = new setget();
            //Console.WriteLine("Sisi nya adlah "+setget1.setsisi(10));

            switch (i)
            {
                case 1:

                    bangunDatar bangunDatar1 = new bangunDatar();
                    bangunDatar1.bangundatar1();
                    Console.ReadLine();

                    break;

                case 2:
                    bangunRuang bangunRuang1 = new bangunRuang();
                    bangunRuang1.bangunruang1();
                    Console.ReadLine();

                    break;

                default: Console.WriteLine("masukkan angka yang tertera!");
                    Console.ReadLine();
                    goto Pilihan;
            }

            Console.Write("Apakah anda ingin lagi? Y/N ");
            String a = (Console.ReadLine());
            switch (a)
            {
                case "Y":
                    Console.Clear();
                    goto Pilihan;

                case "N":
                    break;

                case "y":
                    Console.Clear();
                    goto Pilihan;

                case "n":
                    break;
            }
        }
    }
}
