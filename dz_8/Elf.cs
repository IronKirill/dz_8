using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_8
{
    public abstract class ElvenFighter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Karma { get; set; }
        public int Magic { get; set; }
        public string Weapon { get; set; }

        protected ElvenFighter(string name, int health, int karma, int magic, string weapon)
        {
            Name = name;
            Health = health;
            Karma = karma;
            Magic = magic;
            Weapon = weapon;
        }

        public abstract void Attack();
        public abstract void MakeSound();
        public void showStatus()
        {
            Console.WriteLine($"Имя: {Name}, Здоровье: " +
                $"{Health}, Карма: {Karma}, Магия: {Magic}, Оружие: {Weapon}");
        }
    }


    public class ElvenKnight : ElvenFighter
    {
        public ElvenKnight(string name, int health, int karma, int magic, string weapon)
            : base(name, health, karma, magic, weapon) { }

        public override void Attack()
        {
            Console.WriteLine($"{Name} атакует своим оружием '{Weapon}' с яростью!");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} кричит: 'За честь и славу!'");
        }
    }


    public class ElvenScout : ElvenFighter
    {
        public ElvenScout(string name, int health, int karma, int magic, string weapon)
            : base(name, health, karma, magic, weapon) { }

        public override void Attack()
        {
            Console.WriteLine($"{Name} стреляет из оружия '{Weapon}' с точностью!");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} говорит: 'Моя стрела не промахнется!'");
        }
    }


    public class TempleKnight : ElvenKnight
    {
        public TempleKnight(string name, int health, int karma, int magic, string weapon)
            : base(name, health, karma, magic, weapon) { }

        public override void Attack()
        {
            Console.WriteLine($"{Name} атакует своим оружием '{Weapon}' с яростью!");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} кричит: 'За честь и славу!'");
        }
    }


    public class SwordSinger : ElvenKnight
    {
        public SwordSinger(string name, int health, int karma, int magic, string weapon)
            : base(name, health, karma, magic, weapon) { }

        public override void Attack()
        {
            Console.WriteLine($"{Name} атакует своим оружием '{Weapon}' с яростью!");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} кричит: 'За честь и славу!'");
        }
    }


    public class PlainsWalker : ElvenScout
    {
        public PlainsWalker(string name, int health, int karma, int magic, string weapon)
            : base(name, health, karma, magic, weapon) { }

        public override void Attack()
        {
            Console.WriteLine($"{Name} использует магию и оружие '{Weapon}' для атаки!");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} произносит заклинание: 'Arcanum Explosio!'");
        }
    }


    public class SilverRanger : ElvenScout
    {
        public SilverRanger(string name, int health, int karma, int magic, string weapon)
            : base(name, health, karma, magic, weapon) { }

        public override void Attack()
        {
            Console.WriteLine($"{Name} стреляет из оружия '{Weapon}' с точностью!"); ;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} говорит: 'Моя стрела не промахнется!'");
        }
    }


    public class GuasTemplar : TempleKnight
    {
        public GuasTemplar(string name, int health, int karma, int magic, string weapon)
            : base(name, health, karma, magic, weapon) { }

        public override void Attack()
        {
            Console.WriteLine($"{Name} использует магию и оружие '{Weapon}' для атаки!");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} произносит заклинание: 'Arcanum Explosio!'");
        }
    }


    public class SwordMuse : SwordSinger
    {
        public SwordMuse(string name, int health, int karma, int magic, string weapon)
            : base(name, health, karma, magic, weapon) { }

        public override void Attack()
        {
            Console.WriteLine($"{Name} атакует своим оружием '{Weapon}' с яростью!");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} кричит: 'За честь и славу!'");
        }
    }


    public class WindRider : PlainsWalker
    {
        public WindRider(string name, int health, int karma, int magic, string weapon)
            : base(name, health, karma, magic, weapon) { }

        public override void Attack()
        {
            Console.WriteLine($"{Name} стреляет из оружия '{Weapon}' с точностью!");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} говорит: 'Моя стрела не промахнется!'");
        }
    }


    public class MoonlightSentimel : SilverRanger
    {
        public MoonlightSentimel(string name, int health, int karma, int magic, string weapon)
            : base(name, health, karma, magic, weapon) { }

        public override void Attack()
        {
            Console.WriteLine($"{Name} использует магию и оружие '{Weapon}' для атаки!");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} произносит заклинание: 'Arcanum Explosio!'");
        }
    }
}