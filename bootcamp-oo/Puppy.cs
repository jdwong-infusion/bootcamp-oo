using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootcamp_oo
{
    class Puppy : AdorableAnimal
    {
        public Puppy(string name) : base(name)
        {
        }

        public override string Express()
        {
            if (Happiness >= 1)
            {
                return string.Format("{0} wags tail", Name);
            }
            else
            {
                return string.Format("{0} wants more attention", Name);
            }                        
        }
    }
}
