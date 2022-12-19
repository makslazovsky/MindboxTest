using MindboxTest.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTest.Figures
{
    public class Circle : IFigure
    {
        private double r;
        public Circle(double Radius)
        {
            r = Radius;
            Validate();
        }
        public void Validate()
        {
            if (r < 0)
            {
                throw new ArgumentException("Радиус не может быть меньше нуля");
            }
        }

        public double CalcSquare()
        { 
            return Math.PI * Math.Pow(r, 2);   
        }
    }
}
