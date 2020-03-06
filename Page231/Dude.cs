using System;
using System.Collections.Generic;
using System.Text;

namespace Page231
{
    class Dude
    {
        // This pretty much allows you to put in optional parameters that are not compile-time constants.
        // I you try to do this with an optional parameter, you get "Default parameter value for id" must be compile-time contant
        //public Dude(string name, Guid id = Guid.NewGuid())
        //{

        //}
        // If only the name is passed, use the referenced constructor but set id to Guid.NewGuid()
        public Dude(string name) : this(name, Guid.NewGuid())
        {
            IsRandomID = true;
        }
        // Main constructor
        public Dude(string name, Guid id)
        {
            Name = name;
            ID = id;
            IsRandomID = false;
        }

        public string Name { get; set; }
        public Guid ID { get; set; }
        public bool IsRandomID { get; set; }

        public void Speak()
        {
            Console.WriteLine($"'YOOooooooo... My name is {Name}'");
            System.Threading.Thread.Sleep(1000);

            if (IsRandomID) Console.WriteLine($"\t'I was built with the chained constructor'");
            else Console.WriteLine($"\t'I was NOT built with the chained constructor'");

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"\t'My ID is {ID}'");
        }
    }
}
