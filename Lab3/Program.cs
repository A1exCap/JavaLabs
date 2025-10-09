using System.Reflection.Metadata;
using System.Threading.Channels;

namespace Lab3
{
    internal class Program
    {
        static void Act(Bird bird)
        {
            bird.Move();
            bird.Eat();
        }

        static void Main(string[] args)
        {
            // lab 3, 4
            Act(new Eagle("The best eagle in the world!"));
            Console.WriteLine("----------------");
            Duck duck = new Duck("Cute duck!") {Name = "Grisha"};
            Act(duck);
            Console.WriteLine("-----------------");

            Eagle.amountOfEagles = 0;

            for (int i = 0; i < 5; i++)
            {
                new Eagle("asd");
                Console.WriteLine($"{Eagle.amountOfEagles} орлика");
            }

            Eagle eagle = new Eagle("Not a duck");

            Console.WriteLine(duck.Equals(eagle));

            eagle.Die();
            duck.FlyUp(10);

            IBird bird = new Duck("Interface Duck");
            bird.Die();
        }
    }
}
