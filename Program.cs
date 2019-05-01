using System;

namespace membuat_class
{
    class Program
    {
        static void Main(string[] args)
        {
            //buat objek 
            Mahasiswa jati = new Mahasiswa();
            Mahasiswa ratih = new Mahasiswa();

            //set nilai properties
            jati.NIM = "18.11.2243";
            jati.Nama = "Priambodo Jati";
            jati.IPK = 4.5f;

            ratih.NIM = "18.11.2252";
            ratih.Nama = "Ratih Nur Hasannah";
            ratih.IPK = 5.5f;

            //memanggil method
            jati.Registrasi();
            jati.IsiKRS();

            ratih.Registrasi();
            ratih.IsiKRS();

            Console.ReadKey();
        }
    }
}