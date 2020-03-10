using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    class Accord : RaceCar
    {
        public Accord()
        {
            Name = "Accord";
            TopSpeed = 90;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} engine starts in an extremely average fashion.");
        }
        public override void Brake()
        {
            Console.WriteLine($"The {Name} has stopped in an extremely average fashion.");
            base.Brake();
        }
    }
}
