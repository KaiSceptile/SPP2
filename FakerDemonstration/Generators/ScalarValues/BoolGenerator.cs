using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerDemonstration.Generators.ScalarValues
{
    public class BoolGenerator : Generator
    {
        public BoolGenerator()
        {

        }
        public override object Generate(GeneratorContext context)
        {
            return Convert.ToBoolean(Random.Next(0, 1));
        }

        public override string GetType()
        {
            return typeof(bool).ToString();
        }
    }
}
