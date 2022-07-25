using System;
using CampTask2.AddSuperPower;
using CampTask2.PowerGenerator;
using CampTask2.Warriors;

namespace CampTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior user1 = null;
            Warrior user2 = null;


            Console.WriteLine("User1\n enter 1 - Orc, 2 - Knight, 3 - Wizard 4 - Archer");
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
            Console.WriteLine("User2\n enter 1 - Orc, 2 - Knight, 3 - Wizard 4 - Archer");
            enter = Convert.ToInt32(Console.ReadLine());
            switch (enter)
            {
                case 1:
                    user2 = new Orc();
                    break;
                case 2:
                    user2 = new Knight();
                    break;
                case 3:
                    user2 = new Wizard();
                    break;
                case 4:
                    user2 = new Archer();
                    break;

            }

            ISuperPower hp = new AddHp();
            ISuperPower power = new AddPower();
            ISuperPower armor = new AddArmor();
            var generator = new SuperPowerGenerator();
            Console.WriteLine("User1 superPower\n 1 - hp, 2 - power, 3 - armor");
            enter = Convert.ToInt32(Console.ReadLine());
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
            Console.WriteLine("User2 superPower\n 1 - hp, 2 - power, 3 - armor");
            enter = Convert.ToInt32(Console.ReadLine());
            switch (enter)
            {
                case 1:
                    user2.AddSuperPower(hp, generator.GetSuperPower());
                    break;
                case 2:
                    user2.AddSuperPower(power, generator.GetSuperPower());
                    break;
                case 3:
                    user2.AddSuperPower(armor, generator.GetSuperPower());
                    break;

            }

            BattleScene.Fight(user1, user2);


            Console.ReadKey();
        }
    }
}
