using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LAB_11
{
    internal class AntennSuper:Antenn
    {
        private double emissivity;
        public double Emissivity
        {
            get => emissivity;
            set
            {
                if (value >= 0)
                {
                    emissivity = value;
                }
            }
        }

        public AntennSuper(string name, double power, double height, double _emissivity) : base (name, power, height)
        {
            Emissivity = _emissivity;
        }

        public override double GetQuality()
        {
            return base.GetQuality() - 0.1 * Emissivity;
        }

        public override string? ToString()
        {
            return $"название антенны: {Name}\nмощность: {Power}\nвысота: {Height}\nкоэффициент излучения: {Emissivity}\nкоэффициент: {GetQuality()}";
        }
    }
}
