using CampTask2.Warriors;

namespace CampTask2.AddSuperPower
{
    public class AddHp: ISuperPower
    {
        public void AddSuperPower(Warrior warrior, int power)
        {
            warrior.XP += power;
        }
    }
}
