using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnInterfaces
{
    interface IAutomobile
    {
        double Speed { get; set; }
        int Wheels { get; set; }
        void Honk();
    }
}
