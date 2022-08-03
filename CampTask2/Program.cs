using System;
using System.Threading.Tasks;
using CampTask2.AddSuperPower;
using CampTask2.PowerGenerator;
using CampTask2.Warriors;
using System.Linq;
namespace CampTask2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            while (true)
            {
                var heroes = GenerateHero.GetBaseHeroes();
                var battleFighters = heroes.Chunk(2).Select(x => BattleScene.Fight(x.First(), x.Last()));
                await Task.WhenAll(battleFighters);
                Console.WriteLine("\n\nKeep playing");
            }
        }
    }
}
