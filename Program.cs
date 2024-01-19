using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Sedan s = new Sedan(60);
            Console.WriteLine($"Sedan with {s.Wheels} wheels, driving at {s.Speed} km/h.");
            s.SpeedUp();
            Console.WriteLine($"Sedan's faster speed: {s.Speed}");

            Truck t = new Truck(45, 500);
            Console.WriteLine($"Truck with {t.Wheels} wheels and weight {t.Weight}kg, driving at {t.Speed} km/h.");
            t.SpeedUp();
            Console.WriteLine($"Truck's faster speed: {t.Speed}");
        }
    }
}
