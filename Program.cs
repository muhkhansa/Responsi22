using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<string> daftarMahasiswa = new List<string>();
        private static bool nim;

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        TampilMahasiswa();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Mahasiswa");
            Console.WriteLine("2. Tampilkan Mahasiswa");
            Console.WriteLine("3. Keluar");

            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahMahasiswa()
        {
            Console.Clear();
            Console.Write("NIM: ");
            string nim = Console.ReadLine();
            Console.Write("Nama: ");
            string nama = Console.ReadLine();
            Console.Write("Jenis Kelamin [L/P]: ");
            string JL = Console.ReadLine();
            Console.Write("IPK: ");
            double ipk = Convert.ToDouble(Console.ReadLine());


            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();
            Console.WriteLine("1."+nim);
            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
