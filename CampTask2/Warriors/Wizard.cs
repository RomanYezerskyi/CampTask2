using CampTask2.AddSuperPower;

namespace CampTask2.Warriors
{
    public class Wizard: Warrior
    {
        public override void AddSuperPower(ISuperPower superPower, int power)
        {
            superPower.AddSuperPower(this, power);
        }
    }
}
