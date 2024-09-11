using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIWID_PESAN_MAKANAN
{

}
class Program
{
    static void Main()
    {
        // Array untuk daftar makanan dan harga
        string[] makanan = { "Nasi Goreng", "Nasi Uduk", "Nasi Kucing", "Mie Rebus", "Mie Goreng", "Mie Ayam" };
        double[] hargaMakanan = { 12000, 9000, 6000, 7000, 8000, 10000 };

        // Array untuk daftar minuman dan harga
        string[] minuman = { "Teh Botol", "Teh Pucuk", "Susu Jahe", "Kopi Jahe", "Kopi Susu", "Tea Jus" };
        double[] hargaMinuman = { 5000, 4000, 3000, 3000, 5000, 0 }; // Tea Jus gratis

        // Menampilkan menu makanan
        Console.WriteLine("1. Makanan");
        for (int i = 0; i < makanan.Length; i++)
        {
            Console.WriteLine($"{(char)('a' + i)}. {makanan[i]} - Rp {hargaMakanan[i]:N0}");
        }

        // Menampilkan menu minuman
        Console.WriteLine("\n2. Minuman");
        for (int i = 0; i < minuman.Length; i++)
        {
            string hargaStr = hargaMinuman[i] == 0 ? "FREE" : $"Rp {hargaMinuman[i]:N0}";
            Console.WriteLine($"{(char)('a' + i)}. {minuman[i]} - {hargaStr}");
        }

        // Input dari pengguna
        Console.Write("\nPesanan = ");
        string pesanan = Console.ReadLine();

        // Validasi kode menu dan tipe pesanan (makanan atau minuman)
        char tipePesanan = pesanan[0]; // 1 atau 2
        char kodeMenu = pesanan[1]; // a, b, c, dst.

        // Konversi kodeMenu dari karakter ke indeks array
        int index = kodeMenu - 'a';

        // Mengambil harga berdasarkan tipe pesanan
        double harga = 0;
        string namaPesanan = "";

        if (tipePesanan == '1' && index >= 0 && index < makanan.Length)
        {
            // Jika memilih makanan
            harga = hargaMakanan[index];
            namaPesanan = makanan[index];
        }
        else if (tipePesanan == '2' && index >= 0 && index < minuman.Length)
        {
            // Jika memilih minuman
            harga = hargaMinuman[index];
            namaPesanan = minuman[index];
        }
        else
        {
            Console.WriteLine("Kode menu tidak valid.");
            return;
        }

        // Input jumlah pesanan
        Console.Write("\nBerapa Banyak yang dipesan: ");
        int jumlah = int.Parse(Console.ReadLine());

        // Menghitung total harga
        double totalHarga = harga * jumlah;

        // Jika gratis, total harga tetap 0
        if (harga == 0)
        {
            Console.WriteLine($"\nAnda memesan {jumlah} {namaPesanan} dan total harga adalah FREE");
        }
        else
        {
            Console.WriteLine($"\nAnda memesan {jumlah} {namaPesanan} dengan total harga Rp {totalHarga:N0}");
        }
    }
}