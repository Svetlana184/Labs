using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_11
{
    internal class Antenn
    {
        public string Name { get; set; }
        private double power;
        public double Power 
        {
            get => power;
            set
            {
                if (value >= 0)
                {
                    power = value;
                }
            }
        }
        private double height;
        public double Height
        {
            get => height;
            set
            {
                if (value >= 0)
                {
                    height = value;
                }
            }
        }

        public Antenn(string name, double power, double height)
        {
            Name = name;
            Power = power;
            Height = height;
        }

        public virtual double GetQuality()
        {
            return Power + 0.5 * Height;
        }

        public override string? ToString()
        {
            return $"название антенны {Name}\nмощность {Power}\nвысота {Height}\nкоэффициент {GetQuality()}";
        }
    }
}
