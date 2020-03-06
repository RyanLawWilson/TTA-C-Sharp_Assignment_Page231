using System;

namespace Page231
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("This is some text that cannot be changed: ");
            const string TEXT = "This cannot be changed";
            Console.WriteLine(TEXT);

            System.Threading.Thread.Sleep(1000);

            var randomMath = Math.PI * Math.Sqrt(Math.Abs(Math.Sin(-6.239464)));      // Whatever this output is will be put in this variable.
            Console.WriteLine($"\nThis is a variable using var keyword.  It's value is: {randomMath:F2}");

            System.Threading.Thread.Sleep(1000);

            Dude dude1 = new Dude("Kyle");
            Console.Write("Creating a dude....  Dude says: ");
            dude1.Speak();

            System.Threading.Thread.Sleep(2000);

            Dude dude2 = new Dude("Bobby", new Guid("cbb33efa-b350-473f-9c2d-417ee8ff2f13"));
            Console.Write("Creating another dude....  Dude says: ");
            dude2.Speak();

            System.Threading.Thread.Sleep(1000);

            Console.ReadLine();
        }
    }
}
