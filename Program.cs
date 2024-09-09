using System;

class Program
{
    static void Main()
    {
        int pilihan;
        double celcius, hasil;

        do
        {
            Console.WriteLine("===== Aplikasi Konversi Suhu =====");
            Console.WriteLine("Pilih Salah Satu Menu:");
            Console.WriteLine("1. Celcius ke Fahrenheit");
            Console.WriteLine("2. Celcius ke Kelvin");
            Console.WriteLine("3. Celcius ke Reamur");
            Console.WriteLine("4. Exit");
            Console.Write("Pilihan Anda: ");
            pilihan = int.Parse(Console.ReadLine());

            if (pilihan >= 1 && pilihan <= 3)
            {
                Console.Write("Masukkan suhu dalam Celcius: ");
                celcius = double.Parse(Console.ReadLine());
            }
            else
            {
                celcius = 0;
            }

            switch (pilihan)
            {
                case 1:
                    hasil = (celcius * 9 / 5) + 32;
                    Console.WriteLine("Hasil Konversi: {0} Celcius = {1} Fahrenheit", celcius, hasil);
                    break;
                case 2:
                    hasil = celcius + 273.15;
                    Console.WriteLine("Hasil Konversi: {0} Celcius = {1} Kelvin", celcius, hasil);
                    break;
                case 3:
                    hasil = celcius * 4 / 5;
                    Console.WriteLine("Hasil Konversi: {0} Celcius = {1} Reamur", celcius, hasil);
                    break;
                case 4:
                    Console.WriteLine("Terima kasih telah menggunakan aplikasi ini.");
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid, coba lagi.");
                    break;
            }

            Console.WriteLine("=================================");
        } while (pilihan != 4);
    }
}
