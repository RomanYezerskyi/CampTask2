using System;

namespace CampTask2.PowerGenerator
{
    public class SuperPowerGenerator
    {
        public int GetSuperPower()
        {
            var date = DateTime.Now.Second;
            while (true)
            {
                if (date >= 5 && date <= 10)
                {
                    return date;
                }

                if (date < 5)
                {
                    return date + 5;
                }

                if (date > 10)
                {
                    date /= 10;
                }
            }
        }
    }
}
