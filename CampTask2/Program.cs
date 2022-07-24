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
            var user1 = new Orc();
            var user2 = new Archer();

            var generator = new SuperPowerGenerator();
            var generatedPower = generator.GetSuperPower();

            ISuperPower hp = new AddHp();
            ISuperPower power = new AddPower();

            user1.AddSuperPower(hp, generatedPower);
            user2.AddSuperPower(power, generatedPower);

            BattleScene.Fight(user1, user2);


            Console.ReadKey();
        }
    }
}
