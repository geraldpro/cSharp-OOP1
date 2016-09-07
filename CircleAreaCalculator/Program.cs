using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAreaCalculator
{
    class circle
    {
        int radius1; // Member Varialble

        public int acceptparameters()
        {
            Console.Write("Enter radius value and press enter to run : \t");
            radius1 = Convert.ToInt32(Console.ReadLine()); 
            return radius1;
        }
       
        public double Area(int radius)
        {
            double area;
            area = Math.PI * radius * radius;
            return area;
        }

        static void Main(string[] args)
        {
            int radius;
            double area;
            circle c = new circle();
            radius = c.acceptparameters();
            area = c.Area(radius);
            Console.WriteLine(area);
            Console.ReadLine();

        }        
    }

        
}
