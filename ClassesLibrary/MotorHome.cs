using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class MotorHome : Vehicle
    {

        public int NumberOfBeds { get; set; }

        public MotorHome(string make, string model, int year, float weight, int numberOfBeds) : base(make, model, year, weight)
        {
            NumberOfBeds = numberOfBeds;
        }
        public MotorHome() { }

        public override string ToString()
        {
            return string.Format($"{base.ToString()}\nNumber Of Beds{NumberOfBeds}");
        }

    }
}
