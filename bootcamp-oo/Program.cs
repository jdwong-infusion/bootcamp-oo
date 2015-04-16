using System;

namespace bootcamp_oo
{
    class Program
    {
        static void Main(string[] args)
        {
            var adorableList = new AdorableList<AdorableAnimal>();
            Puppy rover = new Puppy("Rover");
            adorableList.Add(rover);

            Console.WriteLine(adorableList.ToString());

            adorableList.PlayAll();

            Console.WriteLine(adorableList.ToString());

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine(); // waits for line of input before closing
        }
    }
}
