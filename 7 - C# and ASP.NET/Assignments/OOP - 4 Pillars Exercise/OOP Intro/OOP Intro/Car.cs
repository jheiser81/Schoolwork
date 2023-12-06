using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Intro
//fields = variables
//methods = functions
//properties = getters and setters
//classes = contain all of the above
//objects = instances of a class
//constructors = methods that are called when an object is created
//encapsulation = hiding the implementation details of a class from the outside world
//abstraction = hiding the implementation details of a class from the outside world
{
    internal class Car //internal means that this class can only be accessed by other classes in the same namespace
    {
        //fields
        private int _year; //year is a private field, and can only be accessed by other methods in this class

        private int _speed;//underscore indicates a private variable, and helps with readability

        //Properties
        public string Make { get; set; } //get retrieves infomation. Make here is a property, and can be accessed by other classes in the same namespace

        //set defines a value for the property.
        public string Model { get; set; }

        public int Year // Year is a public property, and can be accessed by other classes in the same namespace
        {
            get { return _year; } //the return value of the get method is the value of the private field year
            set { _year = value; } //the value of the private field _year is set to the value of the property Year
        }

        //Constructor
        public Car(string make, string model, int year) //constructor is a method that is called when an object is created. It is used to initialize fields.
                                                        //Here we are initializing the fields make, model, and year
        {
            this.Make = make; //this keyword refers to the current object
            this.Model = model;
            this.Year = year;
        }

        //Methods
        public void Start()
        {
            Console.WriteLine($"Starting the {Make} {Model}...");
        }

        public void Stop()
        {
            Console.WriteLine($"Stopping the {Make} {Model}...");
        }

        public void Accelerate(int increment)
        {
            _speed += increment; //incrementing the speed by the value of the increment parameter. The value of increment is passed in when the method is called
            Console.WriteLine($"Accelerating the {Make} {Model}... Current speed {_speed} mph");
        }

        public void myDemo() //this is a method that is not part of the Car class, but is used to demonstrate the Car class
        {
            Car myCar = new Car("Toyota", "Camry", 2022); //this is an object of the Car class. It is created using the Car constructor
            myCar.Start(); //calling the Start method on the myCar object
            myCar.Accelerate(10); //calling the Accelerate method on the myCar object
        }
    }
}