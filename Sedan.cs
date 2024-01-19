using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnInterfaces
{
    class Sedan : IAutomobile
    {
        public double Speed
        {
            get;
            set;
        }

        public int Wheels
        { get; set; }

        public void Honk()
        {
            Console.WriteLine("HONK!");
        }

        //CONSTRUCTORS  

        public Sedan(double speed)
        {
            this.Speed = speed;
            this.Wheels = 4;
        }

        //METHODS 
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
