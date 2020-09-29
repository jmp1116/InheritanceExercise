using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes
            Bird bird = new Bird();
            Reptile reptile = new Reptile();

            reptile.HardShells = true;
            reptile.HaveScales = true;
            reptile.LayEggs = true;
            reptile.LiveOnLand = true;
            reptile.NumberOfEyes = 2;
            reptile.GotHair = false;
            reptile.ColdBlooded = true;
            reptile.AreVertabrates = true;
            reptile.NumberOfExtremenies = 4;

            bird.FlySouth = true;
            bird.DoesFly = true;
            bird.GotHair = false;
            bird.HaveFeathers = true;
            bird.HollowBones = true;
            bird.LayEggs = true;
            bird.LiveOnLand = true;
            bird.NumberOfExtremenies = 4;
            bird.NumberOfEyes = 2;

            Console.WriteLine("Do Birds lay eggs?:", bird.LayEggs);
            Console.WriteLine("Do Reptiles lay eggs?:", reptile.LayEggs);
            Console.WriteLine("Do Birds live on land?:", bird.LiveOnLand);
            Console.WriteLine("Do Reptiles live on land?:", reptile.LiveOnLand);
            Console.WriteLine("How many eyes do birds have?:", bird.NumberOfEyes);
            Console.WriteLine("How many eyes do reptiles have?:", reptile.NumberOfEyes);
            Console.WriteLine("Do birds have hair?:", bird.GotHair);
            Console.WriteLine("Do reptiles have hair?:", reptile.GotHair);
            Console.WriteLine("Do birds fly?:", bird.DoesFly);

        }
    }
}
