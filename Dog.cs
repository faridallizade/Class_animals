using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_animal
{
    internal class Dog : Animal 
    {
        public Dog(string Name, int Age) : base(Name, Age)
        {

        }
        public Dog(string Breed,string Name,int Age) : base(Breed,Name,Age)
        {
            
        }
    }
}
