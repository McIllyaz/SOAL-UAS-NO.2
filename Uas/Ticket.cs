using System;
namespace Uas
{
	public class Ticket
	{
        public int KODEBOOKING { get; set; }
        public int NIK;
        public int KARTUVAKSIN;
        public string NAMA;
        public string ALAMAT;
        public string TELPON;
        public string ASAL;
        public string TUJUAN { get; set; }
        public int JUMLAH { get; set; }
        public string JAMKEBERANGKATAN { get; set; }
        public string JAMKEDATANGAN { get; set; }
    }
}