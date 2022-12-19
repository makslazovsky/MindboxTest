using MindboxTest.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTest.Figures
{
    public class Triangle : IFigure
    {
        double a;
        double b;
        double c;
        public bool IsRightAngle;
        public Triangle(double A, double B, double C)
        {
            a=A;
            b=B;
            c=C;
            Validate();
            IsRightAngle = CalculateRightAngle();
        }

        private bool CalculateRightAngle()
        {
            if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a))
                return true;
            else 
                return false;
        }

        public void Validate()
        {
            if (!(a < b + c) || !(b < a + c) || !(c < a + b))
            {
                throw new ArgumentException("Треугольник с заданными сторонами не существует");
            }
        }        
        
        public double CalcSquare()
        {
            var p = 0.5 * (a+b+c);
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
    }
}
