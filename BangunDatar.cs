using System;

namespace QUIZ09092019
{
    class BangunDatar
    {
        //Luas Persegi

       public void luaspersegi()
       {
           int sisi;

           Console.WriteLine("Menghitung Luas Persegi");
           Console.WriteLine("-----------------------");
           
           Console.Write("Masukkan Nilai Sisi : ");
           sisi = Convert.ToInt32(Console.ReadLine());

           int luas = sisi * sisi;

           Console.WriteLine("Luas Persegi Adalah : "+luas);
           Console.WriteLine("    ");
       }


        //Luas Segitiga

       public void luassegitiga()
       {
           int alas, tinggi;

           Console.WriteLine("Menghitung Luas Segitiga");
           Console.WriteLine("-----------------------");

           Console.Write("Masukkan Nilai Alas : ");
           alas = Convert.ToInt32(Console.ReadLine());

           Console.Write("Masukkan Nilai Tinggi : ");
           tinggi = Convert.ToInt32(Console.ReadLine());

           int luas;

           luas = alas * tinggi / 2;

           Console.WriteLine("Luas Segitiga Adalah : "+luas);
           Console.WriteLine("    ");
       }

       // Luas Lingkaran

       public void luaslingkaran()
       {
           int r;

           Console.WriteLine("Menghitung Luas Lingkaran");
           Console.WriteLine("-----------------------");

           Console.Write("Masukkan Nilai Jari-Jari : ");
           r = Convert.ToInt32(Console.ReadLine());

           double luas;

           luas = 3.14 * r * r;

           Console.Write("Luas Lingkaran Adalah : "+ luas);
           Console.WriteLine("    ");

       }
    }
}