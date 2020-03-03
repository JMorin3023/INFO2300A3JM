using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3ExampleCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Ball ball = new Ball();

            Console.WriteLine("What is the radius of your circle?");
            ball.Radius = Convert.ToInt32(Console.ReadLine());
            ball.Circumference = ball.Radius * 2;

            Console.WriteLine(ball.Circumference);
            Console.ReadKey();
        }
    }
}
