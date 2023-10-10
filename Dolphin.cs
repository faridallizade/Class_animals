using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_animal
{
    internal class Dolphin : Animal
    {
        public Dolphin(string Name, int Age) : base(Name, Age)
        {

        }
        public Dolphin(string Breed, string Name, int Age) : base(Breed, Name, Age)
        {
            
        }
    }
}
