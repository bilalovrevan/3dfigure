using _3dfigure;
using System;

namespace _3dFigures
{
    internal class Program
    {


        public static void Main(string[] args)
        {
                            /*
                             * Konus
                 S(ot) = pi x r^2
                 V = S(ot) x H / 3


                 Silindr 
                 V = pi x r^2 x l
                 S(ot) = pi x r^2;
                 S(tam) = 2 x S(ot)  + 2 x pi x r x l


                 Duzbucaqlı Paralelepiped   
                 V = a x b x c;
                 S(tam) = 2 x (ab + bc + ac)
             * */
            Cylinder cylinder = new Cylinder();
            l1:
            try
            {
                Console.Write("Slindrin radiusunu daxil edin: ");
                cylinder.Radius = Convert.ToDouble(Console.ReadLine());
                Console.Write("Slindrin hundurluyunu daxil edin: ");
                cylinder.Height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Slindrin oturaciqin sahesi: {cylinder.OturacaqSahesi()} ");
                Console.WriteLine($"Slindrin oturaciqin sahesi: {cylinder.CylinderHecm()} ");
            }
            catch (Exception)
            {

                Console.WriteLine("ededleri duzgun daxil edin: "); 
                goto l1;
            }
            Cuboid cuboid = new Cuboid();
            l3:
            try
            {
                Console.Write("Paralelpipedin hundurluyunu daxil edin: ");
                cuboid.Height = Convert.ToDouble(Console.ReadLine());
                Console.Write("Paralelpipedin enini daxil edin: ");
                cuboid.Width = Convert.ToDouble(Console.ReadLine());
                Console.Write("Paralelpipedin uzunluqu daxil edin: ");
                cuboid.Length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Paralelpipedin oturaciqin sahesi: {cuboid.OturacaqSahesi()} ");
                Console.WriteLine($"Paralelpipedin oturaciqin sahesi: {cuboid.CuboidHecm()} ");
            }
            catch (Exception)
            {

                Console.WriteLine("ededleri duzgun daxil edin: ");
                goto l3;
            }

        }
    }
}
