using System;
using CampTask2.Warriors;

namespace CampTask2
{
    public static class BattleScene
    {

        public static void Fight(Warrior warrior1, Warrior warrior2)
        {
            while (warrior1.IsAlive && warrior2.IsAlive)
            {
                var atack1 = warrior1.Attack();
                warrior2.Defense(atack1);

                var atack2 = warrior2.Attack();
                warrior1.Defense(atack2);
                if (warrior1.XP <= 0)
                {
                    Console.WriteLine($"Перемiг - {warrior2}");
                    break;
                }
                if (warrior2.XP <= 0)
                {
                    Console.WriteLine($"Перемiг - {warrior1}");
                    break;
                }
            }
        }
    }
}
