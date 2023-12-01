using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public abstract string Drive();
        public void Start()
        {
            MessageBox.Show("Vehicle started.");
        }
        public void Stop()
        {
            MessageBox.Show("Vehicle stopped.");
        }
    }



}