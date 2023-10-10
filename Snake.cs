using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_animal
{
    public class Snake : Animal
    {
        private bool _isPoisonous;
        public bool isPoisonous
        {
            get
            {
                return _isPoisonous;
            }
            set
            {
                if (value)
                {
                    Console.WriteLine("Poisonous snake don't acceptable\n");
                }
                else
                {
                    _isPoisonous = value;
                }
            }
        }

        public Snake(string Name, int Age) : base(Name, Age)
        {

        }
        public Snake(string Breed, string Name, int Age,bool isPoisonous) : base(Breed, Name, Age)
        {
            this.isPoisonous=isPoisonous;
        }
        
    }
}
