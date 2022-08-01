using System;
using System.Threading.Tasks;
using CampTask2.Warriors;

namespace CampTask2
{
    public static class BattleScene
    {

        public static async Task Fight(Warrior warrior1, Warrior warrior2)
        {
            var round = 1;
           
            while (warrior1.IsAlive && warrior2.IsAlive)
            {
                Console.WriteLine($"Раунд {round}");
                var atack1 = warrior1.Attack();
                warrior2.Defense(atack1);

                var atack2 = warrior2.Attack();
                warrior1.Defense(atack2);
                if (warrior1.XP <= 0)
                {
                    Console.WriteLine($"Перемiг у раундi {round} - {warrior2}");
                    break;
                }
                if (warrior2.XP <= 0)
                {
                    Console.WriteLine($"Перемiг у раундi {round} - {warrior1}");
                    break;
                }
                round++;
                await Task.Delay(100);
            }
        }
    }
}
