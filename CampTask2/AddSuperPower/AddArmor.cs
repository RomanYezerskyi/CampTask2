using CampTask2.Warriors;

namespace CampTask2.AddSuperPower
{
    internal class AddArmor:ISuperPower
    {
        public void AddSuperPower(Warrior warrior, int power)
        {
            warrior.Armor += power;
        }
    }
}
