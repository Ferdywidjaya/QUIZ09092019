using System;

namespace helloworld
{
    class program
    {
        static void Main(string[] args)
        {
            bangundatar obj = new bangundatar();
            bangunruang obj2 = new bangunruang();
                Console.WriteLine("Menghitung luas persegi ");
                Console.WriteLine("----------------------------");

                int s;
                Console.Write("Masukan nilai sisi :");
                s = Convert.ToInt32(Console.ReadLine());

                obj.luas_persegi(s);
                
                int a1, a2, a3;

                Console.WriteLine("-------------------------------");
                Console.WriteLine("Menghitung luas segitiga ");
                Console.WriteLine("-------------------------------");

                Console.Write("Masukan alas : ");
                a1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Masukan tinggi : ");
                a2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("luas segitiga adalah "+obj.luas_segitiga(a1,a2));

                Console.WriteLine("----------------------------------");
                Console.WriteLine("Menghitung luas lingkaran ");
                Console.WriteLine("----------------------------------");

                int r;
                Console.Write("Masukan panjang jari-jari :");
                r = Convert.ToInt32(Console.ReadLine());

                obj.luas_lingkaran(r);

                Console.WriteLine("-------------------------------");
                Console.WriteLine("Menghitung Volume balok ");
                Console.WriteLine("-------------------------------");

                Console.Write("Masukan panjang : ");
                a1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Masukan lebar : ");
                a2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Masukan tinggi : ");
                a3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Volume balok adalah "+obj2.Volume_balok(a1,a2,a3));


                Console.WriteLine("-------------------------");
                Console.WriteLine("menghitung Volume kubus ");
                Console.WriteLine("-------------------------");

                int sisi;

                Console.Write("Masukan sisi : ");
                sisi = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Volume kubus adalah "+obj2.Volume_kubus(sisi));
        }
    }
}