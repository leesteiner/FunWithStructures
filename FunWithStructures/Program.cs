using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** A First Look at Structures *****\n");

            //Create an initial point.
            Point myPoint;
            myPoint.x = 349;
            myPoint.y = 76;
            myPoint.Display();

            //Adjust the x and y values.
            myPoint.Increment();
            myPoint.Display();
            Console.ReadLine();

            Point p2 = new Point(50, 60);
            p2.Display();
        }


        struct Point
        {
            //Fields of the structure
            public int x;
            public int y;

            //Add 1 to the (x,y) position
            public void Increment()
            {
                x++;
                y++;
            }

            //Subtract 1 from the (x,y) position
            public void Decrement()
            {
                x--;
                y--;
            }

            //Display the current position.
            public void Display()
            {
                Console.WriteLine($"X = {x}, y= {y}");
            }       

            public Point(int XPos, int YPos)
            {
                x = XPos;
                y = YPos;
            }
        }
    }
}
