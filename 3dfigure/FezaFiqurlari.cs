using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3dFigures
{
    internal class FezaFiqurlari
    {
      
        double radius;
        double height;
        double width;
        double length;
        public double Radius { get { return radius; } 
            set
            {
                if (value<=0)
                {
                    throw new Exception("Radiusu duzgun daxil edin");
                }
                radius = value;
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("hundurluyu duzgun daxil edin");
                }
                height = value;
            }
        }
        public double Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("eni duzgun daxil edin");
                }
                width = value;
            }
        }
        public double Length
        {
            get { return length; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("uzunluqu duzgun daxil edin");
                }
                length = value;
            }
        }

        public  double OturacaqSahesi()
        {
           
            double soturacaq = Math.Round(Math.PI, 2) * Math.Pow(radius, 2);
            return soturacaq;
        }
    }
}
