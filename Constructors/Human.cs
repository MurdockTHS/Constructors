using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class Human
    {
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I am {0} {1}. I have {2} eyes and {3} years old",firstName, lastName, eyeColor, age);
        }
    }
}
