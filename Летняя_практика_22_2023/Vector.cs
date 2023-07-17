using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Летняя_практика_22_2023
{
    public class Vector
    {
        private double x;
        private double y;
        private double z;
        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }
        public double Z { get { return z; } set { z = value; } }
        public Vector(double _x, double _y, double _z)
        {
            this.x = _x; 
            this.y = _y;
            this.z = _z;
        }

        public static double Vect_length(double _x, double _y, double _z)
        {
            return Math.Sqrt(_x * _x + _y * _y + _z * _z);
        }

        public static double Skal_pr(Vector first, Vector second)
        {
            return first.X * second.X + first.Y * second.Y + first.Z * second.Z;
        }
        
        public static List<double> Vekt_pr(Vector first, Vector second)
        {
            double i = first.Y * second.Z - second.Y * first.Z;
            double j = first.X * second.Z - second.X * first.Z;
            if (j < 0) j = Math.Abs(j);
            double k = first.X * second.Y - second.X * first.Y;
            List<double> pr = new List<double> { i, j, k };
            return pr;
        }
    }
}
