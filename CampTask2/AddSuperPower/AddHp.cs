using CampTask2.Warriors;

namespace CampTask2.AddSuperPower
{
    internal class AddHp: ISuperPower
    {
        public void AddSuperPower(Warrior warrior, int power)
        {
            warrior.XP += power;
        }
    }
}
