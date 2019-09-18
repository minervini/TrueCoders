using System;
namespace TrueCoders
{
    public class People
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName{get; set; }
        public string HairColor { get; set; }

        public People(int age, string firstName, string lastName, string hairColor)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
            HairColor = hairColor;
        }

        public People()
        {

        }
    }
}
