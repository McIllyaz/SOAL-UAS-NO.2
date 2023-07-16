using System;
using System.Collections.Generic;
namespace Uas
{
    public class Show
    {
        public Show(List<Ticket> listTicket)
		{
            if (listTicket.Count > 0)
            {
                Console.Clear();
                Console.WriteLine("==================================");
                Console.WriteLine("\t  DAFTAR TIKET ANDA");
                Console.WriteLine("==================================");
                foreach (Ticket tiket in listTicket)
                {
                    int i = listTicket.IndexOf(tiket);
                    Console.WriteLine("Tiket ke-{0}", i + 1);
                    Console.WriteLine("Kode Booking\t: {0}", tiket.KODEBOOKING);
                    Console.WriteLine("Nama\t\t: {0}", tiket.NAMA);
                    Console.WriteLine("Keberangkatan\t: {0} {1}", tiket.ASAL, tiket.JAMKEBERANGKATAN);
                    Console.WriteLine("Tujuan\t\t: {0} {1}", tiket.TUJUAN, tiket.JAMKEDATANGAN);
                    Console.WriteLine("Banyak tiket\t: {0}", tiket.JUMLAH);
                    Console.WriteLine("==================================");
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