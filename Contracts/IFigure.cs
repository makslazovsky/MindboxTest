using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTest.Contracts
{
    public interface IFigure
    {
        public void Validate();

        public double CalcSquare();
    }
}
