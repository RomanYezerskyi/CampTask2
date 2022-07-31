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
    internal static class GenerateHero
    {
        public static List<Warrior> GeneBaseHeroes()
        {
            Console.WriteLine("Enter number of heroes");
            var num = Convert.ToInt32(Console.ReadLine());
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

            Console.WriteLine($"User - {i}\n 1 - Orc, 2 - Knight, 3 - Wizard 4 - Archer");
            var enter = Convert.ToInt32(Console.ReadLine());
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

            }
            GenerateWarriorSuperPower(user1, i);
            return user1;
        }
        private static void GenerateWarriorSuperPower(Warrior user1, int i)
        {
            ISuperPower hp = new AddHp();
            ISuperPower power = new AddPower();
            ISuperPower armor = new AddArmor();
            var generator = new SuperPowerGenerator();
            Console.WriteLine($"User - {i} superPower\n 1 - hp, 2 - power, 3 - armor");
            var enter = Convert.ToInt32(Console.ReadLine());
            switch (enter)
            {
                case 1:
                    user1.AddSuperPower(hp, generator.GetSuperPower());
                    break;
                case 2:
                    user1.AddSuperPower(power, generator.GetSuperPower());
                    break;
                case 3:
                    user1.AddSuperPower(armor, generator.GetSuperPower());
                    break;

            }
        }
    }
}
