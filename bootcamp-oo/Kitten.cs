using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootcamp_oo
{
    class Kitten : AdorableAnimal
    {
        public Kitten (string name) : base(name)
        {
            
        }

        public override string Express()
        {
            if (Happiness >= 3)
            {
                return string.Format("{0} purrs", Name);
            }
            else
            {
                return string.Format("{0} could care less about you", Name);
            }
            
        }
    }
}
