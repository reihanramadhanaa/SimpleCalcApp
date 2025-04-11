using System;

class Program
{
    static void Main()
    {
        Kalkulator kalkulator = new Kalkulator();

        Console.Write("Masukkan angka pertama: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Masukkan angka kedua: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Hasil Penjumlahan: " + kalkulator.Tambah(a, b));
        Console.WriteLine("Hasil Pengurangan: " + kalkulator.Kurang(a, b));
        Console.WriteLine("Hasil Perkalian: " + kalkulator.Kali(a, b));

    }
}
