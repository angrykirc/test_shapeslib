using System;
using System.Collections.Generic;
using ShapesLib;

namespace TestProgram
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var shapes = new List<IShape>();

            var triBad = new ShapeTriangle(3, 2, 6);
            var triGood = new ShapeTriangle(3, 9, 9);
            var circ = new ShapeCircle(3);

            shapes.AddRange(new IShape[] { triBad, triGood, circ });

            double totalArea = 0D;
            foreach (IShape sh in shapes)
            {
                Console.WriteLine(sh.DebugInfo());

                if (sh.IsValid())
                    totalArea += sh.GetArea();
            }
            Console.WriteLine("Total area of all shapes: {0}", totalArea);
        }
    }
}
