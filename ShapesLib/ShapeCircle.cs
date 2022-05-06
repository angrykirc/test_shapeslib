using System;

namespace ShapesLib
{
    public class ShapeCircle : IShape
    {
        public double Radius { get; set; }
        public double Diameter { get { return Radius * 2; } }

        public ShapeCircle()
        {
            Radius = 1;
        }

        public ShapeCircle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public bool IsValid()
        {
            if (Radius > 0) return true;
            return false;
        }

        public string DebugInfo()
        {
            return $"Circle. Radius: {Radius} Valid: {IsValid()}";
        }
    
    }
}
