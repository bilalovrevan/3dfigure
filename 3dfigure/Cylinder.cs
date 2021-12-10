using _3dFigures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3dfigure
{
    internal class Cylinder :FezaFiqurlari
    {
        /*
         * 
             Silindr 
             V = pi x r^2 x h
             S(ot) = pi x r^2;
             S(tam) = 2 x S(ot)  + 2 x pi x r x h
         */
        double hecm;
        public double CylinderHecm()
        {
            hecm = Math.Round(Math.PI * Math.Pow(Radius, 2) * Height,2);
            return hecm;
        }
        double stam;
        public double CylinderTamSahe()
        {
            stam = Math.Round(2 * OturacaqSahesi() + 2 * Math.PI * Radius * Height,2);
            return stam;
        }
    }
}
