using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_OOP
{
    internal class Snake : Animal
    {
        public int _length { get; set; }
        public bool _venomous { get; set; }

        public Snake(string name, int age, string breed, int length, string species, bool venomous) : base(name, age, breed, species)
        {
            this._length = length;
            this._venomous = venomous;

            if (_venomous == true)
            {
                MessageBox.Show($"{base.Name} is venomous!");
            }
            else
            {
                MessageBox.Show($"{base.Name} is not venomous.");
            }
        }

        public string Hiss()
        { return ("Hisssss"); }

        public override string Eating()
        { return ($" is eating a mouse. Gulp!"); }

        public override string Sleeping()
        { return (" is hibernating. Zzzzzz Zzzzzzzz Zzzzzzz"); }
    }
}