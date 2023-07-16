using System;
using System.Collections.Generic;

namespace Uas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ticket> listTicket = new List<Ticket>();
            bool keluar = false;
            while (!keluar)
            {
                Console.Clear();
                Console.WriteLine("==================================");
                Console.WriteLine("   Selamat datang di KAI Access");
                Console.WriteLine("==================================");
                Console.WriteLine("1. Beli Tiket Kereta");
                Console.WriteLine("2. Data Diri Pengguna");
                Console.WriteLine("3. Daftar Tiket");
                Console.WriteLine("4. Cetak Tiket Kereta");
                Console.WriteLine("5. Keluar");
                Console.WriteLine("==================================");

                Console.Write("Masukkan pilihan anda: ");
                int pilih = Convert.ToInt32(Console.ReadLine());

                switch (pilih)
                {
                    case 1:
                        Add tambah = new Add(listTicket);
                        Console.ReadKey();
                        Console.WriteLine("==================================");
                        Console.WriteLine("   Tiket berhasil ditambahkan");
                        Console.WriteLine("==================================");
                        break;
                    case 2:
                        Person diri = new Person(listTicket);
                        break;
                    case 3:
                        Show tampil = new Show(listTicket);
                        break;
                    case 4:
                        Console.Clear();
                        Print detail = new Print(listTicket);
                        break;
                    case 5:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("==================================");
                        Console.WriteLine("     Maaf Inputan tidak Valid");
                        Console.WriteLine("==================================");
                        Console.WriteLine();
                        Console.WriteLine("Tekan enter / spasi untuk kembali ke menu :)");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}