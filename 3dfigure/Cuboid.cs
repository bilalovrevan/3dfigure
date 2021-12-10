using _3dFigures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3dfigure
{
    internal class Cuboid : FezaFiqurlari
    {
        /*
         * Duzbucaqlı Paralelepiped   
                 V = a x b x c;
                 S(tam) = 2 x (ab + bc + ac)
         */
        double hecm, stam;
        public double CuboidHecm()
        {
            hecm=Length*Width*Height;
            return hecm;
        }
        public double CuboidTamSahesi()
        {
            stam=2*(Width*Height+Height*Length+Width*Length);
            return stam;
        }
    }
}
