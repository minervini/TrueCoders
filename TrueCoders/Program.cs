using System;
using System.Collections.Generic;

namespace TrueCoders
{
    class Program
    {
        static void Main(string[] args)
        {
            var michaelPeople = new People();
            var danielPeople = new People();
            var stefanoPeople = new People();

            michaelPeople.Age = 32;
            michaelPeople.FirstName = "Michael";
            michaelPeople.LastName = "Doyle";
            michaelPeople.HairColor = "Brown";

            danielPeople.Age = 26;
            danielPeople.FirstName = "Daniel";
            danielPeople.LastName = "Walsh";
            danielPeople.HairColor = "Brownish";

            stefanoPeople.Age = 55;
            stefanoPeople.FirstName = "Stefano";
            stefanoPeople.LastName = "Minervini";
            stefanoPeople.HairColor = "Dark Brown";

            var bobPeople = new People(22, "Bobby", "Jones", "Blonde");

            List<People> TrueCoders = new List<People>();

            TrueCoders.Add(michaelPeople);
            TrueCoders.Add(danielPeople);
            TrueCoders.Add(stefanoPeople);
            TrueCoders.Add(bobPeople);

            foreach (var person in TrueCoders)
            {
                Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Age: {person.Age}, Hair: {person.HairColor}");
            }

        }
    }
}
