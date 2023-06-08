using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_OOP
{
    public abstract class Animal
    {
        private string _name;
        private int _age;
        public string _breed;
        protected readonly string _species;

        public Animal(string name, int age, string breed, string species)
        {
            _name = name;
            _age = age;
            _breed = breed;
            _species = species;
        }

        public string Name
        {
            get { return _name; }
            //set { _name = value; } //I dont seem to need these setters???
        }

        public int Age
        {
            get { return _age; }
            //set { _age = value; }
        }

        public string Breed
        {
            get { return _breed; }
            //set {_breed = value;}
        }

        public string Species
        {
            get { return _species; }
        }

        public virtual string Eating() //added the virtual keyword so that it can be overridden in the other classes
        { return ("The animal is eating."); }

        public abstract string Sleeping(); //removed the implementation of the method here, so that it can be implemented in the other classes

        public string Aging()
        {
            _age++; //incrementing the age of the animal
            return ($" is now {_age} years old.");
        }
    }
}