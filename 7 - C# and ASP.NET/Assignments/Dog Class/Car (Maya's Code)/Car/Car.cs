using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class Car : Vehicle
    {
        //fields = variables
        //methods = functions
        //properties = fields + getters && setters
        //Classes contian all of the above
        private int _age;
        private int VIN;
        public int GetVIN()
        {
            return VIN;
        }
        public void SetVIN(int value)
        {
            VIN = value;
        }
        private bool restoration = false;
        //public int VIN { get; set; }
        public int NumDoors { get; }//this get is a method, and the set is a method but they are more implyed then explicitly written
        //properties are a wrapper for a field or are a field combined with getters and setters
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 40 && restoration == false)
                {
                    _age = 0;
                }
                else if (value < 0)
                {
                    _age = 0;
                }
                else
                {
                    _age = value;
                }
            }
        }

        public Car(string make, string model, int year, int numDoors, int age) : base(make, model, year)
        {
            if (numDoors <= 0)
            {
                this.NumDoors = 2;
            }
            else
            {
                this.NumDoors = numDoors;
            }
            this._age = age;
        }
        public override string Drive()
        {
            return "Car is driving.";
        }
        public void Brake()
        {
            MessageBox.Show("Car is braking.");
        }
    }
}
