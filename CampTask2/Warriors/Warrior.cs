using CampTask2.AddSuperPower;

namespace CampTask2.Warriors
{
    public abstract class Warrior
    {
        public int XP { get; set; } = 100;
        public int Armor { get; set; } = 5;
        public int Power { get; set; } = 15;

        public virtual void AddSuperPower(ISuperPower superPower, int power) { }
    }
}
