using System;
using System.Collections.Generic;
namespace Uas
{
    public class Person
    {
        public Person(List<Ticket> listTicket)
        {
            Console.Clear();
            Console.WriteLine("==================================");
            Console.WriteLine("DETAIL DATA DIRI ANDA");
            Console.WriteLine("==================================");

            if (listTicket.Count > 0)
            {
                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine($"NIK\t\t: {listTicket[i].NIK}");
                    Console.WriteLine($"Kartu Vaksin\t: {listTicket[i].KARTUVAKSIN}");
                    Console.WriteLine($"Nama\t\t: {listTicket[i].NAMA}");
                    Console.WriteLine($"Alamat\t\t: {listTicket[i].ALAMAT}");
                    Console.WriteLine($"No telpon\t: {listTicket[i].TELPON}");
                }
                Console.WriteLine("Tekan enter / spasi untuk kembali ke menu :)");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("============================================");
                Console.WriteLine("Anda belum mengisi data diri untuk saat ini");
                Console.WriteLine("Silakan isi data diri terlebih dahulu");
                Console.WriteLine("============================================");
                Console.ReadKey();
            }
        }
    }

}