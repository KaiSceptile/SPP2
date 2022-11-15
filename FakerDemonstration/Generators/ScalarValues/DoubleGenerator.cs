using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerDemonstration.Generators.ScalarValues
{
    public class DoubleGenerator : Generator
    {
        public DoubleGenerator()
        {

        }

        public override object Generate(GeneratorContext context)
        {
            return Random.NextDouble();
        }

        public override string GetType()
        {
            return typeof(double).ToString();
        }
    }
}
