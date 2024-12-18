using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_9_10
{
    public class Chiselki_six:Chiselki
    {

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Chiselki_six(double x, double y, double z, double a, double b, double c) : base(x, y, z)
        {
            A = a;
            B = b;
            C = c;
        }
        public double ScalyarProizv()
        {
            return X*A + Y*B + Z*C;
        }
        public new void Print()
        {
            Console.WriteLine($"x - {X}, y - {Y}, z - {Z}, a - {A}, b - {B}, c - {C}");
        }

    }
}
