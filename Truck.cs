using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnInterfaces
{
    class Truck : IAutomobile
    {
        public double Speed
        {
            get;
            set;
        }

        public int Wheels
        { get; set; }

        public double Weight
        { get; set; }

        public void Honk()
        {
            Console.WriteLine("HONK!");
        }

        public Truck(double speed, double weight)
        {
            this.Speed = speed;
            this.Weight = weight;
            if (weight < 400)
            {
                this.Wheels = 8;
            }
            else
            {
                this.Wheels = 12;
            }
        }

        public void SpeedUp()
        {
            this.Speed += 5;
        }

        public void SlowDown()
        {
            this.Speed -= 5;
        }
    }
}
