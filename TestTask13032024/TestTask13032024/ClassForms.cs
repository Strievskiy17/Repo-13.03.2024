using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask13032024
{
    public abstract class MainClass
    {
        public string name{ get; private set; }

        public MainClass(string name)
        {
            this.name = name;
        }

        public abstract double Ploshad();
    }

    public static class ShapePrototype
    {
        public static double Ploshad(MainClass shape) => shape.Ploshad();
    }

    public class Krug : MainClass
    {
        public double Radius { get; private set; }

        public Krug(string name, double Radius) : base(name)
        {
            this.Radius = Radius;
        }

        public override double Ploshad()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 1);
        }
    }

    public class Treug: MainClass
    {
        public double ab { get; private set; }
        public double bc { get; private set; }
        public double ac { get; private set; }

        public Treug(string name, double ab, double bc, double ac) : base(name)
        {
            if (ab < 0 || bc < 0 || ac < 0) throw new ArgumentException($"Error: Side can not be less than 0\nCheck your input values");
            else if (ab > (bc + ac) || bc > (ab + ac) || ac > (ab + bc)) throw new ArgumentException($"Error: Your side greater than summary of two another sides\nCheck your input values");
            else
            {
                this.ab = ab;
                this.bc = bc;
                this.ac = ac;
            }
        }

        public override double Ploshad()
        {
            double p = (ab + bc + ac) / 2;
            double result = Math.Round(Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac)), 1);
            return result;
        }

        public bool IsRectangular()
        {
            bool check = (ab == Math.Sqrt(Math.Pow(bc, 2) + Math.Pow(ac, 2)) || bc == Math.Sqrt(Math.Pow(ab, 2) + Math.Pow(ac, 2)) || ac == Math.Sqrt(Math.Pow(ab, 2) + Math.Pow(bc, 2)));
            return check;
        }
    }
}
