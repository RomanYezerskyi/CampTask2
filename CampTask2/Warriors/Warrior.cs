using CampTask2.AddSuperPower;

namespace CampTask2.Warriors
{
    public abstract class Warrior
    {
        public int XP { get; set; } = 100;
        public int Armor { get; set; } = 5;
        public int Power { get; set; } = 15;
        public bool IsAlive { get; set; } = true;
        public virtual void AddSuperPower(ISuperPower superPower, int power) { }
        public int Attack()
        {
            if (this.Armor > 0)
            {
                return this.Power;
            }
            else
            {
                if (this.Power > 1)
                {
                    this.Power--;
                    return this.Power;
                }
                else
                {
                    return this.Power;
                }
            }
        }
        public void Defense(int power)
        {
            if (this.Armor > 0)
            {
                if (this.Armor >= power)
                {
                    var temp = power / 2;
                    power -= temp;
                    this.Armor -= temp;
                }
                power -= this.Armor;
                this.Armor = 0;
            }

            this.XP -= power;
        }
    }
}
