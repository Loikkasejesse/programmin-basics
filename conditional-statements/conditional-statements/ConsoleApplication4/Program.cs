using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int x, y, z;

            Console.WriteLine("Syötä 3 lukua, jotka ohjelma laittaa nousevaan järjestykseen.");
            Console.WriteLine("Syötä ensimmäinen luku: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Syötä toinen luku: ");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Syötä kolmas luku: ");
            z = int.Parse(Console.ReadLine());

            if (x > y)
            {
                if (x > z)
                {
                    if (y > z)
                    {
                        Console.WriteLine($"Luvut pienimmästä isoimpaan: {z} {y} {x}");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine($"Luvut pienimmästä isoimpaan: {y} {z} {x}");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine($"Luvut pienimmästä isoimpaan: {y} {x} {z}");
                    Console.ReadKey();
                }
            }
            else
            {
                if (y > z)
                {
                    if (x > z)
                    {
                        Console.WriteLine($"Luvut pienimmästä isoimpaan: {z} {x} {y}");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine($"Luvut pienimmästä isoimpaan: {x} {z} {y}");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine($"Luvut pienimmästä isoimpaan: {x} {y} {z}");
                    Console.ReadKey();
                }
            }
        }
    }
}

