using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using area_and_the_circumference_of_a_circle;


namespace VizMathFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            area_and_the_circumference_of_a_circleClass mathFunctions = new area_and_the_circumference_of_a_circleClass();

                Console.WriteLine($"{mathFunctions.Cube(Math.PI):F3}");
        }
    }
}
