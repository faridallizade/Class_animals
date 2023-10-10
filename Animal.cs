using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Class_animal
{
    public class Animal
    {
        public string Name;
        public string Breed;
        private int _age = 0;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("The age must be bigger than zero");
                    
                }
                else
                     _age = value;
            }
        }

        public Animal(string name, int Age)
        {
            this.Name = name;
            this.Age = Age;
        }
        public Animal(string Breed, string name, int Age) : this(name, Age)
        {
            this.Breed = Breed;
        }
        public  void GetInfo()
        {
            Console.WriteLine($"This animal's breed is {Breed}, name is {Name} and age is {Age}.");

        }
    }
}
