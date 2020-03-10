using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;
namespace RaceTrack.RaceTrack.Drivers
{
    class Chris : Driver
    {
        public Chris(RaceCar car) : base(car)
        {
            Name = "Chris";
            SkillLevel = 4;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}
