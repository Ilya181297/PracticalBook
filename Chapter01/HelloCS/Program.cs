using System;

namespace HelloCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 100;
            Console.WriteLine("Сыграем в игру");
            Console.WriteLine("Выбери 1 или 2 и нажми Enter");
            int z = Convert.ToInt32(Console.ReadLine());
            switch (z)
            {
                case 1:
                    for (var i = 10; i <= n; i = i + 10)
                    {
                        Console.WriteLine($"Быдло[{i}%]");
                        System.Threading.Thread.Sleep(1000);
                    }
                    Console.WriteLine("ТЫ БЫДЛО");
                    break;

                case 2:
                    for (var i = 10; i <= n; i = i + 10)
                    {
                        Console.WriteLine($"Интелегент[{i}%]");
                        System.Threading.Thread.Sleep(1000);
                    }
                    Console.WriteLine("Ви есть интелегент");
                    break;
            }
        }
    }
}
