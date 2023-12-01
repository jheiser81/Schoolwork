using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_OOP
{
    internal class Dog
    {
        //fields, set to private for encapsulation

        private string _name; //setting _name as a string and private field
        private int _age; //setting _age as an int and private field
        //private string _breed; //setting _breed as a string and private field

        // Constructor (overloaded)
        public Dog(string name, int age, string breed) //setting the constructor to take in name, age, and breed as parameters
        {
            _name = name; //this sets the fields to the parameters
            _age = age;
            Breed = breed;
        }

        //Properties / Getters and Setters
        //Properties are a combination of a field and a method.
        //Properties act like a variable, but they have a getter and setter.

        //Traditional getters and setters for name field
        public string GetName() //this is the getter as a method
        {
            return _name;
        }

        public void SetName(string name) //this is the setter as a method
        {
            _name = name;
        }

        //verified getters and setters for age field. This uses properties instead of methods.
        //This is the preferred way to do it ???
        public int Age //this is the property
        {
            get { return _age; } //this is the getter
            set 
            {
                if (value < 0 || value > 25) //this is the setter
                {
                    value = 0; 
                }
                else
                {
                    _age = value;
                    //throw new ArgumentException("You input an incorrect value"); 
                    //this is an example of an exception for an incorrect value, used for error handling
                }
            }
        }

        //Shorthand getter and setter for Breed field. This uses methods but is a shorthand way to do it.
        public string Breed { get; set; }

        //Methods
        public string Bark() //method to return "Woof!"
        {
            return "Woof!";
        }

        public string WagTail() //method to return "Tail wagging..."
        {
            return "Tail wagging...";
        }
    }
}