using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootcamp_oo
{
    public abstract class AdorableAnimal
    {
        public int Happiness { get; private set; }
        public string Name { get; private set; }

        public AdorableAnimal(string name)
        {
            Name = name;
            Happiness = 0;
        }
        
        public void Play()
        {
            Happiness++;
        }

        public abstract string Express();
    }
}