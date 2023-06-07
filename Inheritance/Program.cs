using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var eagle = new Bird();


            eagle.LegNumber = 2;
            eagle.Color = "Brown and white, unless they're from Philadelphia.";
            eagle.IsPet = false;
            eagle.Name = "Haliaeetus Leucocephalus AKA Bald Eagle.";

            eagle.Habitat = "Typically found near large bodies of water and associated grasslands, marshes, rivers and streams.";
            eagle.Diet = "Waterfowl, turtles, rabbits, snakes, and other small animals.";
            eagle.IsNocturnal = false;
            eagle.Endangered = "Were endangered, but have been removed from endangered list!";

            Console.WriteLine($"Number of legs: {eagle.LegNumber} \n" +
                $"Color: {eagle.Color} \n" +
                $"Can it be a pet? {eagle.IsPet} \n" +
                $"Name: {eagle.Name}");

            Console.WriteLine("More:");

            Console.WriteLine($"Habitat: {eagle.Habitat} \n" +
                $"Feeds on: {eagle.Diet} \n" +
                $"Is it nocturnal? {eagle.IsNocturnal} \n" +
                $"Endangered status: {eagle.Endangered}");


            var dragon = new Reptile();

            dragon.LegNumber = 4;
            dragon.Color = "Mostly black, green or gray with patches of yellow-brown or white.";
            dragon.IsPet = false;
            dragon.Name = "Varanus Komodoensis AKA Komodo Dragon.";

            dragon.Lifespan = "30 years, but still being studied.";
            dragon.Poison = true;
            dragon.Length = "8.5 ft";
            dragon.Aggresiveness = "Very territorial and not friendly. Can attack even when unprovoked. Stay clear!";

            Console.WriteLine($"Number of legs: {dragon.LegNumber} \n" +
                $"Color: {dragon.Color} \n" +
                $"Can it be a pet? {dragon.IsPet} \n" +
                $"Name: {dragon.Name}");

            Console.WriteLine("More:");

            Console.WriteLine($"Lifespan: {dragon.Lifespan} \n" +
                $"Poisonous: {dragon.Poison} \n" +
                $"How long do can they get? {dragon.Length} \n" +
                $"Danger level: {dragon.Aggresiveness}");





        }
    }
}
