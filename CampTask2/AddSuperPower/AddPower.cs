using CampTask2.Warriors;

namespace CampTask2.AddSuperPower
{
    public class AddPower:ISuperPower
    {
        public void AddSuperPower(Warrior warrior, int power)
        {
            warrior.Power += power;
        }
    }
}
