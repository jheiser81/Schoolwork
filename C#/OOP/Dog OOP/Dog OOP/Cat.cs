using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_OOP
{
    internal class Cat : Animal
    {
        public string _mission { get; set; }
        public string _indifference { get; set; }

        public Cat(string name, int age, string breed, string species, string mission, string indifference) : base(name, age, breed, species)
        {
            this._mission = mission;
            _indifference = indifference;
        }

        #region old code

        //public Cat(string name, int age, string breed, string mission)
        //{
        //    _name = name;
        //    _age = age;
        //    _breed = breed;
        //    _mission = mission;
        //}

        //    public string Name
        //    {
        //        get { return _name; }
        //        set { _name = value; }
        //    }
        //public int Age
        //    {
        //        get { return _age; }
        //        set { _age = value; }
        //    }
        //public string Breed
        //    {
        //        get { return _breed; }
        //        set { _breed = value;
        //        }
        //    }
        //public string Mission
        //    {
        //        get { return _mission; }
        //        set { _mission = value; }
        //    }

        #endregion old code

        public string Meow()
        { return ("Meow"); }

        public string Purr()
        { return ("Purr"); }

        public string Hiss()
        { return ("Hisssss"); }

        public string SitsOnKeyboard()
        { return (" is sitting on your keyboard."); }

        public override string Eating() //the method is overriden from the Animal class
        { return (" is daintily eating. Nom Nom."); }

        public override string Sleeping() //the method is overriden from the Animal class
        { return (" is sleeping. Zzzzzz"); }
    }
}