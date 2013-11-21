using System;
using System.Linq;
using System.Collections.Generic;
namespace Triangles
{
    public struct Point
    {
        public int x, y;

        public Point(int a, int b)
        {
            x = a;
            y = b;
        }
    }

    public class Triangle
    {
        double[] sides;

        public Triangle(double a, double b, double c)
        {
            if (!(a > 0 && b > 0 && c > 0))
            {
                throw new ArgumentException("Sidan i en triangel kan inte vara 0 eller mindre");
            }
            sides = new double[] { a, b, c };
        }

        public Triangle(double[] s)
        {
            if (s.Length != 3)
            {
                throw new ArgumentException("A triangle exists of 3 points.");
            }
            if (!(s[0] > 0 && s[1] > 0 && s[2] > 0))
            {
                throw new ArgumentException("Sidan i en triangel kan inte vara 0 eller mindre");
            }

            sides = new double[s.Length];
            for (int i = 0; i < s.Length; i++)
                sides[i] = s[i];
        }

        public Triangle(Point a, Point b, Point c)
        {
            if ((a.x == b.x && a.y == b.y) || (b.x == c.x && b.y == c.y) || (c.x == a.x && c.y == a.y))
            {
                throw new ArgumentException("Om 2 koordinater har samma värde går det inte att rita triangeln");
            }

            sides = new double[3];
            sides[0] = Math.Sqrt(Math.Pow((double)(a.x - b.x), 2.0) + Math.Pow((double)(a.y - b.y), 2.0));
            sides[1] = Math.Sqrt(Math.Pow((double)(b.x - c.x), 2.0) + Math.Pow((double)(b.y - c.y), 2.0));
            sides[2] = Math.Sqrt(Math.Pow((double)(c.x - a.x), 2.0) + Math.Pow((double)(c.y - a.y), 2.0));
        }

        public Triangle(Point[] s)
        {
            if ((s[0].x == s[1].x && s[0].y == s[1].y) || (s[1].x == s[2].x && s[1].y == s[2].y) || (s[2].x == s[0].x && s[2].y == s[0].y))
            {
                throw new ArgumentException("Om 2 koordinater har samma värde går det inte att rita triangeln");
            }
            if (s.Length != 3)
            {
                throw new ArgumentException("A triangle exists of 3 points.");
            }


            sides = new double[s.Length];
            sides[0] = Math.Sqrt(Math.Pow((double)(s[0].x - s[1].x), 2.0) + Math.Pow((double)(s[0].y - s[1].y), 2.0));
            sides[1] = Math.Sqrt(Math.Pow((double)(s[1].x - s[2].x), 2.0) + Math.Pow((double)(s[1].y - s[2].y), 2.0));
            sides[2] = Math.Sqrt(Math.Pow((double)(s[2].x - s[0].x), 2.0) + Math.Pow((double)(s[2].y - s[0].y), 2.0));
        }

        private int uniqueSides()
        {
            return sides.Distinct<double>().Count();
        }

        public bool isScalene()
        {
            if (uniqueSides() == 3)
                return true;
            return false;
        }

        public bool isEquilateral()
        {
            if (uniqueSides() == 1)
                return true;
            return false;
        }

        public bool isIsosceles()
        {
            if (uniqueSides() == 2)
                return true;
            return false;
        }
    }
}