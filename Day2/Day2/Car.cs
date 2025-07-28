using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Car
    {
       public int price { get; set; }
       public int number { get; set; }
       public void Move()
        {
            int speed = 100;
            number = speed;
            this.price = 10;
            this.Display();
        }
        public void Move(int x) { }
        public void Display() { Console.WriteLine($"Numebr: {this.number} \t Price: {price}"); }
    }
}
