using System;

namespace ConsoleApp1
{
    class Program
    {
		class Calculator
		{
			static void Main(string[] args)
			{
				Console.WriteLine("Masukkan Angka:");
				int a = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Masukkan Angka:");
				int b = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Pilih Menu(dalam bentuk angka): ");
				Console.WriteLine("1.Pertambahan:");
				Console.WriteLine("2.Pengurangan:");
				Console.WriteLine("3.Perkalian:");
				Console.WriteLine("4.Pembagianan:");

				int pilihan = Convert.ToInt32(Console.ReadLine()); ;
				switch (pilihan)
				{
					case 1:
						Console.WriteLine("Masukkan Angka:");
						Console.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b));
						break;
					case 2:
						Console.WriteLine("Hasil Pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a, b));
						break;
					case 3:
						Console.WriteLine("Hasil Perkalian: {0} * {1} = {2}", a, b, Perkalian(a, b));
						break;
					case 4:
						Console.WriteLine("Hasil Pembagian: {0} / {1} = {2}", a, b, Pembagian(a, b));
						break;
					
					default:
						// code block
						break;
				}

				Console.WriteLine("\nTekan Sembarang key untuk keluar");
				Console.ReadKey();
			}
		}
		static int Penambahan(int a, int b)
		{
			return a + b;

		}
		static int Pengurangan(int a, int b)
		{
			return a - b;
		}
		static int Perkalian(int a, int b)
		{
			return a * b;
		}
		static int Pembagian(int a, int b)
		{
			return a / b;
		}
	}
}
