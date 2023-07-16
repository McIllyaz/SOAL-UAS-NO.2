using System;
using System.Collections.Generic;

namespace Uas
{
    public class Add
    {
        public Add(List<Ticket> listTicket)
        {
            Console.Clear();
            Console.WriteLine("==================================");
            Console.WriteLine("    LENGKAPI DATA DIRI ANDA");
            Console.WriteLine("==================================");

            Random random = new Random();

            bool dataTerisi = false;

            // Cek apakah data diri sudah terisi atau belum
            if (listTicket.Count > 0)
            {
                Ticket lastTicket = listTicket[^1];
                if (!string.IsNullOrEmpty(lastTicket.NAMA) && lastTicket.NIK != 0 && lastTicket.KARTUVAKSIN != 0 && !string.IsNullOrEmpty(lastTicket.TELPON))
                {
                    dataTerisi = true;
                }
            }
            string jamberangkat = null;
            string jamdatang = null;

            if (dataTerisi)
            {
                int angka = random.Next(10000000);

                Console.Write("Nama\t\t: ");
                string nama = Console.ReadLine();

                Console.Write("No vaksin\t: ");
                int vaksin = Convert.ToInt32(Console.ReadLine());

                Console.Write("Keberangkatan\t: ");
                string asal = Console.ReadLine();

                Console.Write("Tujuan\t\t: ");
                string tujuan = Console.ReadLine();

                Console.WriteLine("===================================");
                Console.WriteLine("Jadwal Keberangkatan");
                Console.WriteLine("1. 08.30");
                Console.WriteLine("2. 14.00");
                Console.WriteLine("3. 19.45");
                Console.WriteLine("==================================");
                Console.Write("Masukkan pilihan [1..3]: ");
                int pilihan = Convert.ToInt32(Console.ReadLine());

                if (pilihan == 1)
                {
                    jamberangkat = "08.30";
                    jamdatang = "15.00";
                } else if (pilihan == 2)
                {
                    jamberangkat = "14.00";
                    jamdatang = "20.00";
                } else if (pilihan == 3)
                {
                    jamberangkat = "19.45";
                    jamdatang = "00.00";
                }


                Console.Write("Banyak tiket\t: ");
                int jumlah = Convert.ToInt32(Console.ReadLine());

                listTicket.Add(new Ticket
                {
                    KODEBOOKING = angka,
                    ASAL = asal,
                    TUJUAN = tujuan,
                    NAMA = nama,
                    JUMLAH = jumlah,
                    KARTUVAKSIN = vaksin,
                    JAMKEBERANGKATAN = jamberangkat,
                    JAMKEDATANGAN = jamdatang

                });
            }
            else
            {
                int angka = random.Next(10000000);

                Console.Write("NIK\t\t: ");
                int nik = Convert.ToInt32(Console.ReadLine());

                Console.Write("No vaksin\t: ");
                int vaksin = Convert.ToInt32(Console.ReadLine());

                Console.Write("Nama\t\t: ");
                string nama = Console.ReadLine();

                Console.Write("Alamat\t\t: ");
                string alamat = Console.ReadLine();

                Console.Write("No Telpon\t: ");
                string telpon = Console.ReadLine();

                Console.Clear();

                Console.WriteLine("==================================");
                Console.WriteLine("   LENGKAPI PESANAN TIKET ANDA");
                Console.WriteLine("==================================");

                Console.Write("Keberangkatan\t: ");
                string asal = Console.ReadLine();

                Console.Write("Tujuan\t\t: ");
                string tujuan = Console.ReadLine();

                Console.WriteLine("==================================");
                Console.WriteLine("Jadwal Keberangkatan");
                Console.WriteLine("1. 08.30");
                Console.WriteLine("2. 14.00");
                Console.WriteLine("3. 19.45");
                Console.WriteLine("==================================");
                Console.Write("Masukkan pilihan [1..3]: ");
                int pilihan = Convert.ToInt32(Console.ReadLine());

                if (pilihan == 1)
                {
                    jamberangkat = "08.30";
                    jamdatang = "15.00";
                } else if (pilihan == 2)
                {
                    jamberangkat = "14.00";
                    jamdatang = "20.00";
                } else if (pilihan == 3)
                {
                    jamberangkat = "19.45";
                    jamdatang = "00.00";
                }

                Console.Write("Banyak tiket\t: ");
                int jumlah = Convert.ToInt32(Console.ReadLine());

                listTicket.Add(new Ticket
                {
                    KODEBOOKING = angka,
                    NIK = nik,
                    KARTUVAKSIN = vaksin,
                    NAMA = nama,
                    ALAMAT = alamat,
                    TELPON = telpon,
                    ASAL = asal,
                    TUJUAN = tujuan,
                    JUMLAH = jumlah,
                    JAMKEBERANGKATAN = jamberangkat,
                    JAMKEDATANGAN = jamdatang
                });
            }
            Console.WriteLine();
            Console.WriteLine("==================================");
            Console.WriteLine("   Tiket berhasil ditambahkan");
            Console.WriteLine("==================================");
        }
    }
}