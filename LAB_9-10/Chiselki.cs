using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_9_10
{
    public class Chiselki
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        
        ~Chiselki() 
        {
            Console.WriteLine($"объект был удалён");
        }

        public Chiselki(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public double SrGeom()
        {
            return Math.Pow(X * Y * Z, 1.0/3);
        }
        public int NumSum()
        {
            string sum = Convert.ToString(X+Y+Z);
            int i = 0;
            foreach (char var in sum)
            {
                if (var != ',') i += 1;
            }
            return i;
        }
        public void Print()
        {
            Console.WriteLine($"x - {X}, y - {Y}, z - {Z}");
        }
    }
}
