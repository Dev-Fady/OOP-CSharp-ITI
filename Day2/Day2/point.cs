using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Point
    {
        public int x,y,z;
       public Point(int x):this(x,10, 20) // Default y to 10 and z to 20 if not provided
        {
            //this.x = x;
            //this.y = 10; // Default y to 10 if not provided
            //this.z = 20; // Default z to 20 if not provided
        }
        public Point(int y, int z):this(10, y, z) // Default x to 10 if not provided
        {
            //this.x = 10;// Default x to 10 if not provided
            //this.y = y;
            //this.z = z; 
        }
       
        public Point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void Display()
        {
            Console.WriteLine($"Point Coordinates: x = {x}, y = {y}, z = {z}");
        }
    }
}
