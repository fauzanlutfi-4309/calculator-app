using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int hasil = 0;

            Console.WriteLine("Pilih menu calculator \n");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.Write("\nInput nomor menu [1..4]: ");
            int pilih = int.Parse(Console.ReadLine());
            

            if (pilih == 1)
            {
                Console.Write("\nInputkan nilai a = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine());

                hasil = a + b;
                Console.WriteLine("\nHasil Penambahan " + a + " + " + b + " = " + hasil);
            }
            else if (pilih == 2)
            {
                Console.Write("\nInputkan nilai a = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine());

                hasil = a - b;
                Console.WriteLine("\nHasil Pengurangan " + a + " - " + b + " = " + hasil);
            }
            else if (pilih == 3) {
                Console.Write("\nInputkan nilai a = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine());

                hasil = a * b;
                Console.WriteLine("\nHasil Perkalian " + a + " * " + b + " = " + hasil);
            }
            else if  (pilih == 4){
                Console.Write("\nInputkan nilai a = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine());

                hasil = a / b;
                Console.WriteLine("\nHasil Pembagian " + a + " / " + b + " = " + hasil);
            }
            else
            {
                Console.WriteLine("Maaf, menu yang Andi pilih tidak tersedia");
            }
            Console.WriteLine("Tekan sembarang key untuk keluar");
            Console.ReadKey();
            
        }

    }
}
