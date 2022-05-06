using System;

namespace ShapesLib
{
    public class ShapeTriangle : IShape
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public ShapeTriangle()
        {
            A = 1;
            B = 1;
            C = 3;
        }

        public ShapeTriangle(double _A, double _B, double _C)
        {
            A = _A;
            B = _B;
            C = _C;
        }

        public double GetArea()
        {
            double hp = (A + B + C) / 2;
            return Math.Sqrt(hp * (hp - A) * (hp - B) * (hp - C));
        }

        public bool IsValid()
        {
            if (A > 0 && B > 0 && C > 0)
            {
                if ((A + B > C) && (A + C > B) && (B + C > A))
                    return true;
            }
            return false;
        }

        public bool IsRightTriangle()
        {
            //if (A == B || B == C || C == B || C == A) return true;
            const double eps = 0.2D;
            if (Math.Abs(A * A + B * B - C * C) < eps)
                return true;
            if (Math.Abs(A * A + C * C - B * B) < eps)
                return true;
            if (Math.Abs(C * C + B * B - A * A) < eps)
                return true;

            return false;
        }

        public string DebugInfo()
        {
            return String.Format("Triangle. Sides: A={0} B={1} C={2} Valid: {3} IsRightTriangle: {4}", A, B, C, IsValid(), IsRightTriangle());
        }
    }
}
