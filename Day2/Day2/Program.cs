namespace Day2
{
    internal class Program
    {
        static void Test(Car car) { 
            int x = 3;
            car.price = 9999;
            car.Display();
        }
        static void Main(string[] args)
        {
           Car c = new Car();
            c.Move();
            c.Display();

            //int num = 5; 
           
            c.price = 1999;
            c.Display();
            Console.WriteLine(c.price);
            Car c2 = c;
            c2.price = 3333;
            Console.WriteLine(c.price);
            c = new Car();
            c.price = 5555;
            Test(c);
            Console.WriteLine(c.price);
            c.Display();
            c2.Display();

            Employee e1 = new Employee(1000);
            Employee e2 = new Employee(1001, 2000);
            e1.Display();
            e2.Display();

            Point p1 = new Point(5);
            Point p2 = new Point(10, 15);
            Point p3 = new Point(1, 2, 3);
            p1.Display();
            p2.Display();
            p3.Display();
        }
    }
}
