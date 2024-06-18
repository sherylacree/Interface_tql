using System.ComponentModel.Design;
using System.Net.Cache;
using System.Security.Principal;

namespace Interface_tql;

internal class Program {

    static void Main(string[] args) {
        //create classes for Dogs, Cat, Birds

        Dog dog1 = new Dog { Breed = "German Shepherd", Age = 2, Weight = 30 };
        Dog dog2 = new Dog { Breed = "Collie", Age = 1, Weight = 20 };

        Cat cat1 = new Cat { Weight = 10, Age = 3, Color = "Grey" };
        Cat cat2 = new Cat { Weight = 7, Age = 2, Color = "Orange" };

        Bird bird1 = new Bird { Type = "Parrot", Color = "Rainbow", CanFly = false };
        Bird bird2 = new Bird { Type = "Eagle", Color = "Brown", CanFly = true };

        List<IPet> pets = new List<IPet>();
        pets.AddRange(new IPet[] { dog1, dog2, cat1, cat2, bird1, bird2 });

        foreach (var pet in pets) {
            if (pet is Dog) {
                var aDog = pet as Dog;
                if (aDog is not null) {
                    Console.WriteLine($"Breed is {aDog.Breed}, Age is {aDog.Age}, Weight is {aDog.Weight}");
                }
            }
            var aCat = pet as Cat;
            if (aCat is not null) {
                Console.WriteLine($"Color is {aCat.Color}, Age is {aCat.Age}, Weight is {aCat.Weight}");
            }

            var aBird = pet as Bird;
            if (aBird is not null) {
                Console.WriteLine($"Type is {aBird.Type}, Color is {aBird.Color}, Can Fly is {aBird.CanFly}");
            }

        }
    }
}

    
