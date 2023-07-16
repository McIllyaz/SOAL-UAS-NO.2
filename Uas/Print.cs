using System;
using System.Collections.Generic;
namespace Uas
{
	public class Print
	{
        public Print(List<Ticket> listTicket)
        {
            if (listTicket.Count > 0)
            {
                foreach (Ticket tiket in listTicket)
                {
                    Console.WriteLine("=================================================");
                    Console.WriteLine("|\t\tDETAIL TIKET KERETA\t\t|");
                    Console.WriteLine("=================================================");
                    Console.WriteLine("|\t{0}\t-\t{1}\t\t|", tiket.ASAL, tiket.TUJUAN);
                    Console.WriteLine("|\t\t\t\t\t\t|");
                    Console.WriteLine("|Kode Booking\t: {0}\t\t\t|", tiket.KODEBOOKING);
                    Console.WriteLine("|========================\t\t\t|");
                    Console.WriteLine("|Jam :\t\t\t\t\t\t|");
                    Console.WriteLine("|{0} - {1}\t\t\t\t\t|", tiket.JAMKEBERANGKATAN, tiket.JAMKEDATANGAN);
                    Console.WriteLine("|Nama\t\t: {0}\t|", tiket.NAMA);
                    Console.WriteLine("|Vaksin\t\t: {0}\t\t\t|", tiket.KARTUVAKSIN);
                    Console.WriteLine("|Banyak tiket\t: {0}\t\t\t\t|", tiket.JUMLAH);
                    Console.WriteLine("=================================================");
                    Console.WriteLine();
                    Console.WriteLine();
                }
                Console.WriteLine("Tekan enter / spasi untuk kembali ke menu :)");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("=========================================");
                Console.WriteLine("Anda tidak memiliki tiket aktif saat ini.");
                Console.WriteLine("=========================================");
                Console.ReadKey();
            }
        }
    }
}