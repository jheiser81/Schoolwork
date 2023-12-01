using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_OOP
{
    internal class Cat
    {
        public string _name;
        public int _age;
        public string _breed;
        public string _mission;

    public Cat(string name, int age, string breed, string mission)
    {
        _name = name;
        _age = age;
        _breed = breed;
        _mission = mission;
    }

    public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
    public string Breed
        {
            get { return _breed; }
            set { _breed = value;
            }
        }
    public string Mission
        {
            get { return _mission; }
            set { _mission = value; }
        }

        public string Meow()
        {return ("Meow");}
       
        public string Purr()
        {return ("Purr");}
            
        public string Hiss()
        {return ("Hisssss");}
    }
}
