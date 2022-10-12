using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_CreateDLL
{
    [Serializable]
    class Dlltrs
    {
        //площадь треугольника
        static double triangle(double A, double B, double C)
        {
            double p, S;
            p = (A + B + C) / 2;
            S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return S;
        }
        //площадь прямоугольника
        static double rectangle(int sideA, int sideB)
        {
            int area;
            area = sideA * sideB;
            return area;
        }
        //площадь квадрата
        static double square(int side)
        {
            int area;
            area = side * side;
            return area;
        }
    }
}
