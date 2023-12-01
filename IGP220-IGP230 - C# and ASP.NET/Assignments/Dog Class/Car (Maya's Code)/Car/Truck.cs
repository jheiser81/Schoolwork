using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class Truck : Vehicle
    {
        public int NumWheels { get; set; }
        public Truck(string make, string model, int year, int numWheels) : base(make, model, year)
        {
            this.NumWheels = numWheels;
        }
        public override string Drive()
        {
            return "Truck is driving.";
        }
        public void Haul()
        {
            MessageBox.Show("Truck is hauling.");
        }
    }
}
