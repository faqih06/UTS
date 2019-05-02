using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan kry1 = new Karyawan();
            Console.WriteLine("karyawan pertama");
            Console.Write("Inputkan Nik: ");
            kry1.Nik = Console.ReadLine();
            Console.Write("Inputkan Nama: ");
            kry1.Nama = Console.ReadLine();
            Console.Write("inputkan gaji: ");
            kry1.Gajibulanan =int.Parse(Console.ReadLine());
            if (kry1.Gajibulanan < 0)
            {
                kry1.Gajibulanan = 0;
            }
            else if (kry1.Gajibulanan >= 0)
            {
                kry1.Gajibulanan = kry1.Gajibulanan;
            }


            Console.WriteLine("\n");

            Karyawan kry2 = new Karyawan();
            Console.WriteLine("karyawan kedua");
            Console.Write("Inputkan Nik: ");
            kry2.Nik = Console.ReadLine();
            Console.Write("Inputkan Nama: ");
            kry2.Nama = Console.ReadLine();
            Console.Write("inputkan gaji: ");
            kry2.Gajibulanan = int.Parse(Console.ReadLine());
            if(kry2.Gajibulanan<0)
            {
                kry2.Gajibulanan = 0;
            }
            else if(kry2.Gajibulanan>=0)
            {
                kry2.Gajibulanan = kry2.Gajibulanan;
            }

            Console.WriteLine("\n");

            Console.WriteLine("No.\tNIk\tNama\t\t Gajibulanan");
            Console.WriteLine("...................................");
            Console.WriteLine("1.\t{0} {1}\t\t{2}", kry1.Nik, kry1.Nama, kry1.Gajibulanan);
            Console.WriteLine("2.\t{0} {1}\t\t{2}", kry2.Nik, kry2.Nama, kry2.Gajibulanan);

            Console.WriteLine("\n\n");
            Console.WriteLine("Alhamdulilah kenaikan gaji 10%");
            Console.WriteLine("\n");

            Console.WriteLine("No.\tNIk\tNama\t\t Gajibulanan");
            Console.WriteLine("...................................");
            Console.WriteLine("1.\t{0} {1}\t\t{2}", kry1.Nik, kry1.Nama, kry1.Gajibulanan + (kry1.Gajibulanan*0.10));
            Console.WriteLine("2.\t{0} {1}\t\t{2}", kry2.Nik, kry2.Nama, kry2.Gajibulanan + (kry2.Gajibulanan*0.10));

            Console.ReadKey();


        }

 
    }
}
