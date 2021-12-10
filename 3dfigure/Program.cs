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
            Cone cone = new Cone();
        l1:
            try
            {
                Console.Write("Konusun radiusunu daxil edin: ");
                cone.Radius = Convert.ToDouble(Console.ReadLine());
                Console.Write("Konusun hundurluyunu daxil edin: ");
                cone.Height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Konusun oturaciqin sahesi: {cone.OturacaqSahesi()} ");
                Console.WriteLine($"Konusun Hecmi: {cone.ConeHecm()} ");
            }
            catch (Exception)
            {

                Console.WriteLine("ededleri duzgun daxil edin: ");
                goto l1;
            }

            Cylinder cylinder = new Cylinder();
            l2:
            try
            {
                Console.Write("Slindrin radiusunu daxil edin: ");
                cylinder.Radius = Convert.ToDouble(Console.ReadLine());
                Console.Write("Slindrin hundurluyunu daxil edin: ");
                cylinder.Height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Slindrin oturaciqin sahesi: {cylinder.OturacaqSahesi()} ");
                Console.WriteLine($"Slindrin Hecmi: {cylinder.CylinderHecm()} ");
            }
            catch (Exception)
            {

                Console.WriteLine("ededleri duzgun daxil edin: "); 
                goto l2;
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
                Console.WriteLine($"Paralelpipedin tam sahesi: {cuboid.CuboidTamSahesi()} ");
                Console.WriteLine($"Paralelpipedin hecmi: {cuboid.CuboidHecm()} ");
            }
            catch (Exception)
            {

                Console.WriteLine("ededleri duzgun daxil edin: ");
                goto l3;
            }

        }
    }
}
