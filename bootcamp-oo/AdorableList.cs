using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootcamp_oo
{
    public class AdorableList<T> : List<T>
    {
        public void PlayAll()
        {
            foreach (T cuteThing in this.ToList())
            {
                if (cuteThing.GetType().IsSubclassOf(typeof(AdorableAnimal)))
                {
                    var animal = cuteThing as AdorableAnimal;
                    animal.Play();
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T cuteThing in this.ToList())
            {
                string output = cuteThing.ToString();

                if (cuteThing.GetType().IsSubclassOf(typeof(AdorableAnimal)))
                {
                    var animal = cuteThing as AdorableAnimal;
                    output = string.Format("Name: {0}\nHappiness: {1}\nExpression:{2}\n", animal.Name, animal.Happiness, animal.Express());
                }
                
                sb.AppendFormat("{0}\n", output);
            }
            return sb.ToString();
        }
    }
}
