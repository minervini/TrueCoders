using System;
using System.Collections.Generic;

namespace TrueCoders
{
    class Program
    {
        static void Main(string[] args)
        {
            var michael = new People();
            var daniel = new People();
            var stefano = new People();

            michael.Age = 32;
            michael.FirstName = "Michael";
            michael.LastName = "Doyle";
            michael.HairColor = "Brown";

            daniel.Age = 26;
            daniel.FirstName = "Daniel";
            daniel.LastName = "Walsh";
            daniel.HairColor = "Brownish";

            stefano.Age = 55;
            stefano.FirstName = "Stefano";
            stefano.LastName = "Minervini";
            stefano.HairColor = "Dark Brown";

            List<People> TrueCoders = new List<People>();

            TrueCoders.Add(michael);
            TrueCoders.Add(daniel);
            TrueCoders.Add(stefano);

            foreach (var person in TrueCoders)
            {
                Console.WriteLine($"Age: (Age), Name: (FirstName) (LastName), Hair: (HairColor)");
            }

        }
    }
}
