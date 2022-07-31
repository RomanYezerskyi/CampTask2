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
            while (true)
            {
                var heroes = GenerateHero.GeneBaseHeroes();

                for (int i = 0; i <= heroes.Count / 2; i+=2)
                {
                    BattleScene.Fight(heroes[i], heroes[i + 1]);
                }

                Console.WriteLine("\n\nKeep playing");


            }

            Console.ReadKey();
        }
    }
}
