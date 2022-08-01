using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CampTask2.AddSuperPower;
using CampTask2.PowerGenerator;
using CampTask2.Warriors;

namespace CampTask2
{
    public static class GenerateHero
    {
        public static List<Warrior> GetBaseHeroes()
        {
            var num = 0;
            do
            {
                Console.WriteLine("Enter number of heroes");
                int.TryParse(Console.ReadLine(), out num);
                if ((num % 2) != 0)
                {
                    num = 0;
                }
            } while (num == 0);
           
            var list = new List<Warrior>();
            for (int i = 0; i < num; i++)
            {
                Warrior hero1 = GenerateWarrior( i+1);

                list.Add(hero1);
            }
            return list;
        }
        private static Warrior GenerateWarrior(int i)
        {
            Warrior user1 = null;
            while (user1 == null)
            {
                int enter = 0;
                do
                {
                    Console.WriteLine($"User - {i}\n 1 - Orc, 2 - Knight, 3 - Wizard 4 - Archer");
                    int.TryParse(Console.ReadLine(), out enter);
                } while (enter == 0);
                switch (enter)
                {
                    case 1:
                        user1 = new Orc();
                        break;
                    case 2:
                        user1 = new Knight();
                        break;
                    case 3:
                        user1 = new Wizard();
                        break;
                    case 4:
                        user1 = new Archer();
                        break;
                    default:
                        Console.WriteLine("Only 1-4 !");
                        break;

                }
            }
            GenerateWarriorSuperPower(user1, i);
            return user1;
        }
        private static void GenerateWarriorSuperPower(Warrior user1, int i)
        {
            ISuperPower superPower = null;
            var generator = new SuperPowerGenerator();
            while (superPower == null)
            {
                int enter = 0;
                do
                {
                    Console.WriteLine($"User - {i} superPower\n 1 - hp, 2 - power, 3 - armor");
                    int.TryParse(Console.ReadLine(), out enter);
                } while (enter == 0);
                switch (enter)
                {
                    case 1:
                        superPower = new AddHp();
                        user1.AddSuperPower(superPower, generator.GetSuperPower());
                        break;
                    case 2:
                        superPower = new AddPower();
                        user1.AddSuperPower(superPower, generator.GetSuperPower());
                        break;
                    case 3:
                        superPower = new AddArmor();
                        user1.AddSuperPower(superPower, generator.GetSuperPower());
                        break;
                    default:
                        Console.WriteLine("Only 1-3 !");
                        break;

                }
            }
        }
    }
}
