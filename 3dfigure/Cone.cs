using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3dFigures
{
    internal class Cone : FezaFiqurlari
    {
        /* 
             * Konus
             S(ot) = pi x r^2
             V = S(ot) x H / 3
             */
        double hecm;
        public double ConeHecm()
        {
            hecm = OturacaqSahesi() * Height / 3;
            return hecm;
        }
        
     
    
    }
}
