using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeDimentionalPoint
{
    class Program
    {
        struct ThreeDPoint
        {
            private static readonly ThreeDPoint StartingPoint = new ThreeDPoint(0, 0, 0);

            public int X { get; set; }
            public int Y { get; set; }
            public int Z { get; set; }

            public static ThreeDPoint StartPoint
            {
                get
                {
                    return StartingPoint;
                }
            }

            public override string ToString()
            {
                return "X: " + X + " Y: " + Y + " Z: " + Z;
            }

            public ThreeDPoint(int x, int y, int z)
            {
                X = x;
                Y = y;
                Z = z;
            }
        }

        static class CalculateDistance
        {
            public static double GetDistance(ThreeDPoint value1, ThreeDPoint value2)
            {
                return Math.Sqrt((value1.X - value2.X) * (value1.X - value2.X) + (value1.Y - value2.Y) * (value1.Y - value2.Y) + (value1.Z - value2.Z) * (value1.Z - value2.Z));
            }
        }
        static void Main()
        {
            ThreeDPoint threeD = new ThreeDPoint(7, 12, 5);
            Console.WriteLine(threeD);
            Console.WriteLine();
        }
    }
}
