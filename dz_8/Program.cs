using static System.Net.Mime.MediaTypeNames;
using System.Threading;
using System;

namespace dz_8
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("______________________________");
            Console.WriteLine("| ВЫБЕРИТЕ ГЕРОЯ:            |");
            Console.WriteLine("|                            |");
            Console.WriteLine("| 1. ElvenKnight             |");
            Console.WriteLine("| 2. ElvenScout              |");
            Console.WriteLine("| 3. TempleKnight            |");
            Console.WriteLine("| 4. SwordSinger             |");
            Console.WriteLine("| 5. PlainsWalker            |");
            Console.WriteLine("| 6. SilverRanger            |");
            Console.WriteLine("| 7. GuasTemplar             |");
            Console.WriteLine("| 8. SwordMuse               |");
            Console.WriteLine("| 9. WindRider               |");
            Console.WriteLine("| 10. MoonlightSentimel      |");
            Console.WriteLine("|____________________________|");

            int choice = int.Parse(Console.ReadLine() ?? "1");

            ElvenFighter heroes = choice switch
            {
                1 => new ElvenKnight("Elven Knight", 100, 50, 20, "Меч"),
                2 => new ElvenScout("Elven Scout", 80, 60, 40, "Лук"),
                3 => new TempleKnight("Temple Knight", 100, 50, 20, "Меч"),
                4 => new SwordSinger("Sword Singer", 100, 50, 20, "Меч"),
                5 => new PlainsWalker("Plains Walker", 70, 30, 100, "Копьё"),
                6 => new SilverRanger("Silver Ranger", 80, 60, 40, "Арбалет"),
                7 => new GuasTemplar("Guas Templar", 70, 30, 100, "Топор"),
                8 => new SwordMuse("Sword Muse", 100, 50, 20, "Меч"),
                9 => new WindRider("Wind Rider", 80, 60, 40, "Арбалет"),
                10 => new MoonlightSentimel("Moonlight Sentimel", 70, 30, 100, "Копьё"),
                _ => new ElvenKnight("Elven Knight", 100, 50, 20, "Меч")
            };

            Console.WriteLine($"ВЫ ВЫБРАЛИ ГЕРОЯ: {heroes.Name}");
            heroes.showStatus();

            ElvenFighter enemy = new TempleKnight("Temple Knight ENEMY", 200, 100, 40, "Меч");
            Console.WriteLine($"\nВАШ ПРОТИВНИК: {enemy.Name}");
            enemy.showStatus();

            Console.WriteLine("\nБИТВА НАЧИНАЕТСЯ!");

            while (heroes.Health > 0 && enemy.Health > 0)
            {
                Console.WriteLine("________________________________");
                Console.WriteLine("| ВЫБЕРИТЕ ДЕЙСТВИЕ:           |");
                Console.WriteLine("|                              |");
                Console.WriteLine("| 1. АТАКОВАТЬ                 |");
                Console.WriteLine("| 2. ПОДАТЬ ГОЛОС              |");
                Console.WriteLine("| 3. ПОКАЗАТЬ СТАТУС           |");
                Console.WriteLine("|______________________________|");

                int action = int.Parse(Console.ReadLine() ?? "1");

                if (action == 1)
                {
                    heroes.Attack();
                    enemy.Health -= 100;

                    if (enemy.Health <= 0)
                    {
                        Console.WriteLine($"{enemy.Name} ПОБЕЖДЁН!");
                        break;
                    }

                    enemy.Attack();
                    heroes.Health -= 10;

                    if (heroes.Health <= 0)
                    {
                        Console.WriteLine("ВЫ - ПРОИГРАЛИ!");
                        break;
                    }
                }

                else if (action == 2)
                {
                    heroes.MakeSound();
                }

                else if (action == 3)
                {
                    heroes.showStatus();
                    enemy.showStatus();
                }

                else
                {
                    Console.WriteLine("ERROR!");
                }
            }
            Console.WriteLine("\nКОНЕЦ ИГРЫ!");
            Console.WriteLine("\nВЫ - ВЫИГРАЛИ!");
        }
    }
}